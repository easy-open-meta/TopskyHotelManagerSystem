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
            foreach (Control item in this.Controls)
            {
                item.Font = UI_FontUtil.mainFont;
            }
            //获取所有部门信息
            cboClub.DataSource = new BaseService().SelectDeptAll();
            cboClub.DisplayMember = "dept_name";
            cboClub.ValueMember = "dept_no";
            //获取所有员工信息
            cboCashPerson.DataSource = new WorkerService().SelectWorkerAll();
            cboCashPerson.DisplayMember = "WorkerName";
            cboCashPerson.ValueMember = "WorkerId";

            dgvCashList.AutoGenerateColumns = false;
            dgvCashList.DataSource = new CashService().SelectCashInfoAll();
<<<<<<< HEAD
            Random random = new Random();
            txtCashNo.Text = "CN" + random.Next(0, 9).ToString() + random.Next(0, 9).ToString() + random.Next(0, 9).ToString() + random.Next(0, 9).ToString();
            if (AdminInfo.Type != "财务经理" || AdminInfo.Type != "总经理")
=======
            txtCashNo.Text = new CounterHelper().GetNewId("CashInfo");
            if (AdminInfo.Type != "总经理" && AdminInfo.Type != "财务经理")
>>>>>>> fb009c4fe69c0285ef7856f5960db104eecbccf7
            {
                btnOK.Enabled = false;
                btnOK.Text = "权限不足";
            }

        }

        public bool CheckInput(Cash cash)
        {
            if (string.IsNullOrWhiteSpace(cash.CashNo))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(cash.CashName))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(cash.CashPerson))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(cash.CashPrice + ""))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(cash.CashSource))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(cash.CashTime + ""))
            {
                return false;
            }
            return true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Cash cash = new Cash()
            {
                CashNo = txtCashNo.Text.Trim(),
                CashName = txtCashName.Text.Trim(),
                CashPrice = txtCashMoney.Text == null ? 0 : Convert.ToDecimal(txtCashMoney.Text),
                CashClub = cboClub.SelectedValue.ToString(),
                CashTime = dtpDate.Value,
                CashSource = txtFrom.Text.Trim(),
                CashPerson = cboCashPerson.SelectedValue.ToString(),
                datains_usr = AdminInfo.Account,
                datains_date = DateTime.Now
            };
            if (CheckInput(cash))
            {
                bool dr = UIMessageBox.Show("请确认信息没有错误，一旦录入则无法修改！", "警告提醒",UIStyle.Orange, UIMessageBoxButtons.OKCancel);
                if (dr == true)
                {
<<<<<<< HEAD
                    Cash cash = new Cash();
                    cash.CashNo = txtCashNo.Text.Trim();
                    cash.CashName = txtCashName.Text.Trim();
                    cash.CashPrice = txtCashMoney.Text.Trim();
                    cash.CashClub = cboClub.Text;
                    cash.CashTime = dtpDate.Value;
                    cash.CashSource = txtFrom.Text.Trim();
                    cash.CashPerson = FrmMain.wk_WorkerName;
=======
                    
>>>>>>> fb009c4fe69c0285ef7856f5960db104eecbccf7
                    bool n = new CashService().AddCashInfo(cash);
                    if (n == true)
                    {
                        UIMessageBox.Show("录入成功！","系统提示",UIStyle.Green,UIMessageBoxButtons.OKCancel);
                        dgvCashList.AutoGenerateColumns = false;
                        dgvCashList.DataSource = new CashService().SelectCashInfoAll();
                        #region 获取添加操作日志所需的信息
                        OperationLog o = new OperationLog();
                        o.OperationTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd,HH:mm:ss"));
                        o.Operationlog = AdminInfo.Account + AdminInfo.Name + "于" + DateTime.Now + "进行资产录入，资产编号为：" + txtCashNo.Text.Trim();
                        o.OperationAccount = AdminInfo.Account + AdminInfo.Name;
                        #endregion
                        new OperationlogService().InsertOperationLog(o);
<<<<<<< HEAD
                        foreach (Control Ctrol in uiGroupBox1.Controls)
                        {
                            if (Ctrol is TextBox)
                            {
                                Ctrol.Text = "";
                            }
                        }
=======
                        txtCashNo.Text = new CounterHelper().GetNewId("CashInfo");
>>>>>>> fb009c4fe69c0285ef7856f5960db104eecbccf7

                    }
                    else
                    {
                        UIMessageBox.Show("录入失败，请检查数据格式是否存在错误或稍后再试！", "系统提示", UIStyle.Red, UIMessageBoxButtons.OK);
                        return;
                    }
                }
                else
                {
                    UIMessageBox.Show("操作取消！", "系统提示", UIStyle.Orange, UIMessageBoxButtons.OK);
                    return;
                }
            }
            else
            {
                UIMessageBox.Show("信息填写不完整，请重试！", "系统提示", UIStyle.Red, UIMessageBoxButtons.OK);
                return;
            }

        }
    }
}
