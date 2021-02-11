using SYS.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYS.FormUI
{
    public partial class FrmNotice : Form
    {
        public FrmNotice()
        {
            InitializeComponent();
        }

        private void FrmNotice_Load(object sender, EventArgs e)
        {
            dgvNoticeList.AutoGenerateColumns = false;
            dgvNoticeList.DataSource = NoticeManager.SelectNoticeAll();
        }
    }
}
