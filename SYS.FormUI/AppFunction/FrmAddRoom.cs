using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using SYS.Core;
using SYS.Application;
using System.Collections.Generic;
using Sunny.UI;

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
                    datains_usr = AdminInfo.Account,
                    datains_date = DateTime.Now
                };
                new RoomService().InsertRoom(rn);
                MessageBox.Show("添加房间成功！");
                LoadRoom();
                #region 获取添加操作日志所需的信息
                OperationLog o = new OperationLog();
                o.OperationTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd,HH:mm:ss"));
                o.Operationlog = AdminInfo.Account + AdminInfo.Name + "于" + DateTime.Now + "新增了房间，房间号为：" + txtRoomNo.Text + "，房间类型为：" + cboRoomType.Text;
                o.OperationAccount = AdminInfo.Account + AdminInfo.Name;
                o.datains_usr = AdminInfo.Account;
                o.datains_date = DateTime.Now;
                #endregion
                new OperationlogService().InsertOperationLog(o);
            }
            else
            {
                MessageBox.Show("房间信息不完整，请重试！");
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
                MessageBox.Show("该房间已存在，无法进行添加操作");
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
    }
}
