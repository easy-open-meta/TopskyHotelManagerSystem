using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSHotelManagerSystem.Properties;

namespace TSHotelManagerSystem
{
    public partial class ExtendOption : Form
    {
        public ExtendOption()
        {
            InitializeComponent();
        }

        private void picCall_Click(object sender, EventArgs e)
        {
            picCall.BackgroundImage = Resources.内部飞鸽_ia;
            picWeb.BackgroundImage = Resources.网页预约_ib;
            picMore.BackgroundImage = Resources.更多扩展_ib;
        }

        private void picCall_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void ExtendOption_Load(object sender, EventArgs e)
        {

        }

        private void picWeb_Click(object sender, EventArgs e)
        {
            picCall.BackgroundImage = Resources.内部飞鸽_ib;
            picWeb.BackgroundImage = Resources.网页预约_ia;
            picMore.BackgroundImage = Resources.更多扩展_ib;
            pnlExtendMID.Controls.Clear();
            WebSite frm1 = new WebSite();
            frm1.TopLevel = false;
            pnlExtendMID.Controls.Add(frm1);
            frm1.Show();
        }

        private void picMore_Click(object sender, EventArgs e)
        {
            picCall.BackgroundImage = Resources.内部飞鸽_ib;
            picWeb.BackgroundImage = Resources.网页预约_ib;
            picMore.BackgroundImage = Resources.更多扩展_ia;
            MessageBox.Show("更多扩展功能请浏览https://www.jackson.xyz 获取","来自智能小T的提醒");
        }

        private void picWeb_MouseEnter(object sender, EventArgs e)
        {
            picCall.BackgroundImage = Resources.内部飞鸽_ib;
            picWeb.BackgroundImage = Resources.网页预约_ia;
            picMore.BackgroundImage = Resources.更多扩展_ib;
        }
    }
}
