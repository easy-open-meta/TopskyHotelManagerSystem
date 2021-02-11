using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SYS.Common;
using SYS.Core;

namespace SYS.Application
{
    /// <summary>
    /// 资产信息接口实现类
    /// </summary>
    public class CashService:Repository<Cash>, ICashService
    {
        /// <summary>
        /// 添加资产信息
        /// </summary>
        /// <param name="cash"></param>
        /// <returns></returns>
        public bool AddCashInfo(Cash cash)
        {
            return base.Insert(cash);
        }

        /// <summary>
        /// 查询资产信息
        /// </summary>
        /// <returns></returns>
        public List<Cash> SelectCashInfoAll()
        {
            List<Cash> cs = new List<Cash>();
            cs = base.GetList();
            return cs;
        }
    }
}
