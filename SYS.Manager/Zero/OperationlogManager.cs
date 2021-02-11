using System.Collections.Generic;
using SYS.Core;
using SYS.Application;

namespace SYS.Manager
{
    public class OperationlogManager
    {
        public static int InsertOperationLog(OperationLog opr)
        {
            return OperationlogService.InsertOperationLog(opr);
        }
        public static List<OperationLog> SelectOperationlogAll()
        {
            return OperationlogService.SelectOperationlogAll();
        }
    }
}