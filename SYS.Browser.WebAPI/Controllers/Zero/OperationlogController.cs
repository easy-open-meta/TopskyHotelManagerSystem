using System.Collections.Generic;
using SYS.Core;
using SYS.Application;
using System.Web.Http;

namespace SYS.Browser.WebAPI.Controllers
{
    /// <summary>
    /// 操作日志控制器
    /// </summary>
    public class OperationlogController : ApiController
    {
        /// <summary>
        /// 添加操作日志
        /// </summary>
        /// <param name="opr"></param>
        /// <returns></returns>
        [HttpPost]
        public int InsertOperationLog([FromBody]OperationLog opr)
        {
            return OperationlogService.InsertOperationLog(opr);
        }

        /// <summary>
        /// 查询所有操作日志
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<OperationLog> SelectOperationlogAll()
        {
            return OperationlogService.SelectOperationlogAll();
        }
    }
}