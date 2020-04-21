using System;
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
