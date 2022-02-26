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
using jvncorelib_fr.Entitylib;
using Sunny.UI;
using SYS.Application;
using SYS.Common;
using SYS.Core;
using SYS.Core.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYS.FormUI
{
    public partial class FrmMySpace : UIForm
    {
        public FrmMySpace()
        {
            InitializeComponent();
        }

        private void FrmMySpace_Load(object sender, EventArgs e)
        {
            //加载民族信息
            cbWorkerNation.DataSource = new BaseService().SelectNationAll(new Nation { delete_mk = 0 });
            cbWorkerNation.DisplayMember = "nation_name";
            cbWorkerNation.ValueMember = "nation_no";
            //加载性别信息
            cboSex.DataSource = new BaseService().SelectSexTypeAll(new SexType { delete_mk = 0 });
            cboSex.DisplayMember = "sexName";
            cboSex.ValueMember = "sexId";
            //加载部门信息
            cboWorkerClub.DataSource = new BaseService().SelectDeptAllCanUse();
            cboWorkerClub.DisplayMember = "dept_name";
            cboWorkerClub.ValueMember = "dept_no";
            //加载职位信息
            cboWorkerPosition.DataSource = new BaseService().SelectPositionAll(new Position { delete_mk = 0 });
            cboWorkerPosition.DisplayMember = "position_name";
            cboWorkerPosition.ValueMember = "position_no";
            LoadData();
        }

        private void tpSecurity_Click(object sender, EventArgs e)
        {

        }

        public void LoadData()
        {
            Worker worker = new WorkerService().SelectWorkerInfoByWorkerId(LoginInfo.WorkerNo);
            if (worker != null)
            {
                txtWorkerNo.Text = worker.WorkerId;
                txtWorkerName.Text = worker.WorkerName;
                cboSex.SelectedIndex = worker.WorkerSex;
                cboWorkerPosition.Text = worker.PositionName;
                cboWorkerPosition.SelectedValue = worker.WorkerPosition;
                cboWorkerClub.Text = worker.ClubName;
                cboWorkerClub.SelectedValue = worker.WorkerClub;
                cbWorkerNation.Text = worker.NationName;
                cbWorkerNation.SelectedValue = worker.WorkerNation;
                txtAddress.Text = worker.WorkerAddress;
                txtTel.Text = worker.WorkerTel;
            }

            var workerPicSource = new WorkerPicService().WorkerPic(new WorkerPic
            {
                WorkerId = LoginInfo.WorkerNo.Trim()
            });
            if (workerPicSource != null && !string.IsNullOrEmpty(workerPicSource.Pic))
            {
                picWorkerPic.BackgroundImage = null;
                picWorkerPic.LoadAsync(workerPicSource.Pic);
            }
        }

        private void txtOldPwd_TextChanged(object sender, EventArgs e)
        {
            if (txtOldPwd.TextLength < 6)
            {
                lgCheckOldPwd.Visible = true;
                lgCheckOldPwd.OnColor = Color.Red;
            }
        }

        private void txtOldPwd_Validated(object sender, EventArgs e)
        {
            //校验旧密码是否正确
            Worker worker = new Worker() { WorkerId = LoginInfo.WorkerNo, WorkerPwd = txtOldPwd.Text.Trim() };
            var result = new WorkerService().SelectWorkerInfoByWorkerIdAndWorkerPwd(worker);
            if (result != null)
            {
                lgCheckOldPwd.Visible = true;
                lgCheckOldPwd.OnColor = Color.Green;
                lblOldMsg.ForeColor = Color.Green;
                lblOldMsg.Text = "旧密码符合，请继续填写新密码！";
                txtNewPwd.ReadOnly = false;
                txtNewPwd.Validated += new EventHandler(txtNewPwd_Validated);
            }
            else
            {
                lgCheckOldPwd.Visible = true;
                lgCheckOldPwd.OnColor = Color.Red;
                lblOldMsg.ForeColor = Color.Red;
                lblOldMsg.Text = "旧密码有误，请重试！";
                txtNewPwd.ReadOnly = true;
                txtNewPwd.Validated -= new EventHandler(txtNewPwd_Validated);

            }
        }

        private void txtNewPwd_Validated(object sender, EventArgs e)
        {
            string pattern = @"^[A-Za-z0-9]+$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(txtNewPwd.Text.Trim()) && txtNewPwd.TextLength > 8)
            {
                lblNewMsg.ForeColor = Color.Green;
                lblNewMsg.Text = "密码长度及格式符合要求！";
                lgCheckNewPwd.Visible = true;
                lgCheckNewPwd.OnColor = Color.Green;
                return;

            }
            else
            {
                lblNewMsg.ForeColor = Color.Red;
                lblNewMsg.Text = "密码长度及格式不符合要求，请检查！";
                lgCheckNewPwd.Visible = true;
                txtNewPwd.Focus();
                lgCheckNewPwd.OnColor = Color.Red;
                return;
            }
        }

        private void btnUpdPwd_Click(object sender, EventArgs e)
        {
            bool tf = new WorkerService().UpdWorkerPwdByWorkNo(LoginInfo.WorkerNo, txtNewPwd.Text.Trim());
            if (tf == false)
            {
                UIMessageBox.Show("服务器繁忙，修改失败！", "系统提示", UIStyle.Red, UIMessageBoxButtons.OK);
                return;
            }

            UIMessageBox.Show("修改成功，系统将在稍后退出，请使用新密码进行登录系统！", "系统提示", UIStyle.Green, UIMessageBoxButtons.OK);
            #region 获取添加操作日志所需的信息
            RecordHelper.Record(LoginInfo.WorkerNo + "-" + LoginInfo.WorkerName + "在" + DateTime.Now + "位于" + LoginInfo.SoftwareVersion + "执行：" + "修改密码操作！", 2);
            #endregion
            FrmMain.CloseMy();
            this.Close();
            return;
        }

        public bool CheckInput(Worker worker)
        {
            if (string.IsNullOrWhiteSpace(worker.WorkerId))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(worker.WorkerName))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(worker.WorkerSex + ""))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(worker.WorkerNation))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(worker.WorkerTel))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(worker.WorkerAddress))
            {
                return false;
            }
            return true;
        }

        private void btnUpdWorker_Click(object sender, EventArgs e)
        {
            Worker worker = new Worker()
            {
                WorkerId = txtWorkerNo.Text.Trim(),
                WorkerName = txtWorkerName.Text.Trim(),
                WorkerSex = cboSex.Text == "男" ? 1 : 0,
                WorkerNation = cbWorkerNation.SelectedValue.ToString(),
                WorkerTel = txtTel.Text.Trim(),
                WorkerAddress = txtAddress.Text.Trim(),
                datachg_usr = LoginInfo.WorkerNo,
                datachg_date = DateTime.Now
            };

            if (CheckInput(worker))
            {
                bool tf = new WorkerService().UpdateWorker(worker);
                if (tf == false)
                {
                    UIMessageBox.Show("修改失败！服务器处于繁忙，请稍后再试！", "系统提示", UIStyle.Red, UIMessageBoxButtons.OK);
                    return;
                }
                UIMessageBox.Show("修改成功！", "系统提示", UIStyle.Green, UIMessageBoxButtons.OK);
                #region 获取添加操作日志所需的信息
                RecordHelper.Record(LoginInfo.WorkerNo + "-" + LoginInfo.WorkerName + "在" + DateTime.Now + "位于" + LoginInfo.SoftwareVersion + "执行：" + "修改个人信息操作！", 2);
                #endregion
                LoadData();
                return;
            }
        }

        private void cbWorkerNation_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void picWorkerPic_Click(object sender, EventArgs e)
        {
            openPic.ShowDialog();
        }

        private void openPic_FileOk(object sender, CancelEventArgs e)
        {
            WorkerPic workerPic = null;
            //查询当前账号是否已存在对应的图片，如果已存在则移除旧图片
            workerPic = new WorkerPic
            {
                WorkerId = txtWorkerNo.Text.Trim(),
            };
            var source = new WorkerPicService().WorkerPic(workerPic);
            if (!source.IsNullOrEmpty())
            {
                if (new WorkerPicService().DeleteWorkerPic(workerPic))
                {
                    PicHandler();
                }
            }
            else
            {
                PicHandler();
            }

        }

        public void PicHandler()
        {
            var serverPath = HttpHelper.postUrl;
            //var serverPath = ConfigurationManager.AppSettings["post"].ToString();
            var result = HttpHelper.UpLoadFile(openPic.FileName, serverPath);
            var workerPic = new WorkerPic
            {
                WorkerId = txtWorkerNo.Text.Trim(),
                Pic = result.Trim(),
            };
            new WorkerPicService().InsertWorkerPic(workerPic);
            picWorkerPic.BackgroundImage = null;
            picWorkerPic.LoadAsync(HttpHelper.baseUrl + result.Trim());
            UIMessageTip.ShowOk("头像上传成功！稍等将会加载头像哦..");
            //picWorkerPic.LoadAsync(ConfigurationManager.AppSettings["FileSite"] + result.Trim());
        }

    }
}
