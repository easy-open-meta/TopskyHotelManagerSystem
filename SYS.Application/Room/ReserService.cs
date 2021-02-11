using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SYS.Common;
using SYS.Core;

namespace SYS.Application
{
    /// <summary>
    /// 预约信息接口实现类
    /// </summary>
    public class ReserService:Repository<Reser>,IReserService
    {
        /// <summary>
        /// 获取所有预约信息
        /// </summary>
        /// <returns></returns>
        public List<Reser> SelectReserAll()
        {
            List<Reser> rss = new List<Reser>();
<<<<<<< HEAD:SYS.Application/Room/ReserService.cs
            string sql = "select * from RESER";
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Reser rs = new Reser();
                rs.ReserId = (string)dr["ReserId"];
                rs.CustoName = dr["CustoName"].ToString();
                rs.CustoTel = (string)dr["CustoTel"];
                rs.ReserWay = (string)dr["ReserWay"];
                if (!DBNull.Value.Equals(dr["ReserRoom"]))
                {
                    rs.ReserRoom = (string)dr["ReserRoom"];
                }
                rs.ReserDate = (DateTime)dr["ReserDate"];
                if (!DBNull.Value.Equals(dr["ReserEndDate"]))
                {
                    rs.ReserEndDay = (DateTime)dr["ReserEndDate"];
                }
                if (!DBNull.Value.Equals(dr["ReserRemark"]))
                {
                    rs.ReserRemark = dr["ReserRemark"].ToString();
                }
                rss.Add(rs);
            }
            dr.Close();
            DBHelper.Closecon();
=======
            rss = base.GetList(a => a.delete_mk == 0);
>>>>>>> InitProject_v1.4.8_happy_new_year:SYS.Application/Business/ReserService.cs
            return rss;
        }

        /// <summary>
        /// 根据房间编号获取预约信息
        /// </summary>
        /// <param name="no"></param>
        /// <returns></returns>
        public Reser SelectReserInfoByRoomNo(string no)
        {
            Reser res = null;
<<<<<<< HEAD:SYS.Application/Room/ReserService.cs
            string sql = "select * from RESER r,ROOM rm where r.ReserRoom = rm.RoomNo and r.ReserRoom = '" + no + "'";
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
            if (dr.Read())
            {
                res = new Reser();
                res.ReserId = (string)dr["ReserId"];
                res.CustoName = dr["CustoNo"].ToString();
                res.CustoTel = (string)dr["CustoTel"];
                res.ReserWay = Convert.ToString(dr["ReserWay"]);
                if (!DBNull.Value.Equals(dr["ReserDate"]))
                {
                    res.ReserDate = DateTime.Parse(dr["ReserDate"].ToString());
                }
                if (!DBNull.Value.Equals(dr["ReserEndDate"]))
                {
                    res.ReserEndDay = DateTime.Parse(dr["ReserEndDate"].ToString());
                }
                res.ReserRemark = (string)dr["ReserRemark"];
            }
            dr.Close();
            DBHelper.Closecon();
=======
            res = base.GetSingle(a => a.ReserRoom == no && a.delete_mk != 1);
>>>>>>> InitProject_v1.4.8_happy_new_year:SYS.Application/Business/ReserService.cs
            return res;
        }

        /// <summary>
        /// 删除预约信息
        /// </summary>
        /// <param name="rid"></param>
        /// <returns></returns>
        public bool DeleteReserInfo(string rid)
        {
            return base.Update(a => new Reser()
            {
                delete_mk = 1,
                datachg_usr = LoginInfo.WorkerNo,
                datachg_date = DateTime.Now
            },a => a.ReserId == rid);

        }

        /// <summary>
        /// 添加预约信息
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public bool InserReserInfo(Reser r)
        {
<<<<<<< HEAD:SYS.Application/Room/ReserService.cs
            string sql = "insert WTINFO (CustoName,CustoTel,ReserWay,";
            sql += "ReserRoomNo,ReserDate,ReserEndDay,Remark) values ";
            sql += "('{0}','{1}','{2}','{3}','{4}','{5}','{6}')";
            sql = string.Format(sql, r.CustoName, r.CustoTel, r.ReserWay,
                r.ReserRoom, r.ReserDate, r.ReserEndDay, r.ReserRemark);
            return DBHelper.ExecuteNonQuery(sql);
=======
            return base.Insert(r);
>>>>>>> InitProject_v1.4.8_happy_new_year:SYS.Application/Business/ReserService.cs
        }


    }
}
