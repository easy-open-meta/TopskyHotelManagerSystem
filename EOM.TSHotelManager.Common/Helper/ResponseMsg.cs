namespace EOM.TSHotelManager.Common
{
    public class ResponseMsg
    {
        /// <summary>
        /// 状态码
        /// </summary>
        public int statusCode { get; set; }
        /// <summary>
        /// 错误信息
        /// </summary>
        public string? message { get; set; }
    }
}
