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
 *模块说明：身份证号码工具类
 */
using SYS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Core.Util
{
    /// <summary>
    /// 身份证号码工具类
    /// </summary>
    public class IDCardUtil:Repository<cardcodes>
    {
        /// <summary>
        /// 查询地区码
        /// </summary>
        /// <param name="identityCard"></param>
        /// <returns></returns>
        public string SelectCardCode(string identityCard)
        {
            var cardid = identityCard.Substring(0, 6).ToString();
            cardcodes cardcodes = new cardcodes();
            var pcd = string.Empty;
            cardcodes = base.GetSingle(a => a.bm == cardid);
            pcd = cardcodes == null ? "" : string.Join(",", cardcodes.Province + cardcodes.City + cardcodes.District);
            return pcd;
        }

    }

    /// <summary>
    /// 
    /// </summary>
    public class cardcodes 
    {
        /// <summary>
        /// 
        /// </summary>
        public cardcodes()
        {
        }

        private System.Int64 _id;
        /// <summary>
        /// 编号
        /// </summary>
        public System.Int64 id { get { return this._id; } set { this._id = value; } }

        private System.String _Province;
        /// <summary>
        /// 省份
        /// </summary>
        public System.String Province { get { return this._Province; } set { this._Province = value; } }

        private System.String _City;
        /// <summary>
        /// 城市
        /// </summary>
        public System.String City { get { return this._City; } set { this._City = value; } }

        private System.String _District;
        /// <summary>
        /// 地区
        /// </summary>
        public System.String District { get { return this._District; } set { this._District = value; } }

        private System.String _bm;
        /// <summary>
        /// 地区识别码
        /// </summary>
        public System.String bm { get { return this._bm; } set { this._bm = value; } }

    }

}
