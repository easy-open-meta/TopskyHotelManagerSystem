﻿using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SYS.Core;

namespace SYS.Application
{
    public class ReserService
    {

        public static List<Reser> SelectReserAll()
        {
            List<Reser> rss = new List<Reser>();
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
                rss.Add(rs);
            }
            dr.Close();
            DBHelper.Closecon();
            return rss;
        }

        public static Reser SelectReserInfoByRoomNo(string no)
        {
            Reser res = null;
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
            }
            dr.Close();
            DBHelper.Closecon();
            return res;
        }

        public static int DeleteReserInfo(string rid)
        {
            string sql = "delete from RESER where ReserId = '" + rid + "'";
            return DBHelper.ExecuteNonQuery(sql);

        }


        public static int InserReserInfo(Reser r)
        {
            string sql = "insert RESER (ReserId,CustoName,CustoTel,ReserWay,";
            sql += "ReserRoom,ReserDate,ReserEndDate) values ";
            sql += "('{0}','{1}','{2}','{3}','{4}','{5}','{6}')";
            sql = string.Format(sql, r.ReserId, r.CustoName, r.CustoTel, r.ReserWay,
                r.ReserRoom, r.ReserDate, r.ReserEndDay);
            return DBHelper.ExecuteNonQuery(sql);
        }


    }
}