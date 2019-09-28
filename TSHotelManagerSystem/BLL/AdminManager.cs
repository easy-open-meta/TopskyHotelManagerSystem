using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSHotelManagerSystem.DAL;
using TSHotelManagerSystem.Models;

namespace TSHotelManagerSystem.BLL
{
   public class AdminManager
    {
        #region 根据超管密码查询管理类型和权限
        /// <summary>
        /// 根据超管密码查询管理类型和权限
        /// </summary>
        /// <param name="workerId"></param>
        /// <returns></returns>
        public static Admin SelectMangerByPass(string adminpass)
        {
            return AdminService.SelectMangerByPass(adminpass);
        }
        #endregion

        #region 根据超管密码查询超管信息
        /// <summary>
        /// 根据超管密码查询超管信息
        /// </summary>
        /// <param name="id"></param>
        /// 登录名称
        /// <returns></returns>
        public static Admin SelectAdminInfoByadminpwd(string pwd)
        {
            return AdminService.SelectAdminInfoByadminpwd(pwd);
        }
        #endregion
    }
}
