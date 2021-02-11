using MySql.Data.MySqlClient;
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
    /// 酒店宣传联动内容接口实现类
    /// </summary>
    public class FontsService:Repository<Fonts>,IFontsService
    {
        /// <summary>
        /// 查询所有宣传联动内容(跑马灯)
        /// </summary>
        /// <returns></returns>
        public List<Fonts> SelectFontAll()
        {
            List<Fonts> fonts = new List<Fonts>();
            fonts = base.GetList();
            return fonts;
        }
    }
}
