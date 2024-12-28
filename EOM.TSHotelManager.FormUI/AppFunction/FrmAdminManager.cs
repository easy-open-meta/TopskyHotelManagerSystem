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
using Sunny.UI;

namespace EOM.TSHotelManager.FormUI
{
    public partial class FrmAdminManager : UIForm
    {
        public FrmAdminManager()
        {
            InitializeComponent();
        }

        ResponseMsg result = null;
        Dictionary<string, string> dic = null;

        private void FrmAdminManager_Load(object sender, EventArgs e)
        {
            LoadAdminList();
        }

        public void LoadAdminList()
        {
            result = HttpHelper.Request("Admin/GetAllAdminList");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("GetAllAdminList+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            dgvAdminList.AutoGenerateColumns = false;
            dgvAdminList.DataSource = HttpHelper.JsonToList<Admin>(result.message);
        }

        private void btnAuthority_Click(object sender, EventArgs e)
        {
            if (dgvAdminList.SelectedRows.Count > 0)
            {
                Admin admin = new Admin()
                {
                    Id = Convert.ToInt32(dgvAdminList.SelectedRows[0].Cells["clId"].Value),
                    DeleteMk = Convert.ToInt32(dgvAdminList.SelectedRows[0].Cells["Column1"].Value),
                    datachg_usr = AdminInfo.Account
                };
                result = HttpHelper.Request("Admin/UpdAccount", HttpHelper.ModelToJson(admin));
                if (result.statusCode != 200)
                {
                    UIMessageBox.ShowError("UpdAccount+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                bool tf = result.message.ToString().Equals("true");
                if (tf)
                {
                    UIMessageBox.ShowSuccess("操作成功！");
                    #region 获取添加操作日志所需的信息
                    RecordHelper.Record(AdminInfo.Account + "-" + AdminInfo.Name + "在" + Convert.ToDateTime(DateTime.Now) + "位于" + AdminInfo.SoftwareVersion + "执行：" + "禁用/启用管理账号操作！新增值为：" + admin.DeleteMk, 2);
                    #endregion
                    LoadAdminList();
                    return;
                }
            }
        }
    }
}
