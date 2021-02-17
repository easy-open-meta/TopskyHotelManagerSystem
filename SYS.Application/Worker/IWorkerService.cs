using SYS.Core;
using System.Collections.Generic;

namespace SYS.Application
{
    /// <summary>
    /// 员工信息接口
    /// </summary>
    public interface IWorkerService
    {
        #region 修改员工信息
        /// <summary>
        /// 修改员工信息
        /// </summary>
        /// <param name="worker"></param>
        /// <returns></returns>
        bool UpdateWorker(Worker worker);
        #endregion

        /// <summary>
        /// 更新员工职位和部门
        /// </summary>
        /// <param name="worker"></param>
        /// <returns></returns>

        bool UpdateWorkerPositionAndClub(Worker worker);

        #region 添加员工信息
        /// <summary>
        /// 添加员工信息
        /// </summary>
        /// <param name="worker"></param>
        /// <returns></returns>
        bool AddWorker(Worker worker);
        #endregion

        #region 获取所有工作人员信息
        /// <summary>
        /// 获取所有工作人员信息
        /// </summary>
        /// <returns></returns>
        List<Worker> SelectWorkerAll();
        #endregion

        #region 根据登录名称查询员工信息
        /// <summary>
        /// 根据登录名称查询员工信息
        /// </summary>
        /// <param name="workerId"></param>
        /// <returns></returns>
        Worker SelectWorkerInfoByWorkerId(string workerId);
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
        Worker SelectWorkerInfoByWorkerIdAndWorkerPwd(string id, string pwd);
        #endregion


        /// <summary>
        /// 根据员工编号和密码修改密码
        /// </summary>
        /// <param name="workId"></param>
        /// <param name="workPwd"></param>
        /// <returns></returns>
        bool UpdWorkerPwdByWorkNo(string workId, string workPwd);
    }
}