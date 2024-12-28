using AntdUI;
using EOM.TSHotelManager.Common.Util;
using System.Reflection;
using System.Xml.Linq;

namespace EOM.TSHotelManager.FormUI
{
    public class TableComHelper
    {
        private XDocument _xmlDoc;

        public TableComHelper()
        {
            try
            {
                var xmlContent = Properties.Resources.EOM_TSHotelManager_Common_Core;
                using (StringReader stringReader = new StringReader(xmlContent))
                {
                    _xmlDoc = XDocument.Load(stringReader);
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("无法加载嵌入的XML内容", ex);
            }
        }

        /// <summary>
        /// 转换字段为AntdUI Table组件的Column类型
        /// </summary>
        /// <param name="tableColumns"></param>
        /// <returns></returns>
        public ColumnCollection ConvertToAntdColumns(List<TableColumn> tableColumns)
        {
            var columnCollection = new ColumnCollection();

            foreach (var tableColumn in tableColumns)
            {
                var column = new Column(
                    tableColumn.Field,                 // 列名
                    tableColumn.Description,              // 列标题
                    ColumnAlign.Center                // 对齐方式
                )
                {
                    Visible = true,
                    SortOrder = true,
                    Align = ColumnAlign.Center,
                    ColAlign = ColumnAlign.Center,
                    LineBreak = true
                };

                columnCollection.Add(column);
            }

            return columnCollection;
        }

        /// <summary>
        /// 转换字段为AntdUI Table组件的AntItem类型
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="datas"></param>
        /// <returns></returns>
        public List<AntdUI.AntItem[]> ConvertToAntdItems<T>(List<T> datas)
        {
            var listTableSource = new List<AntdUI.AntItem[]>();
            var properties = typeof(T).GetProperties(); // 获取泛型实体T的所有属性

            foreach (var data in datas)
            {
                var antItems = new List<AntdUI.AntItem>();

                foreach (var prop in properties)
                {
                    // 获取 UIDisplay 特性
                    var displayAttribute = prop.GetCustomAttribute<UIDisplayAttribute>();

                    // 如果没有 UIDisplay 特性，则跳过
                    if (displayAttribute == null)
                    {
                        continue;
                    }

                    var propName = prop.Name; // 获取属性名
                    var propValue = prop.GetValue(data); // 获取属性值
                    var propType = prop.PropertyType; // 获取属性的类型

                    // 根据字段的类型做特定处理
                    if (propType == typeof(bool) || propType == typeof(int))
                    {
                        var boolValue = Convert.ToBoolean(propValue);
                        var cellTag = boolValue ? new AntdUI.CellTag("是", AntdUI.TTypeMini.Error) : new AntdUI.CellTag("否", AntdUI.TTypeMini.Success);
                        antItems.Add(new AntdUI.AntItem(propName, cellTag));
                    }
                    else if (propType == typeof(string))
                    {
                        antItems.Add(new AntdUI.AntItem(propName, propValue?.ToString()));
                    }
                    else if (propType == typeof(DateTime))
                    {
                        var dateValue = (DateTime)propValue;

                        if (dateValue.Hour == 0 && dateValue.Minute == 0 && dateValue.Second == 0)
                        {
                            antItems.Add(new AntdUI.AntItem(propName, dateValue.ToString("yyyy-MM-dd")));
                        }
                        else
                        {
                            antItems.Add(new AntdUI.AntItem(propName, dateValue.ToString("yyyy-MM-dd HH:mm:ss")));
                        }
                    }
                    else
                    {
                        // 对于其他类型，默认显示字段名和字段值
                        antItems.Add(new AntdUI.AntItem(propName, propValue?.ToString()));
                    }
                }

                listTableSource.Add(antItems.ToArray()); // 添加处理后的AntdItem数组到结果集中
            }
            return listTableSource;
        }

        /// <summary>
        /// 获取实体字段名
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        public List<TableColumn> GenerateDataColumns<T>() where T : class
        {
            var tableColumns = new List<TableColumn>();
            var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var property in properties)
            {
                // 获取 UIDisplay 特性
                var displayAttribute = property.GetCustomAttribute<UIDisplayAttribute>();

                // 如果没有 UIDisplay 特性，则跳过
                if (displayAttribute == null)
                {
                    continue;
                }
                var propertyName = property.Name;
                string comment;
                try
                {
                    comment = GetPropertyComment(_xmlDoc, typeof(T).FullName, propertyName);
                }
                catch (Exception ex)
                {
                    comment = $"注释获取失败: {ex.Message}";
                }

                tableColumns.Add(new TableColumn(propertyName, displayAttribute.DisplayName ?? comment));
            }

            return tableColumns;
        }

        /// <summary>
        /// 获取字段对应注释
        /// </summary>
        /// <param name="xmlDoc"></param>
        /// <param name="typeName"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        public string GetPropertyComment(XDocument xmlDoc, string typeName, string propertyName)
        {
            var propertyNameInXml = $"{typeName}.{propertyName}";
            var commentElement = xmlDoc
                .Descendants("member")
                .FirstOrDefault(x => x.Attribute("name")?.Value == $"P:{propertyNameInXml}")
                ?.Descendants("summary")
                .FirstOrDefault();

            return commentElement?.Value.Trim() ?? "No comment";
        }

        /// <summary>
        /// 表字段
        /// </summary>
        public class TableColumn
        {
            public TableColumn(string field, string description)
            {
                Field = field;
                Description = description;
            }

            public string Field { get; set; }
            public string Description { get; set; }
        }
    }
}
