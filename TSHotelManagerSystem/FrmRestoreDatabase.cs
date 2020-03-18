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
    public partial class FrmRestoreDatabase : Form
    {
        public FrmRestoreDatabase()
        {
            InitializeComponent();
        }

        private void btnLook_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = System.Environment.SpecialFolder.Desktop;
            fbd.SelectedPath = "C:";
            fbd.ShowNewFolderButton = true;
            fbd.Description = "请选择源目录:";
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
            cmdBK.CommandText = "restore database TSHotelDB from disk='" + txtBackUpPath.Text + ".bak'";
            try
            {
                con.Open();
                cmdBK.ExecuteNonQuery();
                MessageBox.Show("还原成功！");
            }
            catch (Exception)
            {
                MessageBox.Show("还原失败，遇到未知错误！");
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
