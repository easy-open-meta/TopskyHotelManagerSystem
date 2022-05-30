using SYS.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Application
{
    /// <summary>
    /// 管理员模块权限管理接口
    /// </summary>
    public interface IAdminModuleZeroService
    {
        /// <summary>
        /// 获取所有模块
        /// </summary>
        /// <returns></returns>
        List<Module> GetAllModule();

        /// <summary>
        /// 根据账号获取对应模块
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        List<ModuleZero> GetAllModuleByAdmin(Admin admin);

        /// <summary>
        /// 批量添加模块
        /// </summary>
        /// <param name="moduleZeros"></param>
        /// <returns></returns>
        bool AddModuleZeroList(List<ModuleZero> moduleZeros);

        /// <summary>
        /// 批量删除模块
        /// </summary>
        /// <param name="moduleZero"></param>
        /// <returns></returns>
        bool DelModuleZeroList(ModuleZero moduleZero);

    }
}
