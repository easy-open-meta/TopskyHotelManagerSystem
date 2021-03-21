/*
 * MIT License
 *Copyright (c) 2021 咖啡与网络(java-and-net)

 *Permission is hereby granted, free of charge, to any person obtaining a copy
 *of this software and associated documentation files (the "Software"), to deal
 *in the Software without restriction, including without limitation the rights
 *to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 *copies of the Software, and to permit persons to whom the Software is
 *furnished to do so, subject to the following conditions:

 *The above copyright notice and this permission notice shall be included in all
 *copies or substantial portions of the Software.

 *THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 *IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 *FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 *AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 *LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 *OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 *SOFTWARE.
 *
 */
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SYS.Common;
using SYS.Core;

namespace SYS.Application
{
    /// <summary>
    /// 商品信息接口实现类
    /// </summary>
    public class SellService:Repository<SellThing>,ISellService
    {
        /// <summary>
        /// 查询所有商品
        /// </summary>
        /// <returns></returns>
        public List<SellThing> SelectSellThingAll()
        {
            List<SellThing> sellThings = new List<SellThing>();
            sellThings = base.GetList(a => a.delete_mk == 0);
            return sellThings;
        }

        /// <summary>
        /// 根据商品ID查询
        /// </summary>
        /// <param name="No"></param>
        /// <returns></returns>
        public SellThing SelectSellThingByNo(string No)
        {
            SellThing s = new SellThing();
            s = base.GetSingle(a => a.SellNo == No && a.delete_mk != 1);
            return s;
        }

        /// <summary>
        /// 根据商品名称查询
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public List<SellThing> SelectSellThingByName(string Name)
        {
            List<SellThing> sellThings = new List<SellThing>();
            sellThings = base.GetList(a => a.SellName.Contains(Name) || a.SellNo.Contains(Name) || a.SellPrice == Convert.ToDecimal(Name) || a.format.Contains(Name));
            return sellThings;
        }

        /// <summary>
        /// 修改商品
        /// </summary>
        /// <param name="stock"></param>
        /// <param name="sellNo"></param>
        /// <returns></returns>
        public bool UpdateSellThing(string stock, string sellNo)
        {
            return base.Update(a => new SellThing() 
            {
                Stock = Convert.ToInt32(stock),
                datachg_usr = LoginInfo.WorkerNo,
                datachg_date = DateTime.Now
            },a => a.SellNo == sellNo);
        }

        /// <summary>
        /// 修改商品信息
        /// </summary>
        /// <param name="sellThing"></param>
        /// <returns></returns>
        public bool UpdateSellthingInfo(SellThing sellThing)
        {
            return base.Update(a => new SellThing()
            {
                SellName = sellThing.SellName,
                SellPrice = sellThing.SellPrice,
                Stock = sellThing.Stock,
                format = sellThing.format,
            },a => a.SellNo == sellThing.SellNo);
        }

        /// <summary>
        /// 撤回客户消费信息
        /// </summary>
        /// <param name="roomNo"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public bool DeleteSellThing(string roomNo, string time)
        {
            return base.Change<Spend>().Update(a => new Spend()
            {
                delete_mk = 1,
                datachg_usr = LoginInfo.WorkerNo,
                datachg_date = DateTime.Now
            },a => a.RoomNo == roomNo && a.SpendTime >= Convert.ToDateTime(time));

        }

        /// <summary>
        /// 根据商品编号删除商品信息
        /// </summary>
        /// <param name="sellNo"></param>
        /// <returns></returns>
        public bool DeleteSellThingBySellNo(string sellNo)
        {
            return base.Update(a => new SellThing()
            {
                delete_mk = 1,
                datachg_usr = AdminInfo.Account,
                datachg_date = DateTime.Now
            }, a => a.SellNo == sellNo);
        }

        /// <summary>
        /// 根据商品名称和价格查询商品编号
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <returns></returns>
        public SellThing SelectSellThingByNameAndPrice(string name,string price)
        {
            SellThing sellThing = null;
            sellThing = base.GetSingle(a => a.SellName == name && a.SellPrice == Convert.ToDecimal(price));
            return sellThing;
        }


        /// <summary>
        /// 根据商品编号查询商品信息
        /// </summary>
        /// <param name="SellNo"></param>
        /// <returns></returns>
        public SellThing SelectSellInfoBySellNo(string SellNo)
        {
            SellThing st = null;
            st = base.GetSingle(a => a.SellNo == SellNo && a.delete_mk != 1);
            return st;
        }

        #region 添加商品
        /// <summary>
        /// 添加商品
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        public bool InsertSellThing(SellThing st)
        {
            return base.Insert(st);
        }
        #endregion
    }
}
