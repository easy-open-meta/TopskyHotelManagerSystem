namespace EOM.TSHotelManager.Common
{
    public class Constant<T> where T : Constant<T>
    {
        public string Code { get; }
        public string Description { get; }

        private static List<T> _constants = new List<T>();

        protected Constant(string code, string description)
        {
            Code = code;
            Description = description;
            _constants.Add((T)this);
        }

        public static IEnumerable<T> GetAll()
        {
            return _constants;
        }

        public static string GetDescriptionByCode(string code)
        {
            var constant = _constants.SingleOrDefault(c => c.Code == code);
            return constant?.Description ?? string.Empty;
        }

        public static string GetCodeByDescription(string description)
        {
            var constant = _constants.SingleOrDefault(c => c.Description == description);
            return constant?.Code ?? string.Empty;
        }

        public static T? GetConstantByCode(string code)
        {
            var constant = _constants.FirstOrDefault(c => c.Code == code);
            return constant ?? null;
        }
    }
}
