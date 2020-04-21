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

        private void FrmGoodOrBad_Load(object sender, EventArgs e)
        {
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
    }
}
