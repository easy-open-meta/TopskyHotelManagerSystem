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
        public int InsertCustomerInfo([FromBody]Custo custo)
        {
            return CustoService.InsertCustomerInfo(custo);
        }
        #endregion

        /// <summary>
        /// 查询酒店盈利情况
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<CustoSpend> SelectAllMoney()
        {
            return CustoService.SelectAllMoney();
        }
        /// <summary>
        /// 查询所有客户信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Custo> SelectCustoAll()
        {
            return CustoService.SelectCustoAll();
        }
        /// <summary>
        /// 根据证件号码查询客户信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>

        [HttpGet]
        public Custo SelectCustoInfoByCardId([FromUri]string input)
        {
            return CustoService.SelectCustoInfoByCardId(input);
        }

        /// <summary>
        /// 根据客户编号查询证件号码
        /// </summary>
        /// <param name="CustoNo"></param>
        /// <returns></returns>
        [HttpGet]
        public Custo SelectCardInfoByCustoNo([FromUri]string CustoNo)
        {
            return CustoService.SelectCardInfoByCustoNo(CustoNo);
        }

        /// <summary>
        /// 查询可消费的客户信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Custo> SelectCanUseCustoAll()
        {
            return CustoService.SelectCanUseCustoAll();
        }

        #region 根据客户编号查询客户信息
        /// <summary>
        /// 根据客户编号查询客户信息
        /// </summary>
        /// <param name="cno"></param>
        /// <returns></returns>
        [HttpGet]
        public Custo SelectCustoByCustoNo([FromUri]string cno)
        {
            return CustoService.SelectCustoByCustoNo(cno);
        }
        #endregion

    }
}
