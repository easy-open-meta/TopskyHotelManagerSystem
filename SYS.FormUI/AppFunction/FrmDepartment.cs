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
using jvncorelib_fr.EntityLib;
using Sunny.UI;
using SYS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SYS.FormUI
{
    public partial class FrmDepartment : UIForm
    {
        public FrmDepartment()
        {
            InitializeComponent();
        }

        private void FrmDepartment_Load(object sender, EventArgs e)
        {
            ReloadDeptList();
            LoadDept();
            LoadLeader();
        }

        ResponseMsg result = null;
        Dictionary<string, string> dic = null;

        public void ReloadDeptList()
        {
            txtDeptNo.Text = Util.GetListNewId("D", 3, 1, "-").FirstOrDefault();
            result = HttpHelper.Request("Base/SelectDeptAllCanUse");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectDeptAllCanUse+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            dgvDeptList.AutoGenerateColumns = false;
            dgvDeptList.DataSource = HttpHelper.JsonToList<Dept>(result.message);
        }

        public void LoadDept()
        {
            result = HttpHelper.Request("Base/SelectDeptAllCanUse");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectDeptAllCanUse+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            cboDeptParent.DataSource = HttpHelper.JsonToList<Dept>(result.message);
            cboDeptParent.DisplayMember = "dept_name";
            cboDeptParent.ValueMember = "dept_no";
        }

        public void LoadLeader()
        {
            result = HttpHelper.Request("Worker/SelectWorkerAll");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectWorkerAll+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            cboDeptLeader.DataSource = HttpHelper.JsonToList<Worker>(result.message);
            cboDeptLeader.DisplayMember = "WorkerName";
            cboDeptLeader.ValueMember = "WorkerId";
        }

        public bool CheckInput(Dept dept)
        {
            if (string.IsNullOrWhiteSpace(dept.dept_no))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(dept.dept_name))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(dept.dept_desc))
            {
                return false;
            }
            return true;
        }

        private void btnAddDept_Click(object sender, EventArgs e)
        {
            Dept dept = new Dept()
            {
                dept_no = txtDeptNo.Text.Trim(),
                dept_name = txtDeptName.Text.Trim(),
                dept_desc = txtDeptDesc.Text.Trim(),
                dept_parent = cboDeptParent.SelectedValue.ToString(),
                dept_date = DateTime.Now,
                dept_leader = cboDeptLeader.SelectedValue.ToString(),
                datains_usr = AdminInfo.Account
            };
            if (CheckInput(dept))
            {
                result = HttpHelper.Request("Base/AddDept", HttpHelper.ModelToJson(dept));
                if (result.statusCode != 200)
                {
                    UIMessageBox.ShowError("AddDept+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                bool tf = result.message.ToString().Equals("true");
                if (!tf)
                {
                    UIMessageBox.Show("添加失败！或是服务器繁忙所致，请稍后重试！", "系统提示", UIStyle.Red, UIMessageBoxButtons.OK);
                    return;
                }
                UIMessageBox.Show("添加成功！", "系统提示", UIStyle.Green, UIMessageBoxButtons.OK);
                #region 获取添加操作日志所需的信息
                RecordHelper.Record(AdminInfo.Account + "-" + AdminInfo.Name + "在" + DateTime.Now + "位于" + AdminInfo.SoftwareVersion + "执行：" + "添加部门类型操作！新增值为：" + dept.dept_no, 2);
                #endregion                
                txtDeptName.Text = "";
                txtDeptDesc.Text = "";
                ReloadDeptList();
                return;
            }
            else
            {
                UIMessageBox.Show("信息不完整，请检查！", "系统提示", UIStyle.Orange, UIMessageBoxButtons.OK);
                return;
            }

        }

        private void dgvDeptList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdateDept_Click(object sender, EventArgs e)
        {
            Dept dept = new Dept()
            {
                dept_no = txtDeptNo.Text.Trim(),
                dept_name = txtDeptName.Text.Trim(),
                dept_desc = txtDeptDesc.Text.Trim(),
                dept_parent = cboDeptParent.SelectedValue == null ? "" : cboDeptParent.ToString(),
                dept_leader = cboDeptLeader.SelectedValue == null ? "" : cboDeptLeader.SelectedValue.ToString(),
                datachg_usr = AdminInfo.Account,
            };
            if (CheckInput(dept))
            {
                result = HttpHelper.Request("Base/UpdDept", HttpHelper.ModelToJson(dept));
                if (result.statusCode != 200)
                {
                    UIMessageBox.ShowError("UpdDept+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                bool tf = result.message.ToString().Equals("true");
                if (!tf)
                {
                    UIMessageBox.Show("修改失败！或是服务器繁忙所致，请稍后重试！", "系统提示", UIStyle.Red, UIMessageBoxButtons.OK);
                    return;
                }
                UIMessageBox.Show("修改成功！", "系统提示", UIStyle.Green, UIMessageBoxButtons.OK);
                #region 获取添加操作日志所需的信息
                RecordHelper.Record(AdminInfo.Account + "-" + AdminInfo.Name + "在" + DateTime.Now + "位于" + AdminInfo.SoftwareVersion + "执行：" + "修改部门类型操作！修改值为：" + dept.dept_no, 2);
                #endregion   
                txtDeptName.Text = "";
                txtDeptDesc.Text = "";
                ReloadDeptList();
                return;
            }
            else
            {
                UIMessageBox.Show("信息不完整，请检查！", "系统提示", UIStyle.Orange, UIMessageBoxButtons.OK);
                return;
            }
        }

        private void btnDeleteDept_Click(object sender, EventArgs e)
        {
            if (dgvDeptList.SelectedRows.Count > 0)
            {
                //删除前先检索该部门下是否存在员工
                dic = new Dictionary<string, string>()
                {
                    { "deptNo",txtDeptNo.Text.Trim()}
                };
                result = HttpHelper.Request("Worker/CheckWorkerBydepartment", null, dic);
                if (result.statusCode != 200)
                {
                    UIMessageBox.ShowError("CheckWorkerBydepartment+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }

                if (result.message.ToString().Equals("true"))
                {
                    UIMessageBox.ShowError("当前部门下存在工作人员信息，无法删除该部门");
                    return;
                }

                Dept dept = new Dept()
                {
                    dept_no = txtDeptNo.Text.Trim(),
                    delete_mk = 1,
                    datachg_usr = AdminInfo.Account,
                };
                result = HttpHelper.Request("Base/DelDept", HttpHelper.ModelToJson(dept));
                if (result.statusCode != 200)
                {
                    UIMessageBox.ShowError("DelDept+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                bool tf = result.message.ToString().Equals("true");
                if (!tf)
                {
                    UIMessageBox.Show("删除失败！或是服务器繁忙所致，请稍后重试！", "系统提示", UIStyle.Red, UIMessageBoxButtons.OK);
                    return;
                }
                UIMessageBox.Show("删除成功！", "系统提示", UIStyle.Green, UIMessageBoxButtons.OK);
                #region 获取添加操作日志所需的信息
                RecordHelper.Record(AdminInfo.Account + "-" + AdminInfo.Name + "在" + DateTime.Now + "位于" + AdminInfo.SoftwareVersion + "执行：" + "删除部门类型操作！删除值为：" + dept.dept_no, 2);
                #endregion   
                txtDeptName.Text = "";
                txtDeptDesc.Text = "";
                ReloadDeptList();
                return;
            }

        }

        private void dgvDeptList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvDeptList.SelectedRows.Count == 1)
            {
                txtDeptNo.Text = dgvDeptList.SelectedRows[0].Cells["clDeptNo"].Value.IsNullOrEmpty() ? "" : dgvDeptList.SelectedRows[0].Cells["clDeptNo"].Value.ToString();
                txtDeptName.Text = dgvDeptList.SelectedRows[0].Cells["clDeptName"].Value.IsNullOrEmpty() ? "" : dgvDeptList.SelectedRows[0].Cells["clDeptName"].Value.ToString();
                txtDeptDesc.Text = dgvDeptList.SelectedRows[0].Cells["clDeptDesc"].Value.IsNullOrEmpty() ? "" : dgvDeptList.SelectedRows[0].Cells["clDeptDesc"].Value.ToString();
                cboDeptLeader.SelectedValue = dgvDeptList.SelectedRows[0].Cells["clDeptLeaderNo"].Value.IsNullOrEmpty() ? "" : dgvDeptList.SelectedRows[0].Cells["clDeptLeaderNo"].Value.ToString();
                cboDeptParent.SelectedValue = dgvDeptList.SelectedRows[0].Cells["clDeptParentNo"].Value.IsNullOrEmpty() ? "" : dgvDeptList.SelectedRows[0].Cells["clDeptParentNo"].Value.ToString();
            }
        }

        private void cboDeptLeader_SelectedValueChanged(object sender, EventArgs e)
        {
            //UIMessageBox.Show(cboDeptLeader.SelectedValue.ToString());
        }
    }



}
