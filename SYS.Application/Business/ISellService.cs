using SYS.Core;
using System.Collections.Generic;

namespace SYS.Application
{
    /// <summary>
    /// 商品接口
    /// </summary>
    public interface ISellService
    {
        /// <summary>
        /// 查询所有商品
        /// </summary>
        /// <returns></returns>
        List<SellThing> SelectSellThingAll();

        /// <summary>
        /// 根据商品ID查询
        /// </summary>
        /// <param name="No"></param>
        /// <returns></returns>
        SellThing SelectSellThingByNo(string No);

        /// <summary>
        /// 根据商品名称查询
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        List<SellThing> SelectSellThingByName(string Name);

        /// <summary>
        /// 修改商品
        /// </summary>
        /// <param name="stock"></param>
        /// <param name="sellNo"></param>
        /// <returns></returns>
        bool UpdateSellThing(string stock, string sellNo);

        /// <summary>
        /// 撤回客户消费信息
        /// </summary>
        /// <param name="roomNo"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        bool DeleteSellThing(string roomNo, string time);

        /// <summary>
        /// 根据商品编号删除商品信息
        /// </summary>
        /// <param name="sellNo"></param>
        /// <returns></returns>
        bool DeleteSellThingBySellNo(string sellNo);

        /// <summary>
        /// 根据商品名称和价格查询商品编号
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <returns></returns>
        SellThing SelectSellThingByNameAndPrice(string name, string price);


        /// <summary>
        /// 根据商品编号查询商品信息
        /// </summary>
        /// <param name="SellNo"></param>
        /// <returns></returns>
        SellThing SelectSellInfoBySellNo(string SellNo);

        #region 添加商品
        /// <summary>
        /// 添加商品
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        bool InsertSellThing(SellThing st);
        #endregion
    }
}