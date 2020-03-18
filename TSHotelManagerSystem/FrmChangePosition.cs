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
    public partial class FrmChangePosition : Form
    {
        public static string wk_WorkerNo;
        public static string wk_WorkerPosition;
        public static string wk_WorkerName;
        public static string wk_WorkerClub;
        public FrmChangePosition()
        {
            InitializeComponent();
        }

        private void FrmChangePosition_Load(object sender, EventArgs e)
        {
            txtworkerId.Text = FrmChangeWorker.wk_WorkerNo;
            txtworkerName.Text = FrmChangeWorker.wk_WorkerName;
            cboClub.Text = FrmChangeWorker.wk_WorkerClub;
            cboPosition.Text = FrmChangeWorker.wk_WorkerPosition;
        }

        private void cboNewClub_TextChanged(object sender, EventArgs e)
        {
            this.Text = "将" + FrmChangeWorker.wk_WorkerClub + "：" + FrmChangeWorker.wk_WorkerName + "任命为：" + cboNewClub.Text + "的" + cboNewPosition.Text + "";
        }

        private void cboNewPosition_TextChanged(object sender, EventArgs e)
        {
            this.Text = "将" + FrmChangeWorker.wk_WorkerClub + "：" + FrmChangeWorker.wk_WorkerName + "任命为：" + cboNewClub.Text + "的" + cboNewPosition.Text + "";

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string sql = "update WORKERINFO set WorkerClub='" + cboNewClub.Text + "',WorkerPosition='" + cboNewPosition.Text + "' where WorkerId='" + txtworkerId.Text + "'";
            SqlConnection con = DBHelper.GetConnection();
            int n = DBHelper.ExecuteNonQuery(sql);
            if (n > 0)
            {
                MessageBox.Show("任命已生效!");
            }
            
            
        }
    }
}
