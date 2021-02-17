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
<<<<<<< HEAD
=======
            foreach (Control item in this.Controls)
            {
                item.Font = UI_FontUtil.mainFont;
            }
            
>>>>>>> fb009c4fe69c0285ef7856f5960db104eecbccf7
            dgvCheckInfo.AutoGenerateColumns = false;
            dgvCheckInfo.DataSource = new CheckInfoService().SelectCheckInfoAll();
        }
    }
}
