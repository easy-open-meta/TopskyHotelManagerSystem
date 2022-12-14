/*
 * MIT License
 *Copyright (c) 2021 咖啡与网络(java-and-net)

 *Permission is hereby granted, free of charge, to any person obtaining a copy
 *of this software and associated documentation files (the "Software"), to deal
 *in the Software without restriction, including without limitation the rights
 *to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 *copies of the Software, and to permit persons to whom the Software is
 *furnished to do so, subject to the following conditions:

 *The above copyright notice and this permission notice shall be included in all
 *copies or substantial portions of the Software.

 *THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 *IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 *FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 *AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 *LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 *OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 *SOFTWARE.
 *
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using jvncorelib_fr.EncryptorLib;
using jvncorelib_fr.EntityLib;
using MySql.Data.MySqlClient;
using Npgsql;
using SYS.Common;
using SYS.Core;

namespace SYS.Application
{
    /// <summary>
    /// 客户信息接口实现类
    /// </summary>
    public class CustoService:Repository<Custo>, ICustoService
    {
        EncryptLib encryptLib = new EncryptLib();

        #region 添加客户信息
        /// <summary>
        /// 添加客户信息
        /// </summary>
        /// <param name="custo"></param>
        /// <returns></returns>
        public bool InsertCustomerInfo(Custo custo)
        {
            string NewID = encryptLib.Encryption(custo.CustoID);
            string NewTel = encryptLib.Encryption(custo.CustoTel);
            custo.CustoID = NewID;
            custo.CustoTel = NewTel;
            return base.Insert(custo);
        }
        #endregion

        /// <summary>
        /// 更新客户信息
        /// </summary>
        /// <param name="custo"></param>
        /// <returns></returns>
        public bool UpdCustomerInfoByCustoNo(Custo custo)
        {
            string NewID = encryptLib.Encryption(custo.CustoID);
            string NewTel = encryptLib.Encryption(custo.CustoTel);
            custo.CustoID = NewID;
            custo.CustoTel = NewTel;
            return base.Update(a => new Custo()
            {
                CustoName  = custo.CustoName,
                CustoSex = custo.CustoSex,
                CustoType = custo.CustoType,
                CustoBirth = custo.CustoBirth,
                CustoAdress = custo.CustoAdress,
                CustoID = custo.CustoID,
                CustoTel = custo.CustoTel,
                PassportType = custo.PassportType,
                datachg_usr = custo.datachg_usr,
                datachg_date = DateTime.Now
            },a => a.CustoNo == custo.CustoNo);
        }

        /// <summary>
        /// 更新客户类型(即会员等级)
        /// </summary>
        /// <param name="custoNo"></param>
        /// <param name="userType"></param>
        /// <returns></returns>
        public bool UpdCustomerTypeByCustoNo(string custoNo,int userType)
        {
            return base.Update(a => new Custo()
            {
                CustoType = userType
            }, a => a.CustoNo.Equals(custoNo));
        }

        /// <summary>
        /// 查询酒店盈利情况
        /// </summary>
        /// <returns></returns>
        public List<CustoSpend> SelectAllMoney()
        {
            List<CustoSpend> custoSpends = new List<CustoSpend>();
            var listSource = base.Change<Spend>().GetList(a => a.MoneyState.Equals(SpendConsts.Settled)).OrderBy(a => a.SpendTime).ToList();
            var listDates = new List<CustoSpend>();
            listSource.ForEach(source =>
            {
                var year = source.SpendTime.ToString("yyyy");
                if (!custoSpends.Select(a => a.Years).ToList().Contains(year))
                {
                    var startDate = new DateTime(source.SpendTime.Year, 1, 1, 0, 0, 0);
                    var endDate = new DateTime(source.SpendTime.Year, 12, 31, 23, 59, 59);
                    custoSpends.Add(new CustoSpend
                    {
                        Years = year,
                        Money = listSource.Where(a => a.SpendTime >= startDate && a.SpendTime <= endDate).Sum(a => a.SpendMoney)
                    });
                }
            });
            
            custoSpends = custoSpends.OrderBy(a => a.Years).ToList();
            return custoSpends;
        }

        /// <summary>
        /// 查询所有客户信息
        /// </summary>
        /// <returns></returns>
        public List<Custo> SelectCustoAll(ref int count,int? pageIndex,int? pageSize)
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

            if (!pageIndex.IsNullOrEmpty() && !pageSize.IsNullOrEmpty())
            {
                custos = base.AsQueryable().ToPageList((int)pageIndex, (int)pageSize, ref count).OrderBy(a => a.CustoNo).ToList();
            }
            else
            {
                custos = base.AsQueryable().OrderBy(a => a.CustoNo).ToList();
            }

            custos.ForEach(source =>
            {
                //解密身份证号码
                var sourceStr = source.CustoID.Contains("·") ? encryptLib.Decryption(source.CustoID) : source.CustoID;
                source.CustoID = sourceStr;
                //解密联系方式
                var sourceTelStr = source.CustoTel.Contains("·") ? encryptLib.Decryption(source.CustoTel) : source.CustoTel;
                source.CustoTel = sourceTelStr;
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

        /// <summary>
        /// 查询指定客户信息
        /// </summary>
        /// <returns></returns>
        public List<Custo> SelectCustoByInfo(Custo custo)
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
            if (!custo.CustoNo.IsNullOrEmpty())
            {
                custos = base.GetList(a => a.CustoNo.Contains(custo.CustoNo)).OrderBy(a => a.CustoNo).ToList();
            }
            if (!custo.CustoName.IsNullOrEmpty())
            {
                custos = base.GetList(a => a.CustoName.Contains(custo.CustoName)).OrderBy(a => a.CustoNo).ToList();
            }
            custos.ForEach(source =>
            {
                //解密身份证号码
                var sourceStr = source.CustoID.Contains("·") ? encryptLib.Decryption(source.CustoID) : source.CustoID;
                source.CustoID = sourceStr;
                //解密联系方式
                var sourceTelStr = source.CustoTel.Contains("·") ? encryptLib.Decryption(source.CustoTel) : source.CustoTel;
                source.CustoTel = sourceTelStr;
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

        /// <summary>
        /// 根据客户编号查询客户信息
        /// </summary>
        /// <param name="CustoNo"></param>
        /// <returns></returns>
        public Custo SelectCardInfoByCustoNo(string CustoNo)
        {
            Custo c = base.GetSingle(a => a.CustoNo.Contains(CustoNo));
            if (c.IsNullOrEmpty())
            {
                return null;
            }
            //性别类型
            var sexType = base.Change<SexType>().GetSingle(a => a.sexId == c.CustoSex);
            c.SexName = string.IsNullOrEmpty(sexType.sexName) ? "" : sexType.sexName;
            //证件类型
            var passPortType = base.Change<PassPortType>().GetSingle(a => a.PassportId == c.PassportType);
            c.PassportName = string.IsNullOrEmpty(passPortType.PassportName) ? "" : passPortType.PassportName;
            //客户类型
            var custoType = base.Change<CustoType>().GetSingle(a => a.UserType == c.CustoType);
            c.typeName = string.IsNullOrEmpty(custoType.TypeName) ? "" : custoType.TypeName;
            //解密身份证号码
            var sourceStr = c.CustoID.Contains("·") ? encryptLib.Decryption(c.CustoID) : c.CustoID;
            c.CustoID = sourceStr;
            //解密联系方式
            var sourceTelStr = c.CustoTel.Contains("·") ? encryptLib.Decryption(c.CustoTel) : c.CustoTel;
            c.CustoTel = sourceTelStr;
            return c;
        }

    }
}
