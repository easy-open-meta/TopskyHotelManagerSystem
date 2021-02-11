using System.Collections.Generic;
using SYS.Core;
using SYS.Application;

namespace SYS.Manager
{
    public class OperationManager
    {
        public static int InsertOperationLog(OperationLog opr)
        {
            return OperationService.InsertOperationLog(opr);
        }
        public static List<OperationLog> SelectOperationlogAll()
        {
            return Operationlog.SelectOperationlogAll();
        }
    }
}