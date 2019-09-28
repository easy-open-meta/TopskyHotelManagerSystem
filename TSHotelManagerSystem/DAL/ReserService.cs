using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSHotelManagerSystem.Models;

namespace TSHotelManagerSystem.DAL
{
   public class ReserService
    {
        public static List<Reser> SelectReserAll()
        {

            List<Reser> rss = new List<Reser>();
            string sql = "select * from RESER r,ROOMTYPE t where r.ReserRoom=t.RoomType";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Reser rs = new Reser();
                rs.ReserId = (string)dr["ReserId"];
                rs.CustoName = dr["CustoName"].ToString();
                rs.CustoTel = (string)dr["CustoTel"];
                rs.ReserWay = (string)dr["ReserWay"];
                rs.ReserCash = (decimal)dr["ReserCash"];
                rs.ReserDate = (DateTime)dr["ReserDate"];
                rs.ReserPerson = (int)dr["ReserPerson"];
                rs.typeName = (string)dr["RoomName"];
                if (!DBNull.Value.Equals(dr["ReserRemark"]))
                {
                    rs.ReserRemark = dr["ReserRemark"].ToString();
                }
                rss.Add(rs);
            }
            dr.Close();
            DBHelper.Closecon();
            return rss;
        }

        public static List<Reser> SelectReserInfoByConn(string tel)
        {
            List<Reser> tis = new List<Reser>();
            string sql = "select * from Reser where CustoTel = '" + tel + "'";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Reser ti = new Reser();
                ti.ReserId = (string)dr["ReserId"];
                ti.CustoName = (string)dr["CustoName"];
                ti.CustoTel = (string)dr["CustoTel"];
                ti.ReserWay = (string)dr["ReserWay"];
                ti.ReserCash = (decimal)dr["ReserCash"];
                ti.ReserDate = DateTime.Parse(dr["ReserDate"].ToString());
                ti.ReserPerson = (int)dr["ReserPerson"];
                ti.ReserRemark = (string)dr["ReserRemark"];
                tis.Add(ti);
            }
            dr.Close();
            DBHelper.Closecon();
            return tis;
        }
    }
}
