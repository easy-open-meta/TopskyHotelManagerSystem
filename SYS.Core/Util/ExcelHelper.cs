using NPOI.HSSF.UserModel;
using NPOI.HSSF.Util;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Core.Util
{
    public class ExcelHelper : IDisposable
    {
        /// <summary>
        /// 导出列名
        /// </summary>
        public System.Collections.SortedList ListColumnsName;

        public List<List<ExcelColumn>> ListColumns;

        /// <summary>
        /// 日期格式化字符串
        /// </summary>
        public string DateFormatString = "yyyy-MM-dd HH:mm:ss";

        public string Title = "";

        public string SubTitle = "";

        private string fileName = null; //文件名
        private IWorkbook workbook = null;
        private FileStream fs = null;
        private bool disposed;

        public ExcelHelper(string fileName)
        {
            this.fileName = fileName;
            disposed = false;
        }

        /// <summary>
        /// 将DataTable数据导入到excel中
        /// </summary>
        /// <param name="data">要导入的数据</param>
        /// <param name="isColumnWritten">DataTable的列名是否要导入</param>
        /// <param name="sheetName">要导入的excel的sheet的名称</param>
        /// <returns>导入数据行数(包含列名那一行)</returns>
        public int DataTableToExcel(DataTable data, string sheetName, bool isColumnWritten)
        {
            int i = 0;
            int j = 0;
            int count = 0;
            ISheet sheet = null;

            fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            if (fileName.IndexOf(".xlsx") > 0) // 2007版本
                workbook = new XSSFWorkbook();
            else if (fileName.IndexOf(".xls") > 0) // 2003版本
                workbook = new HSSFWorkbook();

            try
            {
                if (workbook != null)
                {
                    sheet = workbook.CreateSheet(sheetName);
                }
                else
                {
                    return -1;
                }

                if (isColumnWritten == true) //写入DataTable的列名
                {
                    IRow row = sheet.CreateRow(0);
                    for (j = 0; j < data.Columns.Count; ++j)
                    {
                        row.CreateCell(j).SetCellValue(data.Columns[j].ColumnName);
                    }
                    count = 1;
                }
                else
                {
                    count = 0;
                }

                for (i = 0; i < data.Rows.Count; ++i)
                {
                    IRow row = sheet.CreateRow(count);
                    for (j = 0; j < data.Columns.Count; ++j)
                    {
                        row.CreateCell(j).SetCellValue(data.Rows[i][j].ToString());
                    }
                    ++count;
                }
                workbook.Write(fs); //写入到excel
                return count;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        /// <summary>
        /// 将excel中的数据导入到DataTable中
        /// </summary>
        /// <param name="sheetName">excel工作薄sheet的名称</param>
        /// <param name="isFirstRowColumn">第一行是否是DataTable的列名</param>
        /// <returns>返回的DataTable</returns>
        public DataTable ExcelToDataTable(string sheetName, bool isFirstRowColumn)
        {
            ISheet sheet = null;
            DataTable data = new DataTable();
            int startRow = 0;
            try
            {
                fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                if (fileName.IndexOf(".xlsx") > 0) // 2007版本
                    workbook = new XSSFWorkbook(fs);
                else if (fileName.IndexOf(".xls") > 0) // 2003版本
                    workbook = new HSSFWorkbook(fs);

                if (sheetName != null)
                {
                    sheet = workbook.GetSheet(sheetName);
                    if (sheet == null) //如果没有找到指定的sheetName对应的sheet，则尝试获取第一个sheet
                    {
                        sheet = workbook.GetSheetAt(0);
                    }
                }
                else
                {
                    sheet = workbook.GetSheetAt(0);
                }
                if (sheet != null)
                {
                    IRow firstRow = sheet.GetRow(0);
                    if (firstRow == null)
                    {
                        for (int i = 1; i <= 10; i++)
                        {
                            firstRow = sheet.GetRow(i);
                            if (firstRow != null)
                            {
                                break;
                            }
                        }
                    }
                    int cellCount = firstRow.LastCellNum; //一行最后一个cell的编号 即总的列数

                    if (isFirstRowColumn)
                    {
                        startRow = sheet.FirstRowNum + 1;
                    }
                    else
                    {
                        startRow = sheet.FirstRowNum;
                    }

                    for (int i = firstRow.FirstCellNum; i < cellCount; ++i)
                    {
                        ICell cell = firstRow.GetCell(i);
                        if (cell != null)
                        {
                            string cellValue = cell.ToString();
                            if (!string.IsNullOrEmpty(cellValue))
                            {
                                DataColumn column = new DataColumn(cellValue);
                                data.Columns.Add(column);
                            }
                        }
                    }

                    int colCount = data.Columns.Count;

                    //最后一列的标号
                    int rowCount = sheet.LastRowNum;
                    for (int i = startRow; i <= rowCount; ++i)
                    {
                        IRow row = sheet.GetRow(i);
                        if (row == null) continue; //没有数据的行默认是null　　　　　　　

                        DataRow dataRow = data.NewRow();
                        bool isAdd = true;
                        for (int j = row.FirstCellNum; j < cellCount; ++j)
                        {
                            //获得当前行的列数
                            if (j < colCount)
                            {
                                try
                                {
                                    if (row.GetCell(j) != null)
                                    {
                                        dataRow[j] = row.GetCell(j).ToString();
                                    }
                                }
                                catch (Exception)
                                {
                                    isAdd = false;
                                    break;
                                }
                            }
                            else
                            {
                                isAdd = false;
                            }
                        }
                        if (isAdd)
                        {
                            data.Rows.Add(dataRow);
                        }
                    }
                }

                return data;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        /// <summary>
        /// 创建Excel文件
        /// </summary>
        /// <param name="filePath"></param>
        public XSSFWorkbook CreateExcelFile()
        {
            XSSFWorkbook hssfworkbook = new XSSFWorkbook();
            return hssfworkbook;
        }

        /// <summary>
        /// 创建单元格样式
        /// </summary>
        /// <param name="workbook">工作薄</param>
        /// <param name="horizontal">水平位置</param>
        /// <param name="vertical">垂直位置</param>
        /// <param name="border">边框线条</param>
        /// <param name="borderColor">线条颜色</param>
        /// <returns></returns>
        public static ICellStyle CreateCellStyle(XSSFWorkbook workbook, HorizontalAlignment horizontal, VerticalAlignment vertical, BorderStyle border, short borderColor)
        {
            ICellStyle style = workbook.CreateCellStyle();
            style.Alignment = horizontal;
            style.VerticalAlignment = vertical;
            style.BorderBottom = border;
            style.BorderLeft = border;
            style.BorderRight = border;
            style.BorderTop = border;
            style.TopBorderColor = borderColor;
            style.BottomBorderColor = borderColor;
            style.LeftBorderColor = borderColor;
            style.RightBorderColor = borderColor;
            return style;
        }


        /// <summary>
        /// 创建字体
        /// </summary>
        /// <param name="workbook">工作薄</param>
        /// <param name="fontName">字体名称</param>
        /// <param name="fontSize">尺寸</param>
        /// <param name="bold">粗体</param>
        /// <param name="color">字体颜色</param>
        /// <returns></returns>
        public static IFont CreateFont(XSSFWorkbook workbook, string fontName, short fontSize, short bold, short color)
        {
            IFont font = workbook.CreateFont();
            font.FontName = fontName;
            font.FontHeightInPoints = fontSize;
            font.Boldweight = bold;
            font.Color = color;
            return font;

        }

        private ICellStyle SetCellStyle(IWorkbook workbook)
        {
            ICellStyle cellStyle = workbook.CreateCellStyle();
            //cellStyle.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.Blue.Index2;
            //cellStyle.FillPattern = FillPattern.BigSpots;
            //cellStyle.FillBackgroundColor = NPOI.HSSF.Util.HSSFColor.Pink.Index2;
            //设置单元格上下左右边框线  
            cellStyle.BorderTop = BorderStyle.Thin;
            cellStyle.BorderBottom = BorderStyle.Thin;
            cellStyle.BorderLeft = BorderStyle.Thin;
            cellStyle.BorderRight = BorderStyle.Thin;
            //文字水平和垂直对齐方式  
            cellStyle.Alignment = HorizontalAlignment.Left;
            cellStyle.VerticalAlignment = VerticalAlignment.Center;
            //是否换行  
            cellStyle.WrapText = true;
            //缩小字体填充  
            cellStyle.ShrinkToFit = true;
            return cellStyle;
        }

        private ICellStyle SetHeaderCellStyle(IWorkbook workbook)
        {
            ICellStyle cellStyle = workbook.CreateCellStyle();
            //cellStyle.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.Blue.Index2;
            //cellStyle.FillPattern = FillPattern.BigSpots;
            //cellStyle.FillBackgroundColor = NPOI.HSSF.Util.HSSFColor.Pink.Index2;
            //设置单元格上下左右边框线  
            cellStyle.BorderTop = BorderStyle.Thin;
            cellStyle.BorderBottom = BorderStyle.Thin;
            cellStyle.BorderLeft = BorderStyle.Thin;
            cellStyle.BorderRight = BorderStyle.Thin;
            //文字水平和垂直对齐方式  
            cellStyle.Alignment = HorizontalAlignment.Center;
            cellStyle.VerticalAlignment = VerticalAlignment.Center;
            //是否换行  
            //cellStyle.WrapText = true;  
            //缩小字体填充  
            //cellStyle.ShrinkToFit = true;
            return cellStyle;
        }

        public void CreateHeader(XSSFWorkbook workbook, ISheet sheet)
        {
            XSSFRow headerRow = sheet.CreateRow(0) as XSSFRow;
            ICellStyle cellStyle = SetHeaderCellStyle(workbook);

            IFont font = workbook.CreateFont();
            font.FontName = "宋体";
            //font.FontHeightInPoints = 10;
            font.Boldweight = 700;
            cellStyle.SetFont(font);

            int cellIndex = 0;
            //循环导出列
            foreach (System.Collections.DictionaryEntry de in ListColumnsName)
            {
                ICell newCell = headerRow.CreateCell(cellIndex);
                newCell.CellStyle = cellStyle;
                newCell.SetCellValue(de.Value.ToString());
                cellIndex++;
            }

        }

        /// <summary>
        /// 创建excel表头
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="excelSheet"></param>
        public void CreateHeader(XSSFWorkbook workbook, ISheet excelSheet, ref int rowCount)
        {
            if (!string.IsNullOrEmpty(this.Title))
            {
                //插入报表标题行
                IRow row0 = excelSheet.CreateRow(rowCount);//创建一行
                row0.Height = 600;
                ICell titleCell = row0.CreateCell(0, CellType.String);
                ICellStyle titleStyle = CreateCellStyle(workbook, HorizontalAlignment.Center, VerticalAlignment.Center,
                    BorderStyle.None, 0);
                IFont titlFont = CreateFont(workbook, "宋体", 18, 700, HSSFColor.Black.Index);
                titleStyle.SetFont(titlFont);
                titleCell.CellStyle = titleStyle;
                CellRangeAddress region = new CellRangeAddress(0, 0, 0, ListColumnsName.Count - 1);//参数：起始行号，终止行号， 起始列号，终止列号
                excelSheet.AddMergedRegion(region);
                titleCell.SetCellValue(this.Title);
                rowCount++;
            }

            if (!string.IsNullOrEmpty(this.SubTitle))
            {
                ICellStyle infoCellStyle = CreateCellStyle(workbook, HorizontalAlignment.Left, VerticalAlignment.Center,
                BorderStyle.None, 0);
                IFont infoFont = CreateFont(workbook, "宋体", 14, 300, HSSFColor.Black.Index);
                infoCellStyle.SetFont(infoFont);

                ////插入报表基本信息行2
                IRow row2 = excelSheet.CreateRow(rowCount);//创建一行
                row2.Height = 600;
                ICell info2Cell1 = row2.CreateCell(0, CellType.String);
                infoCellStyle.SetFont(infoFont);
                info2Cell1.CellStyle = infoCellStyle;
                CellRangeAddress info2Region1 = new CellRangeAddress(rowCount, rowCount, 0, ListColumnsName.Count - 1);//参数：起始行号，终止行号， 起始列号，终止列号
                excelSheet.AddMergedRegion(info2Region1);
                info2Cell1.SetCellValue(this.SubTitle);//可能存在多个，建议取消在这里显示
                rowCount++;
            }

            //循环导出列
            if (ListColumnsName != null && ListColumnsName.Count > 0)
            {
                int cellIndex = 0;
                IRow newRow = excelSheet.CreateRow(rowCount);
                newRow.Height = 400;
                ICellStyle style = workbook.CreateCellStyle();
                style.Alignment = HorizontalAlignment.Center;
                style.VerticalAlignment = VerticalAlignment.Center;
                style.FillForegroundColor = HSSFColor.Grey25Percent.Index;
                style.FillPattern = FillPattern.LeastDots;
                style.FillBackgroundColor = HSSFColor.Grey25Percent.Index;

                IFont font = workbook.CreateFont();
                font.FontName = "宋体";
                font.FontHeightInPoints = 12;
                font.Boldweight = 600;

                style.SetFont(font);

                foreach (System.Collections.DictionaryEntry de in ListColumnsName)
                {
                    ICell newCell = newRow.CreateCell(cellIndex);
                    newCell.CellStyle = style;
                    newCell.SetCellValue(de.Value.ToString());
                    cellIndex++;
                }
                rowCount++;
            }
            else
            {
                if (ListColumns != null && ListColumns.Count > 0)
                {
                    ListColumnsName = new System.Collections.SortedList(new NoSort());
                    Dictionary<int, int> currentHeadRow = new Dictionary<int, int>();
                    Dictionary<string, List<int>> fieldIndex = new Dictionary<string, List<int>>();
                    Func<int, int> GetCurrentHeadRow = cell => currentHeadRow.ContainsKey(cell) ? currentHeadRow[cell] : 0;
                    var currentRow = rowCount;
                    var currentCell = 0;

                    //生成多行题头
                    for (var i = 0; i < ListColumns.Count; i++)
                    {
                        currentCell = 0;

                        IRow newRow = excelSheet.CreateRow(currentRow);
                        newRow.Height = 400;
                        ICellStyle style = workbook.CreateCellStyle();
                        style.Alignment = HorizontalAlignment.Center;
                        style.VerticalAlignment = VerticalAlignment.Center;
                        style.FillForegroundColor = HSSFColor.Grey25Percent.Index;
                        style.FillPattern = FillPattern.LeastDots;
                        style.FillBackgroundColor = HSSFColor.Grey25Percent.Index;

                        IFont font = workbook.CreateFont();
                        font.FontName = "宋体";
                        font.FontHeightInPoints = 12;
                        font.Boldweight = 600;
                        style.SetFont(font);

                        for (var j = 0; j < ListColumns[i].Count; j++)
                        {
                            var item = ListColumns[i][j];
                            if (item.hidden) continue;

                            while (currentRow < GetCurrentHeadRow(currentCell))
                            {
                                currentCell++;
                            }

                            ICell newCell = newRow.CreateCell(currentCell);
                            newCell.CellStyle = style;
                            newCell.SetCellValue(item.title);

                            if (item.rowspan + item.colspan > 2)
                            {
                                excelSheet.AddMergedRegion(new CellRangeAddress(currentRow, currentRow + item.rowspan - 1, currentCell, currentCell + item.colspan - 1));
                            }

                            if (!string.IsNullOrEmpty(item.field))
                            {
                                if (!fieldIndex.ContainsKey(item.field))
                                    fieldIndex[item.field] = new List<int>();
                                fieldIndex[item.field].Add(currentCell);
                                ListColumnsName.Add(item.field, item.title);
                            }

                            for (var k = 0; k < item.colspan; k++)
                            {
                                currentHeadRow[currentCell] = GetCurrentHeadRow(currentCell++) + item.rowspan;
                            }
                        }
                        currentRow++;
                        rowCount++;
                    }
                }
            }
        }


        public void CreateHeader(HSSFWorkbook workbook, ISheet excelSheet)
        {
            int cellIndex = 0;
            IRow newRow = excelSheet.CreateRow(0);
            newRow.Height = 400;
            ICellStyle style = workbook.CreateCellStyle();
            style.Alignment = HorizontalAlignment.Center;
            style.VerticalAlignment = VerticalAlignment.Center;
            style.FillForegroundColor = HSSFColor.Grey25Percent.Index;
            style.FillPattern = FillPattern.LeastDots;
            style.FillBackgroundColor = HSSFColor.Grey25Percent.Index;

            IFont font = workbook.CreateFont();
            font.FontName = "宋体";
            font.FontHeightInPoints = 10;
            font.Boldweight = 600;
            style.SetFont(font);
            //循环导出列
            foreach (System.Collections.DictionaryEntry de in ListColumnsName)
            {
                ICell newCell = newRow.CreateCell(cellIndex);
                newCell.CellStyle = style;
                newCell.SetCellValue(de.Value.ToString());
                cellIndex++;
            }
        }

        /// <summary>
        /// 导出数据行
        /// </summary>
        /// <param name="dtSource"></param>
        /// <param name="drSource"></param>
        /// <param name="currentExcelRow"></param>
        /// <param name="excelSheet"></param>
        /// <param name="excelWorkBook"></param>
        /// <param name="cellStyle">格式化日期显示</param>
        protected void InsertCell(int[] arrColWidth, DataRow drSource, IRow currentExcelRow, ISheet excelSheet, XSSFWorkbook excelWorkBook, ICellStyle cellStyle, ref int margeStartRowIndex, ref int margeStartColIndex)
        {
            int margeEndRowIndex = 0;
            int margeEndColIndex = 0;
            margeStartRowIndex = currentExcelRow.RowNum;

            for (int cellIndex = 0; cellIndex < ListColumnsName.Count; cellIndex++)
            {
                excelSheet.SetColumnWidth(cellIndex, (arrColWidth[cellIndex]) * 256);
                //列名称
                string columnsName = ListColumnsName.GetKey(cellIndex).ToString();
                ICell newCell = null;
                System.Type rowType = drSource[columnsName].GetType();
                string drValue = drSource[columnsName].ToString().Trim();

                bool margeStartFlag = false;
                bool margeEndFlag = false;
                if (drValue.Contains("[MargeStart]"))
                {
                    margeStartFlag = true;
                    drValue = drValue.Replace("[MargeStart]", "");
                }
                if (drValue.Contains("[MargeEnd]"))
                {
                    margeEndFlag = true;
                    drValue = drValue.Replace("[MargeEnd]", "");
                }

                switch (rowType.ToString())
                {
                    case "System.String"://字符串类型
                        drValue = drValue.Replace("&", "&");
                        drValue = drValue.Replace(">", ">");
                        drValue = drValue.Replace("<", "<");
                        newCell = currentExcelRow.CreateCell(cellIndex);
                        newCell.SetCellValue(drValue);
                        newCell.CellStyle.VerticalAlignment = VerticalAlignment.Center;
                        newCell.CellStyle.WrapText = true;
                        break;
                    case "System.DateTime"://日期类型
                        DateTime dateV;
                        DateTime.TryParse(drValue, out dateV);
                        newCell = currentExcelRow.CreateCell(cellIndex);
                        newCell.SetCellValue(dateV);
                        newCell.CellStyle = cellStyle;
                        newCell.CellStyle.VerticalAlignment = VerticalAlignment.Center;
                        break;
                    case "System.Boolean"://布尔型
                        bool boolV = false;
                        bool.TryParse(drValue, out boolV);
                        newCell = currentExcelRow.CreateCell(cellIndex);
                        newCell.SetCellValue(boolV);
                        newCell.CellStyle.VerticalAlignment = VerticalAlignment.Center;
                        break;
                    case "System.Int16"://整型
                    case "System.Int32":
                    case "System.Int64":
                    case "System.Byte":
                        long intV = 0;
                        long.TryParse(drValue, out intV);
                        newCell = currentExcelRow.CreateCell(cellIndex);
                        newCell.SetCellValue(intV.ToString());
                        newCell.CellStyle.VerticalAlignment = VerticalAlignment.Center;
                        break;
                    case "System.Decimal"://浮点型
                    case "System.Double":
                        double doubV = 0;
                        double.TryParse(drValue, out doubV);
                        newCell = currentExcelRow.CreateCell(cellIndex);
                        newCell.SetCellValue(doubV);
                        newCell.CellStyle.VerticalAlignment = VerticalAlignment.Center;
                        break;
                    case "System.DBNull"://空值处理
                        newCell = currentExcelRow.CreateCell(cellIndex);
                        newCell.SetCellValue("");
                        newCell.CellStyle.VerticalAlignment = VerticalAlignment.Center;
                        break;
                    default:
                        throw (new Exception(rowType.ToString() + "：类型数据无法处理!"));
                }

                if (margeStartFlag)
                {
                    currentExcelRow.Height = 600;
                    margeStartColIndex = cellIndex;

                    ICellStyle myStyle = excelWorkBook.CreateCellStyle();
                    myStyle.FillForegroundColor = HSSFColor.LemonChiffon.Index;
                    myStyle.FillPattern = FillPattern.SolidForeground;
                    myStyle.FillBackgroundColor = HSSFColor.LemonChiffon.Index;
                    myStyle.BorderLeft = BorderStyle.Thin;
                    myStyle.LeftBorderColor = HSSFColor.Black.Index;

                    myStyle.Alignment = HorizontalAlignment.Left;
                    myStyle.VerticalAlignment = VerticalAlignment.Center;

                    IFont fontStyle = excelWorkBook.CreateFont();
                    fontStyle.IsBold = true;
                    fontStyle.FontHeightInPoints = (short)11;
                    myStyle.SetFont(fontStyle);

                    newCell.CellStyle = myStyle;
                }

                if (margeEndFlag)
                {
                    margeEndRowIndex = currentExcelRow.RowNum;
                    margeEndColIndex = cellIndex;

                    CellRangeAddress region1 = new CellRangeAddress(margeStartRowIndex, margeEndRowIndex, margeStartColIndex, margeEndColIndex); //参数1：起始行 参数2：终止行 参数3：起始列 参数4：终止列   
                    excelSheet.AddMergedRegion(region1);
                }
            }
        }

        protected void InsertCell(DataRow drSource, IRow currentExcelRow, ISheet excelSheet, HSSFWorkbook excelWorkBook, ICellStyle cellStyle)
        {

            for (int cellIndex = 0; cellIndex < ListColumnsName.Count; cellIndex++)
            {
                //列名称
                string columnsName = ListColumnsName.GetKey(cellIndex).ToString();
                ICell newCell = null;
                System.Type rowType = drSource[columnsName].GetType();

                string drValue = drSource[columnsName].ToString().Trim();
                switch (rowType.ToString())
                {
                    case "System.String"://字符串类型
                        drValue = drValue.Replace("&", "&");
                        drValue = drValue.Replace(">", ">");
                        drValue = drValue.Replace("<", "<");
                        newCell = currentExcelRow.CreateCell(cellIndex);
                        newCell.SetCellValue(drValue);
                        break;
                    case "System.DateTime"://日期类型
                        DateTime dateV;
                        DateTime.TryParse(drValue, out dateV);
                        newCell = currentExcelRow.CreateCell(cellIndex);
                        newCell.SetCellValue(dateV.ToString(DateFormatString));
                        break;
                    case "System.Boolean"://布尔型
                        bool boolV = false;
                        bool.TryParse(drValue, out boolV);
                        newCell = currentExcelRow.CreateCell(cellIndex);
                        newCell.SetCellValue(boolV);
                        break;
                    case "System.Int16"://整型
                    case "System.Int32":
                    case "System.Int64":
                    case "System.Byte":
                        long intV = 0;
                        long.TryParse(drValue, out intV);
                        newCell = currentExcelRow.CreateCell(cellIndex);
                        newCell.SetCellValue(intV.ToString());
                        break;
                    case "System.Decimal"://浮点型
                    case "System.Double":
                        double doubV = 0;
                        double.TryParse(drValue, out doubV);
                        newCell = currentExcelRow.CreateCell(cellIndex);
                        newCell.SetCellValue(doubV);
                        break;
                    case "System.DBNull"://空值处理
                        newCell = currentExcelRow.CreateCell(cellIndex);
                        newCell.SetCellValue("");
                        break;
                    default:
                        throw (new Exception(rowType.ToString() + "：类型数据无法处理!"));
                }
                newCell.CellStyle = cellStyle;
            }
        }


        protected void InsertCell(DataRow drSource, XSSFRow currentExcelRow, ISheet excelSheet, XSSFWorkbook excelWorkBook, ICellStyle cellStyle)
        {

            for (int cellIndex = 0; cellIndex < ListColumnsName.Count; cellIndex++)
            {
                //列名称
                string columnsName = ListColumnsName.GetKey(cellIndex).ToString();
                ICell newCell = null;
                System.Type rowType = drSource[columnsName].GetType();

                string drValue = drSource[columnsName].ToString().Trim();
                switch (rowType.ToString())
                {
                    case "System.String"://字符串类型
                        drValue = drValue.Replace("&", "&");
                        drValue = drValue.Replace(">", ">");
                        drValue = drValue.Replace("<", "<");
                        newCell = currentExcelRow.CreateCell(cellIndex);
                        newCell.SetCellValue(drValue);
                        break;
                    case "System.DateTime"://日期类型
                        DateTime dateV;
                        DateTime.TryParse(drValue, out dateV);
                        newCell = currentExcelRow.CreateCell(cellIndex);
                        newCell.SetCellValue(dateV.ToString(DateFormatString));
                        break;
                    case "System.Boolean"://布尔型
                        bool boolV = false;
                        bool.TryParse(drValue, out boolV);
                        newCell = currentExcelRow.CreateCell(cellIndex);
                        newCell.SetCellValue(boolV);
                        break;
                    case "System.Int16"://整型
                    case "System.Int32":
                    case "System.Int64":
                    case "System.Byte":
                        long intV = 0;
                        long.TryParse(drValue, out intV);
                        newCell = currentExcelRow.CreateCell(cellIndex);
                        newCell.SetCellValue(intV.ToString());
                        break;
                    case "System.Decimal"://浮点型
                    case "System.Double":
                        double doubV = 0;
                        double.TryParse(drValue, out doubV);
                        newCell = currentExcelRow.CreateCell(cellIndex);
                        newCell.SetCellValue(doubV);
                        break;
                    case "System.DBNull"://空值处理
                        newCell = currentExcelRow.CreateCell(cellIndex);
                        newCell.SetCellValue("");
                        break;
                    default:
                        throw (new Exception(rowType.ToString() + "：类型数据无法处理!"));
                }
                newCell.CellStyle = cellStyle;
            }
        }

        /// <summary>
        /// 插入数据行
        /// </summary>
        protected void InsertRow(DataTable dtSource, XSSFWorkbook workbook, String sheetName)
        {
            int rowCount = 0;
            int sheetCount = 1;
            ISheet newsheet = null;

            sheetName = string.IsNullOrEmpty(sheetName) ? "Sheet" + sheetCount : sheetName;
            newsheet = workbook.CreateSheet(sheetName);

            //循环数据源导出数据集
            CreateHeader(workbook, newsheet, ref rowCount);

            //取得列宽
            Int32[] arrColWidth = new Int32[ListColumnsName.Count];

            for (Int32 i = 0; i < dtSource.Rows.Count; i++)
            {
                for (Int32 j = 0; j < ListColumnsName.Count; j++)
                {
                    string key = ListColumnsName.GetKey(j).ToString();
                    //标题宽度
                    string columnName = ListColumnsName.GetValueList()[j].ToString();
                    int len = Encoding.UTF8.GetBytes(columnName).Length;
                    Int32 intTemp = Encoding.UTF8.GetBytes(dtSource.Rows[i][key].ToString()).Length;
                    if (intTemp < len)
                        intTemp = len;
                    if (intTemp > arrColWidth[j] && intTemp <= 80)
                    {
                        arrColWidth[j] = intTemp;
                    }
                }
            }

            try
            {
                //格式化显示
                ICellStyle cellStyle = workbook.CreateCellStyle();
                IDataFormat format = workbook.CreateDataFormat();
                cellStyle.VerticalAlignment = VerticalAlignment.Center;
                cellStyle.DataFormat = format.GetFormat(DateFormatString);
                int margeStartRowIndex = rowCount;
                int margeStartColIndex = 0;
                foreach (DataRow dr in dtSource.Rows)
                {
                    //超出10000条数据 创建新的工作簿
                    if (rowCount == 10000)
                    {
                        rowCount = 0;
                        sheetCount++;
                        newsheet = workbook.CreateSheet("Sheet" + sheetCount);
                        CreateHeader(workbook, newsheet, ref rowCount);
                    }

                    IRow newRow = newsheet.CreateRow(rowCount);
                    InsertCell(arrColWidth, dr, newRow, newsheet, workbook, cellStyle, ref margeStartRowIndex, ref margeStartColIndex);

                    rowCount++;
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public MemoryStream TableToExcelForXLS(DataTable dt, string sheetName = "")
        {
            MemoryStream ms = null;
            HSSFWorkbook workbook = null;
            ISheet sheet = null;

            try
            {
                ms = new MemoryStream();
                workbook = new HSSFWorkbook();
                if (!string.IsNullOrEmpty(sheetName))
                {
                    sheet = workbook.CreateSheet(sheetName);
                }
                else
                {
                    sheet = workbook.CreateSheet();
                }
                int sheetCount = 1;

                CreateHeader(workbook, sheet);

                ICellStyle cellStyle = SetCellStyle(workbook);
                int rowCount = 0;
                foreach (DataRow row in dt.Rows)
                {
                    rowCount++;
                    //超出10000条数据 创建新的工作簿
                    if (rowCount == 10000)
                    {
                        rowCount = 1;
                        sheetCount++;
                        if (!string.IsNullOrEmpty(sheetName))
                        {
                            sheet = workbook.CreateSheet(sheetName + sheetCount);
                        }
                        else
                        {
                            sheet = workbook.CreateSheet("Sheet" + sheetCount);
                        }
                        CreateHeader(workbook, sheet);
                    }
                    IRow dataRow = sheet.CreateRow(rowCount);
                    InsertCell(row, dataRow, sheet, workbook, cellStyle);
                }
                //列宽自适应，只对英文和数字有效
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    sheet.AutoSizeColumn(i);
                }

                //转为字节数组
                workbook.Write(ms);
                ms.Flush();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                ms.Close();
                sheet = null;
                workbook = null;
            }
            return ms;

        }

        public MemoryStream DataSetToExcelForXLS(DataSet ds)
        {
            MemoryStream ms = null;
            HSSFWorkbook workbook = null;
            ISheet sheet = null;

            try
            {
                ms = new MemoryStream();
                workbook = new HSSFWorkbook();

                foreach (DataTable dt in ds.Tables)
                {
                    sheet = sheet = workbook.CreateSheet(dt.TableName);
                    int sheetCount = 1;

                    CreateHeader(workbook, sheet);

                    ICellStyle cellStyle = SetCellStyle(workbook);
                    int rowCount = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        rowCount++;
                        //超出10000条数据 创建新的工作簿
                        if (rowCount == 10000)
                        {
                            rowCount = 1;
                            sheetCount++;
                            sheet = workbook.CreateSheet(dt.TableName + sheetCount);
                            CreateHeader(workbook, sheet);
                        }
                        IRow dataRow = sheet.CreateRow(rowCount);
                        InsertCell(row, dataRow, sheet, workbook, cellStyle);
                    }
                    //列宽自适应，只对英文和数字有效
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        sheet.AutoSizeColumn(i);
                    }
                }

                //转为字节数组
                workbook.Write(ms);
                ms.Flush();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                ms.Close();
                sheet = null;
                workbook = null;
            }
            return ms;

        }

        public MemoryStream DataTableToExcel2(DataTable dt, string sheetName = "")
        {
            int sheetCount = 1;
            XSSFWorkbook workbook = null;
            MemoryStream ms = null;
            ISheet sheet = null;
            try
            {
                ms = new MemoryStream();
                workbook = new XSSFWorkbook();
                if (!string.IsNullOrEmpty(sheetName))
                {
                    sheet = workbook.CreateSheet(sheetName);
                }
                else
                {
                    sheet = workbook.CreateSheet();
                }
                CreateHeader(workbook, sheet);

                ICellStyle cellStyle = SetCellStyle(workbook);
                int rowCount = 0;
                foreach (DataRow row in dt.Rows)
                {
                    rowCount++;
                    //超出10000条数据 创建新的工作簿
                    if (rowCount == 10000)
                    {
                        rowCount = 1;
                        sheetCount++;
                        if (!string.IsNullOrEmpty(sheetName))
                        {
                            sheet = workbook.CreateSheet(sheetName + sheetCount);
                        }
                        else
                        {
                            sheet = workbook.CreateSheet("Sheet" + sheetCount);
                        }
                        CreateHeader(workbook, sheet);
                    }
                    XSSFRow dataRow = sheet.CreateRow(rowCount) as XSSFRow;
                    InsertCell(row, dataRow, sheet, workbook, cellStyle);
                }
                //列宽自适应，只对英文和数字有效
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    sheet.AutoSizeColumn(i);
                }

                workbook.Write(ms);
                ms.Flush();
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                ms.Close();
                sheet = null;
                workbook = null;
            }
            return ms;
        }

        public MemoryStream DataSetToExcel2(DataSet ds)
        {
            int sheetCount = 1;
            XSSFWorkbook workbook = null;
            MemoryStream ms = null;
            ISheet sheet = null;
            try
            {
                ms = new MemoryStream();
                workbook = new XSSFWorkbook();

                foreach (DataTable dt in ds.Tables)
                {
                    sheet = workbook.CreateSheet(dt.TableName);
                    CreateHeader(workbook, sheet);

                    ICellStyle cellStyle = SetCellStyle(workbook);
                    int rowCount = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        rowCount++;
                        //超出10000条数据 创建新的工作簿
                        if (rowCount == 10000)
                        {
                            rowCount = 1;
                            sheetCount++;
                            sheet = workbook.CreateSheet(dt.TableName + sheetCount);
                            CreateHeader(workbook, sheet);
                        }
                        XSSFRow dataRow = sheet.CreateRow(rowCount) as XSSFRow;
                        InsertCell(row, dataRow, sheet, workbook, cellStyle);
                    }
                    //列宽自适应，只对英文和数字有效
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        sheet.AutoSizeColumn(i);
                    }
                }

                workbook.Write(ms);
                ms.Flush();
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                ms.Close();
                sheet = null;
                workbook = null;
            }
            return ms;
        }

        // <summary>
        /// 保存到文件
        /// </summary>
        /// <param name="ms"></param>
        /// <param name="fileName"></param>
        public void SaveToFile(DataTable dt)
        {
            MemoryStream ms;
            string ext = Path.GetExtension(fileName);
            if (ext.Equals(".xls", StringComparison.OrdinalIgnoreCase))
            {
                ms = TableToExcelForXLS(dt);
            }
            else
            {
                ms = DataTableToExcel2(dt);
            }

            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                byte[] data = ms.ToArray();
                fs.Write(data, 0, data.Length);
                fs.Flush();
                data = null;
            }
        }

        public void SaveToFile(DataSet ds)
        {
            string ext = Path.GetExtension(fileName);

            MemoryStream ms;
            if (ext.Equals(".xls", StringComparison.OrdinalIgnoreCase))
            {
                ms = DataSetToExcelForXLS(ds);
            }
            else
            {
                ms = DataSetToExcel2(ds);
            }

            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                byte[] data = ms.ToArray();
                fs.Write(data, 0, data.Length);
                fs.Flush();
                data = null;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    if (fs != null)
                        fs.Close();
                }

                fs = null;
                disposed = true;
            }
        }
    }

    //排序实现接口 不进行排序 根据添加顺序导出   
    public class NoSort : System.Collections.IComparer
    { public int Compare(object x, object y) { return -1; } }

    public class ExcelColumn
    {
        public ExcelColumn()
        {
            rowspan = 1;
            colspan = 1;
        }
        public string field { get; set; }
        public string title { get; set; }
        public int rowspan { get; set; }
        public int colspan { get; set; }
        public bool hidden { get; set; }
    }
}
