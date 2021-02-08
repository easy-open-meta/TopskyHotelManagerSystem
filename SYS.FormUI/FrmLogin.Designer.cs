namespace SYS.FormUI
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
            this.label2 = new System.Windows.Forms.Label();
            this.picMin = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picLogin = new Sunny.UI.UIButton();
            this.txtWorkerId = new Sunny.UI.UITextBox();
            this.txtWorkerPwd = new Sunny.UI.UITextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
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
            this.picLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.picLogin.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.picLogin.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.picLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.picLogin.Location = new System.Drawing.Point(581, 313);
            this.picLogin.MinimumSize = new System.Drawing.Size(1, 1);
            this.picLogin.Name = "picLogin";
            this.picLogin.Radius = 30;
            this.picLogin.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.picLogin.Size = new System.Drawing.Size(184, 60);
            this.picLogin.Style = Sunny.UI.UIStyle.LightBlue;
            this.picLogin.TabIndex = 15;
            this.picLogin.Text = "登      录";
            this.picLogin.Click += new System.EventHandler(this.picLogin_Click);
            // 
            // txtWorkerId
            // 
            this.txtWorkerId.BackColor = System.Drawing.Color.Transparent;
            this.txtWorkerId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtWorkerId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWorkerId.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtWorkerId.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtWorkerId.Location = new System.Drawing.Point(581, 164);
            this.txtWorkerId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWorkerId.Maximum = 2147483647D;
            this.txtWorkerId.Minimum = -2147483648D;
            this.txtWorkerId.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtWorkerId.Name = "txtWorkerId";
            this.txtWorkerId.Padding = new System.Windows.Forms.Padding(5);
            this.txtWorkerId.Radius = 20;
            this.txtWorkerId.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtWorkerId.Size = new System.Drawing.Size(214, 35);
            this.txtWorkerId.Style = Sunny.UI.UIStyle.Custom;
            this.txtWorkerId.TabIndex = 16;
            this.txtWorkerId.Text = "UITEXTBOX1";
            // 
            // txtWorkerPwd
            // 
            this.txtWorkerPwd.BackColor = System.Drawing.Color.Transparent;
            this.txtWorkerPwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWorkerPwd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtWorkerPwd.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtWorkerPwd.Location = new System.Drawing.Point(581, 227);
            this.txtWorkerPwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWorkerPwd.Maximum = 2147483647D;
            this.txtWorkerPwd.Minimum = -2147483648D;
            this.txtWorkerPwd.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtWorkerPwd.Name = "txtWorkerPwd";
            this.txtWorkerPwd.Padding = new System.Windows.Forms.Padding(5);
            this.txtWorkerPwd.PasswordChar = '*';
            this.txtWorkerPwd.Radius = 20;
            this.txtWorkerPwd.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtWorkerPwd.Size = new System.Drawing.Size(214, 35);
            this.txtWorkerPwd.Style = Sunny.UI.UIStyle.Custom;
            this.txtWorkerPwd.TabIndex = 17;
            this.txtWorkerPwd.Text = "uitextbox1";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(822, 429);
            this.Controls.Add(this.txtWorkerPwd);
            this.Controls.Add(this.txtWorkerId);
            this.Controls.Add(this.picLogin);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.picMin);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TS酒店管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picMin;
        private System.Windows.Forms.PictureBox picClose;
        private Sunny.UI.UIButton picLogin;
        private Sunny.UI.UITextBox txtWorkerId;
        private Sunny.UI.UITextBox txtWorkerPwd;
    }
}

