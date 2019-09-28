using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSHotelManagerSystem.DAL
{
    public class DBHelper
    {
        private static string conStr = ConfigurationManager.AppSettings["conSqlStr"];
        private static SqlConnection con = null;

        public static SqlConnection GetConnection()
        {
            if (con == null || con.ConnectionString == "")
            {
                con = new SqlConnection(conStr);
            }
            return con;
        }

        

        public static void Opencon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public static void Closecon()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        public static int ExecuteNonQuery(string sql, //SQL语句
           CommandType type = CommandType.Text,   //命令类型：SQL文本，存储过程，表
           params SqlParameter[] para)          //SQL参数列表
        {
            int n = 0;
            SqlConnection con = GetConnection();
            Opencon();
            SqlCommand com = new SqlCommand(sql, con);
            com.CommandType = type;
            com.Parameters.AddRange(para);
            n = com.ExecuteNonQuery();
            Closecon();
            return n;
        }

        

        public static SqlDataReader ExecuteReader(string sql)
        {
            SqlConnection con = GetConnection();
            Opencon();
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }
        public static object ExecuteScalar(string sql,
            CommandType type=CommandType.Text,
            params SqlParameter[] para)
        {
            object obj = 0;
            SqlConnection con = GetConnection();
            Opencon();
            SqlCommand com = new SqlCommand(sql, con);
            com.CommandType = type;
            com.Parameters.AddRange(para);
            obj = com.ExecuteScalar();
            Closecon();
            return obj;
        }
        
        
    }
}
