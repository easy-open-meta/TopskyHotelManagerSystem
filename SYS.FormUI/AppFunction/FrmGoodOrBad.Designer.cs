namespace SYS.FormUI
{
    partial class FrmGoodOrBad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGoodOrBad));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblWorkerNo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CboType = new Sunny.UI.UIComboBox();
            this.DtpDate = new Sunny.UI.UIDatePicker();
            this.RtbGBInfo = new Sunny.UI.UIRichTextBox();
            this.DgvGoodBadList = new Sunny.UI.UIDataGridView();
            this.clWorkNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGBType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGBInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGBOperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGBTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new Sunny.UI.UIButton();
            this.btnClose = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGoodBadList)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "员工编号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "员工姓名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(402, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "入职日期：";
            // 
            // lblWorkerNo
            // 
            this.lblWorkerNo.AutoSize = true;
            this.lblWorkerNo.BackColor = System.Drawing.Color.Transparent;
            this.lblWorkerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkerNo.Location = new System.Drawing.Point(119, 52);
            this.lblWorkerNo.Name = "lblWorkerNo";
            this.lblWorkerNo.Size = new System.Drawing.Size(86, 24);
            this.lblWorkerNo.TabIndex = 4;
            this.lblWorkerNo.Text = "员工编号";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(314, 52);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(86, 24);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "员工姓名";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(509, 52);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(86, 24);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "入职日期";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "奖罚类型：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "奖罚时间：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "奖罚情况：";
            // 
            // CboType
            // 
            this.CboType.DataSource = null;
            this.CboType.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.CboType.FillColor = System.Drawing.Color.White;
            this.CboType.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.CboType.Location = new System.Drawing.Point(141, 104);
            this.CboType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CboType.MinimumSize = new System.Drawing.Size(63, 0);
            this.CboType.Name = "CboType";
            this.CboType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.CboType.Radius = 20;
            this.CboType.Size = new System.Drawing.Size(158, 35);
            this.CboType.Style = Sunny.UI.UIStyle.Custom;
            this.CboType.TabIndex = 107;
            this.CboType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DtpDate
            // 
            this.DtpDate.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.DtpDate.FillColor = System.Drawing.Color.White;
            this.DtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.DtpDate.Location = new System.Drawing.Point(141, 152);
            this.DtpDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtpDate.MaxLength = 10;
            this.DtpDate.MinimumSize = new System.Drawing.Size(63, 0);
            this.DtpDate.Name = "DtpDate";
            this.DtpDate.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.DtpDate.Radius = 20;
            this.DtpDate.ReadOnly = true;
            this.DtpDate.Size = new System.Drawing.Size(158, 31);
            this.DtpDate.Style = Sunny.UI.UIStyle.Custom;
            this.DtpDate.SymbolDropDown = 61555;
            this.DtpDate.SymbolNormal = 61555;
            this.DtpDate.TabIndex = 108;
            this.DtpDate.Text = "2020-11-24";
            this.DtpDate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.DtpDate.Value = new System.DateTime(2020, 11, 24, 22, 50, 36, 791);
            // 
            // RtbGBInfo
            // 
            this.RtbGBInfo.AutoWordSelection = true;
            this.RtbGBInfo.FillColor = System.Drawing.Color.White;
            this.RtbGBInfo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.RtbGBInfo.Location = new System.Drawing.Point(141, 196);
            this.RtbGBInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RtbGBInfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.RtbGBInfo.Name = "RtbGBInfo";
            this.RtbGBInfo.Padding = new System.Windows.Forms.Padding(2);
            this.RtbGBInfo.Radius = 20;
            this.RtbGBInfo.Size = new System.Drawing.Size(486, 148);
            this.RtbGBInfo.Style = Sunny.UI.UIStyle.Custom;
            this.RtbGBInfo.TabIndex = 109;
            this.RtbGBInfo.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.RtbGBInfo.WordWrap = true;
            // 
            // DgvGoodBadList
            // 
            this.DgvGoodBadList.AllowUserToAddRows = false;
            this.DgvGoodBadList.AllowUserToDeleteRows = false;
            this.DgvGoodBadList.AllowUserToResizeColumns = false;
            this.DgvGoodBadList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.DgvGoodBadList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvGoodBadList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvGoodBadList.BackgroundColor = System.Drawing.Color.White;
            this.DgvGoodBadList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvGoodBadList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvGoodBadList.ColumnHeadersHeight = 32;
            this.DgvGoodBadList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvGoodBadList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clWorkNo,
            this.clGBType,
            this.clGBInfo,
            this.clGBOperation,
            this.clGBTime,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvGoodBadList.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvGoodBadList.EnableHeadersVisualStyles = false;
            this.DgvGoodBadList.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.DgvGoodBadList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.DgvGoodBadList.Location = new System.Drawing.Point(34, 390);
            this.DgvGoodBadList.MultiSelect = false;
            this.DgvGoodBadList.Name = "DgvGoodBadList";
            this.DgvGoodBadList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvGoodBadList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvGoodBadList.RowHeadersVisible = false;
            this.DgvGoodBadList.RowHeight = 29;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.DgvGoodBadList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvGoodBadList.RowTemplate.Height = 29;
            this.DgvGoodBadList.SelectedIndex = -1;
            this.DgvGoodBadList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvGoodBadList.ShowGridLine = true;
            this.DgvGoodBadList.Size = new System.Drawing.Size(593, 199);
            this.DgvGoodBadList.Style = Sunny.UI.UIStyle.Custom;
            this.DgvGoodBadList.TabIndex = 3;
            // 
            // clWorkNo
            // 
            this.clWorkNo.DataPropertyName = "WorkNo";
            this.clWorkNo.HeaderText = "员工编号";
            this.clWorkNo.Name = "clWorkNo";
            this.clWorkNo.ReadOnly = true;
            // 
            // clGBType
            // 
            this.clGBType.DataPropertyName = "TypeName";
            this.clGBType.HeaderText = "奖罚类型";
            this.clGBType.Name = "clGBType";
            this.clGBType.ReadOnly = true;
            // 
            // clGBInfo
            // 
            this.clGBInfo.DataPropertyName = "GBInfo";
            this.clGBInfo.HeaderText = "奖惩信息";
            this.clGBInfo.Name = "clGBInfo";
            this.clGBInfo.ReadOnly = true;
            // 
            // clGBOperation
            // 
            this.clGBOperation.DataPropertyName = "OperationName";
            this.clGBOperation.HeaderText = "奖惩操作人";
            this.clGBOperation.Name = "clGBOperation";
            this.clGBOperation.ReadOnly = true;
            // 
            // clGBTime
            // 
            this.clGBTime.DataPropertyName = "GBTime";
            this.clGBTime.HeaderText = "奖惩时间";
            this.clGBTime.Name = "clGBTime";
            this.clGBTime.ReadOnly = true;
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
            this.Column6.DataPropertyName = "GBType";
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "GBOperation";
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 110;
            this.label1.Text = "历史奖罚情况：";
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnAdd.Location = new System.Drawing.Point(421, 599);
            this.btnAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Radius = 20;
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.Style = Sunny.UI.UIStyle.Custom;
            this.btnAdd.TabIndex = 111;
            this.btnAdd.Text = "新     增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnClose.Location = new System.Drawing.Point(527, 599);
            this.btnClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Radius = 20;
            this.btnClose.Size = new System.Drawing.Size(100, 35);
            this.btnClose.Style = Sunny.UI.UIStyle.Custom;
            this.btnClose.TabIndex = 112;
            this.btnClose.Text = "关     闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmGoodOrBad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(657, 646);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvGoodBadList);
            this.Controls.Add(this.RtbGBInfo);
            this.Controls.Add(this.DtpDate);
            this.Controls.Add(this.CboType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblWorkerNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGoodOrBad";
            this.ShowIcon = true;
            this.ShowRadius = false;
            this.ShowShadow = true;
            this.ShowTitleIcon = true;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "员工奖罚情况页";
            this.Load += new System.EventHandler(this.FrmGoodOrBad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvGoodBadList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWorkerNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Sunny.UI.UIComboBox CboType;
        private Sunny.UI.UIDatePicker DtpDate;
        private Sunny.UI.UIRichTextBox RtbGBInfo;
        private Sunny.UI.UIDataGridView DgvGoodBadList;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UIButton btnAdd;
        private Sunny.UI.UIButton btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWorkNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGBType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGBInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGBOperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGBTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}