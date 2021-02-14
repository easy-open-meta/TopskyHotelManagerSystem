namespace SYS.FormUI
{
    partial class FrmWtiInfo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWtiInfo));
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dgvWti = new Sunny.UI.UIDataGridView();
            this.clWtiNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRoomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clWaterUse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPowerUse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRecord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCustoNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWti
            // 
            this.dgvWti.AllowUserToAddRows = false;
            this.dgvWti.AllowUserToDeleteRows = false;
            this.dgvWti.AllowUserToResizeColumns = false;
            this.dgvWti.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvWti.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWti.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvWti.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvWti.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvWti.ColumnHeadersHeight = 32;
            this.dgvWti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvWti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clWtiNo,
            this.clRoomNo,
            this.clUseDate,
            this.clEndDate,
            this.clWaterUse,
            this.clPowerUse,
            this.clRecord,
            this.clCustoNo,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWti.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvWti.EnableHeadersVisualStyles = false;
            this.dgvWti.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgvWti.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvWti.Location = new System.Drawing.Point(12, 48);
            this.dgvWti.MultiSelect = false;
            this.dgvWti.Name = "dgvWti";
            this.dgvWti.ReadOnly = true;
            this.dgvWti.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvWti.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvWti.RowTemplate.Height = 29;
            this.dgvWti.SelectedIndex = -1;
            this.dgvWti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWti.Size = new System.Drawing.Size(981, 563);
            this.dgvWti.Style = Sunny.UI.UIStyle.Custom;
            this.dgvWti.TabIndex = 58;
            // 
            // clWtiNo
            // 
            this.clWtiNo.DataPropertyName = "WtiNo";
            this.clWtiNo.HeaderText = "记录编号";
            this.clWtiNo.Name = "clWtiNo";
            this.clWtiNo.ReadOnly = true;
            // 
            // clRoomNo
            // 
            this.clRoomNo.DataPropertyName = "RoomNo";
            this.clRoomNo.HeaderText = "房号";
            this.clRoomNo.Name = "clRoomNo";
            this.clRoomNo.ReadOnly = true;
            // 
            // clUseDate
            // 
            this.clUseDate.DataPropertyName = "UseDate";
            this.clUseDate.HeaderText = "开始使用时间";
            this.clUseDate.Name = "clUseDate";
            this.clUseDate.ReadOnly = true;
            // 
            // clEndDate
            // 
            this.clEndDate.DataPropertyName = "EndDate";
            this.clEndDate.HeaderText = "结束使用时间";
            this.clEndDate.Name = "clEndDate";
            this.clEndDate.ReadOnly = true;
            // 
            // clWaterUse
            // 
            this.clWaterUse.DataPropertyName = "WaterUse";
            this.clWaterUse.HeaderText = "水费";
            this.clWaterUse.Name = "clWaterUse";
            this.clWaterUse.ReadOnly = true;
            // 
            // clPowerUse
            // 
            this.clPowerUse.DataPropertyName = "PowerUse";
            this.clPowerUse.HeaderText = "电费";
            this.clPowerUse.Name = "clPowerUse";
            this.clPowerUse.ReadOnly = true;
            // 
            // clRecord
            // 
            this.clRecord.DataPropertyName = "Record";
            this.clRecord.HeaderText = "记录员";
            this.clRecord.Name = "clRecord";
            this.clRecord.ReadOnly = true;
            // 
            // clCustoNo
            // 
            this.clCustoNo.DataPropertyName = "CustoNo";
            this.clCustoNo.HeaderText = "客户编号";
            this.clCustoNo.Name = "clCustoNo";
            this.clCustoNo.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "delete_mk";
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "datains_usr";
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "datains_date";
            this.Column9.HeaderText = "Column9";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "datachg_usr";
            this.Column10.HeaderText = "Column10";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "datachg_date";
            this.Column11.HeaderText = "Column11";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Visible = false;
            // 
            // FrmWtiInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1005, 623);
            this.ControlBox = false;
            this.Controls.Add(this.dgvWti);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmWtiInfo";
            this.ShowIcon = true;
            this.ShowInTaskbar = false;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "水电信息";
            this.Load += new System.EventHandler(this.WtiInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip ToolTip1;
        private Sunny.UI.UIDataGridView dgvWti;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWtiNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRoomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWaterUse;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPowerUse;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCustoNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
    }
}