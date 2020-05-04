namespace TSHotelManagerSystem
{
    partial class FrmStart
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.circleProgramBar1 = new TSHotelManagerSystem.CircleProgramBar();
            this.lblSourceAuthor = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("苹方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(240, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "正在检查是否存在最新版本...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(477, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "该效果实现及代码拥有者为：";
            // 
            // circleProgramBar1
            // 
            this.circleProgramBar1.BackColor = System.Drawing.Color.White;
            this.circleProgramBar1.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circleProgramBar1.FinishedColor = System.Drawing.Color.Green;
            this.circleProgramBar1.Font = new System.Drawing.Font("苹方-简", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.circleProgramBar1.ForeColor = System.Drawing.Color.Black;
            this.circleProgramBar1.Location = new System.Drawing.Point(1, 0);
            this.circleProgramBar1.MaxValue = 100;
            this.circleProgramBar1.Name = "circleProgramBar1";
            this.circleProgramBar1.Progress = 1;
            this.circleProgramBar1.Size = new System.Drawing.Size(692, 339);
            this.circleProgramBar1.TabIndex = 0;
            this.circleProgramBar1.TopColor = System.Drawing.Color.SkyBlue;
            this.circleProgramBar1.TextChanged += new System.EventHandler(this.circleProgramBar1_TextChanged);
            this.circleProgramBar1.Click += new System.EventHandler(this.circleProgramBar1_Click);
            // 
            // lblSourceAuthor
            // 
            this.lblSourceAuthor.AutoSize = true;
            this.lblSourceAuthor.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSourceAuthor.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblSourceAuthor.LinkColor = System.Drawing.Color.Black;
            this.lblSourceAuthor.Location = new System.Drawing.Point(631, 316);
            this.lblSourceAuthor.Name = "lblSourceAuthor";
            this.lblSourceAuthor.Size = new System.Drawing.Size(56, 17);
            this.lblSourceAuthor.TabIndex = 3;
            this.lblSourceAuthor.TabStop = true;
            this.lblSourceAuthor.Text = "遗失情缘";
            this.lblSourceAuthor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSourceAuthor_LinkClicked);
            // 
            // FrmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(693, 338);
            this.Controls.Add(this.lblSourceAuthor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.circleProgramBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "加载中......";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmStart_FormClosed);
            this.Load += new System.EventHandler(this.FrmStart_Load);
            this.TextChanged += new System.EventHandler(this.FrmStart_TextChanged);
            this.Leave += new System.EventHandler(this.FrmStart_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircleProgramBar circleProgramBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lblSourceAuthor;
    }
}