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
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Windows.Forms;
using SYS.Core;
using Sunny.UI;
using SYS.Application;
using SYS.Core.Util;

namespace SYS.FormUI
{
    public partial class FrmAddWorker : UIForm
    {
        public FrmAddWorker()
        {
            InitializeComponent();
        }

        ucHistory ucHistory = null;
        private void FrmAddWorker_Load(object sender, EventArgs e)
        {
            //加载部门信息
            cboClub.DataSource = new BaseService().SelectDeptAllCanUse();
            cboClub.DisplayMember = "dept_name";
            cboClub.ValueMember = "dept_no";
            //加载民族信息
            cbWorkerNation.DataSource = new BaseService().SelectNationAllCanUse();
            cbWorkerNation.DisplayMember = "nation_name";
            cbWorkerNation.ValueMember = "nation_no";
            //加载职位信息
            cboWorkerPosition.DataSource = new BaseService().SelectPositionAllCanUse();
            cboWorkerPosition.DisplayMember = "position_name";
            cboWorkerPosition.ValueMember = "position_no";
            //加载性别信息
            cboSex.DataSource = new BaseService().SelectSexTypeAllCanUse();
            cboSex.DisplayMember = "sexName";
            cboSex.ValueMember = "sexId";
            //加载学历信息
            cboEducation.DataSource = new BaseService().SelectEducationAllCanUse();
            cboEducation.DisplayMember = "education_name";
            cboEducation.ValueMember = "education_no";

            pictureBox1.LoadAsync("https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1587209835893&di=02964b1de4a1ef4f938f7d3ae12b5b17&imgtype=0&src=http%3A%2F%2Fbpic.588ku.com%2Felement_origin_min_pic%2F17%2F11%2F25%2F0ef5a188956c2717db96d72d58524dec.jpg");
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
                btnAdd.Visible = false;
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
                this.WorkerID.Validated -= new EventHandler(WorkerID_Validated);
                List<WorkerHistory> workerHistories = new WorkerHistoryService().SelectHistoryByWorkerId(WorkerNo.Text);
                for (int i = 0; i < workerHistories.Count; i++)
                {
                    ucHistory = new ucHistory();
                    ucHistory.dtpStartDate.Value = workerHistories[i].StartDate;
                    ucHistory.dtpEndDate.Value = workerHistories[i].EndDate;
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
                WorkerNo.Text = new CounterHelper().GetNewId(CounterRuleConsts.WorkerId);
                ucHistory = new ucHistory();
                //ucHistory.txtCompany.ReadOnly = false;
                //ucHistory.txtPosition.ReadOnly = false;
                ucHistory.dtpStartDate.Enabled = true;
                ucHistory.dtpEndDate.Enabled = true;
                ucHistory.txtCompany.Enabled = true;
                ucHistory.txtPosition.Enabled = true;
                flpHistory.Controls.Add(ucHistory);
                cboClub.SelectedIndex = 0;
                cboEducation.SelectedIndex = 0;
                cboSex.SelectedIndex = 0;
                cboWorkerFace.SelectedIndex = 0;
                cboWorkerPosition.SelectedIndex = 0;
            }
            else
            {
                bool dr = UIMessageBox.Show("修改操作仅能修改姓名、性别、电话号码、联系地址、面貌以及最高学历，以上是否知晓？点击确定继续进行修改！", "修改提醒",UIStyle.Orange, UIMessageBoxButtons.OKCancel);
                if (dr == true)
                {
                    foreach (Control item in this.Controls)
                    {
                        switch (item.Name)
                        {
                            case "Sunny.UI.UITextBox":
                                (item as Sunny.UI.UITextBox).ReadOnly = true;
                                break;
                            case "Sunny.UI.UIComboBox":
                                (item as Sunny.UI.UIComboBox).ReadOnly = true;
                                break;
                            case "Sunny.UI.UIDatePicker":
                                (item as Sunny.UI.UIDatePicker).ReadOnly = true;
                                break;
                        }
                    }
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
                    this.WorkerID.Validated -= new EventHandler(WorkerID_Validated);
                    btnAdd.Text = "修改";
                    this.btnAdd.Click -= new EventHandler(btnAdd_Click);
                    this.btnAdd.Click += new EventHandler(btnUpd_Click);
                    WorkerTel.ReadOnly = false;
                    txtAddress.ReadOnly = false;
                    List<WorkerHistory> workerHistories = new WorkerHistoryService().SelectHistoryByWorkerId(WorkerNo.Text);
                    for (int i = 0; i < workerHistories.Count; i++)
                    {
                        ucHistory = new ucHistory();
                        ucHistory.dtpStartDate.Value = workerHistories[i].StartDate;
                        ucHistory.dtpEndDate.Value = workerHistories[i].EndDate;
                        ucHistory.txtPosition.Text = workerHistories[i].Position;
                        ucHistory.txtCompany.Text = workerHistories[i].Company;
                        flpHistory.Controls.Add(ucHistory);
                    }
                }
            }
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            bool dr = UIMessageBox.Show("是否确认修改员工信息？", "修改提醒", UIStyle.Green,UIMessageBoxButtons.OKCancel);
            if (dr == true)
            {
                #region 员工信息代码块
                Worker worker = new Worker
                {
                    WorkerId = WorkerNo.Text.Trim(),
                    WorkerName = WorkerName.Text.Trim(),
                    WorkerNation = cbWorkerNation.SelectedValue == null ? "N-00001" : cbWorkerNation.SelectedValue.ToString(),
                    WorkerTel = WorkerTel.Text.Trim(),
                    WorkerAddress = txtAddress.Text.Trim(),
                    WorkerFace = cboWorkerFace.Text.Trim(),
                    WorkerEducation = cboEducation.SelectedValue.ToString() == null ? "E-00001" : cboEducation.SelectedValue.ToString(),
                    datachg_usr = AdminInfo.Account,
                    datachg_date = DateTime.Now
                };
                bool i = new WorkerService().UpdateWorker(worker);
                if (i == true)
                {
                    UIMessageBox.ShowSuccess("信息修改成功！");
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
            if (string.IsNullOrWhiteSpace(worker.WorkerBirthday + ""))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(worker.WorkerClub))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(worker.WorkerNation))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(worker.WorkerPosition))
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
            if (string.IsNullOrWhiteSpace(worker.CardId))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(worker.WorkerEducation))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(worker.WorkerFace))
            {
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
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
                datains_usr = AdminInfo.Account,
                datains_date = DateTime.Now
            };
            try
            {
                if (CheckInput(worker))
                {
                    #region 员工信息添加代码块
                    bool n = new WorkerService().AddWorker(worker);
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
                        bool j = new WorkerHistoryService().AddHistoryByWorkerId(workerHistory);
                        #endregion

                        #region 判断履历和信息代码块
                        if (n == true && j == true)
                        {
                            UIMessageBox.Show("员工信息/履历添加成功！该员工登录密码为：123456，请提醒员工妥善保管并首次登录系统时修改密码！");
                            FrmWorkerManager.Reload();
                            #region 获取添加操作日志所需的信息
                            RecordHelper.Record(AdminInfo.Account + AdminInfo.Name + "于" + DateTime.Now + "进行了添加员工操作，员工编号为：" + WorkerNo.Text + "！", 2);
                            #endregion
                        }
                        else
                        {
                            UIMessageBox.Show("员工信息/履历添加失败，请检查数据格式或稍后再试！");
                        }
                        #endregion
                    }
                }
                else
                {
                    UIMessageBox.Show("信息不能为空！");
                }
            }
            catch(Exception ex)
            {
                UIMessageBox.Show("服务器繁忙或数据格式为空！");
            }
            finally
            {
                this.Close();
            }
        }


        private void WorkerID_Validated(object sender, EventArgs e)
        {
            //获取得到输入的身份证号码
            string identityCard = WorkerID.Text.Trim();
            if (string.IsNullOrEmpty(identityCard))
            {
                //身份证号码不能为空，如果为空返回
                UIMessageBox.ShowWarning("身份证号码不能为空！");
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
            string birthday = "";
            string sex = "";
            if (identityCard.Length == 18)
            {
                var result = new IDCardUtil().SelectCardCode(identityCard);
                var address = result.Replace(",", "").ToString();
                birthday = identityCard.Substring(6, 4) + "-" + identityCard.Substring(10, 2) + "-" + identityCard.Substring(12, 2);
                sex = identityCard.Substring(14, 3);
                txtAddress.Text = address;
                //性别代码为偶数是女性奇数为男性
                if (int.Parse(sex) % 2 == 0)
                {
                    cboSex.SelectedIndex = 0;
                }
                else
                {
                    cboSex.SelectedIndex = 1;
                }
            }
            try
            {
                dtpBirthday.Value = Convert.ToDateTime(birthday);
            }
            catch
            {
                UIMessageBox.ShowError("请正确输入证件号码！");
                return;
            }

            dtpBirthday.Value = Convert.ToDateTime(birthday);
            
            return;
        }

        private void pnlInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddHistory_Click(object sender, EventArgs e)
        {

        }
    }
}