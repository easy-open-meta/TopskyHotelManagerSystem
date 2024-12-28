using EOM.TSHotelManager.Common;
using Newtonsoft.Json;
using RestSharp;

namespace EOM.TSHotelManager.FormUI
{
    public class SwaggerExtractor
    {
        public void ExtractRoutesToFileAsync(string swaggerUrl)
        {
            var reponse = new RestResponse();
            var client = new RestClient(swaggerUrl);
            var request = new RestRequest();

            string resultContent = "";
            RestResponse rsp = null;

            rsp = client.ExecuteGet(request);

            resultContent = rsp.Content;

            var result = new ResponseMsg() { statusCode = (int)rsp.StatusCode, message = resultContent };

            GetSwaggerJson(result.message);
        }

        public void GetSwaggerJson(string json)
        {
            // 解析JSON内容
            dynamic swaggerObject = JsonConvert.DeserializeObject(json);

            // 遍历并打印所有的路径和HTTP方法
            foreach (var path in swaggerObject.paths)
            {
                // 只保存唯一的路径名称
                ApiConstant.Paths.Add(path.Name);
            }
        }
    }
}
