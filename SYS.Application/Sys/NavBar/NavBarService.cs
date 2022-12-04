using SYS.Common;
using SYS.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Application
{
    /// <summary>
    /// 导航控件模块
    /// </summary>
    public class NavBarService:Repository<NavBar>
    {
        /// <summary>
        /// 导航控件列表
        /// </summary>
        /// <returns></returns>
        public List<NavBar> NavBarList()
        {
            var navBarList = base.GetList(a => a.delete_mk != 1);

            return navBarList;
        }
    }
}
