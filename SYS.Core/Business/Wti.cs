using System;

namespace SYS.Core
{
    /// <summary>
    /// 水电信息
    /// </summary>
    public class Wti
    {
        /// <summary>
        /// 信息编号
        /// </summary>
        public string WtiNo { get; set; }
        /// <summary>
        /// 房间编号
        /// </summary>
        public string RoomNo { get; set; }
        /// <summary>
        /// 开始使用时间
        /// </summary>
        public DateTime UseDate { get; set; }
        /// <summary>
        /// 结束使用时间
        /// </summary>
        public DateTime EndDate { get; set; }
        /// <summary>
        /// 水费
        /// </summary>
        public decimal WaterUse { get; set; }
        /// <summary>
        /// 电费
        /// </summary>
        public decimal PowerUse { get; set; }
        /// <summary>
        /// 记录员
        /// </summary>
        public string Record { get; set; }
        /// <summary>
        /// 客户编号
        /// </summary>
        public string CustoNo { get; set; }
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
