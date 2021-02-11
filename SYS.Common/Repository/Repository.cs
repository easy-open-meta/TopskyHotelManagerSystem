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
<<<<<<< HEAD
                    ConnectionString = 
=======
                    ConnectionString = ""
>>>>>>> master
                });

                base.Context.Aop.OnLogExecuting = (s, p) =>
                {
                    Console.WriteLine(s);
                };
            }
        }

    }
}
