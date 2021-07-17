using SYS.Common;
using SYS.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Application.Zero
{
    /// <summary>
    /// 会员等级规则功能模块接口实现类
    /// </summary>
    public class VipRuleAppService:Repository<VipRule>, IVipRuleAppService
    {
        /// <summary>
        /// 查询会员等级规则列表
        /// </summary>
        /// <returns></returns>
        public List<VipRule> SelectVipRuleList()
        {
            List<VipRule> vipRules = new List<VipRule>();

            var listSource = base.GetList(a => a.delete_mk != 1);

            var listUserType = base.Change<CustoType>().GetList(a => a.delete_mk != 1);

            listSource.ForEach(source =>
            {
                var userType = listUserType.FirstOrDefault(a => a.UserType == source.type_id);
                source.type_name = userType == null ? "" : userType.TypeName;
            });

            vipRules = listSource;

            return vipRules;
        }

        /// <summary>
        /// 查询会员等级规则
        /// </summary>
        /// <param name="vipRule"></param>
        /// <returns></returns>
        public VipRule SelectVipRule(VipRule vipRule)
        {
            VipRule vipRule1 = new VipRule();

            var source = base.GetSingle(a => a.rule_id.Equals(vipRule.rule_id));

            var userType = base.Change<CustoType>().GetSingle(a => a.UserType == source.type_id);
            source.type_name = userType == null ? "" : userType.TypeName;

            vipRule1 = source;

            return vipRule1;
        }

        /// <summary>
        /// 添加会员等级规则
        /// </summary>
        /// <param name="vipRule"></param>
        /// <returns></returns>
        public bool AddVipRule(VipRule vipRule)
        {
            return base.Insert(new VipRule() 
            {
                rule_id = vipRule.rule_id,
                rule_name = vipRule.rule_name,
                rule_value = vipRule.rule_value,
                type_id = vipRule.type_id,
                delete_mk = 0,
                datains_usr = AdminInfo.Account,
                datains_date = DateTime.Now
            });
        }

        /// <summary>
        /// 删除会员等级规则
        /// </summary>
        /// <param name="vipRule"></param>
        /// <returns></returns>
        public bool DelVipRule(VipRule vipRule)
        {
            return base.Update(a => new VipRule
            {
                delete_mk = 1,
                datachg_usr = AdminInfo.Account,
                datachg_date = DateTime.Now
            },a => a.rule_id == vipRule.rule_id);
        }

        /// <summary>
        /// 更新会员等级规则
        /// </summary>
        /// <param name="vipRule"></param>
        /// <returns></returns>
        public bool UpdVipRule(VipRule vipRule)
        {
            return base.Update(a => new VipRule
            {
                rule_name = vipRule.rule_name,
                rule_value = vipRule.rule_value,
                delete_mk = vipRule.delete_mk,
                datachg_usr = AdminInfo.Account,
                datachg_date = DateTime.Now
            }, a => a.rule_id == vipRule.rule_id);
        }
    }
}
