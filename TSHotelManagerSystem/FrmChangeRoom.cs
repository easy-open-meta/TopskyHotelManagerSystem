using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSHotelManagerSystem.BLL;
using TSHotelManagerSystem.DAL;
using TSHotelManagerSystem.Models;

namespace TSHotelManagerSystem
{
    public partial class FrmChangeRoom : Form
    {
        public FrmChangeRoom()
        {
            InitializeComponent();
        }

        private void FrmChangeRoom_Load(object sender, EventArgs e)
        {
            string rno = cboRoomList.Text;
            cboRoomList.DataSource = RoomManager.SelectCanUseRoomAll();
            cboRoomList.ValueMember = "RoomNo";
            cboRoomList.DisplayMember = "RoomName";
            
            
        }

        private void btnChangeRoom_Click(object sender, EventArgs e)
        {
            string lbu = LoginInfo.WorkerName;
            string cno = ucRoomList.CustoNo;
            string rno = ucRoomList.RoomNo;
            string rte = ucRoomList.RoomState;
            string nrno = cboRoomList.Text;
            string sql1 = string.Format("update ROOM set RoomStateId='3',CustoNo=null,CheckTime=null,PersonNum=null where RoomNo='{0}'", rno);
            string sql2 = string.Format("update ROOM set RoomStateId='1',CustoNo='{0}' where RoomNo='{1}'", cno, nrno);
            if (DBHelper.ExecuteNonQuery(sql1) > 0 && DBHelper.ExecuteNonQuery(sql2) > 0)
            {
                MessageBox.Show("转房成功");
                #region 获取添加操作日志所需的信息
                Operation o = new Operation();
                o.OperationTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd,HH:mm:ss"));
                o.Operationlog = cno + "于" + DateTime.Now + "进行了换房，请记得到后台修改消费价格！";
                o.OperationAccount = lbu;
                #endregion
                OperationManager.InsertOperationLog(o);
                this.Close();
            }
            else
            {
                MessageBox.Show("转房失败");
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboRoomList_TextChanged(object sender, EventArgs e)
        {
            string str = cboRoomList.Text;
            if (str.Contains("BD"))
            {
                lblRoomType.Text = "标准单人间";
            }
            else if (str.Contains("BS"))
            {
                lblRoomType.Text = "标准双人间";
            }
            else if (str.Contains("HD"))
            {
                lblRoomType.Text = "豪华单人间";
            }
            else if (str.Contains("HS"))
            {
                lblRoomType.Text = "豪华双人间";
            }
            else if (str.Contains("QL"))
            {
                lblRoomType.Text = "情侣套房";
            }
            else if (str.Contains("ZT"))
            {
                lblRoomType.Text = "总统套房";
            }
        }
    }
}
