using jvncorelib_fr.EncryptorLib;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Common
{
    public class Repository<T> : SimpleClient<T> where T : class, new()
    {
        public Repository(ISqlSugarClient context = null) : base(context)//注意这里要有默认值等于null
        {
            /// <summary>
            /// 实例化信息加密插件
            /// </summary>
            EncryptLib encryptLib = new EncryptLib();

            if (context == null)
            {
                base.Context = new SqlSugarClient(new ConnectionConfig()
                {
                    DbType = SqlSugar.DbType.PostgreSQL,
                    InitKeyType = InitKeyType.Attribute,
                    IsAutoCloseConnection = true,
                    MoreSettings = new ConnMoreSettings()
                    {
                        PgSqlIsAutoToLower = false //数据库存在大写字段的 ，需要把这个设为false ，并且实体和字段名称要一样
                    },
                    ConnectionString = encryptLib.Decryption(HttpHelper.pgsqlString)
                });

                base.Context.Aop.OnError = (ex) =>
                {
                    RecordHelper.Record(ex.ToString(), 3);
                };
            }
        }

    }
}
