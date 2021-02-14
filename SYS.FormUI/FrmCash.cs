using System;
using System.Windows.Forms;
using SYS.Manager;
using SYS.Core;

namespace SYS.FormUI
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("苹方-简", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            dgvCashList.DataSource = new CashManager().SelectCashInfoAll();
            Random random = new Random();
            txtCashNo.Text = "CN" + random.Next(0, 9).ToString() + random.Next(0, 9).ToString() + random.Next(0, 9).ToString() + random.Next(0, 9).ToString();
            if (AdminInfo.Type != "财务经理" || AdminInfo.Type != "总经理")
            {
                btnOK.Enabled = false;
                btnOK.Text = "权限不足";
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtCashName.Text != "")
            {
                DialogResult dr = MessageBox.Show("请确认信息没有错误，一旦录入则无法修改！", "警告提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    Cash cash = new Cash();
                    cash.CashNo = txtCashNo.Text.Trim();
                    cash.CashName = txtCashName.Text.Trim();
                    cash.CashPrice = txtCashMoney.Text.Trim();
                    cash.CashClub = cboClub.Text;
                    cash.CashTime = dtpDate.Value;
                    cash.CashSource = txtFrom.Text.Trim();
                    cash.CashPerson = FrmMain.wk_WorkerName;
                    int n = (int)CashManager.AddCashInfo(cash);
                    if (n > 0)
                    {
                        MessageBox.Show("录入成功！");
                        dgvCashList.AutoGenerateColumns = false;
                        dgvCashList.DataSource = new CashManager().SelectCashInfoAll();
                        #region 获取添加操作日志所需的信息
                        OperationLog o = new OperationLog();
                        o.OperationTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd,HH:mm:ss"));
                        o.Operationlog = AdminInfo.Account + AdminInfo.Name + "于" + DateTime.Now + "进行资产录入，资产编号为：" + txtCashNo.Text.Trim();
                        o.OperationAccount = AdminInfo.Account + AdminInfo.Name;
                        #endregion
                        OperationManager.InsertOperationLog(o);
                        foreach (Control Ctrol in gbInfoWrite.Controls)
                        {
                            if (Ctrol is TextBox)
                            {
                                Ctrol.Text = "";
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("录入失败，请检查数据格式是否存在错误或稍后再试！");
                    }
                }
                else
                {
                    MessageBox.Show("操作取消！");
                    foreach (Control Ctrol in gbInfoWrite.Controls)
                    {
                        if (Ctrol is TextBox)
                        {
                            Ctrol.Text = "";
                        }
                    }
                }


            }
            else
            {
                MessageBox.Show("信息填写不完整，请重试！");
            }

        }
    }
}
