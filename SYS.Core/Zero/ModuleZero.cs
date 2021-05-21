using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Core
{

    /// <summary>
    /// 模块权限表
    /// </summary>
    [SqlSugar.SugarTable("module_zero")]
    public class ModuleZero
    {
        /// <summary>
        /// 模块ID
        /// </summary>
        public int module_id { get; set; }
        /// <summary>
        /// 管理员账号
        /// </summary>
        public string admin_account { get; set; }
        /// <summary>
        /// 模块名称
        /// </summary>
        public string module_name { get; set; }
        /// <summary>
        /// 是否开启
        /// </summary>
        public int module_enable { get; set; }
    }
}
