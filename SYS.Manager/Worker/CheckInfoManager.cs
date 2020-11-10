using System.Collections.Generic;
using SYS.Core;
using SYS.Application;

namespace SYS.Manager
{
    public class CheckInfoManager
    {
        public static List<CheckInfo> SelectCheckInfoAll()
        {

            return CheckInfoService.SelectCheckInfoAll();
        }
    }
}
