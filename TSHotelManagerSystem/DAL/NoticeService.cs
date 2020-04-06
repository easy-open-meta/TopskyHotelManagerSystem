using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSHotelManagerSystem.Models;

namespace TSHotelManagerSystem.DAL
{
   public class NoticeService
    {
        #region 获取所有公告信息
        /// <summary>
        /// 获取所有公告信息
        /// </summary>
        /// <returns></returns>
        public static List<Notice> SelectNoticeAll()
        {
            List<Notice> ntc = new List<Notice>();
            string sql = "select * from UPLOADINFO";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Notice ntcs = new Notice();
                ntcs.NoticeNo = (string)dr["NoticeNo"];
                ntcs.Noticetheme = dr["Noticetheme"].ToString();
                ntcs.NoticeTime = DateTime.Parse(dr["NoticeTime"].ToString());
                ntcs.NoticeContent = Convert.ToString(dr["NoticeContent"]);
                ntcs.NoticeClub = (string)dr["NoticeClub"];
                ntcs.NoticePerson = Convert.ToString(dr["NoticePerson"]);
                ntc.Add(ntcs);
            }
            dr.Close();
            DBHelper.Closecon();
            return ntc;
        }
        #endregion
    }
}
