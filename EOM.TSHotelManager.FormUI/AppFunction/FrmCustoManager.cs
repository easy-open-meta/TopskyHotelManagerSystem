/*
 * MIT License
 *Copyright (c) 2021 易开元(EOM)

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

using AntdUI;
using EOM.TSHotelManager.Common;
using EOM.TSHotelManager.Common.Core;
using jvncorelib.EntityLib;
using System.Data;

namespace EOM.TSHotelManager.FormUI
{
    public partial class FrmCustoManager : Window
    {
        public static string cm_CustoNo;
        public static string cm_CustoName;
        public static int cm_CustoSex;
        public static string cm_CustoTel;
        public static int cm_PassportType;
        public static string cm_CustoID;
        public static string cm_CustoAddress;
        public static DateTime cm_CustoBirth;
        public static int cm_CustoType;

        public delegate void ReloadCustomerList(bool onlyVip);


        //定义委托类型的变量
        public static ReloadCustomerList ReloadCusto;
        TableComHelper tableComHelper = null;
        public FrmCustoManager()
        {
            InitializeComponent();
            ReloadCusto = LoadCustomer;
            tableComHelper = new TableComHelper();
        }

        Dictionary<string, string> dic = null;
        ResponseMsg result = null;

        private void FrmCustoManager_Load(object sender, EventArgs e)
        {
            this.btnPg.PageSize = 15;
            LoadCustomer();
        }

        #region 加载用户信息列表
        private void LoadCustomer(bool onlyVip = false)
        {
            var dataCount = 0;
            btnPg.PageSizeOptions = new int[] { 15, 30, 50, 100 };
            dgvCustomerList.Spin("正在加载中...", () =>
            {
                TableComHelper tableComHelper = new TableComHelper();
                dgvCustomerList.Columns = tableComHelper.ConvertToAntdColumns(tableComHelper.GenerateDataColumns<Custo>());
                dgvCustomerList.DataSource = GetPageData(btnPg.Current, btnPg.PageSize, ref dataCount, onlyVip);
                btnPg.PageSize = 15;
                btnPg.Current = 1;
                btnPg.Total = dataCount;
            }, () =>
            {
                System.Diagnostics.Debug.WriteLine("加载结束");
            });
        }

        object GetPageData(int current, int pageSize, ref int totalCount, bool onlyVip = false)
        {
            dic = new Dictionary<string, string>()
            {
                { "pageIndex",current <= 0 ? "1":current.ToString()},
                { "pageSize",pageSize.ToString()}
            };
            if (onlyVip)
            {
                dic.Add("onlyVip", onlyVip.ToString());
            }
            result = HttpHelper.Request("Custo/SelectCustoAll", null, dic);
            if (result.statusCode != 200)
            {
                AntdUI.Message.error(this, "SelectCustoAll+接口服务异常，请提交Issue或尝试更新版本！");
                return null!;
            }
            OSelectAllDto<Custo> custos = HttpHelper.JsonToModel<OSelectAllDto<Custo>>(result.message);
            totalCount = custos.total;
            var listTableSource = new List<AntdUI.AntItem[]>();

            custos.listSource = custos.listSource.OrderBy(a => a.CustoNo).ThenBy(a => a.CustoName).ToList();

            TableComHelper tableComHelper = new TableComHelper();
            listTableSource = tableComHelper.ConvertToAntdItems(custos.listSource);

            return listTableSource;
        }

        #endregion

        /// <summary>
        /// 将DataGridView里的数据转换成DataTable
        /// </summary>
        /// <param name="dgv"></param>
        /// <returns></returns>
        public DataTable ConvertDataGridViewToDataTable(DataGridView dgv)
        {
            // 创建一个新的DataTable对象
            DataTable dt = new DataTable();

            // 为DataTable添加列，列名与DataGridView的列名相同
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                dt.Columns.Add(column.Name, column.ValueType);
            }

            // 遍历DataGridView的每一行，并将其添加到DataTable中
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow) // 排除新行（未绑定的行）
                {
                    DataRow dataRow = dt.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dataRow[cell.OwningColumn.Name] = cell.Value;
                    }
                    dt.Rows.Add(dataRow);
                }
            }

            return dt;
        }

        private void tsmiCustoNo_Click(object sender, EventArgs e)
        {
            if (!cm_CustoNo.IsNullOrEmpty())
            {
                Clipboard.SetText(cm_CustoNo);
                AntdUI.Message.success(this, "复制完成！");
            }
        }

        private void btnSerach_Click(object sender, EventArgs e)
        {
            OSelectAllDto<Custo> custos = new OSelectAllDto<Custo>();
            if (!txtCustoNo.Text.IsNullOrEmpty() || !txtCustoName.Text.IsNullOrEmpty())
            {
                if (!txtCustoNo.Text.IsNullOrEmpty())
                {
                    dic = new Dictionary<string, string>
                    {
                        { "CustoNo", txtCustoNo.Text.Trim() }
                    };
                }
                if (!txtCustoName.Text.IsNullOrEmpty())
                {
                    dic = new Dictionary<string, string>
                    {
                        { "CustoName",  txtCustoName.Text.Trim() }
                    };
                }
                result = HttpHelper.Request("Custo/SelectCustoByInfo", null, dic);
                if (result.statusCode != 200)
                {
                    AntdUI.Message.error(this, "SelectCustoByInfo+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
            }
            else
            {
                result = HttpHelper.Request("Custo/SelectCustoAll?pageIndex=1&pageSize=15");
                if (result.statusCode != 200)
                {
                    AntdUI.Message.error(this, "SelectCustoAll+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
            }

            custos = HttpHelper.JsonToModel<OSelectAllDto<Custo>>(result.message);

            var listTableSource = new List<AntdUI.AntItem[]>();

            custos.listSource = custos.listSource.OrderBy(a => a.CustoNo).ThenBy(a => a.CustoName).ToList();

            TableComHelper tableComHelper = new TableComHelper();
            listTableSource = tableComHelper.ConvertToAntdItems(custos.listSource);

            dgvCustomerList.Spin("正在加载中...", () =>
            {
                dgvCustomerList.DataSource = listTableSource;
            }, () =>
            {
                System.Diagnostics.Debug.WriteLine("加载结束");
            });

            dgvCustomerList.DataSource = custos;
        }

        private void btnAddCusto_Click(object sender, EventArgs e)
        {
            FrmEditInputs frmInputs = new FrmEditInputs();
            frmInputs.ShowDialog();
            frmInputs.Text = "添加客户";
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            //// 调用之前定义的导出方法
            //ExportHelper exportHelper = new ExportHelper();
            //SaveFileDialog saveFileDialog = new SaveFileDialog();
            //// 设置保存对话框的属性
            //saveFileDialog.Filter = "2003~2007工作表*.xls|*.xls|2010及以上版本工作表*.xlsx|*.xlsx";
            //saveFileDialog.Title = cbExportAll.Checked ? "导出Excel文件(导出全部)" : "导出Excel文件(导出当前页)";
            //saveFileDialog.FileName = Convert.ToDateTime(DateTime.Now).ToString("yyyyMMddHHmmss") + "_" + "客户列表"; // 默认文件名
            //saveFileDialog.CheckPathExists = true; // 检查目录是否存在

            //if (saveFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    // 用户确认保存，获取选择的文件路径
            //    string filePath = saveFileDialog.FileName;

            //    try
            //    {
            //        if (cbExportAll.Checked)
            //        {
            //            dic = new Dictionary<string, string>()
            //            {
            //                { "pageIndex",null},
            //                { "pageSize",null}
            //            };
            //            ResponseMsg response = HttpHelper.Request("Custo/SelectCustoAll", null, dic);
            //            if (response.statusCode != 200)
            //            {
            //                AntdUI.Message.error(this,"SelectCustoAll+接口服务异常，请提交Issue或尝试更新版本！");
            //                return;
            //            }
            //            OSelectAllDto<Custo> custos = HttpHelper.JsonToModel<OSelectAllDto<Custo>>(response.message);
            //            exportHelper.ExportDataToExcel(custos.listSource, filePath, new List<string> { "CustoSex", "PassportType", "CustoID", "CustoType", "delete_mk", "datains_usr", "datains_date", "datachg_usr", "datachg_date" });
            //        }
            //        else
            //        {
            //            exportHelper.ExportDataTableToExcel(ConvertDataGridViewToDataTable(dgvCustomerList.CopyData(dgvCustomerList.SelectedIndex), filePath, new List<string> { "Column1", "Column2", "Column3", "Column4" });
            //        }
            //        AntdUI.Message.success(this,"导出成功！");
            //        System.Diagnostics.Process.Start("Explorer.exe", filePath);
            //        #region 获取添加操作日志所需的信息
            //        RecordHelper.Record(LoginInfo.WorkerClub + LoginInfo.WorkerName + LoginInfo.WorkerPosition + LoginInfo.WorkerName + "于" + Convert.ToDateTime(DateTime.Now) + "导出了" + "后台用户信息!", 3);
            //        #endregion
            //    }
            //    catch (Exception ex)
            //    {
            //        // 处理可能发生的任何错误
            //        AntdUI.Message.error(this, $"导出失败: {ex.Message}");
            //    }
            //}
            //// 如果用户取消了保存，则不执行任何操作
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvCustomerList.SelectedIndex < 0)
            {
                AntdUI.Message.error(this, "未选中客户，无法继续操作！");
                return;
            }
            FrmEditInputs frmInputs = new FrmEditInputs();
            frmInputs.Text = "修改客户信息";
            frmInputs.ShowDialog();
        }

        private void dgvCustomerList_CellClick(object sender, TableClickEventArgs e)
        {
            if (e.Record is IList<AntdUI.AntItem> data)
            {
                cm_CustoNo = data[0].value.ToString();
                cm_CustoName = data[1].value.ToString();
                cm_CustoSex = Convert.ToInt32(SexConstant.GetCodeByDescription(data[2].value.ToString()));
                cm_CustoTel = data[3].value.ToString();
                cm_CustoBirth = Convert.ToDateTime(data[4].value.ToString());
                cm_CustoType = Convert.ToInt32(CustomTypeConstant.GetCodeByDescription(data[5].value.ToString()));
                cm_PassportType = Convert.ToInt32(PassportConstant.GetCodeByDescription(data[6].value.ToString()));
                cm_CustoID = data[7].value.ToString();
                cm_CustoAddress = data[8].value.ToString();
                btnUpdate.Enabled = true;
            }
        }

        private void cbOnlyVip_CheckedChanged(object sender, BoolEventArgs e)
        {
            LoadCustomer(e.Value);
        }

        private void btnPg_ValueChanged(object sender, PagePageEventArgs e)
        {
            var dataCount = 0;
            dgvCustomerList.Spin("正在加载中...", () =>
            {
                dgvCustomerList.DataSource = GetPageData(e.Current, e.PageSize, ref dataCount);
                btnPg.Total = dataCount;
            }, () =>
            {
                System.Diagnostics.Debug.WriteLine("加载结束");
            });
        }

        private string btnPg_ShowTotalChanged(object sender, PagePageEventArgs e)
        {
            return $"{e.PageSize} / {e.Total}条 共{e.PageTotal}页";
        }
    }
}
