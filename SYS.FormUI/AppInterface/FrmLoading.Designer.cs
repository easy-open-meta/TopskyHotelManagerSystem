namespace SYS.FormUI
{
    partial class FrmLoading
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
            this.wbWaiting = new Sunny.UI.UIWaitingBar();
            this.lblTips = new Sunny.UI.UILabel();
            this.uiTitlePanel1 = new Sunny.UI.UITitlePanel();
            this.lblSoftwareNewVersion = new Sunny.UI.UILabel();
            this.lblDllVersion = new Sunny.UI.UILabel();
            this.lblSoftwareVersion = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiTitlePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wbWaiting
            // 
            this.wbWaiting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.wbWaiting.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.wbWaiting.Location = new System.Drawing.Point(12, 40);
            this.wbWaiting.MinimumSize = new System.Drawing.Size(70, 23);
            this.wbWaiting.Name = "wbWaiting";
            this.wbWaiting.Size = new System.Drawing.Size(556, 23);
            this.wbWaiting.TabIndex = 0;
            this.wbWaiting.Text = "uiWaitingBar1";
            // 
            // lblTips
            // 
            this.lblTips.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTips.Location = new System.Drawing.Point(108, 80);
            this.lblTips.Name = "lblTips";
            this.lblTips.Size = new System.Drawing.Size(364, 23);
            this.lblTips.TabIndex = 1;
            this.lblTips.Text = "检测新版本中，请让计算机保持联网状态.....";
            this.lblTips.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTitlePanel1
            // 
            this.uiTitlePanel1.Controls.Add(this.lblSoftwareNewVersion);
            this.uiTitlePanel1.Controls.Add(this.lblDllVersion);
            this.uiTitlePanel1.Controls.Add(this.lblSoftwareVersion);
            this.uiTitlePanel1.Controls.Add(this.uiLabel4);
            this.uiTitlePanel1.Controls.Add(this.uiLabel3);
            this.uiTitlePanel1.Controls.Add(this.uiLabel2);
            this.uiTitlePanel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTitlePanel1.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel1.Location = new System.Drawing.Point(166, 120);
            this.uiTitlePanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel1.Name = "uiTitlePanel1";
            this.uiTitlePanel1.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.uiTitlePanel1.ShowCollapse = true;
            this.uiTitlePanel1.Size = new System.Drawing.Size(247, 124);
            this.uiTitlePanel1.TabIndex = 2;
            this.uiTitlePanel1.Text = "软件版本信息";
            this.uiTitlePanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiTitlePanel1.TitleHeight = 25;
            // 
            // lblSoftwareNewVersion
            // 
            this.lblSoftwareNewVersion.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSoftwareNewVersion.Location = new System.Drawing.Point(122, 93);
            this.lblSoftwareNewVersion.Name = "lblSoftwareNewVersion";
            this.lblSoftwareNewVersion.Size = new System.Drawing.Size(111, 23);
            this.lblSoftwareNewVersion.TabIndex = 8;
            this.lblSoftwareNewVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDllVersion
            // 
            this.lblDllVersion.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDllVersion.Location = new System.Drawing.Point(122, 63);
            this.lblDllVersion.Name = "lblDllVersion";
            this.lblDllVersion.Size = new System.Drawing.Size(111, 23);
            this.lblDllVersion.TabIndex = 7;
            this.lblDllVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSoftwareVersion
            // 
            this.lblSoftwareVersion.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSoftwareVersion.Location = new System.Drawing.Point(123, 33);
            this.lblSoftwareVersion.Name = "lblSoftwareVersion";
            this.lblSoftwareVersion.Size = new System.Drawing.Size(110, 23);
            this.lblSoftwareVersion.TabIndex = 6;
            this.lblSoftwareVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.Location = new System.Drawing.Point(14, 93);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(111, 23);
            this.uiLabel4.TabIndex = 5;
            this.uiLabel4.Text = "程序最新版本号：";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(14, 63);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(111, 23);
            this.uiLabel3.TabIndex = 4;
            this.uiLabel3.Text = "本地链库版本号：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(15, 33);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(110, 23);
            this.uiLabel2.TabIndex = 3;
            this.uiLabel2.Text = "本地程序版本号：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmLoading
            // 
            this.AllowShowTitle = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 256);
            this.Controls.Add(this.uiTitlePanel1);
            this.Controls.Add(this.lblTips);
            this.Controls.Add(this.wbWaiting);
            this.Name = "FrmLoading";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.ShowTitle = false;
            this.Text = "FrmLoading";
            this.Load += new System.EventHandler(this.FrmLoading_Load);
            this.uiTitlePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIWaitingBar wbWaiting;
        private Sunny.UI.UILabel lblTips;
        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private Sunny.UI.UILabel lblSoftwareNewVersion;
        private Sunny.UI.UILabel lblDllVersion;
        private Sunny.UI.UILabel lblSoftwareVersion;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
    }
}