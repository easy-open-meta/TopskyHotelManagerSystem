using System;

namespace SYS.Core
{
    /// <summary>
    /// 操作日志
    /// </summary>
    public class OperationLog
    {
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OperationTime { get; set; }
        /// <summary>
        /// 操作信息
        /// </summary>
        public string Operationlog { get; set; }
        /// <summary>
        /// 操作账号
        /// </summary>
        public string OperationAccount { get; set; }
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
