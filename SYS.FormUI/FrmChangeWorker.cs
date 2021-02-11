using System;
using System.Windows.Forms;
using SYS.Core;
using SYS.FormUI.Properties;

namespace SYS.FormUI
{
    public partial class FrmChangeWorker : Form
    {
        public static string wk_WorkerNo;
        public static string wk_WorkerName;
        public static string wk_WorkerBirthday;
        public static string wk_WorkerSex;
        public static string wk_WorkerTel;
        public static string wk_WorkerClub;
        public static string wk_WorkerAddress;
        public static string wk_WorkerPosition;
        public static string wk_WorkerID;
        public static string wk_WorkerPwd;
        public static string wk_WorkerTime;
        public static string wk_WorkerFace;
        public static string wk_WorkerEducation;

        public FrmChangeWorker()
        {
            InitializeComponent();
        }

        private void FrmChangeWorker_Load(object sender, EventArgs e)
        {
            if(AdminInfo.Type != "总经理")
            {
                btnUpWorker.Enabled = false;
                btnUpWorker.Text = "权限不足";
                btnCheck.Enabled = false;
                btnCheck.Text = "权限不足";
                btnGoodBad.Enabled = false;
                btnGoodBad.Text = "权限不足";
            }

            wk_WorkerNo = FrmWorkerManager.wk_WorkerNo;
            wk_WorkerName = FrmWorkerManager.wk_WorkerName;
            wk_WorkerBirthday = FrmWorkerManager.wk_WorkerBirthday;
            wk_WorkerSex = FrmWorkerManager.wk_WorkerSex;
            wk_WorkerTel = FrmWorkerManager.wk_WorkerTel;
            wk_WorkerClub = FrmWorkerManager.wk_WorkerClub;
            wk_WorkerAddress = FrmWorkerManager.wk_WorkerAddress;
            wk_WorkerPosition = FrmWorkerManager.wk_WorkerPosition;
            wk_WorkerID = FrmWorkerManager.wk_WorkerID;
            wk_WorkerPwd = FrmWorkerManager.wk_WorkerPwd;
            wk_WorkerTime = FrmWorkerManager.wk_WorkerTime;
            wk_WorkerFace = FrmWorkerManager.wk_WorkerFace;
            wk_WorkerEducation = FrmWorkerManager.wk_WorkerEducation;
            lblWorker.Text = FrmWorkerManager.wk_WorkerClub + FrmWorkerManager.wk_WorkerPosition + "：" + FrmWorkerManager.wk_WorkerName + "的操作界面";
            if (wk_WorkerClub == "餐饮部")
            {
                this.BackgroundImage = Resources.餐饮部界面;
            }
            else if (wk_WorkerClub == "经理部")
            {
                this.BackgroundImage = Resources.经理部界面;
            }
            else if (wk_WorkerClub == "人事部")
            {
                this.BackgroundImage = Resources.人事部界面;
            }
            else if (wk_WorkerClub == "财务部")
            {
                this.BackgroundImage = Resources.财务部界面;
            }
            else if (wk_WorkerClub == "后勤部")
            {
                this.BackgroundImage = Resources.后勤部界面;
            }
            else if (wk_WorkerClub == "酒店部")
            {
                this.BackgroundImage = Resources.酒店部界面;
            }
        }

        private void btnWatchInfo_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("你要查看信息还是修改信息？('是'则为查看信息/‘否’则为修改信息/'取消'则为取消操作)", "系统提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                FrmAddWorker aff = new FrmAddWorker();
                aff.Text = "员工信息查看页";
                aff.ShowDialog();
            }
            else if (dr == DialogResult.No)
            {
                FrmAddWorker frmAddWorker = new FrmAddWorker();
                frmAddWorker.Text = "员工信息修改页";
                frmAddWorker.ShowDialog();
            }
            else
            {
                MessageBox.Show("操作取消！");
            }
        }

        private void btnUpWorker_Click(object sender, EventArgs e)
        {
            FrmChangePosition aff = new FrmChangePosition();
            aff.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            FrmWorkerCheckInfo frm = new FrmWorkerCheckInfo();
            frm.Show();
        }

        private void btnGoodBad_Click(object sender, EventArgs e)
        {
            FrmGoodOrBad frm = new FrmGoodOrBad();
            frm.Show();
        }
    }
}
