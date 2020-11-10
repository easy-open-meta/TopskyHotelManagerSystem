using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Core;

namespace SYS.Application
{
    public class WorkerCheckService
    {
        /// <summary>
        /// 根据员工编号查询其所有的打卡记录
        /// </summary>
        /// <param name="wid"></param>
        /// <returns></returns>
        public static List<WorkerCheck> SelectCheckInfoByWorkerNo(string wid)
        {
            List<WorkerCheck> workerChecks = new List<WorkerCheck>();
            string sql = "select * from WorkerCheck where WorkerNo = '" + wid + "'";
            DBHelper.Opencon();
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                WorkerCheck workerCheck = new WorkerCheck();
                workerCheck.WorkerNo = dr["WorkerNo"].ToString();
                workerCheck.CheckTime = (DateTime)dr["CheckTime"];
                workerCheck.CheckWay = dr["CheckWay"].ToString();
                if (Convert.ToInt32(dr["CheckState"]) == 0)
                {
                    workerCheck.CheckState = "打卡成功";
                }
                else
                {
                    workerCheck.CheckState = "打卡失败";
                }
                workerChecks.Add(workerCheck);
            }
            dr.Close();
            DBHelper.Closecon();
            return workerChecks;
        }


        /// <summary>
        /// 查询员工签到天数
        /// </summary>
        /// <param name="wkn"></param>
        /// <returns></returns>
        public static object SelectWorkerCheckDaySumByWorkerNo(string wkn)
        {
            string sql = "SELECT COUNT(*) FROM WORKERCHECK WHERE workerNo = '" + wkn + "'";
            return DBHelper.ExecuteScalar(sql);
        }


        /// <summary>
        /// 查询今天员工是否已签到
        /// </summary>
        /// <param name="wkn"></param>
        /// <returns></returns>
        public static object SelectToDayCheckInfoByWorkerNo(string wkn)
        {
            string sql = "select Count(*) from WORKERCHECK where WorkerNo = '"+wkn+"' and DateDiff(dd,CheckTime,getdate())=0";
            return DBHelper.ExecuteScalar(sql);
        }

        /// <summary>
        /// 添加员工打卡数据
        /// </summary>
        /// <param name="workerCheck"></param>
        /// <returns></returns>
        public static int AddCheckInfo(WorkerCheck workerCheck)
        {
            string sql = "insert into WORKERCHECK values('" + workerCheck.WorkerNo + "','"+workerCheck.CheckTime+"','" + workerCheck.CheckWay + "','0')";
            return DBHelper.ExecuteNonQuery(sql);
        }
    }
}
