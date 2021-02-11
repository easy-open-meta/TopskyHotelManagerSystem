using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using SYS.Common;
using SYS.Core;

namespace SYS.Application
{
    /// <summary>
    /// 客户信息接口实现类
    /// </summary>
    public class CustoService:Repository<Custo>, ICustoService
    {
        #region 添加客户信息
        /// <summary>
        /// 添加客户信息
        /// </summary>
        /// <param name="custo"></param>
        /// <returns></returns>
        public bool InsertCustomerInfo(Custo custo)
        {
            string NewID = Md5LockedUtil.MD5Encrypt32(custo.CustoID);
            string NewTel = Md5LockedUtil.MD5Encrypt32(custo.CustoTel);
            custo.CustoID = NewID;
            custo.CustoTel = NewTel;
            return base.Insert(custo);
        }
        #endregion

        /// <summary>
        /// 查询酒店盈利情况
        /// </summary>
        /// <returns></returns>
        public List<CustoSpend> SelectAllMoney()
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

        /// <summary>
        /// 查询所有客户信息
        /// </summary>
        /// <returns></returns>
        public List<Custo> SelectCustoAll()
        {
            //查询出所有性别类型
            List<SexType> sexTypes = new List<SexType>();
            sexTypes = base.Change<SexType>().GetList();
            //查询出所有证件类型
            List<PassPortType> passPortTypes = new List<PassPortType>();
            passPortTypes = base.Change<PassPortType>().GetList();
            //查询出所有客户类型
            List<CustoType> custoTypes = new List<CustoType>();
            custoTypes = base.Change<CustoType>().GetList();
            //查询出所有客户信息
            List<Custo> custos = new List<Custo>();
<<<<<<< HEAD
            string sql = "select * from USERINFO u,USERTYPE t,PASSPORTTYPE p,sextype s where u.CustoType=t.UserType and u.PassportType=p.PassportId and s.sexId = u.CustoSex";
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
=======
            custos = base.GetList().OrderBy(a => a.CustoNo).ToList();
            custos.ForEach(source =>
>>>>>>> InitProject_v1.4.8_happy_new_year
            {
                //性别类型
                var sexType = sexTypes.FirstOrDefault(a => a.sexId == source.CustoSex);
                source.SexName = string.IsNullOrEmpty(sexType.sexName) ? "" : sexType.sexName;
                //证件类型
                var passPortType = passPortTypes.FirstOrDefault(a => a.PassportId == source.PassportType);
                source.PassportName = string.IsNullOrEmpty(passPortType.PassportName) ? "" : passPortType.PassportName;
                //客户类型
                var custoType = custoTypes.FirstOrDefault(a => a.UserType == source.CustoType);
                source.typeName = string.IsNullOrEmpty(custoType.TypeName) ? "" : custoType.TypeName;
            });
            return custos;
        }

<<<<<<< HEAD
        #region 根据客户编号查询客户信息
=======
>>>>>>> InitProject_v1.4.8_happy_new_year
        /// <summary>
        /// 根据客户编号查询客户信息
        /// </summary>
        /// <param name="CustoNo"></param>
        /// <returns></returns>
        public Custo SelectCardInfoByCustoNo(string CustoNo)
        {
            Custo c = new Custo();
            c = base.GetSingle(a => a.CustoNo.Equals(CustoNo) && a.delete_mk != 1);
            //性别类型
            var sexType = base.Change<SexType>().GetSingle(a => a.sexId == c.CustoSex);
            c.SexName = string.IsNullOrEmpty(sexType.sexName) ? "" : sexType.sexName;
            //证件类型
            var passPortType = base.Change<PassPortType>().GetSingle(a => a.PassportId == c.PassportType);
            c.PassportName = string.IsNullOrEmpty(passPortType.PassportName) ? "" : passPortType.PassportName;
            //客户类型
            var custoType = base.Change<CustoType>().GetSingle(a => a.UserType == c.CustoType);
            c.typeName = string.IsNullOrEmpty(custoType.TypeName) ? "" : custoType.TypeName;
            return c;
        }

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="input"></param>
        ///// <returns></returns>
        //public static Custo SelectCustoInfoByCardId(string input)
        //{
        //    Custo cto = new Custo();
        //    string sql = "select * from USERINFO u,PASSPORTTYPE p,USERTYPE ut where u.PassportType=p.PassportId and u.CustoType=ut.UserType and u.CustoNo = '" + input + "'";
        //    MySqlDataReader dr = DBHelper.ExecuteReader(sql);
        //    if (dr.Read())
        //    {
        //        cto = new Custo() 
        //        {
        //            CustoNo = (string)dr["CustoNo"],
        //            CustoName = (string)dr["CustoName"],
        //            CustoSex = Convert.ToInt32(dr["CustoSex"]),
        //            CustoTel = (string)dr["CustoTel"],
        //            PassportType = Convert.ToInt32(dr["PassportType"]),
        //            PassportName = (string)dr["PassportName"],
        //            CustoID = (string)dr["CustoID"],
        //            CustoAdress = (string)dr["CustoAdress"],
        //            CustoBirth = DateTime.Parse(dr["CustoBirth"].ToString()),
        //            CustoType = Convert.ToInt32(dr["CustoType"]),
        //            typeName = (string)dr["TypeName"],
        //        };
                
        //    }
        //    dr.Close();
        //    DBHelper.Closecon();
        //    return cto;
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <returns></returns>
        //public static List<Custo> SelectCanUseCustoAll()
        //{
        //    List<Custo> custos = new List<Custo>();
        //    string sql = "select * from USERINFO";
        //    MySqlDataReader dr = DBHelper.ExecuteReader(sql);
        //    while (dr.Read())
        //    {
        //        Custo custo = new Custo();
        //        custo.CustoNo = (string)dr["CustoNo"];
        //        custos.Add(custo);
        //    }
        //    dr.Close();
        //    DBHelper.Closecon();
        //    return custos;
        //}
    }
}
