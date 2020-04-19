using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSHotelManagerSystem.DAL;
using TSHotelManagerSystem.Models;

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