using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSHotelManagerSystem
{
    public partial class FrmUnLockSystem : Form
    {
        public FrmUnLockSystem()
        {
            InitializeComponent();
        }

        private void FrmUnLockSystem_FormClosing(object sender, FormClosingEventArgs e)
        {



        }

        private void FrmUnLockSystem_Deactivate(object sender, EventArgs e)
        {

        }

        private void btnUnLock_Click(object sender, EventArgs e)
        {
            if (txtUnLockPwd.Text != "admin")
            {
                MessageBox.Show("密码错误! 请输入当前登陆密码解锁!");
                txtUnLockPwd.Text = "";
                txtUnLockPwd.Focus();
            }
            else
            {
                this.Close();
                string regPath = Application.StartupPath + @"\启用任务管理器.reg";
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
            //Timer t = new Timer();
            //t.Interval = 200;
            //t.Tick += delegate
            //{
            //    this.Activate();
            //    Process[] p = Process.GetProcesses();
            //    foreach (Process p1 in p)
            //    {
            //        try
            //        {
            //            if (p1.ProcessName.ToLower().Trim() == "任务管理器")//这里判断是任务管理器   
            //            { p1.Kill(); break; }
            //        }
            //        catch { }
            //    }
            //};
            //t.Start();
            string regPath = Application.StartupPath + @"\禁用任务管理器.reg";
            ExecuteReg(regPath);
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
            if (e.KeyCode == Keys.F4 && e.Alt)
            {
                e.Handled = true;
                MessageBox.Show("请输入解锁密码！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
