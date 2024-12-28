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

namespace EOM.TSHotelManager.FormUI.AppFunction
{
    public partial class FrmRoomMap : UIForm
    {
        public FrmRoomMap()
        {
            InitializeComponent();
        }
        ucRoom room = null;
        private void FrmRoomMap_Load(object sender, EventArgs e)
        {
            LoadRoom();
        }

        public void LoadRoom()
        {
            flpRoom.Controls.Clear();
            var result = HttpHelper.Request("Room/SelectRoomAll");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectRoomAll+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            List<Room> rooms = HttpHelper.JsonToList<Room>(result.message);
            for (int i = 0; i < rooms.Count; i++)
            {
                room = new ucRoom();
                room.btnRoom.Text = string.Format("{0}\n\n{1}\n\n{2}", rooms[i].RoomName, rooms[i].RoomNo, rooms[i].CustoName);
                room.lblMark = "Mark";
                room.romRoomInfo = rooms[i];
                flpRoom.Controls.Add(room);
            }
        }

        private void flpRoom_MouseEnter(object sender, EventArgs e)
        {
            return;
        }
    }
}
