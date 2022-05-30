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
 *模块说明：检测软件版本
 */
using SqlSugar;
using SYS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Core
{
    /// <summary>
    /// 程序版本号检测
    /// </summary>
    public class ApplicationVersionUtil:Repository<applicationversion>
    {
        /// <summary>
        /// 检测版本号
        /// </summary>
        /// <returns></returns>
        public applicationversion CheckBaseVersion() 
        {
            return base.GetSingle(a => a.base_versionId == 1);
        }
    }

    [SqlSugar.SugarTable("applicationversion")]
    public class applicationversion
    {
        /// <summary>
        /// 流水号
        /// </summary>
        [SugarColumn(ColumnName = "base_versionId")]//数据库是自增才配自增
        public int base_versionId { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [SugarColumn(ColumnName = "base_version")]//数据库是自增才配自增
        public string base_version { get; set; }
    }
}
