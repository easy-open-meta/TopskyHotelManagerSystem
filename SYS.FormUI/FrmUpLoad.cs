using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using SYS.Manager;
using SYS.Core;

namespace SYS.FormUI
{
    public partial class FrmUpLoad : Form
    {
        public FrmUpLoad()
        {
            InitializeComponent();
        }

        private void UpLoadNotice_Click(object sender, EventArgs e)
        {
            pnlUpLoad.Visible = true;
        }

        private void btnUpLoad_Click(object sender, EventArgs e)
        {
            string sql = "insert UPLOADINFO(NoticeNo,Noticetheme,NoticeTime,NoticeContent,NoticeClub,NoticePerson)";
            sql += " values('" + txtUpLoadNo.Text + "','" + txtNoticeTheme.Text + "','" + dtpUpLoadDate.Value.ToShortDateString() + "','" + rtbNoticeContent.Text + "','" + cboSelectClub.Text + "','Admin')";
            MySqlConnection con = DBHelper.GetConnection();
            con.Open();
            int n = DBHelper.ExecuteNonQuery(sql);
            MessageBox.Show("上传成功，上传日期为：" + DateTime.Now.ToShortDateString() + "");
            #region 获取添加操作日志所需的信息
            Operation o = new Operation();
            o.OperationTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd,HH:mm:ss"));
            o.Operationlog = AdminInfo.admingroup + AdminInfo.adminType + "于" + DateTime.Now + "进行了上传公告操作！";
            o.OperationAccount = AdminInfo.admingroup + AdminInfo.adminType;
            #endregion
            OperationManager.InsertOperationLog(o);
            foreach (Control Ctrol in pnlUpLoad.Controls)
            {
                if (Ctrol is TextBox)
                {
                    Ctrol.Text = "";
                }
                if (Ctrol is RichTextBox)
                {
                    Ctrol.Text = "";
                }
            }
        }

        public void CmpSetDgv()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvNoticeList.AllowUserToAddRows = false;
            this.dgvNoticeList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            this.dgvNoticeList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNoticeList.BackgroundColor = System.Drawing.Color.White;
            this.dgvNoticeList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvNoticeList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;//211, 223, 240
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("苹方-简", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvNoticeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNoticeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNoticeList.EnableHeadersVisualStyles = false;
            this.dgvNoticeList.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvNoticeList.ReadOnly = true;
            this.dgvNoticeList.RowHeadersVisible = false;
            this.dgvNoticeList.RowTemplate.Height = 23;
            this.dgvNoticeList.RowTemplate.ReadOnly = true;
        }

        private void FrmUpLoad_Load(object sender, EventArgs e)
        {
            CmpSetDgv();
            cboSelectClub.SelectedIndex = 0;
            dgvNoticeList.AutoGenerateColumns = false;
            dgvNoticeList.DataSource = NoticeManager.SelectNoticeAll();
        }

        private void dgvNoticeList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pnlUpLoad.Visible = true;
            txtUpLoadNo.Text = dgvNoticeList.SelectedRows[0].Cells["clNoticeNo"].Value.ToString();
            txtNoticeTheme.Text = dgvNoticeList.SelectedRows[0].Cells["clNoticetheme"].Value.ToString();
            rtbNoticeContent.Text = dgvNoticeList.SelectedRows[0].Cells["clNoticeContent"].Value.ToString();
            //cboSelectClub.Text= dgvNoticeList.SelectedRows[0].Cells["clNoticeClub"].ToString();
            //txtNoticePerson.Text= dgvNoticeList.SelectedRows[0].Cells["clNoticePerson"].ToString();
        }
    }
}
