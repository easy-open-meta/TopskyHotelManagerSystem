using System;
using System.Windows.Forms;

namespace SYS.FormUI
{
    public partial class WebSite : Form
    {
        public WebSite()
        {
            InitializeComponent();
        }

        private void WebSite_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(System.Windows.Forms.Application.StartupPath + "\\网页端\\index.html");
        }


    }
}
