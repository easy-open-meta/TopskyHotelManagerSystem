using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Common
{
    public class BaseDto : IBaseDto
    {
        /// <summary>
        /// 状态码
        /// </summary>
        public StatusCode StatusCode { get; set; }

        /// <summary>
        /// 状态信息
        /// </summary>
        public string StatusMsg { get; set; }

        /// <summary>
        /// 操作账户
        /// </summary>
        public string OperationAccount { get; set; }
    }
}
