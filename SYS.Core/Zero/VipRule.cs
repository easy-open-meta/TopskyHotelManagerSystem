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
 *模块说明：会员等级规则类
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Core
{
    /// <summary>
    /// 会员等级规则类
    /// </summary>
    [SqlSugar.SugarTable("vip_rule")]
    public class VipRule
    {
        /// <summary>
        /// 索引ID
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 会员规则流水号
        /// </summary>
        public string rule_id { get; set; }

        /// <summary>
        /// 会员规则名称
        /// </summary>
        public string rule_name { get; set; }

        /// <summary>
        /// 预设数值(历史消费总额)
        /// </summary>
        public decimal rule_value { get; set; }

        /// <summary>
        /// 会员等级
        /// </summary>
        public int type_id { get; set; }

        /// <summary>
        /// 删除标识
        /// </summary>
        public int delete_mk { get; set; }
        /// <summary>
        /// 新增人
        /// </summary>
        public string datains_usr { get; set; }

        /// <summary>
        /// 新增时间
        /// </summary>
        public DateTime datains_date { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        public string datachg_usr { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime datachg_date { get; set; }

        /// <summary>
        /// 会员等级描述
        /// </summary>
        [SqlSugar.SugarColumn(IsIgnore = true)]
        public string type_name { get; set; }
    }
}
