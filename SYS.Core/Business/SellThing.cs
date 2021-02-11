using System;

namespace SYS.Core
{
    /// <summary>
    /// 商品信息
    /// </summary>
    public class SellThing
    {
        /// <summary>
        /// 商品编号
        /// </summary>
        public string SellNo { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string SellName { get; set; }
        /// <summary>
        /// 商品价格
        /// </summary>
        public decimal SellPrice { get; set; }
        /// <summary>
        /// 规格型号
        /// </summary>
        public string format { get; set; }
        /// <summary>
        /// 库存
        /// </summary>
        public int Stock { get; set; }
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
