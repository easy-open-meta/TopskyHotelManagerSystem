using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSHotelManagerSystem.DAL;

namespace TSHotelManagerSystem
{
    public partial class FrmOperation : Form
    {
        public FrmOperation()
        {
            InitializeComponent();
        }

        public void CmpSetDgv()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvOperationlog.AllowUserToAddRows = false;
            this.dgvOperationlog.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            this.dgvOperationlog.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOperationlog.BackgroundColor = System.Drawing.Color.White;
            this.dgvOperationlog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvOperationlog.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;//211, 223, 240
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("苹方-简", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvOperationlog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOperationlog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperationlog.EnableHeadersVisualStyles = false;
            this.dgvOperationlog.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvOperationlog.ReadOnly = true;
            this.dgvOperationlog.RowHeadersVisible = false;
            this.dgvOperationlog.RowTemplate.Height = 23;
            this.dgvOperationlog.RowTemplate.ReadOnly = true;
        }

        private void FrmOperation_Load(object sender, EventArgs e)
        {
            CmpSetDgv();
            dgvOperationlog.DataSource = Operationlog.SelectOperationlogAll();
        }
    }
}
