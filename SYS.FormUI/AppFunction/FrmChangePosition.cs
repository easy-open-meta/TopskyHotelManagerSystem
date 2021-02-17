using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using SYS.Core;
using Sunny.UI;
using SYS.Application;

namespace SYS.FormUI
{
    public partial class FrmChangePosition : UIForm
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
            foreach (Control item in this.Controls)
            {
                item.Font = UI_FontUtil.scorllingFont;
            }
            txtworkerId.Text = FrmChangeWorker.wk_WorkerNo;
            txtworkerName.Text = FrmChangeWorker.wk_WorkerName;
            txtClub.Text = FrmChangeWorker.wk_WorkerClub;
            txtPosition.Text = FrmChangeWorker.wk_WorkerPosition;
            //获取所有职位信息
<<<<<<< HEAD
            cboNewPosition.DataSource =  new BaseService().SelectPositionAll();
            cboNewPosition.DisplayMember = "position_name";
            cboNewPosition.ValueMember = "position_no";
            //获取所有部门信息
            cboNewClub.DataSource = new BaseService().SelectDeptAll();
=======
            cboNewPosition.DataSource =  new BaseService().SelectPositionAllCanUse();
            cboNewPosition.DisplayMember = "position_name";
            cboNewPosition.ValueMember = "position_no";
            //获取所有部门信息
            cboNewClub.DataSource = new BaseService().SelectDeptAllCanUse();
>>>>>>> fb009c4fe69c0285ef7856f5960db104eecbccf7
            cboNewClub.DisplayMember = "dept_name";
            cboNewClub.ValueMember = "dept_no";
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
            Worker worker = new Worker()
            {
<<<<<<< HEAD
                WorkerClub = cboNewClub.ValueMember,
                WorkerPosition = cboNewPosition.ValueMember,
=======
                WorkerClub = cboNewClub.SelectedValue.ToString(),
                WorkerPosition = cboNewPosition.SelectedValue.ToString(),
>>>>>>> fb009c4fe69c0285ef7856f5960db104eecbccf7
                WorkerId = txtworkerId.Text
            };
             bool n = new WorkerService().UpdateWorkerPositionAndClub(worker);
            if (n == true)
            {
                MessageBox.Show("任命已生效!");
                #region 获取添加操作日志所需的信息
                OperationLog o = new OperationLog();
                o.OperationTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd,HH:mm:ss"));
                o.Operationlog = AdminInfo.Account + AdminInfo.Name + "于" + DateTime.Now + "将员工：" + txtworkerName.Text + "晋升/降级为" + cboNewClub.Text + cboNewPosition.Text;
                o.OperationAccount = AdminInfo.Account;
                o.datains_usr = AdminInfo.Account;
                o.datains_date = DateTime.Now;
                #endregion
                new OperationlogService().InsertOperationLog(o);
<<<<<<< HEAD
=======
                FrmWorkerManager.Reload();
>>>>>>> fb009c4fe69c0285ef7856f5960db104eecbccf7
            }


        }

    }
}
