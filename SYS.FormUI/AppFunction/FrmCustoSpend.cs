using Sunny.UI;
using SYS.Application;
using System;
using System.Windows.Forms;

namespace SYS.FormUI
{
    public partial class FrmCustoSpend : UIForm
    {
        public FrmCustoSpend()
        {
            InitializeComponent();
        }

        private void FrmCustoSpend_Load(object sender, EventArgs e)
        {
            foreach (Control label in this.Controls)
            {
                label.Font = UI_FontUtil.childControlFont;
            }
            dgvSpendList.AutoGenerateColumns = false;
            dgvSpendList.DataSource = new SpendService().SelectSpendInfoAll();
        }
    }
}
