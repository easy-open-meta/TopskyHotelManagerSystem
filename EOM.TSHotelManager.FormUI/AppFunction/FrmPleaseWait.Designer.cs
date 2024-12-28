
namespace EOM.TSHotelManager.FormUI
{
    partial class FrmPleaseWait
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
            this.lblScroll = new Sunny.UI.UIScrollingText();
            this.SuspendLayout();
            // 
            // lblScroll
            // 
            this.lblScroll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.lblScroll.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblScroll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.lblScroll.Interval = 800;
            this.lblScroll.Location = new System.Drawing.Point(154, 290);
            this.lblScroll.MinimumSize = new System.Drawing.Size(1, 1);
            this.lblScroll.Name = "lblScroll";
            this.lblScroll.Offset = 20;
            this.lblScroll.Size = new System.Drawing.Size(693, 42);
            this.lblScroll.TabIndex = 34;
            this.lblScroll.Text = "功能即将上线，敬请期待...";
            // 
            // FrmPleaseWait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 623);
            this.Controls.Add(this.lblScroll);
            this.Name = "FrmPleaseWait";
            this.Text = "功能即将上线，敬请期待...";
            this.Load += new System.EventHandler(this.FrmPleaseWait_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIScrollingText lblScroll;
    }
}