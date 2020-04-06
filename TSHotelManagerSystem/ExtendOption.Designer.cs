namespace TSHotelManagerSystem
{
    partial class ExtendOption
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
            this.pnlExtendMID = new System.Windows.Forms.Panel();
            this.picMore = new System.Windows.Forms.PictureBox();
            this.picWeb = new System.Windows.Forms.PictureBox();
            this.picCall = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWeb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCall)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlExtendMID
            // 
            this.pnlExtendMID.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlExtendMID.Location = new System.Drawing.Point(1, 36);
            this.pnlExtendMID.Name = "pnlExtendMID";
            this.pnlExtendMID.Size = new System.Drawing.Size(991, 417);
            this.pnlExtendMID.TabIndex = 12;
            // 
            // picMore
            // 
            this.picMore.BackColor = System.Drawing.Color.Transparent;
            this.picMore.BackgroundImage = global::TSHotelManagerSystem.Properties.Resources.更多扩展_ib;
            this.picMore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMore.Location = new System.Drawing.Point(345, 1);
            this.picMore.Name = "picMore";
            this.picMore.Size = new System.Drawing.Size(166, 34);
            this.picMore.TabIndex = 11;
            this.picMore.TabStop = false;
            this.picMore.Click += new System.EventHandler(this.picMore_Click);
            // 
            // picWeb
            // 
            this.picWeb.BackColor = System.Drawing.Color.Transparent;
            this.picWeb.BackgroundImage = global::TSHotelManagerSystem.Properties.Resources.网页预约_ib;
            this.picWeb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picWeb.Location = new System.Drawing.Point(173, 1);
            this.picWeb.Name = "picWeb";
            this.picWeb.Size = new System.Drawing.Size(166, 34);
            this.picWeb.TabIndex = 10;
            this.picWeb.TabStop = false;
            this.picWeb.Click += new System.EventHandler(this.picWeb_Click);
            this.picWeb.MouseEnter += new System.EventHandler(this.picWeb_MouseEnter);
            // 
            // picCall
            // 
            this.picCall.BackColor = System.Drawing.Color.Transparent;
            this.picCall.BackgroundImage = global::TSHotelManagerSystem.Properties.Resources.内部飞鸽_ib;
            this.picCall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picCall.Location = new System.Drawing.Point(1, 1);
            this.picCall.Name = "picCall";
            this.picCall.Size = new System.Drawing.Size(166, 34);
            this.picCall.TabIndex = 9;
            this.picCall.TabStop = false;
            this.picCall.Click += new System.EventHandler(this.picCall_Click);
            this.picCall.MouseEnter += new System.EventHandler(this.picCall_MouseEnter);
            // 
            // ExtendOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(994, 453);
            this.Controls.Add(this.pnlExtendMID);
            this.Controls.Add(this.picMore);
            this.Controls.Add(this.picWeb);
            this.Controls.Add(this.picCall);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExtendOption";
            this.Text = "ExtendOption";
            this.Load += new System.EventHandler(this.ExtendOption_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWeb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picMore;
        private System.Windows.Forms.PictureBox picWeb;
        private System.Windows.Forms.PictureBox picCall;
        private System.Windows.Forms.Panel pnlExtendMID;
    }
}