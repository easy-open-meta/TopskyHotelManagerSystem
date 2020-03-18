using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSHotelManagerSystem.Models
{
   public class Notice
    {
        public string NoticeNo { get; set; }
        public string Noticetheme { get; set; }
        public DateTime NoticeTime { get; set; }
        public string NoticeContent { get; set; }
        public string NoticeClub { get; set; }
        public string NoticePerson { get; set; }

    }
}
