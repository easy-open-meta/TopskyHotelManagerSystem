using Sunny.UI;
using SYS.Application;
using System;
using System.Windows.Forms;

namespace SYS.FormUI
{
    public partial class FrmCheckList : UIForm
    {
        public FrmCheckList()
        {
            InitializeComponent();
        }


        private void FrmCashList_Load(object sender, EventArgs e)
        {
            dgvCheckInfo.AutoGenerateColumns = false;
            dgvCheckInfo.DataSource = new CheckInfoService().SelectCheckInfoAll();
        }
    }
}
