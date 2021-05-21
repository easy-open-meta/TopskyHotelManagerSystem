/*
 * MIT License
 *Copyright (c) 2021 咖啡与网络(java-and-net)

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
            Admin admin = new Admin() { AdminAccount = account, AdminPassword = pass };
            Admin a = new AdminService().SelectMangerByPass(admin);
            if (a != null)//判断超管是否存在
            {
                //判断当前管理员是否被禁用
                if (a.DeleteMk == 1)
                {
                    UIMessageBox.ShowError("当前管理员已被禁用，请联系超级管理员进行解除！");
                    return;
                }
                AdminInfo.Type = a.AdminType;
                AdminInfo.Name = a.AdminName;
                AdminInfo.Account = a.AdminAccount;
                AdminInfo.isAdmin = a.IsAdmin == 0 ? false : true;
                FrmBackgroundSystem fm = new FrmBackgroundSystem();
                fm.Show();//打开主窗体
                this.Hide();//隐藏登录窗体
                RecordHelper.Record(AdminInfo.Account + "于" + DateTime.Now + "成功登入后台管理系统！", 3);
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
            txtAccount.Text = "admin";
            txtPassword.Text = "admin";
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
