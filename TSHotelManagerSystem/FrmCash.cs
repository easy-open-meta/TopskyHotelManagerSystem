using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSHotelManagerSystem.BLL;

namespace TSHotelManagerSystem
{
    public partial class FrmCash : Form
    {
        public FrmCash()
        {
            InitializeComponent();
        }

        public void CmpSetDgv()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCashList.AllowUserToAddRows = false;
            this.dgvCashList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            this.dgvCashList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCashList.BackgroundColor = System.Drawing.Color.White;
            this.dgvCashList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCashList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;//211, 223, 240
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvCashList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCashList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCashList.EnableHeadersVisualStyles = false;
            this.dgvCashList.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvCashList.ReadOnly = true;
            this.dgvCashList.RowHeadersVisible = false;
            this.dgvCashList.RowTemplate.Height = 23;
            this.dgvCashList.RowTemplate.ReadOnly = true;
        }

        private void FrmCash_Load(object sender, EventArgs e)
        {
            CmpSetDgv();
            dgvCashList.AutoGenerateColumns = false;
            dgvCashList.DataSource = CashManager.SelectCashInfoAll();
            
        }
    }
}
