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

namespace EOM.TSHotelManager.FormUI
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

        Dictionary<string, string> dic = null;
        ResponseMsg result = null;

        private void btnReser_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string reserid = ApplicationUtil.GetListNewId("R", 3, 1, "-").FirstOrDefault();
            Reser reser = new Reser()
            {
                ReserId = reserid,
                CustoName = txtCustoName.Text.Trim(),
                CustoTel = txtCustoTel.Text.Trim(),
                ReserWay = cboReserWay.Text,
                ReserRoom = cboReserRoomNo.Text,
                ReserDate = dtpBouDate.Value,
                ReserEndDay = dtpEndDate.Value,
                datains_usr = LoginInfo.WorkerNo
            };
            Room room = new Room()
            {
                RoomNo = cboReserRoomNo.Text,
                RoomStateId = 4
            };
            result = HttpHelper.Request("Reser​/InserReserInfo", HttpHelper.ModelToJson(reser));
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("InserReserInfo+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            bool result1 = result.message.ToString().Equals("true");
            result = HttpHelper.Request("Room​/UpdateRoomInfoWithReser", HttpHelper.ModelToJson(room));
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("UpdateRoomInfoWithReser+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            bool result2 = result.message.ToString().Equals("true");

            if (result1 && result2)
            {
                UIMessageBox.ShowSuccess("预约成功！请在指定时间内进行登记入住");
                #region 获取添加操作日志所需的信息
                RecordHelper.Record(LoginInfo.WorkerClub + LoginInfo.WorkerPosition + LoginInfo.WorkerName + "于" + Convert.ToDateTime(DateTime.Now) + "帮助" + txtCustoTel.Text + "进行了预订房间操作！", 1);
                #endregion
                FrmRoomManager.Reload("");
                this.Close();
            }
            else
            {
                UIMessageBox.ShowError("预约失败！服务器繁忙");
                return;
            }
        }

        private void FrmRoomManager_Load(object sender, EventArgs e)
        {
            cboReserWay.SelectedIndex = 0;
            result = HttpHelper.Request("Room/SelectCanUseRoomAll");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectCanUseRoomAll+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            cboReserRoomNo.DataSource = HttpHelper.JsonToList<Room>(result.message);
            cboReserRoomNo.DisplayMember = "RoomNo";
            cboReserRoomNo.ValueMember = "RoomNo";
            cboReserRoomNo.Text = ucRoom.co_RoomNo;
            dtpBouDate.Value = Convert.ToDateTime(DateTime.Now);
        }

        private void btnReserList_Click(object sender, EventArgs e)
        {
            FrmReserList frm = new FrmReserList();
            frm.Show();
        }

        private void dtpBouDate_ValueChanged(object sender, DateTime value)
        {
            dtpEndDate.Value = dtpBouDate.Value.AddDays(3);
        }

        private void dtpBouDate_TextChanged(object sender, EventArgs e)
        {
            dtpEndDate.Value = dtpBouDate.Value.AddDays(3);
        }

        private void dtpBouDate_Validated(object sender, EventArgs e)
        {
            dtpEndDate.Value = dtpBouDate.Value.AddDays(3);
        }
    }
}