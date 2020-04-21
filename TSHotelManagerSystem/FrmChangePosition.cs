﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using TSHotelManagerSystem.BLL;
using TSHotelManagerSystem.DAL;
using TSHotelManagerSystem.Models;

namespace TSHotelManagerSystem
{
    public partial class FrmChangePosition : Form
    {
        public static string wk_WorkerNo;
        public static string wk_WorkerPosition;
        public static string wk_WorkerName;
        public static string wk_WorkerClub;
        public FrmChangePosition()
        {
            InitializeComponent();
        }

        private void FrmChangePosition_Load(object sender, EventArgs e)
        {
            txtworkerId.Text = FrmChangeWorker.wk_WorkerNo;
            txtworkerName.Text = FrmChangeWorker.wk_WorkerName;
            cboClub.Text = FrmChangeWorker.wk_WorkerClub;
            cboPosition.Text = FrmChangeWorker.wk_WorkerPosition;
        }

        private void cboNewClub_TextChanged(object sender, EventArgs e)
        {
            this.Text = "将" + FrmChangeWorker.wk_WorkerClub + "：" + FrmChangeWorker.wk_WorkerName + "任命为：" + cboNewClub.Text + "的" + cboNewPosition.Text + "";
        }

        private void cboNewPosition_TextChanged(object sender, EventArgs e)
        {
            this.Text = "将" + FrmChangeWorker.wk_WorkerClub + "：" + FrmChangeWorker.wk_WorkerName + "任命为：" + cboNewClub.Text + "的" + cboNewPosition.Text + "";

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string sql = "update WORKERINFO set WorkerClub='" + cboNewClub.Text + "',WorkerPosition='" + cboNewPosition.Text + "' where WorkerId='" + txtworkerId.Text + "'";
            SqlConnection con = DBHelper.GetConnection();
            int n = DBHelper.ExecuteNonQuery(sql);
            if (n > 0)
            {
                MessageBox.Show("任命已生效!");
                #region 获取添加操作日志所需的信息
                Operation o = new Operation();
                o.OperationTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd,HH:mm:ss"));
                o.Operationlog = AdminInfo.admingroup + AdminInfo.adminType + "于" + DateTime.Now + "将员工：" + txtworkerName.Text + "晋升为" + cboNewClub.Text + cboNewPosition.Text;
                o.OperationAccount = AdminInfo.admingroup + AdminInfo.adminType;
                #endregion
                OperationManager.InsertOperationLog(o);
            }


        }
    }
}
