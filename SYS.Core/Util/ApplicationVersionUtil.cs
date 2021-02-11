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
            applicationversion applicationVerison = new applicationversion();
            applicationVerison = base.GetSingle(a => a.base_versionId == 1);
            return applicationVerison;
        }
    }

    public class applicationversion
    {
        /// <summary>
        /// 流水号
        /// </summary>
        public int base_versionId { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        public string base_version { get; set; }
    }
}
