using MySql.Data.MySqlClient;
using SYS.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Application
{
    /// <summary>
    /// 酒店宣传联动内容
    /// </summary>
    public class FontsService
    {
        /// <summary>
        /// 查询所有宣传联动内容(跑马灯)
        /// </summary>
        /// <returns></returns>
        public static List<Fonts> SelectFontAll()
        {
            List<Fonts> fonts = new List<Fonts>();
            string sql = "select * from Fonts";
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
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
