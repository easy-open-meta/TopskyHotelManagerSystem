using System;
using System.Windows.Forms;
using TSHotelManagerSystem.Models;
using TSHotelManagerSystem.Properties;

namespace TSHotelManagerSystem
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
            if(AdminInfo.adminType != "总经理")
            {
                btnUpWorker.Enabled = false;
                btnUpWorker.Text = "权限不足";
                btnCheck.Enabled = false;
                btnCheck.Text = "权限不足";
                btnGoodBad.Enabled = false;
                btnGoodBad.Text = "权限不足";
            }

            wk_WorkerNo = FrmTopChange.wk_WorkerNo;
            wk_WorkerName = FrmTopChange.wk_WorkerName;
            wk_WorkerBirthday = FrmTopChange.wk_WorkerBirthday;
            wk_WorkerSex = FrmTopChange.wk_WorkerSex;
            wk_WorkerTel = FrmTopChange.wk_WorkerTel;
            wk_WorkerClub = FrmTopChange.wk_WorkerClub;
            wk_WorkerAddress = FrmTopChange.wk_WorkerAddress;
            wk_WorkerPosition = FrmTopChange.wk_WorkerPosition;
            wk_WorkerID = FrmTopChange.wk_WorkerID;
            wk_WorkerPwd = FrmTopChange.wk_WorkerPwd;
            wk_WorkerTime = FrmTopChange.wk_WorkerTime;
            wk_WorkerFace = FrmTopChange.wk_WorkerFace;
            wk_WorkerEducation = FrmTopChange.wk_WorkerEducation;
            lblWorker.Text = FrmTopChange.wk_WorkerClub + FrmTopChange.wk_WorkerPosition + "：" + FrmTopChange.wk_WorkerName + "的操作界面";
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
                aff.label13.Text = "员工信息查看页";
                aff.ShowDialog();
            }
            else if (dr == DialogResult.No)
            {
                FrmAddWorker frmAddWorker = new FrmAddWorker();
                frmAddWorker.label13.Text = "员工信息修改页";
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
