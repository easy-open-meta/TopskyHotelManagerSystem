using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSHotelManagerSystem.Models
{
   public class OperationLog
    {
        public DateTime OperationTime { get; set; }
        public string Operationlog { get; set; }
        public string OperationAccount { get; set; }

    }
}
