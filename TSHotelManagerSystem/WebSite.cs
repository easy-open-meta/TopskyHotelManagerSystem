using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSHotelManagerSystem
{
    public partial class WebSite : Form
    {
        public WebSite()
        {
            InitializeComponent();
        }

        private void WebSite_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(Application.StartupPath + "\\网页端\\index.html");
        }

        
    }
}
