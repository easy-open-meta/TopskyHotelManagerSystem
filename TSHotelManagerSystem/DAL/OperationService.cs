using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSHotelManagerSystem.Models;

namespace TSHotelManagerSystem.DAL
{
   public class OperationService
    {
        public static int InsertOperationLog(Operation opr)
        {
            int n = 0;
            string sql = "insert OPERATIONLOG(OperationTime,OperationLog,OperationAccount) values(@OperationTime," +
                "@OperationLog,@OperationAccount)";
            n = DBHelper.ExecuteNonQuery(sql, CommandType.Text,
                new SqlParameter[] {
                    new SqlParameter("@OperationTime",opr.OperationTime),
                    new SqlParameter("@OperationLog",opr.Operationlog),
                    new SqlParameter("@OperationAccount",opr.OperationAccount),
                });
            return n;
        }
    }
}
