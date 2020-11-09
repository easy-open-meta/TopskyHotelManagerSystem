using System;
using System.Windows.Forms;
using TSHotelManagerSystem.BLL;
using TSHotelManagerSystem.DAL;
using Core;

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
            double sum = 0;
            string lbu = LoginInfo.WorkerName;
            string cno = ucRoomList.CustoNo;
            string rno = ucRoomList.RoomNo;
            string rte = ucRoomList.RoomState;
            string rct = ucRoomList.co_CheckTime;
            string rpm = ucRoomList.co_PersonNum;
            string nrno = cboRoomList.Text;
            string sql1 = string.Format("update ROOM set RoomStateId='3',CustoNo=null,CheckTime=null,PersonNum=null where RoomNo='{0}'", rno);
            string sql2 = string.Format("update ROOM set RoomStateId='1',CustoNo='{0}',CheckTime='{1}',CheckOutTime=null,PersonNum='{2}' where RoomNo='{3}'", cno, rct, rpm, nrno);
            if (rno.Contains("BD"))
            {
                sum = Convert.ToDouble(Convert.ToString(Convert.ToInt32(RoomManager.DayByRoomNo(rno).ToString()) * 300));
            }
            if (rno.Contains("BS"))
            {
                sum = Convert.ToDouble(Convert.ToInt32(RoomManager.DayByRoomNo(rno).ToString()) * 425);
            }
            if (rno.Contains("HD"))
            {
                sum = Convert.ToDouble(Convert.ToString(Convert.ToInt32(RoomManager.DayByRoomNo(rno).ToString()) * 625));
            }
            if (rno.Contains("HS"))
            {
                sum = Convert.ToDouble(Convert.ToInt32(RoomManager.DayByRoomNo(rno).ToString()) * 660);
            }
            if (rno.Contains("QL"))
            {
                sum = Convert.ToDouble(Convert.ToInt32(RoomManager.DayByRoomNo(rno).ToString()) * 845);
            }
            if (rno.Contains("ZT"))
            {
                sum = Convert.ToDouble(Convert.ToString(Convert.ToInt32(RoomManager.DayByRoomNo(rno).ToString()) * 1080));
                //sum = Convert.ToDouble(Convert.ToInt32(RoomManager.DayByRoomNo(rno).ToString()) * 1080);
            }
            Spend s = new Spend()
            {
                RoomNo = cboRoomList.Text,
                SpendName = "居住" + rno + Convert.ToInt32(RoomManager.DayByRoomNo(rno).ToString()) + "天",
                SpendAmount = Convert.ToInt32(RoomManager.DayByRoomNo(rno).ToString()),
                CustoNo = cno,
                SpendPrice = Convert.ToDecimal(sum),
                SpendMoney = Convert.ToDecimal(sum),
                SpendTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                MoneyState = "未结算",
            };
            if (DBHelper.ExecuteNonQuery(sql1) > 0 && DBHelper.ExecuteNonQuery(sql2) > 0)
            {
                MessageBox.Show("转房成功");
                int m = SpendManager.InsertSpendInfo(s);
                FrmRoomManager.Reload();
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
