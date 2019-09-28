using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSHotelManagerSystem.Properties;

namespace TSHotelManagerSystem
{
    public partial class FrmTopSkyLogo : Form
    {
        public FrmTopSkyLogo()
        {
            InitializeComponent();
        }

        private void FrmTopSkyLogo_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void FrmTopSkyLogo_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
        }
    }
}
