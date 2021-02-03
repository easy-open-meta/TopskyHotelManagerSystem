using System;
using System.Data;
using MySql.Data.MySqlClient;
using SYS.Core;
using SYS.Application;
using System.Collections.Generic;

namespace SYS.Manager
{
    public class CustoManager
    {
        #region 添加客户信息
        public static int InsertCustomerInfo(Custo custo)
        {
            return CustoService.InsertCustomerInfo(custo);
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<CustoSpend> SelectAllMoney()
        {
            return CustoService.SelectAllMoney();
        }

        public static List<Custo> SelectCustoAll()
        {
            return CustoService.SelectCustoAll();
        }


        public static Custo SelectCustoInfoByCardId(string input)
        {
            return CustoService.SelectCustoInfoByCardId(input);
        }

        public static Custo SelectCardInfoByCustoNo(string CustoNo)
        {
            return CustoService.SelectCardInfoByCustoNo(CustoNo);
        }


        public static List<Custo> SelectCanUseCustoAll()
        {
            return CustoService.SelectCanUseCustoAll();
        }

        #region 根据客户编号查询客户信息
        /// <summary>
        /// 根据客户编号查询客户信息
        /// </summary>
        /// <param name="cno"></param>
        /// <returns></returns>
        public static Custo SelectCustoByCustoNo(string cno)
        {
            return CustoService.SelectCustoByCustoNo(cno);
        }
        #endregion

        #region 随机客户编号（用于注册）
        /// <summary>
        /// 随机客户编号（用于注册）
        /// </summary>
        /// <returns></returns>
        public static string GetRandomCustoNo()
        {
            string CustoNo = "";
            Random rand = new Random();
            CustoNo = rand.NextDouble() + "";
            CustoNo = "TS1" + CustoNo.Substring(2, 3);
            Custo card = SelectCardInfoByCustoNo(CustoNo);
            while (card != null)
            {
                CustoNo = rand.NextDouble() + "";
                CustoNo = "TS1" + CustoNo.Substring(2, 3);
                card = SelectCardInfoByCustoNo(CustoNo);
            }
            return CustoNo;
        }
        #endregion
    }
}
