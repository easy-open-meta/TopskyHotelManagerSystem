using System;

namespace SYS.Core
{
    /// <summary>
    /// 房间实体类
    /// </summary>
    public class Room
    {
        /// <summary>
        /// 房间编号
        /// </summary>
        public string RoomNo { get; set; }
        /// <summary>
        /// 房间类型
        /// </summary>
        public int RoomType { get; set; }
        /// <summary>
        /// 客户编号
        /// </summary>
        public string CustoNo { get; set; }
        /// <summary>
        /// 最后一次入住时间
        /// </summary>
        public DateTime CheckTime { get; set; }
        /// <summary>
        /// 最后一次退房时间
        /// </summary>
        public DateTime CheckOutTime { get; set; }
        /// <summary>
        /// 房间状态ID
        /// </summary>
        public int RoomStateId { get; set; }
        /// <summary>
        /// 房间状态
        /// </summary>
        public string RoomState { get; set; }
        /// <summary>
        /// 房间单价
        /// </summary>
        public decimal RoomMoney { get; set; }
        /// <summary>
        /// 房间位置
        /// </summary>
        public string RoomPosition { get; set; }
        /// <summary>
        /// 客户类型名称
        /// </summary>
        public string typeName { get; set; }

    }
}
