using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSHotelManagerSystem.DAL;

namespace TSHotelManagerSystem
{
    public partial class FrmBackupDatabase : Form
    {
        public FrmBackupDatabase()
        {
            InitializeComponent();
        }

        private void btnLook_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = System.Environment.SpecialFolder.Desktop;
            fbd.SelectedPath = "C:";
            fbd.ShowNewFolderButton = true;
            fbd.Description = "请选择备份目录:";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string Path = fbd.SelectedPath;
                txtBackUpPath.Text = Path;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string strDB = txtBackUpName.Text.ToString().Trim();
            SqlConnection con = DBHelper.GetConnection();
            SqlCommand cmdBK = new SqlCommand();
            cmdBK.CommandType = CommandType.Text;
            cmdBK.Connection = con;
            string Date = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString();
            cmdBK.CommandText = "backup database TSHotelDB to disk='" + txtBackUpPath.Text + '\\' + txtBackUpName.Text + "_" + Date + ".bak'";
            try
            {
                con.Open();
                cmdBK.ExecuteNonQuery();
                MessageBox.Show("备份成功，请前往所选择保存的目录下查看！");
                System.Diagnostics.Process.Start("Explorer.exe", txtBackUpPath.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("备份失败，遇到未知错误！");
            }
            finally
            {
                con.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
