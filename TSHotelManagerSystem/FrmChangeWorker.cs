using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public FrmChangeWorker()
        {
            InitializeComponent();
        }

        private void FrmChangeWorker_Load(object sender, EventArgs e)
        {
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
            lblWorker.Text = FrmTopChange.wk_WorkerClub + FrmTopChange.wk_WorkerPosition+"："+FrmTopChange.wk_WorkerName+"的操作界面";
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
            FrmWorkerInfo aff = new FrmWorkerInfo();
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
    }
}
