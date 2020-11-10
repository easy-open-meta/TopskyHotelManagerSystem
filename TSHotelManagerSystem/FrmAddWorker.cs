using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using TSHotelManagerSystem.BLL;
using Core;
using Core;

namespace TSHotelManagerSystem
{
    public partial class FrmAddWorker : Form
    {
        public FrmAddWorker()
        {
            InitializeComponent();
        }

        //EventHandlerList myEventHandlerList = new EventHandlerList(); //事件（委托）列表，记录事件      

        int RandKey = 0;
        ucHistory ucHistory = null;
        private void FrmAddWorker_Load(object sender, EventArgs e)
        {
            Random ran = new Random();
            for (int i = 0; i < 10; i++)
            {
                RandKey = ran.Next(100000000, 999999999);
            }
            pictureBox1.LoadAsync("https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1587209835893&di=02964b1de4a1ef4f938f7d3ae12b5b17&imgtype=0&src=http%3A%2F%2Fbpic.588ku.com%2Felement_origin_min_pic%2F17%2F11%2F25%2F0ef5a188956c2717db96d72d58524dec.jpg");
            if (label13.Text == "员工信息查看页")
            {
                foreach (Control control in pnlInfo.Controls)
                {
                    if (control is TextBox)
                    {
                        (control as TextBox).ReadOnly = true;
                    }
                }
                btnAdd.Visible = false;
                WorkerNo.Text = FrmChangeWorker.wk_WorkerNo;
                WorkerName.Text = FrmChangeWorker.wk_WorkerName;
                cboSex.Text = FrmChangeWorker.wk_WorkerSex;
                cboWorkerPosition.Text = FrmChangeWorker.wk_WorkerPosition;
                cboWorkerFace.Text = FrmChangeWorker.wk_WorkerFace;
                Pwd.Text = "***************";
                dtpBirthday.Value = Convert.ToDateTime(FrmChangeWorker.wk_WorkerBirthday);
                dtpTime.Value = Convert.ToDateTime(FrmChangeWorker.wk_WorkerTime);
                WorkerID.Text = FrmChangeWorker.wk_WorkerID;
                txtAddress.Text = FrmChangeWorker.wk_WorkerAddress;
                WorkerTel.Text = FrmChangeWorker.wk_WorkerTel;
                cboEducation.Text = FrmChangeWorker.wk_WorkerEducation;
                cboClub.Text = FrmChangeWorker.wk_WorkerClub;
                this.WorkerID.Validated -= new EventHandler(WorkerID_Validated);
                List<WorkerHistory> workerHistories = WorkerHistoryManager.SelectHistoryByWorkerId(WorkerNo.Text);
                for (int i = 0; i < workerHistories.Count; i++)
                {
                    ucHistory = new ucHistory();
                    ucHistory.dtpStartDate.Value = workerHistories[i].StartDate;
                    ucHistory.dtpEndDate.Value = workerHistories[i].EndDate;
                    ucHistory.txtPosition.Text = workerHistories[i].Postion.ToString();
                    ucHistory.txtCompany.Text = workerHistories[i].Company.ToString();
                    flpHistory.Controls.Add(ucHistory);
                }
            }
            else if (label13.Text == "员工信息添加页")
            {
                Random random = new Random();
                Pwd.Text = RandKey.ToString();
                WorkerNo.Text = "WK" + random.Next(0, 9).ToString() + random.Next(0, 9).ToString() + random.Next(0, 9).ToString();
                ucHistory = new ucHistory();
                ucHistory.txtCompany.ReadOnly = false;
                ucHistory.txtPosition.ReadOnly = false;
                flpHistory.Controls.Add(ucHistory);
                cboClub.SelectedIndex = 0;
                cboEducation.SelectedIndex = 0;
                cboSex.SelectedIndex = 0;
                cboWorkerFace.SelectedIndex = 0;
                cboWorkerPosition.SelectedIndex = 0;
            }
            else
            {
                DialogResult dr = MessageBox.Show("修改操作仅能修改性别、电话号码、联系地址、登录密码、面貌以及最高学历，以上是否知晓？点击确定继续进行修改！", "修改提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK && Pwd.Text != null)
                {
                    WorkerNo.Text = FrmChangeWorker.wk_WorkerNo;
                    WorkerName.Text = FrmChangeWorker.wk_WorkerName;
                    cboSex.Text = FrmChangeWorker.wk_WorkerSex;
                    cboWorkerPosition.Text = FrmChangeWorker.wk_WorkerPosition;
                    cboWorkerFace.Text = FrmChangeWorker.wk_WorkerFace;
                    //Pwd.Text = "***************";
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
                    Pwd.ReadOnly = false;
                    List<WorkerHistory> workerHistories = WorkerHistoryManager.SelectHistoryByWorkerId(WorkerNo.Text);
                    for (int i = 0; i < workerHistories.Count; i++)
                    {
                        ucHistory = new ucHistory();
                        ucHistory.dtpStartDate.Value = workerHistories[i].StartDate;
                        ucHistory.dtpEndDate.Value = workerHistories[i].EndDate;
                        ucHistory.txtPosition.Text = workerHistories[i].Postion.ToString();
                        ucHistory.txtCompany.Text = workerHistories[i].Company.ToString();
                        flpHistory.Controls.Add(ucHistory);
                    }
                }
            }
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否确认修改员工信息？", "修改提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                #region 员工信息代码块
                Worker worker = new Worker
                {
                    WorkerId = WorkerNo.Text.Trim(),
                    WorkerSex = cboSex.Text,
                    WorkerTel = WorkerTel.Text,
                    WorkerAddress = txtAddress.Text,
                    WorkerPwd = Pwd.Text,
                    WorkerFace = cboWorkerFace.Text,
                    WorkerEduction = cboEducation.Text
                };
                int i = WorkerManager.UpdateWorker(worker);
                if (i > 0)
                {
                    MessageBox.Show("信息修改成功！");
                }
                else
                {
                    MessageBox.Show("服务器繁忙！");
                }
                #endregion
            }
            else
            {
                MessageBox.Show("修改操作已取消！");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (WorkerName.Text != null && ucHistory.txtCompany.Text != null && cboSex.Text != null)
                {
                    #region 员工信息添加代码块
                    Worker worker = new Worker
                    {
                        WorkerId = WorkerNo.Text.Trim(),
                        WorkerName = WorkerName.Text.Trim(),
                        WorkerBirth = dtpBirthday.Value,
                        WorkerSex = cboSex.Text,
                        WorkerTel = WorkerTel.Text,
                        WorkerClub = cboClub.Text,
                        WorkerAddress = txtAddress.Text,
                        WorkerPosition = cboWorkerPosition.Text,
                        CardId = WorkerID.Text,
                        WorkerPwd = Pwd.Text,
                        WorkerTime = dtpTime.Value,
                        WorkerFace = cboWorkerFace.Text,
                        WorkerEduction = cboEducation.Text
                    };
                    int n = WorkerManager.AddWorker(worker);
                    #endregion
                    #region 履历添加代码块
                    if (ucHistory.txtCompany != null && ucHistory.txtPosition != null && ucHistory.dtpStartDate.Value != null && ucHistory.dtpEndDate.Value != null)
                    {
                        WorkerHistory workerHistory = new WorkerHistory
                        {
                            StartDate = ucHistory.dtpStartDate.Value,
                            EndDate = ucHistory.dtpEndDate.Value,
                            Postion = ucHistory.txtPosition.Text,
                            Company = ucHistory.txtCompany.Text
                        };
                        int j = WorkerHistoryManager.AddHistoryByWorkerId(workerHistory, WorkerNo.Text);
                        #endregion

                        #region 判断履历和信息代码块
                        if (n > 0 && j > 0)
                        {
                            MessageBox.Show("员工信息/履历添加成功！该员工登录密码为：" + Pwd.Text + "，请提醒员工妥善保管！");
                            FrmTopChange.Reload();
                            #region 获取添加操作日志所需的信息
                            Operation o = new Operation();
                            o.OperationTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd,HH:mm:ss"));
                            o.Operationlog = AdminInfo.admingroup + AdminInfo.adminType + "于" + DateTime.Now + "进行了添加员工操作，员工编号为：" + WorkerNo.Text + "！";
                            o.OperationAccount = AdminInfo.admingroup + AdminInfo.adminType;
                            OperationManager.InsertOperationLog(o);
                            #endregion
                        }
                        #endregion
                        else
                        {
                            MessageBox.Show("员工信息/履历添加失败，请检查数据格式或稍后再试！");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("信息不能为空！");
                }
            }
            catch
            {
                MessageBox.Show("服务器繁忙或数据格式为空！");
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
                MessageBox.Show("身份证号码不能为空！");
                if (WorkerID.CanFocus)
                {
                    WorkerID.Focus();//设置当前输入焦点为txtCardID_identityCard
                    lblChecked.Text = "◆";
                    lblChecked.ForeColor = Color.Red;
                    lblChecked.Visible = true;
                }
                return;
            }
            else
            {
                //身份证号码只能为15位或18位其它不合法
                if (identityCard.Length != 15 && identityCard.Length != 18)
                {
                    MessageBox.Show("身份证号码为15位或18位，请检查！");
                    if (WorkerID.CanFocus)
                    {
                        WorkerID.Focus();
                        lblChecked.Text = "◆";
                        lblChecked.ForeColor = Color.Red;
                        lblChecked.Visible = true;
                    }
                    return;
                }
            }
            string birthday = "";
            string sex = "";
            if (identityCard.Length == 18)
            {
                SqlConnection con = DBHelper.GetConnection();
                con.Open();
                SqlDataReader dr = DBHelper.ExecuteReader("select Province,City,District from CARDCODES where bm='" + identityCard.Substring(0, 6).ToString() + "'");
                birthday = identityCard.Substring(6, 4) + "-" + identityCard.Substring(10, 2) + "-" + identityCard.Substring(12, 2);
                sex = identityCard.Substring(14, 3);
                while (dr.Read())
                {
                    txtAddress.Text = dr["Province"].ToString() + dr["City"].ToString() + dr["District"].ToString();
                }
                //性别代码为偶数是女性奇数为男性
                if (int.Parse(sex) % 2 == 0)
                {
                    cboSex.Text = "女";
                }
                else
                {
                    cboSex.Text = "男";
                }
                dr.Close();
                con.Close();
            }

            dtpBirthday.Value = Convert.ToDateTime(birthday);
            lblChecked.Text = "◆";
            lblChecked.ForeColor = Color.Green;
            lblChecked.Visible = true;
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