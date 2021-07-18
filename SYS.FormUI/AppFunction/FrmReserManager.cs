using System;
using System.Windows.Forms;
using SYS.Core;
using Sunny.UI;
using SYS.Application;

namespace SYS.FormUI
{
    public partial class FrmReserManager : UIForm
    {
        public FrmReserManager()
        {
            InitializeComponent();
            #region 防止背景闪屏方法
            this.DoubleBuffered = true;//设置本窗体
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲 
            #endregion
        }

        private void btnReser_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string reserid = "";
            reserid = new CounterHelper().GetNewId(CounterRuleConsts.ReserId);
            Reser reser = new Reser()
            {
                ReserId = reserid,
                CustoName = txtCustoName.Text.Trim(),
                CustoTel = txtCustoTel.Text.Trim(),
                ReserWay = cboReserWay.Text,
                ReserRoom = cboReserRoomNo.Text,
                ReserDate = dtpBouDate.Value,
                ReserEndDay = dtpEndDate.Value
            };
            Room room = new Room() 
            {
                RoomNo = cboReserRoomNo.Text,
                RoomStateId = 4
            };
            bool result1 = new ReserService().InserReserInfo(reser);
            bool result2 = new RoomService().UpdateRoomInfoWithReser(room);

            if (result1 == true && result2 == true)
            {
                UIMessageBox.ShowSuccess("预约成功！请在指定时间内进行登记入住");
                #region 获取添加操作日志所需的信息
                RecordHelper.Record(LoginInfo.WorkerClub + LoginInfo.WorkerPosition + LoginInfo.WorkerName + "于" + DateTime.Now + "帮助" + txtCustoTel.Text + "进行了预订房间操作！", 1);
                #endregion
                FrmRoomManager.Reload("");
                this.Close();

            }


        }

        private void FrmRoomManager_Load(object sender, EventArgs e)
        {
            foreach (Control label in this.Controls)
            {
                label.Font = UI_FontUtil.controlFont;
            }
            cboReserWay.SelectedIndex = 0;
            cboReserRoomNo.DataSource = new RoomService().SelectCanUseRoomAll();
            cboReserRoomNo.DisplayMember = "RoomNo";
            cboReserRoomNo.ValueMember = "RoomNo";
            cboReserRoomNo.Text = ucRoomList.co_RoomNo;
            dtpBouDate.Value = DateTime.Now;
        }

        private void btnReserList_Click(object sender, EventArgs e)
        {
            FrmReserList frm = new FrmReserList();
            frm.Show();
        }

        private void dtpBouDate_ValueChanged(object sender, DateTime value)
        {
            dtpEndDate.Value = DateTime.Now.AddDays(3);
        }
    }
}