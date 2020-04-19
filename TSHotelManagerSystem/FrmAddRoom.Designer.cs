namespace TSHotelManagerSystem
{
    partial class FrmAddRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddRoom));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtRoomPosition = new System.Windows.Forms.TextBox();
            this.txtPersonNum = new System.Windows.Forms.TextBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.cboRoomType = new System.Windows.Forms.ComboBox();
            this.txtRoomNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.dgvRoomList = new System.Windows.Forms.DataGridView();
            this.clRoomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCustoNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCheckTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCheckOutTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRoomStateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRoomMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPersonNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRoomPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRoomPosition
            // 
            this.txtRoomPosition.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRoomPosition.ForeColor = System.Drawing.Color.Black;
            this.txtRoomPosition.Location = new System.Drawing.Point(846, 206);
            this.txtRoomPosition.Name = "txtRoomPosition";
            this.txtRoomPosition.ReadOnly = true;
            this.txtRoomPosition.Size = new System.Drawing.Size(105, 24);
            this.txtRoomPosition.TabIndex = 71;
            // 
            // txtPersonNum
            // 
            this.txtPersonNum.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPersonNum.ForeColor = System.Drawing.Color.Black;
            this.txtPersonNum.Location = new System.Drawing.Point(846, 241);
            this.txtPersonNum.Name = "txtPersonNum";
            this.txtPersonNum.ReadOnly = true;
            this.txtPersonNum.Size = new System.Drawing.Size(105, 24);
            this.txtPersonNum.TabIndex = 70;
            // 
            // txtMoney
            // 
            this.txtMoney.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMoney.ForeColor = System.Drawing.Color.Black;
            this.txtMoney.Location = new System.Drawing.Point(846, 276);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.ReadOnly = true;
            this.txtMoney.Size = new System.Drawing.Size(105, 24);
            this.txtMoney.TabIndex = 69;
            // 
            // cboState
            // 
            this.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboState.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboState.ForeColor = System.Drawing.Color.Black;
            this.cboState.FormattingEnabled = true;
            this.cboState.Items.AddRange(new object[] {
            "空房",
            "维修中"});
            this.cboState.Location = new System.Drawing.Point(846, 170);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(105, 25);
            this.cboState.TabIndex = 68;
            // 
            // cboRoomType
            // 
            this.cboRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomType.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboRoomType.ForeColor = System.Drawing.Color.Black;
            this.cboRoomType.FormattingEnabled = true;
            this.cboRoomType.Location = new System.Drawing.Point(846, 134);
            this.cboRoomType.Name = "cboRoomType";
            this.cboRoomType.Size = new System.Drawing.Size(105, 25);
            this.cboRoomType.TabIndex = 66;
            this.cboRoomType.TextChanged += new System.EventHandler(this.cboRoomType_TextChanged);
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRoomNo.ForeColor = System.Drawing.Color.Black;
            this.txtRoomNo.Location = new System.Drawing.Point(846, 99);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.ReadOnly = true;
            this.txtRoomNo.Size = new System.Drawing.Size(105, 24);
            this.txtRoomNo.TabIndex = 65;
            this.txtRoomNo.TextChanged += new System.EventHandler(this.txtRoomNo_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(787, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 64;
            this.label8.Text = "房间位置";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(787, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 63;
            this.label7.Text = "房间人数";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(787, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 62;
            this.label6.Text = "房间单价";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(787, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 61;
            this.label5.Text = "房间状态";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(787, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 59;
            this.label2.Text = "房间类型";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(787, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 58;
            this.label1.Text = "房      号";
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackColor = System.Drawing.Color.LightCyan;
            this.btnAddRoom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddRoom.BackgroundImage")));
            this.btnAddRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddRoom.FlatAppearance.BorderSize = 0;
            this.btnAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRoom.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddRoom.Location = new System.Drawing.Point(833, 373);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(94, 23);
            this.btnAddRoom.TabIndex = 72;
            this.btnAddRoom.Text = "新增客房";
            this.btnAddRoom.UseVisualStyleBackColor = false;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // dgvRoomList
            // 
            this.dgvRoomList.AllowUserToAddRows = false;
            this.dgvRoomList.AllowUserToDeleteRows = false;
            this.dgvRoomList.AllowUserToResizeColumns = false;
            this.dgvRoomList.AllowUserToResizeRows = false;
            this.dgvRoomList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoomList.BackgroundColor = System.Drawing.Color.White;
            this.dgvRoomList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRoomList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvRoomList.ColumnHeadersHeight = 30;
            this.dgvRoomList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRoomList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clRoomNo,
            this.clRoomType,
            this.clCustoNo,
            this.clCheckTime,
            this.clCheckOutTime,
            this.clRoomStateId,
            this.clRoomMoney,
            this.clPersonNum,
            this.clRoomPosition});
            this.dgvRoomList.Location = new System.Drawing.Point(12, 11);
            this.dgvRoomList.MultiSelect = false;
            this.dgvRoomList.Name = "dgvRoomList";
            this.dgvRoomList.ReadOnly = true;
            this.dgvRoomList.RowHeadersWidth = 55;
            this.dgvRoomList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvRoomList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRoomList.RowTemplate.Height = 23;
            this.dgvRoomList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoomList.Size = new System.Drawing.Size(759, 471);
            this.dgvRoomList.TabIndex = 73;
            // 
            // clRoomNo
            // 
            this.clRoomNo.DataPropertyName = "RoomNo";
            this.clRoomNo.HeaderText = "房号";
            this.clRoomNo.Name = "clRoomNo";
            this.clRoomNo.ReadOnly = true;
            // 
            // clRoomType
            // 
            this.clRoomType.DataPropertyName = "typeName";
            this.clRoomType.HeaderText = "房间类型";
            this.clRoomType.Name = "clRoomType";
            this.clRoomType.ReadOnly = true;
            // 
            // clCustoNo
            // 
            this.clCustoNo.DataPropertyName = "CustoNo";
            this.clCustoNo.HeaderText = "客户编号";
            this.clCustoNo.Name = "clCustoNo";
            this.clCustoNo.ReadOnly = true;
            // 
            // clCheckTime
            // 
            this.clCheckTime.DataPropertyName = "CheckTime";
            this.clCheckTime.HeaderText = "入住时间";
            this.clCheckTime.Name = "clCheckTime";
            this.clCheckTime.ReadOnly = true;
            // 
            // clCheckOutTime
            // 
            this.clCheckOutTime.DataPropertyName = "CheckOutTime";
            this.clCheckOutTime.HeaderText = "退房时间";
            this.clCheckOutTime.Name = "clCheckOutTime";
            this.clCheckOutTime.ReadOnly = true;
            // 
            // clRoomStateId
            // 
            this.clRoomStateId.DataPropertyName = "RoomState";
            this.clRoomStateId.HeaderText = "房间状态";
            this.clRoomStateId.Name = "clRoomStateId";
            this.clRoomStateId.ReadOnly = true;
            // 
            // clRoomMoney
            // 
            this.clRoomMoney.DataPropertyName = "RoomMoney";
            this.clRoomMoney.HeaderText = "单价/天";
            this.clRoomMoney.Name = "clRoomMoney";
            this.clRoomMoney.ReadOnly = true;
            // 
            // clPersonNum
            // 
            this.clPersonNum.DataPropertyName = "PersonNum";
            this.clPersonNum.HeaderText = "房间人数";
            this.clPersonNum.Name = "clPersonNum";
            this.clPersonNum.ReadOnly = true;
            // 
            // clRoomPosition
            // 
            this.clRoomPosition.DataPropertyName = "RoomPosition";
            this.clRoomPosition.HeaderText = "房间区域";
            this.clRoomPosition.Name = "clRoomPosition";
            this.clRoomPosition.ReadOnly = true;
            // 
            // FrmAddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(989, 495);
            this.Controls.Add(this.dgvRoomList);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.txtRoomPosition);
            this.Controls.Add(this.txtPersonNum);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.cboState);
            this.Controls.Add(this.cboRoomType);
            this.Controls.Add(this.txtRoomNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新增客房";
            this.Load += new System.EventHandler(this.FrmAddRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRoomPosition;
        private System.Windows.Forms.TextBox txtPersonNum;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.ComboBox cboRoomType;
        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.DataGridView dgvRoomList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRoomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCustoNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCheckTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCheckOutTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRoomStateId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRoomMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPersonNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRoomPosition;
    }
}