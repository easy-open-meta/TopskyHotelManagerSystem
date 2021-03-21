/*
 * MIT License
 *Copyright (c) 2021 咖啡与网络(java-and-net)

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
using System;
using System.Windows.Forms;
using SYS.Core;
using Sunny.UI;
using System.Transactions;
using System.Collections.Generic;
using SYS.Application;

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
            foreach (Control item in this.Controls)
            {
                item.Font = UI_FontUtil.scorllingFont;
            }
            string rno = cboRoomList.Text;
            cboRoomList.DataSource = new RoomService().SelectCanUseRoomAll();
            cboRoomList.ValueMember = "RoomNo";
            cboRoomList.DisplayMember = "RoomNo";


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
                    CheckTime = DateTime.Now,
                    datains_usr = LoginInfo.WorkerNo,
                    datains_date = DateTime.Now
                };

                if (rno.Contains("BD"))
                {
                    sum = Convert.ToDouble(Convert.ToInt32(new RoomService().DayByRoomNo(rno).ToString()) * 300);
                }
                if (rno.Contains("BS"))
                {
                    sum = Convert.ToDouble(Convert.ToInt32(new RoomService().DayByRoomNo(rno).ToString()) * 425);
                }
                if (rno.Contains("HD"))
                {
                    sum = Convert.ToDouble(Convert.ToInt32(new RoomService().DayByRoomNo(rno).ToString()) * 625);
                }
                if (rno.Contains("HS"))
                {
                    sum = Convert.ToDouble(Convert.ToInt32(new RoomService().DayByRoomNo(rno).ToString()) * 660);
                }
                if (rno.Contains("QL"))
                {
                    sum = Convert.ToDouble(Convert.ToInt32(new RoomService().DayByRoomNo(rno).ToString()) * 845);
                }
                if (rno.Contains("ZT"))
                {
                    sum = Convert.ToDouble(Convert.ToInt32(new RoomService().DayByRoomNo(rno).ToString()) * 1080);
                    //sum = Convert.ToDouble(Convert.ToInt32(RoomManager.DayByRoomNo(rno).ToString()) * 1080);
                }
                Spend s = new Spend()
                {
                    RoomNo = cboRoomList.Text,
                    SpendName = "居住" + rno + "共" + Convert.ToInt32(new RoomService().DayByRoomNo(rno).ToString()) + "天",
                    SpendAmount = Convert.ToInt32(new RoomService().DayByRoomNo(rno).ToString()),
                    CustoNo = ucRoomList.CustoNo,
                    SpendPrice = Convert.ToDecimal(sum),
                    SpendMoney = Convert.ToDecimal(sum),
                    SpendTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                    MoneyState = "未结算",
                };

                bool result1 = new RoomService().UpdateRoomInfo(checkInRoom);
                bool result2 = new RoomService().UpdateRoomByRoomNo(rno);
                var result3 = new SpendService().SelectSpendByCustoNo(rno);
                if (result3.Count != 0)
                {
                    bool result4 = new SpendService().UpdateSpendInfoByRoomNo(result3, nrno, ucRoomList.CustoNo);
                }
                if (result1 == true && result2 == true)
                {
                    MessageBox.Show("转房成功");
                    bool m = new SpendService().InsertSpendInfo(s);
                    FrmRoomManager.Reload();
                    #region 获取添加操作日志所需的信息
                    OperationLog o = new OperationLog();
                    o.OperationTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd,HH:mm:ss"));
                    o.Operationlog = ucRoomList.CustoNo + "于" + DateTime.Now + "进行了换房，请记得到后台修改消费价格！";
                    o.OperationAccount = LoginInfo.WorkerNo;
                    o.datains_usr = LoginInfo.WorkerNo;
                    o.datains_date = DateTime.Now;
                    #endregion
                    new OperationlogService().InsertOperationLog(o);
                    scope.Complete();
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
