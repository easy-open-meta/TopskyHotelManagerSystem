using SYS.Core;
using System.Collections.Generic;

namespace SYS.Application
{
    /// <summary>
    /// 酒店宣传联动内容接口
    /// </summary>
    public interface IFontsService
    {
        /// <summary>
        /// 查询所有宣传联动内容(跑马灯)
        /// </summary>
        /// <returns></returns>
        List<Fonts> SelectFontAll();
    }
}