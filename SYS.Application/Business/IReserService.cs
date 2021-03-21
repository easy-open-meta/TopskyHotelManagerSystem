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
using SYS.Core;
using System.Collections.Generic;

namespace SYS.Application
{
    /// <summary>
    /// 预约信息接口
    /// </summary>
    public interface IReserService
    {

        /// <summary>
        /// 获取所有预约信息
        /// </summary>
        /// <returns></returns>
        List<Reser> SelectReserAll();

        /// <summary>
        /// 根据房间编号获取预约信息
        /// </summary>
        /// <param name="no"></param>
        /// <returns></returns>
        Reser SelectReserInfoByRoomNo(string no);

        /// <summary>
        /// 删除预约信息
        /// </summary>
        /// <param name="rid"></param>
        /// <returns></returns>
        bool DeleteReserInfo(string rid);

        /// <summary>
        /// 添加预约信息
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        bool InserReserInfo(Reser r);


    }
}