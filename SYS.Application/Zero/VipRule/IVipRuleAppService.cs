/*
 * MIT License
 *Copyright (c) 2021 咖啡与网络(java-and-net)

 *Permission is hereby granted, free of charge, to any person obtaining a copy
 *of this software and associated documentation files (the "Software"), to deal
 *in the Software without restriction, including without limitation the rights
 *to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 *copies of the Software, and to permit persons to whom the Software is
 *furnished to do so, subject to the following conditions:

 *The above copyright notice and this permission notice shall be included in all
 *copies or substantial portions of the Software.

 *THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 *IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 *FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 *AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 *LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 *OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 *SOFTWARE.
 *
 *模块说明：会员等级规则功能模块接口
 */
using SYS.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Application.Zero
{
    /// <summary>
    /// 会员等级规则功能模块接口
    /// </summary>
    public interface IVipRuleAppService
    {
        /// <summary>
        /// 查询会员等级规则列表
        /// </summary>
        /// <returns></returns>
        List<VipRule> SelectVipRuleList();

        /// <summary>
        /// 查询会员等级规则
        /// </summary>
        /// <param name="vipRule"></param>
        /// <returns></returns>
        VipRule SelectVipRule(VipRule vipRule);

        /// <summary>
        /// 添加会员等级规则
        /// </summary>
        /// <param name="vipRule"></param>
        /// <returns></returns>
        bool AddVipRule(VipRule vipRule);

        /// <summary>
        /// 删除会员等级规则
        /// </summary>
        /// <param name="vipRule"></param>
        /// <returns></returns>
        bool DelVipRule(VipRule vipRule);

        /// <summary>
        /// 更新会员等级规则
        /// </summary>
        /// <param name="vipRule"></param>
        /// <returns></returns>
        bool UpdVipRule(VipRule vipRule);
    }
}
