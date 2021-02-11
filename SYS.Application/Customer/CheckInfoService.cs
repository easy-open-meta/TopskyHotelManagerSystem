using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using SYS.Common;
using SYS.Core;

namespace SYS.Application
{
    /// <summary>
    /// 监管统计接口实现类
    /// </summary>
    public class CheckInfoService:Repository<CheckInfo>, ICheckInfoService
    {
        /// <summary>
        /// 查询所有监管统计信息
        /// </summary>
        /// <returns></returns>
        public List<CheckInfo> SelectCheckInfoAll()
        {
            List<CheckInfo> cif = new List<CheckInfo>();
            cif = base.GetList(a => a.delete_mk != 1);
            return cif;
        }
    }
}
