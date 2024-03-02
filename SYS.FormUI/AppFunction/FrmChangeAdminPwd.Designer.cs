
namespace SYS.FormUI
{
    partial class FrmChangeAdminPwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChangeAdminPwd));
            this.btnUpdPwd = new Sunny.UI.UIButton();
            this.lblNewMsg = new Sunny.UI.UILabel();
            this.lblOldMsg = new Sunny.UI.UILabel();
            this.lgCheckNewPwd = new Sunny.UI.UILight();
            this.lgCheckOldPwd = new Sunny.UI.UILight();
            this.txtOldPwd = new Sunny.UI.UITextBox();
            this.txtNewPwd = new Sunny.UI.UITextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdPwd
            // 
            this.btnUpdPwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdPwd.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnUpdPwd.Location = new System.Drawing.Point(294, 232);
            this.btnUpdPwd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnUpdPwd.Name = "btnUpdPwd";
            this.btnUpdPwd.Radius = 20;
            this.btnUpdPwd.Size = new System.Drawing.Size(115, 42);
            this.btnUpdPwd.TabIndex = 140;
            this.btnUpdPwd.Text = "修    改";
            this.btnUpdPwd.Click += new System.EventHandler(this.btnUpdPwd_Click);
            // 
            // lblNewMsg
            // 
            this.lblNewMsg.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblNewMsg.Location = new System.Drawing.Point(100, 195);
            this.lblNewMsg.Name = "lblNewMsg";
            this.lblNewMsg.Size = new System.Drawing.Size(267, 23);
            this.lblNewMsg.TabIndex = 139;
            this.lblNewMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOldMsg
            // 
            this.lblOldMsg.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblOldMsg.Location = new System.Drawing.Point(100, 107);
            this.lblOldMsg.Name = "lblOldMsg";
            this.lblOldMsg.Size = new System.Drawing.Size(267, 23);
            this.lblOldMsg.TabIndex = 138;
            this.lblOldMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lgCheckNewPwd
            // 
            this.lgCheckNewPwd.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.lgCheckNewPwd.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lgCheckNewPwd.Location = new System.Drawing.Point(369, 145);
            this.lgCheckNewPwd.MinimumSize = new System.Drawing.Size(1, 1);
            this.lgCheckNewPwd.Name = "lgCheckNewPwd";
            this.lgCheckNewPwd.OnCenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.lgCheckNewPwd.Radius = 35;
            this.lgCheckNewPwd.Size = new System.Drawing.Size(35, 35);
            this.lgCheckNewPwd.TabIndex = 137;
            this.lgCheckNewPwd.Text = "uiLight2";
            this.lgCheckNewPwd.Visible = false;
            // 
            // lgCheckOldPwd
            // 
            this.lgCheckOldPwd.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.lgCheckOldPwd.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lgCheckOldPwd.Location = new System.Drawing.Point(369, 57);
            this.lgCheckOldPwd.MinimumSize = new System.Drawing.Size(1, 1);
            this.lgCheckOldPwd.Name = "lgCheckOldPwd";
            this.lgCheckOldPwd.OnCenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.lgCheckOldPwd.Radius = 35;
            this.lgCheckOldPwd.Size = new System.Drawing.Size(35, 35);
            this.lgCheckOldPwd.TabIndex = 136;
            this.lgCheckOldPwd.Text = "uiLight1";
            this.lgCheckOldPwd.Visible = false;
            // 
            // txtOldPwd
            // 
            this.txtOldPwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOldPwd.FillColor = System.Drawing.Color.White;
            this.txtOldPwd.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOldPwd.Location = new System.Drawing.Point(95, 57);
            this.txtOldPwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOldPwd.Maximum = 2147483647D;
            this.txtOldPwd.Minimum = -2147483648D;
            this.txtOldPwd.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtOldPwd.Name = "txtOldPwd";
            this.txtOldPwd.Padding = new System.Windows.Forms.Padding(5);
            this.txtOldPwd.PasswordChar = '*';
            this.txtOldPwd.Radius = 20;
            this.txtOldPwd.Size = new System.Drawing.Size(272, 35);
            this.txtOldPwd.Style = Sunny.UI.UIStyle.Custom;
            this.txtOldPwd.StyleCustomMode = true;
            this.txtOldPwd.TabIndex = 135;
            this.txtOldPwd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtOldPwd.Validated += new System.EventHandler(this.txtOldPwd_Validated);
            this.txtOldPwd.TextChanged += new System.EventHandler(this.txtOldPwd_TextChanged);
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPwd.FillColor = System.Drawing.Color.White;
            this.txtNewPwd.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNewPwd.Location = new System.Drawing.Point(95, 145);
            this.txtNewPwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNewPwd.Maximum = 2147483647D;
            this.txtNewPwd.Minimum = -2147483648D;
            this.txtNewPwd.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.Padding = new System.Windows.Forms.Padding(5);
            this.txtNewPwd.PasswordChar = '*';
            this.txtNewPwd.Radius = 20;
            this.txtNewPwd.Size = new System.Drawing.Size(272, 35);
            this.txtNewPwd.Style = Sunny.UI.UIStyle.Custom;
            this.txtNewPwd.StyleCustomMode = true;
            this.txtNewPwd.TabIndex = 136;
            this.txtNewPwd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(19, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 133;
            this.label4.Text = "新密码";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(19, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 132;
            this.label6.Text = "旧密码";
            // 
            // FrmChangeAdminPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 294);
            this.Controls.Add(this.btnUpdPwd);
            this.Controls.Add(this.lblNewMsg);
            this.Controls.Add(this.lblOldMsg);
            this.Controls.Add(this.lgCheckNewPwd);
            this.Controls.Add(this.lgCheckOldPwd);
            this.Controls.Add(this.txtOldPwd);
            this.Controls.Add(this.txtNewPwd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmChangeAdminPwd";
            this.ShowIcon = true;
            this.ShowTitleIcon = true;
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.FrmChangeAdminPwd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIButton btnUpdPwd;
        private Sunny.UI.UILabel lblNewMsg;
        private Sunny.UI.UILabel lblOldMsg;
        private Sunny.UI.UILight lgCheckNewPwd;
        private Sunny.UI.UILight lgCheckOldPwd;
        private Sunny.UI.UITextBox txtOldPwd;
        private Sunny.UI.UITextBox txtNewPwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}