using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SYS.Core;

namespace SYS.Application
{
    public class CustoService
    {
        #region 添加客户信息
        public static int InsertCustomerInfo(Custo custo)
        {
            string NewID = Md5LockedUtil.MD5Encrypt32(custo.CustoID);
            string NewTel = Md5LockedUtil.MD5Encrypt32(custo.CustoTel);

            string sql = "insert USERINFO(CustoNo,CustoName,CustoSex,CustoTel,PassportType,CustoID,CustoAdress,CustoBirth,CustoType)";
            sql += " values('" + custo.CustoNo + "','" + custo.CustoName + "','" + custo.CustoSex + "','" + NewTel + "','" + custo.PassportType + "','" + NewID + "','" + custo.CustoAdress + "','" + custo.CustoBirth + "','" + custo.CustoType + "') ";
            
            return DBHelper.ExecuteNonQuery(sql);
        }
        #endregion

        public static List<CustoSpend> SelectAllMoney()
        {
            List<CustoSpend> custos = new List<CustoSpend>();
            string sql = "select year(spendtime) as 年份,sum(spendmoney) as 总额 from CustoSpend group by year(spendtime)";
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                CustoSpend cso = new CustoSpend();
                cso.Years = dr["年份"].ToString();
                cso.Money = (decimal)dr["总额"];
                custos.Add(cso);
            }
            dr.Close();
            DBHelper.Closecon();
            return custos;
        }

        public static List<Custo> SelectCustoAll()
        {
            List<Custo> custos = new List<Custo>();
            string sql = "select * from USERINFO u,USERTYPE t,PASSPORTTYPE p,sextype s where u.CustoType=t.UserType and u.PassportType=p.PassportId and s.sexId = u.CustoSex order by u.CustoNo asc";
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Custo cso = new Custo();
                cso.CustoNo = (string)dr["CustoNo"];
                cso.CustoName = dr["CustoName"].ToString();
                cso.SexName = Convert.ToString(dr["SexName"]);
                cso.CustoTel = Convert.ToString(dr["CustoTel"]);
                cso.PassportType = Convert.ToInt32(dr["PassportType"]);
                cso.CustoID = dr["CustoID"].ToString();
                if (!DBNull.Value.Equals(dr["CustoAdress"]))
                {
                    cso.CustoAdress = (string)dr["CustoAdress"];
                }
                else
                {
                    cso.CustoAdress = "";
                }
                cso.CustoBirth = DateTime.Parse(dr["CustoBirth"].ToString());
                cso.CustoType = Convert.ToInt32(dr["CustoType"]);
                cso.typeName = (string)dr["TypeName"];
                cso.PassportName = (string)dr["PassportName"];
                custos.Add(cso);
            }
            dr.Close();
            DBHelper.Closecon();
            return custos;
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
            Custo cto = null;
            MySqlConnection con = DBHelper.GetConnection();
            con.Open();
            MySqlDataReader dr = DBHelper.ExecuteReader("select * from USERINFO where CustoNo='" + cno + "'");
            if (dr.Read())
            {
                cto = new Custo();
                cto.CustoNo = dr["CustoNo"].ToString();
                cto.CustoName = dr["CustoName"].ToString();
                cto.CustoSex = Convert.ToInt32(dr["CustoSex"]);
                cto.CustoTel = dr["CustoTel"].ToString();
                cto.PassportType = Convert.ToInt32(dr["PassportType"].ToString());
                cto.CustoID = dr["CustoID"].ToString();
                cto.CustoAdress = dr["CustoAdress"].ToString();
                cto.CustoBirth = DateTime.Parse(dr["CustoBirth"].ToString());
                cto.CustoType = Convert.ToInt32(dr["CustoType"].ToString());
            }
            dr.Close();
            DBHelper.Closecon();
            return cto;
        }
        #endregion

        public static Custo SelectCustoInfoByCardId(string input)
        {
            Custo cto = null;
            string sql = "select * from USERINFO u,PASSPORTTYPE p,USERTYPE ut where u.PassportType=p.PassportId and u.CustoType=ut.UserType and CustoID = '" + input + "'";
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
            if (dr.Read())
            {
                cto = new Custo();
                cto.CustoNo = (string)dr["CustoNo"];
                cto.CustoName = (string)dr["CustoName"];
                cto.CustoSex = Convert.ToInt32(dr["CustoSex"]);
                cto.CustoTel = (string)dr["CustoTel"];
                cto.PassportType = Convert.ToInt32(dr["PassportType"]);
                cto.PassportName = (string)dr["PassportName"];
                cto.CustoID = (string)dr["CustoID"];
                cto.CustoAdress = (string)dr["CustoAdress"];
                cto.CustoBirth = DateTime.Parse(dr["CustoBirth"].ToString());
                cto.CustoType = Convert.ToInt32(dr["CustoType"]);
                cto.typeName = (string)dr["TypeName"];
            }
            dr.Close();
            DBHelper.Closecon();
            return cto;
        }

        public static List<Custo> SelectCanUseCustoAll()
        {
            List<Custo> custos = new List<Custo>();
            string sql = "select * from USERINFO";
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Custo custo = new Custo();
                custo.CustoNo = (string)dr["CustoNo"];
                custos.Add(custo);
            }
            dr.Close();
            DBHelper.Closecon();
            return custos;
        }
    }
}
