﻿namespace SYS.FormUI
{
    partial class FrmChangePosition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChangePosition));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtworkerId = new Sunny.UI.UITextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtworkerName = new Sunny.UI.UITextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPosition = new Sunny.UI.UITextBox();
            this.txtClub = new Sunny.UI.UITextBox();
            this.cboNewClub = new Sunny.UI.UIComboBox();
            this.cboNewPosition = new Sunny.UI.UIComboBox();
            this.btnOK = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label3.Location = new System.Drawing.Point(13, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "原属部门";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label4.Location = new System.Drawing.Point(13, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "原属职位";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label5.Location = new System.Drawing.Point(218, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "调任职位";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label6.Location = new System.Drawing.Point(218, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "调任部门";
            // 
            // txtworkerId
            // 
            this.txtworkerId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtworkerId.Enabled = false;
            this.txtworkerId.FillColor = System.Drawing.Color.White;
            this.txtworkerId.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtworkerId.Location = new System.Drawing.Point(86, 44);
            this.txtworkerId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtworkerId.Maximum = 2147483647D;
            this.txtworkerId.Minimum = -2147483648D;
            this.txtworkerId.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtworkerId.Name = "txtworkerId";
            this.txtworkerId.Padding = new System.Windows.Forms.Padding(5);
            this.txtworkerId.Radius = 20;
            this.txtworkerId.ReadOnly = true;
            this.txtworkerId.Size = new System.Drawing.Size(125, 29);
            this.txtworkerId.Style = Sunny.UI.UIStyle.Custom;
            this.txtworkerId.StyleCustomMode = true;
            this.txtworkerId.TabIndex = 106;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(13, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 21);
            this.label7.TabIndex = 105;
            this.label7.Text = "员工编号";
            // 
            // txtworkerName
            // 
            this.txtworkerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtworkerName.FillColor = System.Drawing.Color.White;
            this.txtworkerName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtworkerName.Location = new System.Drawing.Point(86, 88);
            this.txtworkerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtworkerName.Maximum = 2147483647D;
            this.txtworkerName.Minimum = -2147483648D;
            this.txtworkerName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtworkerName.Name = "txtworkerName";
            this.txtworkerName.Padding = new System.Windows.Forms.Padding(5);
            this.txtworkerName.Radius = 20;
            this.txtworkerName.Size = new System.Drawing.Size(125, 29);
            this.txtworkerName.Style = Sunny.UI.UIStyle.Custom;
            this.txtworkerName.StyleCustomMode = true;
            this.txtworkerName.TabIndex = 108;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(13, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 21);
            this.label8.TabIndex = 107;
            this.label8.Text = "员工姓名";
            // 
            // txtPosition
            // 
            this.txtPosition.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPosition.Enabled = false;
            this.txtPosition.FillColor = System.Drawing.Color.White;
            this.txtPosition.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPosition.Location = new System.Drawing.Point(86, 177);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPosition.Maximum = 2147483647D;
            this.txtPosition.Minimum = -2147483648D;
            this.txtPosition.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Padding = new System.Windows.Forms.Padding(5);
            this.txtPosition.Radius = 20;
            this.txtPosition.Size = new System.Drawing.Size(125, 29);
            this.txtPosition.Style = Sunny.UI.UIStyle.Custom;
            this.txtPosition.StyleCustomMode = true;
            this.txtPosition.TabIndex = 110;
            // 
            // txtClub
            // 
            this.txtClub.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClub.Enabled = false;
            this.txtClub.FillColor = System.Drawing.Color.White;
            this.txtClub.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtClub.Location = new System.Drawing.Point(86, 133);
            this.txtClub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtClub.Maximum = 2147483647D;
            this.txtClub.Minimum = -2147483648D;
            this.txtClub.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtClub.Name = "txtClub";
            this.txtClub.Padding = new System.Windows.Forms.Padding(5);
            this.txtClub.Radius = 20;
            this.txtClub.ReadOnly = true;
            this.txtClub.Size = new System.Drawing.Size(125, 29);
            this.txtClub.Style = Sunny.UI.UIStyle.Custom;
            this.txtClub.StyleCustomMode = true;
            this.txtClub.TabIndex = 109;
            // 
            // cboNewClub
            // 
            this.cboNewClub.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cboNewClub.FillColor = System.Drawing.Color.White;
            this.cboNewClub.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cboNewClub.Location = new System.Drawing.Point(299, 133);
            this.cboNewClub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboNewClub.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboNewClub.Name = "cboNewClub";
            this.cboNewClub.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cboNewClub.Radius = 20;
            this.cboNewClub.Size = new System.Drawing.Size(125, 29);
            this.cboNewClub.TabIndex = 111;
            this.cboNewClub.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboNewPosition
            // 
            this.cboNewPosition.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cboNewPosition.FillColor = System.Drawing.Color.White;
            this.cboNewPosition.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cboNewPosition.Location = new System.Drawing.Point(299, 177);
            this.cboNewPosition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboNewPosition.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboNewPosition.Name = "cboNewPosition";
            this.cboNewPosition.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cboNewPosition.Radius = 20;
            this.cboNewPosition.Size = new System.Drawing.Size(125, 29);
            this.cboNewPosition.TabIndex = 112;
            this.cboNewPosition.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnOK
            // 
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnOK.Location = new System.Drawing.Point(431, 166);
            this.btnOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOK.Name = "btnOK";
            this.btnOK.Radius = 20;
            this.btnOK.Size = new System.Drawing.Size(100, 40);
            this.btnOK.TabIndex = 113;
            this.btnOK.Text = "任     命";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FrmChangePosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 216);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cboNewPosition);
            this.Controls.Add(this.cboNewClub);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.txtClub);
            this.Controls.Add(this.txtworkerName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtworkerId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmChangePosition";
            this.ShowIcon = true;
            this.Text = "将XXX任命为XXX";
            this.Load += new System.EventHandler(this.FrmChangePosition_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Sunny.UI.UITextBox txtworkerId;
        private System.Windows.Forms.Label label7;
        private Sunny.UI.UITextBox txtworkerName;
        private System.Windows.Forms.Label label8;
        private Sunny.UI.UITextBox txtPosition;
        private Sunny.UI.UITextBox txtClub;
        private Sunny.UI.UIComboBox cboNewClub;
        private Sunny.UI.UIComboBox cboNewPosition;
        private Sunny.UI.UIButton btnOK;
    }
}