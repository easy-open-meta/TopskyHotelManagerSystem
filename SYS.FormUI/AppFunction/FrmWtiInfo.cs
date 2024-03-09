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
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SYS.FormUI
{
    public partial class FrmWtiInfo : UIForm
    {
        public FrmWtiInfo()
        {
            InitializeComponent();
        }

        Dictionary<string, string> dic = null;
        ResponseMsg result = null;

        #region 窗体加载事件
        private void WtiInfo_Load(object sender, EventArgs e)
        {
            LoadWtiInfo();//加载水电费信息
            if (AdminInfo.isAdmin == false)
            {
                uiToolTip1.Active = false;
                dgvWti.ShowCellToolTips = false;
                btnUpdWti.Text = "权限不足";
                btnUpdWti.Enabled = false;
            }
        }
        #endregion

        #region 加载水电费信息到Dgv
        /// <summary>
        /// 加载水电费信息到Dgv
        /// </summary>
        private void LoadWtiInfo()
        {
            result = HttpHelper.Request("Wti/SelectWtiInfoAll");
            if (result.statusCode != 200)
            {
                UIMessageTip.ShowError("SelectWtiInfoAll+接口服务异常，请提交issue");
                return;
            }
            //将水电费信息加载到Dgv
            dgvWti.DataSource = HttpHelper.JsonToList<Wti>(result.message);
            dgvWti.AutoGenerateColumns = false;
        }
        #endregion

        private void btnUpdWti_Click(object sender, EventArgs e)
        {
            Wti wti = new Wti
            {
                WtiNo = Convert.ToInt16(txtRecordNo.Text.Trim()),
                RoomNo = txtRoomNo.Text.Trim(),
                CustoNo = txtCustoNo.Text.Trim(),
                UseDate = dtpStartDate.Value,
                EndDate = dtpEndDate.Value,
                PowerUse = string.IsNullOrEmpty(txtTInfo.Text.Trim()) ? 0 : Convert.ToDecimal(txtTInfo.Text.Trim()),
                WaterUse = string.IsNullOrEmpty(txtWInfo.Text.Trim()) ? 0 : Convert.ToDecimal(txtWInfo.Text.Trim()),
                Record = AdminInfo.Account,
                datachg_usr = AdminInfo.Account,
            };
            result = HttpHelper.Request("Wti/UpdateWtiInfo", HttpHelper.ModelToJson(wti));
            if (result.statusCode != 200)
            {
                UIMessageTip.ShowError("UpdateWtiInfo+接口服务异常，请提交issue");
                return;
            }
            if (!result.message.ToString().Equals("true"))
            {
                UIMessageTip.ShowError("修改失败！", 1500);
            }
            UIMessageTip.ShowOk("修改成功！", 1500);
            pnlWtiInfo.Visible = false;
            LoadWtiInfo();
            return;
        }

        private void dgvWti_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (AdminInfo.isAdmin == true)
            {
                txtRecordNo.Text = dgvWti.SelectedRows[0].Cells["clWtiNo"].Value.ToString();
                txtRoomNo.Text = dgvWti.SelectedRows[0].Cells["clRoomNo"].Value.ToString();
                txtCustoNo.Text = dgvWti.SelectedRows[0].Cells["clCustoNo"].Value.ToString();
                dtpStartDate.Value = Convert.ToDateTime(dgvWti.SelectedRows[0].Cells["clUseDate"].Value.ToString());
                dtpEndDate.Value = Convert.ToDateTime(dgvWti.SelectedRows[0].Cells["clEndDate"].Value.ToString());
                txtWInfo.Text = dgvWti.SelectedRows[0].Cells["clWaterUse"].Value.ToString();
                txtTInfo.Text = dgvWti.SelectedRows[0].Cells["clPowerUse"].Value.ToString();
                pnlWtiInfo.Visible = true;
                btnUpdWti.Enabled = true;
                btnClose.Enabled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.pnlWtiInfo.Visible = false;
        }
    }
}
