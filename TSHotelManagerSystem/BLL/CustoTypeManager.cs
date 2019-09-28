using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSHotelManagerSystem.DAL;
using TSHotelManagerSystem.Models;

namespace TSHotelManagerSystem.BLL
{
   public class CustoTypeManager
    {
        public static List<CustoType> SelectCustoTypesAll()
        {
            List<CustoType> types = new List<CustoType>();
            string sql = "select * from USERTYPE";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                CustoType type = new CustoType();
                type.UserType = (int)dr["UserType"];
                type.TypeName = dr["TypeName"].ToString();
                types.Add(type);
            }
            dr.Close();
            DBHelper.Closecon();

            return types;
        }
    }
}
