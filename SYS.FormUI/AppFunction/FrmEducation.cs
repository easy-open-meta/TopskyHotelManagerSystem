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

using EOM.TSHotelManager.Common.Core;
using Sunny.UI;
using SYS.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SYS.FormUI
{
    public partial class FrmEducation : UIForm
    {
        public delegate void OperationEducation();


        //定义委托类型的变量
        public static OperationEducation operation;

        public static OperationEducation reload;

        public FrmEducation()
        {
            InitializeComponent();
            reload = ReloadEducationList;
        }
        List<Education> educations = null;
        public static string info = null;
        private void FrmEducation_Load(object sender, EventArgs e)
        {
            ReloadEducationList();
        }

        ResponseMsg result = null;
        Dictionary<string, string> dic = null;

        public void ReloadEducationList()
        {
            //flpInformation.Controls.Clear();
            txtEducationNo.Text = Util.GetListNewId("E", 3, 1, "-").FirstOrDefault();
            result = HttpHelper.Request("Base/SelectEducationAll");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectEducationAll+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            educations = HttpHelper.JsonToList<Education>(result.message);
            dgvEducationList.AutoGenerateColumns = false;
            dgvEducationList.DataSource = educations;
        }

        private void btnAddEducation_Click(object sender, EventArgs e)
        {
            if (txtEducationName.Text.Trim().IsNullOrEmpty())
            {
                UIMessageTip.ShowWarning("学历名称为空，请检查", 1500);
                txtEducationName.Focus();
                return;
            }
            var edu = new Education()
            {
                education_no = txtEducationNo.Text.Trim(),
                education_name = txtEducationName.Text.Trim(),
                delete_mk = 0,
                datains_usr = AdminInfo.Account
            };
            result = HttpHelper.Request("Base​/AddEducation", HttpHelper.ModelToJson(edu));
            if (result.statusCode != 200 || result.message.ToString().Equals("false"))
            {
                UIMessageTip.ShowError("AddEducation+接口服务异常，请提交Issue或尝试更新版本！", 1500);
                return;
            }
            UIMessageTip.ShowOk("添加学历成功！", 1500);
            #region 获取添加操作日志所需的信息
            RecordHelper.Record(AdminInfo.Account + "-" + AdminInfo.Name + "在" + DateTime.Now + "位于" + AdminInfo.SoftwareVersion + "执行：" + "新增学历类型操作！新增值为：" + edu.education_no, 2);
            #endregion
            ReloadEducationList();
            return;

        }

        private void btnUpdateEducation_Click(object sender, EventArgs e)
        {
            if (dgvEducationList.SelectedRows.Count <= 0)
            {
                UIMessageTip.ShowWarning("未选择需修改的学历数据，请检查", 1500);
                return;
            }
            var edu = new Education()
            {
                education_no = txtEducationNo.Text.Trim(),
                education_name = txtEducationName.Text.Trim(),
                datachg_usr = AdminInfo.Account,
            };
            result = HttpHelper.Request("Base​/UpdEducation", HttpHelper.ModelToJson(edu));
            if (result.statusCode != 200 || result.message.ToString().Equals("false"))
            {
                UIMessageTip.ShowError("UpdEducation+接口服务异常，请提交Issue或尝试更新版本！", 1500);
                return;
            }
        }

        private void btnDeleteEducation_Click(object sender, EventArgs e)
        {
            if (dgvEducationList.SelectedRows.Count <= 0)
            {
                UIMessageTip.ShowWarning("未选择需修改的学历数据，请检查", 1500);
                return;
            }
            var edu = new Education()
            {
                education_no = txtEducationNo.Text.Trim(),
                education_name = txtEducationName.Text.Trim(),
                datachg_usr = AdminInfo.Account,
            };
            result = HttpHelper.Request("Base​/DelEducation", HttpHelper.ModelToJson(edu));
            if (result.statusCode != 200 || result.message.ToString().Equals("false"))
            {
                UIMessageTip.ShowError("DelEducation+接口服务异常，请提交Issue或尝试更新版本！", 1500);
                return;
            }
            UIMessageTip.ShowOk("删除成功！");
            return;
        }

        private void dgvEducationList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtEducationNo.Text = dgvEducationList.SelectedRows[0].Cells["clEducationNo"].Value.ToString();
            txtEducationName.Text = dgvEducationList.SelectedRows[0].Cells["clEducationName"].Value.ToString();
            if (dgvEducationList.SelectedRows[0].Cells["clDeleteMk"].Value.ToString() == "1")
            {
                btnDeleteEducation.Text = "恢复学历";
                btnDeleteEducation.FillColor = Color.Green;
                btnDeleteEducation.Click += btnRecoveryEducation_Click;
            }
        }

        private void btnRecoveryEducation_Click(object sender, EventArgs e)
        {
            if (dgvEducationList.SelectedRows.Count <= 0)
            {
                UIMessageTip.ShowWarning("未选择需修改的学历数据，请检查", 1500);
                return;
            }
            var edu = new Education()
            {
                education_no = txtEducationNo.Text.Trim(),
                education_name = txtEducationName.Text.Trim(),
                delete_mk = 0,
                datachg_usr = AdminInfo.Account,
            };
            result = HttpHelper.Request("Base​/UpdEducation", HttpHelper.ModelToJson(edu));
            if (result.statusCode != 200 || result.message.ToString().Equals("false"))
            {
                UIMessageTip.ShowError("UpdEducation+接口服务异常，请提交Issue或尝试更新版本！", 1500);
                return;
            }
        }
    }
}
