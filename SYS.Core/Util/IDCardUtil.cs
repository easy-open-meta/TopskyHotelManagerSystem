using MySql.Data.MySqlClient;
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
            pcd = string.Join(",", cardcodes.Province + cardcodes.City + cardcodes.District);
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
