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
using System.Linq;
using System.Windows.Forms;

namespace SYS.FormUI
{
    public partial class FrmSellThingManager : UIForm
    {
        public FrmSellThingManager()
        {
            InitializeComponent();
        }

        public static SellThing st;

        Dictionary<string, string> dic = null;
        ResponseMsg result = null;

        public void LoadData()
        {
            result = HttpHelper.Request("Sellthing/SelectSellThingAll");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectSellThingAll+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            dgvSellthing.AutoGenerateColumns = false;
            dgvSellthing.DataSource = HttpHelper.JsonToList<SellThing>(result.message);
        }

        private void FrmSellThingManager_Load(object sender, EventArgs e)
        {
            string SellId = Util.GetListNewId("ST", 3, 1, "-").FirstOrDefault();
            txtSellNo.Text = SellId;
            LoadData();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dic = new Dictionary<string, string>()
            {
                {"SellNo",txtFind.Text.Trim() },
                { "SellName",txtFind.Text.Trim()}
            };
            result = HttpHelper.Request("Sellthing/SelectSellThingAll", null, dic);
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectSellThingAll+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            dgvSellthing.DataSource = HttpHelper.JsonToList<SellThing>(result.message);
        }

        private void btnDeleteSellThing_Click(object sender, EventArgs e)
        {
            dic = new Dictionary<string, string>()
            {
                { "sellNo",txtSellNo.Text.Trim()}
            };
            result = HttpHelper.Request("Sellthing/DeleteSellThingBySellNo", null, dic);
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("DeleteSellThingBySellNo+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            UIMessageBox.ShowSuccess("删除商品成功!");
            #region 获取添加操作日志所需的信息
            RecordHelper.Record(AdminInfo.Account + "-" + AdminInfo.Name + "在" + DateTime.Now + "位于" + AdminInfo.SoftwareVersion + "执行：" + "删除商品操作！删除值为：" + st.SellNo, 2);
            #endregion
            LoadData();
            return;
        }

        public bool CheckInput(SellThing sellThing)
        {
            if (string.IsNullOrWhiteSpace(sellThing.SellNo))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(sellThing.SellName))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(sellThing.SellPrice + ""))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(sellThing.Stock + ""))
            {
                return false;
            }
            return true;
        }

        private void btnAddSellThing_Click(object sender, EventArgs e)
        {
            st = new SellThing()
            {
                SellNo = txtSellNo.Text,
                SellName = string.IsNullOrWhiteSpace(txtSellName.Text) ? "" : txtSellName.Text,
                SellPrice = string.IsNullOrWhiteSpace(txtSellPrice.Text) ? 0 : Convert.ToDecimal(txtSellPrice.Text),
                format = string.IsNullOrWhiteSpace(txtformat.Text) ? "" : Convert.ToString(txtformat.Text),
                Stock = txtStock.Value == 0 ? 0 : Convert.ToInt32(txtStock.Value),
                datains_usr = AdminInfo.Account,
            };
            if (CheckInput(st))
            {
                dic = new Dictionary<string, string>()
                {
                    { "SellNo",st.SellNo}
                };
                result = HttpHelper.Request("Sellthing/SelectSellInfoBySellNo", null, dic);
                if (result.statusCode != 200)
                {
                    UIMessageBox.ShowError("SelectSellInfoBySellNo+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                var SellThing = HttpHelper.JsonToModel<SellThing>(result.message);
                if (SellThing != null && SellThing.SellName.Equals(st.SellName) && SellThing.format.Equals(st.format))
                {
                    UIMessageBox.ShowError("信息已存在，请检查！");
                    return;
                }
                result = HttpHelper.Request("Sellthing​/InsertSellThing", HttpHelper.ModelToJson(st));
                if (result.statusCode != 200)
                {
                    UIMessageBox.ShowError("InsertSellThing+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                if (!result.ToString().Equals("true"))
                {
                    UIMessageBox.Show("添加商品失败", "系统提示", UIStyle.Red, UIMessageBoxButtons.OK);
                    return;
                }
                UIMessageBox.Show("添加商品成功", "系统提示", UIStyle.Green, UIMessageBoxButtons.OK);
                #region 获取添加操作日志所需的信息
                RecordHelper.Record(AdminInfo.Account + "-" + AdminInfo.Name + "在" + DateTime.Now + "位于" + AdminInfo.SoftwareVersion + "执行：" + "新增商品操作！新增值为：" + st.SellNo, 2);
                #endregion
                LoadData();
                string SellId = Util.GetListNewId("ST", 3, 1, "-").FirstOrDefault();
                txtSellNo.Text = SellId;
            }
            else
            {
                UIMessageBox.ShowError("信息不完整，请检查！");
                string SellId = Util.GetListNewId("ST", 3, 1, "-").FirstOrDefault();
                txtSellNo.Text = SellId;
                return;
            }
        }

        private void dgvSellthing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSellNo.Text = dgvSellthing.SelectedRows[0].Cells["clSellNo"].Value.ToString();
            txtSellName.Text = dgvSellthing.SelectedRows[0].Cells["clSellName"].Value.ToString();
            txtSellPrice.Text = dgvSellthing.SelectedRows[0].Cells["clSellPrice"].Value.ToString();
            txtformat.Text = dgvSellthing.SelectedRows[0].Cells["clFormat"].Value.ToString();
            txtStock.Value = Convert.ToDouble(dgvSellthing.SelectedRows[0].Cells["clStock"].Value);
        }

        private void txtStock_ValueChanged(object sender, double value)
        {
            //对数量步进器做限制，当小于0时使其一直保持0
            if (txtStock.Value <= 0)
            {
                txtStock.Value = 0;
            }
        }

        private void btnUpdateSellthing_Click(object sender, EventArgs e)
        {
            st = new SellThing()
            {
                SellNo = txtSellNo.Text,
                SellName = string.IsNullOrWhiteSpace(txtSellName.Text) ? "" : txtSellName.Text,
                SellPrice = string.IsNullOrWhiteSpace(txtSellPrice.Text) ? 0 : Convert.ToDecimal(txtSellPrice.Text),
                format = string.IsNullOrWhiteSpace(txtformat.Text) ? "" : Convert.ToString(txtformat.Text),
                Stock = txtStock.Value == 0 ? 0 : Convert.ToInt32(txtStock.Value),
                datachg_usr = AdminInfo.Account,
            };
            if (CheckInput(st))
            {
                result = HttpHelper.Request("Sellthing​/UpdateSellthingInfo", HttpHelper.ModelToJson(st));
                if (result.statusCode != 200)
                {
                    UIMessageBox.ShowError("UpdateSellthingInfo+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                if (!result.message.ToString().Equals("true"))
                {
                    UIMessageBox.Show("修改商品失败", "系统提示", UIStyle.Red, UIMessageBoxButtons.OK);
                    return;
                }
                UIMessageBox.Show("修改商品成功", "系统提示", UIStyle.Green, UIMessageBoxButtons.OK);
                #region 获取添加操作日志所需的信息
                RecordHelper.Record(AdminInfo.Account + "-" + AdminInfo.Name + "在" + DateTime.Now + "位于" + AdminInfo.SoftwareVersion + "执行：" + "修改商品操作！修改值为：" + st.SellNo, 2);
                #endregion
                LoadData();
            }
            else
            {
                UIMessageBox.Show("信息不完整，请检查！", "系统提示", UIStyle.Red, UIMessageBoxButtons.OK);
                return;
            }
        }
    }
}


