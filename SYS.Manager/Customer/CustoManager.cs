using System;
using System.Data;
using MySql.Data.MySqlClient;
using SYS.Core;
using SYS.Application;

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


        public static Custo SelectCardInfoByCustoNo(string CustoNo)
        {
            Custo c = null;
            string sql = "select * from USERINFO where CustoNo='" + CustoNo + "'";
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
            if (dr.Read())
            {
                c = new Custo();
                c.CustoNo = Convert.ToString(dr["CustoNo"]);
                c.CustoName = Convert.ToString(dr["CustoName"]);
                c.CustoSex = Convert.ToInt32(dr["CustoSex"]);
                c.CustoTel = Convert.ToString(dr["CustoTel"]);
                c.CustoID = Convert.ToString(dr["CustoID"]);
                c.CustoAdress = Convert.ToString(dr["CustoAdress"]);
                c.CustoBirth = Convert.ToDateTime(dr["CustoBirth"]);
                c.CustoType = Convert.ToInt32(dr["CustoType"]);
            }
            dr.Close();
            DBHelper.Closecon();
            return c;
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
