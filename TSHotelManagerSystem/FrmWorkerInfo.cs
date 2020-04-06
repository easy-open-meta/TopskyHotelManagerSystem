using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSHotelManagerSystem
{
    public partial class FrmWorkerInfo : Form
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

        public FrmWorkerInfo()
        {
            InitializeComponent();
        }

        private void FrmWorkerInfo_Load(object sender, EventArgs e)
        {
            WorkerNo.Text = FrmChangeWorker.wk_WorkerNo;
            WorkerName.Text = FrmChangeWorker.wk_WorkerName;
            dtpBirthday.Value = DateTime.Parse(FrmChangeWorker.wk_WorkerBirthday);
            cboSex.Text = FrmChangeWorker.wk_WorkerSex;
            WorkerTel.Text = FrmChangeWorker.wk_WorkerTel;
            cboClub.Text = FrmChangeWorker.wk_WorkerClub;
            txtAddress.Text = FrmChangeWorker.wk_WorkerAddress;
            cboWorkerPosition.Text = FrmChangeWorker.wk_WorkerPosition;
            WorkerID.Text = FrmChangeWorker.wk_WorkerID;
            Pwd.Text = FrmChangeWorker.wk_WorkerPwd;
            dtpTime.Value= DateTime.Parse(FrmChangeWorker.wk_WorkerTime);
            cboWorkerFace.Text = FrmChangeWorker.wk_WorkerFace;
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
