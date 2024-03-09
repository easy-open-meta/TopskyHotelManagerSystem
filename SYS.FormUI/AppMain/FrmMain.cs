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
using SYS.FormUI.AppUserControls;
using SYS.FormUI.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;

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
            #region 获取添加操作日志所需的信息
            RecordHelper.Record(LoginInfo.WorkerNo + "-" + LoginInfo.WorkerName + "在" + DateTime.Now + "位于" + LoginInfo.SoftwareVersion + "版本登入了系统！", 3);
            #endregion
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

        ResponseMsg result = new ResponseMsg();

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

        #region 定时器：获取网络时间
        private void tmrDate_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm");

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
        }
        #endregion

        List<Fonts> fonts = null;
        int fontn = 0;
        private void LoadFonts()
        {
            #region 从数据库读取文字滚动的内容
            result = HttpHelper.Request("Fonts/SelectFontAll");
            if (result.statusCode != 200)
            {
                fonts = null;
            }

            fonts = HttpHelper.JsonToList<Fonts>(result.message);
            #endregion
        }

        #region 定时器：文字滚动间隔
        private void tmrFont_Tick(object sender, EventArgs e)
        {
            if (fonts.IsNullOrEmpty())
            {
                lblScroll.Text = "接口服务异常";
                return;
            }
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
            System.Windows.Forms.Application.Exit();
            notifyIcon1.Dispose();
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

        /// <summary>
        /// 客房管理点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RoomManager_Event(object sender, EventArgs e)
        {
            pnlMID.Controls.Clear();
            FrmRoomManager frm1 = new FrmRoomManager
            {
                TopLevel = false
            };
            pnlMID.Controls.Add(frm1);
            frm1.Show();
        }

        /// <summary>
        /// 用户管理点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustoManager_Event(object sender, EventArgs e)
        {
            pnlMID.Controls.Clear();
            FrmCustomerManager frm1 = new FrmCustomerManager();
            frm1.TopLevel = false;
            pnlMID.Controls.Add(frm1);
            frm1.Show();
        }

        /// <summary>
        /// 商品消费点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SellManager_Event(object sender, EventArgs e)
        {
            pnlMID.Controls.Clear();
            FrmSellThing frm1 = new FrmSellThing();
            frm1.TopLevel = false;
            pnlMID.Controls.Add(frm1);
            frm1.Show();
        }

        /// <summary>
        /// 加载导航控件列表
        /// </summary>
        private void LoadNavBar()
        {
            var listSource = new List<NavBar>();
            #region 菜单导航代码块
            result = HttpHelper.Request("NavBar/NavBarList");
            if (result.statusCode != 200)
            {
                listSource = null;
                return;
            }
            flpNav.Controls.Clear();
            listSource = HttpHelper.JsonToList<NavBar>(result.message);
            ucNavBar ucNavBar = null;
            if (!listSource.IsNullOrEmpty())
            {
                for (int i = 0; i < listSource.Count; i++)
                {
                    ucNavBar = new ucNavBar();
                    ucNavBar.Name = listSource[i].nav_name;
                    switch (listSource[i].nav_name)
                    {
                        case "客房管理":
                            ucNavBar.Click += new EventHandler(RoomManager_Event);
                            ucNavBar.BackgroundImage = Resources.picRoom_Image;
                            break;
                        case "用户管理":
                            ucNavBar.Click += new EventHandler(CustoManager_Event);
                            ucNavBar.BackgroundImage = Resources.picCustomer_Image;
                            break;
                        case "商品消费":
                            ucNavBar.Click += new EventHandler(SellManager_Event);
                            ucNavBar.BackgroundImage = Resources.picCommodity_Image;
                            break;
                    }
                    ucNavBar.Margin = new Padding(listSource[i].margin_left, 0, 0, 0);
                    flpNav.Controls.Add(ucNavBar);
                }
            }
            else
            {
                UIMessageBox.ShowError("服务器维护中，请过会再试");
                return;
            }
            #endregion
        }

        #region 窗体加载事件方法
        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblSoftName.Text = System.Windows.Forms.Application.ProductName.ToString() + "_V" + System.Windows.Forms.Application.ProductVersion.ToString();

            tmrDate.Enabled = true;

            LoadNavBar();

            LoadFonts();

            lblTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm");

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
            SetClassLong(this.Handle, GCL_STYLE, GetClassLong(this.Handle, GCL_STYLE) | CS_DropSHADOW); //API函数加载，实现窗体边框阴影效果

            Dictionary<string, string> user = new Dictionary<string, string>();
            user.Add("wkn", LoginInfo.WorkerNo);
            result = HttpHelper.Request("WorkerCheck/SelectToDayCheckInfoByWorkerNo", null, user);
            if (result.statusCode != 200)
            {
                UIMessageTip.ShowError("打卡接口异常，请提交issue");
                return;
            }
            int n = Convert.ToInt32(result.message);
            if (n > 0)
            {
                linkLabel1.Text = "已打卡";
                linkLabel1.ForeColor = Color.Green;
                linkLabel1.LinkColor = Color.Green;
            }
            notifyIcon1.Text = "TS酒店管理系统-" + LoginInfo.WorkerName + "-版本号：" + System.Windows.Forms.Application.ProductVersion.ToString();
            wk_WorkerName = LoginInfo.WorkerName;
            pnlMID.Controls.Clear();
            FrmRoomManager frm1 = new FrmRoomManager();
            frm1.TopLevel = false;
            pnlMID.Controls.Add(frm1);
            frm1.Show();
        }
        #endregion

        #region 计算后台系统的入口点击事件方法
        int i = 0;
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
            result = HttpHelper.Request("Base/GetBase");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("接口服务异常，请重试");
                return;
            }

            Base _base = HttpHelper.JsonToModel<Base>(result.message);

            //调用系统默认的浏览器
            System.Diagnostics.Process.Start(_base.url_addr);
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

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIcon1.Dispose();
            this.returnForm1.Visible = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dictionary<string, string> user = new Dictionary<string, string>();
            user.Add("wkn", LoginInfo.WorkerNo);
            result = HttpHelper.Request("WorkerCheck/SelectToDayCheckInfoByWorkerNo", null, user);
            if (result.statusCode != 200)
            {
                UIMessageTip.ShowError("打卡接口异常，请提交issue");
                return;
            }
            int n = Convert.ToInt32(result.message);
            if (n > 0)
            {
                linkLabel1.Text = "已打卡";
                linkLabel1.ForeColor = Color.Green;
                linkLabel1.LinkColor = Color.Green;
                pnlCheckInfo.Visible = true;
                result = HttpHelper.Request("WorkerCheck/SelectWorkerCheckDaySumByWorkerNo", null, user);
                if (result.statusCode != 200)
                {
                    UIMessageTip.ShowError("打卡接口异常，请提交issue");
                    return;
                }
                lblCheckDay.Text = Convert.ToString(result.message);
            }
            else
            {
                linkLabel1.Text = "未打卡";
                linkLabel1.ForeColor = Color.Red;
                linkLabel1.LinkColor = Color.Red;
                bool dr = UIMessageBox.Show("你今天还未打卡哦，请先打卡吧！", "打卡提醒", UIStyle.Blue, UIMessageBoxButtons.OK);
                if (dr == true)
                {
                    WorkerCheck workerCheck = new WorkerCheck
                    {
                        WorkerNo = LoginInfo.WorkerNo,
                        CheckWay = "系统界面",
                        CheckTime = DateTime.Parse(GetNetDateTime()),
                        datains_usr = LoginInfo.WorkerNo
                    };
                    result = HttpHelper.Request("WorkerCheck/AddCheckInfo", workerCheck.ModelToJson(), null);
                    if (result.statusCode != 200)
                    {
                        UIMessageTip.ShowError("打卡接口异常，请提交issue");
                        return;
                    }
                    bool j = result.statusCode == 200 ? true : false;
                    if (j)
                    {
                        result = HttpHelper.Request("WorkerCheck/SelectWorkerCheckDaySumByWorkerNo", null, user);
                        if (result.statusCode != 200)
                        {
                            UIMessageTip.ShowError("打卡接口异常，请提交issue");
                            return;
                        }
                        lblCheckDay.Text = Convert.ToString(result.message);
                        UIMessageBox.Show("打卡成功！你已共打卡" + lblCheckDay.Text + "天，再接再厉吧！", "打卡提醒", UIStyle.Green, UIMessageBoxButtons.OK);
                        linkLabel1.Text = "已打卡";
                        linkLabel1.ForeColor = Color.Green;
                        linkLabel1.LinkColor = Color.Green;
                        pnlCheckInfo.Visible = true;
                        return;

                    }
                    else
                    {
                        UIMessageBox.Show("服务器错误，请稍后再试！", "系统提示", UIStyle.Red, UIMessageBoxButtons.OK);
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
        }

        private void picFormSize_MouseDown(object sender, MouseEventArgs e)
        {
            this.picFormSize.BackColor = System.Drawing.Color.FromArgb(74, 131, 229);
        }

        private void picClose_MouseHover(object sender, EventArgs e)
        {
            this.picClose.BackColor = System.Drawing.Color.FromArgb(111, 168, 255);
        }

        private void picClose_MouseDown(object sender, MouseEventArgs e)
        {
            this.picClose.BackColor = System.Drawing.Color.FromArgb(74, 131, 229);
        }

        private void picFormSize_MouseLeave_1(object sender, EventArgs e)
        {
            this.picFormSize.BackColor = System.Drawing.Color.Transparent;
            this.picFormSize.BackgroundImage = Resources.arrow_down_b;
            this.picFormSize.RectColor = System.Drawing.Color.FromArgb(80, 160, 255);
        }

        private void picClose_MouseLeave_1(object sender, EventArgs e)
        {
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.BackgroundImage = Resources.close;
            this.picClose.RectColor = System.Drawing.Color.FromArgb(80, 160, 255);
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

        private void picLogo_Click(object sender, EventArgs e)
        {
            FrmAboutUs frmAboutUs = new FrmAboutUs();
            frmAboutUs.ShowDialog();
        }

        private void tsmiLoginBackSystem_Click(object sender, EventArgs e)
        {


        }

        private void picSetting_Click(object sender, EventArgs e)
        {
            cmsMain.Show(Cursor.Position);
        }

        private void picSetting_MouseDown(object sender, MouseEventArgs e)
        {
            this.picSetting.BackColor = System.Drawing.Color.FromArgb(111, 168, 255);
        }

        private void picSetting_MouseHover(object sender, EventArgs e)
        {
            this.picSetting.BackColor = System.Drawing.Color.FromArgb(111, 168, 255);
        }

        private void picSetting_MouseLeave(object sender, EventArgs e)
        {
            this.picSetting.BackColor = System.Drawing.Color.Transparent;
            this.picSetting.BackgroundImage = Resources.settings2;
            this.picSetting.RectColor = System.Drawing.Color.FromArgb(80, 160, 255);
        }

        private void notifyIcon1_BalloonTipClosed(object sender, EventArgs e)
        {
            notifyIcon1.Dispose();
        }
    }
}
