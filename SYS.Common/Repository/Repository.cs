using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Common
{
    public class Repository<T> : SimpleClient<T> where T : class, new()
    {
        public Repository(ISqlSugarClient context = null) : base(context)//注意这里要有默认值等于null
        {
            if (context == null)
            {
                base.Context = new SqlSugarClient(new ConnectionConfig()
                {
                    DbType = SqlSugar.DbType.MySql,
                    InitKeyType = InitKeyType.Attribute,
                    IsAutoCloseConnection = true,
                    ConnectionString = "Server=134.175.239.108;Database=tshoteldb;Uid=root;Pwd=yjj0720.;"
                });

                base.Context.Aop.OnLogExecuting = (s, p) =>
                {
                    Console.WriteLine(s);
                };
            }
        }

    }
}
