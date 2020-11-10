using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using SYS.Core;

namespace SYS.Application
{
    public class CheckInfoService
    {

        public static string CheckBaseVersion()
        {
            string version = null;
            string sql = "select* from baseversion";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            if (dr.Read())
            {
                version = dr["base_version"].ToString();
            }
            dr.Close();
            DBHelper.Closecon();
            return version;
        }

        public static List<CheckInfo> SelectCheckInfoAll()
        {

            List<CheckInfo> cif = new List<CheckInfo>();
            string sql = "select * from CHECKINFO";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {

                CheckInfo ci = new CheckInfo();
                ci.CheckNo = (string)dr["CheckNo"];
                ci.CheckClub = dr["CheckClub"].ToString();
                ci.CheckProgres = (string)dr["CheckProgres"];
                ci.CheckCash = Convert.ToString(dr["CheckCash"]);
                ci.CheckScore = (int)dr["CheckScore"];
                ci.CheckPerson = dr["CheckPerson"].ToString();
                ci.CheckAdvice = dr["CheckAdvice"].ToString();
                cif.Add(ci);
            }
            dr.Close();
            DBHelper.Closecon();
            return cif;
        }
    }
}
