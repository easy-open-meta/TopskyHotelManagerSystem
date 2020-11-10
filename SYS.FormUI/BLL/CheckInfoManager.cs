using System.Collections.Generic;
using SYS.Core;
using SYS.Application;

namespace SYS.FormUI.BLL
{
    public class CheckInfoManager
    {
        public static List<CheckInfo> SelectCheckInfoAll()
        {

            return CheckInfoService.SelectCheckInfoAll();
        }
    }
}
