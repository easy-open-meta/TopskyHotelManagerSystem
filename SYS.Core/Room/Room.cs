using System;

namespace SYS.Core
{
    public class Room
    {
        public string RoomNo { get; set; }
        public int RoomType { get; set; }
        public string CustoNo { get; set; }
<<<<<<< HEAD
        public DateTime CheckTime { get; set; }
        public DateTime CheckOutTime { get; set; }
        public int RoomStateId { get; set; }
=======
        /// <summary>
        /// 最后一次入住时间
        /// </summary>
        public DateTime? CheckTime { get; set; }
        /// <summary>
        /// 最后一次退房时间
        /// </summary>
        public DateTime? CheckOutTime { get; set; }
        /// <summary>
        /// 房间状态ID
        /// </summary>
        public int RoomStateId { get; set; }
        /// <summary>
        /// 房间状态
        /// </summary>
        [SqlSugar.SugarColumn(IsIgnore = true)]
<<<<<<< HEAD
>>>>>>> InitProject_v1.4.8_happy_new_year
=======
>>>>>>> master
        public string RoomState { get; set; }
        public decimal RoomMoney { get; set; }
        public string PersonNum { get; set; }
        public string RoomPosition { get; set; }
<<<<<<< HEAD
=======
        /// <summary>
        /// 客户类型名称
        /// </summary>
        [SqlSugar.SugarColumn(IsIgnore = true)]
<<<<<<< HEAD
>>>>>>> InitProject_v1.4.8_happy_new_year
=======
>>>>>>> master
        public string typeName { get; set; }
        /// <summary>
        /// 房间名称
        /// </summary>
        [SqlSugar.SugarColumn(IsIgnore = true)]
        public string RoomName { get; set; }
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
