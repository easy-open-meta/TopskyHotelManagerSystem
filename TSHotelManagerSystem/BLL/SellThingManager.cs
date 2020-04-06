using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSHotelManagerSystem.DAL;
using TSHotelManagerSystem.Models;

namespace TSHotelManagerSystem.BLL
{
    public class SellThingManager
    {
        public static List<SellThing> SelectSellThingAll()
        {
            return SellService.SelectSellThingAll();
        }

        public static SellThing SelectSellThingByNo(string No)
        {
            return SellService.SelectSellThingByNo(No);
        }

        public static int UpdateSellThing(string stock, string sellNo)
        {
            return SellService.UpdateSellThing(stock,sellNo);
        }

        public static int DeleteSellThing(string roomNo, string time)
        {
            return SellService.DeleteSellThing(roomNo,time);
        }

        public static List<SellThing> SelectThingByName(string Name)
        {
            return SellService.SelectSellThingByName(Name);
        }

        public static SellThing SelectSellThingByNameAndPrice(string name, string price)
        {
            return SellService.SelectSellThingByNameAndPrice(name, price);
        }

        public static string GetRandomSellNo()
        {
            string SellNo = "";
            Random rand = new Random();
            SellNo = rand.NextDouble() + "";
            SellNo = "ST" + SellNo.Substring(2, 3);
            SellThing card = SelectSellInfoBySellNo(SellNo);
            while (card != null)
            {
                SellNo = rand.NextDouble() + "";
                SellNo = "ST" + SellNo.Substring(2, 3);
                card = SelectSellInfoBySellNo(SellNo);
            }
            return SellNo;
        }

        public static SellThing SelectSellInfoBySellNo(string SellNo)
        {
            return SellService.SelectSellInfoBySellNo(SellNo);
        }

        public static int InsertSellThing(SellThing st)
        {
            return SellService.InsertSellThing(st);
        }
    }
}
