namespace SYS.FormUI
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
            this.tmrDate = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMID = new System.Windows.Forms.Panel();
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblScroll = new Sunny.UI.UIScrollingText();
            this.tmrFont = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.iBattery = new Sunny.UI.UIBattery();
            this.btnHello = new Sunny.UI.UIButton();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.picFormSize = new Sunny.UI.UIButton();
            this.picClose = new Sunny.UI.UIButton();
            this.pnlCheckInfo = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCheckDay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.picRoom = new Sunny.UI.UIImageButton();
            this.picCustomer = new Sunny.UI.UIImageButton();
            this.picCommodity = new Sunny.UI.UIImageButton();
            this.picExtend = new Sunny.UI.UIImageButton();
            this.cmsMain.SuspendLayout();
            this.pnlCheckInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCommodity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExtend)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTime.Location = new System.Drawing.Point(53, 157);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(74, 20);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "NowTime";
            // 
            // tmrDate
            // 
            this.tmrDate.Enabled = true;
            this.tmrDate.Interval = 1000;
            this.tmrDate.Tick += new System.EventHandler(this.tmrDate_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(13, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 36);
            this.label1.TabIndex = 14;
            this.label1.Text = "TS酒店管理系统";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMID
            // 
            this.pnlMID.BackColor = System.Drawing.Color.Transparent;
            this.pnlMID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMID.Location = new System.Drawing.Point(4, 225);
            this.pnlMID.Name = "pnlMID";
            this.pnlMID.Size = new System.Drawing.Size(1072, 490);
            this.pnlMID.TabIndex = 23;
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
            this.cmsMain.Size = new System.Drawing.Size(144, 160);
            this.cmsMain.Opening += new System.ComponentModel.CancelEventHandler(this.cmsMain_Opening);
            // 
            // tsmiMain
            // 
            this.tsmiMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsmiMain.Name = "tsmiMain";
            this.tsmiMain.Size = new System.Drawing.Size(143, 24);
            this.tsmiMain.Text = "主界面";
            this.tsmiMain.Click += new System.EventHandler(this.tsmiMain_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(140, 6);
            // 
            // tsmiChangeUser
            // 
            this.tsmiChangeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsmiChangeUser.Name = "tsmiChangeUser";
            this.tsmiChangeUser.Size = new System.Drawing.Size(143, 24);
            this.tsmiChangeUser.Text = "切换用户";
            this.tsmiChangeUser.Click += new System.EventHandler(this.tsmiChangeUser_Click);
            // 
            // tsmiLockScreen
            // 
            this.tsmiLockScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsmiLockScreen.Name = "tsmiLockScreen";
            this.tsmiLockScreen.Size = new System.Drawing.Size(143, 24);
            this.tsmiLockScreen.Text = "快速锁屏";
            this.tsmiLockScreen.Click += new System.EventHandler(this.tsmiLockScreen_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(140, 6);
            // 
            // tsmiCheckUpdate
            // 
            this.tsmiCheckUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsmiCheckUpdate.Name = "tsmiCheckUpdate";
            this.tsmiCheckUpdate.Size = new System.Drawing.Size(143, 24);
            this.tsmiCheckUpdate.Text = "检查更新";
            this.tsmiCheckUpdate.Click += new System.EventHandler(this.tsmiCheckUpdate_Click);
            // 
            // tsmiAboutUs
            // 
            this.tsmiAboutUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsmiAboutUs.Name = "tsmiAboutUs";
            this.tsmiAboutUs.Size = new System.Drawing.Size(143, 24);
            this.tsmiAboutUs.Text = "关于我们";
            this.tsmiAboutUs.Click += new System.EventHandler(this.tsmiAboutUs_Click);
            // 
            // tsmiExitSystem
            // 
            this.tsmiExitSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsmiExitSystem.Name = "tsmiExitSystem";
            this.tsmiExitSystem.Size = new System.Drawing.Size(143, 24);
            this.tsmiExitSystem.Text = "退出系统";
            this.tsmiExitSystem.Click += new System.EventHandler(this.tsmiExitSystem_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(178, 21);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(50, 17);
            this.linkLabel1.TabIndex = 26;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "未打卡";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Green;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblScroll
            // 
            this.lblScroll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.lblScroll.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblScroll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.lblScroll.Interval = 1000;
            this.lblScroll.Location = new System.Drawing.Point(234, 7);
            this.lblScroll.MinimumSize = new System.Drawing.Size(1, 1);
            this.lblScroll.Name = "lblScroll";
            this.lblScroll.Size = new System.Drawing.Size(760, 42);
            this.lblScroll.TabIndex = 0;
            // 
            // tmrFont
            // 
            this.tmrFont.Enabled = true;
            this.tmrFont.Interval = 1000;
            this.tmrFont.Tick += new System.EventHandler(this.tmrFont_Tick);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(53, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "NowTime";
            // 
            // iBattery
            // 
            this.iBattery.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.iBattery.Location = new System.Drawing.Point(1020, 52);
            this.iBattery.MinimumSize = new System.Drawing.Size(1, 1);
            this.iBattery.Name = "iBattery";
            this.iBattery.Size = new System.Drawing.Size(56, 35);
            this.iBattery.Style = Sunny.UI.UIStyle.Custom;
            this.iBattery.TabIndex = 32;
            this.iBattery.Text = "uiBattery1";
            this.iBattery.Visible = false;
            // 
            // btnHello
            // 
            this.btnHello.BackColor = System.Drawing.Color.Transparent;
            this.btnHello.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHello.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnHello.FillColor = System.Drawing.Color.Transparent;
            this.btnHello.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnHello.Location = new System.Drawing.Point(12, 182);
            this.btnHello.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnHello.Name = "btnHello";
            this.btnHello.Radius = 20;
            this.btnHello.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.btnHello.RectColor = System.Drawing.Color.Transparent;
            this.btnHello.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btnHello.Size = new System.Drawing.Size(35, 35);
            this.btnHello.Style = Sunny.UI.UIStyle.Custom;
            this.btnHello.StyleCustomMode = true;
            this.btnHello.TabIndex = 33;
            // 
            // uiButton1
            // 
            this.uiButton1.BackColor = System.Drawing.Color.Transparent;
            this.uiButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiButton1.BackgroundImage")));
            this.uiButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.uiButton1.FillColor = System.Drawing.Color.Transparent;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton1.Location = new System.Drawing.Point(12, 146);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Radius = 20;
            this.uiButton1.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiButton1.RectColor = System.Drawing.Color.Transparent;
            this.uiButton1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiButton1.Size = new System.Drawing.Size(35, 35);
            this.uiButton1.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton1.StyleCustomMode = true;
            this.uiButton1.TabIndex = 31;
            // 
            // picFormSize
            // 
            this.picFormSize.BackColor = System.Drawing.Color.Transparent;
            this.picFormSize.BackgroundImage = global::SYS.FormUI.Properties.Resources.arrow_down_b;
            this.picFormSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFormSize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picFormSize.FillColor = System.Drawing.Color.Transparent;
            this.picFormSize.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.picFormSize.Location = new System.Drawing.Point(1000, 6);
            this.picFormSize.MinimumSize = new System.Drawing.Size(1, 1);
            this.picFormSize.Name = "picFormSize";
            this.picFormSize.Radius = 20;
            this.picFormSize.Size = new System.Drawing.Size(35, 35);
            this.picFormSize.Style = Sunny.UI.UIStyle.Custom;
            this.picFormSize.StyleCustomMode = true;
            this.picFormSize.TabIndex = 29;
            this.picFormSize.Click += new System.EventHandler(this.picFormSize_Click_1);
            this.picFormSize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picFormSize_MouseDown);
            this.picFormSize.MouseLeave += new System.EventHandler(this.picFormSize_MouseLeave_1);
            this.picFormSize.MouseHover += new System.EventHandler(this.picFormSize_MouseHover);
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.BackgroundImage = global::SYS.FormUI.Properties.Resources.close;
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.FillColor = System.Drawing.Color.Transparent;
            this.picClose.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.picClose.Location = new System.Drawing.Point(1041, 6);
            this.picClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.picClose.Name = "picClose";
            this.picClose.Radius = 20;
            this.picClose.Size = new System.Drawing.Size(35, 35);
            this.picClose.Style = Sunny.UI.UIStyle.Custom;
            this.picClose.TabIndex = 28;
            this.picClose.Click += new System.EventHandler(this.picClose_Click_1);
            this.picClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picClose_MouseDown);
            this.picClose.MouseLeave += new System.EventHandler(this.picClose_MouseLeave_1);
            this.picClose.MouseHover += new System.EventHandler(this.picClose_MouseHover);
            // 
            // pnlCheckInfo
            // 
            this.pnlCheckInfo.BackColor = System.Drawing.Color.Transparent;
            this.pnlCheckInfo.BackgroundImage = global::SYS.FormUI.Properties.Resources.打卡;
            this.pnlCheckInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCheckInfo.Controls.Add(this.lblClose);
            this.pnlCheckInfo.Controls.Add(this.label4);
            this.pnlCheckInfo.Controls.Add(this.lblCheckDay);
            this.pnlCheckInfo.Controls.Add(this.label2);
            this.pnlCheckInfo.Location = new System.Drawing.Point(173, 53);
            this.pnlCheckInfo.Name = "pnlCheckInfo";
            this.pnlCheckInfo.Size = new System.Drawing.Size(88, 73);
            this.pnlCheckInfo.TabIndex = 27;
            this.pnlCheckInfo.Visible = false;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblClose.Location = new System.Drawing.Point(66, 5);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(16, 17);
            this.lblClose.TabIndex = 3;
            this.lblClose.Text = "×";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(18, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "天";
            // 
            // lblCheckDay
            // 
            this.lblCheckDay.AutoSize = true;
            this.lblCheckDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCheckDay.Location = new System.Drawing.Point(7, 28);
            this.lblCheckDay.Name = "lblCheckDay";
            this.lblCheckDay.Size = new System.Drawing.Size(48, 17);
            this.lblCheckDay.TabIndex = 1;
            this.lblCheckDay.Text = "36500";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(5, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "您已打卡：";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Location = new System.Drawing.Point(12, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(155, 97);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // picRoom
            // 
            this.picRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRoom.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.picRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.picRoom.Image = ((System.Drawing.Image)(resources.GetObject("picRoom.Image")));
            this.picRoom.ImageHover = ((System.Drawing.Image)(resources.GetObject("picRoom.ImageHover")));
            this.picRoom.ImagePress = ((System.Drawing.Image)(resources.GetObject("picRoom.ImagePress")));
            this.picRoom.Location = new System.Drawing.Point(257, 132);
            this.picRoom.Name = "picRoom";
            this.picRoom.Size = new System.Drawing.Size(124, 83);
            this.picRoom.TabIndex = 34;
            this.picRoom.TabStop = false;
            this.picRoom.Text = null;
            this.picRoom.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.picRoom.Click += new System.EventHandler(this.picRoom_Click);
            // 
            // picCustomer
            // 
            this.picCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCustomer.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.picCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.picCustomer.Image = ((System.Drawing.Image)(resources.GetObject("picCustomer.Image")));
            this.picCustomer.ImageHover = ((System.Drawing.Image)(resources.GetObject("picCustomer.ImageHover")));
            this.picCustomer.ImagePress = ((System.Drawing.Image)(resources.GetObject("picCustomer.ImagePress")));
            this.picCustomer.Location = new System.Drawing.Point(479, 132);
            this.picCustomer.Name = "picCustomer";
            this.picCustomer.Size = new System.Drawing.Size(124, 83);
            this.picCustomer.TabIndex = 35;
            this.picCustomer.TabStop = false;
            this.picCustomer.Text = null;
            this.picCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.picCustomer.WaitOnLoad = true;
            this.picCustomer.Click += new System.EventHandler(this.picCustomer_Click);
            // 
            // picCommodity
            // 
            this.picCommodity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCommodity.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.picCommodity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.picCommodity.Image = ((System.Drawing.Image)(resources.GetObject("picCommodity.Image")));
            this.picCommodity.ImageHover = ((System.Drawing.Image)(resources.GetObject("picCommodity.ImageHover")));
            this.picCommodity.ImagePress = ((System.Drawing.Image)(resources.GetObject("picCommodity.ImagePress")));
            this.picCommodity.Location = new System.Drawing.Point(710, 132);
            this.picCommodity.Name = "picCommodity";
            this.picCommodity.Size = new System.Drawing.Size(124, 83);
            this.picCommodity.TabIndex = 36;
            this.picCommodity.TabStop = false;
            this.picCommodity.Text = null;
            this.picCommodity.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.picCommodity.WaitOnLoad = true;
            this.picCommodity.Click += new System.EventHandler(this.picCommodity_Click);
            // 
            // picExtend
            // 
            this.picExtend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExtend.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.picExtend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.picExtend.Image = ((System.Drawing.Image)(resources.GetObject("picExtend.Image")));
            this.picExtend.ImageHover = ((System.Drawing.Image)(resources.GetObject("picExtend.ImageHover")));
            this.picExtend.ImagePress = ((System.Drawing.Image)(resources.GetObject("picExtend.ImagePress")));
            this.picExtend.Location = new System.Drawing.Point(928, 132);
            this.picExtend.Name = "picExtend";
            this.picExtend.Size = new System.Drawing.Size(124, 83);
            this.picExtend.TabIndex = 37;
            this.picExtend.TabStop = false;
            this.picExtend.Text = null;
            this.picExtend.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.picExtend.WaitOnLoad = true;
            this.picExtend.Click += new System.EventHandler(this.picExtend_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.btnHello);
            this.Controls.Add(this.iBattery);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblScroll);
            this.Controls.Add(this.picFormSize);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.pnlCheckInfo);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pnlMID);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.picRoom);
            this.Controls.Add(this.picCustomer);
            this.Controls.Add(this.picCommodity);
            this.Controls.Add(this.picExtend);
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
            this.cmsMain.ResumeLayout(false);
            this.pnlCheckInfo.ResumeLayout(false);
            this.pnlCheckInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCommodity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExtend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tmrDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel pnlMID;
        private System.Windows.Forms.ToolStripMenuItem tsmiMain;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
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
        private Sunny.UI.UIButton picClose;
        private Sunny.UI.UIButton picFormSize;
        private System.Windows.Forms.Timer tmrFont;
        private Sunny.UI.UIScrollingText lblScroll;
        private System.Windows.Forms.Label label3;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIBattery iBattery;
        private Sunny.UI.UIButton btnHello;
        private Sunny.UI.UIImageButton picRoom;
        private Sunny.UI.UIImageButton picCustomer;
        private Sunny.UI.UIImageButton picCommodity;
        private Sunny.UI.UIImageButton picExtend;
    }
}