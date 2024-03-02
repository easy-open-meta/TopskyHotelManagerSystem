
namespace SYS.FormUI.AppFunction
{
    partial class FrmRoomMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRoomMap));
            this.flpRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpRoom
            // 
            this.flpRoom.AutoScroll = true;
            this.flpRoom.BackColor = System.Drawing.Color.Transparent;
            this.flpRoom.Location = new System.Drawing.Point(83, 99);
            this.flpRoom.Name = "flpRoom";
            this.flpRoom.Size = new System.Drawing.Size(838, 424);
            this.flpRoom.TabIndex = 72;
            this.flpRoom.MouseEnter += new System.EventHandler(this.flpRoom_MouseEnter);
            // 
            // FrmRoomMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 623);
            this.ControlBox = false;
            this.Controls.Add(this.flpRoom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRoomMap";
            this.ShowIcon = true;
            this.ShowTitleIcon = true;
            this.Text = "房态图一览";
            this.Load += new System.EventHandler(this.FrmRoomMap_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpRoom;
    }
}