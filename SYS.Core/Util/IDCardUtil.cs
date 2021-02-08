using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Core.Util
{
    /// <summary>
    /// 身份证号码工具类
    /// </summary>
    public class IDCardUtil
    {
        /// <summary>
        /// 查询地区码
        /// </summary>
        /// <param name="identityCard"></param>
        /// <returns></returns>
        public static string SelectCardCode(string identityCard)
        {
            var pcd = string.Empty;
            MySqlConnection con = DBHelper.GetConnection();
            con.Open();
            MySqlDataReader dr = DBHelper.ExecuteReader("select Province,City,District from CARDCODES where bm='" + identityCard.Substring(0, 6).ToString() + "'");
            while (dr.Read())
            {
                pcd = string.Join(",", dr["Province"].ToString() + dr["City"].ToString() + dr["District"].ToString());
            }
            dr.Close();
            con.Close();
            return pcd;
        }

    }
}
