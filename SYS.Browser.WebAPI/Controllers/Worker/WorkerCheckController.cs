using System.Collections.Generic;
using SYS.Core;
using SYS.Application;
using System.Web.Http;

namespace SYS.Browser.WebAPI.Controllers
{
    /// <summary>
    /// 员工打卡考勤控制器
    /// </summary>
    public class WorkerCheckController:ApiController
    {
        /// <summary>
        /// 根据员工编号查询其所有的打卡记录
        /// </summary>
        /// <param name="wid"></param>
        /// <returns></returns>
        [HttpGet]
        public List<WorkerCheck> SelectCheckInfoByWorkerNo([FromUri]string wid)
        {
            return WorkerCheckService.SelectCheckInfoByWorkerNo(wid);
        }

        /// <summary>
        /// 查询员工签到天数
        /// </summary>
        /// <param name="wkn"></param>
        /// <returns></returns>
        [HttpGet]
        public object SelectWorkerCheckDaySumByWorkerNo([FromUri]string wkn)
        {
            return WorkerCheckService.SelectWorkerCheckDaySumByWorkerNo(wkn);
        }


        /// <summary>
        /// 查询今天员工是否已签到
        /// </summary>
        /// <param name="wkn"></param>
        /// <returns></returns>
        [HttpPost]
        public object SelectToDayCheckInfoByWorkerNo([FromUri]string wkn)
        {
            return WorkerCheckService.SelectToDayCheckInfoByWorkerNo(wkn);
        }

        /// <summary>
        /// 添加员工打卡数据
        /// </summary>
        /// <param name="workerCheck"></param>
        /// <returns></returns>
        [HttpPost]
        public int AddCheckInfo([FromBody]WorkerCheck workerCheck)
        {
            return WorkerCheckService.AddCheckInfo(workerCheck);
        }
    }
}
