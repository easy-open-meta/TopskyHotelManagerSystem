namespace EOM.TSHotelManager.FormUI
{
    partial class FrmMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            lblTime = new Label();
            tmrDate = new System.Windows.Forms.Timer(components);
            lblSoftName = new Label();
            pnlMID = new Panel();
            notifyIcon1 = new NotifyIcon(components);
            cmsMain = new ContextMenuStrip(components);
            tsmiChangeUser = new ToolStripMenuItem();
            tsmiMySpace = new ToolStripMenuItem();
            tsmiExChange = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            tsmiLockScreen = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            tsmiLoginBackSystem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            tsmiCheckUpdate = new ToolStripMenuItem();
            tsmiAboutUs = new ToolStripMenuItem();
            tsmiExitSystem = new ToolStripMenuItem();
            linkLabel1 = new LinkLabel();
            lblScroll = new Sunny.UI.UIScrollingText();
            tmrFont = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            btnHello = new Sunny.UI.UIButton();
            uiButton1 = new Sunny.UI.UIButton();
            pnlCheckInfo = new Panel();
            lblClose = new Label();
            label4 = new Label();
            lblCheckDay = new Label();
            label2 = new Label();
            picLogo = new PictureBox();
            muNavBar = new AntdUI.Menu();
            btnClose = new AntdUI.Button();
            btnFormSize = new AntdUI.Button();
            btnSetting = new AntdUI.Button();
            cpUITheme = new AntdUI.ColorPicker();
            cmsMain.SuspendLayout();
            pnlCheckInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTime.AutoSize = true;
            lblTime.BackColor = Color.Transparent;
            lblTime.FlatStyle = FlatStyle.Flat;
            lblTime.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblTime.Location = new Point(53, 141);
            lblTime.Margin = new Padding(4, 0, 4, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(92, 24);
            lblTime.TabIndex = 2;
            lblTime.Text = "NowTime";
            // 
            // tmrDate
            // 
            tmrDate.Enabled = true;
            tmrDate.Interval = 60000;
            tmrDate.Tick += tmrDate_Tick;
            // 
            // lblSoftName
            // 
            lblSoftName.BackColor = Color.Transparent;
            lblSoftName.FlatStyle = FlatStyle.Flat;
            lblSoftName.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSoftName.Location = new Point(328, 7);
            lblSoftName.Margin = new Padding(4, 0, 4, 0);
            lblSoftName.Name = "lblSoftName";
            lblSoftName.Size = new Size(547, 36);
            lblSoftName.TabIndex = 14;
            lblSoftName.Text = "TS酒店管理系统";
            lblSoftName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlMID
            // 
            pnlMID.BackColor = Color.Transparent;
            pnlMID.BackgroundImageLayout = ImageLayout.Stretch;
            pnlMID.Location = new Point(4, 225);
            pnlMID.Margin = new Padding(4);
            pnlMID.Name = "pnlMID";
            pnlMID.Size = new Size(1072, 490);
            pnlMID.TabIndex = 23;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "TS酒店管理系统";
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipClosed += notifyIcon1_BalloonTipClosed;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // cmsMain
            // 
            cmsMain.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Italic, GraphicsUnit.Point, 134);
            cmsMain.Items.AddRange(new ToolStripItem[] { tsmiChangeUser, tsmiMySpace, tsmiExChange, toolStripSeparator3, tsmiLockScreen, toolStripSeparator4, tsmiLoginBackSystem, toolStripSeparator2, tsmiCheckUpdate, tsmiAboutUs, tsmiExitSystem });
            cmsMain.Name = "cmsMain";
            cmsMain.RenderMode = ToolStripRenderMode.Professional;
            cmsMain.Size = new Size(208, 214);
            // 
            // tsmiChangeUser
            // 
            tsmiChangeUser.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            tsmiChangeUser.Image = Properties.Resources.切换账号;
            tsmiChangeUser.Name = "tsmiChangeUser";
            tsmiChangeUser.Size = new Size(207, 24);
            tsmiChangeUser.Text = "切换用户";
            tsmiChangeUser.Click += tsmiChangeUser_Click;
            // 
            // tsmiMySpace
            // 
            tsmiMySpace.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            tsmiMySpace.Image = Properties.Resources.个人中心;
            tsmiMySpace.Name = "tsmiMySpace";
            tsmiMySpace.Size = new Size(207, 24);
            tsmiMySpace.Text = "个人中心";
            tsmiMySpace.Click += tsmiMySpace_Click;
            // 
            // tsmiExChange
            // 
            tsmiExChange.Font = new Font("Microsoft Sans Serif", 12F);
            tsmiExChange.Name = "tsmiExChange";
            tsmiExChange.Size = new Size(207, 24);
            tsmiExChange.Text = "换班";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(204, 6);
            // 
            // tsmiLockScreen
            // 
            tsmiLockScreen.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            tsmiLockScreen.Image = Properties.Resources.锁屏;
            tsmiLockScreen.Name = "tsmiLockScreen";
            tsmiLockScreen.Size = new Size(207, 24);
            tsmiLockScreen.Text = "快速锁屏";
            tsmiLockScreen.Click += tsmiLockScreen_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(204, 6);
            // 
            // tsmiLoginBackSystem
            // 
            tsmiLoginBackSystem.Enabled = false;
            tsmiLoginBackSystem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            tsmiLoginBackSystem.Image = Properties.Resources.系统管理员;
            tsmiLoginBackSystem.Name = "tsmiLoginBackSystem";
            tsmiLoginBackSystem.Size = new Size(207, 24);
            tsmiLoginBackSystem.Text = "进入后台管理系统";
            tsmiLoginBackSystem.Click += tsmiLoginBackSystem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(204, 6);
            // 
            // tsmiCheckUpdate
            // 
            tsmiCheckUpdate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            tsmiCheckUpdate.Image = Properties.Resources.检查更新__1_;
            tsmiCheckUpdate.Name = "tsmiCheckUpdate";
            tsmiCheckUpdate.Size = new Size(207, 24);
            tsmiCheckUpdate.Text = "检查更新";
            tsmiCheckUpdate.Click += tsmiCheckUpdate_Click;
            // 
            // tsmiAboutUs
            // 
            tsmiAboutUs.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            tsmiAboutUs.Image = Properties.Resources.关于我们;
            tsmiAboutUs.Name = "tsmiAboutUs";
            tsmiAboutUs.Size = new Size(207, 24);
            tsmiAboutUs.Text = "关于我们";
            tsmiAboutUs.Click += tsmiAboutUs_Click;
            // 
            // tsmiExitSystem
            // 
            tsmiExitSystem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            tsmiExitSystem.Image = Properties.Resources.注销;
            tsmiExitSystem.Name = "tsmiExitSystem";
            tsmiExitSystem.Size = new Size(207, 24);
            tsmiExitSystem.Text = "退出系统";
            tsmiExitSystem.Click += tsmiExitSystem_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Microsoft Sans Serif", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel1.Location = new Point(214, 25);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(50, 17);
            linkLabel1.TabIndex = 26;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "未打卡";
            linkLabel1.VisitedLinkColor = Color.Green;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // lblScroll
            // 
            lblScroll.Active = true;
            lblScroll.FillColor = Color.FromArgb(235, 243, 255);
            lblScroll.Font = new Font("微软雅黑", 12F);
            lblScroll.Interval = 1000;
            lblScroll.Location = new Point(328, 58);
            lblScroll.Margin = new Padding(4);
            lblScroll.MinimumSize = new Size(1, 1);
            lblScroll.Name = "lblScroll";
            lblScroll.Radius = 0;
            lblScroll.RectSides = ToolStripStatusLabelBorderSides.None;
            lblScroll.ScrollingType = Sunny.UI.UIScrollingText.UIScrollingType.LeftToRight;
            lblScroll.Size = new Size(597, 33);
            lblScroll.TabIndex = 0;
            // 
            // tmrFont
            // 
            tmrFont.Enabled = true;
            tmrFont.Interval = 1000;
            tmrFont.Tick += tmrFont_Tick;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F);
            label3.Location = new Point(53, 193);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(54, 24);
            label3.TabIndex = 30;
            label3.Text = "Hello";
            // 
            // btnHello
            // 
            btnHello.BackColor = Color.Transparent;
            btnHello.BackgroundImageLayout = ImageLayout.Zoom;
            btnHello.FillColor = Color.Transparent;
            btnHello.Font = new Font("微软雅黑", 12F);
            btnHello.Location = new Point(5, 183);
            btnHello.Margin = new Padding(4);
            btnHello.MinimumSize = new Size(1, 1);
            btnHello.Name = "btnHello";
            btnHello.Radius = 20;
            btnHello.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            btnHello.RectColor = Color.Transparent;
            btnHello.RectSides = ToolStripStatusLabelBorderSides.None;
            btnHello.Size = new Size(40, 34);
            btnHello.Style = Sunny.UI.UIStyle.Custom;
            btnHello.StyleCustomMode = true;
            btnHello.TabIndex = 33;
            btnHello.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // uiButton1
            // 
            uiButton1.BackColor = Color.Transparent;
            uiButton1.BackgroundImage = (Image)resources.GetObject("uiButton1.BackgroundImage");
            uiButton1.BackgroundImageLayout = ImageLayout.Stretch;
            uiButton1.FillColor = Color.Transparent;
            uiButton1.Font = new Font("微软雅黑", 12F);
            uiButton1.Location = new Point(6, 127);
            uiButton1.Margin = new Padding(4);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Radius = 20;
            uiButton1.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            uiButton1.RectColor = Color.Transparent;
            uiButton1.RectSides = ToolStripStatusLabelBorderSides.None;
            uiButton1.Size = new Size(40, 39);
            uiButton1.Style = Sunny.UI.UIStyle.Custom;
            uiButton1.StyleCustomMode = true;
            uiButton1.TabIndex = 31;
            uiButton1.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // pnlCheckInfo
            // 
            pnlCheckInfo.BackColor = Color.Transparent;
            pnlCheckInfo.BackgroundImage = Properties.Resources.打卡2;
            pnlCheckInfo.BackgroundImageLayout = ImageLayout.Stretch;
            pnlCheckInfo.Controls.Add(lblClose);
            pnlCheckInfo.Controls.Add(label4);
            pnlCheckInfo.Controls.Add(lblCheckDay);
            pnlCheckInfo.Controls.Add(label2);
            pnlCheckInfo.Location = new Point(208, 58);
            pnlCheckInfo.Margin = new Padding(4);
            pnlCheckInfo.Name = "pnlCheckInfo";
            pnlCheckInfo.Size = new Size(103, 103);
            pnlCheckInfo.TabIndex = 27;
            pnlCheckInfo.Visible = false;
            // 
            // lblClose
            // 
            lblClose.AutoSize = true;
            lblClose.Font = new Font("Microsoft Sans Serif", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblClose.Location = new Point(77, 7);
            lblClose.Margin = new Padding(4, 0, 4, 0);
            lblClose.Name = "lblClose";
            lblClose.Size = new Size(16, 17);
            lblClose.TabIndex = 3;
            lblClose.Text = "×";
            lblClose.Click += lblClose_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label4.Location = new Point(21, 68);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(22, 17);
            label4.TabIndex = 2;
            label4.Text = "天";
            // 
            // lblCheckDay
            // 
            lblCheckDay.AutoSize = true;
            lblCheckDay.Font = new Font("Microsoft Sans Serif", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblCheckDay.Location = new Point(8, 40);
            lblCheckDay.Margin = new Padding(4, 0, 4, 0);
            lblCheckDay.Name = "lblCheckDay";
            lblCheckDay.Size = new Size(48, 17);
            lblCheckDay.TabIndex = 1;
            lblCheckDay.Text = "36500";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.Location = new Point(6, 6);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 0;
            label2.Text = "您已打卡：";
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.BackgroundImage = (Image)resources.GetObject("picLogo.BackgroundImage");
            picLogo.BackgroundImageLayout = ImageLayout.Stretch;
            picLogo.Cursor = Cursors.Hand;
            picLogo.Location = new Point(5, 7);
            picLogo.Margin = new Padding(4);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(165, 111);
            picLogo.TabIndex = 15;
            picLogo.TabStop = false;
            picLogo.Click += picLogo_Click;
            // 
            // muNavBar
            // 
            muNavBar.Font = new Font("Microsoft YaHei UI", 14F);
            muNavBar.Location = new Point(311, 172);
            muNavBar.Mode = AntdUI.TMenuMode.Horizontal;
            muNavBar.Name = "muNavBar";
            muNavBar.Size = new Size(765, 45);
            muNavBar.TabIndex = 39;
            muNavBar.Text = "menu1";
            muNavBar.SelectChanged += muNavBar_SelectChanged;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.BackgroundImage = Properties.Resources.close;
            btnClose.Font = new Font("Microsoft YaHei UI", 9F);
            btnClose.Ghost = true;
            btnClose.Location = new Point(1032, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(41, 38);
            btnClose.TabIndex = 41;
            btnClose.Click += picClose_Click;
            // 
            // btnFormSize
            // 
            btnFormSize.BackColor = Color.Transparent;
            btnFormSize.BackgroundImage = Properties.Resources.arrow_down_b;
            btnFormSize.Font = new Font("Microsoft YaHei UI", 9F);
            btnFormSize.Ghost = true;
            btnFormSize.Location = new Point(982, 5);
            btnFormSize.Name = "btnFormSize";
            btnFormSize.Size = new Size(41, 38);
            btnFormSize.TabIndex = 40;
            btnFormSize.Click += picFormSize_Click;
            // 
            // btnSetting
            // 
            btnSetting.BackColor = Color.Transparent;
            btnSetting.BackgroundImage = Properties.Resources.settings2;
            btnSetting.Font = new Font("Microsoft YaHei UI", 9F);
            btnSetting.Ghost = true;
            btnSetting.Location = new Point(932, 5);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(41, 38);
            btnSetting.TabIndex = 42;
            btnSetting.Click += btnSetting_Click;
            // 
            // cpUITheme
            // 
            cpUITheme.Location = new Point(882, 5);
            cpUITheme.Name = "cpUITheme";
            cpUITheme.Size = new Size(41, 38);
            cpUITheme.TabIndex = 43;
            cpUITheme.Text = "colorPicker1";
            cpUITheme.Value = Color.FromArgb(22, 119, 255);
            cpUITheme.ValueChanged += cpUITheme_ValueChanged;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 243, 255);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1080, 721);
            Controls.Add(cpUITheme);
            Controls.Add(lblScroll);
            Controls.Add(btnSetting);
            Controls.Add(btnClose);
            Controls.Add(btnFormSize);
            Controls.Add(muNavBar);
            Controls.Add(btnHello);
            Controls.Add(uiButton1);
            Controls.Add(label3);
            Controls.Add(pnlCheckInfo);
            Controls.Add(linkLabel1);
            Controls.Add(pnlMID);
            Controls.Add(picLogo);
            Controls.Add(lblSoftName);
            Controls.Add(lblTime);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TS酒店管理系统";
            FormClosing += FrmMain_FormClosing;
            FormClosed += FrmMain_FormClosed;
            Load += FrmMain_Load;
            MouseDown += FrmMain_MouseDown_1;
            MouseMove += FrmMain_MouseMove_1;
            cmsMain.ResumeLayout(false);
            pnlCheckInfo.ResumeLayout(false);
            pnlCheckInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tmrDate;
        private System.Windows.Forms.Label lblSoftName;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlMID;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangeUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiLockScreen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiCheckUpdate;
        private System.Windows.Forms.ToolStripMenuItem tsmiExitSystem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAboutUs;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel pnlCheckInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCheckDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblClose;
        public System.Windows.Forms.NotifyIcon notifyIcon1;
        public System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.Timer tmrFont;
        private Sunny.UI.UIScrollingText lblScroll;
        private System.Windows.Forms.Label label3;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIButton btnHello;
        private System.Windows.Forms.ToolStripMenuItem tsmiMySpace;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoginBackSystem;
        private Sunny.UI.UIButton picSetting;
        private System.Windows.Forms.ToolStripMenuItem tsmiExChange;
        private AntdUI.Menu muNavBar;
        private AntdUI.Button btnClose;
        private AntdUI.Button btnFormSize;
        private AntdUI.Button btnSetting;
        private AntdUI.ColorPicker cpUITheme;
    }
}