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
            modules.ForEach(source =>
            {
                switch (source.module_name)
                {
                    case ModuleConsts.BaseInfo:
                        source.module_name = ModuleConsts.BaseInfo + "||" + "基础信息";
                        break;
                    case ModuleConsts.CashInfo:
                        source.module_name = ModuleConsts.CashInfo + "||" + "财务信息";
                        break;
                    case ModuleConsts.WtiInfo:
                        source.module_name = ModuleConsts.WtiInfo + "||" + "水电管理";
                        break;
                    case ModuleConsts.CheckInfo:
                        source.module_name = ModuleConsts.CheckInfo + "||" + "监管统计";
                        break;
                    case ModuleConsts.RoomManager:
                        source.module_name = ModuleConsts.RoomManager + "||" + "客房管理";
                        break;
                    case ModuleConsts.CustomerManager:
                        source.module_name = ModuleConsts.CustomerManager + "||" + "客户管理";
                        break;
                    case ModuleConsts.HumanResourcesManager:
                        source.module_name = ModuleConsts.HumanResourcesManager + "||" + "人事管理";
                        break;
                    case ModuleConsts.MaterialManager:
                        source.module_name = ModuleConsts.MaterialManager + "||" + "物资管理";
                        break;
                    case ModuleConsts.OperationLogManager:
                        source.module_name = ModuleConsts.OperationLogManager + "||" + "员工操作日志";
                        break;
                    case ModuleConsts.AdminManager:
                        source.module_name = ModuleConsts.AdminManager + "||" + "系统管理";
                        break;
                }
            });
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
            moduleZeros.ForEach(source =>
            {
                switch (source.module_name)
                {
                    case ModuleConsts.BaseInfo:
                        source.module_name = ModuleConsts.BaseInfo + "||" + "基础信息";
                        break;
                    case ModuleConsts.CashInfo:
                        source.module_name = ModuleConsts.CashInfo + "||" + "财务信息";
                        break;
                    case ModuleConsts.WtiInfo:
                        source.module_name = ModuleConsts.WtiInfo + "||" + "水电管理";
                        break;
                    case ModuleConsts.CheckInfo:
                        source.module_name = ModuleConsts.CheckInfo + "||" + "监管统计";
                        break;
                    case ModuleConsts.RoomManager:
                        source.module_name = ModuleConsts.RoomManager + "||" + "客房管理";
                        break;
                    case ModuleConsts.CustomerManager:
                        source.module_name = ModuleConsts.CustomerManager + "||" + "客户管理";
                        break;
                    case ModuleConsts.HumanResourcesManager:
                        source.module_name = ModuleConsts.HumanResourcesManager + "||" + "人事管理";
                        break;
                    case ModuleConsts.MaterialManager:
                        source.module_name = ModuleConsts.MaterialManager + "||" + "物资管理";
                        break;
                    case ModuleConsts.OperationLogManager:
                        source.module_name = ModuleConsts.OperationLogManager + "||" + "员工操作日志";
                        break;
                    case ModuleConsts.AdminManager:
                        source.module_name = ModuleConsts.AdminManager + "||" + "系统管理";
                        break;
                }
            });
            return moduleZeros;
        }

        /// <summary>
        /// 批量添加模块
        /// </summary>
        /// <param name="moduleZeros"></param>
        /// <returns></returns>
        public bool AddModuleZeroList(List<ModuleZero> moduleZeros)
        {
            moduleZeros.ForEach(moduleZero =>
            {
                moduleZero.module_name = moduleZero.module_name.Split('|','|').FirstOrDefault().ToString();
            });
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
