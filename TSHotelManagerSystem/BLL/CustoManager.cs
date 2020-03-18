using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSHotelManagerSystem.DAL;
using TSHotelManagerSystem.Models;

namespace TSHotelManagerSystem.BLL
{
   public class CustoManager
    {
        public static int InsertCusto(Custo cto)
        {
            int n = 0;
            string sql = "insert USERINFO(CustoNo,CustoName,CustoSex,CustoTel,PassportType,CustoID,CustoAdress,CustoBirth,CustoType) values(@CustoNo," +
                "@CustoName,@CustoSex,@CustoTel,@PassportType,@CustoID,@CustoAdress,@CustoBirth,@CustoType)";
            n = DBHelper.ExecuteNonQuery(sql, CommandType.Text,
                new SqlParameter[] {
                    new SqlParameter("@CustoNo",cto.CustoNo),
                    new SqlParameter("@CustoName",cto.CustoName),
                    new SqlParameter("@CustoSex",cto.CustoSex),
                    new SqlParameter("@CustoTel",cto.CustoTel),
                    new SqlParameter("@PassportType",cto.PassportType),
                    new SqlParameter("@CustoID",cto.CustoID),
                    new SqlParameter("@CustoAdress",cto.CustoAdress),
                    new SqlParameter("@CustoBirth",cto.CustoBirth),
                    new SqlParameter("@CustoType",cto.CustoType)
                });
            return n;
        }

        public static Custo SelectCardInfoByCustoNo(string CustoNo)
        {
            Custo c = null;
            string sql = "select * from USERINFO where CustoNo='" + CustoNo + "'";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
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
