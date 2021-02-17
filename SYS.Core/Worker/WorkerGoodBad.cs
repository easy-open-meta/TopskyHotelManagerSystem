using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Core
{
    /// <summary>
    /// 员工奖罚
    /// </summary>
    public class WorkerGoodBad
    {
        /// <summary>
        /// 工号
        /// </summary>
        public string WorkNo { get; set; }
        /// <summary>
        /// 奖惩信息
        /// </summary>
        public string GBInfo { get; set; }
        /// <summary>
        /// 奖惩类型
        /// </summary>
        public int GBType { get; set; }
        /// <summary>
        /// 奖惩操作人
        /// </summary>
        public string GBOperation { get; set; }
        /// <summary>
        /// 奖惩操作人
        /// </summary>
        [SqlSugar.SugarColumn(IsIgnore = true)]
        public string OperationName { get; set; }
        /// <summary>
        /// 奖惩时间
        /// </summary>
        public DateTime GBTime { get; set; }
        /// <summary>
        /// 类型名称
        /// </summary>
        [SqlSugar.SugarColumn(IsIgnore = true)]
        public string TypeName { get; set; }
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
