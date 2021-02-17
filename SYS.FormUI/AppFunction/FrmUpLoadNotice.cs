using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using SYS.Core;
using SYS.Application;
using Sunny.UI;

namespace SYS.FormUI
{
    public partial class FrmUpLoadNotice : UIForm
    {
        public FrmUpLoadNotice()
        {
            InitializeComponent();
        }

        public bool CheckInput(string Content) 
        {
            if (string.IsNullOrWhiteSpace(Content))
            {
                return false;
            }

            if (Content.Contains("alert") || Content.Contains("ALERT"))
            {
                return false;
            }
            return true;
        }

        private void btnUpLoad_Click(object sender, EventArgs e)
        {
            if (CheckInput(rtbNoticeContent.Html))
            {
                Notice notice = new Notice()
                {
                    NoticeNo = new CounterHelper().GetNewId("NoticeId"),
                    Noticetheme = txtNoticeTheme.Text.Trim(),
                    NoticeContent = rtbNoticeContent.Html,
                    NoticeTime = dtpUpLoadDate.Value,
                    NoticeClub = cboSelectClub.SelectedValue.ToString(),
                    datains_usr = AdminInfo.Account,
                    datains_date = DateTime.Now
                };

                switch (cbNoticeType.Text)
                {
                    case "人事变动":
                        notice.NoticeTypeName = "PersonnelChanges";
                        break;
                    case "普通公告":
                        notice.NoticeTypeName = "GeneralNotice";
                        break;
                }

                bool n = new NoticeService().InsertNotice(notice);
                MessageBox.Show("上传成功！");
                #region 获取添加操作日志所需的信息
                OperationLog o = new OperationLog();
                o.OperationTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd,HH:mm:ss"));
                o.Operationlog = AdminInfo.Account + AdminInfo.Name + "于" + DateTime.Now + "进行了上传公告操作！编号为：" + notice.NoticeNo;
                o.OperationAccount = AdminInfo.Account + AdminInfo.Name;
                o.datains_usr = AdminInfo.Account;
                o.datains_date = DateTime.Now;
                #endregion
                new OperationlogService().InsertOperationLog(o);
            }
            else
            {
                UIMessageBox.ShowWarning("含有非法操作字符！");
                return;
            }
            foreach (Control Ctrol in this.Controls)
            {
                if (Ctrol is TextBox)
                {
                    Ctrol.Text = "";
                }
                if (Ctrol is KSharpEditor.KEditor)
                {
                    Ctrol.Text = "";
                }
            }
        }

        

        private void FrmUpLoad_Load(object sender, EventArgs e)
        {
            foreach (Control label in this.Controls)
            {
                label.Font = UI_FontUtil.controlFont;
            }
            cboSelectClub.DataSource = new BaseService().SelectDeptAll();
            cboSelectClub.DisplayMember = "dept_name";
            cboSelectClub.ValueMember = "dept_no";
            
        }

        private void dgvNoticeList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtUpLoadNo.Text = dgvNoticeList.SelectedRows[0].Cells["clNoticeNo"].Value.ToString();
            //txtNoticeTheme.Text = dgvNoticeList.SelectedRows[0].Cells["clNoticetheme"].Value.ToString();
            //rtbNoticeContent.Text = dgvNoticeList.SelectedRows[0].Cells["clNoticeContent"].Value.ToString();
            //cboSelectClub.Text= dgvNoticeList.SelectedRows[0].Cells["clNoticeClub"].ToString();
            //txtNoticePerson.Text= dgvNoticeList.SelectedRows[0].Cells["clNoticePerson"].ToString();
        }

    }
}
