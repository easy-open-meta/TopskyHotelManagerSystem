using AntdUI;

namespace EOM.TSHotelManager.FormUI
{
    public partial class FrmProgress : Window
    {
        public FrmProgress()
        {
            InitializeComponent();
            // 创建ProgressBar控件并配置
            ProgressBar progressBar = new ProgressBar
            {
                Dock = DockStyle.Fill,
                Style = ProgressBarStyle.Marquee,
                MarqueeAnimationSpeed = 30,
                Size = new Size(196, 23)
            };

            this.Controls.Add(progressBar);
            this.Text = "Loading...";
            this.TopMost = true;
            this.Size = new System.Drawing.Size(196, 23);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ControlBox = false;
        }

        private void FrmProgress_Load(object sender, EventArgs e)
        {

        }
    }
}
