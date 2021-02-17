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
<<<<<<< HEAD
=======
            foreach (Control label in this.Controls)
            {
                label.Font = UI_FontUtil.childControlFont;
            }
>>>>>>> fb009c4fe69c0285ef7856f5960db104eecbccf7
            dgvSpendList.AutoGenerateColumns = false;
            dgvSpendList.DataSource = new SpendService().SelectSpendInfoAll();
        }
    }
}
