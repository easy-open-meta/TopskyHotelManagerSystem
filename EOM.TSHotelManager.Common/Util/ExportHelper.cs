using jvncorelib.EntityLib;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.Data;

namespace EOM.TSHotelManager.Common
{
    /// <summary>
    /// 导出助手
    /// </summary>
    public class ExportHelper
    {
        /// <summary>
        /// 导出DataTable数据到Excel
        /// </summary>
        /// <param name="dataTable">要导出的数据表</param>
        /// <param name="filePath">保存的文件路径</param>
        /// <param name="ignoreColumns">要忽略的列名列表</param>
        public void ExportDataTableToExcel(DataTable dataTable, string filePath, List<string> ignoreColumns = null)
        {
            var workbook = new XSSFWorkbook(); // 创建XSSFWorkbook实例
            ISheet sheet = workbook.CreateSheet("Customer List"); // 创建工作表

            // 创建表头
            IRow headerRow = sheet.CreateRow(0);
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                if (ignoreColumns == null || !ignoreColumns.Contains(dataTable.Columns[i].ColumnName))
                {
                    var cell = headerRow.CreateCell(i);
                    cell.SetCellValue(dataTable.Columns[i].ColumnName);
                }
            }

            // 写入数据行
            int rowIndex = 1;
            foreach (DataRow row in dataTable.Rows)
            {
                IRow sheetRow = sheet.CreateRow(rowIndex++);
                for (int i = 0; i < row.ItemArray.Length; i++)
                {
                    var cell = sheetRow.CreateCell(i);
                    var cellValue = row.ItemArray[i];
                    if (cellValue != DBNull.Value && (ignoreColumns == null || !ignoreColumns.Contains(dataTable.Columns[i].ColumnName)))
                    {
                        if (cellValue is DateTime)
                        {
                            cell.SetCellValue(Convert.ToDateTime(cellValue).ToString("yyyy-MM-dd"));
                        }
                        else
                        {
                            cell.SetCellValue(cellValue.ToString());
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
