namespace TSHotelManagerSystem
{
    partial class RoomOption
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
            this.pnlRoomMID = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlRoomMID
            // 
            this.pnlRoomMID.BackColor = System.Drawing.Color.Transparent;
            this.pnlRoomMID.Location = new System.Drawing.Point(3, 38);
            this.pnlRoomMID.Name = "pnlRoomMID";
            this.pnlRoomMID.Size = new System.Drawing.Size(993, 414);
            this.pnlRoomMID.TabIndex = 3;
            // 
            // RoomOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(999, 453);
            this.Controls.Add(this.pnlRoomMID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.RoomOption_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlRoomMID;
    }
}