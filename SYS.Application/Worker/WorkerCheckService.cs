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
using System;
using System.Collections.Generic;
using System.Linq;
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
            var listCheckInfo = base.GetList(a => a.WorkerNo == wkn && a.delete_mk != 1);
            var count = listCheckInfo.Where(a => a.CheckTime.ToShortDateString() == DateTime.Now.ToShortDateString()).Count() > 0 ? 1:0;
            return count;
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
