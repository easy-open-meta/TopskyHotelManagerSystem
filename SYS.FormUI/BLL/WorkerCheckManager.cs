using System.Collections.Generic;
using SYS.Core;
using SYS.Application;

namespace SYS.FormUI.BLL
{
    public class WorkerCheckManager
    {
        /// <summary>
        /// 根据员工编号查询其所有的打卡记录
        /// </summary>
        /// <param name="wid"></param>
        /// <returns></returns>
        public static List<WorkerCheck> SelectCheckInfoByWorkerNo(string wid)
        {
            return WorkerCheckService.SelectCheckInfoByWorkerNo(wid);
        }

        /// <summary>
        /// 查询员工签到天数
        /// </summary>
        /// <param name="wkn"></param>
        /// <returns></returns>
        public static object SelectWorkerCheckDaySumByWorkerNo(string wkn)
        {
            return WorkerCheckService.SelectWorkerCheckDaySumByWorkerNo(wkn);
        }


        /// <summary>
        /// 查询今天员工是否已签到
        /// </summary>
        /// <param name="wkn"></param>
        /// <returns></returns>
        public static object SelectToDayCheckInfoByWorkerNo(string wkn)
        {
            return WorkerCheckService.SelectToDayCheckInfoByWorkerNo(wkn);
        }
        /// <summary>
        /// 添加员工打卡数据
        /// </summary>
        /// <param name="workerCheck"></param>
        /// <returns></returns>
        public static int AddCheckInfo(WorkerCheck workerCheck)
        {
            return WorkerCheckService.AddCheckInfo(workerCheck);
        }
    }
}
