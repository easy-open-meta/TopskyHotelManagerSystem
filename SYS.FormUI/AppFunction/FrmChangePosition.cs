/*
 * MIT License
 *Copyright (c) 2021 咖啡与网络(java-and-net)

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
using System;

using System.Windows.Forms;
using EOM.TSHotelManager.Common.Core;
using Sunny.UI;

using SYS.Common;
using System.Collections.Generic;

namespace SYS.FormUI
{
    public partial class FrmChangePosition : UIForm
    {
        public static string wk_WorkerNo;
        public static string wk_WorkerPosition;
        public static string wk_WorkerName;
        public static string wk_WorkerClub;
        public FrmChangePosition()
        {
            InitializeComponent();
        }

        ResponseMsg result = null;
        Dictionary<string, string> dic = null;

        private void FrmChangePosition_Load(object sender, EventArgs e)
        {
            txtworkerId.Text = FrmChangeWorker.wk_WorkerNo;
            txtworkerName.Text = FrmChangeWorker.wk_WorkerName;
            txtClub.Text = FrmChangeWorker.wk_WorkerClub;
            txtPosition.Text = FrmChangeWorker.wk_WorkerPosition;
            //获取所有职位信息
            dic= new Dictionary<string, string>()
            {
                { "delete_mk","0"}
            };
            result = HttpHelper.Request("Base/SelectPositionAll",null,dic);
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectPositionAll+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            cboNewPosition.DataSource = HttpHelper.JsonToList<Position>(result.message);
            cboNewPosition.DisplayMember = "position_name";
            cboNewPosition.ValueMember = "position_no";
            //获取所有部门信息
            result = HttpHelper.Request("Base/SelectDeptAllCanUse");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectDeptAllCanUse+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            cboNewClub.DataSource = HttpHelper.JsonToList<Dept>(result.message);
            cboNewClub.DisplayMember = "dept_name";
            cboNewClub.ValueMember = "dept_no";
        }

        private void cboNewClub_TextChanged(object sender, EventArgs e)
        {
            this.Text = "将" + FrmChangeWorker.wk_WorkerClub + "：" + FrmChangeWorker.wk_WorkerName + "任命为：" + cboNewClub.Text + "的" + cboNewPosition.Text + "";
        }

        private void cboNewPosition_TextChanged(object sender, EventArgs e)
        {
            this.Text = "将" + FrmChangeWorker.wk_WorkerClub + "：" + FrmChangeWorker.wk_WorkerName + "任命为：" + cboNewClub.Text + "的" + cboNewPosition.Text + "";

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Worker worker = new Worker()
            {
                WorkerClub = cboNewClub.SelectedValue.ToString(),
                WorkerPosition = cboNewPosition.SelectedValue.ToString(),
                WorkerId = txtworkerId.Text,
                datachg_usr = AdminInfo.Account
            };
            result = HttpHelper.Request("Worker​/UpdateWorkerPositionAndClub", HttpHelper.ModelToJson(worker));
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("UpdateWorkerPositionAndClub+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            bool n = result.message.ToString().Equals("true");
            if (n)
            {
                UIMessageBox.ShowSuccess("任命已生效!");
                #region 获取添加操作日志所需的信息
                RecordHelper.Record(AdminInfo.Account + "-" + AdminInfo.Name + "在" + DateTime.Now + "位于" + AdminInfo.SoftwareVersion + "执行：" + "职位任命操作！任命值为：" + worker.WorkerId, 2);
                #endregion
                FrmWorkerManager.Reload();
                this.Close();
            }
        }

    }
}
