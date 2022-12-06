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
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using SYS.Core;
using SYS.FormUI.Properties;
using SYS.Application;
using Sunny.UI;
using SYS.Common;

namespace SYS.FormUI
{
    public partial class FrmSellThingManager : UIForm
    {
        public FrmSellThingManager()
        {
            InitializeComponent();
        }

        public static SellThing st;

        public void LoadData()
        {
            dgvSellthing.AutoGenerateColumns = false;
            dgvSellthing.DataSource = new SellService().SelectSellThingAll();
        }

        private void FrmSellThingManager_Load(object sender, EventArgs e)
        {
            string SellId = new CounterHelper().GetNewId(CounterRuleConsts.SellId);
            txtSellNo.Text = SellId;
            dgvSellthing.AutoGenerateColumns = false;
            dgvSellthing.DataSource = new SellService().SelectSellThingAll();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvSellthing.DataSource = new SellService().SelectSellThingAll(new SellThing { SellNo = txtFind.Text.Trim(), SellName = txtFind.Text.Trim() });
        }

        private void btnDeleteSellThing_Click(object sender, EventArgs e)
        {
            bool n = new SellService().DeleteSellThingBySellNo(txtSellNo.Text.Trim());
            UIMessageBox.ShowSuccess("删除商品成功!");
            #region 获取添加操作日志所需的信息
            RecordHelper.Record(AdminInfo.Account + "-" + AdminInfo.Name + "在" + DateTime.Now + "位于" + AdminInfo.SoftwareVersion + "执行：" + "删除商品操作！删除值为：" + st.SellNo, 2);
            #endregion
            LoadData();
            return;
        }

        public bool CheckInput(SellThing sellThing) 
        {
            if(string.IsNullOrWhiteSpace(sellThing.SellNo))
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
                datains_date = DateTime.Now
            };
            if (CheckInput(st))
            {
                var SellThing = new SellService().SelectSellInfoBySellNo(st.SellNo);
                if (SellThing != null && SellThing.SellName.Equals(st.SellName) && SellThing.format.Equals(st.format))
                {
                    UIMessageBox.ShowError("信息已存在，请检查！");
                    return;
                }

                new SellService().InsertSellThing(st);
                UIMessageBox.Show("添加商品成功","系统提示",UIStyle.Green,UIMessageBoxButtons.OK);
                #region 获取添加操作日志所需的信息
                RecordHelper.Record(AdminInfo.Account + "-" + AdminInfo.Name + "在" + DateTime.Now + "位于" + AdminInfo.SoftwareVersion + "执行：" + "新增商品操作！新增值为：" + st.SellNo, 2);
                #endregion
                LoadData();
                string SellId = new CounterHelper().GetNewId("SellId");
                txtSellNo.Text = SellId;
            }
            else
            {
                UIMessageBox.ShowError("信息不完整，请检查！");
                return;
                string SellId = new CounterHelper().GetNewId("SellId");
                txtSellNo.Text = SellId;
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
                datachg_date = DateTime.Now
            };
            if (CheckInput(st))
            {
                new SellService().UpdateSellthingInfo(st);
                UIMessageBox.Show("修改商品成功","系统提示",UIStyle.Green,UIMessageBoxButtons.OK);
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


