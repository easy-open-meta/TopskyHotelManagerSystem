
using Sunny.UI;

using SYS.Common;
using EOM.TSHotelManager.Common.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYS.FormUI
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
            dgvAdminList.DataSource =HttpHelper.JsonToList<Admin>(result.message);
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
                result = HttpHelper.Request("Admin/UpdAccount",HttpHelper.ModelToJson(admin));
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
                    RecordHelper.Record(AdminInfo.Account + "-" + AdminInfo.Name + "在" + DateTime.Now + "位于" + AdminInfo.SoftwareVersion + "执行：" + "禁用/启用管理账号操作！新增值为：" + admin.DeleteMk, 2);
                    #endregion
                    LoadAdminList();
                    return;
                }
            }
        }
    }
}
