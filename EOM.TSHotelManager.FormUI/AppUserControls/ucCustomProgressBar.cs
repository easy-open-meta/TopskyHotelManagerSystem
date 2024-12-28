namespace EOM.TSHotelManager.FormUI
{
    public partial class ucCustomProgressBar : UserControl
    {
        private ProgressBar progressBar;

        public ucCustomProgressBar()
        {
            InitializeDefaults();
        }

        private void InitializeDefaults()
        {
            this.Width = 300;
            this.Height = 30;
            this.MaximumSize = new Size(300, 30);

            progressBar = new ProgressBar
            {
                Dock = DockStyle.Fill,
                Maximum = 100
            };

            this.Controls.Add(progressBar);
        }

        // 更新进度
        public int Value
        {
            get => progressBar.Value;
            set => progressBar.Value = value;
        }

        // 自定义显示方法
        public new void Show()
        {
            base.Show();
            progressBar.Visible = true;
        }

        // 自定义关闭方法
        public new void Close()
        {
            // 用 Dispose 方法表示关闭
            this.Dispose();
        }

        // 在父控件中居中显示
        public void CenterInParent()
        {
            if (this.Parent != null)
            {
                int x = (this.Parent.ClientSize.Width - this.Width) / 2;
                int y = (this.Parent.ClientSize.Height - this.Height) / 2;
                this.Location = new Point(x, y);
            }
        }
    }
}
