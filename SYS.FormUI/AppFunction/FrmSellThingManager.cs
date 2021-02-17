using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using SYS.Core;
using SYS.FormUI.Properties;
using SYS.Application;
using Sunny.UI;

namespace SYS.FormUI
{
    public partial class FrmSellThingManager : UIForm
    {
        public FrmSellThingManager()
        {
            InitializeComponent();
        }

        public static SellThing st;

<<<<<<< HEAD
        private void FrmSellThingManager_Load(object sender, EventArgs e)
        {
=======
        public void LoadData()
        {
            dgvSellthing.AutoGenerateColumns = false;
            dgvSellthing.DataSource = new SellService().SelectSellThingAll();
        }

        private void FrmSellThingManager_Load(object sender, EventArgs e)
        {
            foreach (Control label in this.Controls)
            {
                label.Font = UI_FontUtil.childControlFont;
            }
>>>>>>> fb009c4fe69c0285ef7856f5960db104eecbccf7
            string SellId = new CounterHelper().GetNewId("SellId");
            txtSellNo.Text = SellId;
            dgvSellthing.DataSource = new SellService().SelectSellThingAll();
            dgvSellthing.AutoGenerateColumns = false;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvSellthing.DataSource = new SellService().SelectSellThingByName(txtFind.Text);
        }

        private void btnDeleteSellThing_Click(object sender, EventArgs e)
        {
            bool n = new SellService().DeleteSellThingBySellNo(txtSellNo.Text.Trim());
<<<<<<< HEAD
            MessageBox.Show("删除商品成功!");
            foreach (Control c in pnlSellThingInfo.Controls)
=======
            UIMessageBox.ShowSuccess("删除商品成功!");
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
>>>>>>> fb009c4fe69c0285ef7856f5960db104eecbccf7
            {
                return false;
            }
            return true;
        }

<<<<<<< HEAD
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

=======
>>>>>>> fb009c4fe69c0285ef7856f5960db104eecbccf7
        private void btnAddSellThing_Click(object sender, EventArgs e)
        {
            st = new SellThing()
            {
                SellNo = txtSellNo.Text,
<<<<<<< HEAD
                SellName = txtSellName.Text,
                SellPrice = Convert.ToDecimal(txtSellPrice.Text),
                format = Convert.ToString(txtformat.Text),
                Stock = Convert.ToInt32(txtStock.Text),
=======
                SellName = string.IsNullOrWhiteSpace(txtSellName.Text) ? "" : txtSellName.Text,
                SellPrice = string.IsNullOrWhiteSpace(txtSellPrice.Text) ? 0 : Convert.ToDecimal(txtSellPrice.Text),
                format = string.IsNullOrWhiteSpace(txtformat.Text) ? "" : Convert.ToString(txtformat.Text),
                Stock = txtStock.Value == 0 ? 0 : Convert.ToInt32(txtStock.Value),
>>>>>>> fb009c4fe69c0285ef7856f5960db104eecbccf7
                datains_usr = AdminInfo.Account,
                datains_date = DateTime.Now
            };
            if (CheckInput(st))
            {
<<<<<<< HEAD
                new SellService().InsertSellThing(st);
                MessageBox.Show("添加商品成功");
                dgvSellthing.DataSource = new SellService().SelectSellThingAll();
=======
                var SellThing = new SellService().SelectSellInfoBySellNo(st.SellNo);
                if (SellThing != null && SellThing.SellName.Equals(st.SellName) && SellThing.format.Equals(st.format))
                {
                    UIMessageBox.ShowError("信息已存在，请检查！");
                    return;
                }

                new SellService().InsertSellThing(st);
                UIMessageBox.Show("添加商品成功","系统提示",UIStyle.Green,UIMessageBoxButtons.OK);
                LoadData();
>>>>>>> fb009c4fe69c0285ef7856f5960db104eecbccf7
                string SellId = new CounterHelper().GetNewId("SellId");
                txtSellNo.Text = SellId;
            }
            else
            {
                UIMessageBox.ShowError("信息不完整，请检查！");
                return;
<<<<<<< HEAD
=======
                string SellId = new CounterHelper().GetNewId("SellId");
                txtSellNo.Text = SellId;
>>>>>>> fb009c4fe69c0285ef7856f5960db104eecbccf7
            }
            
        }

        private void dgvSellthing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
<<<<<<< HEAD
            txtSellNo.Text = dgvSellthing.SelectedRows[0].Cells["SellNo"].Value.ToString();
            txtSellName.Text = dgvSellthing.SelectedRows[0].Cells["SellName"].Value.ToString();
            txtSellPrice.Text = dgvSellthing.SelectedRows[0].Cells["SellPrice"].Value.ToString();
            txtformat.Text = dgvSellthing.SelectedRows[0].Cells["format"].Value.ToString();
            txtStock.Text = dgvSellthing.SelectedRows[0].Cells["Stock"].Value.ToString();
        }

        private void picGetCustoNo_Click(object sender, EventArgs e)
        {
            //picGetCustoNo.BackgroundImage = Resources.获取用户编号_ia;
            

=======
            txtSellNo.Text = dgvSellthing.SelectedRows[0].Cells["clSellNo"].Value.ToString();
            txtSellName.Text = dgvSellthing.SelectedRows[0].Cells["clSellName"].Value.ToString();
            txtSellPrice.Text = dgvSellthing.SelectedRows[0].Cells["clSellPrice"].Value.ToString();
            txtformat.Text = dgvSellthing.SelectedRows[0].Cells["clFormat"].Value.ToString();
            txtStock.Value = Convert.ToDouble(dgvSellthing.SelectedRows[0].Cells["clStock"].Value);
>>>>>>> fb009c4fe69c0285ef7856f5960db104eecbccf7
        }

        private void txtStock_ValueChanged(object sender, double value)
        {
            //对数量步进器做限制，当小于0时使其一直保持0
            if (txtStock.Value <= 0)
            {
                txtStock.Value = 0;
            }
        }
<<<<<<< HEAD
=======

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
                LoadData();
            }
            else
            {
                UIMessageBox.Show("信息不完整，请检查！", "系统提示", UIStyle.Red, UIMessageBoxButtons.OK);
                return;
            }
        }
>>>>>>> fb009c4fe69c0285ef7856f5960db104eecbccf7
    }
}


