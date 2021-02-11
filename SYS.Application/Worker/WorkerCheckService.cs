using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SYS.Common;
using SYS.Core;

namespace SYS.Application
{
    /// <summary>
    /// 员工打卡接口实现类
    /// </summary>
    public class WorkerCheckService:Repository<WorkerCheck>, IWorkerCheckService
    {
        /// <summary>
        /// 根据员工编号查询其所有的打卡记录
        /// </summary>
        /// <param name="wid"></param>
        /// <returns></returns>
        public List<WorkerCheck> SelectCheckInfoByWorkerNo(string wid)
        {
            List<WorkerCheck> workerChecks = new List<WorkerCheck>();
            workerChecks = base.GetList(a => a.WorkerNo == wid && a.delete_mk != 1);
            workerChecks.ForEach(source =>
            {
                source.CheckStateNm = source.CheckState == 0 ? "打卡成功" : "打卡失败";
            });
            return workerChecks;
        }


        /// <summary>
        /// 查询员工签到天数
        /// </summary>
        /// <param name="wkn"></param>
        /// <returns></returns>
        public object SelectWorkerCheckDaySumByWorkerNo(string wkn)
        {
            return base.GetList(a => a.WorkerNo == wkn && a.delete_mk != 1).Count;
        }


        /// <summary>
        /// 查询今天员工是否已签到
        /// </summary>
        /// <param name="wkn"></param>
        /// <returns></returns>
        public object SelectToDayCheckInfoByWorkerNo(string wkn)
        {
            //string sql = "select Count(*) from WORKERCHECK where WorkerNo = '"+wkn+ "' and DATEDIFF(CURRENT_DATE(),workercheck.CheckTime)";
            return base.GetList(a => a.WorkerNo == wkn && a.delete_mk != 1 && a.CheckTime >= DateTime.Now).Count;
        }

        /// <summary>
        /// 添加员工打卡数据
        /// </summary>
        /// <param name="workerCheck"></param>
        /// <returns></returns>
        public bool AddCheckInfo(WorkerCheck workerCheck)
        {
            return base.Insert(workerCheck);
        }
    }
}
