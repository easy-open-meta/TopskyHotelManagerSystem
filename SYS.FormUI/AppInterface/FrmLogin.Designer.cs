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
            this.picLogin = new Sunny.UI.UIButton();
            this.txtWorkerId = new Sunny.UI.UITextBox();
            this.txtWorkerPwd = new Sunny.UI.UITextBox();
            this.btnLoginBackSystem = new Sunny.UI.UIButton();
            this.picFormSize = new Sunny.UI.UIButton();
            this.uiButton1 = new Sunny.UI.UIButton();
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
            // picLogin
            // 
            this.picLogin.BackColor = System.Drawing.Color.Transparent;
            this.picLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.picLogin.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.picLogin.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.picLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.picLogin.Location = new System.Drawing.Point(581, 357);
            this.picLogin.MinimumSize = new System.Drawing.Size(1, 1);
            this.picLogin.Name = "picLogin";
            this.picLogin.Radius = 30;
            this.picLogin.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.picLogin.Size = new System.Drawing.Size(184, 60);
            this.picLogin.Style = Sunny.UI.UIStyle.Blue;
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
            this.txtWorkerId.Text = "WK010";
            this.txtWorkerId.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.txtWorkerPwd.Text = "admin";
            this.txtWorkerPwd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLoginBackSystem
            // 
            this.btnLoginBackSystem.BackColor = System.Drawing.Color.Transparent;
            this.btnLoginBackSystem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoginBackSystem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnLoginBackSystem.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnLoginBackSystem.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnLoginBackSystem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnLoginBackSystem.Location = new System.Drawing.Point(581, 280);
            this.btnLoginBackSystem.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLoginBackSystem.Name = "btnLoginBackSystem";
            this.btnLoginBackSystem.Radius = 30;
            this.btnLoginBackSystem.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnLoginBackSystem.Size = new System.Drawing.Size(184, 60);
            this.btnLoginBackSystem.Style = Sunny.UI.UIStyle.Blue;
            this.btnLoginBackSystem.TabIndex = 18;
            this.btnLoginBackSystem.Text = "进入后台管理系统";
            this.btnLoginBackSystem.Click += new System.EventHandler(this.btnLoginBackSystem_Click);
            // 
            // picFormSize
            // 
            this.picFormSize.BackColor = System.Drawing.Color.Transparent;
            this.picFormSize.BackgroundImage = global::SYS.FormUI.Properties.Resources.arrow_down_b;
            this.picFormSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFormSize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picFormSize.FillColor = System.Drawing.Color.Transparent;
            this.picFormSize.FillHoverColor = System.Drawing.Color.RoyalBlue;
            this.picFormSize.FillSelectedColor = System.Drawing.Color.RoyalBlue;
            this.picFormSize.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.picFormSize.Location = new System.Drawing.Point(744, 2);
            this.picFormSize.MinimumSize = new System.Drawing.Size(1, 1);
            this.picFormSize.Name = "picFormSize";
            this.picFormSize.Radius = 0;
            this.picFormSize.RectHoverColor = System.Drawing.Color.RoyalBlue;
            this.picFormSize.RectPressColor = System.Drawing.Color.RoyalBlue;
            this.picFormSize.RectSelectedColor = System.Drawing.Color.RoyalBlue;
            this.picFormSize.Size = new System.Drawing.Size(35, 35);
            this.picFormSize.Style = Sunny.UI.UIStyle.Custom;
            this.picFormSize.StyleCustomMode = true;
            this.picFormSize.TabIndex = 31;
            this.picFormSize.Click += new System.EventHandler(this.picMin_Click);
            this.picFormSize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picFormSize_MouseDown);
            this.picFormSize.MouseLeave += new System.EventHandler(this.picFormSize_MouseLeave);
            this.picFormSize.MouseHover += new System.EventHandler(this.picFormSize_MouseHover);
            // 
            // uiButton1
            // 
            this.uiButton1.BackColor = System.Drawing.Color.Transparent;
            this.uiButton1.BackgroundImage = global::SYS.FormUI.Properties.Resources.close;
            this.uiButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.FillColor = System.Drawing.Color.Transparent;
            this.uiButton1.FillHoverColor = System.Drawing.Color.RoyalBlue;
            this.uiButton1.FillSelectedColor = System.Drawing.Color.RoyalBlue;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton1.Location = new System.Drawing.Point(785, 2);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Radius = 0;
            this.uiButton1.RectHoverColor = System.Drawing.Color.RoyalBlue;
            this.uiButton1.RectPressColor = System.Drawing.Color.RoyalBlue;
            this.uiButton1.RectSelectedColor = System.Drawing.Color.RoyalBlue;
            this.uiButton1.Size = new System.Drawing.Size(35, 35);
            this.uiButton1.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton1.TabIndex = 30;
            this.uiButton1.Click += new System.EventHandler(this.picClose_Click);
            this.uiButton1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.uiButton1_MouseDown);
            this.uiButton1.MouseLeave += new System.EventHandler(this.uiButton1_MouseLeave);
            this.uiButton1.MouseHover += new System.EventHandler(this.uiButton1_MouseHover);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(822, 429);
            this.Controls.Add(this.picFormSize);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.btnLoginBackSystem);
            this.Controls.Add(this.txtWorkerPwd);
            this.Controls.Add(this.txtWorkerId);
            this.Controls.Add(this.picLogin);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UIButton picLogin;
        private Sunny.UI.UITextBox txtWorkerId;
        private Sunny.UI.UITextBox txtWorkerPwd;
        private Sunny.UI.UIButton btnLoginBackSystem;
        private Sunny.UI.UIButton picFormSize;
        private Sunny.UI.UIButton uiButton1;
    }
}

