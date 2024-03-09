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
using SYS.FormUI.Properties;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SYS.FormUI
{
    public partial class FrmRoomManager : Form
    {
        public static string co_CustoNo;
        public static string co_RoomNo;
        public static string co_CustoName;
        public static string co_CheckTime;
        public static string co_Day;

        public delegate void ReLoadRoomList(string typeName);

        public delegate void ReadRoomInfo();

        //定义委托类型的变量
        public static ReadRoomInfo ReadInfo;
        public static ReLoadRoomList Reload;

        public FrmRoomManager()
        {
            InitializeComponent();
            ReadInfo = LoadRoomInfo;
            Reload = LoadData;
        }

        Dictionary<string, string> dic = null;
        ResponseMsg result = null;

        List<Room> romsty = null;
        ucRoomList romt = null;
        #region 房间加载事件方法
        private void FrmRoomManager_Load(object sender, EventArgs e)
        {
            LoadRoomInfo();

            //foreach (Control item in this.pnlRoomInfo.Controls)
            //{
            //    if (item.GetType().ToString() == "System.Windows.Forms.Label")
            //    {
            //        item.Font = UI_FontUtil.childControlFont;
            //    }
            //}

            LoadData();

        }
        #endregion

        private void btnAll_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnBD_Click(object sender, EventArgs e)
        {
            LoadData(btnBD.Text);
        }

        public void LoadRoomInfo()
        {
            result = HttpHelper.Request("Room/SelectCanUseRoomAllByRoomState");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectCanUseRoomAllByRoomState+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            lblCanUse.Text = result.message.ToString();
            result = HttpHelper.Request("Room/SelectNotUseRoomAllByRoomState");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectNotUseRoomAllByRoomState+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            lblCheck.Text = result.message.ToString();
            result = HttpHelper.Request("Room/SelectNotClearRoomAllByRoomState");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectNotClearRoomAllByRoomState+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            lblNotClear.Text = result.message.ToString();
            result = HttpHelper.Request("Room/SelectFixingRoomAllByRoomState");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectFixingRoomAllByRoomState+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            lblFix.Text = result.message.ToString();
            result = HttpHelper.Request("Room/SelectReseredRoomAllByRoomState");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectReseredRoomAllByRoomState+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            lblReser.Text = result.message.ToString();
            lblRoomNo.Text = ucRoomList.co_RoomNo;
            lblCustoNo.Text = ucRoomList.co_CustoNo;
            lblRoomPosition.Text = ucRoomList.co_RoomPosition;
            lblCheckTime.Text = ucRoomList.co_CheckTime == null ? "" : Convert.ToDateTime(ucRoomList.co_CheckTime).ToString("yyyy-MM-dd");
            lblRoomState.Text = ucRoomList.co_RoomState;
        }

        private void LoadData(string typeName = "")
        {
            flpRoom.Controls.Clear();
            if (string.IsNullOrEmpty(typeName))
            {
                result = HttpHelper.Request("Room/SelectRoomAll");
                if (result.statusCode != 200)
                {
                    UIMessageBox.ShowError("SelectRoomAll+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                romsty = HttpHelper.JsonToList<Room>(result.message);
            }
            else
            {
                dic = new Dictionary<string, string>()
                {
                    { "TypeName",typeName}
                };
                result = HttpHelper.Request("Room/SelectRoomByTypeName", null, dic);
                if (result.statusCode != 200)
                {
                    UIMessageBox.ShowError("SelectRoomByTypeName+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                romsty = HttpHelper.JsonToList<Room>(result.message);
            }
            for (int i = 0; i < romsty.Count; i++)
            {
                romt = new ucRoomList();
                romt.lblMark.Text = String.Empty;
                romt.lblRoomNo.Text = romsty[i].RoomNo;
                romt.lblCustoNo.Text = romsty[i].CustoNo;
                romt.lblRoomType.Text = romsty[i].RoomName;
                romt.romCustoInfo = romsty[i];
                flpRoom.Controls.Add(romt);
            }
            lblRoomNo.Text = "";
            lblRoomPosition.Text = "";
            lblRoomState.Text = "";
            lblCustoNo.Text = "";
            lblCheckTime.Text = "";
            LoadRoomInfo();
        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            LoadData(btnBS.Text);
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            LoadData(btnHD.Text);
        }

        private void btnHS_Click(object sender, EventArgs e)
        {
            LoadData(btnHS.Text);
        }

        private void btnQL_Click(object sender, EventArgs e)
        {
            LoadData(btnQL.Text);
        }

        private void btnZT_Click(object sender, EventArgs e)
        {
            LoadData(btnZT.Text);
        }

        private void picRefrech_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadRoomByState(int stateid)
        {
            flpRoom.Controls.Clear();
            dic = new Dictionary<string, string>()
            {
                { "stateid",stateid.ToString()}
            };
            result = HttpHelper.Request("Room/SelectRoomByRoomState", null, dic);
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectRoomByRoomState+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            romsty = HttpHelper.JsonToList<Room>(result.message);
            for (int i = 0; i < romsty.Count; i++)
            {
                romt = new ucRoomList();
                romt.lblMark.Text = String.Empty;
                romt.lblRoomNo.Text = romsty[i].RoomNo;
                romt.lblCustoNo.Text = romsty[i].CustoNo;
                romt.lblRoomType.Text = romsty[i].RoomName;
                romt.romCustoInfo = romsty[i];
                flpRoom.Controls.Add(romt);
            }
            lblRoomNo.Text = "";
            lblRoomPosition.Text = "";
            lblRoomState.Text = "";
            lblCustoNo.Text = "";
            lblCheckTime.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoadRoomByState(0);
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Resources.可住房_hover_icon;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = Resources.已住房_hover_icon;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = Resources.脏房_hover_icon;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.BackgroundImage = Resources.维修房_hover_icon;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackgroundImage = Resources.维修房icon;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = Resources.脏房icon1;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = Resources.已住房icon;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Resources.可住房icon;
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.BackgroundImage = Resources.预约房_hover_icon;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.BackgroundImage = Resources.预约房icon;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            flpRoom.Controls.Clear();
            LoadRoomByState(1);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            LoadRoomByState(3);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            LoadRoomByState(2);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            LoadRoomByState(4);
        }
    }
}