using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Sunny.UI;
using SYS.Core;
using SYS.Manager;

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

        private void btnUnLock_Click(object sender, EventArgs e)
        {
            var account = AdminManager.SelectAdminPwdByAccount(AdminInfo.Account);
            if (account != null)
            {
                if (account.AdminPassword != txtUnLockPwd.Text.Trim())
                {
                    MessageBox.Show("密码错误! 请输入当前超管密码解锁!");
                    txtUnLockPwd.Text = "";
                    txtUnLockPwd.Focus();
                    return;
                }
                this.Close();
                string regPath = System.Windows.Forms.Application.StartupPath + @"\启用任务管理器.reg";
                ExecuteReg(regPath);
                FrmMain.Start();

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
            string regPath = System.Windows.Forms.Application.StartupPath + @"\禁用任务管理器.reg";
            ExecuteReg(regPath);
            //FrmMain.Stop();
            //HookStart();
            Process[] ps = Process.GetProcessesByName("TS酒店管理系统");
            if (ps.Length < 0)
            {
                foreach (Process p in ps)
                    p.Kill();
                FrmMain.Start();
            }
            IntPtr hMenu = GetSystemMenu(this.Handle, 0);
            EnableMenuItem(hMenu, SC_CLOSE, MF_DISABLED | MF_GRAYED);
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
                MessageBox.Show("请输入解锁密码！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
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
