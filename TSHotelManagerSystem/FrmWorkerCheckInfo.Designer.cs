namespace TSHotelManagerSystem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWorkerCheckInfo));
            this.DgvCheckInfoList = new System.Windows.Forms.DataGridView();
            this.lblWorkerInfo = new System.Windows.Forms.Label();
            this.clWorkerNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCheckTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCheckWay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCheckState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCheckInfoList)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvCheckInfoList
            // 
            this.DgvCheckInfoList.AllowUserToAddRows = false;
            this.DgvCheckInfoList.AllowUserToDeleteRows = false;
            this.DgvCheckInfoList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvCheckInfoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCheckInfoList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clWorkerNo,
            this.clCheckTime,
            this.clCheckWay,
            this.clCheckState});
            this.DgvCheckInfoList.Location = new System.Drawing.Point(3, 58);
            this.DgvCheckInfoList.Name = "DgvCheckInfoList";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DgvCheckInfoList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvCheckInfoList.RowTemplate.Height = 23;
            this.DgvCheckInfoList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCheckInfoList.Size = new System.Drawing.Size(458, 150);
            this.DgvCheckInfoList.TabIndex = 0;
            // 
            // lblWorkerInfo
            // 
            this.lblWorkerInfo.AutoSize = true;
            this.lblWorkerInfo.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblWorkerInfo.Location = new System.Drawing.Point(-1, 34);
            this.lblWorkerInfo.Name = "lblWorkerInfo";
            this.lblWorkerInfo.Size = new System.Drawing.Size(45, 20);
            this.lblWorkerInfo.TabIndex = 1;
            this.lblWorkerInfo.Text = "label1";
            // 
            // clWorkerNo
            // 
            this.clWorkerNo.DataPropertyName = "WorkerNo";
            this.clWorkerNo.HeaderText = "员工编号";
            this.clWorkerNo.Name = "clWorkerNo";
            // 
            // clCheckTime
            // 
            this.clCheckTime.DataPropertyName = "CheckTime";
            this.clCheckTime.HeaderText = "打卡时间";
            this.clCheckTime.Name = "clCheckTime";
            // 
            // clCheckWay
            // 
            this.clCheckWay.DataPropertyName = "CheckWay";
            this.clCheckWay.HeaderText = "打卡方式";
            this.clCheckWay.Name = "clCheckWay";
            // 
            // clCheckState
            // 
            this.clCheckState.DataPropertyName = "CheckState";
            this.clCheckState.HeaderText = "打卡状态";
            this.clCheckState.Name = "clCheckState";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Location = new System.Drawing.Point(392, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(73, 25);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "关    闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(-1, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "员工打卡考勤记录查看页";
            // 
            // FrmWorkerCheckInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(466, 215);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblWorkerInfo);
            this.Controls.Add(this.DgvCheckInfoList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmWorkerCheckInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmWorkerCheckInfo";
            this.Load += new System.EventHandler(this.FrmWorkerCheckInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCheckInfoList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvCheckInfoList;
        private System.Windows.Forms.Label lblWorkerInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWorkerNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCheckTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCheckWay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCheckState;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
    }
}