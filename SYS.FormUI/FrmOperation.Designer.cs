namespace SYS.FormUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvOperationlog = new Sunny.UI.UIDataGridView();
            this.clOperationTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clOperationlog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clOperationAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperationlog)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOperationlog
            // 
            this.dgvOperationlog.AllowUserToAddRows = false;
            this.dgvOperationlog.AllowUserToDeleteRows = false;
            this.dgvOperationlog.AllowUserToResizeColumns = false;
            this.dgvOperationlog.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvOperationlog.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOperationlog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOperationlog.BackgroundColor = System.Drawing.Color.White;
            this.dgvOperationlog.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOperationlog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOperationlog.ColumnHeadersHeight = 32;
            this.dgvOperationlog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOperationlog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clOperationTime,
            this.clOperationlog,
            this.clOperationAccount});
            this.dgvOperationlog.EnableHeadersVisualStyles = false;
            this.dgvOperationlog.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgvOperationlog.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvOperationlog.Location = new System.Drawing.Point(1, 2);
            this.dgvOperationlog.MultiSelect = false;
            this.dgvOperationlog.Name = "dgvOperationlog";
            this.dgvOperationlog.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgvOperationlog.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOperationlog.RowTemplate.Height = 29;
            this.dgvOperationlog.SelectedIndex = -1;
            this.dgvOperationlog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOperationlog.ShowGridLine = true;
            this.dgvOperationlog.Size = new System.Drawing.Size(985, 492);
            this.dgvOperationlog.Style = Sunny.UI.UIStyle.Custom;
            this.dgvOperationlog.TabIndex = 1;
            // 
            // clOperationTime
            // 
            this.clOperationTime.DataPropertyName = "OperationTime";
            this.clOperationTime.HeaderText = "操作时间";
            this.clOperationTime.Name = "clOperationTime";
            this.clOperationTime.ReadOnly = true;
            // 
            // clOperationlog
            // 
            this.clOperationlog.DataPropertyName = "Operationlog";
            this.clOperationlog.HeaderText = "操作日志";
            this.clOperationlog.Name = "clOperationlog";
            this.clOperationlog.ReadOnly = true;
            // 
            // clOperationAccount
            // 
            this.clOperationAccount.DataPropertyName = "OperationAccount";
            this.clOperationAccount.HeaderText = "操作人";
            this.clOperationAccount.Name = "clOperationAccount";
            this.clOperationAccount.ReadOnly = true;
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

        private Sunny.UI.UIDataGridView dgvOperationlog;
        private System.Windows.Forms.DataGridViewTextBoxColumn clOperationTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clOperationlog;
        private System.Windows.Forms.DataGridViewTextBoxColumn clOperationAccount;
    }
}