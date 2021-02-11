using System;

namespace SYS.Core
{
    /// <summary>
    /// 客户类型
    /// </summary>
    [SqlSugar.SugarTable("usertype")]
    public class CustoType
    {
        /// <summary>
        /// 客户类型
        /// </summary>
        public int UserType { get; set; }
        /// <summary>
        /// 类型名字
        /// </summary>
        public string TypeName { get; set; }
        /// <summary>
        /// 删除标记
        /// </summary>
        public int delete_mk { get; set; }
        /// <summary>
        /// 资料创建人
        /// </summary>
        public string datains_usr { get; set; }
        /// <summary>
        /// 资料创建时间
        /// </summary>
        public DateTime datains_date { get; set; }
        /// <summary>
        /// 资料更新人
        /// </summary>
        public string datachg_usr { get; set; }
        /// <summary>
        /// 资料更新时间
        /// </summary>
        public DateTime datachg_date { get; set; }
    }
}
