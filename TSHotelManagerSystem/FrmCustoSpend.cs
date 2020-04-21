using System;
using System.Windows.Forms;
using TSHotelManagerSystem.BLL;

namespace TSHotelManagerSystem
{
    public partial class FrmCustoSpend : Form
    {
        public FrmCustoSpend()
        {
            InitializeComponent();
        }

        public void CmpSetDgv()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSpendList.AllowUserToAddRows = false;
            this.dgvSpendList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            this.dgvSpendList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSpendList.BackgroundColor = System.Drawing.Color.White;
            this.dgvSpendList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSpendList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;//211, 223, 240
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("苹方-简", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvSpendList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSpendList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpendList.EnableHeadersVisualStyles = false;
            this.dgvSpendList.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvSpendList.ReadOnly = true;
            this.dgvSpendList.RowHeadersVisible = false;
            this.dgvSpendList.RowTemplate.Height = 23;
            this.dgvSpendList.RowTemplate.ReadOnly = true;
        }

        private void FrmCustoSpend_Load(object sender, EventArgs e)
        {
            CmpSetDgv();
            dgvSpendList.AutoGenerateColumns = false;
            dgvSpendList.DataSource = SpendManager.SelectSpendInfoAll();
        }
    }
}
