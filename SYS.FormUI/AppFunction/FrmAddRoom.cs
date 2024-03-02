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
using System.Data;

using System.Windows.Forms;
using EOM.TSHotelManager.Common.Core;

using System.Collections.Generic;
using Sunny.UI;
using SYS.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SYS.FormUI
{
    public partial class FrmAddRoom : UIForm
    {
        public FrmAddRoom()
        {
            InitializeComponent();
        }

        Room rn;

        ResponseMsg result = null;
        Dictionary<string, string> dic = null;

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            dic = new Dictionary<string, string>
            {
                { "roomType", Convert.ToString(cboRoomType.SelectedValue.ToString())}
            };
            result = HttpHelper.Request("RoomType/SelectRoomTypeByType", null, dic);
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectRoomTypeByType+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            RoomType roomType = HttpHelper.JsonToModel<RoomType>(result.message);

            txtMoney.Text = Convert.ToDecimal(txtMoney.Text) <= 0 ? roomType.RoomRent.ToString() : txtMoney.Text;
            txtDeposit.Text = Convert.ToDecimal(txtDeposit.Text) <= 0 ? roomType.RoomDeposit.ToString() : txtDeposit.Text;

            if (!string.IsNullOrWhiteSpace(txtRoomNo.Text)&& !txtMoney.Text.IsNullOrWhiteSpace() && !txtDeposit.Text.IsNullOrWhiteSpace())
            {
                rn = new Room()
                {
                    RoomNo = txtRoomNo.Text,
                    RoomType = cboRoomType.SelectedIndex,
                    RoomMoney = Convert.ToDecimal(txtMoney.Text),
                    RoomPosition = txtRoomPosition.Text,
                    RoomStateId = 0,
                    RoomDeposit = Convert.ToDecimal(txtDeposit.Text),
                    datains_usr = AdminInfo.Account
                };
                result = HttpHelper.Request("Room​/InsertRoom", HttpHelper.ModelToJson(rn));
                if (result.statusCode != 200)
                {
                    UIMessageBox.ShowError("InsertRoom+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                bool tf = result.message.ToString().Equals("true");
                if (tf)
                {
                    UIMessageBox.Show("添加房间成功！");
                    LoadRoom();
                    #region 获取添加操作日志所需的信息
                    RecordHelper.Record(AdminInfo.Account + AdminInfo.Name + "于" + DateTime.Now + "新增了房间，房间号为：" + txtRoomNo.Text + "，房间类型为：" + cboRoomType.Text, 2);
                    #endregion
                    txtRoomNo.Text = string.Empty;
                    txtDeposit.Text = "0.00";
                    txtMoney.Text = "0.00";
                    txtRoomPosition.Text = string.Empty;

                    return;
                }
            }
            else
            {
                UIMessageBox.Show("房间信息不完整，请重试！");
            }
        }


        ucRoomList romt = null;
        private void FrmAddRoom_Load(object sender, EventArgs e)
        {
            LoadRoom();
            result = HttpHelper.Request("RoomType/SelectRoomTypesAll");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectRoomTypesAll+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            cboRoomType.DataSource = HttpHelper.JsonToList<RoomType>(result.message);
            cboRoomType.DisplayMember = "RoomName";
            cboRoomType.ValueMember = "RoomType";
            cboRoomType.SelectedIndex = 0;
        }

        public void LoadRoom()
        {
            result = HttpHelper.Request("Room/SelectCanUseRoomAll");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectCanUseRoomAll+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            List<Room> rooms = HttpHelper.JsonToList<Room>(result.message);
            flpRoom.Controls.Clear();
            for (int i = 0; i < rooms.Count; i++)
            {
                romt = new ucRoomList();
                romt.lblMark.Text = "Mark";
                romt.lblRoomNo.Text = rooms[i].RoomNo;
                romt.lblCustoNo.Text = rooms[i].CustoNo;
                romt.lblRoomType.Text = rooms[i].RoomName;
                romt.romCustoInfo = rooms[i];
                flpRoom.Controls.Add(romt);
            }
        }

        private void cboRoomType_TextChanged(object sender, EventArgs e)
        {
            

        }

        private bool CheckRoomExists(string RoomNo)
        {
            bool ret = false;
            dic = new Dictionary<string, string>
            {
                { "no", RoomNo }
            };
            result = HttpHelper.Request("Room/SelectRoomByRoomNo",null, dic);
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectRoomByRoomNo+接口服务异常，请提交Issue或尝试更新版本！");
                return ret;
            }
            var room = HttpHelper.JsonToModel<Room>(result.message);
            if (room.RoomNo != null)
            {
                ret = true;
            }
            return ret;
        }

        private void flpRoom_MouseEnter(object sender, EventArgs e)
        {
            return;
        }

        private void txtRoomNo_Validated(object sender, EventArgs e)
        {
            if (CheckRoomExists(txtRoomNo.Text))
            {
                UIMessageBox.ShowError("房间已存在。");
                return;
            }
        }
    }
}
