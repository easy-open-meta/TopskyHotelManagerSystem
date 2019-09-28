namespace TSHotelManagerSystem
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
            this.btnUnLock = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文中宋", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(48, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前系统已锁定，请输入密码进行解锁！";
            // 
            // txtUnLockPwd
            // 
            this.txtUnLockPwd.Font = new System.Drawing.Font("华文中宋", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUnLockPwd.Location = new System.Drawing.Point(95, 54);
            this.txtUnLockPwd.Name = "txtUnLockPwd";
            this.txtUnLockPwd.Size = new System.Drawing.Size(259, 33);
            this.txtUnLockPwd.TabIndex = 1;
            this.txtUnLockPwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUnLockPwd_KeyDown);
            // 
            // btnUnLock
            // 
            this.btnUnLock.Font = new System.Drawing.Font("华文中宋", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUnLock.Location = new System.Drawing.Point(178, 97);
            this.btnUnLock.Name = "btnUnLock";
            this.btnUnLock.Size = new System.Drawing.Size(92, 32);
            this.btnUnLock.TabIndex = 2;
            this.btnUnLock.Text = "解   锁";
            this.btnUnLock.UseVisualStyleBackColor = true;
            this.btnUnLock.Click += new System.EventHandler(this.btnUnLock_Click);
            // 
            // FrmUnLockSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 137);
            this.Controls.Add(this.btnUnLock);
            this.Controls.Add(this.txtUnLockPwd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUnLockSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUnLockSystem";
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
        private System.Windows.Forms.Button btnUnLock;
        private System.Windows.Forms.Timer timer1;
    }
}