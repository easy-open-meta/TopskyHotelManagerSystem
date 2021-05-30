using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Core
{
    /// <summary>
    /// 模块实体
    /// </summary>
    [SqlSugar.SugarTable("module")]
    public class Module
    {
        /// <summary>
        /// 模块ID
        /// </summary>
        public int module_id { get; set; }

        /// <summary>
        /// 模块名称
        /// </summary>
        public string module_name { get; set; }

        /// <summary>
        /// 模块描述
        /// </summary>
        public string module_desc { get; set; }

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
        public DateTime datains_time { get; set; }

        /// <summary>
        /// 资料更新人
        /// </summary>
        public string datachg_usr { get; set; }

        /// <summary>
        /// 资料更新时间
        /// </summary>
        public DateTime datachg_time { get; set; }
    }
}
