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
 *模块说明：登录信息静态类(前台工作人员登入后的本地信息存储)
 */
namespace SYS.Common
{
    /// <summary>
    /// 登录信息静态类(前台工作人员登入后的本地信息存储)
    /// </summary>
    public static class LoginInfo
    {
        /// <summary>
        /// 存储当前员工编号
        /// </summary>
        public static string WorkerNo = "";

        /// <summary>
        /// 存储当前员工姓名
        /// </summary>
        public static string WorkerName = "";

        /// <summary>
        /// 存储当前员工职位
        /// </summary>
        public static string WorkerPosition = "";

        /// <summary>
        /// 存储当前员工部门
        /// </summary>
        public static string WorkerClub = "";

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
