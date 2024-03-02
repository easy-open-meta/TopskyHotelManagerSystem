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
using Sunny.UI;

using SYS.Common;
using EOM.TSHotelManager.Common.Core;
using SYS.FormUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYS.FormUI
{
    public partial class FrmPosition : UIForm
    {
        public delegate void PositionInfo();


        //定义委托类型的变量
        public static PositionInfo operation;

        public static PositionInfo reload;

        public FrmPosition()
        {
            InitializeComponent();
            reload = ReloadPositionList;
        }

        List<Position> positions = null;
        public static string info = null;
        private void FrmPosition_Load(object sender, EventArgs e)
        {
            ReloadPositionList();
        }

        ResponseMsg result = new ResponseMsg();
        Dictionary<string, string> dic = null;

        public void ReloadPositionList()
        {
            txtPositionNo.Text = Util.GetListNewId("P", 3, 1, "-").FirstOrDefault();
            result = HttpHelper.Request("Base/SelectPositionAll");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectPositionAll+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            positions = HttpHelper.JsonToList<Position>(result.message);
            dgvPositionList.AutoGenerateColumns = false;
            dgvPositionList.DataSource = positions;
        }

        private void btnAddPosition_Click(object sender, EventArgs e)
        {
            if (txtPositionName.Text.Trim().IsNullOrEmpty())
            {
                UIMessageTip.ShowWarning("职位名称为空，请检查", 1500);
                txtPositionName.Focus();
                return;
            }
            var pos = new Position()
            {
                position_no = txtPositionNo.Text.Trim(),
                position_name = txtPositionName.Text.Trim(),
                delete_mk = 0,
                datains_usr = AdminInfo.Account
            };
            result = HttpHelper.Request("Base​/AddPosition", HttpHelper.ModelToJson(pos));
            if (result.statusCode != 200 || result.message.ToString().Equals("false"))
            {
                UIMessageTip.ShowError("AddPosition+接口服务异常，请提交Issue或尝试更新版本！", 1500);
                return;
            }
            UIMessageTip.ShowOk("添加职位成功！", 1500);
            #region 获取添加操作日志所需的信息
            RecordHelper.Record(AdminInfo.Account + "-" + AdminInfo.Name + "在" + DateTime.Now + "位于" + AdminInfo.SoftwareVersion + "执行：" + "新增职位类型操作！新增值为：" + pos.position_no, 2);
            #endregion
            ReloadPositionList();
            return;
        }

        private void btnUpdatePosition_Click(object sender, EventArgs e)
        {
            if (dgvPositionList.SelectedRows.Count <= 0)
            {
                UIMessageTip.ShowWarning("未选择需修改的职位数据，请检查", 1500);
                return;
            }
            var pos = new Position()
            {
                position_no = txtPositionNo.Text.Trim(),
                position_name = txtPositionName.Text.Trim(),
                datachg_usr = AdminInfo.Account,
            };
            result = HttpHelper.Request("Base​/UpdPosition", HttpHelper.ModelToJson(pos));
            if (result.statusCode != 200 || result.message.ToString().Equals("false"))
            {
                UIMessageTip.ShowError("UpdPosition+接口服务异常，请提交Issue或尝试更新版本！", 1500);
                return;
            }
        }

        private void btnDeletePosition_Click(object sender, EventArgs e)
        {
            if (dgvPositionList.SelectedRows.Count <= 0)
            {
                UIMessageTip.ShowWarning("未选择需修改的职位数据，请检查", 1500);
                return;
            }
            var pos = new Position()
            {
                position_no = txtPositionNo.Text.Trim(),
                position_name = txtPositionName.Text.Trim(),
                delete_mk = 1,
                datachg_usr = AdminInfo.Account,
            };
            result = HttpHelper.Request("Base​/DelPosition", HttpHelper.ModelToJson(pos));
            if (result.statusCode != 200 || result.message.ToString().Equals("false"))
            {
                UIMessageTip.ShowError("DelPosition+接口服务异常，请提交Issue或尝试更新版本！", 1500);
                return;
            }
            UIMessageTip.ShowOk("删除成功！");
            return;
        }

        private void dgvPositionList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtPositionNo.Text = dgvPositionList.SelectedRows[0].Cells["clPositionNo"].Value.ToString();
            txtPositionName.Text = dgvPositionList.SelectedRows[0].Cells["clPositionName"].Value.ToString();
            if (dgvPositionList.SelectedRows[0].Cells["clDeleteMk"].Value.ToString() == "1")
            {
                btnDeletePosition.Text = "恢复职位";
                btnDeletePosition.FillColor = Color.Green;
                btnDeletePosition.RectColor = Color.Green;
                btnDeletePosition.Click += btnRecoveryPosition_Click;
            }
        }

        private void btnRecoveryPosition_Click(object sender, EventArgs e)
        {
            if (dgvPositionList.SelectedRows.Count <= 0)
            {
                UIMessageTip.ShowWarning("未选择需修改的职位数据，请检查", 1500);
                return;
            }
            var pos = new Position()
            {
                position_no = txtPositionNo.Text.Trim(),
                position_name = txtPositionName.Text.Trim(),
                delete_mk = 0,
                datachg_usr = AdminInfo.Account,
            };
            result = HttpHelper.Request("Base​/UpdPosition", HttpHelper.ModelToJson(pos));
            if (result.statusCode != 200 || result.message.ToString().Equals("false"))
            {
                UIMessageTip.ShowError("UpdPosition+接口服务异常，请提交Issue或尝试更新版本！", 1500);
                return;
            }
        }
    }
}
