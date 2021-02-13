﻿namespace SYS.FormUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOperation));
            this.dgvOperationlog = new Sunny.UI.UIDataGridView();
            this.clOperationTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clOperationlog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clOperationAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.clOperationAccount,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOperationlog.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOperationlog.EnableHeadersVisualStyles = false;
            this.dgvOperationlog.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgvOperationlog.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvOperationlog.Location = new System.Drawing.Point(3, 39);
            this.dgvOperationlog.MultiSelect = false;
            this.dgvOperationlog.Name = "dgvOperationlog";
            this.dgvOperationlog.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvOperationlog.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOperationlog.RowTemplate.Height = 29;
            this.dgvOperationlog.SelectedIndex = -1;
            this.dgvOperationlog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOperationlog.ShowGridLine = true;
            this.dgvOperationlog.Size = new System.Drawing.Size(998, 582);
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
            // Column1
            // 
            this.Column1.DataPropertyName = "delete_mk";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "datains_usr";
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "datains_date";
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "datachg_usr";
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "datachg_date";
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // FrmOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1005, 623);
            this.ControlBox = false;
            this.Controls.Add(this.dgvOperationlog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOperation";
            this.ShowIcon = true;
            this.Text = "员工操作日志";
            this.Load += new System.EventHandler(this.FrmOperation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperationlog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIDataGridView dgvOperationlog;
        private System.Windows.Forms.DataGridViewTextBoxColumn clOperationTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clOperationlog;
        private System.Windows.Forms.DataGridViewTextBoxColumn clOperationAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}