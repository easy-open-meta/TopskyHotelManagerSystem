using System.Collections.Generic;
using SYS.Core;
using SYS.Application;

namespace SYS.FormUI.BLL
{
    public class WorkerHistoryManager
    {
        public static int AddHistoryByWorkerId(WorkerHistory workerHistory, string wid)
        {
            return WorkerHistoryService.AddHistoryByWorkerId(workerHistory, wid);
        }

        public static List<WorkerHistory> SelectHistoryByWorkerId(string wid)
        {
            return WorkerHistoryService.SelectHistoryByWorkerId(wid);
        }
    }
}
