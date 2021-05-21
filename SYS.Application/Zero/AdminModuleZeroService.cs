using SYS.Common;
using SYS.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Application
{
    /// <summary>
    /// 管理员模块权限管理接口实现类
    /// </summary>
    public class AdminModuleZeroService:Repository<ModuleZero>, IAdminModuleZeroService
    {
        /// <summary>
        /// 获取所有模块
        /// </summary>
        /// <returns></returns>
        public List<Module> GetAllModule()
        {
            List<Module> modules = base.Change<Module>().GetList();
            return modules;
        }

        /// <summary>
        /// 根据账号获取对应模块
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        public List<ModuleZero> GetAllModuleByAdmin(Admin admin)
        {
            List<ModuleZero> moduleZeros = base.GetList(a => a.admin_account.Equals(admin.AdminAccount)
            && a.module_enable == 1);
            return moduleZeros;
        }

        /// <summary>
        /// 批量添加模块
        /// </summary>
        /// <param name="moduleZeros"></param>
        /// <returns></returns>
        public bool AddModuleZeroList(List<ModuleZero> moduleZeros)
        {
            var result = base.InsertRange(moduleZeros);
            return result;
        }

        /// <summary>
        /// 批量删除模块
        /// </summary>
        /// <param name="moduleZero"></param>
        /// <returns></returns>
        public bool DelModuleZeroList(ModuleZero moduleZero)
        {
            var result = base.Delete(a => a.admin_account.Equals(moduleZero.admin_account));
            return result;
        }


    }
}
