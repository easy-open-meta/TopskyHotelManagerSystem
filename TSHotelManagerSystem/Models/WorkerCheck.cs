using System;

namespace TSHotelManagerSystem.Models
{
    public class WorkerCheck
    {
        public string WorkerNo { get; set; }
        public DateTime CheckTime { get; set; }
        public string CheckWay { get; set; }
        public string CheckState { get; set; }

    }
}
