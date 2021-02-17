using SYS.Core;

namespace SYS.Application
{
    /// <summary>
    /// 管理员数据访问接口
    /// </summary>
    public interface IAdminService
    {

        #region 根据超管密码查询员工类型和权限
        /// <summary>
        /// 根据超管密码查询员工类型和权限
        /// </summary>
        /// <param name="adminaccount"></param>
        /// <param name="adminpass"></param>
        /// <returns></returns>
        Admin SelectMangerByPass(string adminaccount, string adminpass);
        #endregion


        #region 根据超管账号查询对应的密码
        /// <summary>
        /// 根据超管账号查询对应的密码
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        Admin SelectAdminPwdByAccount(string account);
        #endregion


        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="Account"></param>
        /// <param name="NewPwd"></param>
        /// <returns></returns>
        bool UpdateNewPwdByOldPwd(string Account, string NewPwd);
    }
}