using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSHotelManagerSystem.Models;

namespace TSHotelManagerSystem.DAL
{
   public class CheckInfoService
    {
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
