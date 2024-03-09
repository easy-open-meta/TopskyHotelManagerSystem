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
using EOM.TSHotelManager.Common.Core;
using jvncorelib_fr.EntityLib;
using Sunny.UI;
using SYS.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;

namespace SYS.FormUI
{
    public partial class FrmChangeAdminPwd : UIForm
    {
        public FrmChangeAdminPwd()
        {
            InitializeComponent();
        }

        ResponseMsg result = null;
        Dictionary<string, string> dic = null;

        private void FrmChangeAdminPwd_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdPwd_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin() { AdminAccount = AdminInfo.Account, AdminPassword = txtNewPwd.Text.Trim(), datachg_usr = AdminInfo.Account };
            result = HttpHelper.Request("Admin​/UpdateNewPwdByOldPwd", HttpHelper.ModelToJson(admin));
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("UpdateNewPwdByOldPwd+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            bool tf = result.message.ToString().Equals("true");
            if (!tf)
            {
                UIMessageBox.Show("服务器繁忙，修改失败！", "系统提示", UIStyle.Red, UIMessageBoxButtons.OK);
                return;
            }
            UIMessageBox.Show("修改成功，系统将在稍后退出，请使用新密码进行登录系统！", "系统提示", UIStyle.Green, UIMessageBoxButtons.OK);
            FrmBackgroundSystem.closeform();
            this.Close();
            return;
        }

        private void txtOldPwd_TextChanged(object sender, EventArgs e)
        {
            if (txtOldPwd.TextLength < 6)
            {
                lgCheckOldPwd.Visible = true;
                lgCheckOldPwd.OnColor = Color.Red;
            }
        }

        private void txtOldPwd_Validated(object sender, EventArgs e)
        {
            //校验旧密码是否正确
            Admin admin = new Admin() { AdminAccount = AdminInfo.Account, AdminPassword = txtOldPwd.Text.Trim() };
            result = HttpHelper.Request("Admin​/SelectMangerByPass", HttpHelper.ModelToJson(admin));
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectMangerByPass+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            var source = HttpHelper.JsonToModel<Admin>(result.message);
            if (!source.IsNullOrEmpty())
            {
                lgCheckOldPwd.Visible = true;
                lgCheckOldPwd.OnColor = Color.Green;
                lblOldMsg.ForeColor = Color.Green;
                lblOldMsg.Text = "旧密码符合，请继续填写新密码！";
                txtNewPwd.ReadOnly = false;
                txtNewPwd.Validated += new EventHandler(txtNewPwd_Validated);
            }
            else
            {
                lgCheckOldPwd.Visible = true;
                lgCheckOldPwd.OnColor = Color.Red;
                lblOldMsg.ForeColor = Color.Red;
                lblOldMsg.Text = "旧密码有误，请重试！";
                txtNewPwd.ReadOnly = true;
                txtNewPwd.Validated -= new EventHandler(txtNewPwd_Validated);

            }
        }


        private void txtNewPwd_Validated(object sender, EventArgs e)
        {
            string pattern = @"^[A-Za-z0-9]+$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(txtNewPwd.Text.Trim()) && txtNewPwd.TextLength > 8)
            {
                lblNewMsg.ForeColor = Color.Green;
                lblNewMsg.Text = "密码长度及格式符合要求！";
                lgCheckNewPwd.Visible = true;
                lgCheckNewPwd.OnColor = Color.Green;
                return;

            }
            else
            {
                lblNewMsg.ForeColor = Color.Red;
                lblNewMsg.Text = "密码长度及格式不符合要求，请检查！";
                lgCheckNewPwd.Visible = true;
                txtNewPwd.Focus();
                lgCheckNewPwd.OnColor = Color.Red;
                return;
            }
        }


    }
}
