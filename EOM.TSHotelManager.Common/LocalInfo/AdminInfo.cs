/*
 * MIT License
 *Copyright (c) 2021 易开元(Easy-Open-Meta)

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
 *模块说明：管理员信息静态类
 */
namespace EOM.TSHotelManager.Common
{
    /// <summary>
    /// 管理员信息静态类(后台管理员登入后的本地信息存储)
    /// </summary>
    public class AdminInfo
    {
        /// <summary>
        /// 存储当前超管账号
        /// </summary>
        public static string Account = "";

        /// <summary>
        /// 存储当前超管类型
        /// </summary>
        public static string Type = "";

        /// <summary>
        /// 存储当前超管用户组
        /// </summary>
        public static string Group = "";

        /// <summary>
        /// 存储当前超管名称
        /// </summary>
        public static string Name = "";

        /// <summary>
        /// 是否为超管
        /// </summary>
        public static bool isAdmin;

        /// <summary>
        /// 存储当前软件版本
        /// </summary>
        public static string SoftwareVersion = "";

        /// <summary>
        /// 存储当前用户Token
        /// </summary>
        public static string UserToken = "";

    }
}
