using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace SYS.Common
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
                LogContent = OperationLog,
                OperationAccount = LoginInfo.WorkerNo + AdminInfo.Account,
                OperationLevel = level == 1 ? RecordLevel.Normal : level == 2 ? RecordLevel.Warning : RecordLevel.Danger,
                SoftwareVersion = AdminInfo.SoftwareVersion + LoginInfo.SoftwareVersion,
                delete_mk = 0,
                datains_usr = AdminInfo.Account + LoginInfo.WorkerNo,
                datains_date = DateTime.Now
            };
            new OperationlogService().InsertOperationLog(logDetail);
        }

    }
}
