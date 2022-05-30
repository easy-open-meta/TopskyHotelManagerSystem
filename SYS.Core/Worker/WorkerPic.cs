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
    [SqlSugar.SugarTable("workerpic")]
    public class WorkerPic
    {
        /// <summary>
        /// 自增长流水号
        /// </summary>
        [SqlSugar.SugarColumn(IsIdentity = true,ColumnName = "Id",IsPrimaryKey = true)]
        public int Id { get; set; }
        /// <summary>
        /// 工号
        /// </summary>
        [SqlSugar.SugarColumn(ColumnName = "WorkerId")]
        public string WorkerId { get; set; }

        /// <summary>
        /// 照片路径
        /// </summary>
        [SqlSugar.SugarColumn(ColumnName = "Pic")]
        public string Pic { get; set; }
    }
}
