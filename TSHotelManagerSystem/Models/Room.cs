using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSHotelManagerSystem.Models
{
   public class Room
    {
       public string RoomNo { get; set; }
       public int RoomType { get; set; }
       public string CustoNo { get; set; }
       public DateTime CheckTime { get; set; }
       public DateTime CheckOutTime { get; set; }
       public int RoomStateId { get; set; }
       public string RoomState { get; set; }
       public decimal RoomMoney { get; set; }
       public string PersonNum { get; set; }
       public string RoomPosition { get; set; }
       public string typeName { get; set; }

    }
}
