using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSHotelManagerSystem.Models
{
    public class SellThing
    {
        public string SellNo{ get; set; }
        public string SellName { get; set; }
        public decimal SellPrice { get; set; }
        public string format { get; set; }
        public int Stock { get; set; }
    }
}
