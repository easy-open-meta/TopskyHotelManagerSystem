using System.Collections.Generic;
using System.Web.Http;
using SYS.Application;
using SYS.Core;

namespace SYS.Browser.WebAPI.Controllers
{
    /// <summary>
    /// 酒店宣传语控制器
    /// </summary>
    public class FontsController : ApiController
    {
        /// <summary>
        /// 查询所有宣传联动内容(跑马灯)
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Fonts> SelectFontAll()
        {
            return new FontsService().SelectFontAll();
        }

    }
}
