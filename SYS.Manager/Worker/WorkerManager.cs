using System.Collections.Generic;
using SYS.Core;
using SYS.Application;

namespace SYS.Manager
{
    public class WorkerManager
    {
        #region 修改员工信息
        /// <summary>
        /// 修改员工信息
        /// </summary>
        /// <param name="worker"></param>
        /// <returns></returns>
        public static int UpdateWorker(Worker worker)
        {
            return WorkerService.UpdateWorker(worker);
        }
        #endregion

        #region 添加员工信息
        /// <summary>
        /// 添加员工信息
        /// </summary>
        /// <param name="worker"></param>
        /// <returns></returns>
        public static int AddWorker(Worker worker)
        {
            return WorkerService.AddWorker(worker);
        }
        #endregion

        #region 获取所有工作人员信息
        /// <summary>
        /// 获取所有工作人员信息
        /// </summary>
        /// <returns></returns>
        public List<Worker> SelectWorkerAll()
        {
            return WorkerService.SelectWorkerAll();
        }
        #endregion

        #region 根据登录名称查询员工信息
        /// <summary>
        /// 根据登录名称查询员工信息
        /// </summary>
        /// <param name="workerId"></param>
        /// <returns></returns>
        public static Worker SelectWorkerInfoByWorkerId(string workerId)
        {
            return WorkerService.SelectWorkerInfoByWorkerId(workerId);
        }
        #endregion

        #region 根据登录名称、密码查询员工信息
        /// <summary>
        /// 根据登录名称、密码查询员工信息
        /// </summary>
        /// <param name="id"></param>
        /// 登录名称
        /// <param name="pwd"></param>
        /// 登录密码
        /// <returns></returns>
        public static Worker SelectWorkerInfoByWorkerIdAndWorkerPwd(string id, string pwd)
        {
            return WorkerService.SelectWorkerInfoByWorkerIdAndWorkerPwd(id, pwd);
        }
        #endregion
    }
}
