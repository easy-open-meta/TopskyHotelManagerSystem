using System;

namespace SYS.Core
{
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

    }
}
