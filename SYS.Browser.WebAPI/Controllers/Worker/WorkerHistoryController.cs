using System.Collections.Generic;
using SYS.Core;
using SYS.Application;
using System.Web.Http;

namespace SYS.Browser.WebAPI.Controllers
{
    /// <summary>
    /// 员工履历控制器
    /// </summary>
    public class WorkerHistoryController: ApiController
    {
        /// <summary>
        /// 添加工作履历
        /// </summary>
        /// <param name="workerHistory"></param>
        /// <param name="wid"></param>
        /// <returns></returns>
        public int AddHistoryByWorkerId(WorkerHistory workerHistory, string wid)
        {
            return WorkerHistoryService.AddHistoryByWorkerId(workerHistory, wid);
        }

        /// <summary>
        /// 根据员工编号查询履历信息
        /// </summary>
        /// <param name="wid"></param>
        /// <returns></returns>
        public List<WorkerHistory> SelectHistoryByWorkerId(string wid)
        {
            return WorkerHistoryService.SelectHistoryByWorkerId(wid);
        }
    }
}
