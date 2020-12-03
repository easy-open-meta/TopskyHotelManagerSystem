using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Common
{
    public class BaseDto : IBaseDto
    {
        public enum Code : int
        {
            SQLE_202_操作异常 = 202,
            SQLE_200_操作成功 = 200,
            SQLE_400_系统异常_请联系系统管理员 = 400

        }
        /// <summary>
        /// 状态码
        /// </summary>
        public int StatusCode { get; set; }

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
