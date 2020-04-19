using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSHotelManagerSystem.Models;

namespace TSHotelManagerSystem.DAL
{
   public class SpendService
    {
        #region 添加消费信息
        /// <summary>
        /// 添加消费信息
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int InsertSpendInfo(Spend s)
        {
            int n = 0;
            string sql = "insert CUSTOSPEND values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')";
            sql = string.Format(sql, s.RoomNo, s.CustoNo, s.SpendName, s.SpendAmount, s.SpendPrice, s.SpendMoney, s.SpendTime,s.MoneyState);
            n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }
        #endregion

        #region 根据客户编号查询信息
        /// <summary>
        /// 根据客户编号查询信息
        /// </summary>
        /// <param name="CustoNo"></param>
        /// <param name="RoomNo"></param>
        /// <returns></returns>
        public static List<Spend> SelectSpendByRoomNo(string RoomNo)
        {
            List<Spend> spends = new List<Spend>();
            string sql = "select * from CUSTOSPEND c,ROOM r where c.RoomNo=r.RoomNo";
            sql += " and c.RoomNo = '" + RoomNo + "' and SpendTime between r.CheckTime AND GETDATE()";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Spend spend = new Spend();
                spend.RoomNo = dr["RoomNo"].ToString();
                spend.CustoNo = dr["CustoNo"].ToString();
                spend.SpendName = dr["SpendName"].ToString();
                spend.SpendAmount = (int)dr["SpendAmount"];
                spend.SpendPrice = Convert.ToDecimal(dr["SpendPrice"]);
                spend.SpendMoney = Convert.ToDecimal(dr["SpendMoney"]);
                spend.SpendTime = Convert.ToDateTime(dr["SpendTime"]);
                spends.Add(spend);
            }
            dr.Close();
            DBHelper.Closecon();
            return spends;
        }
        #endregion

        #region 根据客户编号查询消费信息
        /// <summary>
        /// 根据客户编号查询消费信息
        /// </summary>
        /// <param name="No"></param>
        /// <returns></returns>
        public static List<Spend> SelectSpendByCustoNo(string No)
        {
            List<Spend> ls = new List<Spend>();
            string sql = "select * from CUSTOSPEND where CustoNo like '%" + No + "%' or RoomNo like '%" + No + "%'";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Spend s = new Spend();
                s.RoomNo = dr["RoomNo"].ToString();
                s.CustoNo = dr["CustoNo"].ToString();
                s.SpendName = dr["SpendName"].ToString();
                s.SpendAmount = (int)dr["SpendAmount"];
                s.SpendPrice = Convert.ToDecimal(dr["SpendPrice"]);
                s.SpendMoney = Convert.ToDecimal(dr["SpendMoney"]);
                s.SpendTime = Convert.ToDateTime(dr["SpendTime"]);
                s.MoneyState = dr["MoneyState"].ToString();
                ls.Add(s);
            }
            dr.Close();
            DBHelper.Closecon();
            return ls;
        }
        #endregion

        #region 查询消费的所有信息
        /// <summary>
        /// 查询消费的所有信息
        /// </summary>
        /// <returns></returns>
        public static List<Spend> SelectSpendInfoAll()
        {
            List<Spend> ls = new List<Spend>();
            string sql = "select * from CUSTOSPEND";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Spend s = new Spend();
                s.RoomNo = (string)dr["RoomNo"];
                s.CustoNo = (string)dr["CustoNo"];
                s.SpendName = (string)dr["SpendName"];
                s.SpendAmount = (int)dr["SpendAmount"];
                s.SpendPrice = (decimal)dr["SpendPrice"];
                s.SpendMoney = (decimal)dr["SpendMoney"];
                s.SpendTime = (DateTime)dr["SpendTime"];
                s.MoneyState = dr["MoneyState"].ToString();
                ls.Add(s);
            }
            dr.Close();
            DBHelper.Closecon();
            return ls;
        }
        #endregion

        #region 根据房间号查询消费的所有信息
        /// <summary>
        /// 根据房间号查询消费的所有信息
        /// </summary>
        /// <returns></returns>
        public static List<Spend> SelectSpendInfoRoomNo(string RoomNo)
        {
            List<Spend> ls = new List<Spend>();
            string sql = "select * from CUSTOSPEND c,ROOM r where c.RoomNo=r.RoomNo and c.RoomNo = '" + RoomNo + "' and c.MoneyState = '未结算' and SpendTime between r.CheckTime AND GETDATE()";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Spend s = new Spend();
                s.RoomNo = dr["RoomNo"].ToString();
                s.CustoNo = dr["CustoNo"].ToString();
                s.SpendName = dr["SpendName"].ToString();
                s.SpendAmount = (int)dr["SpendAmount"];
                s.SpendPrice = Convert.ToDecimal(dr["SpendPrice"]);
                s.SpendMoney = Convert.ToDecimal(dr["SpendMoney"]);
                s.SpendTime = Convert.ToDateTime(dr["SpendTime"]);
                s.MoneyState = dr["MoneyState"].ToString();
                ls.Add(s);
            }
            dr.Close();
            DBHelper.Closecon();
            return ls;
        }
        #endregion

        #region 根据房间编号、入住时间到当前时间查询消费总金额
        /// <summary>
        /// 根据房间编号、入住时间到当前时间查询消费总金额
        /// </summary>
        /// <param name="roomno"></param>
        /// <returns></returns>
        public static object SelectMoneyByRoomNoAndTime(string roomno)
        {
            string sql = "select convert(decimal(15,2),SUM(SpendMoney)) from CUSTOSPEND c,ROOM r where c.RoomNo=r.RoomNo ";
            sql += "and c.RoomNo = '" + roomno + "' and SpendTime between r.CheckTime AND GETDATE()";
            return DBHelper.ExecuteScalar(sql);
        }
        #endregion

        #region 根据房间编号、入住时间和当前时间修改结算状态
        /// <summary>
        /// 根据房间编号、入住时间和当前时间修改结算状态
        /// </summary>
        /// <param name="roomno"></param>
        /// <param name="checktime"></param>
        /// <returns></returns>
        public static int UpdateMoneyState(string roomno,string checktime)
        {
            string sql = "update CUSTOSPEND set MoneyState='已结算' where RoomNo='{0}' and SpendTime between '{1}' AND GETDATE()";
            sql = string.Format(sql, roomno, checktime);
            return DBHelper.ExecuteNonQuery(sql);
        }
        #endregion
    }
}
