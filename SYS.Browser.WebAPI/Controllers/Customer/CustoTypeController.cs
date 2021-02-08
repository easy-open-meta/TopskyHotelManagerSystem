using System.Collections.Generic;
using SYS.Core;
using SYS.Application;
using System.Web.Http;

namespace SYS.Browser.WebAPI.Controllers
{
    /// <summary>
    /// 客户类型控制器
    /// </summary>
    public class CustoTypeController:ApiController
    {
        #region 查询所有会员等级名称
        /// <summary>
        /// 查询所有会员等级名称
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<CustoType> SelectCustoTypesAll()
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
        [HttpGet]
        public string SelectTypeNameByCustoTypeId([FromUri]int CustoTypeId)
        {
            return CustoTypeService.SelectTypeNameByCustoTypeId(CustoTypeId);
        }
        #endregion

        #region 查询所有证件类型
        /// <summary>
        /// 查询所有证件类型
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<PassPortType> SelectPassPortTypeAll()
        {
            return CustoTypeService.SelectPassPortTypeAll();
        }
        #endregion

    }
}
