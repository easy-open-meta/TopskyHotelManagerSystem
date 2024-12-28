namespace EOM.TSHotelManager.Common
{
    public class RoomStateConstant : Constant<RoomStateConstant>
    {
        // 空房
        public static readonly RoomStateConstant Empty = new RoomStateConstant("0", "空房");
        // 已住
        public static readonly RoomStateConstant Occupied = new RoomStateConstant("1", "已住");
        // 维修
        public static readonly RoomStateConstant UnderRepair = new RoomStateConstant("2", "维修");
        // 脏房
        public static readonly RoomStateConstant Dirty = new RoomStateConstant("3", "脏房");
        // 预约
        public static readonly RoomStateConstant Reserved = new RoomStateConstant("4", "预约");

        private RoomStateConstant(string code, string description) : base(code, description)
        {
        }
    }
}
