using jvncorelib_fr.EntityLib;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYS.Common
{
    /// <summary>
    /// 导出助手
    /// </summary>
    public class ExportHelper
    {
        /// <summary>
        /// 导出DataGridView数据到Excel(默认当前页)
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="filePath"></param>
        /// <param name="ignoreColumns"></param>
        public void ExportDataGridViewToExcel(DataGridView dataGridView, string filePath,List<string> ignoreColumns = null)
        {
            var workbook = new XSSFWorkbook(); // 创建XSSFWorkbook实例
            ISheet sheet = workbook.CreateSheet("Customer List"); // 创建工作表

            IRow headerRow = sheet.CreateRow(0); // 创建表头行
            // 创建表头
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                if (!ignoreColumns.Contains(dataGridView.Columns[i].Name))
                {
                    var cell = headerRow.CreateCell(i);
                    cell.SetCellValue(dataGridView.Columns[i].HeaderText);
                }
            }

            // 写入数据行
            int rowIndex = 1;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow) // 排除未提交的新行
                {
                    IRow sheetRow = sheet.CreateRow(rowIndex++);
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        var cell = sheetRow.CreateCell(i);
                        var cellValue = row.Cells[i].Value;
                        if (cellValue != null && !ignoreColumns.Contains(dataGridView.Columns[i].Name)) // 检查空值
                        {
                            if (cellValue is DateTime)
                            {
                                cell.SetCellValue(Convert.ToDateTime(row.Cells[i].Value).ToString("yyyy-MM-dd"));
                            }
                            else
                            {
                                cell.SetCellValue(row.Cells[i].Value.ToString());
                            }
                        }
                    }
                }
            }

            // 保存到文件
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                workbook.Write(fileStream);
            }
        }

        /// <summary>
        /// 导出DataGridView数据到Excel(默认全部)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataSource"></param>
        /// <param name="filePath"></param>
        /// <param name="ignoreColumns"></param>
        public void ExportDataToExcel<T>(List<T> dataSource, string filePath, List<string> ignoreColumns = null)
        {
            var workbook = new XSSFWorkbook(); // 创建XSSFWorkbook实例
            ISheet sheet = workbook.CreateSheet("Customer List"); // 创建工作表

            IRow headerRow = sheet.CreateRow(0); // 创建表头行

            // 使用反射获取数据类型的属性，这些属性将用作列名
            var properties = typeof(T).GetProperties();

            if (!ignoreColumns.IsNullOrEmpty())
            {
                properties = properties.Where(prop => !ignoreColumns.Contains(prop.Name)).ToArray();
            }

            // 创建表头
            for (int i = 0; i < properties.Length; i++)
            {
                var cell = headerRow.CreateCell(i);
                cell.SetCellValue(properties[i].Name);
            }

            // 写入数据行
            int rowIndex = 1;
            foreach (var item in dataSource)
            {
                IRow sheetRow = sheet.CreateRow(rowIndex++);
                for (int i = 0; i < properties.Length; i++)
                {
                    var cell = sheetRow.CreateCell(i);
                    var value = properties[i].GetValue(item);

                    if (value != null)
                    {
                        if (value is DateTime)
                        {
                            cell.SetCellValue(((DateTime)value).ToString("yyyy-MM-dd"));
                        }
                        else
                        {
                            cell.SetCellValue(value.ToString());
                        }
                    }
                }
            }

            // 保存到文件
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                workbook.Write(fileStream);
            }
        }
    }
}
