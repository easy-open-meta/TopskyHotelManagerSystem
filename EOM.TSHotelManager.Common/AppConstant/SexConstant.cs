namespace EOM.TSHotelManager.Common
{
    public class SexConstant : Constant<SexConstant>
    {
        // 女
        public static readonly SexConstant Female = new SexConstant("0", "女");
        // 男
        public static readonly SexConstant Male = new SexConstant("1", "男");

        private SexConstant(string code, string description) : base(code, description)
        {
        }
    }
}
