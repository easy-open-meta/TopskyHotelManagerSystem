using System.Collections.Generic;
using Core;
using SYS.Application;

namespace TSHotelManagerSystem.BLL
{
    public class CheckInfoManager
    {
        public static List<CheckInfo> SelectCheckInfoAll()
        {

            return CheckInfoService.SelectCheckInfoAll();
        }
    }
}
