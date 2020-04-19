using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSHotelManagerSystem.Models;

namespace TSHotelManagerSystem.DAL
{
   public class RoomService
    {
        #region 获取所有房间信息
        /// <summary>
        /// 获取所有房间信息
        /// </summary>
        /// <returns></returns>
        public static List<Room> SelectRoomAll()
        {
            List<Room> rooms = new List<Room>();
            string sql = "select * from ROOM r,ROOMTYPE t,ROOMSTATE rs where r.RoomType=t.RoomType and r.RoomStateId=rs.RoomStateId";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Room room = new Room();
                room.RoomNo = (string)dr["RoomNo"];
                room.CustoNo = dr["CustoNo"].ToString();
                room.RoomMoney = (decimal)dr["RoomMoney"];
                room.PersonNum = Convert.ToString(dr["PersonNum"]);
                if (!DBNull.Value.Equals(dr["CheckTime"]))
                {
                    room.CheckTime = DateTime.Parse(dr["CheckTime"].ToString());
                }
                if (!DBNull.Value.Equals(dr["CheckOutTime"]))
                {
                    room.CheckOutTime = DateTime.Parse(dr["CheckOutTime"].ToString());
                }
                room.RoomStateId = (int)dr["RoomStateId"];
                room.RoomState = (string)dr["RoomState"];
                room.RoomType = (int)dr["RoomType"];
                room.RoomPosition = (string)dr["RoomPosition"];
                room.typeName = (string)dr["RoomName"];
                rooms.Add(room);
            }
            dr.Close();
            DBHelper.Closecon();
            return rooms;
        }
        #endregion

        #region 获取房间分区的信息
        /// <summary>
        /// 获取房间分区的信息
        /// </summary>
        /// <returns></returns>
        public static List<Room> SelectRoomByTypeName(string TypeName)
        {
            List<Room> rs = new List<Room>();
            string sql = "select * from ROOM r,ROOMTYPE t,ROOMSTATE rs where r.RoomType=t.RoomType and r.RoomStateId=rs.RoomStateId and t.RoomName='" + TypeName + "'";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Room r = new Room();
                r.RoomNo = (string)dr["RoomNo"];
                r.CustoNo = dr["CustoNo"].ToString();
                r.RoomMoney = (decimal)dr["RoomMoney"];
                r.PersonNum = Convert.ToString(dr["PersonNum"]);
                if (!DBNull.Value.Equals(dr["CheckTime"]))
                {
                    r.CheckTime = DateTime.Parse(dr["CheckTime"].ToString());
                }
                if (!DBNull.Value.Equals(dr["CheckOutTime"]))
                {
                    r.CheckOutTime = DateTime.Parse(dr["CheckOutTime"].ToString());
                }
                r.RoomStateId = (int)dr["RoomStateId"];
                r.RoomState = (string)dr["RoomState"];
                r.RoomType = (int)dr["RoomType"];
                r.RoomPosition = (string)dr["RoomPosition"];
                r.typeName = (string)dr["RoomName"];
                rs.Add(r);
            }
            dr.Close();
            DBHelper.Closecon();
            return rs;

        }
        #endregion
        
        #region 根据房间状态来查询可使用的房间
        /// <summary>
        /// 根据房间状态来查询可使用的房间
        /// </summary>
        /// <returns></returns>
        public static List<Room> SelectCanUseRoomAll()
        {
            List<Room> rooms = new List<Room>();
            string sql = "select * from ROOM r,ROOMTYPE t,ROOMSTATE rs where r.RoomType=t.RoomType and r.RoomStateId=rs.RoomStateId and r.RoomStateId='0'";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Room room = new Room();
                room.RoomNo = (string)dr["RoomNo"];
                room.CustoNo = dr["CustoNo"].ToString();
                room.RoomMoney = (decimal)dr["RoomMoney"];
                room.PersonNum = Convert.ToString(dr["PersonNum"]);
                if (!DBNull.Value.Equals(dr["CheckTime"]))
                {
                    room.CheckTime = DateTime.Parse(dr["CheckTime"].ToString());
                }
                if (!DBNull.Value.Equals(dr["CheckOutTime"]))
                {
                    room.CheckOutTime = DateTime.Parse(dr["CheckOutTime"].ToString());
                }
                room.RoomStateId = (int)dr["RoomStateId"];
                room.RoomState = (string)dr["RoomState"];
                room.RoomType = (int)dr["RoomType"];
                room.RoomPosition = (string)dr["RoomPosition"];
                room.typeName = (string)dr["RoomName"];
                rooms.Add(room);
            }
            dr.Close();
            DBHelper.Closecon();
            return rooms;
        }
        #endregion

        

        #region 根据房间编号查询房间信息
        /// <summary>
        /// 根据房间编号查询房间信息
        /// </summary>
        /// <param name="no"></param>
        /// <returns></returns>
        public static Room SelectRoomByRoomNo(string no)
        {
            Room room = null;
            string sql = "select * from room where RoomNo='" + no + "'";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            if (dr.Read())
            {
                room = new Room();
                room.RoomNo = (string)dr["RoomNo"];
                room.CustoNo = dr["CustoNo"].ToString();
                room.RoomMoney = (decimal)dr["RoomMoney"];
                room.PersonNum = Convert.ToString(dr["PersonNum"]);
                if (!DBNull.Value.Equals(dr["CheckTime"]))
                {
                    room.CheckTime = DateTime.Parse(dr["CheckTime"].ToString());
                }
                if (!DBNull.Value.Equals(dr["CheckOutTime"]))
                {
                    room.CheckOutTime = DateTime.Parse(dr["CheckOutTime"].ToString());
                }
                room.RoomStateId = (int)dr["RoomStateId"];
                room.RoomType = (int)dr["RoomType"];
                room.RoomPosition = (string)dr["RoomPosition"];
            }
            dr.Close();
            DBHelper.Closecon();
            return room;
        }
        #endregion
        
        #region 根据房间编号退房（退房）
        /// <summary>
        /// 根据房间编号退房（退房）
        /// </summary>
        /// <param name="room"></param>
        /// <returns></returns>
        public static int UpdateRoomByRoomNo(string room)
        {
            string sql = "update ROOM set CustoNo=Null,CheckTime=null,";
            sql+="CheckOutTime =GETDATE(),PersonNum=Null,";
                sql+="RoomStateId='3' where RoomNo='" + room + "'";
            return DBHelper.ExecuteNonQuery(sql);
        }
        #endregion

        #region 根据房间编号查询截止到今天住了多少天
        /// <summary>
        /// 根据房间编号查询截止到今天住了多少天
        /// </summary>
        /// <param name="roomno"></param>
        /// <returns></returns>
        public static object DayByRoomNo(string roomno)
        {
            string sql = "select DATEDIFF(DAY,CheckTime,GETDATE()) from ROOM where RoomNo='" + roomno + "'";
            return DBHelper.ExecuteScalar(sql);
        }
        #endregion

        #region 根据房间编号修改房间信息（入住）
        /// <summary>
        /// 根据房间编号修改房间信息（入住）
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public static int UpdateRoomInfo(Room r)
        {
            string sql = "update Room set CustoNo='{1}',CheckTime='{2}',CheckOutTime=Null,";
            sql += "RoomStateId ='{3}',PersonNum='{4}' where RoomNo='{0}'";
            sql = string.Format(sql, r.RoomNo, r.CustoNo, r.CheckTime, r.RoomStateId, r.PersonNum);
            SqlConnection con = DBHelper.GetConnection();
            return DBHelper.ExecuteNonQuery(sql);
        }
        #endregion

        #region 查询可入住房间数量
        /// <summary>
        /// 查询可入住房间数量
        /// </summary>
        /// <returns></returns>
        public static object SelectCanUseRoomAllByRoomState()
        {
            List<Room> rooms = new List<Room>();
            string sql = "select Count(*) from ROOM where RoomStateId='0'";
            return DBHelper.ExecuteScalar(sql);
        }
        #endregion

        #region 查询已入住房间数量
        /// <summary>
        /// 查询已入住房间数量
        /// </summary>
        /// <returns></returns>
        public static object SelectNotUseRoomAllByRoomState()
        {
            List<Room> rooms = new List<Room>();
            string sql = "select Count(*) from ROOM where RoomStateId='1'";
            return DBHelper.ExecuteScalar(sql);
        }
        #endregion

        #region 根据房间编号查询房间价格
        /// <summary>
        /// 根据房间编号查询房间价格
        /// </summary>
        /// <returns></returns>
        public static object SelectRoomByRoomPrice(string r)
        {

            string sql = "select RoomMoney from Room where RoomNo='" + r + "'";
            return DBHelper.ExecuteReader(sql);

        }
        #endregion

        #region 查询脏房数量
        /// <summary>
        /// 查询脏房数量
        /// </summary>
        /// <returns></returns>
        public static object SelectNotClearRoomAllByRoomState()
        {
            List<Room> rooms = new List<Room>();
            string sql = "select Count(*) from ROOM where RoomStateId='3'";
            return DBHelper.ExecuteScalar(sql);
        }
        #endregion

        #region 查询维修房数量
        /// <summary>
        /// 查询维修房数量
        /// </summary>
        /// <returns></returns>
        public static object SelectFixingRoomAllByRoomState()
        {
            List<Room> rooms = new List<Room>();
            string sql = "select Count(*) from ROOM where RoomStateId='2'";
            return DBHelper.ExecuteScalar(sql);
        }
        #endregion

        #region 查询预约房数量
        /// <summary>
        /// 查询预约房数量
        /// </summary>
        /// <returns></returns>
        public static object SelectReseredRoomAllByRoomState()
        {
            List<Room> rooms = new List<Room>();
            string sql = "select Count(*) from ROOM where RoomStateId='4'";
            return DBHelper.ExecuteScalar(sql);
        }
        #endregion

        #region 根据房间编号查询房间状态名称
        /// <summary>
        /// 根据房间编号查询房间状态名称
        /// </summary>
        /// <param name="roomno"></param>
        /// <returns></returns>
        public static object SelectRoomStateNameByRoomNo(string roomno)
        {
            string sql = "select s.RoomState from ROOMSTATE s,ROOM r where s.RoomStateId=r.RoomStateId and r.RoomNo='" + roomno + "'";
            return DBHelper.ExecuteScalar(sql);
        }
        #endregion

        #region 根据房间编号更改房间状态
        /// <summary>
        /// 根据房间编号更改房间状态
        /// </summary>
        /// <param name="roomno"></param>
        /// <param name="stateid"></param>
        /// <returns></returns>
        public static int UpdateRoomStateByRoomNo(string roomno,int stateid)
        {
            string sql = "update ROOM set RoomStateId='" + stateid + "' where RoomNo='" + roomno + "'";
            return DBHelper.ExecuteNonQuery(sql);
        }
        #endregion

        #region 添加房间
        /// <summary>
        /// 添加房间
        /// </summary>
        /// <param name="roomno"></param>
        /// <returns></returns>
        public static object InsertRoom(Room rn)
        {
            string sql = "insert ROOM values('{0}','{1}',NULL,NULL,NULL,'0','{2}',NULL,'{3}')";
            sql = string.Format(sql, rn.RoomNo, rn.RoomType, rn.RoomMoney, rn.RoomPosition);
            return DBHelper.ExecuteNonQuery(sql);
        }
        #endregion

        #region 查询所有可消费（已住）房间
        /// <summary>
        /// 查询所有可消费（已住）房间
        /// </summary>
        /// <returns></returns>
        public static List<Room> SelectRoomByStateAll()
        {
            List<Room> rooms = new List<Room>();
            string sql = "select * from ROOM r,ROOMTYPE t,ROOMSTATE rs where r.RoomType=t.RoomType and r.RoomStateId=rs.RoomStateId and r.RoomStateId='1'";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Room room = new Room();
                room.RoomNo = (string)dr["RoomNo"];
                room.CustoNo = dr["CustoNo"].ToString();
                room.RoomMoney = (decimal)dr["RoomMoney"];
                room.PersonNum = Convert.ToString(dr["PersonNum"]);
                if (!DBNull.Value.Equals(dr["CheckTime"]))
                {
                    room.CheckTime = DateTime.Parse(dr["CheckTime"].ToString());
                }
                if (!DBNull.Value.Equals(dr["CheckOutTime"]))
                {
                    room.CheckOutTime = DateTime.Parse(dr["CheckOutTime"].ToString());
                }
                room.RoomStateId = (int)dr["RoomStateId"];
                room.RoomState = (string)dr["RoomState"];
                room.RoomType = (int)dr["RoomType"];
                room.RoomPosition = (string)dr["RoomPosition"];
                room.typeName = (string)dr["RoomName"];
                rooms.Add(room);
            }
            dr.Close();
            DBHelper.Closecon();
            return rooms;
        }
        #endregion

        #region 获取所有房间状态
        /// <summary>
        /// 获取所有房间状态
        /// </summary>
        /// <returns></returns>
        public static List<Room> SelectRoomStateAll()
        {
            List<Room> rs = new List<Room>();
            string sql = "select * from ROOMSTATE";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Room r = new Room();
                r.RoomStateId = Convert.ToInt32(dr["RoomStateId"]);
                r.RoomState = dr["RoomState"].ToString();
                rs.Add(r);
            }
            dr.Close();
            DBHelper.Closecon();
            return rs;
        }
        #endregion

        #region 根据房间编号查询房间状态编号
        /// <summary>
        /// 根据房间编号查询房间状态编号
        /// </summary>
        /// <param name="roomno"></param>
        /// <returns></returns>
        public static object SelectRoomStateIdByRoomNo(string roomno)
        {
            string sql = "select RoomStateId from ROOM where RoomNo='" + roomno + "'";
            return DBHelper.ExecuteScalar(sql);
        }
        #endregion
    }
}
