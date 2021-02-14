namespace SYS.FormUI
{
    partial class WtiInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WtiInfo));
            this.dgvWti = new System.Windows.Forms.DataGridView();
            this.clRoomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clWaterUse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPowerUse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRecord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCustoNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.txtRoomNo = new System.Windows.Forms.TextBox();
            this.lblUseDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpUseDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.picFend = new System.Windows.Forms.PictureBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.picDelete = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picUpdate = new System.Windows.Forms.PictureBox();
            this.txtCustoNo = new System.Windows.Forms.TextBox();
            this.lblRecord = new System.Windows.Forms.Label();
            this.txtRecord = new System.Windows.Forms.TextBox();
            this.lblPowerUse = new System.Windows.Forms.Label();
            this.txtPowerUse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWaterUse = new System.Windows.Forms.TextBox();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWti)).BeginInit();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWti
            // 
            this.dgvWti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWti.BackgroundColor = System.Drawing.Color.White;
            this.dgvWti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clRoomNo,
            this.clUseDate,
            this.clEndDate,
            this.clWaterUse,
            this.clPowerUse,
            this.clRecord,
            this.clCustoNo});
            this.dgvWti.Location = new System.Drawing.Point(12, 12);
            this.dgvWti.Name = "dgvWti";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvWti.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWti.RowTemplate.Height = 23;
            this.dgvWti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWti.Size = new System.Drawing.Size(965, 262);
            this.dgvWti.TabIndex = 0;
            this.dgvWti.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvWti_CellMouseClick);
            // 
            // clRoomNo
            // 
            this.clRoomNo.DataPropertyName = "RoomNo";
            this.clRoomNo.HeaderText = "房号";
            this.clRoomNo.Name = "clRoomNo";
            // 
            // clUseDate
            // 
            this.clUseDate.DataPropertyName = "UseDate";
            this.clUseDate.HeaderText = "开始使用时间";
            this.clUseDate.Name = "clUseDate";
            // 
            // clEndDate
            // 
            this.clEndDate.DataPropertyName = "EndDate";
            this.clEndDate.HeaderText = "结束使用时间";
            this.clEndDate.Name = "clEndDate";
            // 
            // clWaterUse
            // 
            this.clWaterUse.DataPropertyName = "WaterUse";
            this.clWaterUse.HeaderText = "水费";
            this.clWaterUse.Name = "clWaterUse";
            // 
            // clPowerUse
            // 
            this.clPowerUse.DataPropertyName = "PowerUse";
            this.clPowerUse.HeaderText = "电费";
            this.clPowerUse.Name = "clPowerUse";
            // 
            // clRecord
            // 
            this.clRecord.DataPropertyName = "Record";
            this.clRecord.HeaderText = "记录员";
            this.clRecord.Name = "clRecord";
            // 
            // clCustoNo
            // 
            this.clCustoNo.DataPropertyName = "CustoNo";
            this.clCustoNo.HeaderText = "客户编号";
            this.clCustoNo.Name = "clCustoNo";
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.AutoSize = true;
            this.lblRoomNo.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRoomNo.Location = new System.Drawing.Point(24, 37);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(32, 17);
            this.lblRoomNo.TabIndex = 51;
            this.lblRoomNo.Text = "房号";
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRoomNo.Location = new System.Drawing.Point(59, 34);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Size = new System.Drawing.Size(100, 24);
            this.txtRoomNo.TabIndex = 52;
            // 
            // lblUseDate
            // 
            this.lblUseDate.AutoSize = true;
            this.lblUseDate.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUseDate.Location = new System.Drawing.Point(480, 37);
            this.lblUseDate.Name = "lblUseDate";
            this.lblUseDate.Size = new System.Drawing.Size(80, 17);
            this.lblUseDate.TabIndex = 53;
            this.lblUseDate.Text = "开始使用时间";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(480, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 54;
            this.label1.Text = "结束使用时间";
            // 
            // dtpUseDate
            // 
            this.dtpUseDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpUseDate.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpUseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpUseDate.Location = new System.Drawing.Point(563, 31);
            this.dtpUseDate.Name = "dtpUseDate";
            this.dtpUseDate.Size = new System.Drawing.Size(156, 24);
            this.dtpUseDate.TabIndex = 55;
            this.dtpUseDate.Value = new System.DateTime(2018, 12, 4, 10, 32, 40, 0);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpEndDate.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(563, 71);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(156, 24);
            this.dtpEndDate.TabIndex = 56;
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.picFend);
            this.gbInfo.Controls.Add(this.btnOk);
            this.gbInfo.Controls.Add(this.picDelete);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Controls.Add(this.picUpdate);
            this.gbInfo.Controls.Add(this.txtCustoNo);
            this.gbInfo.Controls.Add(this.lblRecord);
            this.gbInfo.Controls.Add(this.txtRecord);
            this.gbInfo.Controls.Add(this.lblPowerUse);
            this.gbInfo.Controls.Add(this.txtPowerUse);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Controls.Add(this.txtWaterUse);
            this.gbInfo.Controls.Add(this.dtpEndDate);
            this.gbInfo.Controls.Add(this.lblRoomNo);
            this.gbInfo.Controls.Add(this.dtpUseDate);
            this.gbInfo.Controls.Add(this.label1);
            this.gbInfo.Controls.Add(this.lblUseDate);
            this.gbInfo.Controls.Add(this.txtRoomNo);
            this.gbInfo.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbInfo.Location = new System.Drawing.Point(12, 280);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(965, 205);
            this.gbInfo.TabIndex = 57;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "基本信息";
            // 
            // picFend
            // 
            this.picFend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picFend.BackgroundImage")));
            this.picFend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFend.Location = new System.Drawing.Point(527, 136);
            this.picFend.Name = "picFend";
            this.picFend.Size = new System.Drawing.Size(49, 46);
            this.picFend.TabIndex = 61;
            this.picFend.TabStop = false;
            this.picFend.Click += new System.EventHandler(this.picFend_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.SkyBlue;
            this.btnOk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOk.BackgroundImage")));
            this.btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOk.Location = new System.Drawing.Point(801, 72);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 65;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // picDelete
            // 
            this.picDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picDelete.BackgroundImage")));
            this.picDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picDelete.Location = new System.Drawing.Point(457, 136);
            this.picDelete.Name = "picDelete";
            this.picDelete.Size = new System.Drawing.Size(49, 46);
            this.picDelete.TabIndex = 60;
            this.picDelete.TabStop = false;
            this.picDelete.Click += new System.EventHandler(this.picDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(243, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 63;
            this.label3.Text = "客户编号";
            // 
            // picUpdate
            // 
            this.picUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picUpdate.BackgroundImage")));
            this.picUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picUpdate.Location = new System.Drawing.Point(388, 136);
            this.picUpdate.Name = "picUpdate";
            this.picUpdate.Size = new System.Drawing.Size(49, 46);
            this.picUpdate.TabIndex = 59;
            this.picUpdate.TabStop = false;
            this.picUpdate.Click += new System.EventHandler(this.picUpdate_Click);
            // 
            // txtCustoNo
            // 
            this.txtCustoNo.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCustoNo.Location = new System.Drawing.Point(302, 34);
            this.txtCustoNo.Name = "txtCustoNo";
            this.txtCustoNo.Size = new System.Drawing.Size(100, 24);
            this.txtCustoNo.TabIndex = 64;
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRecord.Location = new System.Drawing.Point(793, 37);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(44, 17);
            this.lblRecord.TabIndex = 61;
            this.lblRecord.Text = "记录员";
            // 
            // txtRecord
            // 
            this.txtRecord.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRecord.Location = new System.Drawing.Point(840, 34);
            this.txtRecord.Name = "txtRecord";
            this.txtRecord.Size = new System.Drawing.Size(100, 24);
            this.txtRecord.TabIndex = 62;
            // 
            // lblPowerUse
            // 
            this.lblPowerUse.AutoSize = true;
            this.lblPowerUse.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPowerUse.Location = new System.Drawing.Point(267, 77);
            this.lblPowerUse.Name = "lblPowerUse";
            this.lblPowerUse.Size = new System.Drawing.Size(32, 17);
            this.lblPowerUse.TabIndex = 59;
            this.lblPowerUse.Text = "电费";
            // 
            // txtPowerUse
            // 
            this.txtPowerUse.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPowerUse.Location = new System.Drawing.Point(302, 74);
            this.txtPowerUse.Name = "txtPowerUse";
            this.txtPowerUse.Size = new System.Drawing.Size(100, 24);
            this.txtPowerUse.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(24, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 57;
            this.label2.Text = "水费";
            // 
            // txtWaterUse
            // 
            this.txtWaterUse.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtWaterUse.Location = new System.Drawing.Point(59, 74);
            this.txtWaterUse.Name = "txtWaterUse";
            this.txtWaterUse.Size = new System.Drawing.Size(100, 24);
            this.txtWaterUse.TabIndex = 58;
            // 
            // WtiInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(989, 497);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.dgvWti);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WtiInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WtiInfo";
            this.Load += new System.EventHandler(this.WtiInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWti)).EndInit();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWti;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRoomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWaterUse;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPowerUse;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCustoNo;
        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.Label lblUseDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpUseDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustoNo;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.TextBox txtRecord;
        private System.Windows.Forms.Label lblPowerUse;
        private System.Windows.Forms.TextBox txtPowerUse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWaterUse;
        private System.Windows.Forms.PictureBox picUpdate;
        private System.Windows.Forms.PictureBox picDelete;
        private System.Windows.Forms.PictureBox picFend;
        private System.Windows.Forms.ToolTip ToolTip1;
        private System.Windows.Forms.Button btnOk;
    }
}