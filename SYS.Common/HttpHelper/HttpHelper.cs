using jvncorelib_fr.EncryptorLib;
using jvncorelib_fr.EntityLib;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;

namespace SYS.Common
{
    /// <summary>
    /// 文件上传帮助类
    /// </summary>
    public static class HttpHelper
    {
        static EncryptLib encrypt = new EncryptLib();

        #region 受限于打包插件的限制才放在这，个人开发时建议统一在App.Config进行配置

        /// <summary>
        /// 数据库配置连接
        /// </summary>
        public const string mysqlString = "server = localhost; user id = softuser; password = .; database = tshoteldb;";

        public const string pgsqlString = "";

        /// <summary>
        /// 照片文件配置URL
        /// </summary>
        public const string baseUrl = "";

        /// <summary>
        /// 上传照片URL
        /// </summary>
        public const string postUrl = "";

        /// <summary>
        /// WebApi URL(release)
        /// </summary>
        public const string apiUrl = "";

        // Debug
        //public const string apiUrl = "";
        #endregion

        public class IgnoreNullValuesConverter : JsonConverter
        {
            private readonly bool _convertEmptyStringToNull;

            // 添加一个构造函数，允许在创建转换器实例时指定是否将空字符串转换为 null
            public IgnoreNullValuesConverter(bool convertEmptyStringToNull = false)
            {
                _convertEmptyStringToNull = convertEmptyStringToNull;
            }

            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                JObject obj = JObject.FromObject(value, serializer);

                foreach (var prop in obj.Properties().ToList())
                {
                    if (prop.Value == null || string.IsNullOrEmpty(prop.Value.ToString()))
                    {
                        // 根据 _convertEmptyStringToNull 决定是移除属性还是设置为 null
                        if (_convertEmptyStringToNull && prop.Value?.Type == JTokenType.String)
                        {
                            prop.Value = JValue.CreateNull();
                        }
                        else
                        {
                            prop.Remove();
                        }
                    }
                }

                obj.WriteTo(writer);
            }

            public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            {
                // 实现这个方法是必要的，但是本例中不需要修改
                throw new NotImplementedException();
            }

            public override bool CanConvert(Type objectType)
            {
                // 仅为示例，根据实际情况调整
                return objectType == typeof(JObject);
            }

            public override bool CanRead => false; // 设置为 false，因为我们不需要修改反序列化的行为
        }

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

        /// <summary>
        /// 统一请求方法
        /// </summary>
        /// <param name="url"></param>
        /// <param name="json"></param>
        /// <param name="dic"></param>
        /// <returns></returns>
        public static ResponseMsg Request(string url, string json = null, Dictionary<string, string> dic = null)
        {
            ResponseMsg msg = new ResponseMsg();

            //处理url
            var sourceStr = url.Replace("​", string.Empty);

            //解密原始URL
            var api = encrypt.Decryption(apiUrl);

            var requestUrl = api + sourceStr;

            if (!json.IsNullOrEmpty())
            {
                msg = DoPost(requestUrl, json);
            }
            else if (!dic.IsNullOrEmpty())
            {
                msg = DoGet(requestUrl, dic);
            }
            else
            {
                msg = DoGet(requestUrl);
            }

            return msg;
        }
        /// <summary>
        /// GET请求
        /// </summary>
        /// <param name="url"></param>
        /// <param name="parameters"></param>
        /// <param name="contentType"></param>
        /// <param name="referer"></param>
        /// <param name="cookie"></param>
        /// <param name="dicHeaders"></param>
        /// <returns></returns>
        public static ResponseMsg DoGet(string url, IDictionary<string, string> parameters = null, string contentType = null, string referer = null, string cookie = null, Dictionary<string, string> dicHeaders = null)
        {
            if (parameters != null && parameters.Count > 0)
            {
                if (url.Contains("?"))
                {
                    url = url + "&" + BuildQuery(parameters);
                }
                else
                {
                    url = url + "?" + BuildQuery(parameters);
                }
            }

            HttpWebRequest req = null;
            string resultContent = "";
            System.IO.Stream stream = null;
            StreamReader reader = null;
            HttpWebResponse rsp = null;

            try
            {
                req = GetWebRequest(url, "GET");//post也行

                if (!string.IsNullOrEmpty(contentType))
                {
                    req.ContentType = contentType;
                }
                else
                {
                    req.ContentType = "application/x-www-form-urlencoded;charset=utf-8";
                }

                if (!string.IsNullOrEmpty(referer))
                {
                    req.Referer = referer;
                }

                if (!string.IsNullOrEmpty(cookie))
                {
                    req.Headers.Add("Cookie", cookie);
                }

                if (dicHeaders != null)
                {
                    foreach (var key in dicHeaders.Keys)
                    {
                        req.Headers.Add(key, dicHeaders[key]);
                    }
                }

                var token = LoginInfo.UserToken.IsNullOrEmpty() ? AdminInfo.UserToken : LoginInfo.UserToken;

                req.Headers.Add("Authorization", string.Format("Bearer {0}", token));

                rsp = (HttpWebResponse)req.GetResponse();

                Encoding encoding = null;
                try
                {
                    encoding = string.IsNullOrEmpty(rsp.CharacterSet) ? Encoding.UTF8 : Encoding.GetEncoding(rsp.CharacterSet);
                }
                catch (Exception)
                {
                    encoding = Encoding.UTF8;
                }

                if (!string.IsNullOrEmpty(contentType))
                {
                    Regex regex = new Regex("charset\\s*=\\s*(\\S+)", RegexOptions.IgnoreCase);
                    Match match = null;
                    match = regex.Match(contentType);
                    if (match.Success)
                    {
                        try
                        {
                            encoding = Encoding.GetEncoding(match.Groups[1].Value.Trim());
                        }
                        catch (Exception)
                        {
                            encoding = string.IsNullOrEmpty(rsp.CharacterSet) ? Encoding.UTF8 : Encoding.GetEncoding(rsp.CharacterSet);
                        }
                    }
                }

                // 以字符流的方式读取HTTP响应
                stream = rsp.GetResponseStream();
                reader = new StreamReader(stream, encoding);
                resultContent = reader.ReadToEnd();
            }
            catch (Exception)
            {
                //LogWriter.WriteError(ex, MethodBase.GetCurrentMethod(), url, parameters, contentType, referer);
                throw;
            }
            finally
            {
                // 释放资源
                if (reader != null) reader.Close();
                if (stream != null) stream.Close();
                if (rsp != null) rsp.Close();
                if (req != null) req.Abort();
                //GC.Collect();
            }

            return new ResponseMsg() { statusCode = (int)rsp.StatusCode, message = resultContent };
        }

        /// <summary>
        /// Post请求
        /// </summary>
        /// <param name="url"></param>
        /// <param name="jsonParam"></param>
        /// <param name="contentType"></param>
        /// <param name="referer"></param>
        /// <param name="cookie"></param>
        /// <param name="dicHeaders"></param>
        /// <returns></returns>
        public static ResponseMsg DoPost(string url, string jsonParam = null, string contentType = null, string referer = null, string cookie = null, Dictionary<string, string> dicHeaders = null)
        {
            var resultContent = string.Empty;
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";

            if (!string.IsNullOrEmpty(contentType))
            {
                request.ContentType = contentType;
            }
            else
            {
                request.ContentType = "application/json;charset=utf-8";
            }

            if (!string.IsNullOrEmpty(referer))
            {
                request.Referer = referer;
            }

            if (!string.IsNullOrEmpty(cookie))
            {
                request.Headers.Add("Cookie", cookie);
            }

            if (dicHeaders != null)
            {
                foreach (var key in dicHeaders.Keys)
                {
                    request.Headers.Add(key, dicHeaders[key]);
                }
            }

            var token = LoginInfo.UserToken.IsNullOrEmpty() ? AdminInfo.UserToken : LoginInfo.UserToken;

            request.Headers.Add("Authorization", string.Format("Bearer {0}", token));

            Stream writer = null;

            if (jsonParam != null)
            {
                byte[] byteData = Encoding.UTF8.GetBytes(jsonParam);
                int length = byteData.Length;
                request.ContentLength = length;
                writer = request.GetRequestStream();
                writer.Write(byteData, 0, length);
                writer.Close();
            }

            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("utf-8")).ReadToEnd();

            resultContent = responseString.ToString();

            return new ResponseMsg() { statusCode = (int)response.StatusCode, message = resultContent };
        }

        /// <summary>
        /// 组装普通文本请求参数。
        /// </summary>
        /// <param name="parameters">Key-Value形式请求参数字典</param>
        /// <returns>URL编码后的请求数据</returns>
        public static string BuildQuery(IDictionary<string, string> parameters)
        {
            StringBuilder postData = new StringBuilder();
            bool hasParam = false;

            IEnumerator<KeyValuePair<string, string>> dem = parameters.GetEnumerator();
            while (dem.MoveNext())
            {
                string name = dem.Current.Key;
                string value = dem.Current.Value;
                // 忽略参数名或参数值为空的参数
                if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(value))
                {
                    if (hasParam)
                    {
                        postData.Append("&");
                    }

                    postData.Append(name);
                    postData.Append("=");
                    postData.Append(UrlEncode(value, Encoding.UTF8));
                    hasParam = true;
                }
            }

            return postData.ToString();
        }

        /**
        * C#的URL encoding有两个问题：
        * 1.左右括号没有转移（Java的URLEncoder.encode有）
        * 2.转移符合都是小写的，Java是大写的
        */
        public static string UrlEncode(string str, Encoding e)
        {
            var REG_URL_ENCODING = new Regex(@"%[a-f0-9]{2}");

            if (str == null)
            {
                return null;
            }

            String stringToEncode = HttpUtility.UrlEncode(str, e).Replace("+", "%20").Replace("*", "%2A").Replace("(", "%28").Replace(")", "%29");
            return REG_URL_ENCODING.Replace(stringToEncode, m => m.Value.ToUpperInvariant());
        }

        /// <summary>
        /// 获取网页请求
        /// </summary>
        /// <param name="url"></param>
        /// <param name="method"></param>
        /// <returns></returns>
        public static HttpWebRequest GetWebRequest(string url, string method)
        {
            HttpWebRequest req = null;
            if (url.Contains("https"))
            {
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
                req = (HttpWebRequest)WebRequest.CreateDefault(new Uri(url));
            }
            else
            {
                req = (HttpWebRequest)WebRequest.Create(url);
            }

            req.ServicePoint.Expect100Continue = false;
            req.Method = method;
            req.KeepAlive = true;
            req.UserAgent = "userAgent";
            req.Timeout = 100000;

            return req;
        }

        /// <summary>
        /// 获取网页请求扩展-检查请求
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="certificate"></param>
        /// <param name="chain"></param>
        /// <param name="errors"></param>
        /// <returns></returns>
        public static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        { //直接确认，否则打不开
            return true;
        }

        /// <summary>
        /// Json转数组列表
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="JsonStr"></param>
        /// <returns></returns>
        public static List<T> JsonToList<T>(string JsonStr)
        {
            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            return javaScriptSerializer.Deserialize<List<T>>(JsonStr);
        }

        /// <summary>
        /// Json转实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input"></param>
        /// <returns></returns>
        public static T JsonToModel<T>(this string input)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(input);
            }
            catch (Exception)
            {
                return default(T);
            }
        }

        /// <summary>
        /// 实体转Json
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string ModelToJson<T>(this T input)
        {
            try
            {
                return Newtonsoft.Json.JsonConvert.SerializeObject(input, new JsonSerializerSettings
                {
                    Converters = { new IgnoreNullValuesConverter(true) },
                    Formatting = Formatting.Indented // 如果需要格式化输出
                });
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
