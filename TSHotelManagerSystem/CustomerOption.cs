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
    public partial class CustomerOption : Form
    {
        public CustomerOption()
        {
            InitializeComponent();
        }

        private void CustomerOption_Load(object sender, EventArgs e)
        {

        }

        private void picCustomer_MouseEnter(object sender, EventArgs e)
        {
            picCustomer.BackgroundImage = Resources.用户管理_ia1;
        }

        private void picCustomer_MouseLeave(object sender, EventArgs e)
        {
            picCustomer.BackgroundImage = Resources.用户管理_ib1;
        }

        

        private void picSpend_MouseEnter(object sender, EventArgs e)
        {
            picSpend.BackgroundImage = Resources.消费管理_ia;
        }

        private void picSpend_MouseLeave(object sender, EventArgs e)
        {
            picSpend.BackgroundImage = Resources.消费管理_ib;
        }

        private void picCustomer_Click(object sender, EventArgs e)
        {
            pnlCustomerMID.Controls.Clear();
            FrmCustomerManager frm1 = new FrmCustomerManager();
            frm1.TopLevel = false;
            pnlCustomerMID.Controls.Add(frm1);
            frm1.Show();
        }
    }
}
