using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using MySql.Data.MySqlClient;
using SYS.Common;
using SYS.Core;

namespace SYS.Application
{
    /// <summary>
    /// 操作日志数据访问层
    /// </summary>
    public class OperationlogService:Repository<OperationLog>, IOperationlogService
    {
        /// <summary>
        /// 添加操作日志
        /// </summary>
        /// <param name="opr"></param>
        /// <returns></returns>
        public bool InsertOperationLog(OperationLog opr)
        {
            return base.Insert(opr);
        }

        /// <summary>
        /// 查询所有操作日志
        /// </summary>
        /// <returns></returns>
        public List<OperationLog> SelectOperationlogAll()
        {
            List<OperationLog> operationLogs = new List<OperationLog>();
            operationLogs = base.GetList(a => a.delete_mk != 1).OrderBy(a => a.OperationTime).ToList();
            return operationLogs;
        }

        
    }
}
