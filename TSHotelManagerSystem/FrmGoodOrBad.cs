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
using TSHotelManagerSystem.Models;

namespace TSHotelManagerSystem
{
    public partial class FrmGoodOrBad : Form
    {
        public FrmGoodOrBad()
        {
            InitializeComponent();
        }

        public void CmpSetDgv()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvGoodBadList.AllowUserToAddRows = false;
            this.DgvGoodBadList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            this.DgvGoodBadList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvGoodBadList.BackgroundColor = System.Drawing.Color.White;
            this.DgvGoodBadList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvGoodBadList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;//211, 223, 240
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("苹方-简", 11, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DgvGoodBadList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvGoodBadList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGoodBadList.EnableHeadersVisualStyles = false;
            this.DgvGoodBadList.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DgvGoodBadList.ReadOnly = true;
            this.DgvGoodBadList.RowHeadersVisible = false;
            this.DgvGoodBadList.RowTemplate.Height = 23;
            this.DgvGoodBadList.RowTemplate.ReadOnly = true;
        }


        private void FrmGoodOrBad_Load(object sender, EventArgs e)
        {
            CmpSetDgv();
            lblWorkerNo.Text = FrmTopChange.wk_WorkerNo;
            lblName.Text = FrmTopChange.wk_WorkerName;
            lblDate.Text = FrmTopChange.wk_WorkerTime.Substring(0,9);
            DgvGoodBadList.AutoGenerateColumns = false;
            DgvGoodBadList.DataSource = WorkerGoodBadManager.SelectAllGoodBadByWorkNo(lblWorkerNo.Text);
            CboType.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (RtbGBInfo.Text != null)
            {
                DialogResult dr = MessageBox.Show("确定录入？一旦录入后将无法修改及删除，或会影响员工的晋升！", "录入警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    WorkerGoodBad goodBad = new WorkerGoodBad();
                    goodBad.WorkNo = lblWorkerNo.Text;
                    goodBad.GBType = CboType.SelectedIndex;
                    goodBad.GBInfo = RtbGBInfo.Text;
                    goodBad.GBOperation = AdminInfo.admingroup;
                    goodBad.GBTime = DtpDate.Value;
                    int n = WorkerGoodBadManager.AddGoodBad(goodBad);
                    if (n > 0)
                    {
                        MessageBox.Show("新增成功！");
                        #region 获取添加操作日志所需的信息
                        Operation o = new Operation();
                        o.OperationTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd,HH:mm:ss"));
                        o.Operationlog = AdminInfo.admingroup + AdminInfo.adminType + "于" + DateTime.Now + "对员工：" + lblName.Text + "进行了奖罚情况录入！";
                        o.OperationAccount = AdminInfo.admingroup + AdminInfo.adminType;
                        #endregion
                        OperationManager.InsertOperationLog(o);
                        DgvGoodBadList.DataSource = WorkerGoodBadManager.SelectAllGoodBadByWorkNo(lblWorkerNo.Text);
                    }
                    else
                    {
                        MessageBox.Show("或是服务器错误所致！");
                    }
                }
                else
                {
                    MessageBox.Show("取消录入操作！");
                }

            }
            else
            {
                MessageBox.Show("信息不能为空！");
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
