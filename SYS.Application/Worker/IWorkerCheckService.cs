using SYS.Core;
using System.Collections.Generic;

namespace SYS.Application
{
    /// <summary>
    /// 员工打卡接口
    /// </summary>
    public interface IWorkerCheckService
    {
        /// <summary>
        /// 根据员工编号查询其所有的打卡记录
        /// </summary>
        /// <param name="wid"></param>
        /// <returns></returns>
        List<WorkerCheck> SelectCheckInfoByWorkerNo(string wid);


        /// <summary>
        /// 查询员工签到天数
        /// </summary>
        /// <param name="wkn"></param>
        /// <returns></returns>
        object SelectWorkerCheckDaySumByWorkerNo(string wkn);


        /// <summary>
        /// 查询今天员工是否已签到
        /// </summary>
        /// <param name="wkn"></param>
        /// <returns></returns>
        object SelectToDayCheckInfoByWorkerNo(string wkn);

        /// <summary>
        /// 添加员工打卡数据
        /// </summary>
        /// <param name="workerCheck"></param>
        /// <returns></returns>
        bool AddCheckInfo(WorkerCheck workerCheck);
    }
}