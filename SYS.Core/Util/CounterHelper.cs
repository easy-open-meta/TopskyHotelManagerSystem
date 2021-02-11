using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Core
{
    /// <summary>
    /// 流水号规则
    /// </summary>
    public class CounterHelper
    {
        /// <summary>
        /// 获取生成编号
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string GetNewId(string str)
        {
            var count = 0;
            var Str = string.Empty;
            string sql = string.Format("select * from counterrule where rule_name = '{0}'",str);
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Str = dr["prefix_name"].ToString() + dr["separating_char"].ToString() + DateTime.Now.ToString(dr["custo_format"].ToString())
                    + dr["number_format"].ToString() + dr["now_id"].ToString();
                count++;
            }
            dr.Close();
            DBHelper.Closecon();
            string sql1 = string.Format("update counterrule set now_id = now_id + {1} where rule_name = '{0}'", str,count);
            DBHelper.ExecuteNonQuery(sql1);
            return Str;
        }
    }
}
