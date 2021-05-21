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
 *模块说明：预约类
 */
using System;

namespace SYS.Core
{
    /// <summary>
    /// 预约列表
    /// </summary>
    public class Reser
    {
        /// <summary>
        /// 预约编号
        /// </summary>
        public string ReserId { get; set; }
        /// <summary>
        /// 客户名称
        /// </summary>
        public string CustoName { get; set; }
        /// <summary>
        /// 预约电话
        /// </summary>
        public string CustoTel { get; set; }
        /// <summary>
        /// 预约渠道
        /// </summary>
        public string ReserWay { get; set; }
        /// <summary>
        /// 预约房号
        /// </summary>
        public string ReserRoom { get; set; }
        /// <summary>
        /// 预约起始
        /// </summary>
        public DateTime ReserDate { get; set; }
        /// <summary>
        /// 预约止日
        /// </summary>
        public DateTime ReserEndDay { get; set; }
        /// <summary>
        /// 删除标记
        /// </summary>
        public int delete_mk { get; set; }
        /// <summary>
        /// 资料创建人
        /// </summary>
        public string datains_usr { get; set; }
        /// <summary>
        /// 资料创建时间
        /// </summary>
        public DateTime datains_date { get; set; }
        /// <summary>
        /// 资料更新人
        /// </summary>
        public string datachg_usr { get; set; }
        /// <summary>
        /// 资料更新时间
        /// </summary>
        public DateTime datachg_date { get; set; }

    }
}
