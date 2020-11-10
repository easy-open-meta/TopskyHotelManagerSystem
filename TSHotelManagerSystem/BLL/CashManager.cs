using System.Collections.Generic;
using Core;
using SYS.Application;

namespace TSHotelManagerSystem.BLL
{
    public class CashManager
    {
        public static List<Cash> SelectCashInfoAll()
        {

            return CashService.SelectCashInfoAll();
        }

        public static object AddCashInfo(Cash cash)
        {
            return CashService.AddCashInfo(cash);
        }
    }
}
