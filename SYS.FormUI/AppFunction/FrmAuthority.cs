using jvncorelib_fr.EntityLib;
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
    public partial class FrmAuthority : UIForm
    {
        public FrmAuthority()
        {
            InitializeComponent();
        }

        ResponseMsg result = null;
        Dictionary<string, string> dic = null;

        private void FrmAuthority_Load(object sender, EventArgs e)
        {
            
        }

        public void LoadAdminInfo()
        {
            dic =  new Dictionary<string, string>()
            {
                { "AdminAccount",txtAccount.Text.Trim() }
            }; 
            result = HttpHelper.Request("Admin/GetAdminInfoByAdminAccount", null,dic);
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("GetAdminInfoByAdminAccount+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            var adminInfo = HttpHelper.JsonToModel<Admin>(result.message);
            if (adminInfo.IsNullOrEmpty())
            {
                UIMessageTip.ShowError("找不到对应的管理员，请检查是否输入有误！");
                cbAccountType.Text = "";
                txtName.Text = "";
                txtAccount.Text = "";
                return;
            }
            txtAccount.Text = adminInfo.AdminAccount;
            txtName.Text = adminInfo.AdminName;
            cbAccountType.Text = adminInfo.TypeName;
        }

        public void LoadAllMyModule()
        {
            tfModuleZero.ItemsLeft.Clear();
            var admin = new Admin
            {
                AdminAccount = txtAccount.Text.Trim(),
            };
            
            result = HttpHelper.Request("Module/GetAllModuleByAdmin", HttpHelper.ModelToJson(admin));
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("GetAllModuleByAdmin+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            var listMyModule = HttpHelper.JsonToList<Module>(result.message);
            listMyModule.ForEach(myModule =>
            {
                tfModuleZero.ItemsRight.Add(myModule.module_name);
            });
            result = HttpHelper.Request("Module/GetAllModule");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("GetAllModule+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            var listModules = HttpHelper.JsonToList<Module>(result.message);
            listModules.ForEach(module =>
            {
                var myModule = listMyModule.FirstOrDefault(a => a.module_name.Equals(module.module_name));
                if (myModule == null)
                {
                    tfModuleZero.ItemsLeft.Add(module.module_name);
                }
            });
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            tfModuleZero.ItemsRight.Clear();
            LoadAdminInfo();
            LoadAllMyModule();
        }

        private void btnAuthority_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAccount.Text.Trim()))
            {
                UIMessageTip.ShowError("账号不能为空，请检查！");
                return;
            }
            dic = new Dictionary<string, string>()
            {
                { "AdminAccount",txtAccount.Text.Trim() }
            };
            result = HttpHelper.Request("Module/GetAllModuleByAdmin", null, dic);
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("GetAllModuleByAdmin+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            var listExsitModule = HttpHelper.JsonToList<Module>(result.message);
            var listAddModule = new List<ModuleZero>();
            if (listExsitModule != null)
            {
                ModuleZero moduleZero = new ModuleZero() { admin_account = txtAccount.Text.Trim() };
                result = HttpHelper.Request("Module/DelModuleZeroList", HttpHelper.ModelToJson(moduleZero));
                if (result.statusCode != 200)
                {
                    UIMessageBox.ShowError("DelModuleZeroList+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                for (int i = 0; i < tfModuleZero.ItemsRight.Count; i++)
                {
                    var newModule = tfModuleZero.ItemsRight[i].ToString();
                    listAddModule.Add(new ModuleZero() { admin_account = txtAccount.Text.Trim(), module_name = newModule, module_enable = 1 });
                }
            }
            if (!listAddModule.IsNullOrEmpty())
            {
                result = HttpHelper.Request("Module/AddModuleZeroList", HttpHelper.ModelToJson(listAddModule));
                if (result.statusCode != 200)
                {
                    UIMessageBox.ShowError("AddModuleZeroList+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                bool tf = result.message.ToString().Equals("true");
                if (tf)
                {
                    UIMessageBox.ShowSuccess("批量授权成功！");
                    return;
                }
            }
        }
    }
}
