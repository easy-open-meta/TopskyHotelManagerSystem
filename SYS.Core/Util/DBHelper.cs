/*
 * MIT License
 *Copyright (c) 2021 咖啡与网络(java-and-net)

 *Permission is hereby granted, free of charge, to any person obtaining a copy
 *of this software and associated documentation files (the "Software"), to deal
 *in the Software without restriction, including without limitation the rights
 *to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 *copies of the Software, and to permit persons to whom the Software is
 *furnished to do so, subject to the following conditions:

 *The above copyright notice and this permission notice shall be included in all
 *copies or substantial portions of the Software.

 *THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 *IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 *FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 *AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 *LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 *OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 *SOFTWARE.
 *
 *模块说明：数据库配置类
 */
using MySql.Data.MySqlClient;
using SYS.Core.Util;
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
        //private static string conStr = ConfigurationManager.AppSettings["MySqlStr"];
        private static string conStr = HttpHelper.dbString;

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
