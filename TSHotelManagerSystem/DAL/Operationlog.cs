using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TSHotelManagerSystem.Models;

namespace TSHotelManagerSystem.DAL
{
    public class Operationlog
    {
        public static List<OperationLog> SelectOperationlogAll()
        {
            List<OperationLog> custos = new List<OperationLog>();
            string sql = "select * from operationlog order by OperationTime desc";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
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
