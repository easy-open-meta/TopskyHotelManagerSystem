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
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using EOM.TSHotelManager.Common.Core;
using Sunny.UI;

using System.Net;
using System.Configuration;
using System.IO;
using System.Text;
using SYS.Common;
using System.Linq;
using jvncorelib_fr.EncryptorLib;

namespace SYS.FormUI
{
    public partial class FrmAddWorker : UIEditForm
    {
        public FrmAddWorker()
        {
            InitializeComponent();
        }

        protected override bool CheckData()
        {
            return CheckEmpty(WorkerName, "请输入姓名")
                && CheckEmpty(WorkerNo, "请输入工号")
                   && CheckEmpty(WorkerID, "请输入证件号码")
                   && CheckEmpty(WorkerTel, "输入11位手机号码")
                   && CheckEmpty(txtAddress, "请填写居住地址");
        }

        ucHistory ucHistory = null;
        private void FrmAddWorker_Load(object sender, EventArgs e)
        {
            var result = HttpHelper.Request("Base/SelectDeptAllCanUse");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectDeptAllCanUse+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            //加载部门信息
            cboClub.DataSource = HttpHelper.JsonToList<Dept>(result.message);
            cboClub.DisplayMember = "dept_name";
            cboClub.ValueMember = "dept_no";
            //加载民族信息
            Dictionary<string,string> dic = new Dictionary<string,string>();
            dic.Add("delete_mk","0");
            result = HttpHelper.Request("Base/SelectNationAll",null, dic);
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectNationAll+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            cbWorkerNation.DataSource = HttpHelper.JsonToList<Nation>(result.message);
            cbWorkerNation.DisplayMember = "nation_name";
            cbWorkerNation.ValueMember = "nation_no";
            //加载职位信息
            dic = new Dictionary<string, string>();
            dic.Add("delete_mk", "0");
            result = HttpHelper.Request("Base/SelectPositionAll", null, dic);
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectPositionAll+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            cboWorkerPosition.DataSource = HttpHelper.JsonToList<Position>(result.message);
            cboWorkerPosition.DisplayMember = "position_name";
            cboWorkerPosition.ValueMember = "position_no";
            //加载性别信息
            dic = new Dictionary<string, string>();
            dic.Add("delete_mk", "0");
            result = HttpHelper.Request("Base/SelectSexTypeAll", null, dic);
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectSexTypeAll+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            cboSex.DataSource = HttpHelper.JsonToList<SexType>(result.message);
            cboSex.DisplayMember = "sexName";
            cboSex.ValueMember = "sexId";
            //加载学历信息
            dic = new Dictionary<string, string>();
            dic.Add("delete_mk", "0");
            result = HttpHelper.Request("Base/SelectEducationAll", null, dic);
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectEducationAll+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            cboEducation.DataSource = HttpHelper.JsonToList<Education>(result.message);
            cboEducation.DisplayMember = "education_name";
            cboEducation.ValueMember = "education_no";
            //加载面貌信息
            cboWorkerFace.DataSource = new List<string>() { "群众", "团员", "党员" };


            if (this.Text == "员工信息查看页")
            {
                foreach (Control control in this.Controls)
                {
                    switch (control.GetType().ToString())
                    {
                        case "Sunny.UI.UITextBox":
                            (control as Sunny.UI.UITextBox).ReadOnly = true;
                            break;
                        case "Sunny.UI.UIComboBox":
                            (control as Sunny.UI.UIComboBox).ReadOnly = true;
                            break;
                        case "Sunny.UI.UIDatePicker":
                            (control as Sunny.UI.UIDatePicker).ReadOnly = true;
                            break;
                    }
                    
                }
                btnOK.Visible = false;
                btnCancel.Visible = false;
                WorkerNo.Text = FrmChangeWorker.wk_WorkerNo;
                WorkerName.Text = FrmChangeWorker.wk_WorkerName;
                cboSex.Text = FrmChangeWorker.wk_WorkerSex;
                cboWorkerPosition.Text = FrmChangeWorker.wk_WorkerPosition;
                cboWorkerFace.Text = FrmChangeWorker.wk_WorkerFace;
                cbWorkerNation.Text = FrmChangeWorker.wk_WorkerNation;
                dtpBirthday.Value = Convert.ToDateTime(FrmChangeWorker.wk_WorkerBirthday);
                dtpTime.Value = Convert.ToDateTime(FrmChangeWorker.wk_WorkerTime);
                WorkerID.Text = FrmChangeWorker.wk_WorkerID;
                txtAddress.Text = FrmChangeWorker.wk_WorkerAddress;
                WorkerTel.Text = FrmChangeWorker.wk_WorkerTel;
                cboEducation.Text = FrmChangeWorker.wk_WorkerEducation;
                cboClub.Text = FrmChangeWorker.wk_WorkerClub;

                dic = new Dictionary<string, string>
                {
                    { "WorkerId", WorkerNo.Text.Trim() }
                };
                result = HttpHelper.Request("WorkerPicture/WorkerPic", null, dic);
                //if (result.statusCode != 200)
                //{
                //    UIMessageBox.ShowError("WorkerPic+接口服务异常，请提交Issue或尝试更新版本！");
                //    return;
                //}
                var workerPicSource = HttpHelper.JsonToModel<WorkerPic>(result.message);
                if (workerPicSource != null && !string.IsNullOrEmpty(workerPicSource.Pic))
                {
                    EncryptLib encryptLib = new EncryptLib();
                    picWorkerPic.Enabled = false;
                    picWorkerPic.BackgroundImage = null;
                    picWorkerPic.LoadAsync(encryptLib.Decryption(HttpHelper.baseUrl) + workerPicSource.Pic);
                }
                this.WorkerID.Validated -= new EventHandler(WorkerID_Validated);
                dic = new Dictionary<string, string>();
                dic.Add("wid", WorkerNo.Text.Trim());
                result = HttpHelper.Request("WorkerHistory/SelectHistoryByWorkerId", null, dic);
                if (result.statusCode != 200)
                {
                    UIMessageBox.ShowError("SelectHistoryByWorkerId+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                List<WorkerHistory> workerHistories = HttpHelper.JsonToList<WorkerHistory>(result.message);
                for (int i = 0; i < workerHistories.Count; i++)
                {
                    ucHistory = new ucHistory();
                    ucHistory.dtpStartDate.Value = Convert.ToDateTime(workerHistories[i].StartDate);
                    ucHistory.dtpEndDate.Value = Convert.ToDateTime(workerHistories[i].EndDate);
                    ucHistory.txtPosition.Text = workerHistories[i].Position;
                    ucHistory.txtCompany.Text = workerHistories[i].Company;
                    ucHistory.dtpStartDate.ReadOnly = true;
                    ucHistory.dtpEndDate.ReadOnly = true;
                    ucHistory.txtPosition.ReadOnly = true;
                    ucHistory.txtCompany.ReadOnly = true;
                    flpHistory.Controls.Add(ucHistory);
                }
            }
            else if (this.Text == "添加员工")
            {
                WorkerNo.Text = Util.GetListNewId("WK", 3, 1, "-").FirstOrDefault();
                ucHistory = new ucHistory();
                ucHistory.dtpStartDate.Enabled = true;
                ucHistory.dtpEndDate.Enabled = true;
                ucHistory.txtCompany.Enabled = true;
                ucHistory.txtPosition.Enabled = true;
                flpHistory.Controls.Add(ucHistory);
                //cboClub.SelectedIndex = 0;
                //cboEducation.SelectedIndex = 0;
                //cboSex.SelectedIndex = 0;
                //cboWorkerFace.SelectedIndex = 0;
                //cboWorkerPosition.SelectedIndex = 0;
            }
            else
            {
                bool dr = UIMessageBox.Show("修改操作仅能修改姓名、性别、电话号码、联系地址、民族、面貌以及最高学历，以上是否知晓？点击确定继续进行修改！", "修改提醒",UIStyle.Orange, UIMessageBoxButtons.OKCancel);
                if (dr)
                {
                    WorkerNo.Text = FrmChangeWorker.wk_WorkerNo;
                    WorkerName.Text = FrmChangeWorker.wk_WorkerName;
                    cboSex.Text = FrmChangeWorker.wk_WorkerSex;
                    cboWorkerPosition.Text = FrmChangeWorker.wk_WorkerPosition;
                    cboWorkerFace.Text = FrmChangeWorker.wk_WorkerFace;
                    cbWorkerNation.Text = FrmChangeWorker.wk_WorkerNation;
                    dtpBirthday.Value = Convert.ToDateTime(FrmChangeWorker.wk_WorkerBirthday);
                    dtpTime.Value = Convert.ToDateTime(FrmChangeWorker.wk_WorkerTime);
                    WorkerID.Text = FrmChangeWorker.wk_WorkerID;
                    txtAddress.Text = FrmChangeWorker.wk_WorkerAddress;
                    WorkerTel.Text = FrmChangeWorker.wk_WorkerTel;
                    cboEducation.Text = FrmChangeWorker.wk_WorkerEducation;
                    cboClub.Text = FrmChangeWorker.wk_WorkerClub;

                    dic = new Dictionary<string, string>();
                    dic.Add("WorkerId", WorkerNo.Text.Trim());
                    result = HttpHelper.Request("WorkerPicture/WorkerPic", null, dic);
                    if (result.statusCode != 200)
                    {
                        UIMessageBox.ShowError("WorkerPic+接口服务异常，请提交Issue或尝试更新版本！");
                        return;
                    }
                    var workerPicSource = HttpHelper.JsonToModel<WorkerPic>(result.message);
                    if (workerPicSource!=null &&!string.IsNullOrEmpty(workerPicSource.Pic))
                    {
                        picWorkerPic.BackgroundImage = null;
                        picWorkerPic.LoadAsync(workerPicSource.Pic);
                    }
                    //this.WorkerID.Validated -= new EventHandler(WorkerID_Validated);
                    btnOK.Text = "修改";
                    this.ButtonOkClick -= new EventHandler(FrmAddWorker_ButtonOkClick);
                    this.ButtonOkClick += new EventHandler(btnUpd_Click);
                    WorkerTel.ReadOnly = false;
                    txtAddress.ReadOnly = false;
                    cboWorkerFace.ReadOnly = false;
                    dic = new Dictionary<string, string>();
                    dic.Add("wid", WorkerNo.Text.Trim());
                    result = HttpHelper.Request("WorkerHistory/SelectHistoryByWorkerId", null, dic);
                    if (result.statusCode != 200)
                    {
                        UIMessageBox.ShowError("SelectHistoryByWorkerId+接口服务异常，请提交Issue或尝试更新版本！");
                        return;
                    }
                    List<WorkerHistory> workerHistories = HttpHelper.JsonToList<WorkerHistory>(result.message);
                    for (int i = 0; i < workerHistories.Count; i++)
                    {
                        ucHistory = new ucHistory();
                        ucHistory.dtpStartDate.Value = Convert.ToDateTime(workerHistories[i].StartDate);
                        ucHistory.dtpEndDate.Value = Convert.ToDateTime(workerHistories[i].EndDate);
                        ucHistory.txtPosition.Text = workerHistories[i].Position;
                        ucHistory.txtCompany.Text = workerHistories[i].Company;
                        flpHistory.Controls.Add(ucHistory);
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            bool dr = UIMessageBox.Show("是否确认修改员工信息？", "修改提醒", UIStyle.Green,UIMessageBoxButtons.OKCancel);
            if (dr)
            {
                #region 员工信息代码块
                Worker worker = new Worker
                {
                    WorkerId = WorkerNo.Text.Trim(),
                    WorkerName = WorkerName.Text.Trim(),
                    WorkerNation = cbWorkerNation.SelectedValue.ToString(),
                    WorkerTel = WorkerTel.Text.Trim(),
                    CardId = WorkerID.Text.Trim(),
                    WorkerAddress = txtAddress.Text.Trim(),
                    WorkerFace = cboWorkerFace.SelectedValue.ToString(),
                    WorkerEducation = cboEducation.SelectedValue.ToString(),
                    WorkerBirthday = dtpBirthday.Value,
                    datachg_usr = AdminInfo.Account
                };
                var result = HttpHelper.Request("Worker/UpdateWorker", HttpHelper.ModelToJson(worker));
                if (result.statusCode != 200)
                {
                    UIMessageBox.ShowError("UpdateWorker+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                bool i = result.message.ToString().Equals("true") ? true:false; /*new WorkerService().UpdateWorker(worker);*/
                if (i)
                {
                    UIMessageBox.ShowSuccess("信息修改成功！");
                    #region 获取添加操作日志所需的信息
                    RecordHelper.Record(AdminInfo.Account + "-" + AdminInfo.Name + "在" + DateTime.Now + "位于" + AdminInfo.SoftwareVersion + "执行：" + "修改员工操作！修改值为：" + worker.WorkerId, 2);
                    #endregion
                    this.Close();
                    FrmWorkerManager.Reload();
                    return;
                }
                else
                {
                    UIMessageBox.ShowError("服务器繁忙！");
                    return;
                }
                #endregion
            }
            else
            {
                UIMessageBox.ShowWarning("修改操作已取消！");
                return;
            }
        }


        private void WorkerID_Validated(object sender, EventArgs e)
        {
            //获取得到输入的身份证号码
            string identityCard = WorkerID.Text.Trim();

            if (string.IsNullOrEmpty(identityCard))
            {
                //身份证号码不能为空，如果为空返回
                UIMessageBox.ShowError("身份证号码不能为空！");
                if (WorkerID.CanFocus)
                {
                    WorkerID.Focus();//设置当前输入焦点为txtCardID_identityCard
                }
                return;
            }
            else
            {
                //身份证号码只能为15位或18位其它不合法
                if (identityCard.Length != 15 && identityCard.Length != 18)
                {
                    UIMessageBox.ShowWarning("身份证号码为15位或18位，请检查！");
                    if (WorkerID.CanFocus)
                    {
                        WorkerID.Focus();
                    }
                    return;
                }
            }

            if (identityCard.Length == 18)
            {
                var result = Util.searchCode(identityCard);
                if (result.message.IsNullOrEmpty()) //如果没有错误消息输出，则代表成功
                {
                    try
                    {
                        cboSex.Text = result.sex;
                        txtAddress.Text = result.address;
                        dtpBirthday.Value = Convert.ToDateTime(result.birthday);
                    }
                    catch
                    {
                        UIMessageBox.ShowError("请正确输入证件号码！");
                        return;
                    }
                }
                else
                {
                    UIMessageBox.ShowError(result.message);
                    return;
                }
            }
            return;
        }

        private void workerPic_Click(object sender, EventArgs e)
        {
            openPic.ShowDialog();
        }

        EncryptLib encryptLib = new EncryptLib();
        private void openPic_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var serverPath = encryptLib.Decryption(HttpHelper.postUrl);
            var result = HttpHelper.UpLoadFile(openPic.FileName, serverPath);
            WorkerPic workerPic = new WorkerPic
            {
                WorkerId = WorkerNo.Text.Trim(),
                Pic = result.Trim(),
            };

            var response = HttpHelper.Request("WorkerPicture/InsertWorkerPic", HttpHelper.ModelToJson(workerPic));
            if (response.statusCode != 200)
            {
                UIMessageBox.ShowError("InsertWorkerPic+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }


            picWorkerPic.BackgroundImage = null;
            picWorkerPic.LoadAsync(encryptLib.Decryption(HttpHelper.baseUrl) + result.Trim());
        }

        private void FrmAddWorker_ButtonOkClick(object sender, EventArgs e)
        {
            Worker worker = new Worker
            {
                WorkerId = WorkerNo.Text.Trim(),
                WorkerName = WorkerName.Text.Trim(),
                WorkerBirthday = dtpBirthday.Value,
                WorkerSex = (int)cboSex.SelectedValue,
                WorkerNation = cbWorkerNation.SelectedValue.ToString(),
                WorkerTel = WorkerTel.Text,
                WorkerClub = cboClub.SelectedValue.ToString(),
                WorkerAddress = txtAddress.Text,
                WorkerPosition = cboWorkerPosition.SelectedValue.ToString(),
                CardId = WorkerID.Text,
                WorkerTime = dtpTime.Value,
                WorkerFace = cboWorkerFace.Text,
                WorkerEducation = cboEducation.SelectedValue.ToString(),
                datains_usr = AdminInfo.Account
            };
            try
            {
                #region 员工信息添加代码块
                var response = HttpHelper.Request("Worker/AddWorker", HttpHelper.ModelToJson(worker));
                if (response.statusCode != 200)
                {
                    UIMessageBox.ShowError("AddWorker+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                bool n = response.message.ToString().Equals("true")?true:false;
                #endregion

                if (ucHistory.txtCompany != null && ucHistory.txtPosition != null && ucHistory.dtpStartDate.Value != null && ucHistory.dtpEndDate.Value != null)
                {
                    #region 履历添加代码块
                    WorkerHistory workerHistory = new WorkerHistory
                    {
                        StartDate = ucHistory.dtpStartDate.Value,
                        EndDate = ucHistory.dtpEndDate.Value,
                        Position = ucHistory.txtPosition.Text,
                        Company = ucHistory.txtCompany.Text,
                        WorkerId = WorkerNo.Text.Trim()
                    };

                    response = HttpHelper.Request("WorkerHistory/AddHistoryByWorkerId", HttpHelper.ModelToJson(workerHistory));
                    if (response.statusCode != 200)
                    {
                        UIMessageBox.ShowError("AddHistoryByWorkerId+接口服务异常，请提交Issue或尝试更新版本！");
                        return;
                    }
                    bool j = response.message.ToString().Equals("true") ? true : false;
                    #endregion

                    #region 判断履历和信息代码块
                    if (n == true && j == true)
                    {
                        UIMessageBox.Show("员工信息/履历添加成功！该员工登录密码为：123456，请提醒员工妥善保管并首次登录系统时修改密码！");
                        this.Close();
                        FrmWorkerManager.Reload();
                        #region 获取添加操作日志所需的信息
                        RecordHelper.Record(AdminInfo.Account + "-" + AdminInfo.Name + "在" + DateTime.Now + "位于" + AdminInfo.SoftwareVersion + "执行：" + "添加员工操作！新增值为：" + worker.WorkerId, 2);
                        #endregion
                    }
                    else
                    {
                        UIMessageBox.Show("员工信息/履历添加失败，请检查数据格式或稍后再试！");
                    }
                    #endregion
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.Show("服务器繁忙或数据格式为空！");
            }
            finally
            {
                this.Close();
            }
        }

        private void FrmAddWorker_ButtonCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}