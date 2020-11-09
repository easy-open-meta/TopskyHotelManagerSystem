using System.Collections.Generic;
using TSHotelManagerSystem.DAL;
using Core;

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
