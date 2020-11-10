using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using SYS.Core;

namespace SYS.Application
{
    public class WorkerService
    {

        #region 修改员工信息
        /// <summary>
        /// 修改员工信息
        /// </summary>
        /// <param name="worker"></param>
        /// <returns></returns>
        public static int UpdateWorker(Worker worker)
        {
            string sql = "update WORKERINFO set WorkerTel = '"+worker.WorkerTel+"',WorkerAddress = '"+worker.WorkerAddress+"',WorkerPwd = '"+worker.WorkerPwd+"',WorkerFace = '"+worker.WorkerFace+"',WorkerEducation = '"+worker.WorkerEduction+"',WorkerSex = '"+worker.WorkerSex+"' where WorkerId = '"+worker.WorkerId+"'";
            return DBHelper.ExecuteNonQuery(sql);
        }
        #endregion


        #region 添加员工信息
        /// <summary>
        /// 添加员工信息
        /// </summary>
        /// <param name="worker"></param>
        /// <returns></returns>
        public static int AddWorker(Worker worker)
        {
            string sql = "insert into WORKERINFO values('" + worker.WorkerId + "','" + worker.WorkerName + "','" + worker.WorkerBirth + "','" + worker.WorkerSex + "','" + worker.WorkerTel + "','" + worker.WorkerClub + "','" + worker.WorkerAddress + "','" + worker.WorkerPosition + "','" + worker.CardId + "','" + worker.WorkerPwd + "','" + worker.WorkerTime + "','" + worker.WorkerFace + "','" + worker.WorkerEduction + "')";
            return DBHelper.ExecuteNonQuery(sql);
        }
        #endregion

        #region 获取所有工作人员信息
        /// <summary>
        /// 获取所有工作人员信息
        /// </summary>
        /// <returns></returns>
        public static List<Worker> SelectWorkerAll()
        {
            List<Worker> workers = new List<Worker>();
            string sql = "select * from WORKERINFO";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Worker worker = new Worker();
                worker.WorkerId = (string)dr["WorkerId"];
                worker.WorkerName = dr["WorkerName"].ToString();
                worker.WorkerBirth = DateTime.Parse(dr["WorkerBirthday"].ToString());
                worker.WorkerSex = Convert.ToString(dr["WorkerSex"]);
                worker.WorkerTel = (string)dr["WorkerTel"];
                worker.WorkerClub = (string)dr["WorkerClub"];
                worker.WorkerAddress = (string)dr["WorkerAddress"];
                worker.WorkerPosition = (string)dr["WorkerPosition"];
                worker.CardId = (string)dr["CardId"];
                worker.WorkerPwd = (string)dr["WorkerPwd"];
                worker.WorkerTime = DateTime.Parse(dr["WorkerTime"].ToString());
                worker.WorkerFace = (string)dr["WorkerFace"];
                worker.WorkerEduction = (string)dr["WorkerEducation"];
                workers.Add(worker);
            }
            dr.Close();
            DBHelper.Closecon();
            return workers;
        }
        #endregion

        #region 根据登录名称查询员工信息
        /// <summary>
        /// 根据登录名称查询员工信息
        /// </summary>
        /// <param name="workerId"></param>
        /// <returns></returns>
        public static Worker SelectWorkerInfoByWorkerId(string workerId)
        {
            Worker w = null;
            string sql = "select * from WORKERINFO where WorkerId='" + workerId + "'";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            if (dr.Read())
            {
                w = new Worker();
                w.WorkerId = (string)dr["WorkerId"];
                w.WorkerName = dr["WorkerName"].ToString();
                w.WorkerBirth = DateTime.Parse(dr["WorkerBirthday"].ToString());
                w.WorkerSex = Convert.ToString(dr["WorkerSex"]);
                w.WorkerTel = (string)dr["WorkerTel"];
                w.WorkerClub = (string)dr["WorkerClub"];
                w.WorkerAddress = (string)dr["WorkerAddress"];
                w.WorkerPosition = (string)dr["WorkerPosition"];
                w.CardId = (string)dr["CardId"];
                w.WorkerPwd = (string)dr["WorkerPwd"];
                w.WorkerTime = DateTime.Parse(dr["WorkerTime"].ToString());
                w.WorkerFace = (string)dr["WorkerFace"];
            }
            dr.Close();
            DBHelper.Closecon();
            return w;
        }
        #endregion

        #region 根据登录名称、密码查询员工信息
        /// <summary>
        /// 根据登录名称、密码查询员工信息
        /// </summary>
        /// <param name="id"></param>
        /// 登录名称
        /// <param name="pwd"></param>
        /// 登录密码
        /// <returns></returns>
        public static Worker SelectWorkerInfoByWorkerIdAndWorkerPwd(string id, string pwd)
        {
            Worker w = null;
            string sql = "select * from WORKERINFO where WorkerId='{0}' and WorkerPwd='{1}'";
            sql = string.Format(sql, id, pwd);
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            if (dr.Read())
            {
                w = new Worker();
                w.WorkerId = (string)dr["WorkerId"];
                w.WorkerName = dr["WorkerName"].ToString();
                w.WorkerBirth = DateTime.Parse(dr["WorkerBirthday"].ToString());
                w.WorkerSex = Convert.ToString(dr["WorkerSex"]);
                w.WorkerTel = (string)dr["WorkerTel"];
                w.WorkerClub = (string)dr["WorkerClub"];
                w.WorkerAddress = (string)dr["WorkerAddress"];
                w.WorkerPosition = (string)dr["WorkerPosition"];
                w.CardId = (string)dr["CardId"];
                w.WorkerPwd = (string)dr["WorkerPwd"];
                w.WorkerTime = DateTime.Parse(dr["WorkerTime"].ToString());
                w.WorkerFace = (string)dr["WorkerFace"];
            }
            dr.Close();
            DBHelper.Closecon();
            return w;
        }
        #endregion
    }
}
