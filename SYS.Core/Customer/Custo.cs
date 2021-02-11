using System;

namespace SYS.Core
{
    /// <summary>
    /// 客户信息
    /// </summary>
    [SqlSugar.SugarTable("userinfo")]
    public class Custo
    {
        /// <summary>
        /// 客户编号
        /// </summary>
        public string CustoNo { get; set; }
        /// <summary>
        /// 客户名称
        /// </summary>
        public string CustoName { get; set; }
        /// <summary>
        /// 客户性别
        /// </summary>
        public int CustoSex { get; set; }
        /// <summary>
        /// 客户电话
        /// </summary>
        public string CustoTel { get; set; }
        /// <summary>
        /// 证件类型
        /// </summary>
        public int PassportType { get; set; }
        /// <summary>
        /// 证件号码
        /// </summary>
        public string CustoID { get; set; }
        /// <summary>
        /// 居住地址
        /// </summary>
        public string CustoAdress { get; set; }
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime CustoBirth { get; set; }
        /// <summary>
        /// 客户类型
        /// </summary>
        public int CustoType { get; set; }
        /// <summary>
        /// 客户类型
        /// </summary>
        [SqlSugar.SugarColumn(IsIgnore = true)]
        public string typeName { get; set; }
        /// <summary>
        /// 证件类型
        /// </summary>
        [SqlSugar.SugarColumn(IsIgnore = true)]
        public string PassportName { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        [SqlSugar.SugarColumn(IsIgnore = true)]
        public string SexName { get; set; }
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
