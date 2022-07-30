using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Common
{
    /// <summary>
    /// 文件上传帮助类
    /// </summary>
    public class HttpHelper
    {
        #region 受限于打包插件的限制才放在这，个人开发时建议统一在App.Config进行配置

        /// <summary>
        /// 数据库配置连接
        /// </summary>
        public const string mysqlString = "server = localhost; user id = softuser; password = .; database = tshoteldb;";
        public const string pgsqlString = "PORT=5630;DATABASE=tshoteldb;HOST=localhost;PASSWORD=.;USER ID=postgres";
        /// <summary>
        /// 照片文件配置URL
        /// </summary>
        public const string baseUrl = "http://localhost:5622/FileVisualPath/";
        /// <summary>
        /// 上传照片URL
        /// </summary>
        public const string postUrl = "http://localhost:5622/api/Upload";

        #endregion

        /// <summary>
        /// WebClient上传文件至服务器
        /// </summary>
        /// <param name="fileNamePath">文件名，全路径格式</param>
        /// <param name="uriString">服务器文件夹路径</param>
        public static string UpLoadFile(string fileNamePath, string uriString)
        {
            // 创建WebClient实例
            WebClient myWebClient = new WebClient();
            byte[] responseData = myWebClient.UploadFile(uriString, "POST", fileNamePath);//得到返回的内容
            String str = Encoding.UTF8.GetString(responseData);//得到的目的字符串

            return str.Replace('\"', ' ');
        }
    }
}
