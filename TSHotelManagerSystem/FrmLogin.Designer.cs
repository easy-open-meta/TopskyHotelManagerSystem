namespace TSHotelManagerSystem
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
            this.txtWorkerId = new System.Windows.Forms.TextBox();
            this.txtWorkerPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picMin = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // txtWorkerId
            // 
            this.txtWorkerId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtWorkerId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWorkerId.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtWorkerId.Location = new System.Drawing.Point(581, 167);
            this.txtWorkerId.Margin = new System.Windows.Forms.Padding(0);
            this.txtWorkerId.MaxLength = 8;
            this.txtWorkerId.Name = "txtWorkerId";
            this.txtWorkerId.Size = new System.Drawing.Size(214, 28);
            this.txtWorkerId.TabIndex = 0;
            this.txtWorkerId.WordWrap = false;
            // 
            // txtWorkerPwd
            // 
            this.txtWorkerPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtWorkerPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWorkerPwd.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtWorkerPwd.Location = new System.Drawing.Point(581, 230);
            this.txtWorkerPwd.Margin = new System.Windows.Forms.Padding(0);
            this.txtWorkerPwd.MaxLength = 11;
            this.txtWorkerPwd.Name = "txtWorkerPwd";
            this.txtWorkerPwd.PasswordChar = '*';
            this.txtWorkerPwd.Size = new System.Drawing.Size(214, 28);
            this.txtWorkerPwd.TabIndex = 1;
            this.txtWorkerPwd.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(397, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "  ";
            // 
            // picMin
            // 
            this.picMin.BackColor = System.Drawing.Color.Transparent;
            this.picMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picMin.BackgroundImage")));
            this.picMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMin.Location = new System.Drawing.Point(746, -1);
            this.picMin.Name = "picMin";
            this.picMin.Size = new System.Drawing.Size(35, 35);
            this.picMin.TabIndex = 6;
            this.picMin.TabStop = false;
            this.picMin.Click += new System.EventHandler(this.picMin_Click);
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picClose.BackgroundImage")));
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picClose.Location = new System.Drawing.Point(787, -1);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(35, 35);
            this.picClose.TabIndex = 7;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // picLogin
            // 
            this.picLogin.BackColor = System.Drawing.Color.Transparent;
            this.picLogin.BackgroundImage = global::TSHotelManagerSystem.Properties.Resources.Login_a1;
            this.picLogin.Location = new System.Drawing.Point(581, 302);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(176, 59);
            this.picLogin.TabIndex = 10;
            this.picLogin.TabStop = false;
            this.picLogin.Click += new System.EventHandler(this.picLogin_Click);
            this.picLogin.MouseEnter += new System.EventHandler(this.picLogin_MouseEnter);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(822, 429);
            this.Controls.Add(this.picLogin);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.picMin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWorkerPwd);
            this.Controls.Add(this.txtWorkerId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TS酒店管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseDown);
            this.MouseLeave += new System.EventHandler(this.FrmLogin_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWorkerId;
        private System.Windows.Forms.TextBox txtWorkerPwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picMin;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picLogin;
    }
}

