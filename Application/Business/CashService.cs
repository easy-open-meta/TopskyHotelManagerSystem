using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Core;

namespace SYS.Application
{
    public class CashService
    {

        public static object AddCashInfo(Cash cash)
        {
            string sql = "insert into cashinfo values('" + cash.CashNo + "','" + cash.CashName + "','" + cash.CashPrice + "','" + cash.CashClub + "','" + cash.CashTime + "','" + cash.CashSource + "','" + cash.CashPerson + "')";
            return DBHelper.ExecuteNonQuery(sql);
        }

        public static List<Cash> SelectCashInfoAll()
        {

            List<Cash> cs = new List<Cash>();
            string sql = "select * from CASHINFO";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {

                Cash c = new Cash();
                c.CashNo = (string)dr["CashNo"];
                c.CashName = dr["CashName"].ToString();
                c.CashPrice = (string)dr["CashPrice"];
                c.CashClub = Convert.ToString(dr["CashClub"]);
                c.CashTime = DateTime.Parse(dr["CashTime"].ToString());
                c.CashSource = dr["CashSource"].ToString();
                c.CashPerson = dr["CashPerson"].ToString();
                cs.Add(c);
            }
            dr.Close();
            DBHelper.Closecon();
            return cs;
        }
    }
}
