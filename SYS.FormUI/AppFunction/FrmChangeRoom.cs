using System;
using System.Windows.Forms;
using SYS.Manager;
using SYS.Core;
using Sunny.UI;
using System.Transactions;
using System.Collections.Generic;

namespace SYS.FormUI
{
    public partial class FrmChangeRoom : UIForm
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
            using (TransactionScope scope = new TransactionScope())
            {
                double sum = 0;
                string lbu = LoginInfo.WorkerName;
                string rno = ucRoomList.RoomNo.ToString();
                string nrno = cboRoomList.Text;
                Room checkInRoom = new Room()
                {
                    RoomNo = nrno,
                    CustoNo = ucRoomList.CustoNo,
                    RoomStateId = 1,
                    CheckTime = DateTime.Now
                };

                int result1 = RoomManager.UpdateRoomInfo(checkInRoom);
                int result2 = RoomManager.UpdateRoomByRoomNo(rno);


                if (rno.Contains("BD"))
                {
                    sum = Convert.ToDouble(Convert.ToInt32(RoomManager.DayByRoomNo(rno).ToString()) * 300);
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
                    CustoNo = ucRoomList.CustoNo,
                    SpendPrice = Convert.ToDecimal(sum),
                    SpendMoney = Convert.ToDecimal(sum),
                    SpendTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                    MoneyState = "未结算",
                };
                if (result1 > 0 && result2 > 0)
                {
                    MessageBox.Show("转房成功");
                    int m = SpendManager.InsertSpendInfo(s);
                    FrmRoomManager.Reload();
                    #region 获取添加操作日志所需的信息
                    Operation o = new Operation();
                    o.OperationTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd,HH:mm:ss"));
                    o.Operationlog = ucRoomList.CustoNo + "于" + DateTime.Now + "进行了换房，请记得到后台修改消费价格！";
                    o.OperationAccount = lbu;
                    #endregion
                    OperationlogManager.InsertOperationLog(o);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("转房失败");
                }
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
