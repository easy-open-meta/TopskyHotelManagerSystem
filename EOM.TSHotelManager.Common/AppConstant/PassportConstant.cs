namespace EOM.TSHotelManager.Common
{
    public class PassportConstant : Constant<PassportConstant>
    {
        // 中国居民身份证
        public static readonly PassportConstant ChineseResidentIdentityCard = new PassportConstant("0", "中国居民身份证");
        // 港澳居民来往内地通行证
        public static readonly PassportConstant MainlandTravelPermitforHKandMOResidents = new PassportConstant("1", "港澳居民来往内地通行证");
        // 台湾居民来往大陆通行证
        public static readonly PassportConstant MainlandTravelPermitforTWResidents = new PassportConstant("2", "台湾居民来往大陆通行证");
        // 军官证
        public static readonly PassportConstant OfficerCertificate = new PassportConstant("3", "军官证");
        // 外国护照
        public static readonly PassportConstant ForeignPassport = new PassportConstant("4", "外国护照");

        private PassportConstant(string code, string description) : base(code, description)
        {
        }
    }
}
