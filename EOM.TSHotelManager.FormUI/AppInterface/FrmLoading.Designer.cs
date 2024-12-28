namespace EOM.TSHotelManager.FormUI
{
    partial class FrmLoading
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTips = new Sunny.UI.UILabel();
            uiTitlePanel1 = new Sunny.UI.UITitlePanel();
            lblSoftwareVersion = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            uiTitlePanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTips
            // 
            lblTips.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblTips.ForeColor = Color.FromArgb(48, 48, 48);
            lblTips.Location = new Point(44, 51);
            lblTips.Name = "lblTips";
            lblTips.Size = new Size(247, 23);
            lblTips.TabIndex = 1;
            lblTips.Text = "检测新版本中，请让计算机保持联网状态.....";
            lblTips.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uiTitlePanel1
            // 
            uiTitlePanel1.Controls.Add(lblSoftwareVersion);
            uiTitlePanel1.Controls.Add(uiLabel2);
            uiTitlePanel1.Font = new Font("微软雅黑", 12F);
            uiTitlePanel1.ForeColor = Color.White;
            uiTitlePanel1.Location = new Point(44, 91);
            uiTitlePanel1.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel1.MinimumSize = new Size(1, 1);
            uiTitlePanel1.Name = "uiTitlePanel1";
            uiTitlePanel1.Padding = new Padding(0, 25, 0, 0);
            uiTitlePanel1.ShowCollapse = true;
            uiTitlePanel1.ShowText = false;
            uiTitlePanel1.Size = new Size(247, 66);
            uiTitlePanel1.TabIndex = 2;
            uiTitlePanel1.Text = "软件版本信息";
            uiTitlePanel1.TextAlignment = ContentAlignment.MiddleCenter;
            uiTitlePanel1.TitleHeight = 25;
            // 
            // lblSoftwareVersion
            // 
            lblSoftwareVersion.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblSoftwareVersion.ForeColor = Color.FromArgb(48, 48, 48);
            lblSoftwareVersion.Location = new Point(123, 33);
            lblSoftwareVersion.Name = "lblSoftwareVersion";
            lblSoftwareVersion.Size = new Size(110, 23);
            lblSoftwareVersion.TabIndex = 6;
            lblSoftwareVersion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(15, 33);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(110, 23);
            uiLabel2.TabIndex = 3;
            uiLabel2.Text = "本地程序版本号：";
            uiLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmLoading
            // 
            AllowShowTitle = false;
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(335, 180);
            Controls.Add(uiTitlePanel1);
            Controls.Add(lblTips);
            Name = "FrmLoading";
            Padding = new Padding(0);
            ShowTitle = false;
            Text = "FrmLoading";
            ZoomScaleRect = new Rectangle(15, 15, 580, 256);
            Load += FrmLoading_Load;
            uiTitlePanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UILabel lblTips;
        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private Sunny.UI.UILabel lblDllVersion;
        private Sunny.UI.UILabel lblSoftwareVersion;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
    }
}