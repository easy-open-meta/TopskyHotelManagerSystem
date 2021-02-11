using SYS.Application;
using SYS.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SYS.Browser.WebAPI.Controllers
{
    /// <summary>
    /// 财务管理控制器(后台)
    /// </summary>
    public class CashController : ApiController
    {
        /// <summary>
        /// 查询所有资产信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Cash> SelectCashInfoAll()
        {
            return new CashService().SelectCashInfoAll();
        }

        /// <summary>
        /// 添加资产信息
        /// </summary>
        /// <param name="cash"></param>
        /// <returns></returns>
        [HttpPost]
        public object AddCashInfo([FromBody]Cash cash)
        {
            return new CashService().AddCashInfo(cash);
        }
    }
}
