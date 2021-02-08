using System.Collections.Generic;
using SYS.Core;
using SYS.Application;

namespace SYS.Manager
{
    public class OperationManager
    {
        public static int InsertOperationLog(Operation opr)
        {
            return OperationService.InsertOperationLog(opr);
        }
        public static List<OperationLog> SelectOperationlogAll()
        {
            return Operationlog.SelectOperationlogAll();
        }
    }
}