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
using Sunny.UI;
using SYS.Application;
using SYS.Core;
using SYS.FormUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        public void ReloadDeptList()
        {
            LoadDept();
            LoadLeader();
            txtDeptNo.Text = new CounterHelper().GetNewId("DeptInfo");
            dgvDeptList.AutoGenerateColumns = false;
            dgvDeptList.DataSource = new BaseService().SelectDeptAllCanUse();
        }

        public void LoadDept()
        {
            cboDeptParent.DataSource = new BaseService().SelectDeptAllCanUse();
            cboDeptParent.DisplayMember = "dept_name";
            cboDeptParent.ValueMember = "dept_no";
        }

        public void LoadLeader()
        {
            cboDeptLeader.DataSource = new WorkerService().SelectWorkerAll();
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
                dept_leader = cboDeptLeader.SelectedValue.ToString()
            };
            if (CheckInput(dept))
            {
                bool tf = new BaseService().AddDept(dept);
                if (tf == false)
                {
                    UIMessageBox.Show("添加失败！或是服务器繁忙所致，请稍后重试！", "系统提示", UIStyle.Red, UIMessageBoxButtons.OK);
                    return;
                }
                UIMessageBox.Show("添加成功！", "系统提示", UIStyle.Green, UIMessageBoxButtons.OK);
                OperationLog operationLog = new OperationLog()
                {
                    OperationTime = DateTime.Now,
                    Operationlog = AdminInfo.Account + AdminInfo.Name + "于" + DateTime.Now.ToString("yyyy年MM月dd日") + "添加了一个部门，部门编号为" + dept.dept_no,
                    OperationAccount = AdminInfo.Account,
                    datains_usr = AdminInfo.Account,
                    datains_date = DateTime.Now
                };
                new OperationlogService().InsertOperationLog(operationLog);
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
            if (dgvDeptList.SelectedRows.Count == 1)
            {
                txtDeptNo.Text = dgvDeptList.SelectedRows[0].Cells["clDeptNo"].Value.ToString();
                txtDeptName.Text = dgvDeptList.SelectedRows[0].Cells["clDeptName"].Value.ToString();
                txtDeptDesc.Text = dgvDeptList.SelectedRows[0].Cells["clDeptDesc"].Value.ToString();
            }
        }

        private void btnUpdateDept_Click(object sender, EventArgs e)
        {
            Dept dept = new Dept()
            {
                dept_no = txtDeptNo.Text.Trim(),
                dept_name = txtDeptName.Text.Trim(),
                dept_desc = txtDeptDesc.Text.Trim(),
                dept_parent = cboDeptParent.SelectedValue == null ? "" : cboDeptParent.SelectedValue.ToString(),
                dept_leader = cboDeptLeader.SelectedValue == null ? "" : cboDeptLeader.SelectedValue.ToString(),
                datachg_usr = AdminInfo.Account,
                datachg_date = DateTime.Now
            };
            if (CheckInput(dept))
            {
                bool tf = new BaseService().UpdDept(dept);
                if (tf == false)
                {
                    UIMessageBox.Show("修改失败！或是服务器繁忙所致，请稍后重试！", "系统提示", UIStyle.Red, UIMessageBoxButtons.OK);
                    return;
                }
                UIMessageBox.Show("修改成功！", "系统提示", UIStyle.Green, UIMessageBoxButtons.OK);
                OperationLog operationLog = new OperationLog()
                {
                    OperationTime = DateTime.Now,
                    Operationlog = AdminInfo.Account + AdminInfo.Name + "于" + DateTime.Now.ToString("yyyy年MM月dd日") + "修改了一个部门，部门编号为" + dept.dept_no,
                    OperationAccount = AdminInfo.Account,
                    datains_usr = AdminInfo.Account,
                    datains_date = DateTime.Now
                };
                new OperationlogService().InsertOperationLog(operationLog);
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
            if (dgvDeptList.SelectedRows.Count == 1)
            {
                Dept dept = new Dept()
                {
                    dept_no = txtDeptNo.Text.Trim(),
                    dept_name = txtDeptName.Text.Trim(),
                    dept_desc = txtDeptDesc.Text.Trim(),
                    dept_parent = cboDeptParent.SelectedValue.ToString(),
                    dept_date = DateTime.Now,
                    dept_leader = cboDeptLeader.SelectedValue.ToString()
                };
                bool tf = new BaseService().DelDept(dept);
                if (tf == false)
                {
                    UIMessageBox.Show("删除失败！或是服务器繁忙所致，请稍后重试！", "系统提示", UIStyle.Red, UIMessageBoxButtons.OK);
                    return;
                }
                UIMessageBox.Show("删除成功！", "系统提示", UIStyle.Green, UIMessageBoxButtons.OK);
                OperationLog operationLog = new OperationLog()
                {
                    OperationTime = DateTime.Now,
                    Operationlog = AdminInfo.Account + AdminInfo.Name + "于" + DateTime.Now.ToString("yyyy年MM月dd日") + "修改了一个部门，部门编号为" + dept.dept_no,
                    OperationAccount = AdminInfo.Account,
                    datains_usr = AdminInfo.Account,
                    datains_date = DateTime.Now
                };
                new OperationlogService().InsertOperationLog(operationLog);
                ReloadDeptList();
                return;
            }
            
        }
    }

    

}
