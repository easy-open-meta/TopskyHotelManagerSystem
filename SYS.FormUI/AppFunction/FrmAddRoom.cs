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
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using SYS.Core;
using SYS.Application;
using System.Collections.Generic;
using Sunny.UI;
using SYS.Common;

namespace SYS.FormUI
{
    public partial class FrmAddRoom : UIForm
    {
        public FrmAddRoom()
        {
            InitializeComponent();
        }

        Room rn;

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtRoomNo.Text))
            {
                rn = new Room()
                {
                    RoomNo = txtRoomNo.Text,
                    RoomType = cboRoomType.SelectedIndex,
                    RoomMoney = Convert.ToDecimal(txtMoney.Text),
                    RoomPosition = txtRoomPosition.Text,
                    RoomStateId = 0,
                    RoomDeposit = Convert.ToDecimal(txtDeposit.Text),
                    datains_usr = AdminInfo.Account,
                    datains_date = DateTime.Now
                };
                new RoomService().InsertRoom(rn);
                UIMessageBox.Show("添加房间成功！");
                LoadRoom();
                #region 获取添加操作日志所需的信息
                RecordHelper.Record(AdminInfo.Account + AdminInfo.Name + "于" + DateTime.Now + "新增了房间，房间号为：" + txtRoomNo.Text + "，房间类型为：" + cboRoomType.Text, 2);
                #endregion
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
            cboRoomType.DataSource = new RoomTypeService().SelectRoomTypesAll();
            cboRoomType.DisplayMember = "RoomName";
            cboRoomType.ValueMember = "RoomType";
            cboRoomType.SelectedIndex = 0;
        }

        public void LoadRoom()
        {
            List<Room> rooms = new RoomService().SelectCanUseRoomAll();
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
            if (cboRoomType.Text == "标准单人间")
            {
                txtMoney.Text = "300";
                txtRoomPosition.Text = "A层";
            }
            else if (cboRoomType.Text == "标准双人间")
            {
                txtMoney.Text = "425";
                txtRoomPosition.Text = "A层";
            }
            else if (cboRoomType.Text == "豪华单人间")
            {
                txtMoney.Text = "625";
                txtRoomPosition.Text = "B层";
            }
            else if (cboRoomType.Text == "豪华双人间")
            {
                txtMoney.Text = "660";
                txtRoomPosition.Text = "B层";
            }
            else if (cboRoomType.Text == "情侣套房")
            {
                txtMoney.Text = "845";
                txtRoomPosition.Text = "C层";
            }
            else if (cboRoomType.Text == "总统套房")
            {
                txtMoney.Text = "1080";
                txtRoomPosition.Text = "D层";
            }
        }

        private void txtRoomNo_TextChanged(object sender, EventArgs e)
        {
            if (CheckRoomExists(txtRoomNo.Text))
            {
                UIMessageBox.Show("该房间已存在，无法进行添加操作");
                return;
            }
        }

        private bool CheckRoomExists(string RoomNo)
        {
            bool ret = false;
            Room room = new Room();
            room = new RoomService().SelectRoomByRoomNo(RoomNo);
            if (room != null)
            {
                ret = true;
            }
            return ret;
        }

        private void flpRoom_MouseEnter(object sender, EventArgs e)
        {
            return;
        }
    }
}
