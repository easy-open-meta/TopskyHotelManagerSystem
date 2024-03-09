using EOM.TSHotelManager.Common.Core;
using Sunny.UI;
using SYS.Common;
using System;
using System.Threading;
using System.Windows.Forms;

namespace SYS.FormUI
{
    public partial class FrmLoading : UIForm
    {
        public FrmLoading()
        {
            InitializeComponent();
        }

        private void FrmLoading_Load(object sender, EventArgs e)
        {
            lblSoftwareVersion.Text = System.Windows.Forms.Application.ProductVersion.ToString();
            lblDllVersion.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            CheckUpdate();
            //Thread thread2 = new Thread(threadPro);//创建新线程
            //thread2.Start();
        }

        public void threadPro()
        {
            MethodInvoker MethInvo = new MethodInvoker(ShowLoginForm);
            BeginInvoke(MethInvo);
        }

        public void ShowLoginForm()
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog(this);
            this.Close();
        }

        ResponseMsg result = new ResponseMsg();

        #region 判断版本号
        private void CheckUpdate()
        {
            result = HttpHelper.Request("App/CheckBaseVersion");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("CheckBaseVersion+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            var newversion = HttpHelper.JsonToModel<Applicationversion>(result.message);

            string version = System.Windows.Forms.Application.ProductVersion.ToString();
            if (newversion.base_version != version)
            {
                lblTips.Text = "旧版已停止使用，请到github或gitee仓库更新最新发行版！";
                System.Windows.Forms.Application.Exit();
                this.Visible = false;
                //调用系统默认的浏览器
                System.Diagnostics.Process.Start("https://gitee.com/java-and-net/TopskyHotelManagerSystem/releases");
            }
            else
            {
                lblSoftwareNewVersion.Text = newversion.base_version;
                lblTips.Text = "当前已为最新版本，无需更新！";
                Thread thread2 = new Thread(threadPro);//创建新线程
                thread2.Start();
            }
        }
        #endregion

    }
}
