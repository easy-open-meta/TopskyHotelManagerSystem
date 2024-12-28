/*
 * MIT License
 *Copyright (c) 2021 易开元(EOM)

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

using EOM.TSHotelManager.Common;
using EOM.TSHotelManager.Common.Core;
using Sunny.UI;
using System.Transactions;

namespace EOM.TSHotelManager.FormUI
{
    public partial class FrmChangeRoom : UIForm
    {
        public FrmChangeRoom()
        {
            InitializeComponent();
        }

        ResponseMsg result = null;
        Dictionary<string, string> dic = null;
        static bool firstLoad = true;

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
            cboRoomList.DisplayMember = nameof(Room.RoomNo);
            cboRoomList.ValueMember = nameof(Room.RoomNo);
            firstLoad = false;
        }

        private void btnChangeRoom_Click(object sender, EventArgs e)
        {
            double sum = 0;
            string lbu = LoginInfo.WorkerName;
            string rno = ucRoom.co_RoomNo.ToString();
            string nrno = cboRoomList.Text;
            dic = new Dictionary<string, string>()
            {
                { "no",rno}
            };

            result = HttpHelper.Request("Room/SelectRoomByRoomNo", null, dic);
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectRoomByRoomNo+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            Room room = HttpHelper.JsonToModel<Room>(result.message);
            Room checkInRoom = new Room()
            {
                RoomNo = nrno,
                CustoNo = ucRoom.co_CustoNo,
                RoomStateId = 1,
                CheckTime = Convert.ToDateTime(DateTime.Now),
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
            sum = Convert.ToDouble(Convert.ToString(Convert.ToInt32(result.message) * room.RoomMoney));

            Spend s = new Spend()
            {
                RoomNo = cboRoomList.Text,
                SpendName = "居住" + rno + "共" + Convert.ToInt32(result.message) + "天",
                SpendAmount = Convert.ToInt32(result.message),
                CustoNo = ucRoom.co_CustoNo,
                SpendPrice = Convert.ToDecimal(sum),
                SpendMoney = Convert.ToDecimal(sum),
                SpendTime = Convert.ToDateTime(Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss")),
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
                Spend spend = new Spend() { RoomNo = nrno, CustoNo = ucRoom.CustoNo };
                result = HttpHelper.Request("Spend​/UpdateSpendInfoByRoomNo", HttpHelper.ModelToJson(spend));
                if (result.statusCode != 200)
                {
                    UIMessageBox.ShowError("UpdateSpendInfoByRoomNo+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                bool result4 = result.message.ToString().Equals("true");
            }
            using (TransactionScope scope = new TransactionScope())
            {
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
                    FrmRoomManager._RefreshRoomCount();
                    #region 获取添加操作日志所需的信息
                    RecordHelper.Record(LoginInfo.WorkerNo + "-" + LoginInfo.WorkerName + "在" + Convert.ToDateTime(DateTime.Now) + "位于" + LoginInfo.SoftwareVersion + "执行：" + ucRoom.CustoNo + "于" + Convert.ToDateTime(DateTime.Now) + "进行了换房！", 2);
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

        private void cboRoomList_TextChanged(object sender, EventArgs e)
        {
            string str = firstLoad ? ucRoom.RoomNo.ToString() : cboRoomList.SelectedValue.ToString();
            dic = new Dictionary<string, string>()
            {
                { "no",str}
            };
            result = HttpHelper.Request("RoomType/SelectRoomTypeByRoomNo", null, dic);
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectRoomTypeByRoomNo+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            RoomType roomType = HttpHelper.JsonToModel<RoomType>(result.message);
            lblRoomType.Text = roomType.RoomName;
        }
    }
}
