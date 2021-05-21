using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SYS.Core;

namespace SYS.Application
{
    /// <summary>
    /// 日志记录助手
    /// </summary>
    public static class RecordHelper
    {
        /// <summary>
        /// 记录信息集合
        /// </summary>
        /// <param name="OperationLog"></param>
        /// <param name="level"></param>
        public static void Record(string OperationLog, int level)
        {
            var logDetail = new OperationLog
            {
                OperationTime = DateTime.Now,
                Operationlog = OperationLog,
                OperationAccount = LoginInfo.WorkerNo == null ? AdminInfo.Account : LoginInfo.WorkerNo,
                OperationLevel = level == 1 ? RecordLevel.Normal : level == 2 ? RecordLevel.Warning : RecordLevel.Danger,
                delete_mk = 0,
                datains_usr = LoginInfo.WorkerNo == null ? AdminInfo.Account : LoginInfo.WorkerNo,
                datains_date = DateTime.Now
            };
            new OperationlogService().InsertOperationLog(logDetail);
        }
    }
}
