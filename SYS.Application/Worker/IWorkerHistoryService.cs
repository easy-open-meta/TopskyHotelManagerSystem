using SYS.Core;
using System.Collections.Generic;

namespace SYS.Application
{
    /// <summary>
    /// 员工履历信息接口
    /// </summary>
    public  interface IWorkerHistoryService
    {
        /// <summary>
        /// 根据工号添加员工履历
        /// </summary>
        /// <param name="workerHistory"></param>
        /// <returns></returns>
        bool AddHistoryByWorkerId(WorkerHistory workerHistory);

        /// <summary>
        /// 根据工号查询履历信息
        /// </summary>
        /// <param name="wid"></param>
        /// <returns></returns>
        List<WorkerHistory> SelectHistoryByWorkerId(string wid);
    }
}