using EOM.TSHotelManager.Common.Core;
using Sunny.UI;
using SYS.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SYS.FormUI
{
    public partial class ucRoom : UserControl
    {
        private const uint WS_EX_LAYERED = 0x80000;
        private const int WS_EX_TRANSPARENT = 0x20;
        private const int GWL_STYLE = (-16);
        private const int GWL_EXSTYLE = (-20);
        [DllImport("user32", EntryPoint = "SetWindowLong")]
        private static extern uint SetWindowLong(IntPtr hwnd, int nIndex, uint dwNewLong);
        [DllImport("user32", EntryPoint = "GetWindowLong")]
        private static extern uint GetWindowLong(IntPtr hwnd, int nIndex);

        /// <summary>
        /// 使窗口有鼠标穿透功能
        /// </summary>
        public void CanPenetrate()
        {
            uint intExTemp = GetWindowLong(this.Handle, GWL_EXSTYLE);
            uint oldGWLEx = SetWindowLong(this.Handle, GWL_EXSTYLE, WS_EX_TRANSPARENT | WS_EX_LAYERED);
        }

        public ucRoom()
        {
            InitializeComponent();
            this.CanPenetrate();
        }

        Dictionary<string, string> dic = null;
        ResponseMsg result = null;

        #region 存放房间信息类
        public static string rm_RoomNo;
        public static string rm_CustoNo;
        public static string rm_RoomType;
        public static string rm_RoomMoney;
        public static string rm_CheckTime;
        public static int rm_RoomStateId;
        public static string co_RoomNo;
        public static string co_CustoNo;
        public static string co_CheckTime;
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

        private void ucRoom_Load(object sender, EventArgs e)
        {
            us_CustoNo = romRoomInfo.CustoNo;
            us_CustoName = romRoomInfo.CustoName;
            us_CustoSex = romRoomInfo.CustoSex == 1 ? "男" : "女";
            us_CustoTel = romRoomInfo.CustoTel;
            us_CustoID = romRoomInfo.CustoID;
            us_CustoBirthday = Convert.ToDateTime(romRoomInfo.CustoBirth).ToString();
            us_CustoPassportType = romRoomInfo.PassportType;
            us_CustoType = romRoomInfo.CustoType;
            us_CustoAddress = romRoomInfo.CustoAdress;
            switch (romCustoInfo.RoomStateId)
            {
                case 0:
                    leRoomState.Text = "可入住";
                    break;
                case 1:
                    leRoomState.Text = "已住状态";
                    break;
                case 2:
                    leRoomState.Text = "维修中";
                    break;
                case 3:
                    leRoomState.Text = "脏  房";
                    break;
                case 4:
                    leRoomState.Text = "已预约";
                    break;
            }
        }

        /// <summary>
        /// 加载房间信息
        /// </summary>
        public void LoadRoomInfo()
        {
            co_RoomNo = romCustoInfo.RoomNo;
            co_CustoNo = romCustoInfo.CustoNo;
            romTypeName = romCustoInfo.RoomName;
            co_CheckTime = romCustoInfo.CheckTimeFormat;
            co_RoomPosition = romCustoInfo.RoomPosition;
            co_RoomState = romCustoInfo.RoomState;

        }

        private void ucRoom_MouseClick(object sender, MouseEventArgs e)
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
                    cmsControlPanel.Enabled = false;
                    return;
                }
            }
            catch (Exception)
            {

            }
        }

        private void ucRoom_Click(object sender, EventArgs e)
        {
            LoadRoomInfo();
        }

        Room r = null;
        private void cmsControlPanel_Opening(object sender, CancelEventArgs e)
        {
            dic = new Dictionary<string, string>()
            {
                { "no",leRoomNo.Text.Trim()}
            };
            result = HttpHelper.Request("Room/SelectRoomByRoomNo", null, dic);
            if (result.statusCode != 200)
            {
                UIMessageTip.ShowError("SelectRoomByRoomNo+接口服务异常，请提交issue");
                return;
            }
            r = HttpHelper.JsonToModel<Room>(result.message);
            if (!r.CustoNo.IsNullOrEmpty())
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
            else if (r.CustoNo.IsNullOrEmpty())
            {
                tsmiCheckIn.Enabled = true;
                tsmiCheckOut.Enabled = false;
                tsmiSelectUserInfo.Enabled = false;
                tsmiChangeState.Enabled = true;
                tsmiChangeRoom.Enabled = false;
                tsmiReserRoom.Enabled = true;
            }
        }

        /// <summary>
        /// 入住房间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiCheckIn_Click(object sender, EventArgs e)
        {
            if (r.RoomStateId == 4)
            {
                rm_CustoNo = leCustoNo.Text;
                rm_RoomNo = leRoomNo.Text;
                rm_RoomType = leRoomType.Text;
                rm_RoomMoney = Convert.ToDecimal(romCustoInfo.RoomMoney).ToString();
                rm_RoomStateId = 4;
                UIMessageBox.ShowInfo("欢迎入住，请先注册客户信息！");
                FrmReserList frm = new FrmReserList();
                frm.ShowDialog();
                return;
            }
            else
            {
                rm_CustoNo = leCustoNo.Text;
                rm_RoomNo = leRoomNo.Text;
                rm_RoomType = leRoomType.Text;
                rm_RoomMoney = Convert.ToDecimal(romCustoInfo.RoomMoney).ToString();
                FrmCheckIn frm = new FrmCheckIn();
                frm.Show();
            }
        }

        /// <summary>
        /// 退房结算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiCheckOut_Click(object sender, EventArgs e)
        {
            rm_CustoNo = leCustoNo.Text;
            rm_RoomNo = leRoomNo.Text;
            rm_RoomType = leRoomType.Text;
            FrmCheckOutForm frm = new FrmCheckOutForm();
            frm.Show();
        }

        /// <summary>
        /// 双击入住
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ucRoom_DoubleClick(object sender, EventArgs e)
        {
            if (leCustoNo.Text.IsNullOrEmpty())
            {
                dic = new Dictionary<string, string>()
                {
                    { "no",leRoomNo.Text.Trim()}
                };
                result = HttpHelper.Request("Room/SelectRoomByRoomNo", null, dic);
                if (result.statusCode != 200)
                {
                    UIMessageTip.ShowError("SelectRoomByRoomNo+接口服务异常，请提交issue");
                    return;
                }
                Room r = HttpHelper.JsonToModel<Room>(result.message);
                if (r.RoomStateId == 0)
                {
                    rm_RoomNo = leRoomNo.Text;
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
                rm_CustoNo = leCustoNo.Text;
                rm_RoomNo = leRoomNo.Text;
                rm_RoomType = leRoomType.Text;
                FrmCheckOutForm frm = new FrmCheckOutForm();
                frm.Show();
            }
        }

        /// <summary>
        /// 查看客户信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiSelectUserInfo_Click(object sender, EventArgs e)
        {
            rm_CustoNo = leCustoNo.Text;
            FrmSelectCustoInfo frm = new FrmSelectCustoInfo();
            frm.Show();
        }

        /// <summary>
        /// 修改房间状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiChangeState_Click(object sender, EventArgs e)
        {
            dic = new Dictionary<string, string>()
            {
                { "roomno",leRoomNo.Text.Trim()}
            };
            result = HttpHelper.Request("Room/SelectRoomStateIdByRoomNo", null, dic);
            if (result.statusCode != 200)
            {
                UIMessageTip.ShowError("SelectRoomStateIdByRoomNo+接口服务异常，请提交issue");
                return;
            }
            rm_RoomStateId = Convert.ToInt32(result.message.ToString());
            rm_RoomNo = leRoomNo.Text;
            FrmRoomStateManager frsm = new FrmRoomStateManager();
            frsm.ShowDialog();
        }

        public static string RoomNo;
        public static string CustoNo;
        /// <summary>
        /// 转换房间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiChangeRoom_Click(object sender, EventArgs e)
        {
            bool tf = UIMessageBox.Show("确定要进行转房吗？", "来自小T的提醒", UIStyle.Orange, UIMessageBoxButtons.OKCancel);
            if (tf)
            {
                RoomNo = leRoomNo.Text;
                CustoNo = leCustoNo.Text;
                FrmChangeRoom frm = new FrmChangeRoom();
                frm.Show();
            }
        }

        /// <summary>
        /// 预约房间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiReserRoom_Click(object sender, EventArgs e)
        {
            FrmReserManager frm = new FrmReserManager();
            frm.Show();
        }

        private void ucRoom_MouseHover(object sender, EventArgs e)
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
                    cmsControlPanel.Enabled = false;
                    return;
                }
            }
            catch (Exception)
            {

            }
        }

        private void ucRoom_MouseEnter(object sender, EventArgs e)
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
                    cmsControlPanel.Enabled = false;
                    return;
                }
            }
            catch (Exception)
            {

            }
        }

        private void leRoomType_Click(object sender, EventArgs e)
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
                    cmsControlPanel.Enabled = false;
                    return;
                }
            }
            catch (Exception)
            {

            }
        }

        private void leRoomNo_Click(object sender, EventArgs e)
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
                    cmsControlPanel.Enabled = false;
                    return;
                }
            }
            catch (Exception)
            {

            }
        }

        private void leCustoNo_Click(object sender, EventArgs e)
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
                    cmsControlPanel.Enabled = false;
                    return;
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
