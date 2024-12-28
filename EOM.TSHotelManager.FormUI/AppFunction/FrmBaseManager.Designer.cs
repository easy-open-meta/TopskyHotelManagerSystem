
namespace EOM.TSHotelManager.FormUI
{
    partial class FrmBaseManager
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
            this.flpMenu = new Sunny.UI.UIFlowLayoutPanel();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.btnRoomFix = new Sunny.UI.UIButton();
            this.flpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpMenu
            // 
            this.flpMenu.Controls.Add(this.uiButton1);
            this.flpMenu.Controls.Add(this.btnRoomFix);
            this.flpMenu.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flpMenu.Location = new System.Drawing.Point(1, 2);
            this.flpMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flpMenu.MinimumSize = new System.Drawing.Size(1, 1);
            this.flpMenu.Name = "flpMenu";
            this.flpMenu.Padding = new System.Windows.Forms.Padding(2);
            this.flpMenu.Size = new System.Drawing.Size(208, 486);
            this.flpMenu.TabIndex = 0;
            this.flpMenu.Text = "uiFlowLayoutPanel1";
            this.flpMenu.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton1.Location = new System.Drawing.Point(8, 60);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(192, 42);
            this.uiButton1.TabIndex = 3;
            this.uiButton1.Text = "维修进度";
            // 
            // btnRoomFix
            // 
            this.btnRoomFix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoomFix.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnRoomFix.Location = new System.Drawing.Point(8, 9);
            this.btnRoomFix.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRoomFix.Name = "btnRoomFix";
            this.btnRoomFix.Size = new System.Drawing.Size(192, 42);
            this.btnRoomFix.TabIndex = 1;
            this.btnRoomFix.Text = "客房报修";
            // 
            // FrmBaseManager
            // 
            this.AllowShowTitle = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 490);
            this.ControlBox = false;
            this.Controls.Add(this.flpMenu);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBaseManager";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.ShowRect = false;
            this.ShowTitle = false;
            this.Text = "FrmBaseManager";
            this.Load += new System.EventHandler(this.FrmBaseManager_Load);
            this.flpMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIFlowLayoutPanel flpMenu;
        private Sunny.UI.UIButton btnRoomFix;
        private Sunny.UI.UIButton uiButton1;
    }
}