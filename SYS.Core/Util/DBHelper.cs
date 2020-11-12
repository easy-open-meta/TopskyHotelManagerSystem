using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;

namespace SYS.Core
{
    public class DBHelper
    {
        private static string conStr = ConfigurationManager.AppSettings["MySqlStr"];
        private static MySqlConnection con = null;

        public static MySqlConnection GetConnection()
        {
            if (con == null || con.ConnectionString == "")
            {
                con = new MySqlConnection(conStr);
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
           params MySqlParameter[] para)          //SQL参数列表
        {
            int n = 0;
            MySqlConnection con = GetConnection();
            Opencon();
            MySqlCommand com = new MySqlCommand(sql, con);
            com.CommandType = type;
            com.Parameters.AddRange(para);
            n = com.ExecuteNonQuery();
            Closecon();
            return n;
        }



        public static MySqlDataReader ExecuteReader(string sql)
        {
            MySqlConnection con = GetConnection();
            Opencon();
            MySqlCommand com = new MySqlCommand(sql, con);
            MySqlDataReader dr = com.ExecuteReader();
            return dr;
        }

        public static object ExecuteScalar(string sql,
            CommandType type = CommandType.Text,
            params MySqlParameter[] para)
        {
            object obj = 0;
            MySqlConnection con = GetConnection();
            Opencon();
            MySqlCommand com = new MySqlCommand(sql, con);
            com.CommandType = type;
            com.Parameters.AddRange(para);
            obj = com.ExecuteScalar();
            Closecon();
            return obj;
        }


    }
}
