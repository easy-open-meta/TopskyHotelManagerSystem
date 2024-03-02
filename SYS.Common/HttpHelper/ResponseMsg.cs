using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Common
{
    public class ResponseMsg
    {
        /// <summary>
        /// 状态码
        /// </summary>
        public int statusCode { get; set; }
        /// <summary>
        /// 错误信息
        /// </summary>
        public string message { get; set; }
    }
}
