using Core;
using System.Data.SqlClient;

namespace SYS.Application
{
    public class CustoTypeService
    {
        #region 根据会员等级编号查询会员等级名称
        /// <summary>
        /// 根据会员等级编号查询会员等级名称
        /// </summary>
        /// <param name="CustoTypeId"></param>
        /// <returns></returns>
        public static string SelectTypeNameByCustoTypeId(int CustoTypeId)
        {
            string name = "";
            string sql = "select * from USERTYPE where UserType=" + CustoTypeId;
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            if (dr.Read())
            {
                name = dr["TypeName"].ToString();
            }
            dr.Close();
            DBHelper.Closecon();
            return name;
        }
        #endregion
    }
}
