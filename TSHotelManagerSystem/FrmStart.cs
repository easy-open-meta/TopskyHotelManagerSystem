using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SYS.Application;
using ThreadState = System.Threading.ThreadState;

namespace TSHotelManagerSystem
{
    public partial class FrmStart : Form
    {
        public FrmStart()
        {
            InitializeComponent();
        }

        

        #region 判断版本号
        private void CheckUpdate()
        {
            string newversion = CheckInfoService.CheckBaseVersion();

            string version = Application.ProductVersion.ToString();
            if (version != newversion)
            {
                MessageBox.Show("旧版已停止使用，请到github或gitee仓库更新最新发行版！", "系统提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
                this.Visible = false;
                //调用系统默认的浏览器
                System.Diagnostics.Process.Start("https://gitee.com/yjj0720/TopskyHotelManagerSystem/releases");
            }
            else
            {
                MessageBox.Show("当前已为最新版本，无需更新！","系统提醒",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        #endregion

        private void FrmStart_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            this.TransparencyKey = Color.White;
            Thread thread = new Thread(new ThreadStart(new Action(delegate
            {
                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(50);
                    this.circleProgramBar1.Progress = i + 1;
                    if (this.circleProgramBar1.Progress == this.circleProgramBar1.MaxValue - 1)
                    {
                        this.Invoke(new Action(() =>
                        {
                            CheckUpdate();
                            FrmLogin f = new FrmLogin(this);
                            f.Show();
                            this.Visible = false;
                        }
                        ));
                    }
                }
            })));
            thread.IsBackground = true;
            thread.Start();
        }
           

        private void FrmStart_FormClosed(object sender, FormClosedEventArgs e)
        {
                
        }

        private void FrmStart_TextChanged(object sender, EventArgs e)
        {

        }

        private void circleProgramBar1_TextChanged(object sender, EventArgs e)
        {
            
        }

       

        private void FrmStart_Leave(object sender, EventArgs e)
        {
            
        }

        private void circleProgramBar1_Click(object sender, EventArgs e)
        {

        }

        private void lblSourceAuthor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://blog.lost520.cn/");
        }
    }
}
