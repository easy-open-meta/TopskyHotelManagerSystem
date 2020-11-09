using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace TSHotelManagerSystem.DAL
{
    public class WorkerGoodBadService
    {
        public static int AddGoodBad(WorkerGoodBad goodBad)
        {
            string sql = "insert into WorkerGoodBad values('" + goodBad.WorkNo + "','" + goodBad.GBInfo + "','" + goodBad.GBType + "','" + goodBad.GBOperation + "','" + goodBad.GBTime + "')";
            return DBHelper.ExecuteNonQuery(sql);
        }


        public static List<WorkerGoodBad> SelectAllGoodBadByWorkNo(string wn) 
        {
            List<WorkerGoodBad> gb = new List<WorkerGoodBad>();
            string sql = "select * from WorkerGoodBad wgb,GBType gbt where wgb.GBType = gbt.GBType and wgb.WorkNo = '" + wn + "'";
            SqlConnection conn = DBHelper.GetConnection();
            conn.Open();
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                WorkerGoodBad goodBad = new WorkerGoodBad();
                goodBad.WorkNo = dr["WorkNo"].ToString();
                goodBad.GBInfo = dr["GBInfo"].ToString();
                goodBad.TypeName = dr["GBName"].ToString();
                goodBad.GBOperation = dr["GBOperation"].ToString();
                goodBad.GBTime = (DateTime)dr["GBTime"];
                gb.Add(goodBad);
            }
            dr.Close();
            DBHelper.Closecon();
            return gb;
        }
    }
}
