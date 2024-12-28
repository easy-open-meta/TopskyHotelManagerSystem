namespace EOM.TSHotelManager.FormUI
{
    partial class FrmWorkerPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWorkerPanel));
            this.lblWorker = new System.Windows.Forms.Label();
            this.btnWatchInfo = new Sunny.UI.UIButton();
            this.btnUpWorker = new Sunny.UI.UIButton();
            this.btnGoodBad = new Sunny.UI.UIButton();
            this.btnCheck = new Sunny.UI.UIButton();
            this.btnClose = new Sunny.UI.UIButton();
            this.btnUpdate = new Sunny.UI.UIButton();
            this.btnBlockAccount = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // lblWorker
            // 
            this.lblWorker.AutoSize = true;
            this.lblWorker.BackColor = System.Drawing.Color.Transparent;
            this.lblWorker.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorker.Location = new System.Drawing.Point(86, 48);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(239, 25);
            this.lblWorker.TabIndex = 108;
            this.lblWorker.Text = "XXX部XXX:XXX的操作界面";
            // 
            // btnWatchInfo
            // 
            this.btnWatchInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWatchInfo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnWatchInfo.Location = new System.Drawing.Point(17, 114);
            this.btnWatchInfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnWatchInfo.Name = "btnWatchInfo";
            this.btnWatchInfo.Radius = 15;
            this.btnWatchInfo.Size = new System.Drawing.Size(72, 29);
            this.btnWatchInfo.TabIndex = 110;
            this.btnWatchInfo.Text = "查看信息";
            this.btnWatchInfo.Click += new System.EventHandler(this.btnWatchInfo_Click);
            // 
            // btnUpWorker
            // 
            this.btnUpWorker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpWorker.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpWorker.Location = new System.Drawing.Point(197, 114);
            this.btnUpWorker.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnUpWorker.Name = "btnUpWorker";
            this.btnUpWorker.Radius = 15;
            this.btnUpWorker.Size = new System.Drawing.Size(72, 29);
            this.btnUpWorker.TabIndex = 111;
            this.btnUpWorker.Text = "职位任命";
            this.btnUpWorker.Click += new System.EventHandler(this.btnUpWorker_Click);
            // 
            // btnGoodBad
            // 
            this.btnGoodBad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoodBad.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGoodBad.Location = new System.Drawing.Point(17, 149);
            this.btnGoodBad.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnGoodBad.Name = "btnGoodBad";
            this.btnGoodBad.Radius = 15;
            this.btnGoodBad.Size = new System.Drawing.Size(72, 29);
            this.btnGoodBad.TabIndex = 112;
            this.btnGoodBad.Text = "奖罚情况";
            this.btnGoodBad.Click += new System.EventHandler(this.btnGoodBad_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheck.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCheck.Location = new System.Drawing.Point(107, 149);
            this.btnCheck.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Radius = 15;
            this.btnCheck.Size = new System.Drawing.Size(72, 29);
            this.btnCheck.TabIndex = 113;
            this.btnCheck.Text = "打卡考勤";
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Location = new System.Drawing.Point(197, 149);
            this.btnClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Radius = 15;
            this.btnClose.Size = new System.Drawing.Size(72, 29);
            this.btnClose.TabIndex = 114;
            this.btnClose.Text = "关闭界面";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdate.Location = new System.Drawing.Point(107, 114);
            this.btnUpdate.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Radius = 15;
            this.btnUpdate.Size = new System.Drawing.Size(72, 29);
            this.btnUpdate.TabIndex = 115;
            this.btnUpdate.Text = "修改信息";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBlockAccount
            // 
            this.btnBlockAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBlockAccount.FillColor = System.Drawing.Color.Red;
            this.btnBlockAccount.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBlockAccount.Location = new System.Drawing.Point(287, 114);
            this.btnBlockAccount.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnBlockAccount.Name = "btnBlockAccount";
            this.btnBlockAccount.Radius = 15;
            this.btnBlockAccount.RectColor = System.Drawing.Color.Red;
            this.btnBlockAccount.Size = new System.Drawing.Size(72, 29);
            this.btnBlockAccount.Style = Sunny.UI.UIStyle.Custom;
            this.btnBlockAccount.TabIndex = 116;
            this.btnBlockAccount.Text = "禁用账号";
            this.btnBlockAccount.Click += new System.EventHandler(this.btnBlockAccount_Click);
            // 
            // FrmChangeWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::EOM.TSHotelManager.FormUI.Properties.Resources.常规部门卡片;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(375, 239);
            this.Controls.Add(this.btnBlockAccount);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnGoodBad);
            this.Controls.Add(this.btnUpWorker);
            this.Controls.Add(this.btnWatchInfo);
            this.Controls.Add(this.lblWorker);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmChangeWorker";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XXX员工操作";
            this.Load += new System.EventHandler(this.FrmChangeWorker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblWorker;
        private Sunny.UI.UIButton btnWatchInfo;
        private Sunny.UI.UIButton btnUpWorker;
        private Sunny.UI.UIButton btnGoodBad;
        private Sunny.UI.UIButton btnCheck;
        private Sunny.UI.UIButton btnClose;
        private Sunny.UI.UIButton btnUpdate;
        private Sunny.UI.UIButton btnBlockAccount;
    }
}