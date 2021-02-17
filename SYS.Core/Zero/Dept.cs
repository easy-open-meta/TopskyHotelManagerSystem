using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Core
{
    /// <summary>
    /// 部门表
    /// </summary>
    public class Dept
    {
        /// <summary>
        /// 部门编号
        /// </summary>  
        public string dept_no { get; set; }
        /// <summary>
        /// 部门名称
        /// </summary>
        public string dept_name { get; set; }
        /// <summary>
        /// 部门描述
        /// </summary>
        public string dept_desc { get; set; }
        /// <summary>
        /// 创建时间(部门)
        /// </summary>
        public DateTime dept_date { get; set; }
        /// <summary>
        /// 部门主管
        /// </summary>
        public string dept_leader { get; set; }
        /// <summary>
        /// 部门主管
        /// </summary>
        [SqlSugar.SugarColumn(IsIgnore = true)]
        public string leader_name { get; set; }
        /// <summary>
        /// 上级部门
        /// </summary>
        public string dept_parent { get; set; }
        /// <summary>
        /// 上级部门
        /// </summary>
        [SqlSugar.SugarColumn(IsIgnore = true)]
        public string parent_name { get; set; }
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
