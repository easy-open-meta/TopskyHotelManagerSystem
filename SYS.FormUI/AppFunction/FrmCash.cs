/*
 * MIT License
 *Copyright (c) 2021 咖啡与网络(java-and-net)

 *Permission is hereby granted, free of charge, to any person obtaining a copy
 *of this software and associated documentation files (the "Software"), to deal
 *in the Software without restriction, including without limitation the rights
 *to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 *copies of the Software, and to permit persons to whom the Software is
 *furnished to do so, subject to the following conditions:

 *The above copyright notice and this permission notice shall be included in all
 *copies or substantial portions of the Software.

 *THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 *IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 *FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 *AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 *LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 *OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 *SOFTWARE.
 *
 */
using System;
using System.Windows.Forms;
using Sunny.UI;
using SYS.Application;
using SYS.Common;
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
            txtCashNo.Text = new CounterHelper().GetNewId(CounterRuleConsts.CashInfo);
            if (AdminInfo.Type != "GeneralManager" && AdminInfo.Type != "FinanceManager" && AdminInfo.isAdmin == false)
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
                    
                    bool n = new CashService().AddCashInfo(cash);
                    if (n == true)
                    {
                        UIMessageBox.Show("录入成功！","系统提示",UIStyle.Green,UIMessageBoxButtons.OKCancel);
                        dgvCashList.AutoGenerateColumns = false;
                        dgvCashList.DataSource = new CashService().SelectCashInfoAll();
                        #region 获取添加操作日志所需的信息
                        RecordHelper.Record(AdminInfo.Account + AdminInfo.Name + "于" + DateTime.Now + "进行资产录入，资产编号为：" + txtCashNo.Text.Trim(), 3);
                        txtCashNo.Text = new CounterHelper().GetNewId("CashInfo");
                        #endregion
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
