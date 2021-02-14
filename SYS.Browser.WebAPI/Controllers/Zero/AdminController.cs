using SYS.Core;
using SYS.Application;
using System.Web.Http;

namespace SYS.Browser.WebAPI.Controllers
{
    /// <summary>
    /// 后台管理员信息控制器
    /// </summary>
    public class AdminController: ApiController
    {
        #region 根据超管密码查询管理类型和权限
        /// <summary>
        /// 根据超管密码查询管理类型和权限
        /// </summary>
        /// <param name="adminaccount"></param>
        /// <param name="adminpass"></param>
        /// <returns></returns>
        [HttpPost]
        public Admin SelectMangerByPass([FromBody]string adminaccount, string adminpass)
        {
            return new AdminService().SelectMangerByPass(adminaccount,adminpass);
        }
        #endregion

    }
}
