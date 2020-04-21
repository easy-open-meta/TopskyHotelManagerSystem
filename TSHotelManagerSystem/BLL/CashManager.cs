using System.Collections.Generic;
using TSHotelManagerSystem.DAL;
using TSHotelManagerSystem.Models;

namespace TSHotelManagerSystem.BLL
{
    public class CashManager
    {
        public static List<Cash> SelectCashInfoAll()
        {

            return CashService.SelectCashInfoAll();
        }

        public static object AddCashInfo(Models.Cash cash)
        {
            return CashService.AddCashInfo(cash);
        }
    }
}
