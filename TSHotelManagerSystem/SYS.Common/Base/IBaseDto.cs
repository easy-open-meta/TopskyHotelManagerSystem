using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Common
{
    /// <summary>
    /// 统一结果回传
    /// </summary>
    public interface IBaseDto
    {
        /// <summary>
        /// 状态码
        /// </summary>
        StatusCode StatusCode { get; set; }

        /// <summary>
        /// 回传信息
        /// </summary>
        string StatusMsg { get; set; }

        /// <summary>
        /// 操作账户
        /// </summary>
        string OperationAccount { get; set; }
    }
}
