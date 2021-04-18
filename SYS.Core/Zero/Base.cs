using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Core
{
    [SqlSugar.SugarTable("base")]
    public class Base
    {
        /// <summary>
        /// 地址编号
        /// </summary>
        public int url_no { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string url_addr { get; set; }
    }
}
