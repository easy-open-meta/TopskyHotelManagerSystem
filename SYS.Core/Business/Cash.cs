using System;
namespace SYS.Core
{
    /// <summary>
    /// 资产管理
    /// </summary>
    [SqlSugar.SugarTable("cashinfo")]
    public class Cash
    {
        /// <summary>
        /// 资产编号
        /// </summary>
        public string CashNo { get; set; }
        /// <summary>
        /// 资产名称
        /// </summary>
        public string CashName { get; set; }
        /// <summary>
        /// 资产总值
        /// </summary>
        public string CashPrice { get; set; }
        /// <summary>
        /// 所属部门
        /// </summary>
        public string CashClub { get; set; }
        /// <summary>
        /// 入库时间
        /// </summary>
        public DateTime CashTime { get; set; }
        /// <summary>
        /// 资产来源
        /// </summary>
        public string CashSource { get; set; }
        /// <summary>
        /// 资产经办人
        /// </summary>
        public string CashPerson { get; set; }
    }
}
