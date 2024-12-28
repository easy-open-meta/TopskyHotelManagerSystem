/*
 * MIT License
 *Copyright (c) 2021 易开元(EOM)

 *Permission is hereby granted, free of charge, to any person obtaining a copy
 *of this software and associated documentation files (the "Software"), to deal
 *in the Software without restriction, including without limitation the rights
 *to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 *copies of the Software, and to permit persons to whom the Software is
 *furnished to do so, subject to the following conditions:

 *The above copyright notice and this permission notice shall be included in all
 *copies or substantial portions of the Software.

 *THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 *IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 *FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 *AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 *LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 *OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 *SOFTWARE.
 *
 */

using EOM.TSHotelManager.Common;
using EOM.TSHotelManager.Common.Core;
using Sunny.UI;

namespace EOM.TSHotelManager.FormUI
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
        public static string wk_WorkerNation;
        public static string wk_WorkerEducation;
        public static string wk_WorkerStatus;

        public delegate void ReLoadWorkerList();


        //定义委托类型的变量
        public static ReLoadWorkerList Reload;

        public FrmWorkerManager()
        {
            InitializeComponent();
            Reload = LoadWorker;
        }

        Dictionary<string, string> dic = null;
        ResponseMsg result = null;

        private void LoadWorker()
        {
            result = HttpHelper.Request("Worker/SelectWorkerAll");
            if (result.statusCode != 200)
            {
                UIMessageTip.ShowError("SelectWorkerAll+接口服务异常，请提交issue");
                return;
            }
            dgvWorkerList.AutoGenerateColumns = false;
            dgvWorkerList.DataSource = HttpHelper.JsonToList<Worker>(result.message);
        }

        private void FrmTopChange_Load(object sender, EventArgs e)
        {
            LoadWorker();
            if (AdminInfo.isAdmin == false && AdminInfo.Type != "GeneralManager" && AdminInfo.Type != "HRManager")
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
                wk_WorkerNation = dgvWorkerList.SelectedRows[0].Cells["clWorkerNation"].Value.ToString();
                wk_WorkerStatus = dgvWorkerList.SelectedRows[0].Cells["Column1"].Value.ToString();
                FrmWorkerPanel aff = new FrmWorkerPanel();
                aff.ShowDialog();

            }
        }



        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            FrmWorkerInfo frm = new FrmWorkerInfo();
            frm.Show();
        }

        private void btnRefush_Click(object sender, EventArgs e)
        {
            LoadWorker();
        }
    }
}
