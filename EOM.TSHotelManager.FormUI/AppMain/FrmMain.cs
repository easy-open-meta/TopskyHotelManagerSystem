/*
 * MIT License
 *Copyright (c) 2021 易开元(EOM)

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

using AntdUI;
using EOM.TSHotelManager.Common;
using EOM.TSHotelManager.Common.Core;
using EOM.TSHotelManager.FormUI.AppUserControls;
using EOM.TSHotelManager.FormUI.Properties;
using Sunny.UI;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace EOM.TSHotelManager.FormUI
{
    public partial class FrmMain : Window
    {
        private FrmLogin returnForm1 = null;
        private LoadingProgress _loadingProgress;

        public FrmMain(FrmLogin F1, LoadingProgress loadingProgress)
        {
            InitializeComponent();
            _loadingProgress = loadingProgress;

            #region 防止背景闪屏方法
            this.DoubleBuffered = true;//设置本窗体
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲 
            #endregion
            cpUITheme.ValueChanged += cpUITheme_ValueChanged;
            Control.CheckForIllegalCrossThreadCalls = false;//关闭线程检查
            //Main = this;//储存主窗口实例对象
            // 接受Form1对象
            this.returnForm1 = F1;
            #region 获取添加操作日志所需的信息
            RecordHelper.Record(LoginInfo.WorkerNo + "-" + LoginInfo.WorkerName + "在" + Convert.ToDateTime(DateTime.Now) + "位于" + LoginInfo.SoftwareVersion + "版本登入了系统！", 3);
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

        #region 定时器：获取网络时间
        private void tmrDate_Tick(object sender, EventArgs e)
        {
            lblTime.Text = Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd HH:mm");

            DateTime tmCur = Convert.ToDateTime(DateTime.Now);

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
        private void picClose_Click(object sender, EventArgs e)
        {

            System.Windows.Forms.Application.Exit();
            notifyIcon1.Dispose();
        }
        #endregion

        #region 窗体最小化
        private void picFormSize_Click(object sender, EventArgs e)
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
            muNavBar.Controls.Clear();
            listSource = HttpHelper.JsonToList<NavBar>(result.message);
            MenuItem menuItem = null;
            if (!listSource.IsNullOrEmpty())
            {
                foreach (var item in listSource)
                {
                    menuItem = new MenuItem
                    {
                        Text = item.nav_name
                    };
                    switch (item.nav_name)
                    {
                        case "客房管理":
                            menuItem.Icon = Resources.picRoom_Image;
                            break;
                        case "用户管理":
                            menuItem.Icon = Resources.picCustomer_Image;
                            break;
                        case "商品消费":
                            menuItem.Icon = Resources.picCommodity_Image;
                            break;
                    }
                    muNavBar.Items.Add(menuItem);
                }
            }
            else
            {
                AntdUI.Message.error(this, "服务器维护中，请过会再试");
                return;
            }
            #endregion
        }

        #region 窗体加载事件方法
        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Owner.Hide();
            
            lblSoftName.Text = System.Windows.Forms.Application.ProductName.ToString() + "_V" + ApplicationUtil.GetApplicationVersion();

            tmrDate.Enabled = true;

            LoadNavBar();

            LoadFonts();

            lblTime.Text = Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd HH:mm");

            DateTime tmCur = Convert.ToDateTime(DateTime.Now);

            if (tmCur.Hour < 8 || tmCur.Hour > 18)
            {//晚上
                label3.Text = "(*´▽｀)ノノ晚上好 " + LoginInfo.WorkerName;
                btnHello.BackgroundImage = Resources.月亮;
            }
            else if (tmCur.Hour > 8 && tmCur.Hour < 12)
            {//上午
                label3.Text = "(*´▽｀)ノノ上午好 " + LoginInfo.WorkerName;
                btnHello.BackgroundImage = Resources.早上;
            }
            else
            {//下午
                label3.Text = "(*´▽｀)ノノ下午好 " + LoginInfo.WorkerName;
                btnHello.BackgroundImage = Resources.咖啡;
            }
            //SetClassLong(this.Handle, GCL_STYLE, GetClassLong(this.Handle, GCL_STYLE) | CS_DropSHADOW); //API函数加载，实现窗体边框阴影效果

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
            notifyIcon1.Text = "TS酒店管理系统-" + LoginInfo.WorkerName + "-版本号：" + ApplicationUtil.GetApplicationVersion();
            wk_WorkerName = LoginInfo.WorkerName;
            pnlMID.Controls.Clear();
            FrmRoomManager frm1 = new FrmRoomManager();
            frm1.TopLevel = false;
            pnlMID.Controls.Add(frm1);
            frm1.Show();

            if (_loadingProgress != null)
            {
                _loadingProgress.Close();
            }

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
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Process.Start(new ProcessStartInfo(_base.url_addr) { UseShellExecute = true });
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                Process.Start("xdg-open", _base.url_addr);
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                Process.Start("open", _base.url_addr);
            }
            else
            {
                throw new PlatformNotSupportedException("This OS is not supported");
            }
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
            Dictionary<string, string> user = new()
            {
                { "wkn", LoginInfo.WorkerNo }
            };
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
                    WorkerCheck workerCheck = new()
                    {
                        WorkerNo = LoginInfo.WorkerNo,
                        CheckWay = "系统界面",
                        CheckTime = DateTime.Now,
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

        private void btnSetting_Click(object sender, EventArgs e)
        {
            cmsMain.Show(Cursor.Position);
        }

        private void notifyIcon1_BalloonTipClosed(object sender, EventArgs e)
        {
            notifyIcon1.Dispose();
        }

        private void cpUITheme_ValueChanged(object sender, ColorEventArgs e)
        {
            AntdUI.Style.Db.SetPrimary(e.Value);
            Refresh();
        }

        private void muNavBar_SelectChanged(object sender, MenuSelectEventArgs e)
        {
            _loadingProgress.Show();
            switch (e.Value.Text)
            {
                case "客房管理":
                    pnlMID.Controls.Clear();
                    FrmRoomManager frmRoomManager = new()
                    {
                        TopLevel = false
                    };
                    pnlMID.Controls.Add(frmRoomManager);
                    frmRoomManager.Show();
                    break;
                case "用户管理":
                    pnlMID.Controls.Clear();
                    FrmCustomerManager frmCustomerManager = new()
                    {
                        TopLevel = false
                    };
                    pnlMID.Controls.Add(frmCustomerManager);
                    frmCustomerManager.Show();
                    break;
                case "商品消费":
                    pnlMID.Controls.Clear();
                    FrmSellThing frmSellThing = new()
                    {
                        TopLevel = false
                    };
                    pnlMID.Controls.Add(frmSellThing);
                    frmSellThing.Show();
                    break;
            }
            _loadingProgress.Close();

        }
    }
}
