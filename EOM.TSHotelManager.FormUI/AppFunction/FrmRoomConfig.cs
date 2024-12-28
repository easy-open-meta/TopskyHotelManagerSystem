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
using EOM.TSHotelManager.Common.Util;
using jvncorelib.EntityLib;
using Sunny.UI;

namespace EOM.TSHotelManager.FormUI.AppFunction
{
    public partial class FrmRoomConfig : UIForm
    {
        public FrmRoomConfig()
        {
            InitializeComponent();
        }

        ResponseMsg result = null;
        Dictionary<string, string> dic = null;

        public void LoadRoomType()
        {
            result = HttpHelper.Request("RoomType/SelectRoomTypesAll", null);
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectRoomTypesAll+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            List<RoomType> roomTypes = HttpHelper.JsonToList<RoomType>(result.message);
            dgvRoomTypeList.AutoGenerateColumns = false;
            dgvRoomTypeList.DataSource = roomTypes;
        }

        private void FrmRoomConfig_Load(object sender, EventArgs e)
        {
            LoadRoomType();
        }

        private void btnAddRoomType_Click(object sender, EventArgs e)
        {
            dic = new Dictionary<string, string>
            {
                { "roomTypeId",txtRoomTypeId.IntValue.ToString()}
            };
            var result = HttpHelper.Request("RoomType/SelectRoomTypeByType", null, dic);
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectRoomTypeByType+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            var roomType = HttpHelper.JsonToModel<RoomType>(result.message);
            if (!roomType.IsNullOrEmpty())
            {
                UIMessageBox.ShowError("房间状态已存在，请重新检查");
                txtRoomTypeId.IntValue = 0;
                txtRoomTypeName.Text = null;
                dudDeposit.Value = 0;
                dudRent.Value = 0;
                return;
            }
            roomType = new RoomType
            {
                Roomtype = txtRoomTypeId.IntValue,
                RoomName = txtRoomTypeName.Text.Trim(),
                RoomRent = Convert.ToDecimal(dudRent.Value),
                RoomDeposit = Convert.ToDecimal(dudDeposit.Value),
                delete_mk = 0,
                datains_usr = AdminInfo.Account
            };
            if (ValidateHelper.Validate(roomType))
            {
                result = HttpHelper.Request("RoomType/InsertRoomType", HttpHelper.ModelToJson(roomType));
                if (result.statusCode != 200)
                {
                    UIMessageBox.ShowError("InsertRoomType+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                UIMessageBox.ShowSuccess("提交成功，房间状态已添加！");
                RecordHelper.Record(AdminInfo.Account + AdminInfo.Name + "于" + Convert.ToDateTime(DateTime.Now) + "新增了房间状态，状态编码为：" + txtRoomTypeId.IntValue, 2);
                txtRoomTypeId.IntValue = 0;
                txtRoomTypeName.Text = null;
                dudDeposit.Value = 0;
                dudRent.Value = 0;
                LoadRoomType();
                return;
            }
            UIMessageBox.ShowError("字段校验未通过，请检查");
            return;
        }

        private void btnUpdateRoomType_Click(object sender, EventArgs e)
        {
            var roomType = new RoomType
            {
                Roomtype = txtRoomTypeId.IntValue,
                RoomName = txtRoomTypeName.Text.Trim(),
                RoomRent = Convert.ToDecimal(dudRent.Value),
                RoomDeposit = Convert.ToDecimal(dudDeposit.Value),
                delete_mk = 0,
                datachg_usr = AdminInfo.Account
            };
            if (ValidateHelper.Validate(roomType))
            {
                result = HttpHelper.Request("RoomType/UpdateRoomType", HttpHelper.ModelToJson(roomType));
                if (result.statusCode != 200)
                {
                    UIMessageBox.ShowError("UpdateRoomType+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                UIMessageBox.ShowSuccess("提交成功，状态信息已修改！");
                RecordHelper.Record(AdminInfo.Account + AdminInfo.Name + "于" + Convert.ToDateTime(DateTime.Now) + "修改了房间状态配置，状态编码为：" + txtRoomTypeId.IntValue, 2);
                LoadRoomType();
                txtRoomTypeId.IntValue = 0;
                txtRoomTypeName.Text = null;
                dudDeposit.Value = 0;
                dudRent.Value = 0;
                return;
            }
            UIMessageBox.ShowError("字段校验未通过，请检查");
            return;
        }

        private void btnDeleteRoomType_Click(object sender, EventArgs e)
        {
            var deleteMk = Convert.ToInt32(dgvRoomTypeList.SelectedRows[0].Cells["clDeleteMark"].Value);
            var roomType = new RoomType
            {
                Roomtype = txtRoomTypeId.IntValue,
                RoomName = txtRoomTypeName.Text.Trim(),
                RoomRent = Convert.ToDecimal(dudRent.Value),
                RoomDeposit = Convert.ToDecimal(dudDeposit.Value),
                delete_mk = deleteMk == 0 ? 1 : 0,
                datachg_usr = AdminInfo.Account
            };
            if (ValidateHelper.Validate(roomType))
            {
                result = HttpHelper.Request("RoomType/DeleteRoomType", HttpHelper.ModelToJson(roomType));
                if (result.statusCode != 200)
                {
                    UIMessageBox.ShowError("DeleteRoomType+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                UIMessageBox.ShowSuccess("提交成功，状态信息已删除！");
                RecordHelper.Record(AdminInfo.Account + AdminInfo.Name + "于" + Convert.ToDateTime(DateTime.Now) + "删除了房间状态配置，状态编码为：" + txtRoomTypeId.IntValue, 2);
                LoadRoomType();
                return;
            }
            UIMessageBox.ShowError("字段校验未通过，请检查");
            return;
        }

        private void dgvRoomTypeList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtRoomTypeId.IntValue = Convert.ToInt32(dgvRoomTypeList.SelectedRows[0].Cells["clRoomType"].Value);
            txtRoomTypeName.Text = dgvRoomTypeList.SelectedRows[0].Cells["clRoomTypeName"].Value.ToString();
            dudRent.Value = Convert.ToDouble(dgvRoomTypeList.SelectedRows[0].Cells["clRoomRent"].Value);
            dudDeposit.Value = Convert.ToDouble(dgvRoomTypeList.SelectedRows[0].Cells["clRoomDeposit"].Value);
        }
    }
}
