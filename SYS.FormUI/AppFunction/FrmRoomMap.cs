using Sunny.UI;
using SYS.Application;
using SYS.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYS.FormUI.AppFunction
{
    public partial class FrmRoomMap : UIForm
    {
        public FrmRoomMap()
        {
            InitializeComponent();
        }
        ucRoomList romt = null;
        private void FrmRoomMap_Load(object sender, EventArgs e)
        {
            LoadRoom();
        }

        public void LoadRoom()
        {
            flpRoom.Controls.Clear();
            List<Room> rooms = new RoomService().SelectRoomAll();
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


    }
}
