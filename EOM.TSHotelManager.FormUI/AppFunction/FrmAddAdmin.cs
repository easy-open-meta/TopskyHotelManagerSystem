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
using AntdUI;
using EOM.TSHotelManager.Common;
using EOM.TSHotelManager.Common.Core;
using EOM.TSHotelManager.Common.Util;
using Sunny.UI;

namespace EOM.TSHotelManager.FormUI
{
    public partial class FrmAddAdmin : Window
    {
        TableComHelper tableComHelper = null;
        public FrmAddAdmin()
        {
            InitializeComponent();
            tableComHelper = new TableComHelper();
        }

        ResponseMsg result = null;
        private Dictionary<string, string> dic = null;

        private void FrmAddAdmin_Load(object sender, EventArgs e)
        {
            LoadAdminType();
            cbAccountType.SelectedIndex = 0;
            LoadAdminList();
        }

        public void LoadAdminList()
        {
            pgnPageNavigate.PageSizeOptions = new int[] { 10, 30, 50, 100 };
            var dataCount = 0;
            dgvAdminList.Spin("正在加载中...", () =>
            {
                TableComHelper tableComHelper = new TableComHelper();
                dgvAdminList.Columns = tableComHelper.ConvertToAntdColumns(tableComHelper.GenerateDataColumns<Admin>());
                dgvAdminList.DataSource = GetPageData(pgnPageNavigate.Current, pgnPageNavigate.PageSize, ref dataCount);
                pgnPageNavigate.PageSize = 10;
                pgnPageNavigate.Total = dataCount;
            }, () =>
            {
                System.Diagnostics.Debug.WriteLine("加载结束");
            });
        }

        object GetPageData(int current, int pageSize, ref int totalCount)
        {
            result = HttpHelper.Request("Admin/GetAllAdmin");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("GetAllAdmin+接口服务异常，请提交Issue或尝试更新版本！");
                return null;
            }
            var listDataSource = HttpHelper.JsonToList<Admin>(result.message);
            totalCount = listDataSource.Count;
            var listTableSource = new List<AntdUI.AntItem[]>();

            int skip = (current - 1) * pageSize;
            listDataSource = listDataSource.OrderBy(a => a.Id).Skip(skip).Take(pageSize).ToList();

            listTableSource = tableComHelper.ConvertToAntdItems(listDataSource);
            return listTableSource;
        }

        public void LoadAdminType()
        {
            result = HttpHelper.Request("Admin/GetAllAdminTypes");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("GetAllAdminTypes+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }

            cbAccountType.Items.AddRange(HttpHelper.JsonToList<AdminType>(result.message).Select(a => new SelectItem(a.type_name, a.type_id)).ToArray());
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAccount.Text = string.Empty;
            txtName.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var admin = new Admin
            {
                AdminAccount = txtAccount.Text.Trim(),
                AdminPassword = txtPassword.Text.Trim(),
                AdminName = txtName.Text.Trim(),
                AdminType = cbAccountType.SelectedValue.ToString(),
                IsAdmin = cbAccountType.SelectedValue.ToString() == "超级管理员" ? 1 : 0,
                DeleteMk = 0,
                datains_usr = AdminInfo.Account
            };
            if (ValidateHelper.Validate(admin))
            {
                result = HttpHelper.Request("Admin​/AddAdmin", HttpHelper.ModelToJson(admin));
                if (result.statusCode != 200)
                {
                    UIMessageBox.ShowError("AddAdmin+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                bool tf = result.message.ToString().Equals("true");
                if (tf)
                {
                    UIMessageBox.ShowSuccess("添加管理员成功！");
                    LoadAdminList();
                    return;
                }
            }
        }

        private void pgnPageNavigate_ValueChanged(object sender, PagePageEventArgs e)
        {
            var dataCount = 0;
            dgvAdminList.Spin("正在加载中...", () =>
            {
                dgvAdminList.DataSource = GetPageData(e.Current, e.PageSize, ref dataCount);
                pgnPageNavigate.PageSize = 10;
                pgnPageNavigate.Total = dataCount;
            }, () =>
            {
                System.Diagnostics.Debug.WriteLine("加载结束");
                txtAccount.Text = string.Empty;
                txtName.Text = string.Empty;
                txtPassword.Text = string.Empty;
            });
        }

        private string pgnPageNavigate_ShowTotalChanged(object sender, PagePageEventArgs e)
        {
            return $"{e.PageSize} / {e.Total}条 {e.PageTotal}页";
        }
    }
}
