using System.Collections.Generic;
using Core;
using SYS.Application;

namespace TSHotelManagerSystem.BLL
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