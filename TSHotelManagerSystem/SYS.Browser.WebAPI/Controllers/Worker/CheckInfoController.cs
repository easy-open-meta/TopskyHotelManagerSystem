using System.Collections.Generic;
using SYS.Core;
using SYS.Application;
using System.Web.Http;

namespace SYS.Browser.WebAPI.Controllers
{
    /// <summary>
    /// 部门监管控制器
    /// </summary>
    public class CheckInfoController : ApiController
    {
        /// <summary>
        /// 查询所有部门监管信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<CheckInfo> SelectCheckInfoAll()
        {

            return new CheckInfoService().SelectCheckInfoAll();
        }
    }
}
