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

        private void FrmSellThingManager_Load(object sender, EventArgs e)
        {
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
            MessageBox.Show("删除商品成功!");
            foreach (Control c in pnlSellThingInfo.Controls)
            {
                if (c is TextBox)
                    c.Text = "";
            }
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
                SellName = txtSellName.Text,
                SellPrice = Convert.ToDecimal(txtSellPrice.Text),
                format = Convert.ToString(txtformat.Text),
                Stock = Convert.ToInt32(txtStock.Text),
                datains_usr = AdminInfo.Account,
                datains_date = DateTime.Now
            };
            if (CheckInput(st))
            {
                new SellService().InsertSellThing(st);
                MessageBox.Show("添加商品成功");
                dgvSellthing.DataSource = new SellService().SelectSellThingAll();
                string SellId = new CounterHelper().GetNewId("SellId");
                txtSellNo.Text = SellId;
            }
            else
            {
                UIMessageBox.ShowError("信息不完整，请检查！");
                return;
            }
            
        }

        private void dgvSellthing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSellNo.Text = dgvSellthing.SelectedRows[0].Cells["SellNo"].Value.ToString();
            txtSellName.Text = dgvSellthing.SelectedRows[0].Cells["SellName"].Value.ToString();
            txtSellPrice.Text = dgvSellthing.SelectedRows[0].Cells["SellPrice"].Value.ToString();
            txtformat.Text = dgvSellthing.SelectedRows[0].Cells["format"].Value.ToString();
            txtStock.Text = dgvSellthing.SelectedRows[0].Cells["Stock"].Value.ToString();
        }

        private void picGetCustoNo_Click(object sender, EventArgs e)
        {
            //picGetCustoNo.BackgroundImage = Resources.获取用户编号_ia;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}


