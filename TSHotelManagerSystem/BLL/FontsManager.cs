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
   public class FontsManager
    {
        public List<Fonts> SelectFontAll()
        {
            List<Fonts> fonts = new List<Fonts>();
            string sql = "select * from Fonts";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Fonts font = new Fonts();
                font.FontsId = (int)dr["FontsId"];
                font.FontsMess = dr["FontsMess"].ToString();
                fonts.Add(font);
            }
            dr.Close();
            DBHelper.Closecon();
            return fonts;
        }
        
    }
}
