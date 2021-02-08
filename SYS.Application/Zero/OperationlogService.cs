using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using SYS.Core;

namespace SYS.Application
{
    /// <summary>
    /// 操作日志数据访问层
    /// </summary>
    public class OperationlogService
    {
        /// <summary>
        /// 添加操作日志
        /// </summary>
        /// <param name="opr"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 查询所有操作日志
        /// </summary>
        /// <returns></returns>
        public static List<OperationLog> SelectOperationlogAll()
        {
            List<OperationLog> custos = new List<OperationLog>();
            string sql = "select * from operationlog order by OperationTime desc";
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                OperationLog cso = new OperationLog();
                cso.OperationTime = DateTime.Parse(dr["OperationTime"].ToString());
                cso.Operationlog = dr["Operationlog"].ToString();
                cso.OperationAccount = (string)dr["OperationAccount"];
                custos.Add(cso);
            }
            dr.Close();
            DBHelper.Closecon();
            return custos;
        }

        
    }
}
