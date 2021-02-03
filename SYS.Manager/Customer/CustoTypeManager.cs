using System.Collections.Generic;
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
            return CustoTypeService.SelectCustoTypesAll();
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

        #region 查询所有证件类型
        /// <summary>
        /// 查询所有证件类型
        /// </summary>
        /// <returns></returns>
        public static List<PassPortType> SelectPassPortTypeAll()
        {
            return CustoTypeService.SelectPassPortTypeAll();
        }
        #endregion

    }
}
