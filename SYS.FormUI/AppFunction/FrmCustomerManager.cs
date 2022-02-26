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
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using SYS.Core;
using SYS.FormUI.Properties;
using System.Collections.Generic;
using System.Linq;
using SYS.Application;
using Sunny.UI;

namespace SYS.FormUI
{
    public partial class FrmCustomerManager : Form
    {

        public delegate void ReloadCustomerList();


        //定义委托类型的变量
        public static ReloadCustomerList ReloadCustomer;

        public FrmCustomerManager()
        {
            InitializeComponent();
            ReloadCustomer = LoadCustomer;
        }

        #region 用户管理界面加载事件方法
        private void FrmCustomerManager_Load(object sender, EventArgs e)
        {
            foreach (Control label in this.Controls)
            {
                label.Font = UI_FontUtil.childControlFont;
            }
            LoadCustomer();
            
        }
        #endregion

        #region 加载用户信息列表
        private void LoadCustomer()
        {

            List<Custo> lstSource = new CustoService().SelectCustoAll();
            this.dgvCustomerList.DataSource = lstSource;
            this.dgvCustomerList.AutoGenerateColumns = false;
        }
        #endregion

        #region 计算点击次数
        private int n = 0;
        #endregion

        #region 隐藏显示信息
        private void picShow_Click(object sender, EventArgs e)
        {
            
        }
        #endregion

        //#region 导出事件方法
        //private void picLoadOut_Click(object sender, EventArgs e)
        //{
        //    #region 导出信息保存为Excel表
        //    bool ret = UIMessageBox.Show("导出信息为敏感操作，确定要继续导出吗？(此步操作将写入操作日志)", "信息提醒",UIStyle.Orange, UIMessageBoxButtons.OKCancel);
        //    if (!ret)
        //    {
        //        //Response.ContentEncoding = System.Text.Encoding.UTF8;
        //        string fileName = "";
        //        string saveFileName = "";
        //        //fileName.Charset = "GB2312";
        //        SaveFileDialog saveDialog = new SaveFileDialog();
        //        //saveDialog.DefaultExt = "xls";
        //        saveDialog.FileName = fileName;
        //        saveDialog.Filter = "2003~2007工作表*.xls|*.xls|2010及以上版本工作表*.xlsx|*.xlsx";
        //        saveDialog.ShowDialog();
        //        saveFileName = saveDialog.FileName;
        //        if (saveFileName.IndexOf(":") < 0) return;
        //        Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
        //        if (xlApp == null)
        //        {
        //            UIMessageBox.Show("无法创建Excel对象,您的电脑可能未安装Excel！", "来自T仔的提醒",UIStyle.Red);
        //            return;
        //        }
        //        Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;
        //        Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
        //        Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];
        //        for (int i = 0; i < this.dgvCustomerList.Columns.Count; i++)
        //        {
        //            xlApp.Cells[1, i + 1] = dgvCustomerList.Columns[i].HeaderText;
        //        }
        //        for (int i = 0; i < dgvCustomerList.Rows.Count; i++)//添加每一项
        //        {
        //            for (int j = 0; j < dgvCustomerList.Columns.Count; j++)
        //            {
        //                xlApp.Cells[i + 2, j + 1] = dgvCustomerList.Rows[i].Cells[j].ToString();
        //            }
        //        }
        //        System.Windows.Forms.Application.DoEvents();
        //        worksheet.Columns.EntireColumn.AutoFit();//列宽自适应
        //        UIMessageBox.Show(fileName + "信息导出成功", "来自T仔提示",UIStyle.Green, UIMessageBoxButtons.OKCancel);
        //        #region 获取添加操作日志所需的信息
        //        RecordHelper.Record(LoginInfo.WorkerClub + LoginInfo.WorkerName + LoginInfo.WorkerPosition + LoginInfo.WorkerName + "于" + DateTime.Now + "导出了" + "用户信息!", 3);
        //        #endregion
        //        System.Diagnostics.Process.Start("Explorer.exe", saveFileName);
        //        if (saveFileName != "")
        //        {
        //            try
        //            {
        //                workbook.Saved = true;
        //                workbook.SaveCopyAs(saveFileName);  //fileSaved = true;                 
        //            }
        //            catch (Exception ex)
        //            {//fileSaved = false;                      
        //                UIMessageBox.Show("导出文件时出错,文件可能正被打开！\n" + ex.Message,"系统提示",UIStyle.Red);
        //            }
        //        }
        //        xlApp.Quit();
        //        GC.Collect();
        //        #endregion
        //    }
        //}
        //#endregion


        private void btnSerach_BtnClick(object sender, EventArgs e)
        {
            if (txtCustoNo.Text != "")
            {
                dgvCustomerList.ClearRows();
                dgvCustomerList.AutoGenerateColumns = false;
                List<Custo> custos = new CustoService().SelectCustoByInfo(new Custo { CustoNo = txtCustoNo.Text.Trim() });
                dgvCustomerList.DataSource = custos;
            }
            else
            {
                dgvCustomerList.ClearRows();
                dgvCustomerList.AutoGenerateColumns = false;
                List<Custo> custos = new CustoService().SelectCustoAll();
                dgvCustomerList.DataSource = custos;
            }
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
    }

}
