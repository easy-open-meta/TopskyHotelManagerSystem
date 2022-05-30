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
        [SqlSugar.SugarColumn(IsIdentity = true,ColumnName = "module_id")]
        public int module_id { get; set; }
        /// <summary>
        /// 管理员账号
        /// </summary>
        [SqlSugar.SugarColumn(ColumnName = "admin_account")]
        public string admin_account { get; set; }
        /// <summary>
        /// 模块名称
        /// </summary>
        [SqlSugar.SugarColumn(ColumnName = "module_name")]
        public string module_name { get; set; }
        /// <summary>
        /// 是否开启
        /// </summary>
        [SqlSugar.SugarColumn(ColumnName = "module_enable")]
        public int module_enable { get; set; }
    }
}
