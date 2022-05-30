using SqlSugar;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Common
{
    public class MysqlRepository<T> : SimpleClient<T> where T : class, new()
    {
        public MysqlRepository(ISqlSugarClient context = null) : base(context)//注意这里要有默认值等于null
        {
            if (context == null)
            {
                base.Context = new SqlSugarClient(new ConnectionConfig()
                {
                    DbType = SqlSugar.DbType.MySql,
                    InitKeyType = InitKeyType.Attribute,
                    IsAutoCloseConnection = true,
                    ConnectionString = HttpHelper.mysqlString
                });

                base.Context.Aop.OnError = (ex) =>
                {
                    RecordHelper.Record(ex.ToString(), 3);
                };
            }
        }

    }
}
