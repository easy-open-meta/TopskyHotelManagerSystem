using System;

namespace SYS.Core
{
    /// <summary>
    /// 监管统计
    /// </summary>
    public class CheckInfo
    {
        /// <summary>
        /// 监管统计编号
        /// </summary>
        public string CheckNo { get; set; }
        /// <summary>
        /// 监管部门
        /// </summary>
        public string CheckClub { get; set; }
        /// <summary>
        /// 监管进度
        /// </summary>
        public string CheckProgres { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CheckCash { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int CheckScore { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CheckPerson { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CheckAdvice { get; set; }

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
