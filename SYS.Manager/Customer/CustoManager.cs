using System;
using System.Data;
using MySql.Data.MySqlClient;
using SYS.Core;
using SYS.Application;

namespace SYS.Manager
{
    public class CustoManager
    {
        public static int InsertCusto(Custo cto)
        {
            int n = 0;
            string sql = "insert USERINFO(CustoNo,CustoName,CustoSex,CustoTel,PassportType,CustoID,CustoAdress,CustoBirth,CustoType) values(@CustoNo," +
                "@CustoName,@CustoSex,@CustoTel,@PassportType,@CustoID,@CustoAdress,@CustoBirth,@CustoType)";
            n = DBHelper.ExecuteNonQuery(sql, CommandType.Text,
                new MySqlParameter[] {
                    new MySqlParameter("@CustoNo",cto.CustoNo),
                    new MySqlParameter("@CustoName",cto.CustoName),
                    new MySqlParameter("@CustoSex",cto.CustoSex),
                    new MySqlParameter("@CustoTel",cto.CustoTel),
                    new MySqlParameter("@PassportType",cto.PassportType),
                    new MySqlParameter("@CustoID",cto.CustoID),
                    new MySqlParameter("@CustoAdress",cto.CustoAdress),
                    new MySqlParameter("@CustoBirth",cto.CustoBirth),
                    new MySqlParameter("@CustoType",cto.CustoType)
                });
            return n;
        }

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
                c.CustoSex = Convert.ToString(dr["CustoSex"]);
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
