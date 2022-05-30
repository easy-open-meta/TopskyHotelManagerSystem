/*
 * MIT License
 *Copyright (c) 2021 咖啡与网络(java-and-net)

 *Permission is hereby granted, free of charge, to any person obtaining a copy
 *of this software and associated documentation files (the "Software"), to deal
 *in the Software without restriction, including without limitation the rights
 *to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 *copies of the Software, and to permit persons to whom the Software is
 *furnished to do so, subject to the following conditions:

 *The above copyright notice and this permission notice shall be included in all
 *copies or substantial portions of the Software.

 *THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 *IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 *FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 *AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 *LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 *OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 *SOFTWARE.
 *
 */
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
        /// 员工账号禁/启用
        /// </summary>
        /// <param name="worker"></param>
        /// <returns></returns>
        bool ManagerWorkerAccount(Worker worker);

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
        /// <param name="worker"></param>
        /// <returns></returns>
        Worker SelectWorkerInfoByWorkerIdAndWorkerPwd(Worker worker);
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