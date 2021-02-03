using System;
using System.Windows.Forms;
using SYS.Manager;
using SYS.Core;
using Sunny.UI;

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
            reserid = "R" + random.Next(0, 9).ToString() + random.Next(0, 9).ToString() + random.Next(0, 9).ToString() + random.Next(0, 9).ToString();
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
            int result1 = ReserManager.InserReserInfo(reser);
            int result2 = RoomManager.UpdateRoomInfoWithReser(room);

            if (result1 > 0 && result2 > 0)
            {
                MessageBox.Show("预约成功！请在指定时间内进行登记入住");
                #region 获取添加操作日志所需的信息
                Operation o = new Operation();
                o.OperationTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd,HH:mm:ss"));
                o.Operationlog = LoginInfo.WorkerClub + LoginInfo.WorkerPosition + LoginInfo.WorkerName + "于" + DateTime.Now + "帮助" + txtCustoTel.Text + "进行了预订房间操作！";
                o.OperationAccount = LoginInfo.WorkerClub + LoginInfo.WorkerPosition + LoginInfo.WorkerName;
                #endregion
                OperationlogManager.InsertOperationLog(o);
                this.Close();
            }


        }

        private void FrmRoomManager_Load(object sender, EventArgs e)
        {
            cboReserWay.SelectedIndex = 0;
            cboReserRoomNo.DataSource = RoomManager.SelectCanUseRoomAll();
            cboReserRoomNo.DisplayMember = "RoomNo";
            cboReserRoomNo.ValueMember = "typeName";
            cboReserRoomNo.Text = ucRoomList.co_RoomNo;
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