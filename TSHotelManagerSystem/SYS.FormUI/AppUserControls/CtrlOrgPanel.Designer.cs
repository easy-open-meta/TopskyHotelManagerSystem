namespace SYS.FormUI
{
    partial class CtrlOrgPanel
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            this.labName = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labDecision = new System.Windows.Forms.Label();
            this.labJobs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.BackColor = System.Drawing.Color.Transparent;
            this.labName.Location = new System.Drawing.Point(44, 8);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(0, 13);
            this.labName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "姓名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(10, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "職位:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(9, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "決策:";
            // 
            // labDecision
            // 
            this.labDecision.AutoSize = true;
            this.labDecision.BackColor = System.Drawing.Color.Transparent;
            this.labDecision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDecision.ForeColor = System.Drawing.Color.Blue;
            this.labDecision.Location = new System.Drawing.Point(44, 39);
            this.labDecision.Name = "labDecision";
            this.labDecision.Size = new System.Drawing.Size(0, 13);
            this.labDecision.TabIndex = 5;
            // 
            // labJobs
            // 
            this.labJobs.AutoSize = true;
            this.labJobs.BackColor = System.Drawing.Color.Transparent;
            this.labJobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labJobs.ForeColor = System.Drawing.Color.Blue;
            this.labJobs.Location = new System.Drawing.Point(44, 24);
            this.labJobs.Name = "labJobs";
            this.labJobs.Size = new System.Drawing.Size(0, 15);
            this.labJobs.TabIndex = 6;
            // 
            // CtrlOrgPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.BackgroundImage = global::SYS.FormUI.Properties.Resources.組織圖塊;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.labDecision);
            this.Controls.Add(this.labJobs);
            this.DoubleBuffered = true;
            this.Name = "CtrlOrgPanel";
            this.Size = new System.Drawing.Size(135, 62);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel labName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labDecision;
        private System.Windows.Forms.Label labJobs;
    }
}
