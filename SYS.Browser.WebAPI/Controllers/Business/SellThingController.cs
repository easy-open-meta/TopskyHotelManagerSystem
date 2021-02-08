using System;
using System.Collections.Generic;
using SYS.Core;
using SYS.Application;
using System.Web.Http;

namespace SYS.Browser.WebAPI.Controllers
{
    /// <summary>
    /// 商品消费控制器(后)
    /// </summary>
    public class SellThingController : ApiController
    {
        /// <summary>
        /// 查询所有商品信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<SellThing> SelectSellThingAll()
        {
            return SellService.SelectSellThingAll();
        }

        /// <summary>
        /// 根据商品ID查询商品信息
        /// </summary>
        /// <param name="No"></param>
        /// <returns></returns>
        [HttpGet]
        public SellThing SelectSellThingByNo([FromUri]string No)
        {
            return SellService.SelectSellThingByNo(No);
        }

        /// <summary>
        /// 消费商品(更新库存)
        /// </summary>
        /// <param name="stock"></param>
        /// <param name="sellNo"></param>
        /// <returns></returns>
        [HttpPost]
        public int UpdateSellThing([FromBody]string stock, string sellNo)
        {
            return SellService.UpdateSellThing(stock, sellNo);
        }

        /// <summary>
        /// 撤回客户消费信息
        /// </summary>
        /// <param name="roomNo"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        [HttpDelete]
        public int DeleteSellThing([FromBody]string roomNo, string time)
        {
            return SellService.DeleteSellThing(roomNo, time);
        }

        /// <summary>
        /// 根据商品名称查询商品信息
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        [HttpGet]
        public List<SellThing> SelectThingByName([FromUri]string Name)
        {
            return SellService.SelectSellThingByName(Name);
        }

        /// <summary>
        /// 根据商品名称和价格查询商品编号
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <returns></returns>
        [HttpGet]

        public SellThing SelectSellThingByNameAndPrice([FromUri]string name,string price)
        {
            return SellService.SelectSellThingByNameAndPrice(name, price);
        }

        /// <summary>
        /// 根据商品编号查询消费信息
        /// </summary>
        /// <param name="SellNo"></param>
        /// <returns></returns>
        [HttpGet]
        public SellThing SelectSellInfoBySellNo([FromUri]string SellNo)
        {
            return SellService.SelectSellInfoBySellNo(SellNo);
        }

        /// <summary>
        /// 添加商品消费
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        [HttpPost]
        public int InsertSellThing([FromBody]SellThing st)
        {
            return SellService.InsertSellThing(st);
        }
    }
}
