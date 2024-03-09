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
using EOM.TSHotelManager.Common.Core;
using Sunny.UI;
using SYS.Common;
using System;
using System.Collections.Generic;
using System.Transactions;

namespace SYS.FormUI
{
    public partial class FrmChangeRoom : UIForm
    {
        public FrmChangeRoom()
        {
            InitializeComponent();
        }

        ResponseMsg result = null;
        Dictionary<string, string> dic = null;

        private void FrmChangeRoom_Load(object sender, EventArgs e)
        {
            //string rno = cboRoomList.Text;
            result = HttpHelper.Request("Room/SelectCanUseRoomAll");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectCanUseRoomAll+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            cboRoomList.DataSource = HttpHelper.JsonToList<Room>(result.message);
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
                    datains_usr = LoginInfo.WorkerNo
                };
                dic = new Dictionary<string, string>()
                {
                    { "roomno",rno}
                };
                result = HttpHelper.Request("Room/DayByRoomNo", null, dic);
                if (result.statusCode != 200)
                {
                    UIMessageBox.ShowError("DayByRoomNo+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                if (rno.StartsWith("BD"))
                {
                    sum = Convert.ToDouble(Convert.ToInt32(result.message) * 300);
                }
                if (rno.StartsWith("BS"))
                {
                    sum = Convert.ToDouble(Convert.ToInt32(result.message) * 425);
                }
                if (rno.StartsWith("HD"))
                {
                    sum = Convert.ToDouble(Convert.ToInt32(result.message) * 625);
                }
                if (rno.StartsWith("HS"))
                {
                    sum = Convert.ToDouble(Convert.ToInt32(result.message) * 660);
                }
                if (rno.StartsWith("QL"))
                {
                    sum = Convert.ToDouble(Convert.ToInt32(result.message) * 845);
                }
                if (rno.StartsWith("ZT"))
                {
                    sum = Convert.ToDouble(Convert.ToInt32(result.message) * 1080);
                }
                Spend s = new Spend()
                {
                    RoomNo = cboRoomList.Text,
                    SpendName = "居住" + rno + "共" + Convert.ToInt32(result.message) + "天",
                    SpendAmount = Convert.ToInt32(result.message),
                    CustoNo = ucRoomList.CustoNo,
                    SpendPrice = Convert.ToDecimal(sum),
                    SpendMoney = Convert.ToDecimal(sum),
                    SpendTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                    MoneyState = SpendConsts.UnSettle,
                };

                result = HttpHelper.Request("Room​/UpdateRoomInfo", HttpHelper.ModelToJson(checkInRoom), null);
                if (result.statusCode != 200)
                {
                    UIMessageBox.ShowError("UpdateRoomInfo+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                bool result1 = result.message.ToString().Equals("true");
                dic = new Dictionary<string, string>()
                {
                    { "room",rno}
                };
                result = HttpHelper.Request("Room​/UpdateRoomByRoomNo", null, dic);
                if (result.statusCode != 200)
                {
                    UIMessageBox.ShowError("UpdateRoomByRoomNo+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                bool result2 = result.message.ToString().Equals("true");
                dic = new Dictionary<string, string>()
                {
                    { "No",rno}
                };
                result = HttpHelper.Request("Spend​/SelectSpendByCustoNo", null, dic);
                if (result.statusCode != 200)
                {
                    UIMessageBox.ShowError("SelectSpendByCustoNo+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                var result3 = HttpHelper.JsonToList<Spend>(result.message);
                if (result3.Count != 0)
                {
                    Spend spend = new Spend() { RoomNo = nrno, CustoNo = ucRoomList.CustoNo };
                    result = HttpHelper.Request("Spend​/UpdateSpendInfoByRoomNo", HttpHelper.ModelToJson(spend));
                    if (result.statusCode != 200)
                    {
                        UIMessageBox.ShowError("UpdateSpendInfoByRoomNo+接口服务异常，请提交Issue或尝试更新版本！");
                        return;
                    }
                    bool result4 = result.message.ToString().Equals("true");
                }
                if (result1 && result2)
                {
                    UIMessageBox.ShowSuccess("转房成功");
                    result = HttpHelper.Request("Spend​/InsertSpendInfo", HttpHelper.ModelToJson(s));
                    if (result.statusCode != 200)
                    {
                        UIMessageBox.ShowError("InsertSpendInfo+接口服务异常，请提交Issue或尝试更新版本！");
                        return;
                    }
                    bool m = result.message.ToString().Equals("true");
                    FrmRoomManager.Reload("");
                    #region 获取添加操作日志所需的信息
                    RecordHelper.Record(LoginInfo.WorkerNo + "-" + LoginInfo.WorkerName + "在" + DateTime.Now + "位于" + LoginInfo.SoftwareVersion + "执行：" + ucRoomList.CustoNo + "于" + DateTime.Now + "进行了换房！", 2);
                    #endregion
                    scope.Complete();
                    this.Close();
                }
                else
                {
                    UIMessageBox.ShowError("转房失败");
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
