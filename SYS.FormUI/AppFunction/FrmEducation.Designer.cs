
namespace SYS.FormUI
{
    partial class FrmEducation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEducation));
            this.flpInformation = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpInformation
            // 
            this.flpInformation.AutoScroll = true;
            this.flpInformation.BackColor = System.Drawing.Color.Transparent;
            this.flpInformation.Location = new System.Drawing.Point(441, 39);
            this.flpInformation.Margin = new System.Windows.Forms.Padding(2);
            this.flpInformation.Name = "flpInformation";
            this.flpInformation.Size = new System.Drawing.Size(562, 582);
            this.flpInformation.TabIndex = 73;
            this.flpInformation.SizeChanged += new System.EventHandler(this.flpInformation_SizeChanged);
            // 
            // FrmEducation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 623);
            this.ControlBox = false;
<<<<<<< HEAD
=======
            this.Controls.Add(this.flpInformation);
>>>>>>> fb009c4fe69c0285ef7856f5960db104eecbccf7
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEducation";
            this.ShowIcon = true;
            this.Text = "学历类型维护";
            this.Load += new System.EventHandler(this.FrmEducation_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpInformation;
    }
}