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
 *模块说明：奖惩类型类
 */
using System;

namespace SYS.Application
{
    /// <summary>
    /// 奖惩类型实体类
    /// </summary>
    public class GBType
    {
        /// <summary>
        /// 奖惩编号
        /// </summary>
        public int GBTypeId { get; set; }

        /// <summary>
        /// 奖惩名称
        /// </summary>
        public string GBName { get; set; }

        /// <summary>
        /// 删除标记
        /// </summary>
        public int delete_mk { get; set; }

        /// <summary>
        /// 资料新增人
        /// </summary>
        public string datains_usr { get; set; }

        /// <summary>
        /// 资料新增日期
        /// </summary>
        public DateTime? datains_date { get; set; }

        /// <summary>
        /// 资料更新人
        /// </summary>
        public string datachg_usr { get; set; }

        /// <summary>
        /// 资料更新日期
        /// </summary>
        public DateTime? datachg_date { get; set; }
    }
}