using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Core
{
    /// <summary>
    /// 管理员类型
    /// </summary>
    public class AdminType
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 管理员类型
        /// </summary>
        public string type_id { get; set; }

        /// <summary>
        /// 类型名称
        /// </summary>
        public string type_name { get; set; }

        /// <summary>
        /// 删除标记
        /// </summary>
        public int delete_mk { get; set; }

        /// <summary>
        /// 新增人
        /// </summary>
        public string datains_usr { get; set; }
        /// <summary>
        /// 新增时间
        /// </summary>
        public DateTime datains_date { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        public string datachg_usr { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime datachg_date { get; set; }
    }
}
