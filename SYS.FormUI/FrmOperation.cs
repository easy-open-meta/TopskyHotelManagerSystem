using System;
using System.Windows.Forms;
using SYS.Application;

namespace SYS.FormUI
{
    public partial class FrmOperation : Form
    {
        public FrmOperation()
        {
            InitializeComponent();
        }

        

        private void FrmOperation_Load(object sender, EventArgs e)
        {
            dgvOperationlog.DataSource = Operationlog.SelectOperationlogAll();
        }
    }
}
