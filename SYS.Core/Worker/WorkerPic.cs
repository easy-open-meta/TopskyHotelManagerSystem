using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Core
{
    /// <summary>
    /// 员工照片
    /// </summary>
    [Table("workerpic")]
    public class WorkerPic
    {
        /// <summary>
        /// 工号
        /// </summary>
        public string WorkerId { get; set; }

        /// <summary>
        /// 照片路径
        /// </summary>
        public string Pic { get; set; }
    }
}
