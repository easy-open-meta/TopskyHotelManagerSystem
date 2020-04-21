using System.Data.SqlClient;
using TSHotelManagerSystem.Models;

namespace TSHotelManagerSystem.DAL
{
    public class AdminService
    {
        #region 根据超管密码查询员工类型和权限
        /// <summary>
        /// 根据超管密码查询员工类型和权限
        /// </summary>
        /// <param name="workerId"></param>
        /// <returns></returns>
        public static Admin SelectMangerByPass(string adminpass)
        {
            Admin a = null;
            string sql = "select * from ADMININFO where AdminPassword='" + adminpass + "'";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            if (dr.Read())
            {
                a = new Admin();
                a.AdminPassword = (string)dr["AdminPassword"];
                a.AdminType = dr["AdminType"].ToString();
                a.AdminGroup = dr["AdminName"].ToString();
            }
            dr.Close();
            DBHelper.Closecon();
            return a;
        }
        #endregion

        #region 根据超管密码查询超管信息
        /// <summary>
        /// 根据超管密码查询超管信息
        /// </summary>
        /// <param name="pwd"></param>
        /// 超管密码
        /// <returns></returns>
        public static Admin SelectAdminInfoByadminpwd(string pwd)
        {
            Admin a = null;
            string sql = "select * from ADMININFO where AdminPassword='{0}'";
            sql = string.Format(sql, pwd);
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            if (dr.Read())
            {
                a = new Admin();
                a.AdminPassword = (string)dr["WorkerId"];
                a.AdminType = dr["WorkerName"].ToString();
            }
            dr.Close();
            DBHelper.Closecon();
            return a;
        }
        #endregion
    }
}
