using System.Collections.Generic;
using TSHotelManagerSystem.DAL;
using TSHotelManagerSystem.Models;

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
