using System;
using System.Windows.Forms;
using Sunny.UI;
using SYS.Application;
using SYS.Core;

namespace SYS.FormUI
{
    public partial class FrmCash : UIForm
    {
        public FrmCash()
        {
            InitializeComponent();
        }

        

        private void FrmCash_Load(object sender, EventArgs e)
        {
            dgvCashList.AutoGenerateColumns = false;
            dgvCashList.DataSource = new CashService().SelectCashInfoAll();
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
                    bool n = new CashService().AddCashInfo(cash);
                    if (n == true)
                    {
                        MessageBox.Show("录入成功！");
                        dgvCashList.AutoGenerateColumns = false;
                        dgvCashList.DataSource = new CashService().SelectCashInfoAll();
                        #region 获取添加操作日志所需的信息
                        OperationLog o = new OperationLog();
                        o.OperationTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd,HH:mm:ss"));
                        o.Operationlog = AdminInfo.Account + AdminInfo.Name + "于" + DateTime.Now + "进行资产录入，资产编号为：" + txtCashNo.Text.Trim();
                        o.OperationAccount = AdminInfo.Account + AdminInfo.Name;
                        #endregion
                        new OperationlogService().InsertOperationLog(o);
                        foreach (Control Ctrol in uiGroupBox1.Controls)
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
                    foreach (Control Ctrol in uiGroupBox1.Controls)
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
