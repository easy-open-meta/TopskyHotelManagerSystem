namespace EOM.TSHotelManager.FormUI
{
    partial class FrmLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            label2 = new System.Windows.Forms.Label();
            txtWorkerId = new AntdUI.Input();
            txtWorkerPwd = new AntdUI.Input();
            picLogin = new AntdUI.Button();
            btnLoginBackSystem = new AntdUI.Button();
            picFormSize = new AntdUI.Button();
            picClose = new AntdUI.Button();
            avatar1 = new AntdUI.Avatar();
            avatar2 = new AntdUI.Avatar();
            label1 = new AntdUI.Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            label2.Location = new System.Drawing.Point(368, 199);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(29, 20);
            label2.TabIndex = 5;
            label2.Text = "  ";
            // 
            // txtWorkerId
            // 
            txtWorkerId.BackColor = System.Drawing.Color.White;
            txtWorkerId.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F);
            txtWorkerId.Location = new System.Drawing.Point(648, 190);
            txtWorkerId.Name = "txtWorkerId";
            txtWorkerId.Size = new System.Drawing.Size(238, 52);
            txtWorkerId.TabIndex = 32;
            txtWorkerId.Text = "WK010";
            // 
            // txtWorkerPwd
            // 
            txtWorkerPwd.BackColor = System.Drawing.Color.White;
            txtWorkerPwd.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F);
            txtWorkerPwd.Location = new System.Drawing.Point(648, 264);
            txtWorkerPwd.Name = "txtWorkerPwd";
            txtWorkerPwd.PasswordChar = '*';
            txtWorkerPwd.PasswordCopy = true;
            txtWorkerPwd.Size = new System.Drawing.Size(238, 52);
            txtWorkerPwd.TabIndex = 33;
            txtWorkerPwd.Text = "admin";
            // 
            // picLogin
            // 
            picLogin.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            picLogin.Location = new System.Drawing.Point(658, 423);
            picLogin.Name = "picLogin";
            picLogin.Radius = 8;
            picLogin.Shape = AntdUI.TShape.Round;
            picLogin.Size = new System.Drawing.Size(191, 57);
            picLogin.TabIndex = 34;
            picLogin.Text = "登      录";
            picLogin.Type = AntdUI.TTypeMini.Primary;
            picLogin.Click += picLogin_Click;
            // 
            // btnLoginBackSystem
            // 
            btnLoginBackSystem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            btnLoginBackSystem.Location = new System.Drawing.Point(658, 342);
            btnLoginBackSystem.Name = "btnLoginBackSystem";
            btnLoginBackSystem.Radius = 8;
            btnLoginBackSystem.Shape = AntdUI.TShape.Round;
            btnLoginBackSystem.Size = new System.Drawing.Size(191, 57);
            btnLoginBackSystem.TabIndex = 35;
            btnLoginBackSystem.Text = "后台管理系统";
            btnLoginBackSystem.Type = AntdUI.TTypeMini.Primary;
            btnLoginBackSystem.Click += btnLoginBackSystem_Click;
            // 
            // picFormSize
            // 
            picFormSize.BackColor = System.Drawing.Color.Transparent;
            picFormSize.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            picFormSize.Ghost = true;
            picFormSize.BackgroundImage = Properties.Resources.arrow_down_b;
            picFormSize.Location = new System.Drawing.Point(822, 1);
            picFormSize.Name = "picFormSize";
            picFormSize.Size = new System.Drawing.Size(41, 38);
            picFormSize.TabIndex = 36;
            picFormSize.Click += picMin_Click;
            // 
            // picClose
            // 
            picClose.BackColor = System.Drawing.Color.Transparent;
            picClose.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            picClose.Ghost = true;
            picClose.BackgroundImage = Properties.Resources.close;
            picClose.Location = new System.Drawing.Point(875, 1);
            picClose.Name = "picClose";
            picClose.Size = new System.Drawing.Size(41, 38);
            picClose.TabIndex = 37;
            picClose.Click += picClose_Click;
            // 
            // avatar1
            // 
            avatar1.Image = (System.Drawing.Image)resources.GetObject("avatar1.Image");
            avatar1.ImageFit = AntdUI.TFit.None;
            avatar1.Location = new System.Drawing.Point(605, 195);
            avatar1.Name = "avatar1";
            avatar1.Size = new System.Drawing.Size(45, 43);
            avatar1.TabIndex = 38;
            avatar1.Text = "a";
            // 
            // avatar2
            // 
            avatar2.Image = (System.Drawing.Image)resources.GetObject("avatar2.Image");
            avatar2.ImageFit = AntdUI.TFit.None;
            avatar2.Location = new System.Drawing.Point(605, 268);
            avatar2.Name = "avatar2";
            avatar2.Size = new System.Drawing.Size(45, 43);
            avatar2.TabIndex = 39;
            avatar2.Text = "a";
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F);
            label1.Location = new System.Drawing.Point(648, 72);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(222, 83);
            label1.TabIndex = 40;
            label1.Text = "欢迎登录";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(235, 243, 255);
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ClientSize = new System.Drawing.Size(916, 510);
            Controls.Add(label1);
            Controls.Add(avatar2);
            Controls.Add(avatar1);
            Controls.Add(picClose);
            Controls.Add(picFormSize);
            Controls.Add(btnLoginBackSystem);
            Controls.Add(picLogin);
            Controls.Add(txtWorkerPwd);
            Controls.Add(txtWorkerId);
            Controls.Add(label2);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4);
            Name = "FrmLogin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "TS酒店管理系统";
            FormClosing += FrmLogin_FormClosing;
            Load += FrmLogin_Load;
            MouseDown += FrmLogin_MouseDown;
            MouseMove += FrmLogin_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label2;
        private AntdUI.Input txtWorkerId;
        private AntdUI.Input txtWorkerPwd;
        private AntdUI.Button picLogin;
        private AntdUI.Button btnLoginBackSystem;
        private AntdUI.Button picFormSize;
        private AntdUI.Button picClose;
        private AntdUI.Avatar avatar1;
        private AntdUI.Avatar avatar2;
        private AntdUI.Label label1;
    }
}

