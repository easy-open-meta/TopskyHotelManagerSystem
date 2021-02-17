using System;
using System.Drawing;
using System.Windows.Forms;
using Sunny.UI;
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
        public static string wk_WorkerNation;
        public static string wk_WorkerEducation;

        public FrmChangeWorker()
        {
            InitializeComponent();
        }
        private void FrmChangeWorker_Load(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                item.Font = UI_FontUtil.roomControlFont;
            }
            if (AdminInfo.Type != "总经理")
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
            wk_WorkerNation = FrmWorkerManager.wk_WorkerNation;
            wk_WorkerEducation = FrmWorkerManager.wk_WorkerEducation;
            lblWorker.Text = FrmWorkerManager.wk_WorkerClub + FrmWorkerManager.wk_WorkerPosition + "：" + FrmWorkerManager.wk_WorkerName + "的操作界面";
            
            switch (wk_WorkerClub)
            {
                case "经理部":
                    this.BackgroundImage = Resources.经理部卡片;
                    this.btnWatchInfo.FillColor = Color.FromArgb(255, 105, 105);
                    this.btnUpdate.FillColor = Color.FromArgb(255, 105, 105);
                    this.btnUpWorker.FillColor = Color.FromArgb(255, 105, 105);
                    this.btnGoodBad.FillColor = Color.FromArgb(255, 105, 105);
                    this.btnClose.FillColor = Color.FromArgb(255, 105, 105);
                    this.btnCheck.FillColor = Color.FromArgb(255, 105, 105);
                    break;
                case "总经办":
                    this.BackgroundImage = Resources.总经办卡片;
                    this.btnWatchInfo.FillColor = Color.FromArgb(67, 123, 232);
                    this.btnUpdate.FillColor = Color.FromArgb(67, 123, 232);
                    this.btnUpWorker.FillColor = Color.FromArgb(67, 123, 232);
                    this.btnGoodBad.FillColor = Color.FromArgb(67, 123, 232);
                    this.btnClose.FillColor = Color.FromArgb(67, 123, 232);
                    this.btnCheck.FillColor = Color.FromArgb(67, 123, 232);
                    break;
                case "人力资源部":
                    this.BackgroundImage = Resources.人力资源部卡片; 
                    this.btnWatchInfo.FillColor = Color.FromArgb(101, 165, 72);
                    this.btnUpdate.FillColor = Color.FromArgb(101, 165, 72);
                    this.btnUpWorker.FillColor = Color.FromArgb(101, 165, 72);
                    this.btnGoodBad.FillColor = Color.FromArgb(101, 165, 72);
                    this.btnClose.FillColor = Color.FromArgb(101, 165, 72);
                    this.btnCheck.FillColor = Color.FromArgb(101, 165, 72);
                    break;
                case "财务部":
                    this.BackgroundImage = Resources.财务部卡片;
                    this.btnWatchInfo.FillColor = Color.FromArgb(80, 160, 255);
                    this.btnUpdate.FillColor = Color.FromArgb(80, 160, 255);
                    this.btnUpWorker.FillColor = Color.FromArgb(80, 160, 255);
                    this.btnGoodBad.FillColor = Color.FromArgb(80, 160, 255);
                    this.btnClose.FillColor = Color.FromArgb(80, 160, 255);
                    this.btnCheck.FillColor = Color.FromArgb(80, 160, 255);
                    break;
                case "酒店部":
                    this.BackgroundImage = Resources.酒店部卡片;
                    this.btnWatchInfo.FillColor = Color.FromArgb(255, 185, 38);
                    this.btnUpdate.FillColor = Color.FromArgb(255, 185, 38);
                    this.btnUpWorker.FillColor = Color.FromArgb(255, 185, 38);
                    this.btnGoodBad.FillColor = Color.FromArgb(255, 185, 38);
                    this.btnClose.FillColor = Color.FromArgb(255, 185, 38);
                    this.btnCheck.FillColor = Color.FromArgb(255, 185, 38);
                    break;
                case "内控部":
                    this.BackgroundImage = Resources.内控部卡片; 
                    var btnColor = Color.FromArgb(251, 157, 63);
                    this.btnWatchInfo.FillColor = btnColor;
                    this.btnUpdate.FillColor = btnColor;
                    this.btnUpWorker.FillColor = btnColor;
                    this.btnGoodBad.FillColor = btnColor;
                    this.btnClose.FillColor = btnColor;
                    this.btnCheck.FillColor = btnColor;
                    break;
                case "监管小组":
                    this.BackgroundImage = Resources.监管小组卡片;
                    this.btnWatchInfo.FillColor = Color.FromArgb(251, 186, 36);
                    this.btnUpdate.FillColor = Color.FromArgb(251, 186, 36);
                    this.btnUpWorker.FillColor = Color.FromArgb(251, 186, 36);
                    this.btnGoodBad.FillColor = Color.FromArgb(251, 186, 36);
                    this.btnClose.FillColor = Color.FromArgb(251, 186, 36);
                    this.btnCheck.FillColor = Color.FromArgb(251, 186, 36);
                    break;
                case "餐饮部":
                    this.BackgroundImage = Resources.餐饮部卡片;
                    this.btnWatchInfo.FillColor = Color.FromArgb(243, 160, 53);
                    this.btnUpdate.FillColor = Color.FromArgb(243, 160, 53);
                    this.btnUpWorker.FillColor = Color.FromArgb(243, 160, 53);
                    this.btnGoodBad.FillColor = Color.FromArgb(243, 160, 53);
                    this.btnClose.FillColor = Color.FromArgb(243, 160, 53);
                    this.btnCheck.FillColor = Color.FromArgb(243, 160, 53);
                    break;
                case "后勤部":
                    this.BackgroundImage = Resources.后勤部卡片;
                    this.btnWatchInfo.FillColor = Color.FromArgb(106, 229, 162);
                    this.btnUpdate.FillColor = Color.FromArgb(106, 229, 162);
                    this.btnUpWorker.FillColor = Color.FromArgb(106, 229, 162);
                    this.btnGoodBad.FillColor = Color.FromArgb(106, 229, 162);
                    this.btnClose.FillColor = Color.FromArgb(106, 229, 162);
                    this.btnCheck.FillColor = Color.FromArgb(106, 229, 162);
                    break;
                case "维修部":
                    this.BackgroundImage = Resources.维修部卡片; 
                    this.btnWatchInfo.FillColor = Color.FromArgb(16, 90, 152);
                    this.btnUpdate.FillColor = Color.FromArgb(16, 90, 152);
                    this.btnUpWorker.FillColor = Color.FromArgb(16, 90, 152);
                    this.btnGoodBad.FillColor = Color.FromArgb(16, 90, 152);
                    this.btnClose.FillColor = Color.FromArgb(16, 90, 152);
                    this.btnCheck.FillColor = Color.FromArgb(16, 90, 152);
                    break;
                case "商品部":
                    this.BackgroundImage = Resources.商品部卡片;
                    this.btnWatchInfo.FillColor = Color.FromArgb(18, 150, 219);
                    this.btnUpdate.FillColor = Color.FromArgb(18, 150, 219);
                    this.btnUpWorker.FillColor = Color.FromArgb(18, 150, 219);
                    this.btnGoodBad.FillColor = Color.FromArgb(18, 150, 219);
                    this.btnClose.FillColor = Color.FromArgb(18, 150, 219);
                    this.btnCheck.FillColor = Color.FromArgb(18, 150, 219);
                    break;
                default:
                    this.BackgroundImage = Resources.常规部门卡片;
                    this.btnWatchInfo.FillColor = Color.FromArgb(255, 200, 35);
                    this.btnUpdate.FillColor = Color.FromArgb(255, 200, 35);
                    this.btnUpWorker.FillColor = Color.FromArgb(255, 200, 35);
                    this.btnGoodBad.FillColor = Color.FromArgb(255, 200, 35);
                    this.btnClose.FillColor = Color.FromArgb(255, 200, 35);
                    this.btnCheck.FillColor = Color.FromArgb(255, 200, 35);

                    break;
            }
        }

        private void btnWatchInfo_Click(object sender, EventArgs e)
        {
            FrmAddWorker aff = new FrmAddWorker();
            aff.Text = "员工信息查看页";
            aff.ShowDialog();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmAddWorker frmAddWorker = new FrmAddWorker();
            frmAddWorker.Text = "员工信息修改页";
            frmAddWorker.ShowDialog();
        }
    }
}
