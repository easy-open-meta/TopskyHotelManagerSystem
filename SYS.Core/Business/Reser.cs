using System;

namespace SYS.Core
{
    /// <summary>
    /// 预约列表
    /// </summary>
    public class Reser
    {
        public string ReserId { get; set; }
        public string CustoName { get; set; }
        public string CustoTel { get; set; }
        public string ReserWay { get; set; }
        public string ReserRoom { get; set; }
        public DateTime ReserDate { get; set; }
        public DateTime ReserEndDay { get; set; }
<<<<<<< HEAD
        public string ReserRemark { get; set; }
=======
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
<<<<<<< HEAD
        public DateTime datachg_date { get; set; }
>>>>>>> InitProject_v1.4.8_happy_new_year
=======
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
>>>>>>> master

    }
}
