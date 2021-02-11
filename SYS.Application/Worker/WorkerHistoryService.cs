using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SYS.Common;
using SYS.Core;

namespace SYS.Application
{
    /// <summary>
    /// 员工履历接口实现类
    /// </summary>
    public class WorkerHistoryService:Repository<WorkerHistory>, IWorkerHistoryService
    {
        /// <summary>
        /// 根据工号添加员工履历
        /// </summary>
        /// <param name="workerHistory"></param>
        /// <returns></returns>
        public bool AddHistoryByWorkerId(WorkerHistory workerHistory)
        {
            return base.Insert(workerHistory);
        }

        /// <summary>
        /// 根据工号查询履历信息
        /// </summary>
        /// <param name="wid"></param>
        /// <returns></returns>
        public List<WorkerHistory> SelectHistoryByWorkerId(string wid)
        {
            List<WorkerHistory> why = new List<WorkerHistory>();
            why = base.GetList(a => a.delete_mk != 1 && a.WorkerId == wid);
            return why;
        }
    }
}
