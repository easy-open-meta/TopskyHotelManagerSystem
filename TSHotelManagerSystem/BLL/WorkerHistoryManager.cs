using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSHotelManagerSystem.DAL;
using TSHotelManagerSystem.Models;

namespace TSHotelManagerSystem.BLL
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
