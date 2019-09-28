namespace TSHotelManagerSystem
{
    partial class FrmOperation
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
            this.dgvOperationlog = new System.Windows.Forms.DataGridView();
            this.clOperationTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clOperationLog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clOperationAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperationlog)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOperationlog
            // 
            this.dgvOperationlog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOperationlog.BackgroundColor = System.Drawing.Color.White;
            this.dgvOperationlog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperationlog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clOperationTime,
            this.clOperationLog,
            this.clOperationAccount});
            this.dgvOperationlog.Location = new System.Drawing.Point(12, 17);
            this.dgvOperationlog.Name = "dgvOperationlog";
            this.dgvOperationlog.RowTemplate.Height = 23;
            this.dgvOperationlog.Size = new System.Drawing.Size(965, 461);
            this.dgvOperationlog.TabIndex = 0;
            // 
            // clOperationTime
            // 
            this.clOperationTime.DataPropertyName = "OperationTime";
            this.clOperationTime.HeaderText = "操作时间";
            this.clOperationTime.Name = "clOperationTime";
            // 
            // clOperationLog
            // 
            this.clOperationLog.DataPropertyName = "OperationLog";
            this.clOperationLog.HeaderText = "日志详情";
            this.clOperationLog.Name = "clOperationLog";
            // 
            // clOperationAccount
            // 
            this.clOperationAccount.DataPropertyName = "OperationAccount";
            this.clOperationAccount.HeaderText = "操作账号";
            this.clOperationAccount.Name = "clOperationAccount";
            // 
            // FrmOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(989, 495);
            this.Controls.Add(this.dgvOperationlog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOperation";
            this.Text = "FrmOperation";
            this.Load += new System.EventHandler(this.FrmOperation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperationlog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOperationlog;
        private System.Windows.Forms.DataGridViewTextBoxColumn clOperationTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clOperationLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn clOperationAccount;
    }
}