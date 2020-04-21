namespace TSHotelManagerSystem
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lblTime = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.tmrDate = new System.Windows.Forms.Timer(this.components);
            this.lblScroll = new System.Windows.Forms.Label();
            this.tmrFont = new System.Windows.Forms.Timer(this.components);
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picFormSize = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.picRoom = new System.Windows.Forms.PictureBox();
            this.picCustomer = new System.Windows.Forms.PictureBox();
            this.picExtend = new System.Windows.Forms.PictureBox();
            this.pnlMID = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiMain = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiChangeUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLockScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCheckUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAboutUs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExitSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.fadeTimer = new System.Windows.Forms.Timer(this.components);
            this.picCommodity = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pnlCheckInfo = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCheckDay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFormSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExtend)).BeginInit();
            this.panel1.SuspendLayout();
            this.cmsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCommodity)).BeginInit();
            this.pnlCheckInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTime.Font = new System.Drawing.Font("苹方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTime.Location = new System.Drawing.Point(349, 7);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(80, 22);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "NowTime";
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUserName.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUserName.Location = new System.Drawing.Point(148, 8);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(183, 21);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "Admin【管理员】";
            // 
            // tmrDate
            // 
            this.tmrDate.Enabled = true;
            this.tmrDate.Interval = 1000;
            this.tmrDate.Tick += new System.EventHandler(this.tmrDate_Tick);
            // 
            // lblScroll
            // 
            this.lblScroll.BackColor = System.Drawing.Color.Transparent;
            this.lblScroll.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblScroll.Location = new System.Drawing.Point(-7, 5);
            this.lblScroll.Name = "lblScroll";
            this.lblScroll.Size = new System.Drawing.Size(633, 25);
            this.lblScroll.TabIndex = 0;
            this.lblScroll.Text = "欢迎使用TS酒店管理系统，若遇bug等问题请向工程部进行反馈！";
            this.lblScroll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrFont
            // 
            this.tmrFont.Enabled = true;
            this.tmrFont.Interval = 50;
            this.tmrFont.Tick += new System.EventHandler(this.tmrFont_Tick);
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picClose.BackgroundImage")));
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picClose.Location = new System.Drawing.Point(978, 0);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(35, 35);
            this.picClose.TabIndex = 11;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            this.picClose.MouseEnter += new System.EventHandler(this.picClose_MouseEnter);
            this.picClose.MouseLeave += new System.EventHandler(this.picClose_MouseLeave);
            // 
            // picFormSize
            // 
            this.picFormSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picFormSize.BackColor = System.Drawing.Color.Transparent;
            this.picFormSize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picFormSize.BackgroundImage")));
            this.picFormSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFormSize.Location = new System.Drawing.Point(937, 0);
            this.picFormSize.Name = "picFormSize";
            this.picFormSize.Size = new System.Drawing.Size(35, 35);
            this.picFormSize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picFormSize.TabIndex = 12;
            this.picFormSize.TabStop = false;
            this.picFormSize.Click += new System.EventHandler(this.picFormSize_Click);
            this.picFormSize.MouseEnter += new System.EventHandler(this.picFormSize_MouseEnter);
            this.picFormSize.MouseLeave += new System.EventHandler(this.picFormSize_MouseLeave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("苹方-简", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(0, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "TS酒店管理系统";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Location = new System.Drawing.Point(12, 30);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(147, 97);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // picRoom
            // 
            this.picRoom.BackColor = System.Drawing.Color.Transparent;
            this.picRoom.BackgroundImage = global::TSHotelManagerSystem.Properties.Resources.客房管理_ib;
            this.picRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRoom.Location = new System.Drawing.Point(165, 44);
            this.picRoom.Name = "picRoom";
            this.picRoom.Size = new System.Drawing.Size(124, 83);
            this.picRoom.TabIndex = 16;
            this.picRoom.TabStop = false;
            this.picRoom.Click += new System.EventHandler(this.picRoom_Click);
            // 
            // picCustomer
            // 
            this.picCustomer.BackColor = System.Drawing.Color.Transparent;
            this.picCustomer.BackgroundImage = global::TSHotelManagerSystem.Properties.Resources.用户管理_ib;
            this.picCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCustomer.Location = new System.Drawing.Point(396, 44);
            this.picCustomer.Name = "picCustomer";
            this.picCustomer.Size = new System.Drawing.Size(133, 83);
            this.picCustomer.TabIndex = 17;
            this.picCustomer.TabStop = false;
            this.picCustomer.Click += new System.EventHandler(this.picCustomer_Click);
            // 
            // picExtend
            // 
            this.picExtend.BackColor = System.Drawing.Color.Transparent;
            this.picExtend.BackgroundImage = global::TSHotelManagerSystem.Properties.Resources.扩展功能_ib;
            this.picExtend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picExtend.Location = new System.Drawing.Point(863, 44);
            this.picExtend.Name = "picExtend";
            this.picExtend.Size = new System.Drawing.Size(120, 83);
            this.picExtend.TabIndex = 21;
            this.picExtend.TabStop = false;
            this.picExtend.Click += new System.EventHandler(this.picExtend_Click);
            // 
            // pnlMID
            // 
            this.pnlMID.BackColor = System.Drawing.Color.Transparent;
            this.pnlMID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMID.Location = new System.Drawing.Point(4, 133);
            this.pnlMID.Name = "pnlMID";
            this.pnlMID.Size = new System.Drawing.Size(1005, 454);
            this.pnlMID.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblScroll);
            this.panel1.Location = new System.Drawing.Point(432, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 37);
            this.panel1.TabIndex = 24;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.cmsMain;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "TS酒店管理系统";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // cmsMain
            // 
            this.cmsMain.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMain,
            this.toolStripSeparator1,
            this.tsmiChangeUser,
            this.tsmiLockScreen,
            this.toolStripSeparator2,
            this.tsmiCheckUpdate,
            this.tsmiAboutUs,
            this.tsmiExitSystem});
            this.cmsMain.Name = "cmsMain";
            this.cmsMain.Size = new System.Drawing.Size(145, 172);
            this.cmsMain.Opening += new System.ComponentModel.CancelEventHandler(this.cmsMain_Opening);
            // 
            // tsmiMain
            // 
            this.tsmiMain.Font = new System.Drawing.Font("苹方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsmiMain.Name = "tsmiMain";
            this.tsmiMain.Size = new System.Drawing.Size(144, 26);
            this.tsmiMain.Text = "主界面";
            this.tsmiMain.Click += new System.EventHandler(this.tsmiMain_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(141, 6);
            // 
            // tsmiChangeUser
            // 
            this.tsmiChangeUser.Font = new System.Drawing.Font("苹方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsmiChangeUser.Name = "tsmiChangeUser";
            this.tsmiChangeUser.Size = new System.Drawing.Size(144, 26);
            this.tsmiChangeUser.Text = "切换用户";
            this.tsmiChangeUser.Click += new System.EventHandler(this.tsmiChangeUser_Click);
            // 
            // tsmiLockScreen
            // 
            this.tsmiLockScreen.Font = new System.Drawing.Font("苹方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsmiLockScreen.Name = "tsmiLockScreen";
            this.tsmiLockScreen.Size = new System.Drawing.Size(144, 26);
            this.tsmiLockScreen.Text = "快速锁屏";
            this.tsmiLockScreen.Click += new System.EventHandler(this.tsmiLockScreen_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(141, 6);
            // 
            // tsmiCheckUpdate
            // 
            this.tsmiCheckUpdate.Font = new System.Drawing.Font("苹方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsmiCheckUpdate.Name = "tsmiCheckUpdate";
            this.tsmiCheckUpdate.Size = new System.Drawing.Size(144, 26);
            this.tsmiCheckUpdate.Text = "检查更新";
            this.tsmiCheckUpdate.Click += new System.EventHandler(this.tsmiCheckUpdate_Click);
            // 
            // tsmiAboutUs
            // 
            this.tsmiAboutUs.Font = new System.Drawing.Font("苹方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsmiAboutUs.Name = "tsmiAboutUs";
            this.tsmiAboutUs.Size = new System.Drawing.Size(144, 26);
            this.tsmiAboutUs.Text = "关于我们";
            this.tsmiAboutUs.Click += new System.EventHandler(this.tsmiAboutUs_Click);
            // 
            // tsmiExitSystem
            // 
            this.tsmiExitSystem.Font = new System.Drawing.Font("苹方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsmiExitSystem.Name = "tsmiExitSystem";
            this.tsmiExitSystem.Size = new System.Drawing.Size(144, 26);
            this.tsmiExitSystem.Text = "退出系统";
            this.tsmiExitSystem.Click += new System.EventHandler(this.tsmiExitSystem_Click);
            // 
            // fadeTimer
            // 
            this.fadeTimer.Tick += new System.EventHandler(this.fadeTimer_Tick);
            // 
            // picCommodity
            // 
            this.picCommodity.BackColor = System.Drawing.Color.Transparent;
            this.picCommodity.BackgroundImage = global::TSHotelManagerSystem.Properties.Resources.商品消费_ia;
            this.picCommodity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCommodity.Location = new System.Drawing.Point(636, 44);
            this.picCommodity.Name = "picCommodity";
            this.picCommodity.Size = new System.Drawing.Size(120, 83);
            this.picCommodity.TabIndex = 25;
            this.picCommodity.TabStop = false;
            this.picCommodity.Click += new System.EventHandler(this.picCommodity_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(298, 7);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(51, 20);
            this.linkLabel1.TabIndex = 26;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "未打卡";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Green;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pnlCheckInfo
            // 
            this.pnlCheckInfo.BackColor = System.Drawing.Color.Transparent;
            this.pnlCheckInfo.BackgroundImage = global::TSHotelManagerSystem.Properties.Resources.打卡;
            this.pnlCheckInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCheckInfo.Controls.Add(this.lblClose);
            this.pnlCheckInfo.Controls.Add(this.label4);
            this.pnlCheckInfo.Controls.Add(this.lblCheckDay);
            this.pnlCheckInfo.Controls.Add(this.label2);
            this.pnlCheckInfo.Location = new System.Drawing.Point(295, 30);
            this.pnlCheckInfo.Name = "pnlCheckInfo";
            this.pnlCheckInfo.Size = new System.Drawing.Size(95, 97);
            this.pnlCheckInfo.TabIndex = 27;
            this.pnlCheckInfo.Visible = false;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblClose.Location = new System.Drawing.Point(73, 6);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(17, 20);
            this.lblClose.TabIndex = 3;
            this.lblClose.Text = "×";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(18, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "天";
            // 
            // lblCheckDay
            // 
            this.lblCheckDay.AutoSize = true;
            this.lblCheckDay.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCheckDay.Location = new System.Drawing.Point(9, 35);
            this.lblCheckDay.Name = "lblCheckDay";
            this.lblCheckDay.Size = new System.Drawing.Size(49, 20);
            this.lblCheckDay.TabIndex = 1;
            this.lblCheckDay.Text = "36500";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(8, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "您已打卡：";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImage = global::TSHotelManagerSystem.Properties.Resources.main_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1013, 589);
            this.Controls.Add(this.pnlCheckInfo);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.picCommodity);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMID);
            this.Controls.Add(this.picExtend);
            this.Controls.Add(this.picCustomer);
            this.Controls.Add(this.picRoom);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picFormSize);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblTime);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TS酒店管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseDown_1);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseMove_1);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFormSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExtend)).EndInit();
            this.panel1.ResumeLayout(false);
            this.cmsMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCommodity)).EndInit();
            this.pnlCheckInfo.ResumeLayout(false);
            this.pnlCheckInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tmrDate;
        private System.Windows.Forms.Label lblScroll;
        private System.Windows.Forms.Timer tmrFont;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picFormSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox picRoom;
        private System.Windows.Forms.PictureBox picCustomer;
        private System.Windows.Forms.PictureBox picExtend;
        private System.Windows.Forms.Panel pnlMID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiMain;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangeUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiLockScreen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiCheckUpdate;
        private System.Windows.Forms.ToolStripMenuItem tsmiExitSystem;
        private System.Windows.Forms.Timer fadeTimer;
        private System.Windows.Forms.PictureBox picCommodity;
        private System.Windows.Forms.ToolStripMenuItem tsmiAboutUs;
        public System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel pnlCheckInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCheckDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblClose;
    }
}