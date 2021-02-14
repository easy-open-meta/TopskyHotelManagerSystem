using SYS.Application;
using System;
using System.Windows.Forms;

namespace SYS.FormUI
{
    public partial class FrmCheckInfo : Form
    {
        public FrmCheckInfo()
        {
            InitializeComponent();
        }

        private void FrmCheckInfo_Load(object sender, EventArgs e)
        {
            dgvCheckInfo.AutoGenerateColumns = false;
            dgvCheckInfo.DataSource = new CheckInfoService().SelectCheckInfoAll();
        }
    }
}
