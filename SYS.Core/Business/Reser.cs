using System;

namespace SYS.Core
{
    /// <summary>
    /// 预约列表
    /// </summary>
    public class Reser
    {
        /// <summary>
        /// 预约编号
        /// </summary>
        public string ReserId { get; set; }
        /// <summary>
        /// 客户名称
        /// </summary>
        public string CustoName { get; set; }
        /// <summary>
        /// 预约电话
        /// </summary>
        public string CustoTel { get; set; }
        /// <summary>
        /// 预约渠道
        /// </summary>
        public string ReserWay { get; set; }
        /// <summary>
        /// 预约房号
        /// </summary>
        public string ReserRoom { get; set; }
        /// <summary>
        /// 预约起始
        /// </summary>
        public DateTime ReserDate { get; set; }
        /// <summary>
        /// 预约止日
        /// </summary>
        public DateTime ReserEndDay { get; set; }
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
