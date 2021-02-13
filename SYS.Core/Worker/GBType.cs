using System;

namespace SYS.Application
{
    /// <summary>
    /// 奖惩类型实体类
    /// </summary>
    public class GBType
    {
        /// <summary>
        /// 奖惩编号
        /// </summary>
        public int GBTypeId { get; set; }

        /// <summary>
        /// 奖惩名称
        /// </summary>
        public string GBName { get; set; }

        /// <summary>
        /// 删除标记
        /// </summary>
        public int delete_mk { get; set; }

        /// <summary>
        /// 资料新增人
        /// </summary>
        public string datains_usr { get; set; }

        /// <summary>
        /// 资料新增日期
        /// </summary>
        public DateTime? datains_date { get; set; }

        /// <summary>
        /// 资料更新人
        /// </summary>
        public string datachg_usr { get; set; }

        /// <summary>
        /// 资料更新日期
        /// </summary>
        public DateTime? datachg_date { get; set; }
    }
}