using System;

namespace SYS.Core
{
    /// <summary>
    /// 房间状态
    /// </summary>
    public class RoomState
    {
        /// <summary>
        /// 房间状态编号
        /// </summary>
        public int RoomStateId { get; set; }
        /// <summary>
        /// 房间状态
        /// </summary>
        [SqlSugar.SugarColumn(ColumnName = "RoomState")]
        public string RoomStateName { get; set; }
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
