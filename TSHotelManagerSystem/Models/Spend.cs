using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSHotelManagerSystem.Models
{
   public class Spend
    {
        public string RoomNo { get; set; }
        public string CustoNo { get; set; }
        public string SpendName { get; set; }
        public int SpendAmount { get; set; }
        public decimal SpendPrice { get; set; }
        public decimal SpendMoney { get; set; }
        public DateTime SpendTime { get; set; }
        public string MoneyState { get; set; }
    }
}
