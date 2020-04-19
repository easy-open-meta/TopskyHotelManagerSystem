using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSHotelManagerSystem.Models;

namespace TSHotelManagerSystem.DAL
{
   public class WorkerHistoryService
    {

        public static int AddHistoryByWorkerId(WorkerHistory workerHistory,string wid)
        {
            string sql = "insert into WorkerHistory values('" + wid + "','" + workerHistory.StartDate + "','" + workerHistory.EndDate + "','" + workerHistory.Postion + "','" + workerHistory.Company + "')";
            return DBHelper.ExecuteNonQuery(sql);
        }

        public static List<WorkerHistory> SelectHistoryByWorkerId(string wid)
        {
            List<WorkerHistory> why = new List<WorkerHistory>();
            string sql = "SELECT * FROM WORKERINFO wi,WORKERHISTORY wh where wi.WorkerId = wh.WorkerId and wi.WorkerId = '"+wid+"'";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                WorkerHistory workerHistory = new WorkerHistory();
                workerHistory.WorkerId = dr["WorkerId"].ToString();
                workerHistory.StartDate = DateTime.Parse(dr["StartDate"].ToString());
                workerHistory.EndDate = DateTime.Parse(dr["EndDate"].ToString());
                workerHistory.Postion = dr["Position"].ToString();
                workerHistory.Company = dr["Company"].ToString();
                why.Add(workerHistory);
            }
            dr.Close();
            DBHelper.Closecon();
            return why;
        }
    }
}
