using System;
using System.ComponentModel;
using System.Windows.Forms;
using Sunny.UI;
using SYS.Application;
using SYS.Core;

namespace SYS.FormUI
{
    public partial class FrmWorkerManager : UIForm
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

        public delegate void ReLoadWorkerList();


        //定义委托类型的变量
        public static ReLoadWorkerList Reload;

        public FrmWorkerManager()
        {
            InitializeComponent();
            Reload = LoadWorker;
        }

        private void LoadWorker()
        {
            dgvWorkerList.DataSource = new WorkerService().SelectWorkerAll();
        }

        private void FrmTopChange_Load(object sender, EventArgs e)
        {
            dgvWorkerList.AutoGenerateColumns = false;
            dgvWorkerList.DataSource = new WorkerService().SelectWorkerAll();
            if (AdminInfo.Type != "总经理" && AdminInfo.Type != "人力资源部经理")
            {
                btnAddWorker.Enabled = false;
                btnAddWorker.Text = "权限不足";
            }
        }

        private void dgvWorkerList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvWorkerList.Rows.Count > 1)
            {
                wk_WorkerNo = dgvWorkerList.SelectedRows[0].Cells["clWorkerNo"].Value.ToString();
                wk_WorkerName = dgvWorkerList.SelectedRows[0].Cells["clWorkerName"].Value.ToString();
                wk_WorkerBirthday = dgvWorkerList.SelectedRows[0].Cells["clWorkerBirthday"].Value.ToString();
                wk_WorkerSex = dgvWorkerList.SelectedRows[0].Cells["clWorkerSex"].Value.ToString();
                wk_WorkerTel = dgvWorkerList.SelectedRows[0].Cells["clWorkerTel"].Value.ToString();
                wk_WorkerClub = dgvWorkerList.SelectedRows[0].Cells["clWorkerClub"].Value.ToString();
                wk_WorkerAddress = dgvWorkerList.SelectedRows[0].Cells["clWorkerAddress"].Value.ToString();
                wk_WorkerPosition = dgvWorkerList.SelectedRows[0].Cells["clWorkerPosition"].Value.ToString();
                wk_WorkerID = dgvWorkerList.SelectedRows[0].Cells["clWorkerCardID"].Value.ToString();
                wk_WorkerPwd = dgvWorkerList.SelectedRows[0].Cells["clWorkerPwd"].Value.ToString();
                wk_WorkerTime = dgvWorkerList.SelectedRows[0].Cells["clWorkerTime"].Value.ToString();
                wk_WorkerFace = dgvWorkerList.SelectedRows[0].Cells["clWorkerFace"].Value.ToString();
                wk_WorkerEducation = dgvWorkerList.SelectedRows[0].Cells["clWorkerEducation"].Value.ToString();
                FrmChangeWorker aff = new FrmChangeWorker();
                this.Close();
                aff.Show();

            }
        }

        

        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            FrmAddWorker frm = new FrmAddWorker();
            frm.Show();
        }

        private void btnRefush_Click(object sender, EventArgs e)
        {
            LoadWorker();
        }
    }
}
