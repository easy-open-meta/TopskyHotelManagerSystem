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
    public partial class FrmRoomStateManager : UIForm
    {
        public FrmRoomStateManager()
        {
            InitializeComponent();
        }

        Dictionary<string, string> dic = null;
        ResponseMsg result = null;

        #region 窗体加载事件
        private void FrmRoomStateManager_Load(object sender, EventArgs e)
        {
            txtRoomNo.Text = ucRoom.rm_RoomNo;
            result = HttpHelper.Request("Room/SelectRoomStateAll");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectRoomStateAll+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            cboState.DataSource = HttpHelper.JsonToList<RoomState>(result.message);
            cboState.DisplayMember = "RoomStateName";
            cboState.ValueMember = "RoomStateId";
            cboState.SelectedIndex = 0;
        }
        #endregion

        #region 确定按钮点击事件
        private void btnOk_Click(object sender, EventArgs e)
        {
            switch (cboState.SelectedIndex)
            {
                case 1:
                    UIMessageBox.Show("不能设置为已住状态！", "来自小T的提示", UIStyle.Orange);
                    break;
                case 0:
                case 2:
                case 3:
                case 4:
                    dic = new Dictionary<string, string>()
                    {
                        { "roomno",txtRoomNo.Text},
                        { "stateid",cboState.SelectedIndex.ToString()}
                    };
                    result = HttpHelper.Request("Room/UpdateRoomStateByRoomNo", null, dic);
                    if (result.statusCode != 200)
                    {
                        UIMessageBox.ShowError("UpdateRoomStateByRoomNo+接口服务异常，请提交Issue或尝试更新版本！");
                        return;
                    }
                    if (result.message.ToString().Equals("true"))
                    {
                        UIMessageBox.Show("房间" + txtRoomNo.Text + "成功修改为" + cboState.Text, "修改提示", UIStyle.Green);
                        FrmRoomManager.Reload("");
                        FrmRoomManager._RefreshRoomCount();
                        this.Close();
                    }
                    else
                    {
                        UIMessageBox.Show("修改失败", "来自小T的提示", UIStyle.Red);
                    }
                    break;
                default:
                    UIMessageBox.Show("请选择房间状态", "来自小T的提示", UIStyle.Orange);
                    break;
            }

        }
        #endregion
    }
}
