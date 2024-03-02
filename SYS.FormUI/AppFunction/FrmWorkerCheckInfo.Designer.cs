namespace SYS.FormUI
{
    partial class FrmWorkerCheckInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWorkerCheckInfo));
            this.lblWorkerInfo = new System.Windows.Forms.Label();
            this.DgvCheckInfoList = new Sunny.UI.UIDataGridView();
            this.clWorkerNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCheckTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCheckWay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCheckState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCheckInfoList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWorkerInfo
            // 
            this.lblWorkerInfo.AutoSize = true;
            this.lblWorkerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkerInfo.Location = new System.Drawing.Point(12, 50);
            this.lblWorkerInfo.Name = "lblWorkerInfo";
            this.lblWorkerInfo.Size = new System.Drawing.Size(60, 24);
            this.lblWorkerInfo.TabIndex = 1;
            this.lblWorkerInfo.Text = "label1";
            // 
            // DgvCheckInfoList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.DgvCheckInfoList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvCheckInfoList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvCheckInfoList.BackgroundColor = System.Drawing.Color.White;
            this.DgvCheckInfoList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCheckInfoList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvCheckInfoList.ColumnHeadersHeight = 32;
            this.DgvCheckInfoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvCheckInfoList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clWorkerNo,
            this.clCheckTime,
            this.clCheckWay,
            this.clCheckState,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvCheckInfoList.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvCheckInfoList.EnableHeadersVisualStyles = false;
            this.DgvCheckInfoList.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.DgvCheckInfoList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.DgvCheckInfoList.Location = new System.Drawing.Point(3, 88);
            this.DgvCheckInfoList.Name = "DgvCheckInfoList";
            this.DgvCheckInfoList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCheckInfoList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvCheckInfoList.RowHeadersVisible = false;
            this.DgvCheckInfoList.RowHeight = 29;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.DgvCheckInfoList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvCheckInfoList.RowTemplate.Height = 29;
            this.DgvCheckInfoList.SelectedIndex = -1;
            this.DgvCheckInfoList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCheckInfoList.ShowGridLine = true;
            this.DgvCheckInfoList.Size = new System.Drawing.Size(550, 154);
            this.DgvCheckInfoList.TabIndex = 2;
            // 
            // clWorkerNo
            // 
            this.clWorkerNo.DataPropertyName = "WorkerNo";
            this.clWorkerNo.HeaderText = "员工编号";
            this.clWorkerNo.Name = "clWorkerNo";
            this.clWorkerNo.ReadOnly = true;
            // 
            // clCheckTime
            // 
            this.clCheckTime.DataPropertyName = "CheckTime";
            this.clCheckTime.HeaderText = "打卡时间";
            this.clCheckTime.Name = "clCheckTime";
            this.clCheckTime.ReadOnly = true;
            // 
            // clCheckWay
            // 
            this.clCheckWay.DataPropertyName = "CheckWay";
            this.clCheckWay.HeaderText = "打卡方式";
            this.clCheckWay.Name = "clCheckWay";
            this.clCheckWay.ReadOnly = true;
            // 
            // clCheckState
            // 
            this.clCheckState.DataPropertyName = "CheckStateNm";
            this.clCheckState.HeaderText = "打卡状态";
            this.clCheckState.Name = "clCheckState";
            this.clCheckState.ReadOnly = true;
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
            this.Column2.DataPropertyName = "datains_date";
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "datains_usr";
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
            // Column6
            // 
            this.Column6.DataPropertyName = "CheckState";
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // FrmWorkerCheckInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(556, 247);
            this.Controls.Add(this.DgvCheckInfoList);
            this.Controls.Add(this.lblWorkerInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsForbidAltF4 = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmWorkerCheckInfo";
            this.ShowIcon = true;
            this.ShowTitleIcon = true;
            this.Text = "员工打卡考勤记录查看页";
            this.Load += new System.EventHandler(this.FrmWorkerCheckInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCheckInfoList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblWorkerInfo;
        private Sunny.UI.UIDataGridView DgvCheckInfoList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWorkerNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCheckTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCheckWay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCheckState;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}