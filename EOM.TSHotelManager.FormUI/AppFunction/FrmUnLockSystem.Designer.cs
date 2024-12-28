namespace EOM.TSHotelManager.FormUI
{
    partial class FrmUnLockSystem
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUnLockPwd = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnUnLock = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("阿里巴巴普惠体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(33, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前系统已锁定，请输入超管密码进行解锁！";
            // 
            // txtUnLockPwd
            // 
            this.txtUnLockPwd.Font = new System.Drawing.Font("阿里巴巴普惠体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnLockPwd.Location = new System.Drawing.Point(120, 65);
            this.txtUnLockPwd.Name = "txtUnLockPwd";
            this.txtUnLockPwd.PasswordChar = '*';
            this.txtUnLockPwd.Size = new System.Drawing.Size(259, 35);
            this.txtUnLockPwd.TabIndex = 1;
            this.txtUnLockPwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUnLockPwd_KeyDown);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnUnLock
            // 
            this.btnUnLock.BackColor = System.Drawing.Color.Transparent;
            this.btnUnLock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnLock.FillColor = System.Drawing.Color.Red;
            this.btnUnLock.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnUnLock.Location = new System.Drawing.Point(205, 116);
            this.btnUnLock.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnUnLock.Name = "btnUnLock";
            this.btnUnLock.Radius = 20;
            this.btnUnLock.RectColor = System.Drawing.Color.Transparent;
            this.btnUnLock.RectPressColor = System.Drawing.Color.Transparent;
            this.btnUnLock.RectSelectedColor = System.Drawing.Color.Transparent;
            this.btnUnLock.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btnUnLock.Size = new System.Drawing.Size(101, 40);
            this.btnUnLock.Style = Sunny.UI.UIStyle.Custom;
            this.btnUnLock.TabIndex = 113;
            this.btnUnLock.Text = "解      锁";
            this.btnUnLock.Click += new System.EventHandler(this.btnUnLock_Click);
            // 
            // FrmUnLockSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EOM.TSHotelManager.FormUI.Properties.Resources.jpg_auto_04N58PICPw2s58PICaP4M8cef_PIC2018_jpg_w1024_new_small;
            this.ClientSize = new System.Drawing.Size(498, 179);
            this.Controls.Add(this.btnUnLock);
            this.Controls.Add(this.txtUnLockPwd);
            this.Controls.Add(this.label1);
            this.EscClose = false;
            this.IsForbidAltF4 = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUnLockSystem";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.RectColor = System.Drawing.Color.Transparent;
            this.ShowInTaskbar = false;
            this.ShowTitle = false;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "系统已锁定！";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.TopMost = true;
            this.Deactivate += new System.EventHandler(this.FrmUnLockSystem_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmUnLockSystem_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmUnLockSystem_FormClosed);
            this.Load += new System.EventHandler(this.FrmUnLockSystem_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmUnLockSystem_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUnLockPwd;
        private System.Windows.Forms.Timer timer1;
        private Sunny.UI.UIButton btnUnLock;
    }
}