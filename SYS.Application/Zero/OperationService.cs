using System.Data;
using MySql.Data.MySqlClient;
using SYS.Core;

namespace SYS.Application
{
    public class OperationService
    {
        public static int InsertOperationLog(Operation opr)
        {
            int n = 0;
            string sql = "insert OPERATIONLOG(OperationTime,OperationLog,OperationAccount) values(@OperationTime," +
                "@OperationLog,@OperationAccount)";
            n = DBHelper.ExecuteNonQuery(sql, CommandType.Text,
                new MySqlParameter[] {
                    new MySqlParameter("@OperationTime",opr.OperationTime),
                    new MySqlParameter("@OperationLog",opr.Operationlog),
                    new MySqlParameter("@OperationAccount",opr.OperationAccount),
                });
            return n;
        }
    }
}
