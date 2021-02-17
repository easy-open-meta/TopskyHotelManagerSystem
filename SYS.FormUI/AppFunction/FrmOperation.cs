using Sunny.UI;
using SYS.Application;
using System;
using System.Windows.Forms;

namespace SYS.FormUI
{
    public partial class FrmOperation : UIForm
    {
        public FrmOperation()
        {
            InitializeComponent();
        }

        

        private void FrmOperation_Load(object sender, EventArgs e)
        {
            foreach (Control label in this.Controls)
            {
                label.Font = UI_FontUtil.childControlFont;
            }

            dgvOperationlog.DataSource = new OperationlogService().SelectOperationlogAll();
        }
    }
}
