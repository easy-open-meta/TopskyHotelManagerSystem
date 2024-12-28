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
using EOM.TSHotelManager.FormUI.Properties;
using Sunny.UI;

namespace EOM.TSHotelManager.FormUI
{
    /// <summary>
    /// 员工操作界面
    /// </summary>
    public partial class FrmWorkerPanel : Form
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

        public FrmWorkerPanel()
        {
            InitializeComponent();
        }

        ResponseMsg result = null;
        Dictionary<string, string> dic = null;

        private void FrmChangeWorker_Load(object sender, EventArgs e)
        {
            if (AdminInfo.isAdmin == false && AdminInfo.Type != "GeneralManager" && AdminInfo.Type != "HRManager")
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
            wk_WorkerStatus = FrmWorkerManager.wk_WorkerStatus;
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

            switch (wk_WorkerStatus)
            {
                case "0":
                    btnBlockAccount.Text = "禁用账号";
                    btnBlockAccount.FillColor = Color.Red;
                    break;
                case "1":
                    btnBlockAccount.Text = "启用账号";
                    btnBlockAccount.FillColor = Color.Green;
                    btnBlockAccount.RectColor = Color.Green;
                    break;
            }
        }

        private void btnWatchInfo_Click(object sender, EventArgs e)
        {
            FrmWorkerInfo aff = new FrmWorkerInfo();
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
            FrmWorkerInfo frmAddWorker = new FrmWorkerInfo();
            frmAddWorker.Text = "员工信息修改页";
            frmAddWorker.Show();
        }

        private void btnBlockAccount_Click(object sender, EventArgs e)
        {
            //根据员工账号状态确定是否禁用或启用
            if (wk_WorkerStatus.Equals("1"))
            {
                Worker worker = new Worker
                {
                    WorkerId = wk_WorkerNo,
                    delete_mk = 0
                };
                result = HttpHelper.Request("Worker​/ManagerWorkerAccount", HttpHelper.ModelToJson(worker));
                if (result.statusCode != 200)
                {
                    UIMessageBox.ShowError("ManagerWorkerAccount+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                #region 获取添加操作日志所需的信息
                RecordHelper.Record(AdminInfo.Account + "-" + AdminInfo.Name + "在" + Convert.ToDateTime(DateTime.Now) + "位于" + AdminInfo.SoftwareVersion + "执行：" + "启用员工账号操作！新增值为：" + worker.WorkerId, 2);
                #endregion
                this.Close();
                FrmWorkerManager.Reload();
            }
            else
            {
                Worker worker = new Worker
                {
                    WorkerId = wk_WorkerNo,
                    delete_mk = 1
                };
                result = HttpHelper.Request("Worker​/ManagerWorkerAccount", HttpHelper.ModelToJson(worker));
                if (result.statusCode != 200)
                {
                    UIMessageBox.ShowError("ManagerWorkerAccount+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                #region 获取添加操作日志所需的信息
                RecordHelper.Record(AdminInfo.Account + "-" + AdminInfo.Name + "在" + Convert.ToDateTime(DateTime.Now) + "位于" + AdminInfo.SoftwareVersion + "执行：" + "禁用员工账号操作！新增值为：" + worker.WorkerId, 2);
                #endregion
                this.Close();
                FrmWorkerManager.Reload();
            }
        }
    }
}
