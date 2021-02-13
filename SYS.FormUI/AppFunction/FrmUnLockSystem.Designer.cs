﻿namespace SYS.FormUI
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(54, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前系统已锁定，请输入超管密码进行解锁！";
            // 
            // txtUnLockPwd
            // 
            this.txtUnLockPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUnLockPwd.Location = new System.Drawing.Point(121, 86);
            this.txtUnLockPwd.Name = "txtUnLockPwd";
            this.txtUnLockPwd.PasswordChar = '*';
            this.txtUnLockPwd.Size = new System.Drawing.Size(259, 29);
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
            this.btnUnLock.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnUnLock.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.btnUnLock.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btnUnLock.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btnUnLock.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnUnLock.Location = new System.Drawing.Point(199, 127);
            this.btnUnLock.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnUnLock.Name = "btnUnLock";
            this.btnUnLock.Radius = 20;
            this.btnUnLock.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnUnLock.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.btnUnLock.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btnUnLock.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btnUnLock.Size = new System.Drawing.Size(101, 40);
            this.btnUnLock.Style = Sunny.UI.UIStyle.Red;
            this.btnUnLock.TabIndex = 113;
            this.btnUnLock.Text = "解      锁";
            this.btnUnLock.Click += new System.EventHandler(this.btnUnLock_Click);
            // 
            // FrmUnLockSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SYS.FormUI.Properties.Resources._770e7b52ecafc807247aad51bb6c6b43;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(498, 179);
            this.Controls.Add(this.btnUnLock);
            this.Controls.Add(this.txtUnLockPwd);
            this.Controls.Add(this.label1);
            this.IsForbidAltF4 = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUnLockSystem";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ShowInTaskbar = false;
            this.ShowTitle = false;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "系统已锁定！";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
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