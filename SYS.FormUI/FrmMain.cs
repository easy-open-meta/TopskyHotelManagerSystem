using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using SYS.Manager;
using SYS.Core;
using SYS.FormUI.Properties;

namespace SYS.FormUI
{
    public partial class FrmMain : Form
    {
        private FrmLogin returnForm1 = null;
        public FrmMain(FrmLogin F1)
        {
            InitializeComponent();
            #region 防止背景闪屏方法
            this.DoubleBuffered = true;//设置本窗体
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲 
            #endregion

            Control.CheckForIllegalCrossThreadCalls = false;//关闭线程检查
            Main = this;//储存主窗口实例对象
            // 接受Form1对象
            this.returnForm1 = F1;
            Stop = StopUseExit;
            Start = StartUseExit;
        }

        public delegate void StopUseList();
        //定义委托类型的变量
        public static StopUseList Stop;

        public delegate void StarUseList();
        //定义委托类型的变量
        public static StarUseList Start;

        public void StopUseExit()
        {
            notifyIcon1.Visible = false;
            tsmiExitSystem.Enabled = false;
        }

        public void StartUseExit()
        {
            notifyIcon1.Visible = true;
            tsmiExitSystem.Enabled = true;
        }

        public static FrmMain Main;//全局保存主窗口实例对象
        //private MyRoom Myroom;//房态图对象

        public static string wk_WorkerName;
        public static string wk_WorkerNames;

        #region 调用windows的系统锁定
        [DllImport("user32 ")]
        public static extern bool LockWorkStation();//这个是调用windows的系统锁定  
        #endregion

        #region 窗体渐变相关代码
        private bool showing = true;
        #endregion

        #region 记录鼠标和窗体坐标的方法
        private Point mouseOld;//鼠标旧坐标
        private Point formOld;//窗体旧坐标 
        #endregion

        #region 记录移动的窗体坐标
        private void FrmMain_MouseDown_1(object sender, MouseEventArgs e)
        {
            formOld = this.Location;
            mouseOld = MousePosition;
        }
        #endregion

        #region 记录窗体移动的坐标
        private void FrmMain_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mouseNew = MousePosition;
                int moveX = mouseNew.X - mouseOld.X;
                int moveY = mouseNew.Y - mouseOld.Y;
                this.Location = new Point(formOld.X + moveX, formOld.Y + moveY);
            }
        }
        #endregion

        #region 定时器：获取网络时间
        private void tmrDate_Tick(object sender, EventArgs e)
        {

            string netTime = GetNetDateTime();

            if (netTime != "")
            {
                lblTime.Text = Convert.ToDateTime(netTime).ToString("HH:mm:ss");
            }
            else
            {
                lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            }
        }
        #endregion

        #region 获取网络时间
        public static string GetNetDateTime()
        {//获取网络时间
            WebRequest request = null;
            WebResponse response = null;
            WebHeaderCollection headerCollection = null;
            string datetime = string.Empty;
            try
            {
                request = WebRequest.Create("https://www.baidu.com");
                request.Timeout = 3000;
                request.Credentials = CredentialCache.DefaultCredentials;
                response = request.GetResponse();
                headerCollection = response.Headers;
                foreach (var h in headerCollection.AllKeys)
                {
                    if (h == "Date")
                    {
                        datetime = headerCollection[h];
                    }
                }
                return datetime;
            }
            catch (Exception) { return datetime; }
            finally
            {
                if (request != null)
                { request.Abort(); }
                if (response != null)
                { response.Close(); }
                if (headerCollection != null)
                { headerCollection.Clear(); }
            }
        }
        #endregion

        #region 从数据库读取文字滚动的内容
        static FontsManager fontsManager = new FontsManager();
        List<Fonts> fonts = fontsManager.SelectFontAll();
        int fontn = 0;
        #endregion

        #region 定时器：文字滚动间隔
        private void tmrFont_Tick(object sender, EventArgs e)
        {
            lblScroll.Location = new Point(lblScroll.Location.X - 8, lblScroll.Location.Y);
            if (lblScroll.Location.X + lblScroll.Width <= 8)
            {
                fontn++;
                if (fontn == fonts.Count)
                {
                    fontn = 0;
                }
                lblScroll.Text = fonts[fontn].FontsMess;
                lblScroll.Location = new Point(panel1.Width, lblScroll.Location.Y);
            }

        }
        #endregion

        #region 退出当前程序
        private void picClose_Click(object sender, EventArgs e)
        {
            notifyIcon1.Dispose();
            System.Windows.Forms.Application.Exit();

        }
        #endregion

        #region 窗体最小化
        private void picFormSize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region 窗体加载事件方法
        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblUserName.Text = LoginInfo.WorkerName + "【" + LoginInfo.WorkerClub + LoginInfo.WorkerPosition + "】";
            notifyIcon1.Text = "TS酒店管理系统" + lblUserName.Text + "-版本号：" + System.Windows.Forms.Application.ProductVersion.ToString();
            wk_WorkerName = LoginInfo.WorkerName;
            //Opacity = 0.0; //窗体透明度为0
            //fadeTimer.Start(); //计时开始
            picRoom.BackgroundImage = Resources.预订管理ab;
            picExtend.BackgroundImage = Resources.扩展功能_ib;
            picCustomer.BackgroundImage = Resources.用户管理_ib;
            //CheckUpdate();
            pnlMID.Controls.Clear();
            FrmRoomManager frm1 = new FrmRoomManager();
            frm1.TopLevel = false;
            pnlMID.Controls.Add(frm1);
            frm1.Show();
            int n = Convert.ToInt32(WorkerCheckManager.SelectToDayCheckInfoByWorkerNo(LoginInfo.WorkerNo));
            if (n > 0)
            {
                linkLabel1.Text = "已打卡";
                linkLabel1.ForeColor = Color.Green;
                linkLabel1.LinkColor = Color.Green;
            }



        }
        #endregion


        #region 客房管理列表弹出事件方法
        private void picRoom_Click(object sender, EventArgs e)
        {
            //picReser.BackgroundImage = Resources.预约管理;
            picRoom.BackgroundImage = Resources.预订管理ab;
            picExtend.BackgroundImage = Resources.扩展功能_ib;
            picCustomer.BackgroundImage = Resources.用户管理_ib;
            picCommodity.BackgroundImage = Resources.商品消费_ia;
            pnlMID.Controls.Clear();
            FrmRoomManager frm1 = new FrmRoomManager();
            frm1.TopLevel = false;
            pnlMID.Controls.Add(frm1);
            frm1.Show();


        }
        #endregion

        #region 用户管理列表弹出事件方法
        private void picCustomer_Click(object sender, EventArgs e)
        {

            ////picReser.BackgroundImage = Resources.预约管理;
            picRoom.BackgroundImage = Resources.预订管理_aa;
            picCustomer.BackgroundImage = Resources.用户管理_ia;
            picExtend.BackgroundImage = Resources.扩展功能_ib;
            picCommodity.BackgroundImage = Resources.商品消费_ia;
            pnlMID.Controls.Clear();
            FrmCustomerManager frm1 = new FrmCustomerManager();
            frm1.TopLevel = false;
            pnlMID.Controls.Add(frm1);
            frm1.Show();
        }
        #endregion


        #region 扩展管理列表弹出事件方法
        private void picExtend_Click(object sender, EventArgs e)
        {
            picRoom.BackgroundImage = Resources.预订管理_aa;
            picCustomer.BackgroundImage = Resources.用户管理_ib;
            picCommodity.BackgroundImage = Resources.商品消费_ia;
            picExtend.BackgroundImage = Resources.扩展功能_ia;
            pnlMID.Controls.Clear();
            FrmExtendOption frm = new FrmExtendOption();
            frm.TopLevel = false;
            FrmExtendOption frm1 = new FrmExtendOption();
            frm1.TopLevel = false;
            pnlMID.Controls.Add(frm1);
            frm1.Show();
        }
        #endregion

        #region 关闭按钮鼠标事件
        private void picClose_MouseEnter(object sender, EventArgs e)
        {
            picClose.BackColor = Color.White;
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            picClose.BackColor = Color.Transparent;
        }
        #endregion

        #region 最小化按钮鼠标事件
        private void picFormSize_MouseEnter(object sender, EventArgs e)
        {
            picFormSize.BackColor = Color.White;
        }
        private void picFormSize_MouseLeave(object sender, EventArgs e)
        {
            picFormSize.BackColor = Color.Transparent;
        }






        #endregion


        #region 计算后台系统的入口点击事件方法
        int i = 0;
        #endregion

        #region 后台系统入口事件方法
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            i++;
            if (i < 3)
            {

            }
            else if (i % 3 == 0)
            {
                FrmAdminEnter frm = new FrmAdminEnter();
                frm.Show();
                #region 获取添加操作日志所需的信息
                Operation o = new Operation();
                o.OperationTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd,HH:mm:ss"));
                o.Operationlog = lblUserName.Text + "于" + DateTime.Now + "尝试或成功登入了后台系统！";
                o.OperationAccount = lblUserName.Text;
                #endregion
                OperationManager.InsertOperationLog(o);
            }

        }
        #endregion

        #region 调用系统锁屏方法
        private void tsmiLockScreen_Click(object sender, EventArgs e)
        {
            LockWorkStation();
        }
        #endregion

        #region 检查软件更新版本事件方法
        private void tsmiCheckUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请到：https://gitee.com/yjj0720/TopskyHotelManagerSystem" + "获取该软件的最新版本！");
        }
        #endregion

        #region 切换用户事件方法
        private void tsmiChangeUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 退出酒店管理系统事件方法
        private void tsmiExitSystem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }
        #endregion

        #region 关于我们选项的事件方法
        private void tsmiAboutUs_Click(object sender, EventArgs e)
        {
            FrmAboutUs frm = new FrmAboutUs();
            frm.Show();
        }
        #endregion

        #region 当窗体关闭后的事件方法
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            notifyIcon1.Dispose();
        }
        #endregion

        private void tsmiSelectUserAdmin_Click(object sender, EventArgs e)
        {

        }

        private void picCommodity_Click(object sender, EventArgs e)
        {
            //picReser.BackgroundImage = Resources.预约管理;
            picRoom.BackgroundImage = Resources.预订管理_aa;
            picCustomer.BackgroundImage = Resources.用户管理_ib;
            picExtend.BackgroundImage = Resources.扩展功能_ib;
            picCommodity.BackgroundImage = Resources.商品消费_ib;
            pnlMID.Controls.Clear();
            FrmSellThing frm1 = new FrmSellThing();
            frm1.TopLevel = false;
            pnlMID.Controls.Add(frm1);
            frm1.Show();
        }

        

        private void cmsMain_Opening(object sender, CancelEventArgs e)
        {

        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIcon1.Dispose();
            this.returnForm1.Visible = true;
        }

        private void tsmiMain_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int n = Convert.ToInt32(WorkerCheckManager.SelectToDayCheckInfoByWorkerNo(LoginInfo.WorkerNo));
            if (n > 0)
            {
                linkLabel1.Text = "已打卡";
                linkLabel1.ForeColor = Color.Green;
                linkLabel1.LinkColor = Color.Green;
                pnlCheckInfo.Visible = true;
                lblCheckDay.Text = Convert.ToString(WorkerCheckManager.SelectWorkerCheckDaySumByWorkerNo(LoginInfo.WorkerNo));
            }
            else
            {
                linkLabel1.Text = "未打卡";
                linkLabel1.ForeColor = Color.Red;
                linkLabel1.LinkColor = Color.Red;
                DialogResult dr = MessageBox.Show("你今天还未打卡哦，请先打卡吧！", "打卡提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    WorkerCheck workerCheck = new WorkerCheck
                    {
                        WorkerNo = LoginInfo.WorkerNo,
                        CheckWay = "系统界面",
                        CheckTime = DateTime.Parse(GetNetDateTime())

                    };
                    int j = WorkerCheckManager.AddCheckInfo(workerCheck);
                    if (j > 0)
                    {
                        lblCheckDay.Text = Convert.ToString(WorkerCheckManager.SelectWorkerCheckDaySumByWorkerNo(LoginInfo.WorkerNo));
                        MessageBox.Show("打卡成功！你已累计打卡" + lblCheckDay.Text + "天，再接再厉吧！", "打卡提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        linkLabel1.Text = "已打卡";
                        linkLabel1.ForeColor = Color.Green;
                        linkLabel1.LinkColor = Color.Green;
                        pnlCheckInfo.Visible = true;

                    }
                    else
                    {
                        MessageBox.Show("服务器错误，请稍后再试！");
                    }
                }
            }


        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            pnlCheckInfo.Visible = false;
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
