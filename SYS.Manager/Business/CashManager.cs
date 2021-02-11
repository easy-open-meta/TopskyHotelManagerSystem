using System.Collections.Generic;
using SYS.Core;
using SYS.Application;

namespace SYS.Manager
{
    public class CashManager
    {
        public List<Cash> SelectCashInfoAll()
        {

            return new CashService().SelectCashInfoAll();
        }

        public static object AddCashInfo(Cash cash)
        {
            return new CashService().AddCashInfo(cash);
        }
    }
}
