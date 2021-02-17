using Sunny.UI;
using SYS.Application;
using System;
using System.Windows.Forms;

namespace SYS.FormUI
{
    public partial class FrmWorkerCheckInfo : UIForm
    {
        public FrmWorkerCheckInfo()
        {
            InitializeComponent();

        }



        private void FrmWorkerCheckInfo_Load(object sender, EventArgs e)
        {
            foreach (Control label in this.Controls)
            {
                label.Font = UI_FontUtil.childControlFont;
            }
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
