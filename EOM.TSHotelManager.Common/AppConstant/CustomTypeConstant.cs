namespace EOM.TSHotelManager.Common
{
    public class CustomTypeConstant : Constant<CustomTypeConstant>
    {
        // 普通会员
        public static readonly CustomTypeConstant RegularMember = new CustomTypeConstant("0", "普通会员");
        // 钻石会员
        public static readonly CustomTypeConstant DiamondMember = new CustomTypeConstant("1", "钻石会员");
        // 白金会员
        public static readonly CustomTypeConstant PlatinumMember = new CustomTypeConstant("2", "白金会员");
        // 黄金会员
        public static readonly CustomTypeConstant GoldMember = new CustomTypeConstant("3", "黄金会员");

        private CustomTypeConstant(string code, string description) : base(code, description)
        {
        }
    }
}
