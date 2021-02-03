using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using SYS.Manager;
using SYS.Core;
using SYS.FormUI.Properties;

namespace SYS.FormUI
{
    public partial class FrmSellThingManager : Form
    {
        public FrmSellThingManager()
        {
            InitializeComponent();
        }

        public static SellThing st;

        public void CmpSetDgv()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSellthing.AllowUserToAddRows = false;
            this.dgvSellthing.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            this.dgvSellthing.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSellthing.BackgroundColor = System.Drawing.Color.White;
            this.dgvSellthing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSellthing.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;//211, 223, 240
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("苹方-简", 14, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvSellthing.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSellthing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSellthing.EnableHeadersVisualStyles = false;
            this.dgvSellthing.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvSellthing.ReadOnly = true;
            this.dgvSellthing.RowHeadersVisible = false;
            this.dgvSellthing.RowTemplate.Height = 23;
            this.dgvSellthing.RowTemplate.ReadOnly = true;
        }

        private void FrmSellThingManager_Load(object sender, EventArgs e)
        {
            dgvSellthing.DataSource = SellThingManager.SelectSellThingAll();
            dgvSellthing.AutoGenerateColumns = false;
            CmpSetDgv();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvSellthing.DataSource = SellThingManager.SelectThingByName(txtFind.Text);
        }

        private void btnDeleteSellThing_Click(object sender, EventArgs e)
        {
            MySqlConnection con = DBHelper.GetConnection();
            con.Open();
            string sql = "delete from SellThing where SellNo='" + txtSellNo.Text + "'";
            int n = DBHelper.ExecuteNonQuery(sql);
            MessageBox.Show("删除商品成功!");
            foreach (Control c in pnlSellThingInfo.Controls)
            {
                if (c is TextBox)
                    c.Text = "";
            }
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
            };
            SellThingManager.InsertSellThing(st);
            MessageBox.Show("添加商品成功");
            dgvSellthing.DataSource = SellThingManager.SelectSellThingAll();
        }

        private void txtSellNo_TextChanged(object sender, EventArgs e)
        {

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
            picGetCustoNo.BackgroundImage = Resources.获取用户编号_ia;
            string SellId = SellThingManager.GetRandomSellNo();
            txtSellNo.Text = SellId;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("暂不支持！");
        }
    }
}


