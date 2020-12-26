using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SYS.Core;
using SYS.Application;

namespace SYS.Manager
{
    public class WorkerGoodBadManager
    {
        public static int AddGoodBad(WorkerGoodBad goodBad)
        {
            return WorkerGoodBadService.AddGoodBad(goodBad);
        }

        public static List<WorkerGoodBad> SelectAllGoodBadByWorkNo(string wn)
        {
            return WorkerGoodBadService.SelectAllGoodBadByWorkNo(wn); 
        }
    }
}
