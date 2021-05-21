using System;
using System.Data;
using SYS.Core;
using SYS.Application;
using System.Collections.Generic;
using System.Web.Http;

namespace SYS.Browser.WebAPI.Controllers
{
    /// <summary>
    /// 客户信息控制器
    /// </summary>
    public class CustoController:ApiController
    {
        #region 添加客户信息
        /// <summary>
        /// 添加客户信息
        /// </summary>
        /// <param name="custo"></param>
        /// <returns></returns>
        [HttpPost]
        public bool InsertCustomerInfo([FromBody]Custo custo)
        {
            return new CustoService().InsertCustomerInfo(custo);
        }
        #endregion

        /// <summary>
        /// 查询酒店盈利情况
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<CustoSpend> SelectAllMoney()
        {
            return new CustoService().SelectAllMoney();
        }
        /// <summary>
        /// 查询所有客户信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Custo> SelectCustoAll()
        {
            return new CustoService().SelectCustoAll();
        }
        /// <summary>
        /// 根据客户编号查询证件号码
        /// </summary>
        /// <param name="CustoNo"></param>
        /// <returns></returns>
        [HttpGet]
        public Custo SelectCardInfoByCustoNo([FromUri]string CustoNo)
        {
            return new CustoService().SelectCardInfoByCustoNo(CustoNo);
        }

    }
}
