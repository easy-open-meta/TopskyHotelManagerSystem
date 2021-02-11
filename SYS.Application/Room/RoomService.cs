using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using SYS.Common;
using SYS.Core;

namespace SYS.Application
{
    /// <summary>
    /// 客房信息接口实现类
    /// </summary>
    public class RoomService:Repository<Room>, IRoomService
    {
        #region 根据房间状态获取相应状态的房间信息
        /// <summary>
        /// 根据房间状态获取相应状态的房间信息
        /// </summary>
        /// <param name="stateid"></param>
        /// <returns></returns>
        public List<Room> SelectRoomByRoomState(int stateid)
        {
            List<RoomState> roomStates = new List<RoomState>();
            roomStates = base.Change<RoomState>().GetList(a => a.delete_mk != 1);
            List<RoomType> roomTypes = new List<RoomType>();
            roomTypes = base.Change<RoomType>().GetList(a => a.delete_mk != 1);
            List<Room> rooms = new List<Room>();
<<<<<<< HEAD
            string sql = "select * from ROOM r,ROOMTYPE t,ROOMSTATE rs where r.RoomType = t.RoomType and r.RoomStateId = rs.RoomStateId and r.RoomStateId = " + stateid;
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
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
=======
            rooms = base.GetList(a => a.delete_mk != 1 && a.RoomStateId == stateid).OrderBy(a => a.RoomNo).ToList();
            rooms.ForEach(source =>
            {
                var roomState = roomStates.FirstOrDefault(a => a.RoomStateId == source.RoomStateId);
                source.RoomState = string.IsNullOrEmpty(roomState.RoomStateName) ? "" : roomState.RoomStateName;
                var roomType = roomTypes.FirstOrDefault(a => a.Roomtype == source.RoomType);
                source.RoomName = string.IsNullOrEmpty(roomType.RoomName) ? "" : roomType.RoomName;
            });
>>>>>>> InitProject_v1.4.8_happy_new_year
            return rooms;
        }
        #endregion

<<<<<<< HEAD
=======

        #region 根据房间状态来查询可使用的房间
        /// <summary>
        /// 根据房间状态来查询可使用的房间
        /// </summary>
        /// <returns></returns>
        public List<Room> SelectCanUseRoomAll()
        {
            List<RoomState> roomStates = new List<RoomState>();
            roomStates = base.Change<RoomState>().GetList(a => a.delete_mk != 1);
            List<RoomType> roomTypes = new List<RoomType>();
            roomTypes = base.Change<RoomType>().GetList(a => a.delete_mk != 1);
            List<Room> rooms = new List<Room>();
            rooms = base.GetList(a => a.delete_mk != 1 && a.RoomStateId == 0).OrderBy(a => a.RoomNo).ToList();
            rooms.ForEach(source =>
            {
                var roomState = roomStates.FirstOrDefault(a => a.RoomStateId == source.RoomStateId);
                source.RoomState = string.IsNullOrEmpty(roomState.RoomStateName) ? "" : roomState.RoomStateName;
                var roomType = roomTypes.FirstOrDefault(a => a.Roomtype == source.RoomType);
                source.RoomName = string.IsNullOrEmpty(roomType.RoomName) ? "" : roomType.RoomName;
            });
            return rooms;
        }
        #endregion


>>>>>>> InitProject_v1.4.8_happy_new_year
        #region 获取所有房间信息
        /// <summary>
        /// 获取所有房间信息
        /// </summary>
        /// <returns></returns>
        public List<Room> SelectRoomAll()
        {
            List<RoomState> roomStates = new List<RoomState>();
            roomStates = base.Change<RoomState>().GetList(a => a.delete_mk != 1);
            List<RoomType> roomTypes = new List<RoomType>();
            roomTypes = base.Change<RoomType>().GetList(a => a.delete_mk != 1);
            List<Room> rooms = new List<Room>();
<<<<<<< HEAD
            string sql = "select * from ROOM r,ROOMTYPE t,ROOMSTATE rs where r.RoomType=t.RoomType and r.RoomStateId=rs.RoomStateId";
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
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
=======
            rooms = base.GetList(a => a.delete_mk != 1).OrderBy(a => a.RoomNo).ToList();
            rooms.ForEach(source =>
            {
                var roomState = roomStates.FirstOrDefault(a => a.RoomStateId == source.RoomStateId);
                source.RoomState = string.IsNullOrEmpty(roomState.RoomStateName) ? "" : roomState.RoomStateName;
                var roomType = roomTypes.FirstOrDefault(a => a.Roomtype == source.RoomType);
                source.RoomName = string.IsNullOrEmpty(roomType.RoomName) ? "" : roomType.RoomName;
            });
>>>>>>> InitProject_v1.4.8_happy_new_year
            return rooms;
        }
        #endregion

        #region 获取房间分区的信息
        /// <summary>
        /// 获取房间分区的信息
        /// </summary>
        /// <returns></returns>
        public List<Room> SelectRoomByTypeName(string TypeName)
        {
<<<<<<< HEAD
            List<Room> rs = new List<Room>();
            string sql = "select * from ROOM r,ROOMTYPE t,ROOMSTATE rs where r.RoomType=t.RoomType and r.RoomStateId=rs.RoomStateId and t.RoomName='" + TypeName + "'";
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
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

=======
            List<RoomState> roomStates = new List<RoomState>();
            roomStates = base.Change<RoomState>().GetList(a => a.delete_mk != 1);
            List<RoomType> roomTypes = new List<RoomType>();
            roomTypes = base.Change<RoomType>().GetList(a => a.delete_mk != 1 && a.RoomName == TypeName);
            var listTypes = roomTypes.Select(a => a.Roomtype).Distinct().ToList();
            List<Room> rooms = new List<Room>();
            rooms = base.GetList(a => a.delete_mk != 1 && listTypes.Contains(a.RoomType)).OrderBy(a => a.RoomNo).ToList();
            rooms.ForEach(source =>
            {
                var roomState = roomStates.FirstOrDefault(a => a.RoomStateId == source.RoomStateId);
                source.RoomState = string.IsNullOrEmpty(roomState.RoomStateName) ? "" : roomState.RoomStateName;
                var roomType = roomTypes.FirstOrDefault(a => a.Roomtype == source.RoomType);
                source.RoomName = string.IsNullOrEmpty(roomType.RoomName) ? "" : roomType.RoomName;
            });
            return rooms;
>>>>>>> InitProject_v1.4.8_happy_new_year
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
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
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
        public Room SelectRoomByRoomNo(string no)
        {
<<<<<<< HEAD
            Room room = null;
            string sql = "select * from room where RoomNo='" + no + "'";
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
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
=======
            List<RoomState> roomStates = new List<RoomState>();
            roomStates = base.Change<RoomState>().GetList(a => a.delete_mk != 1);
            Room room = new Room();
            room = base.GetSingle(a => a.delete_mk != 1 && a.RoomNo == no);
            var roomSate = roomStates.FirstOrDefault(a => a.RoomStateId == room.RoomStateId);
            room.RoomState = string.IsNullOrEmpty(roomSate.RoomStateName) ? "" : roomSate.RoomStateName;
>>>>>>> InitProject_v1.4.8_happy_new_year
            return room;
        }
        #endregion

        #region 根据房间编号退房（退房）
        /// <summary>
        /// 根据房间编号退房（退房）
        /// </summary>
        /// <param name="room"></param>
        /// <returns></returns>
        public bool UpdateRoomByRoomNo(string room)
        {
<<<<<<< HEAD
            string sql = "update ROOM set CustoNo=Null,CheckTime=null,";
            sql += "CheckOutTime =CURRENT_DATE(),PersonNum=Null,";
            sql += "RoomStateId='3' where RoomNo='" + room + "'";
            return DBHelper.ExecuteNonQuery(sql);
=======
            return base.Update(a => new Room()
            {
                CustoNo = null,
                CheckTime = null,
                CheckOutTime = DateTime.Now,
                RoomStateId = 3
            },a => a.RoomNo == room);
>>>>>>> InitProject_v1.4.8_happy_new_year
        }
        #endregion

        #region 根据房间编号查询截止到今天住了多少天
        /// <summary>
        /// 根据房间编号查询截止到今天住了多少天
        /// </summary>
        /// <param name="roomno"></param>
        /// <returns></returns>
        public object DayByRoomNo(string roomno)
        {
<<<<<<< HEAD
            string sql = "select DATEDIFF(CURRENT_DATE(),CheckTime) from ROOM where RoomNo='" + roomno + "'";
            //DATEDIFF(workercheck.CheckTime,CURRENT_DATE()) = 0
            return DBHelper.ExecuteScalar(sql);
=======
            return Math.Abs(((TimeSpan)(base.GetSingle(a => a.RoomNo == roomno).CheckTime - DateTime.Now)).Days);
>>>>>>> InitProject_v1.4.8_happy_new_year
        }
        #endregion

        #region 根据房间编号修改房间信息（入住）
        /// <summary>
        /// 根据房间编号修改房间信息（入住）
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public bool UpdateRoomInfo(Room r)
        {
<<<<<<< HEAD
            string sql = "update Room set CustoNo='{1}',CheckTime='{2}',CheckOutTime=Null,";
            sql += "RoomStateId ='{3}',PersonNum='{4}' where RoomNo='{0}'";
            sql = string.Format(sql, r.RoomNo, r.CustoNo, r.CheckTime, r.RoomStateId, r.PersonNum);
            MySqlConnection con = DBHelper.GetConnection();
            return DBHelper.ExecuteNonQuery(sql);
=======
            return base.Update(a => new Room()
            {
                CheckTime = r.CheckTime,
                RoomStateId = r.RoomStateId,
                CustoNo = r.CustoNo
            },a => a.RoomNo == r.RoomNo);
        }
        #endregion

        #region 根据房间编号修改房间信息（预约）
        /// <summary>
        /// 根据房间编号修改房间信息（预约）
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public bool UpdateRoomInfoWithReser(Room r)
        {
            return base.Update(a => new Room()
            {
                RoomStateId = r.RoomStateId,
                datachg_usr = LoginInfo.WorkerNo,
                datachg_date = DateTime.Now
            }, a => a.RoomNo == r.RoomNo);
>>>>>>> InitProject_v1.4.8_happy_new_year
        }
        #endregion

        #region 查询可入住房间数量
        /// <summary>
        /// 查询可入住房间数量
        /// </summary>
        /// <returns></returns>
        public object SelectCanUseRoomAllByRoomState()
        {
<<<<<<< HEAD
            List<Room> rooms = new List<Room>();
            string sql = "select Count(*) from ROOM where RoomStateId='0'";
            return DBHelper.ExecuteScalar(sql);
=======
            return base.GetList(a => a.RoomStateId == 0 && a.delete_mk != 1).OrderBy(a => a.RoomNo).Count();
>>>>>>> InitProject_v1.4.8_happy_new_year
        }
        #endregion

        #region 查询已入住房间数量
        /// <summary>
        /// 查询已入住房间数量
        /// </summary>
        /// <returns></returns>
        public object SelectNotUseRoomAllByRoomState()
        {
<<<<<<< HEAD
            List<Room> rooms = new List<Room>();
            string sql = "select Count(*) from ROOM where RoomStateId='1'";
            return DBHelper.ExecuteScalar(sql);
=======
            return base.GetList(a => a.RoomStateId == 1 && a.delete_mk != 1).OrderBy(a => a.RoomNo).Count();
>>>>>>> InitProject_v1.4.8_happy_new_year
        }
        #endregion

        #region 根据房间编号查询房间价格
        /// <summary>
        /// 根据房间编号查询房间价格
        /// </summary>
        /// <returns></returns>
        public object SelectRoomByRoomPrice(string r)
        {
            return base.GetSingle(a => a.RoomNo == r).RoomMoney;
        }
        #endregion

        #region 查询脏房数量
        /// <summary>
        /// 查询脏房数量
        /// </summary>
        /// <returns></returns>
        public object SelectNotClearRoomAllByRoomState()
        {
<<<<<<< HEAD
            List<Room> rooms = new List<Room>();
            string sql = "select Count(*) from ROOM where RoomStateId='3'";
            return DBHelper.ExecuteScalar(sql);
=======
            return base.GetList(a => a.RoomStateId == 3 && a.delete_mk != 1).OrderBy(a => a.RoomNo).Count();
>>>>>>> InitProject_v1.4.8_happy_new_year
        }
        #endregion

        #region 查询维修房数量
        /// <summary>
        /// 查询维修房数量
        /// </summary>
        /// <returns></returns>
        public object SelectFixingRoomAllByRoomState()
        {
<<<<<<< HEAD
            List<Room> rooms = new List<Room>();
            string sql = "select Count(*) from ROOM where RoomStateId='2'";
            return DBHelper.ExecuteScalar(sql);
=======
            return base.GetList(a => a.RoomStateId == 2 && a.delete_mk != 1).OrderBy(a => a.RoomNo).Count();
>>>>>>> InitProject_v1.4.8_happy_new_year
        }
        #endregion

        #region 查询预约房数量
        /// <summary>
        /// 查询预约房数量
        /// </summary>
        /// <returns></returns>
        public object SelectReseredRoomAllByRoomState()
        {
<<<<<<< HEAD
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
=======
            return base.GetList(a => a.RoomStateId == 4 && a.delete_mk != 1).OrderBy(a => a.RoomNo).Count();
>>>>>>> InitProject_v1.4.8_happy_new_year
        }
        #endregion

        #region 根据房间编号更改房间状态
        /// <summary>
        /// 根据房间编号更改房间状态
        /// </summary>
        /// <param name="roomno"></param>
        /// <param name="stateid"></param>
        /// <returns></returns>
        public bool UpdateRoomStateByRoomNo(string roomno, int stateid)
        {
            return base.Update(a => new Room()
            {
                RoomStateId = stateid,
                datains_usr = LoginInfo.WorkerNo,
                datachg_date = DateTime.Now
            },a => a.RoomNo == roomno);
        }
        #endregion

        #region 添加房间
        /// <summary>
        /// 添加房间
        /// </summary>
        /// <param name="rn"></param>
        /// <returns></returns>
        public bool InsertRoom(Room rn)
        {
            return base.Insert(rn);
        }
        #endregion

        #region 查询所有可消费（已住）房间
        /// <summary>
        /// 查询所有可消费（已住）房间
        /// </summary>
        /// <returns></returns>
        public List<Room> SelectRoomByStateAll()
        {
            List<RoomState> roomStates = new List<RoomState>();
            roomStates = base.Change<RoomState>().GetList(a => a.delete_mk != 1);
            List<RoomType> roomTypes = new List<RoomType>();
            roomTypes = base.Change<RoomType>().GetList(a => a.delete_mk != 1);
            List<Room> rooms = new List<Room>();
            rooms = base.GetList(a => a.delete_mk != 1 && a.RoomStateId == 1).OrderBy(a => a.RoomNo).ToList();
            rooms.ForEach(source =>
            {
<<<<<<< HEAD
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
=======
                var roomState = roomStates.FirstOrDefault(a => a.RoomStateId == source.RoomStateId);
                source.RoomState = string.IsNullOrEmpty(roomState.RoomStateName) ? "" : roomState.RoomStateName;
                var roomType = roomTypes.FirstOrDefault(a => a.Roomtype == source.RoomType);
                source.RoomName = string.IsNullOrEmpty(roomType.RoomName) ? "" : roomType.RoomName;
            });
>>>>>>> InitProject_v1.4.8_happy_new_year
            return rooms;
        }
        #endregion

        #region 获取所有房间状态
        /// <summary>
        /// 获取所有房间状态
        /// </summary>
        /// <returns></returns>
        public List<RoomState> SelectRoomStateAll()
        {
            List<RoomState> rs = new List<RoomState>();
            rs = base.Change<RoomState>().GetList(a => a.delete_mk != 1);
            return rs;
        }
        #endregion

        #region 根据房间编号查询房间状态编号
        /// <summary>
        /// 根据房间编号查询房间状态编号
        /// </summary>
        /// <param name="roomno"></param>
        /// <returns></returns>
        public object SelectRoomStateIdByRoomNo(string roomno)
        {
            return base.GetSingle(a => a.RoomNo == roomno).RoomStateId;
        }
        #endregion
    }
}
