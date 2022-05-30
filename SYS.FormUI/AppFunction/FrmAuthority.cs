using Sunny.UI;
using SYS.Application;
using SYS.Core;
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

        private void FrmAuthority_Load(object sender, EventArgs e)
        {
            
        }

        public void LoadAdminInfo()
        {
            Admin admin = new Admin() { AdminAccount = txtAccount.Text.Trim() };
            var adminInfo = new AdminService().GetAdminInfoByAdminAccount(admin);
            if (adminInfo == null)
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
            Admin admin = new Admin() { AdminAccount = txtAccount.Text.Trim() };
            var listMyModule = new AdminModuleZeroService().GetAllModuleByAdmin(admin);
            listMyModule.ForEach(myModule =>
            {
                tfModuleZero.ItemsRight.Add(myModule.module_name);
            });
            var listModules = new AdminModuleZeroService().GetAllModule();
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
            Admin admin = new Admin() { AdminAccount = txtAccount.Text.Trim() };
            var listExsitModule = new AdminModuleZeroService().GetAllModuleByAdmin(admin);
            var listAddModule = new List<ModuleZero>();
            if (listExsitModule != null)
            {
                ModuleZero moduleZero = new ModuleZero() { admin_account = txtAccount.Text.Trim() };
                new AdminModuleZeroService().DelModuleZeroList(moduleZero);
                for (int i = 0; i < tfModuleZero.ItemsRight.Count; i++)
                {
                    var newModule = tfModuleZero.ItemsRight[i].ToString();
                    listAddModule.Add(new ModuleZero() { admin_account = txtAccount.Text.Trim(), module_name = newModule, module_enable = 1 });
                }
            }

            bool result = new AdminModuleZeroService().AddModuleZeroList(listAddModule);
            if (result == true)
            {
                UIMessageBox.ShowSuccess("批量授权成功！");
                return;
            }

        }
    }
}
