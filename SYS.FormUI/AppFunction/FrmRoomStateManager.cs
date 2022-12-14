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
using System.Windows.Forms;
using SYS.Core;
using Sunny.UI;
using SYS.Application;

namespace SYS.FormUI
{
    public partial class FrmRoomStateManager : UIForm
    {
        public FrmRoomStateManager()
        {
            InitializeComponent();
        }

        #region 窗体加载事件
        private void FrmRoomStateManager_Load(object sender, EventArgs e)
        {
            foreach (Control label in this.Controls)
            {
                label.Font = UI_FontUtil.controlFont;
            }
            txtRoomNo.Text = ucRoomList.rm_RoomNo;
            cboState.DataSource = new RoomService().SelectRoomStateAll();
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
                    if (new RoomService().UpdateRoomStateByRoomNo(txtRoomNo.Text, cboState.SelectedIndex) == true)
                    {
                        UIMessageBox.Show("房间" + txtRoomNo.Text + "成功修改为" + cboState.Text, "修改提示", UIStyle.Green);
                        FrmRoomManager.Reload("");
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
