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
        public static int InserReserInfo(Reser r)
        {
            return ReserService.InserReserInfo(r);
        }
    }
}
