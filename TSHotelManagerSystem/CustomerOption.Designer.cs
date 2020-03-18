namespace TSHotelManagerSystem
{
    partial class CustomerOption
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
            this.picSpend = new System.Windows.Forms.PictureBox();
            this.picCustomer = new System.Windows.Forms.PictureBox();
            this.pnlCustomerMID = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picSpend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // picSpend
            // 
            this.picSpend.BackColor = System.Drawing.Color.Transparent;
            this.picSpend.BackgroundImage = global::TSHotelManagerSystem.Properties.Resources.消费管理_ia;
            this.picSpend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picSpend.Location = new System.Drawing.Point(1, 101);
            this.picSpend.Name = "picSpend";
            this.picSpend.Size = new System.Drawing.Size(189, 50);
            this.picSpend.TabIndex = 5;
            this.picSpend.TabStop = false;
            this.picSpend.MouseEnter += new System.EventHandler(this.picSpend_MouseEnter);
            this.picSpend.MouseLeave += new System.EventHandler(this.picSpend_MouseLeave);
            // 
            // picCustomer
            // 
            this.picCustomer.BackColor = System.Drawing.Color.Transparent;
            this.picCustomer.BackgroundImage = global::TSHotelManagerSystem.Properties.Resources.用户管理_ia1;
            this.picCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picCustomer.Location = new System.Drawing.Point(1, 32);
            this.picCustomer.Name = "picCustomer";
            this.picCustomer.Size = new System.Drawing.Size(189, 50);
            this.picCustomer.TabIndex = 3;
            this.picCustomer.TabStop = false;
            this.picCustomer.Click += new System.EventHandler(this.picCustomer_Click);
            this.picCustomer.MouseEnter += new System.EventHandler(this.picCustomer_MouseEnter);
            this.picCustomer.MouseLeave += new System.EventHandler(this.picCustomer_MouseLeave);
            // 
            // pnlCustomerMID
            // 
            this.pnlCustomerMID.Location = new System.Drawing.Point(203, 1);
            this.pnlCustomerMID.Name = "pnlCustomerMID";
            this.pnlCustomerMID.Size = new System.Drawing.Size(788, 451);
            this.pnlCustomerMID.TabIndex = 16;
            // 
            // CustomerOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(994, 453);
            this.Controls.Add(this.pnlCustomerMID);
            this.Controls.Add(this.picSpend);
            this.Controls.Add(this.picCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerOption";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.CustomerOption_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSpend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picSpend;
        private System.Windows.Forms.PictureBox picCustomer;
        private System.Windows.Forms.Panel pnlCustomerMID;
    }
}