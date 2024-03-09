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
using EOM.TSHotelManager.Common.Core;
using Sunny.UI;
using SYS.Common;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SYS.FormUI
{
    public partial class FrmCustomerManager : Form
    {

        public delegate void ReloadCustomerList(bool onlyVip = false);


        //定义委托类型的变量
        public static ReloadCustomerList ReloadCustomer;

        public FrmCustomerManager()
        {
            InitializeComponent();
            ReloadCustomer = LoadCustomer;
        }

        Dictionary<string, string> dic = null;
        ResponseMsg result = null;

        #region 用户管理界面加载事件方法
        private void FrmCustomerManager_Load(object sender, EventArgs e)
        {
            this.btnPg.PageSize = 15;
            LoadCustomer();
        }
        #endregion

        #region 加载用户信息列表
        private void LoadCustomer(bool onlyVip = false)
        {
            dic = new Dictionary<string, string>()
            {
                { "pageIndex","1"},
                { "pageSize","15"}
            };
            if (onlyVip)
            {
                dic.Add("onlyVip", onlyVip.ToString());
            }
            result = HttpHelper.Request("Custo/SelectCustoAll", null, dic);
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectCustoAll+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            OSelectCustoAllDto custos = HttpHelper.JsonToModel<OSelectCustoAllDto>(result.message);
            btnPg.TotalCount = custos.total;
            this.dgvCustomerList.AutoGenerateColumns = false;
            this.dgvCustomerList.DataSource = custos.listSource;
        }
        #endregion

        int count = 0;
        private void btnSerach_BtnClick(object sender, EventArgs e)
        {
            dgvCustomerList.ClearRows();
            dgvCustomerList.AutoGenerateColumns = false;
            List<Custo> custos = new List<Custo>();
            if (!txtCustoNo.Text.IsNullOrEmpty())
            {
                var custo = new Custo()
                {
                    CustoNo = txtCustoNo.Text.Trim()
                };
                result = HttpHelper.Request("Custo/SelectCustoByInfo", HttpHelper.ModelToJson(custo));
                if (result.statusCode != 200)
                {
                    UIMessageBox.ShowError("SelectCustoByInfo+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                custos = HttpHelper.JsonToList<Custo>(result.message);
            }
            else if (!txtCustoName.Text.IsNullOrEmpty())
            {
                var custo = new Custo()
                {
                    CustoName = txtCustoName.Text.Trim()
                };
                result = HttpHelper.Request("Custo/SelectCustoByInfo", HttpHelper.ModelToJson(custo));
                if (result.statusCode != 200)
                {
                    UIMessageBox.ShowError("SelectCustoByInfo+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                custos = HttpHelper.JsonToList<Custo>(result.message);
            }
            else
            {
                result = HttpHelper.Request("Custo/SelectCustoAll?pageIndex=1&pageSize=15");
                var listSource = HttpHelper.JsonToModel<OSelectCustoAllDto>(result.message);
                custos = listSource.listSource;
            }
            dgvCustomerList.DataSource = custos;
        }

        private void btnAddCusto_BtnClick(object sender, EventArgs e)
        {
            FrmEditInputs frmInputs = new FrmEditInputs();
            frmInputs.ShowDialog();
        }

        private void dgvCustomerList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCustomerList.SelectedRows.Count == 1)
            {
                btnUpdCustomer.Enabled = true;
                return;
            }
            btnUpdCustomer.Enabled = true;
            return;
        }

        private void btnUpdCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomerList.SelectedRows.Count == 1)
            {
                FrmCustoManager.cm_CustoNo = dgvCustomerList.SelectedRows[0].Cells["CustoNo"].Value.ToString();
                FrmCustoManager.cm_CustoName = dgvCustomerList.SelectedRows[0].Cells["CustoName"].Value.ToString();
                FrmCustoManager.cm_CustoAddress = dgvCustomerList.SelectedRows[0].Cells["CustoAdress"].Value == null ? "" : dgvCustomerList.SelectedRows[0].Cells["CustoAdress"].Value.ToString();
                FrmCustoManager.cm_CustoType = Convert.ToInt32(dgvCustomerList.SelectedRows[0].Cells["Column2"].Value);
                FrmCustoManager.cm_CustoSex = Convert.ToInt32(dgvCustomerList.SelectedRows[0].Cells["Column4"].Value);
                FrmCustoManager.cm_PassportType = Convert.ToInt32(dgvCustomerList.SelectedRows[0].Cells["Column1"].Value);
                FrmCustoManager.cm_CustoBirth = Convert.ToDateTime(dgvCustomerList.SelectedRows[0].Cells["CustoBirth"].Value.ToString());
                FrmCustoManager.cm_CustoID = dgvCustomerList.SelectedRows[0].Cells["Column3"].Value.ToString();
                FrmCustoManager.cm_CustoTel = dgvCustomerList.SelectedRows[0].Cells["CustoTel"].Value.ToString();
                FrmEditInputs frmInputs = new FrmEditInputs();
                frmInputs.Text = "修改客户信息";
                frmInputs.ShowDialog();
            }
        }

        private void btnPg_Click(object sender, EventArgs e)
        {

        }

        private void btnPg_PageChanged(object sender, object pagingSource, int pageIndex, int count)
        {
            dic = new Dictionary<string, string>()
            {
                { "pageIndex",pageIndex.ToString()},
                { "pageSize",count.ToString()}
            };
            result = HttpHelper.Request("Custo/SelectCustoAll", null, dic);
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectCustoAll+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            OSelectCustoAllDto custos = HttpHelper.JsonToModel<OSelectCustoAllDto>(result.message);
            this.btnPg.TotalCount = custos.total;
            this.dgvCustomerList.AutoGenerateColumns = false;
            this.dgvCustomerList.DataSource = custos.listSource;
        }

        private void tsmiCustoNo_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(dgvCustomerList.SelectedRows[0].Cells["CustoNo"].Value as string);
            UIMessageTip.ShowOk("复制完成！", 1500);
        }

        private void cbOnlyVip_CheckedChanged(object sender, EventArgs e)
        {
            LoadCustomer(cbOnlyVip.Checked);
        }
    }

}
