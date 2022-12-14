using Sunny.UI;
using SYS.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYS.FormUI
{
    public partial class FrmLoading : UIForm
    {
        public FrmLoading()
        {
            InitializeComponent();
        }
       
        private void FrmLoading_Load(object sender, EventArgs e)
        {
            lblSoftwareVersion.Text = System.Windows.Forms.Application.ProductVersion.ToString();
            lblDllVersion.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            CheckUpdate();
            //Thread thread2 = new Thread(threadPro);//创建新线程
            //thread2.Start();
        }

        public void threadPro()
        {
            MethodInvoker MethInvo = new MethodInvoker(ShowLoginForm);
            BeginInvoke(MethInvo);
        }

        public void ShowLoginForm()
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog(this);
            this.Close();
        }

        #region 判断版本号
        private void CheckUpdate()
        {
            var newversion = new ApplicationVersionUtil().CheckBaseVersion();

            string version = System.Windows.Forms.Application.ProductVersion.ToString();
            if (newversion.base_version != version)
            {
                lblTips.Text = "旧版已停止使用，请到github或gitee仓库更新最新发行版！";
                System.Windows.Forms.Application.Exit();
                this.Visible = false;
                //调用系统默认的浏览器
                System.Diagnostics.Process.Start("https://gitee.com/java-and-net/TopskyHotelManagerSystem/releases");
            }
            else
            {
                lblSoftwareNewVersion.Text = newversion.base_version;
                lblTips.Text = "当前已为最新版本，无需更新！";
                Thread thread2 = new Thread(threadPro);//创建新线程
                thread2.Start();
            }
        }
        #endregion

    }
}
