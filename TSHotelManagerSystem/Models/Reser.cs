using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSHotelManagerSystem.Models
{
   public class Reser
    {
        public string ReserId { get; set; }
        public string CustoName { get; set; }
        public string CustoTel { get; set; }
        public string ReserWay { get; set; }
        public string ReserRoom { get; set; }
        public DateTime ReserDate { get; set; }
        public DateTime ReserEndDay { get; set; }
        public string ReserRemark { get; set; }

    }
}
