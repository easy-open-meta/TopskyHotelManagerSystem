using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSHotelManagerSystem.Models;

namespace TSHotelManagerSystem.DAL
{
    public class SellService
    {
        /// <summary>
        /// 查询所有商品
        /// </summary>
        /// <returns></returns>
        public static List<SellThing> SelectSellThingAll()
        {
            List<SellThing> ls = new List<SellThing>();
            string sql = "select * from Sellthing";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                SellThing s = new SellThing();
                s.SellNo = dr["SellNo"].ToString();
                s.SellName = dr["SellName"].ToString();
                s.SellPrice =Convert.ToDecimal(dr["SellPrice"]);
                s.format = (string)dr["format"];
                s.Stock = (int)dr["Stock"];
                ls.Add(s);
            }
            dr.Close();
            DBHelper.Closecon();
            return ls;
        }

        /// <summary>
        /// 根据商品ID查询
        /// </summary>
        /// <param name="No"></param>
        /// <returns></returns>
        public static SellThing SelectSellThingByNo(string No)
        {
            SellThing s = new SellThing();
            string sql = "select * from Sellthing where SellNo='" + No + "'";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                s = new SellThing();
                s.SellNo = dr["SellNo"].ToString();
                s.SellName = dr["SellName"].ToString();
                s.SellPrice = Convert.ToDecimal(dr["SellPrice"]);
                s.format = (string)dr["format"];
                s.Stock = (int)dr["Stock"];
            }
            dr.Close();
            DBHelper.Closecon();
            return s;
        }

        /// <summary>
        /// 根据商品名称查询
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public static List<SellThing> SelectSellThingByName(string Name)
        {
            List<SellThing> ls = new List<SellThing>();
            string sql = "select * from Sellthing where SellName like '%" + Name + "%' or SellNo like '%" + Name + "%' or SellPrice like '%" + Name + "%' or format like '%" + Name + "%'";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                SellThing s = new SellThing();
                s.SellNo = dr["SellNo"].ToString();
                s.SellName = dr["SellName"].ToString();
                s.SellPrice = Convert.ToDecimal(dr["SellPrice"]);
                s.format = (string)dr["format"];
                s.Stock = (int)dr["Stock"];
                ls.Add(s);
            }
            dr.Close();
            DBHelper.Closecon();
            return ls;
        }

        /// <summary>
        /// 修改商品
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int UpdateSellThing(string stock,string sellNo)
        {
            int n = 0;
            string sql = "update SELLTHING set Stock='{0}' where SellNo='{1}'";
            sql = string.Format(sql,stock,sellNo);
            n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }

        /// <summary>
        /// 撤回客户消费信息
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int DeleteSellThing(string roomNo,string time)
        {
            string sql = "delete from CUSTOSPEND where RoomNo='{0}' and SpendTime='{1}'";
            sql = string.Format(sql, roomNo, time);
            return DBHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 根据商品名称和价格查询商品编号
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <returns></returns>
        public static SellThing SelectSellThingByNameAndPrice(string name, string price)
        {
            SellThing s = null;
            string sql = "select * from SELLTHING where SellName='{0}' and SellPrice='{1}'";
            sql = string.Format(sql, name, price);
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            if (dr.Read())
            {
                s = new SellThing();
                s.SellNo = dr["SellNo"].ToString();
                s.SellName = dr["SellName"].ToString();
                s.SellPrice = Convert.ToDecimal(dr["SellPrice"]);
                s.format = (string)dr["format"];
                s.Stock = (int)dr["Stock"];
            }
            dr.Close();
            DBHelper.Closecon();
            return s;
        }

        

        public static SellThing SelectSellInfoBySellNo(string SellNo)
        {
            SellThing st = null;
            string sql = "select * from SellThing where SellNo='" + SellNo + "'";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            if (dr.Read())
            {
                st = new SellThing();
                st.SellNo = Convert.ToString(dr["SellNo"]);
                st.SellName = Convert.ToString(dr["SellName"]);
                st.SellPrice = Convert.ToDecimal(dr["SellPrice"]);
                st.format = Convert.ToString(dr["format"]);
                st.Stock = Convert.ToInt32(dr["Stock"]);
            }
            dr.Close();
            DBHelper.Closecon();
            return st;
        }

        #region 添加商品
        public static int InsertSellThing(SellThing st)
        {
            string sql = "insert SellThing (SellNo,SellName,SellPrice,";
            sql += "format,Stock) values ";
            sql += "('{0}','{1}','{2}','{3}','{4}')";
            sql = string.Format(sql, st.SellNo, st.SellName, st.SellPrice,
                st.format, st.Stock);
            return DBHelper.ExecuteNonQuery(sql);
        } 
        #endregion
    }
}
