/*
 * MIT License
 *Copyright (c) 2021 易开元(EOM)

 *Permission is hereby granted, free of charge, to any person obtaining a copy
 *of this software and associated documentation files (the "Software"), to deal
 *in the Software without restriction, including without limitation the rights
 *to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 *copies of the Software, and to permit persons to whom the Software is
 *furnished to do so, subject to the following conditions:

 *The above copyright notice and this permission notice shall be included in all
 *copies or substantial portions of the Software.

 *THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 *IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 *FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 *AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 *LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 *OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 *SOFTWARE.
 *
 */
using EOM.TSHotelManager.Common;
using EOM.TSHotelManager.Common.Core;
using Newtonsoft.Json;
using Sunny.UI;
using System.Diagnostics;
using System.Reflection;

namespace EOM.TSHotelManager.FormUI
{
    public partial class FrmLoading : UIForm
    {
        private string CurrentVersion => ApplicationUtil.GetApplicationVersion().ToString();
        private string GithubRepoUrl = "https://api.github.com/repos/easy-open-meta/TopskyHotelManagerSystem/releases/latest";
        private string FileName { get; set; }
        private string CurrentExecutablePath => Application.ExecutablePath;
        private string CurrentExecutableName => Path.GetFileName(CurrentExecutablePath);
        private string FallbackUrl = "https://pan.gkhive.com/TS%E9%85%92%E5%BA%97%E7%AE%A1%E7%90%86%E7%B3%BB%E7%BB%9F%E7%89%88%E6%9C%AC%E5%BA%93";

        private ProgressBar progressBar;

        public FrmLoading()
        {
            InitializeComponent();
            progressBar = new ProgressBar
            {
                Minimum = 0,
                Maximum = 100,
                Dock = DockStyle.Top
            };
            this.Controls.Add(progressBar);
        }

        private async void CheckForUpdate()
        {
            try
            {
                using var client = new HttpClient { Timeout = TimeSpan.FromSeconds(10) };
                client.DefaultRequestHeaders.Add("User-Agent", await GetDefaultUserAgentAsync());
                var response = await client.GetAsync(GithubRepoUrl);

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var release = JsonConvert.DeserializeObject<GitHubRelease>(result);

                    var latestVersion = release!.TagName.Replace("v", "", StringComparison.OrdinalIgnoreCase);
                    var currentVersion = CurrentVersion.Replace("v", "", StringComparison.OrdinalIgnoreCase);

                    var versionCompareResult = string.Compare(latestVersion, currentVersion, StringComparison.OrdinalIgnoreCase);

                    if (versionCompareResult > 0)
                    {
                        var updateAsset = release.Assets.FirstOrDefault(a => a.Name.EndsWith(".exe", StringComparison.OrdinalIgnoreCase));
                        if (updateAsset != null)
                        {
                            FileName = $"{updateAsset.Name}_{DateTime.Now.ToString("yyyyMMddHHmmsss")}";
                            var isUpdated = await DownloadAndInstallUpdate(updateAsset.BrowserDownloadUrl, updateAsset.Name, new Progress<double>(ReportProgress));
                            if (isUpdated)
                            {
                                UIMessageBox.ShowWarning("旧版已停止使用，稍后将自动下载最新发行版！");
                                ExitApplication();
                            }
                            else
                            {
                                UIMessageBox.ShowWarning("更新失败，请手动下载最新版本。");
                            }
                        }
                        else
                        {
                            UIMessageBox.ShowWarning("最新版本中未找到可更新的 .exe 文件。");
                        }
                    }
                    else
                    {
                        UIMessageBox.ShowSuccess("当前已为最新版本，无需更新！");
                        await Task.Run(() => threadPro());
                    }
                }
                else
                {
                    UIMessageBox.Show("无法获取最新版本信息，请检查网络连接。");
                    ExitApplication();
                }
            }
            catch (OperationCanceledException)
            {
                UIMessageBox.Show("网络连接超时，无法检查更新。即将跳转到网盘版本库");
                OpenFallbackUrl();
                ExitApplication();
            }
            catch (Exception ex)
            {
                UIMessageBox.Show($"检查更新时发生错误: {ex.Message}");
            }
        }

        private async Task<string> GetDefaultUserAgentAsync()
        {
            using var webBrowser = new WebBrowser();
            webBrowser.ScriptErrorsSuppressed = true;
            var tcs = new TaskCompletionSource<bool>();
            webBrowser.DocumentCompleted += (sender, e) => tcs.TrySetResult(true);

            webBrowser.Navigate(FallbackUrl);

            await tcs.Task;

            string? userAgent = webBrowser.Document?.InvokeScript("eval", new object[] { "navigator.userAgent;" })?.ToString();
            return userAgent ?? string.Empty;
        }

        private async Task<bool> DownloadAndInstallUpdate(string downloadUrl, string fileName, IProgress<double> progress)
        {
            try
            {
                using var client = new HttpClient { Timeout = TimeSpan.FromSeconds(10) };
                var tempFilePath = Path.Combine(Path.GetTempPath(), fileName);

                var response = await client.GetAsync(downloadUrl, HttpCompletionOption.ResponseHeadersRead);
                var contentLength = response.Content.Headers.ContentLength;

                using var fileStream = new FileStream(tempFilePath, FileMode.Create, FileAccess.Write, FileShare.None);
                using var stream = await response.Content.ReadAsStreamAsync();

                var totalBytesRead = 0L;
                var buffer = new byte[8192];
                int bytesRead;

                while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                {
                    await fileStream.WriteAsync(buffer, 0, bytesRead);
                    totalBytesRead += bytesRead;

                    if (contentLength.HasValue)
                    {
                        var progressPercentage = (double)totalBytesRead / contentLength.Value * 100;
                        progress.Report(progressPercentage);
                    }
                }

                Process.Start(new ProcessStartInfo
                {
                    FileName = "explorer.exe",
                    Arguments = $"/select, \"{tempFilePath}\"",
                    UseShellExecute = false,
                    CreateNoWindow = true
                });

                ExitApplication();

                return true;
            }
            catch (OperationCanceledException)
            {
                UIMessageBox.Show("网络连接超时，无法下载更新。");
                OpenFallbackUrl();
            }
            catch (Exception ex)
            {
                UIMessageBox.Show($"下载更新时发生错误: {ex.Message}");
                OpenFallbackUrl();
            }
            return false;
        }

        private void ReportProgress(double percentage)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<double>(ReportProgress), percentage);
            }
            else
            {
                progressBar.Value = (int)percentage;
            }
        }

        private void OpenFallbackUrl()
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = FallbackUrl,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                UIMessageBox.Show($"打开浏览器时发生错误: {ex.Message}");
            }
        }

        private void FrmLoading_Load(object sender, EventArgs e)
        {
            lblSoftwareVersion.Text = ApplicationUtil.GetApplicationVersion().ToString();
            CheckForUpdate();
        }

        public void threadPro()
        {
            System.Windows.Forms.MethodInvoker MethInvo = new System.Windows.Forms.MethodInvoker(ShowLoginForm);
            BeginInvoke(MethInvo);
        }

        public void ShowLoginForm()
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog(this);
            this.Close();
        }

        private void FrmLoading_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void ExitApplication()
        {
            Application.Exit();
        }

        public class GitHubRelease
        {
            [JsonProperty("tag_name")]
            public string TagName { get; set; }

            [JsonProperty("assets")]
            public List<GitHubAsset> Assets { get; set; }
        }

        public class GitHubAsset
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("browser_download_url")]
            public string BrowserDownloadUrl { get; set; }
        }
    }
}
