namespace EOM.TSHotelManager.FormUI
{
    partial class FrmAdminEnter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminEnter));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtAccount = new Sunny.UI.UITextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new Sunny.UI.UITextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uiToolTip1 = new Sunny.UI.UIToolTip(this.components);
            this.btnCheckIn = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(579, 320);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // txtAccount
            // 
            this.txtAccount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccount.FillColor = System.Drawing.Color.White;
            this.txtAccount.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAccount.Location = new System.Drawing.Point(243, 409);
            this.txtAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAccount.Maximum = 100D;
            this.txtAccount.MaxLength = 20;
            this.txtAccount.Minimum = 0D;
            this.txtAccount.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Padding = new System.Windows.Forms.Padding(5);
            this.txtAccount.Radius = 20;
            this.txtAccount.Size = new System.Drawing.Size(208, 35);
            this.txtAccount.Style = Sunny.UI.UIStyle.Custom;
            this.txtAccount.StyleCustomMode = true;
            this.txtAccount.TabIndex = 106;
            this.txtAccount.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(136, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 105;
            this.label1.Text = "管理员账号";
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.FillColor = System.Drawing.Color.White;
            this.txtPassword.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPassword.Location = new System.Drawing.Point(243, 463);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Maximum = 2147483647D;
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Minimum = -2147483648D;
            this.txtPassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(5);
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Radius = 20;
            this.txtPassword.Size = new System.Drawing.Size(208, 35);
            this.txtPassword.Style = Sunny.UI.UIStyle.Custom;
            this.txtPassword.StyleCustomMode = true;
            this.txtPassword.TabIndex = 108;
            this.txtPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(136, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 107;
            this.label3.Text = "管理员密码";
            // 
            // uiToolTip1
            // 
            this.uiToolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.uiToolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.uiToolTip1.OwnerDraw = true;
            this.uiToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.uiToolTip1.ToolTipTitle = "安全模式：";
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckIn.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnCheckIn.Location = new System.Drawing.Point(203, 525);
            this.btnCheckIn.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Radius = 20;
            this.btnCheckIn.Size = new System.Drawing.Size(180, 35);
            this.btnCheckIn.Style = Sunny.UI.UIStyle.Custom;
            this.btnCheckIn.TabIndex = 112;
            this.btnCheckIn.Text = "登      录";
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // FrmAdminEnter
            // 
            this.AcceptButton = this.btnCheckIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(586, 603);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsForbidAltF4 = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdminEnter";
            this.ShowIcon = true;
            this.ShowTitleIcon = true;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "超级管理员安全系统";
            this.Load += new System.EventHandler(this.FrmAdminEnter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UITextBox txtAccount;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UITextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private Sunny.UI.UIToolTip uiToolTip1;
        private Sunny.UI.UIButton btnCheckIn;
    }
}