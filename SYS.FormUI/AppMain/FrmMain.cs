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
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using SYS.Core;
using SYS.FormUI.Properties;
using Sunny.UI;
using System.Management;
using SYS.Application;

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
            //Main = this;//储存主窗口实例对象
            // 接受Form1对象
            this.returnForm1 = F1;
            Stop = StopUseExit;
            Start = StartUseExit;
            CloseMy = CloseMine;
        }

        public delegate void StopUseList();
        //定义委托类型的变量
        public static StopUseList Stop;

        public delegate void StarUseList();
        //定义委托类型的变量
        public static StarUseList Start;

        public static StarUseList CloseMy;


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
        
        //public static FrmMain Main;//全局保存主窗口实例对象
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
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        #endregion

        #region 获取网络时间
        public static string GetNetDateTime()
        {
            //获取网络时间
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
        List<Fonts> fonts = new FontsService().SelectFontAll();
        int fontn = 0;
        #endregion

        #region 定时器：文字滚动间隔
        private void tmrFont_Tick(object sender, EventArgs e)
        {
            fontn++;
            if (fontn == fonts.Count)
            {
                fontn = 0;
            }
            lblScroll.Text = fonts[fontn].FontsMess;
        }
        #endregion

        #region 退出当前程序
        private void picClose_Click_1(object sender, EventArgs e)
        {
            notifyIcon1.Dispose();
            System.Windows.Forms.Application.Exit();
        }
        #endregion

        #region 窗体最小化
        private void picFormSize_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region 窗体边框阴影效果变量申明

        const int CS_DropSHADOW = 0x20000;
        const int GCL_STYLE = (-26);
        //声明Win32 API
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SetClassLong(IntPtr hwnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetClassLong(IntPtr hwnd, int nIndex);

        #endregion

        #region 窗体加载事件方法
        private void FrmMain_Load(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.Label")
                {
                    item.Font = UI_FontUtil.mainFont;
                }
            }


            SetClassLong(this.Handle, GCL_STYLE, GetClassLong(this.Handle, GCL_STYLE) | CS_DropSHADOW); //API函数加载，实现窗体边框阴影效果
            
            DateTime tmCur = DateTime.Now;

            if (tmCur.Hour < 8 || tmCur.Hour > 18)
            {//晚上
                label3.Text = "(*´▽｀)ノノ晚上好," + LoginInfo.WorkerName;
                btnHello.BackgroundImage = Resources.月亮;
            }
            else if (tmCur.Hour > 8 && tmCur.Hour < 12)
            {//上午
                label3.Text = "上午好," + LoginInfo.WorkerName;
                btnHello.BackgroundImage = Resources.早上;
            }
            else
            {//下午
                label3.Text = "下午好," + LoginInfo.WorkerName;
                btnHello.BackgroundImage = Resources.咖啡;
            }
            int n = Convert.ToInt32(new WorkerCheckService().SelectToDayCheckInfoByWorkerNo(LoginInfo.WorkerNo));
            if (n > 0)
            {
                linkLabel1.Text = "已打卡";
                linkLabel1.ForeColor = Color.Green;
                linkLabel1.LinkColor = Color.Green;
            }
            notifyIcon1.Text = "TS酒店管理系统-"+ LoginInfo.WorkerName +"-版本号：" + System.Windows.Forms.Application.ProductVersion.ToString();
            wk_WorkerName = LoginInfo.WorkerName;
            pnlMID.Controls.Clear();
            FrmRoomManager frm1 = new FrmRoomManager();
            frm1.TopLevel = false;
            pnlMID.Controls.Add(frm1);
            frm1.Show();
            



        }
        #endregion


        #region 客房管理列表弹出事件方法
        private void picRoom_Click(object sender, EventArgs e)
        {
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
            //pnlMID.Controls.Clear();
            UIMessageTip.ShowError("界面维护，请稍后重试");
            return;
            //FrmExtendOption frm = new FrmExtendOption();
            //frm.TopLevel = false;
            //FrmExtendOption frm1 = new FrmExtendOption();
            //frm1.TopLevel = false;
            //pnlMID.Controls.Add(frm1);
            //frm1.Show();
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
                OperationLog o = new OperationLog();
                o.OperationTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd,HH:mm:ss"));
                o.Operationlog = LoginInfo.WorkerNo + LoginInfo.WorkerName + "于" + DateTime.Now + "尝试或成功登入了后台系统！";
                o.OperationAccount = LoginInfo.WorkerNo;
                o.datains_usr = LoginInfo.WorkerNo;
                o.datains_date = DateTime.Now;
                #endregion
                new OperationlogService().InsertOperationLog(o);
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
            //调用系统默认的浏览器
            System.Diagnostics.Process.Start("https://gitee.com/yjj0720/TopskyHotelManagerSystem/releases");
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
            int n = Convert.ToInt32(new WorkerCheckService().SelectToDayCheckInfoByWorkerNo(LoginInfo.WorkerNo));
            if (n > 0)
            {
                linkLabel1.Text = "已打卡";
                linkLabel1.ForeColor = Color.Green;
                linkLabel1.LinkColor = Color.Green;
                pnlCheckInfo.Visible = true;
                lblCheckDay.Text = Convert.ToString(new WorkerCheckService().SelectWorkerCheckDaySumByWorkerNo(LoginInfo.WorkerNo));
            }
            else
            {
                linkLabel1.Text = "未打卡";
                linkLabel1.ForeColor = Color.Red;
                linkLabel1.LinkColor = Color.Red;
                bool dr = UIMessageBox.Show("你今天还未打卡哦，请先打卡吧！", "打卡提醒",UIStyle.Blue, UIMessageBoxButtons.OK);
                if (dr == true)
                {
                    WorkerCheck workerCheck = new WorkerCheck
                    {
                        WorkerNo = LoginInfo.WorkerNo,
                        CheckWay = "系统界面",
                        CheckTime = DateTime.Parse(GetNetDateTime()),
                        datains_usr = LoginInfo.WorkerNo,
                        datains_date = DateTime.Now
                    };
                    bool j = new WorkerCheckService().AddCheckInfo(workerCheck);
                    if (j == true)
                    {
                        lblCheckDay.Text = Convert.ToString(new WorkerCheckService().SelectWorkerCheckDaySumByWorkerNo(LoginInfo.WorkerNo));
                        UIMessageBox.Show("打卡成功！你已累计打卡" + lblCheckDay.Text + "天，再接再厉吧！", "打卡提醒",UIStyle.Green, UIMessageBoxButtons.OK);
                        linkLabel1.Text = "已打卡";
                        linkLabel1.ForeColor = Color.Green;
                        linkLabel1.LinkColor = Color.Green;
                        pnlCheckInfo.Visible = true;
                        return;

                    }
                    else
                    {
                        UIMessageBox.Show("服务器错误，请稍后再试！", "系统提示", UIStyle.Red,UIMessageBoxButtons.OK);
                        return;
                    }
                }
            }


        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            pnlCheckInfo.Visible = false;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void picFormSize_MouseHover(object sender, EventArgs e)
        {
            this.picFormSize.BackColor = System.Drawing.Color.FromArgb(111, 168, 255);
            this.picFormSize.Radius = 20;
        }

        private void picFormSize_MouseDown(object sender, MouseEventArgs e)
        {
            this.picFormSize.BackColor = System.Drawing.Color.FromArgb(74, 131, 229);
            this.picFormSize.Radius = 20;
        }

        private void picClose_MouseHover(object sender, EventArgs e)
        {
            this.picClose.BackColor = System.Drawing.Color.FromArgb(111, 168, 255);
            this.picClose.Radius = 20;
        }

        private void picClose_MouseDown(object sender, MouseEventArgs e)
        {
            this.picClose.BackColor = System.Drawing.Color.FromArgb(74, 131, 229);
            this.picClose.Radius = 20;
        }

        private void picFormSize_MouseLeave_1(object sender, EventArgs e)
        {
            this.picFormSize.BackColor = System.Drawing.Color.Transparent;
            this.picFormSize.BackgroundImage = Resources.arrow_down_b;
            this.picFormSize.RectColor = System.Drawing.Color.FromArgb(80, 160, 255);
            this.picFormSize.Radius = 20;
        }

        private void picClose_MouseLeave_1(object sender, EventArgs e)
        {
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.BackgroundImage = Resources.close;
            this.picClose.RectColor = System.Drawing.Color.FromArgb(80, 160, 255);
            this.picClose.Radius = 20;
        }

        private void tsmiMySpace_Click(object sender, EventArgs e)
        {
            FrmMySpace frmMySpace = new FrmMySpace();
            frmMySpace.Text = LoginInfo.WorkerName + "的个人中心";
            frmMySpace.ShowDialog();
        }

        public void CloseMine() 
        {
            this.Close();
        }
    }
}
