using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using EOM.TSHotelManager.Common.Core;
using SYS.FormUI.Properties;

using Sunny.UI;
using SYS.Common;
using System.Collections.Generic;
using SqlSugar;

namespace SYS.FormUI
{
    public partial class ucRoomList : UserControl
    {
        FrmRoomManager frm = null;
        Room r = null;

        public ucRoomList()
        {
            InitializeComponent();
            this.BorderStyle = BorderStyle.None;
            //traninfo = LoadRoomInfo(co_RoomNo, co_CustoNo, co_RoomPosition, co_CheckTime, co_RoomState);
            //string Roomno, string Custono, string Roompo, string Checktime, string Roomstate
        }

        #region 房态图圆角代码
        public GraphicsPath GetRoundRectPath(RectangleF rect, float radius)
        {
            return GetRoundRectPath(rect.X, rect.Y, rect.Width, rect.Height, radius);
        }
        public GraphicsPath GetRoundRectPath(float X, float Y, float width, float height, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddLine(X + radius, Y, (X + width) - (radius * 2f), Y);
            path.AddArc((X + width) - (radius * 2f), Y, radius * 2f, radius * 2f, 270f, 100f);
            path.AddLine((float)(X + width), (float)(Y + radius), (float)(X + width), (float)((Y + height) - (radius * 2f)));
            path.AddArc((float)((X + width) - (radius * 2f)), (float)((Y + height) - (radius * 2f)), (float)(radius * 2f), (float)(radius * 2f), 0f, 100f);
            path.AddLine((float)((X + width) - (radius * 2f)), (float)(Y + height), (float)(X + radius), (float)(Y + height));
            path.AddArc(X, (Y + height) - (radius * 2f), radius * 2f, radius * 2f, 100f, 100f);
            path.AddLine(X, (Y + height) - (radius * 2f), X, Y + radius);
            path.AddArc(X, Y, radius * 2f, radius * 2f, 180f, 100f);
            path.CloseFigure();
            return path;
        }

        //窗体圆角代码开始
        public void SetWindowRegion()
        {
            System.Drawing.Drawing2D.GraphicsPath FormPath;
            FormPath = new System.Drawing.Drawing2D.GraphicsPath();
            Rectangle rect = new Rectangle(0, 22, this.Width, this.Height - 22);
            //this.Left-10,this.Top-10,this.Width-10,this.Height-10);                 
            FormPath = GetRoundedRectPath(rect, 30);
            this.Region = new Region(FormPath);
        }
        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            int diameter = radius;
            Rectangle arcRect = new Rectangle(rect.Location, new Size(diameter, diameter));
            GraphicsPath path = new GraphicsPath();
            //   左上角   
            path.AddArc(arcRect, 180, 90);
            //   右上角   
            arcRect.X = rect.Right - diameter;
            path.AddArc(arcRect, 270, 90);
            //   右下角   
            arcRect.Y = rect.Bottom - diameter;
            path.AddArc(arcRect, 0, 90);
            //   左下角   
            arcRect.X = rect.Left;
            path.AddArc(arcRect, 90, 90);
            path.CloseFigure();
            return path;
        }
        protected override void OnResize(System.EventArgs e)
        {
            this.Region = null;
            SetWindowRegion();
        }
        #endregion

        private const uint WS_EX_LAYERED = 0x80000;
        private const int WS_EX_TRANSPARENT = 0x20;
        private const int GWL_STYLE = (-16);
        private const int GWL_EXSTYLE = (-20);
        [DllImport("user32", EntryPoint = "SetWindowLong")]
        private static extern uint SetWindowLong(
       IntPtr hwnd,
       int nIndex,
       uint dwNewLong
       );
        [DllImport("user32", EntryPoint = "GetWindowLong")]
        private static extern uint GetWindowLong(
       IntPtr hwnd,
       int nIndex
       );
        /// <summary>
        /// 使窗口有鼠标穿透功能
        /// </summary>
        public void CanPenetrate()
        {
            uint intExTemp = GetWindowLong(this.Handle, GWL_EXSTYLE);
            uint oldGWLEx = SetWindowLong(this.Handle, GWL_EXSTYLE, WS_EX_TRANSPARENT | WS_EX_LAYERED);
        }


        #region 存放房间信息类
        public static string rm_RoomNo;
        public static string rm_CustoNo;
        public static string rm_CustoName;
        public static string rm_RoomType;
        public static string rm_RoomMoney;
        public static DateTime? rm_CheckTime;
        public static int rm_RoomStateId;
        public static string co_RoomNo;
        public static string co_CustoNo;
        public static DateTime? co_CheckTime;
        public static string co_RoomPosition;
        public static string co_RoomState;
        public static string co_CustoName;
        public static string co_CustoType;
        public static string co_PersonNum;
        #endregion

        #region 存放用户信息类
        public static string us_CustoNo;
        public static string us_RoomNo;
        public static string us_CustoName;
        public static string us_CustoBirthday;
        public static string us_CustoSex;
        public static string us_CustoTel;
        public static int us_CustoPassportType;
        public static string us_CustoAddress;
        public static int us_CustoType;
        public static string us_CustoID;
        #endregion

        #region 实例化房态图的房间信息
        public string romTypeName;
        public Room romCustoInfo = new Room();
        public Custo romRoomInfo = new Custo();
        #endregion

        #region 鼠标点击房态图传值到类
        private void ucRoomList_Click(object sender, EventArgs e)
        {
            LoadRoomInfo();
        }
        #endregion

        #region 房态图加载事件方法
        private void ucRoomList_Load(object sender, EventArgs e)
        {
            this.CanPenetrate();
            this.Region = new Region(GetRoundRectPath(new RectangleF(0, 0, this.Width, this.Height), 6f));
            us_CustoNo = romRoomInfo.CustoNo;
            us_CustoName = romRoomInfo.CustoName;
            us_CustoSex = romRoomInfo.CustoSex == 1 ? "男" : "女";
            us_CustoTel = romRoomInfo.CustoTel;
            us_CustoID = romRoomInfo.CustoID;
            us_CustoBirthday = romRoomInfo.CustoBirth == null? "":Convert.ToDateTime(romRoomInfo.CustoBirth).ToString();
            us_CustoPassportType = romRoomInfo.PassportType;
            us_CustoType = romRoomInfo.CustoType;
            us_CustoAddress = romRoomInfo.CustoAdress;
            switch (romCustoInfo.RoomStateId)
            {
                case 0:
                    BackgroundImage = Resources.可住状态;
                    break;
                case 1:
                    BackgroundImage = Resources.已住状态;
                    break;
                case 2:
                    BackgroundImage = Resources.维修状态;
                    break;
                case 3:
                    BackgroundImage = Resources.脏房状态;
                    break;
                case 4:
                    BackgroundImage = Resources.预约状态;
                    break;
            }
            
        }
        #endregion

        #region 当右键菜单打开时事件方法
        private void cmsMain_Opening(object sender, CancelEventArgs e)
        {
            Dictionary<string, string> room = new Dictionary<string, string>();
            room.Add("no", lblRoomNo.Text);
            var result = HttpHelper.Request("Room/SelectRoomByRoomNo", null,room);

            if (result.statusCode != 200)
            {
                UIMessageBox.Show("接口服务异常！", "来自小T提示", UIStyle.Red);
                return;
            }
            r = HttpHelper.JsonToModel<Room>(result.message);
            if (lblCustoNo.Text != "")
            {
                tsmiCheckIn.Enabled = false;
                tsmiCheckOut.Enabled = true;
                tsmiSelectUserInfo.Enabled = true;
                tsmiChangeState.Enabled = false;
                tsmiChangeRoom.Enabled = true;
                tsmiReserRoom.Enabled = false;
            }
            else if (r.RoomStateId == 3 || r.RoomStateId == 2)
            {
                tsmiCheckIn.Enabled = false;
                tsmiCheckOut.Enabled = false;
                tsmiSelectUserInfo.Enabled = false;
                tsmiChangeState.Enabled = true;
                tsmiChangeRoom.Enabled = false;
                tsmiReserRoom.Enabled = false;
            }
            else if (r.RoomStateId == 4)
            {
                tsmiCheckIn.Enabled = true;
                tsmiCheckOut.Enabled = false;
                tsmiSelectUserInfo.Enabled = false;
                tsmiChangeState.Enabled = true;
                tsmiChangeRoom.Enabled = false;
                tsmiReserRoom.Enabled = false;
            }
            else if (lblCustoNo.Text == "")
            {
                tsmiCheckIn.Enabled = true;
                tsmiCheckOut.Enabled = false;
                tsmiSelectUserInfo.Enabled = false;
                tsmiChangeState.Enabled = true;
                tsmiChangeRoom.Enabled = false;
                tsmiReserRoom.Enabled = true;
            }


        }
        #endregion

        #region 入住房间事件方法
        private void tsmiCheckIn_Click(object sender, EventArgs e)
        {
            if (r.RoomStateId == 4)
            {
                rm_CustoNo = lblCustoNo.Text;
                rm_RoomNo = lblRoomNo.Text;
                rm_RoomType = lblRoomType.Text;
                rm_RoomMoney = Convert.ToDecimal(romCustoInfo.RoomMoney).ToString();
                rm_RoomStateId = 4;
                UIMessageBox.ShowInfo("欢迎入住，请先注册客户信息！");
                FrmReserList frm = new FrmReserList();
                frm.ShowDialog();
                return;
            }
            else
            {
                rm_CustoNo = lblCustoNo.Text;
                rm_RoomNo = lblRoomNo.Text;
                rm_RoomType = lblRoomType.Text;
                rm_RoomMoney = Convert.ToDecimal(romCustoInfo.RoomMoney).ToString();
                FrmCheckIn frm = new FrmCheckIn();
                frm.Show();
            }



        }
        #endregion

        #region 退房事件方法
        private void tsmiCheckOut_Click(object sender, EventArgs e)
        {
            rm_CustoNo = lblCustoNo.Text;
            rm_RoomNo = lblRoomNo.Text;
            rm_RoomType = lblRoomType.Text;
            FrmCheckOutForm frm = new FrmCheckOutForm();
            frm.Show();
        }
        #endregion

        #region 双击进入入住/退房事件方法
        private void ucRoomList_DoubleClick(object sender, EventArgs e)
        {
            List<Custo> custos = new List<Custo>();
            if (!lblCustoNo.Text.IsNullOrEmpty())
            {
                Dictionary<string, string> dic = new Dictionary<string, string>()
                {
                    { "CustoNo",lblCustoNo.Text.Trim() }
                } ;
                var result = HttpHelper.Request("Custo/SelectCardInfoByCustoNo", null, dic);
                if (result.statusCode != 200)
                {
                    UIMessageBox.ShowError("SelectCardInfoByCustoNo+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }

                Room r = HttpHelper.JsonToModel<Room>(result.message);
                if (r.RoomStateId == 0)
                {
                    rm_RoomNo = lblRoomNo.Text;
                    FrmCheckIn frm = new FrmCheckIn();
                    frm.Show();
                }
                else
                {
                    return;
                }

            }
            else
            {
                rm_CustoNo = lblCustoNo.Text;
                rm_RoomNo = lblRoomNo.Text;
                rm_RoomType = lblRoomType.Text;
                FrmCheckOutForm frm = new FrmCheckOutForm();
                frm.Show();
            }
        }
        #endregion

        private void tsmiSelectUserInfo_Click(object sender, EventArgs e)
        {
            rm_CustoNo = lblCustoNo.Text;
            FrmSelectCustoInfo frm = new FrmSelectCustoInfo();
            frm.Show();
        }

        #region 修改房间状态
        private void tsmiChangeState_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> room = new Dictionary<string, string>
            {
                { "roomno", lblRoomNo.Text }
            };
            var result = HttpHelper.Request("Room/SelectRoomStateIdByRoomNo", null, room);

            if (result.statusCode != 200)
            {
                UIMessageBox.Show("SelectRoomStateIdByRoomNo+接口服务异常！", "来自小T提示", UIStyle.Red);
                return;
            }
            rm_RoomStateId = Convert.ToInt32(result.message);
            rm_RoomNo = lblRoomNo.Text;
            FrmRoomStateManager frsm = new FrmRoomStateManager();
            frsm.ShowDialog();
        }
        #endregion

        public static string RoomNo;
        public static string CustoNo;
        public static string RoomState;
        private void tsmiChangeRoom_Click(object sender, EventArgs e)
        {
            bool tf = UIMessageBox.Show("确定要进行转房吗？", "来自小T的提醒", UIStyle.Orange, UIMessageBoxButtons.OKCancel);
            if (tf)
            {
                RoomNo = lblRoomNo.Text;
                CustoNo = lblCustoNo.Text;
                RoomState = lblRoomType.Text;
                FrmChangeRoom frm = new FrmChangeRoom();
                frm.Show();
            }

        }

        private void tsmiReserRoom_Click(object sender, EventArgs e)
        {
            FrmReserManager frm = new FrmReserManager();

            frm.Show();

        }

        private void ucRoomList_SizeChanged(object sender, EventArgs e)
        {
            this.Width = 125;
            this.Height = 85;
        }

        public void LoadRoomInfo()
        {
            co_RoomNo = romCustoInfo.RoomNo;
            co_CustoNo = romCustoInfo.CustoName;
            romTypeName = romCustoInfo.RoomName;
            co_CheckTime = romCustoInfo.CheckTime;
            co_RoomPosition = romCustoInfo.RoomPosition;
            co_RoomState = romCustoInfo.RoomState;

        }

        private void ucRoomList_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (lblMark.Text.Trim().IsNullOrEmpty())
                {
                    LoadRoomInfo();
                    FrmRoomManager.ReadInfo();
                }
                else
                {
                    cmsMain.Enabled = false;
                    return;
                }
            }
            catch (Exception)
            {

            }
        }

        private void lblRoomType_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (lblMark.Text.Trim().IsNullOrEmpty())
                {
                    LoadRoomInfo();
                    FrmRoomManager.ReadInfo();
                }
                else
                {
                    cmsMain.Enabled = false;
                    return;
                }
            }
            catch (Exception)
            {

            }
        }

        private void lblRoomNo_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (lblMark.Text.Trim().IsNullOrEmpty())
                {
                    LoadRoomInfo();
                    FrmRoomManager.ReadInfo();
                }
                else
                {
                    cmsMain.Enabled = false;
                    return;
                }
            }
            catch (Exception)
            {

            }
        }

        private void lblCustoNo_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (lblMark.Text.Trim().IsNullOrEmpty())
                {
                    LoadRoomInfo();
                    FrmRoomManager.ReadInfo();
                }
                else
                {
                    cmsMain.Enabled = false;
                    return;
                }
            }
            catch (Exception)
            {

            }
        }

    }
}
