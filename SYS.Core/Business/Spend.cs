using System;

namespace SYS.Core
{
    /// <summary>
    /// 消费信息
    /// </summary>
    public class Spend
    {
        



        /// <summary>
        /// 房间编号
        /// </summary>
        public string RoomNo { get; set; }
        /// <summary>
        /// 客户编号
        /// </summary>
        public string CustoNo { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string SpendName { get; set; }
        /// <summary>
        /// 消费数量
        /// </summary>
        public int SpendAmount { get; set; }
        /// <summary>
        /// 商品单价
        /// </summary>
        public decimal SpendPrice { get; set; }
        /// <summary>
        /// 消费金额
        /// </summary>
        public decimal SpendMoney { get; set; }
        /// <summary>
        /// 消费时间
        /// </summary>
        public DateTime SpendTime { get; set; }
        /// <summary>
        /// 结算状态
        /// </summary>
        public string MoneyState { get; set; }
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
