using System;
using System.Windows.Forms;
using SYS.Core;
using Sunny.UI;
using System.Text.RegularExpressions;
using SYS.Application;

namespace SYS.FormUI
{
    public partial class FrmAdminEnter : UIForm
    {
        public FrmAdminEnter()
        {
            InitializeComponent();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            string account = txtAccount.Text.Trim();//获取超管账号
            string pass = txtPassword.Text.Trim();//获取超管密码
            if (!CheckInputString(account, pass))
            {
                UIMessageDialog.ShowErrorDialog(this, "错误提示", "账号或密码包含除字母数字外的字符，请检查！", UIStyle.Red);
                return;
            }
            Admin a = new AdminService().SelectMangerByPass(account,pass);
            if (a != null)//判断超管是否存在
            {
                AdminInfo.Type = a.AdminType;
                AdminInfo.Name = a.AdminName;
                AdminInfo.Account = a.AdminAccount;
                FrmBackgroundSystem fm = new FrmBackgroundSystem();
                fm.Show();//打开主窗体
                this.Hide();//隐藏登录窗体
            }
            else
            {
                UIMessageDialog.ShowErrorDialog(this, "错误提示", "账号或密码有误，请检查！", UIStyle.Red);
                return;
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAdminEnter_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 检查输入的字符是否包含非法字符
        /// </summary>
        /// <param name="adminaccount"></param>
        /// <param name="adminpassword"></param>
        /// <returns></returns>
        public bool CheckInputString(string adminaccount,string adminpassword)
        {
            if (string.IsNullOrWhiteSpace(adminaccount))
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(adminpassword))
            {
                return false;
            }

            if (!string.IsNullOrWhiteSpace(adminaccount) && !string.IsNullOrWhiteSpace(adminpassword))
            {
                string pattern = @"^[A-Za-z0-9]+$";
                Regex regex = new Regex(pattern);
                if (!regex.IsMatch(adminaccount) || !regex.IsMatch(adminpassword))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
