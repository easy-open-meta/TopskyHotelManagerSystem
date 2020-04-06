using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using TSHotelManagerSystem.DAL;
using TSHotelManagerSystem.Models;
using TSHotelManagerSystem.BLL;

namespace TSHotelManagerSystem
{
    public partial class FrmReserManager : Form
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
            string sql1 = string.Format("insert Reser values('"+reserid+"','" + txtCustoName.Text + "','" + txtCustoTel.Text + "','" + cboReserWay.Text + "','" + cboReserRoomNo.Text + "','" + dtpBouDate.Value.ToString() + "','" + dtpEndDate.Value.ToString() + "','" + txtRemark.Text + "')");
            string sql2 = string.Format("update Room set RoomStateId='4' where RoomNo='" + cboReserRoomNo.Text + "'");
            if (DBHelper.ExecuteNonQuery(sql1) > 0 && DBHelper.ExecuteNonQuery(sql2) > 0)
            {
                MessageBox.Show("预约成功！请在指定时间内进行登记入住");
                #region 获取添加操作日志所需的信息
                Operation o = new Operation();
                o.OperationTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd,HH:mm:ss"));
                o.Operationlog = LoginInfo.WorkerClub + LoginInfo.WorkerPosition + LoginInfo.WorkerName + "于" + DateTime.Now + "帮助" + txtCustoTel.Text + "进行了预订房间操作！";
                o.OperationAccount = LoginInfo.WorkerClub + LoginInfo.WorkerPosition + LoginInfo.WorkerName;
                #endregion
                OperationManager.InsertOperationLog(o);
                this.Close();
            }
            

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRoomManager_Load(object sender, EventArgs e)
        {
            cboReserWay.SelectedIndex = 0;
            cboReserRoomNo.DataSource = RoomService.SelectCanUseRoomAll();
            cboReserRoomNo.DisplayMember = "RoomName";
            cboReserRoomNo.ValueMember = "RoomNo";
            cboReserRoomNo.Text = ucRoomList.co_RoomNo;
        }

        private void dtpBouDate_Validated_1(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            dtpEndDate.Value = now.AddDays(3);
        }
    }
}