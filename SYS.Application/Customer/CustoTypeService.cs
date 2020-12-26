using SYS.Core;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

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
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
            if (dr.Read())
            {
                name = dr["TypeName"].ToString();
            }
            dr.Close();
            DBHelper.Closecon();
            return name;
        }
        #endregion

        #region 查询所有会员等级名称
        /// <summary>
        /// 查询所有会员等级名称
        /// </summary>
        /// <returns></returns>
        public static List<CustoType> SelectCustoTypesAll()
        {
            List<CustoType> types = new List<CustoType>();
            string sql = "select * from USERTYPE";
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
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
        #endregion

        #region 查询所有证件类型
        /// <summary>
        /// 查询所有证件类型
        /// </summary>
        /// <returns></returns>
        public static List<PassPortType> SelectPassPortTypeAll()
        {
            List<PassPortType> passTypes = new List<PassPortType>();
            string sql = "select * from Passporttype";
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                PassPortType type = new PassPortType();
                type.PassportId = (int)dr["PassportId"];
                type.PassportName = dr["PassportName"].ToString();
                passTypes.Add(type);
            }
            dr.Close();
            DBHelper.Closecon();

            return passTypes;
        }
        #endregion

        #region 查询所有性别类型
        /// <summary>
        /// 查询所有性别类型
        /// </summary>
        /// <returns></returns>
        public static List<SexType> SelectSexTypeAll()
        {
            List<SexType> sexTypes = new List<SexType>();
            string sql = "select * from sextype";
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                SexType type = new SexType();
                type.sexId = (int)dr["sexId"];
                type.sexName = dr["sexName"].ToString();
                sexTypes.Add(type);
            }
            dr.Close();
            DBHelper.Closecon();

            return sexTypes;
        }
        #endregion
    }
}
