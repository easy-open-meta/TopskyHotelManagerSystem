using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using SYS.Manager;
using SYS.Core;

namespace SYS.FormUI
{
    public partial class FrmUpLoadNotice : Form
    {
        public FrmUpLoadNotice()
        {
            InitializeComponent();
        }

        private void UpLoadNotice_Click(object sender, EventArgs e)
        {
            pnlUpLoad.Visible = true;
        }

        private void btnUpLoad_Click(object sender, EventArgs e)
        {
            string sql = "insert UPLOADINFO(NoticeNo,Noticetheme,NoticeTime,NoticeContent,NoticeClub,NoticePerson)";
            sql += " values('" + txtUpLoadNo.Text + "','" + txtNoticeTheme.Text + "','" + dtpUpLoadDate.Value.ToShortDateString() + "','" + rtbNoticeContent.Text + "','" + cboSelectClub.Text + "','Admin')";
            MySqlConnection con = DBHelper.GetConnection();
            con.Open();
            int n = DBHelper.ExecuteNonQuery(sql);
            MessageBox.Show("上传成功，上传日期为：" + DateTime.Now.ToShortDateString() + "");
            #region 获取添加操作日志所需的信息
            OperationLog o = new OperationLog();
            o.OperationTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd,HH:mm:ss"));
            o.Operationlog = AdminInfo.Account + AdminInfo.Name + "于" + DateTime.Now + "进行了上传公告操作！";
            o.OperationAccount = AdminInfo.Account + AdminInfo.Name;
            #endregion
            OperationlogManager.InsertOperationLog(o);
            foreach (Control Ctrol in pnlUpLoad.Controls)
            {
                if (Ctrol is TextBox)
                {
                    Ctrol.Text = "";
                }
                if (Ctrol is RichTextBox)
                {
                    Ctrol.Text = "";
                }
            }
        }

        

        private void FrmUpLoad_Load(object sender, EventArgs e)
        {
            
            cboSelectClub.SelectedIndex = 0;
            
        }

        private void dgvNoticeList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pnlUpLoad.Visible = true;
            //txtUpLoadNo.Text = dgvNoticeList.SelectedRows[0].Cells["clNoticeNo"].Value.ToString();
            //txtNoticeTheme.Text = dgvNoticeList.SelectedRows[0].Cells["clNoticetheme"].Value.ToString();
            //rtbNoticeContent.Text = dgvNoticeList.SelectedRows[0].Cells["clNoticeContent"].Value.ToString();
            //cboSelectClub.Text= dgvNoticeList.SelectedRows[0].Cells["clNoticeClub"].ToString();
            //txtNoticePerson.Text= dgvNoticeList.SelectedRows[0].Cells["clNoticePerson"].ToString();
        }
    }
}
