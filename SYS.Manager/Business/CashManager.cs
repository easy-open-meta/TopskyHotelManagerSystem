using System.Collections.Generic;
using SYS.Core;
using SYS.Application;

namespace SYS.Manager
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
