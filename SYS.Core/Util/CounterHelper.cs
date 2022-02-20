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
 *模块说明：流水号规则
 */
using MySql.Data.MySqlClient;
using SYS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Core
{
    /// <summary>
    /// 流水号规则
    /// </summary>
    public class CounterHelper:Repository<counterrule>
    {
        /// <summary>
        /// 获取生成编号
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string GetNewId(string str)
        {
            var count = 0;
            var Str = string.Empty;
            counterrule counterrule = new counterrule();
            counterrule = base.GetSingle(a => a.rule_name == str);
            Str = counterrule.prefix_name + counterrule.separating_char + DateTime.Now.ToString(counterrule.custo_format)
                    + counterrule.number_format + counterrule.now_id;
            count++;
            var exe2 = base.Update(a => new counterrule()
            {
                now_id = counterrule.now_id + count
            },a => a.rule_name == str);
            return Str;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class counterrule
    {
        /// <summary>
        /// 
        /// </summary>
        public counterrule()
        {
        }

        private System.Int32 _rule_id;
        /// <summary>
        /// 规则编号
        /// </summary>
        public System.Int32 rule_id { get { return this._rule_id; } set { this._rule_id = value; } }

        private System.String _rule_name;
        /// <summary>
        /// 规格名称
        /// </summary>
        public System.String rule_name { get { return this._rule_name; } set { this._rule_name = value; } }

        private System.String _rule_desc;
        /// <summary>
        /// 规则描述
        /// </summary>
        public System.String rule_desc { get { return this._rule_desc; } set { this._rule_desc = value; } }

        private System.Int32? _now_id;
        /// <summary>
        /// 当前ID
        /// </summary>
        public System.Int32? now_id { get { return this._now_id; } set { this._now_id = value; } }

        private System.String _prefix_name;
        /// <summary>
        /// 规则简写
        /// </summary>
        public System.String prefix_name { get { return this._prefix_name; } set { this._prefix_name = value; } }

        private System.String _custo_format;
        /// <summary>
        /// 规则格式
        /// </summary>
        public System.String custo_format { get { return this._custo_format; } set { this._custo_format = value; } }

        private System.String _number_format;
        /// <summary>
        /// 编号前缀
        /// </summary>
        public System.String number_format { get { return this._number_format; } set { this._number_format = value; } }

        private System.String _separating_char;
        /// <summary>
        /// 规则分割符
        /// </summary>
        public System.String separating_char { get { return this._separating_char; } set { this._separating_char = value; } }

        private System.String _datains_usrid;
        /// <summary>
        /// 资料新增人
        /// </summary>
        public System.String datains_usrid { get { return this._datains_usrid; } set { this._datains_usrid = value; } }

        private System.DateTime? _datains_time;
        /// <summary>
        /// 资料新增时间
        /// </summary>
        public System.DateTime? datains_time { get { return this._datains_time; } set { this._datains_time = value; } }

        private System.String _datachg_usrid;
        /// <summary>
        /// 资料更新人
        /// </summary>
        public System.String datachg_usrid { get { return this._datachg_usrid; } set { this._datachg_usrid = value; } }

        private System.DateTime? _datachg_time;
        /// <summary>
        /// 资料更新时间
        /// </summary>
        public System.DateTime? datachg_time { get { return this._datachg_time; } set { this._datachg_time = value; } }
    }
}
