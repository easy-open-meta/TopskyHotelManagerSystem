using System.Windows.Forms;

namespace SYS.FormUI
{
    public partial class ucHistory : UserControl
    {
        public ucHistory()
        {
            InitializeComponent();
        }

        private void ucHistory_Load(object sender, System.EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                item.Font = UI_FontUtil.controlFont;
            }
        }

        private void ucHistory_SizeChanged(object sender, System.EventArgs e)
        {
        }

        private void ucHistory_SizeChanged(object sender, System.EventArgs e)
        {
        }
    }
}
