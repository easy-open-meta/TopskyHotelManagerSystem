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
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using SYS.Core;
using Sunny.UI;
using SYS.Application;
using SYS.Common;

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

        private void FrmChangePosition_Load(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                item.Font = UI_FontUtil.scorllingFont;
            }
            txtworkerId.Text = FrmChangeWorker.wk_WorkerNo;
            txtworkerName.Text = FrmChangeWorker.wk_WorkerName;
            txtClub.Text = FrmChangeWorker.wk_WorkerClub;
            txtPosition.Text = FrmChangeWorker.wk_WorkerPosition;
            //获取所有职位信息
            cboNewPosition.DataSource =  new BaseService().SelectPositionAllCanUse();
            cboNewPosition.DisplayMember = "position_name";
            cboNewPosition.ValueMember = "position_no";
            //获取所有部门信息
            cboNewClub.DataSource = new BaseService().SelectDeptAllCanUse();
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
                WorkerId = txtworkerId.Text
            };
             bool n = new WorkerService().UpdateWorkerPositionAndClub(worker);
            if (n == true)
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
