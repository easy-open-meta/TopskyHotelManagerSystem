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
    public partial class FrmAddAdmin : UIForm
    {
        public FrmAddAdmin()
        {
            InitializeComponent();
        }

        private void FrmAddAdmin_Load(object sender, EventArgs e)
        {
            LoadAdminType();
            cbAccountType.SelectedIndex = 1;
            LoadAdminList();
        }

        public void LoadAdminList() 
        {
            dgvAdminList.AutoGenerateColumns = false;
            dgvAdminList.DataSource = new AdminService().GetAllAdmin();
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
                datains_usr = AdminInfo.Account,
                datains_time = DateTime.Now
            };
            if (CheckInputs(admin) == true)
            {
                bool result = new AdminService().AddAdmin(admin);
                if (result == true)
                {
                    UIMessageBox.ShowSuccess("添加管理员成功！");
                    LoadAdminList();
                    return;


                }
            }
        }

        public void LoadAdminType()
        {
            cbAccountType.DataSource = new AdminService().GetAllAdminTypes();
            cbAccountType.ValueMember = "type_id";
            cbAccountType.DisplayMember = "type_name";
        }

        public bool CheckInputs(Admin admin) 
        {
            bool result = true;
            if (string.IsNullOrWhiteSpace(admin.AdminAccount))
            {
                result = false;
            }
            if (string.IsNullOrWhiteSpace(admin.AdminPassword))
            {
                result = false;
            }
            if (string.IsNullOrWhiteSpace(admin.AdminName))
            {
                result = false;
            }
            if (string.IsNullOrWhiteSpace(admin.IsAdmin + ""))
            {
                result = false;
            }
            if (string.IsNullOrWhiteSpace(admin.AdminType))
            {
                result = false;
            }
            return result;
        }

        private void cbAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAccountType.Text == "超级管理员")
            {
                UIMessageTip.ShowWarning("警告：赋予当前账号为超级管理员意味着其所作的所有行为将不受系统监管\n并有可能造成系统数据的缺失！", 3000);
                return;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                switch (item.GetType().ToString())
                {
                    case "Sunny.UI.UITextBox":
                        item.Text = "";
                        break;
                }
            }
        }
    }
}
