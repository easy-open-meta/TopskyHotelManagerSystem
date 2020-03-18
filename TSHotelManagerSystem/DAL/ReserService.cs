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
        public static int InserReserInfo(Reser r)
        {
            string sql = "insert WTINFO (CustoName,CustoTel,ReserWay,";
            sql += "ReserRoomNo,ReserDate,ReserEndDay,Remark) values ";
            sql += "('{0}','{1}','{2}','{3}','{4}','{5}','{6}')";
            sql = string.Format(sql, r.CustoName, r.CustoTel, r.ReserWay,
                r.ReserRoomNo, r.ReserDate, r.ReserEndDay, r.Remark);
            return DBHelper.ExecuteNonQuery(sql);
        }

        
    }
}
