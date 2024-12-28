using EOM.TSHotelManager.Common;
using EOM.TSHotelManager.Common.Core;
using EOM.TSHotelManager.FormUI.Properties;
using jvncorelib.EntityLib;
using Sunny.UI;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace EOM.TSHotelManager.FormUI
{
    public partial class ucRoom : UserControl
    {
        public ucRoom()
        {
            InitializeComponent();
        }


        ResponseMsg result = new ResponseMsg();
        Dictionary<string, string> getParam = new Dictionary<string, string>();
        string postParam = string.Empty;

        #region 存放房间信息类
        //用于结算、转房显示信息用
        public static string? rm_RoomNo;
        public static string? rm_CustoNo;
        public static string? rm_RoomType;
        public static string? rm_RoomMoney;
        public static int rm_RoomStateId;

        public static string? co_RoomNo;
        public static string? co_CustoNo;
        public static DateTime? co_CheckTime;
        public static string? co_RoomPosition;
        public static string? co_RoomState;
        public static string? co_CustoName;
        public static string? co_CustoType;
        #endregion

        #region 存放用户信息类
        //用于房态图、查看用户信息用
        public static string? us_CustoNo;
        public static string? us_RoomNo;
        public static string? us_CustoName;
        public static string? us_CustoBirthday;
        public static string? us_CustoSex;
        public static string? us_CustoTel;
        public static int us_CustoPassportType;
        public static string? us_CustoAddress;
        public static int us_CustoType;
        public static string? us_CustoID;
        #endregion

        #region 实例化房态图的房间信息
        public string romTypeName;
        public Room romRoomInfo { get; set; }
        public Custo romCustoInfo { get; set; }
        #endregion

        public string lblMark { get; set; }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            if (lblMark == "Mark")
            {
                return;
            }
            LoadRoomInfo();
            FrmRoomManager.ReadInfo();
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

        public void LoadRoomInfo()
        {
            co_RoomNo = romRoomInfo.RoomNo;
            co_CustoNo = romCustoInfo.CustoNo;
            co_CustoName = romCustoInfo.CustoName;
            romTypeName = romRoomInfo.RoomName;
            co_CheckTime = romRoomInfo.CheckTime;
            co_RoomPosition = romRoomInfo.RoomPosition;
            co_RoomState = romRoomInfo.RoomState;

        }

        private static List<string>? roomInfo = null;

        private void ucRoom_Load(object sender, EventArgs e)
        {
            this.CanPenetrate();
            this.Region = new Region(GetRoundRectPath(new RectangleF(0, 0, this.Width, this.Height), 6f));
            if (romCustoInfo != null)
            {
                us_CustoNo = romCustoInfo.CustoNo;
                us_CustoName = romCustoInfo.CustoName;
                us_CustoSex = romCustoInfo.CustoSex == 1 ? "男" : "女";
                us_CustoTel = romCustoInfo.CustoTel;
                us_CustoID = romCustoInfo.CustoID;
                us_CustoBirthday = romCustoInfo.CustoBirth == default ? "" : Convert.ToDateTime(romCustoInfo.CustoBirth).ToString();
                us_CustoPassportType = romCustoInfo.PassportType;
                us_CustoType = romCustoInfo.CustoType;
                us_CustoAddress = romCustoInfo.CustoAdress;
            }
            switch (romRoomInfo.RoomStateId)
            {
                case 0:
                    btnRoom.BackgroundImage = Resources.可住状态;
                    break;
                case 1:
                    btnRoom.BackgroundImage = Resources.已住状态;
                    break;
                case 2:
                    btnRoom.BackgroundImage = Resources.维修状态;
                    break;
                case 3:
                    btnRoom.BackgroundImage = Resources.脏房状态;
                    break;
                case 4:
                    btnRoom.BackgroundImage = Resources.预约状态;
                    break;
            }
            btnRoom.BackgroundImageLayout = AntdUI.TFit.Cover;
        }

        Room r;
        private void tsmiReserRoom_Click(object sender, EventArgs e)
        {
            FrmReserManager frm = new FrmReserManager();
            frm.Show();
        }
        private void cmsMain_Opening(object sender, CancelEventArgs e)
        {
            if (lblMark == "Mark")
            {
                e.Cancel = true;
                return;
            }
            var roomText = btnRoom.Text?.Split("\n\n");
            if (roomText == null || roomText.Length < 2)
            {
                UIMessageBox.Show("房间信息不完整！", "来自小T提示", UIStyle.Red);
                return;
            }
            getParam = new Dictionary<string, string>
            {
                { "no", roomText[1] }
            };
            result = HttpHelper.Request("Room/SelectRoomByRoomNo", string.Empty, getParam);

            if (result.statusCode != 200)
            {
                UIMessageBox.Show("接口服务异常！", "来自小T提示", UIStyle.Red);
                return;
            }
            r = HttpHelper.JsonToModel<Room>(result.message!)!;
            if (r.RoomStateId == 1)
            {
                tsmiCheckIn.Enabled = false;
                tsmiCheckOut.Enabled = true;
                tsmiSelectUserInfo.Enabled = true;
                tsmiChangeState.Enabled = false;
                tsmiChangeRoom.Enabled = true;
                tsmiReserRoom.Enabled = false;
            }
            else if (r.RoomStateId == 2 || r.RoomStateId == 3)
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
            else
            {
                tsmiCheckIn.Enabled = true;
                tsmiCheckOut.Enabled = false;
                tsmiSelectUserInfo.Enabled = false;
                tsmiChangeState.Enabled = true;
                tsmiChangeRoom.Enabled = false;
                tsmiReserRoom.Enabled = true;
            }
        }

        private void tsmiCheckIn_Click(object sender, EventArgs e)
        {
            if (romCustoInfo != null && romRoomInfo != null)
            {
                if (r.RoomStateId == 4)
                {
                    rm_CustoNo = romCustoInfo.CustoNo;
                    rm_RoomNo = romRoomInfo.RoomNo;
                    rm_RoomType = romRoomInfo.RoomName;
                    rm_RoomMoney = Convert.ToDecimal(romRoomInfo.RoomMoney).ToString();
                    rm_RoomStateId = 4;
                    UIMessageBox.ShowInfo("欢迎入住，请先注册客户信息！");
                    FrmReserList frm = new FrmReserList();
                    frm.ShowDialog();
                    return;
                }
                else
                {
                    rm_CustoNo = romCustoInfo.CustoNo;
                    rm_RoomNo = romRoomInfo.RoomNo;
                    rm_RoomType = romRoomInfo.RoomName;
                    rm_RoomMoney = Convert.ToDecimal(romRoomInfo.RoomMoney).ToString();
                    FrmCheckIn frm = new FrmCheckIn();
                    frm.Show();
                }
            }
            else
            {
                UIMessageBox.Show("房间信息不完整！", "来自小T提示", UIStyle.Red);
            }
        }

        private void tsmiCheckOut_Click(object sender, EventArgs e)
        {
            rm_CustoNo = romRoomInfo.CustoNo;
            rm_RoomNo = romRoomInfo.RoomNo;
            rm_RoomType = romRoomInfo.RoomName;
            FrmCheckOutForm frm = new FrmCheckOutForm();
            frm.Show();
        }

        public static string? RoomNo;
        public static string? CustoNo;
        public static string? RoomState;
        private void tsmiChangeRoom_Click(object sender, EventArgs e)
        {
            if (romCustoInfo != null && romRoomInfo != null)
            {
                bool tf = UIMessageBox.Show("确定要进行转房吗？", "来自小T的提醒", UIStyle.Orange, UIMessageBoxButtons.OKCancel);
                if (tf)
                {
                    RoomNo = romRoomInfo.RoomNo;
                    CustoNo = romCustoInfo.CustoNo;
                    RoomState = romRoomInfo.RoomState;
                    FrmChangeRoom frm = new FrmChangeRoom();
                    frm.Show();
                }
            }
            else
            {
                UIMessageBox.Show("房间信息不完整！", "来自小T提示", UIStyle.Red);
            }
        }

        private void tsmiSelectUserInfo_Click(object sender, EventArgs e)
        {
            rm_CustoNo = romCustoInfo.CustoNo;
            FrmSelectCustoInfo frm = new FrmSelectCustoInfo();
            frm.Show();
        }

        private void tsmiChangeState_Click(object sender, EventArgs e)
        {
            if (r.RoomStateId == 4)
            {
                bool tf = UIMessageBox.Show("当前房间已被预约，确认更改状态后将会删除原本预约状态及信息，你确定吗？", "来自小T的提醒", UIStyle.Red, UIMessageBoxButtons.OKCancel);
                if (tf)
                {
                    getParam = new Dictionary<string, string>()
                    {
                        {"no",r.RoomNo }
                    };
                    result = HttpHelper.Request("Reser/SelectReserInfoByRoomNo", null, getParam);
                    if (result.statusCode != 200)
                    {
                        UIMessageBox.Show("SelectReserInfoByRoomNo+接口服务异常！", "来自小T提示", UIStyle.Red);
                        return;
                    }
                    else
                    {
                        var reser = new Reser
                        {
                            ReserId = HttpHelper.JsonToModel<Reser>(result.message!)!.ReserId
                        };
                        result = HttpHelper.Request("Reser/DeleteReserInfo", HttpHelper.ModelToJson(reser), null);
                        if (result.statusCode != 200)
                        {
                            UIMessageBox.Show("DeleteReserInfo+接口服务异常！", "来自小T提示", UIStyle.Red);
                            return;
                        }
                    }
                }
            }
            if (romCustoInfo != null && romRoomInfo != null)
            {
                rm_RoomStateId = romRoomInfo.RoomStateId;
                rm_RoomNo = romRoomInfo.RoomNo;
                FrmRoomStateManager frsm = new FrmRoomStateManager();
                frsm.ShowDialog();
            }
            else
            {
                UIMessageBox.Show("房间信息不完整！", "来自小T提示", UIStyle.Red);
            }
        }
    }
}
