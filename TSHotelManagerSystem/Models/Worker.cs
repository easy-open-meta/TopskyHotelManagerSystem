using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSHotelManagerSystem.Models
{
   public class Worker
    {
        public string WorkerId { get; set; }
        public string WorkerName { get; set; }
        public DateTime WorkerBirth { get; set; }
        public string WorkerSex { get; set; }
        public string WorkerTel { get; set; }
        public string WorkerClub { get; set; }
        public string WorkerAddress { get; set; }
        public string WorkerPosition { get; set; }
        public string CardId { get; set; }
        public string WorkerPwd { get; set; }
        public DateTime WorkerTime { get; set; }
        public string WorkerFace { get; set; }
    }
}
