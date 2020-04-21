using System;
using System.Windows.Forms;
using TSHotelManagerSystem.BLL;

namespace TSHotelManagerSystem
{
    public partial class FrmWorkerCheckInfo : Form
    {
        public FrmWorkerCheckInfo()
        {
            InitializeComponent();

        }


        public void CmpSetDgv()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvCheckInfoList.AllowUserToAddRows = false;
            this.DgvCheckInfoList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            this.DgvCheckInfoList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvCheckInfoList.BackgroundColor = System.Drawing.Color.White;
            this.DgvCheckInfoList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvCheckInfoList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;//211, 223, 240
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("苹方-简", 11, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DgvCheckInfoList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvCheckInfoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCheckInfoList.EnableHeadersVisualStyles = false;
            this.DgvCheckInfoList.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DgvCheckInfoList.ReadOnly = true;
            this.DgvCheckInfoList.RowHeadersVisible = false;
            this.DgvCheckInfoList.RowTemplate.Height = 23;
            this.DgvCheckInfoList.RowTemplate.ReadOnly = true;
        }


        private void FrmWorkerCheckInfo_Load(object sender, EventArgs e)
        {
            CmpSetDgv();
            lblWorkerInfo.Text = "以下为员工编号：" + FrmChangeWorker.wk_WorkerNo + "员工姓名：" + FrmChangeWorker.wk_WorkerName + "的所有打卡考勤记录:";
            DgvCheckInfoList.AutoGenerateColumns = false;
            DgvCheckInfoList.DataSource = WorkerCheckManager.SelectCheckInfoByWorkerNo(FrmChangeWorker.wk_WorkerNo);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
