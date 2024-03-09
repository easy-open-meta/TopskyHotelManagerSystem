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
using Sunny.UI;
using SYS.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SYS.FormUI
{
    public partial class FrmUnLockSystem : UIForm
    {

        public FrmUnLockSystem()
        {
            InitializeComponent();
        }

        private const int SC_CLOSE = 0xF060;

        private const int MF_ENABLED = 0x00000000;

        private const int MF_GRAYED = 0x00000001;

        private const int MF_DISABLED = 0x00000002;



        [DllImport("user32.dll", EntryPoint = "GetSystemMenu")]

        private static extern IntPtr GetSystemMenu(IntPtr hWnd, int bRevert);

        [DllImport("User32.dll")]

        public static extern bool EnableMenuItem(IntPtr hMenu, int uIDEnableItem, int uEnable);

        private void FrmUnLockSystem_FormClosing(object sender, FormClosingEventArgs e)
        {
            //HookStop();
        }

        private void FrmUnLockSystem_Deactivate(object sender, EventArgs e)
        {

        }

        Dictionary<string, string> dic = null;
        ResponseMsg result = null;

        private void btnUnLock_Click(object sender, EventArgs e)
        {
            dic = new Dictionary<string, string>()
            {
                { "account",AdminInfo.Account.Trim()}
            };
            result = HttpHelper.Request("Admin/SelectAdminPwdByAccount", null, dic);
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectAdminPwdByAccount+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            var account = HttpHelper.JsonToModel<Admin>(result.message);
            if (account != null)
            {
                if (account.AdminPassword != txtUnLockPwd.Text.Trim())
                {
                    UIMessageBox.ShowError("密码错误! 请输入当前超管密码解锁!");
                    txtUnLockPwd.Text = "";
                    txtUnLockPwd.Focus();
                    return;
                }
                this.Close();
                string regPath = System.Windows.Forms.Application.StartupPath + @"\启用任务管理器.reg";
                ExecuteReg(regPath);
            }

        }


        private void FrmUnLockSystem_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void txtUnLockPwd_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void FrmUnLockSystem_Load(object sender, EventArgs e)
        {
            //string regPath = System.Windows.Forms.Application.StartupPath + @"\禁用任务管理器.reg";
            //ExecuteReg(regPath);
            //Process[] ps = Process.GetProcessesByName("TS酒店管理系统");
            //if (ps.Length < 0)
            //{
            //    foreach (Process p in ps)
            //        p.Kill();
            //    FrmMain.Start();
            //}
            //IntPtr hMenu = GetSystemMenu(this.Handle, 0);
            //EnableMenuItem(hMenu, SC_CLOSE, MF_DISABLED | MF_GRAYED);
            //FrmBackgroundSystem.hideform();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_NOCLOSE = 0x200;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = cp.ClassStyle | CS_NOCLOSE;
                return cp;
            }

        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 0x84 && m.Result == (IntPtr)2) // 不让拖动标题栏
            {
                m.Result = (IntPtr)1;
            }
            if (m.Msg == 0xA3)                         // 双击标题栏无反应
            {
                m.WParam = System.IntPtr.Zero;
            }
        }

        /// <summary>  
        /// 执行注册表导入  
        /// </summary>  
        /// <param name="regPath">注册表文件路径</param>  
        public void ExecuteReg(string regPath)
        {
            if (File.Exists(regPath))
            {
                regPath = @"""" + regPath + @"""";
                Process.Start("regedit", string.Format(" /s {0}", regPath));
            }
        }

        private void FrmUnLockSystem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4 && e.Modifiers == Keys.Alt)
            {
                UIMessageBox.Show("请输入解锁密码！", "错误", UIStyle.Red, UIMessageBoxButtons.OK);
                e.Handled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btnUnLock_Click_1(object sender, EventArgs e)
        {

        }
    }
}
