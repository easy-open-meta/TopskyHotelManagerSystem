using SYS.Application;
using System;
using System.Windows.Forms;

namespace SYS.FormUI
{
    public partial class FrmWorkerCheckInfo : Form
    {
        public FrmWorkerCheckInfo()
        {
            InitializeComponent();

        }



        private void FrmWorkerCheckInfo_Load(object sender, EventArgs e)
        {
            lblWorkerInfo.Text = "以下为员工编号：" + FrmChangeWorker.wk_WorkerNo + "员工姓名：" + FrmChangeWorker.wk_WorkerName + "的所有打卡考勤记录:";
            DgvCheckInfoList.AutoGenerateColumns = false;
            DgvCheckInfoList.DataSource = new WorkerCheckService().SelectCheckInfoByWorkerNo(FrmChangeWorker.wk_WorkerNo);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
