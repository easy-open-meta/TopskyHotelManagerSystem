<<<<<<< HEAD:SYS.Manager/Util/FontsManager.cs
﻿using System.Collections.Generic;
using MySql.Data.MySqlClient;
=======
﻿using MySql.Data.MySqlClient;
using SYS.Common;
>>>>>>> InitProject_v1.4.8_happy_new_year:SYS.Application/Business/FontsService.cs
using SYS.Core;

namespace SYS.Manager
{
<<<<<<< HEAD:SYS.Manager/Util/FontsManager.cs
    public class FontsManager
    {
=======
    /// <summary>
    /// 酒店宣传联动内容接口实现类
    /// </summary>
    public class FontsService:Repository<Fonts>,IFontsService
    {
        /// <summary>
        /// 查询所有宣传联动内容(跑马灯)
        /// </summary>
        /// <returns></returns>
>>>>>>> InitProject_v1.4.8_happy_new_year:SYS.Application/Business/FontsService.cs
        public List<Fonts> SelectFontAll()
        {
            List<Fonts> fonts = new List<Fonts>();
            fonts = base.GetList();
            return fonts;
        }

    }
}
