using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSHotelManagerSystem.Models;

namespace TSHotelManagerSystem.DAL
{
    public class WtiService
    {
        #region 根据房间编号查询水电费信息
        /// <summary>
        /// 根据房间编号查询水电费信息
        /// </summary>
        /// <param name="roomNo"></param>
        /// <returns></returns>
        public static Wti SelectWtiInfoByRoomNo(string roomNo)
        {
            Wti w = null;
            string sql = "select * from WTINFO where RoomNo like '%" + roomNo + "%'";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            if (dr.Read())
            {
                w = new Wti();
                w.CustoNo = dr["CustoNo"].ToString();
                w.EndDate = Convert.ToDateTime(dr["EndDate"]);
                w.PowerUse = (decimal)dr["PowerUse"];
                w.Record = dr["Record"].ToString();
                w.RoomNo = dr["RoomNo"].ToString();
                w.UseDate = Convert.ToDateTime(dr["UseDate"]);
                w.WaterUse = (decimal)dr["WaterUse"];
            }
            dr.Close();
            DBHelper.Closecon();
            return w;
        }
        #endregion

        #region 根据房间编号、使用时间查询水电费信息
        /// <summary>
        /// 根据房间编号、使用时间查询水电费信息
        /// </summary>
        /// <param name="roomno"></param>
        /// <param name="usedate"></param>
        /// <param name="enddate"></param>
        /// <returns></returns>
        public static Wti SelectWtiInfoByRoomNoAndTime(string roomno, string usedate, string enddate)
        {
            Wti w = null;
            string sql = "select * from WTINFO where RoomNo='" + roomno +
                "' and UseDate='" + usedate + "' and EndDate='" + enddate + "'";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            if (dr.Read())
            {
                w = new Wti();
                w.CustoNo = dr["CustoNo"].ToString();
                w.EndDate = Convert.ToDateTime(dr["EndDate"]);
                w.PowerUse = (decimal)dr["PowerUse"];
                w.Record = dr["Record"].ToString();
                w.RoomNo = dr["RoomNo"].ToString();
                w.UseDate = Convert.ToDateTime(dr["UseDate"]);
                w.WaterUse = (decimal)dr["WaterUse"];
            }
            dr.Close();
            DBHelper.Closecon();
            return w;
        } 
        #endregion

        #region 获取所有水电费信息
        /// <summary>
        /// 获取所有水电费信息
        /// </summary>
        /// <returns></returns>
        public static List<Wti> SelectWtiInfoAll()
        {
            List<Wti> wti = new List<Wti>();
            string sql = "select * from WTINFO";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Wti w = new Wti();
                w.CustoNo = dr["CustoNo"].ToString();
                w.EndDate =Convert.ToDateTime(dr["EndDate"]);
                w.PowerUse = (decimal)dr["PowerUse"];
                w.Record = dr["Record"].ToString();
                w.RoomNo = dr["RoomNo"].ToString();
                w.UseDate = Convert.ToDateTime(dr["UseDate"]);
                w.WaterUse = (decimal)dr["WaterUse"];
                wti.Add(w);
            }
            dr.Close();
            DBHelper.Closecon();
            return wti;
        }
        #endregion

        #region 添加水电费信息
        /// <summary>
        /// 添加水电费信息
        /// </summary>
        /// <param name="w"></param>
        /// <returns></returns>
        public static int InsertWtiInfo(Wti w)
        {
            string sql = "insert WTINFO (RoomNo,UseDate,EndDate,";
            sql += "WaterUse,PowerUse,Record,CustoNo) values ";
            sql += "('{0}','{1}','{2}','{3}','{4}','{5}','{6}')";
            sql = string.Format(sql, w.RoomNo, w.UseDate, w.EndDate,
                w.WaterUse, w.PowerUse, w.Record, w.CustoNo);
            return DBHelper.ExecuteNonQuery(sql);
        }
        #endregion

        #region 修改水电费信息(根据房间编号)
        /// <summary>
        /// 修改水电费信息(根据房间编号)
        /// </summary>
        /// <param name="w"></param>
        /// <returns></returns>
        public static int UpdateWtiInfo(Wti w)
        {
            string sql = " update WTINFO set UseDate='{1}',EndDate='{2}',";
            sql += "WaterUse ='{3}',PowerUse='{4}',Record='{5}',CustoNo='{6}'where RoomNo = '{0}'";
            sql = string.Format(sql, w.RoomNo, w.UseDate, w.EndDate,
                w.WaterUse, w.PowerUse, w.Record, w.CustoNo);
            return DBHelper.ExecuteNonQuery(sql);
        }
        #endregion

        #region 根据房间信息、使用时间修改水电费
        /// <summary>
        /// 根据房间信息、使用时间修改水电费
        /// </summary>
        /// <param name="w"></param>
        /// <returns></returns>
        public static int UpdateWtiInfoByRoomNoAndDateTime(Wti w)
        {
            string sql = "update WTINFO set WaterUse='{0}',PowerUse='{1}' where ";
            sql += " RoomNo='{2}' and UseDate='{3}' and EndDate='{4}'";
            sql = string.Format(sql, w.WaterUse, w.PowerUse, w.RoomNo, w.UseDate, w.EndDate);
            return DBHelper.ExecuteNonQuery(sql);
        } 
        #endregion

        #region 删除水电费信息:根据房间编号
        /// <summary>
        /// 删除水电费信息:根据房间编号
        /// </summary>
        /// <param name="roomno"></param>
        /// <returns></returns>
        public static int DeleteWtiInfo(string roomno)
        {
            string sql = "delete from WtiInfo where RoomNo='" + roomno + "'";
            return DBHelper.ExecuteNonQuery(sql);
        }
        #endregion

        #region 根据房间编号、使用时间删除水电费信息
        /// <summary>
        /// 根据房间编号、使用时间删除水电费信息
        /// </summary>
        /// <param name="roomno"></param>
        /// <param name="usedate"></param>
        /// <param name="enddate"></param>
        /// <returns></returns>
        public static int DeleteWtiInfoByRoomNoAndDateTime(string roomno, string usedate, string enddate)
        {
            string sql = " delete from WTINFO where RoomNo='{0}' and UseDate='{1}' and EndDate='{2}'";
            sql = string.Format(sql, roomno, usedate, enddate);
            return DBHelper.ExecuteNonQuery(sql);
        } 
        #endregion
    }
}
