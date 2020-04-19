using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSHotelManagerSystem.DAL;
using TSHotelManagerSystem.Models;

namespace TSHotelManagerSystem.BLL
{
   public class ReserManager
    {
        public static Reser SelectReserInfoByRoomNo(string no)
        {
            Reser r = ReserService.SelectReserInfoByRoomNo(no);
            return r;
        }

        public static int DeleteReserInfo(string rid)
        {
            return ReserService.DeleteReserInfo(rid);
        }

        public static List<Reser> SelectReserAll()
        {
            return ReserService.SelectReserAll();
        }

        public static int InserReserInfo(Reser r)
        {
            return ReserService.InserReserInfo(r);
        }
    }
}
