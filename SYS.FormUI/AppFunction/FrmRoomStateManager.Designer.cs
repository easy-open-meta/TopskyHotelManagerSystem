namespace SYS.FormUI
{
    partial class FrmRoomStateManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRoomStateManager));
            this.txtRoomNo = new Sunny.UI.UITextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboState = new Sunny.UI.UIComboBox();
            this.btnOk = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomNo.FillColor = System.Drawing.Color.White;
            this.txtRoomNo.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRoomNo.Location = new System.Drawing.Point(121, 48);
            this.txtRoomNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoomNo.Maximum = 2147483647D;
            this.txtRoomNo.Minimum = -2147483648D;
            this.txtRoomNo.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Padding = new System.Windows.Forms.Padding(5);
            this.txtRoomNo.Radius = 20;
            this.txtRoomNo.Size = new System.Drawing.Size(158, 35);
            this.txtRoomNo.Style = Sunny.UI.UIStyle.Custom;
            this.txtRoomNo.StyleCustomMode = true;
            this.txtRoomNo.TabIndex = 133;
            this.txtRoomNo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(29, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 132;
            this.label2.Text = "客户编号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(29, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 134;
            this.label1.Text = "房间状态";
            // 
            // cboState
            // 
            this.cboState.DataSource = null;
            this.cboState.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cboState.FillColor = System.Drawing.Color.White;
            this.cboState.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.cboState.Items.AddRange(new object[] {
            "前台",
            "小程序",
            "电话"});
            this.cboState.Location = new System.Drawing.Point(121, 101);
            this.cboState.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboState.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboState.Name = "cboState";
            this.cboState.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboState.Radius = 20;
            this.cboState.Size = new System.Drawing.Size(158, 35);
            this.cboState.TabIndex = 135;
            this.cboState.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboState.Watermark = "";
            // 
            // btnOk
            // 
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnOk.Location = new System.Drawing.Point(196, 148);
            this.btnOk.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOk.Name = "btnOk";
            this.btnOk.Radius = 15;
            this.btnOk.Size = new System.Drawing.Size(84, 35);
            this.btnOk.TabIndex = 136;
            this.btnOk.Text = "修改";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // FrmRoomStateManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 196);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cboState);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRoomNo);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRoomStateManager";
            this.ShowIcon = true;
            this.ShowTitleIcon = true;
            this.Text = "修改房间状态";
            this.Load += new System.EventHandler(this.FrmRoomStateManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UITextBox txtRoomNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UIComboBox cboState;
        private Sunny.UI.UIButton btnOk;
    }
}