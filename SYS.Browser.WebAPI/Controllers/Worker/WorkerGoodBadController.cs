using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SYS.Core;
using SYS.Application;
using System.Web.Http;

namespace SYS.Browser.WebAPI.Controllers
{
    /// <summary>
    /// 员工奖惩信息控制器
    /// </summary>
    public class WorkerGoodBadController:ApiController
    {
        /// <summary>
        /// 添加奖惩信息
        /// </summary>
        /// <param name="goodBad"></param>
        /// <returns></returns>
        [HttpPost]
        public int AddGoodBad([FromBody]WorkerGoodBad goodBad)
        {
            return WorkerGoodBadService.AddGoodBad(goodBad);
        }

        /// <summary>
        /// 根据员工编号查询奖惩信息
        /// </summary>
        /// <param name="wn"></param>
        /// <returns></returns>
        [HttpGet]
        public List<WorkerGoodBad> SelectAllGoodBadByWorkNo([FromUri]string wn)
        {
            return WorkerGoodBadService.SelectAllGoodBadByWorkNo(wn); 
        }
    }
}
