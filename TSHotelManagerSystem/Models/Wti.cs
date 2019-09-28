using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSHotelManagerSystem.Models
{
    public class Wti
    {
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

       
    }
}
