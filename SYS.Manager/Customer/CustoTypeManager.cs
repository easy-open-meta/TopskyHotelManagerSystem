﻿using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SYS.Core;
using SYS.Application;

namespace SYS.Manager
{
    public class CustoTypeManager
    {
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

        #region 根据会员等级编号查询会员等级名称
        /// <summary>
        /// 根据会员等级编号查询会员等级名称
        /// </summary>
        /// <param name="CustoTypeId"></param>
        /// <returns></returns>
        public static string SelectTypeNameByCustoTypeId(int CustoTypeId)
        {
            return CustoTypeService.SelectTypeNameByCustoTypeId(CustoTypeId);
        }
        #endregion
    }
}