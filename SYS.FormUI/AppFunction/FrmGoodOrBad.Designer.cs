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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGoodOrBad));
            this.DgvGoodBadList = new System.Windows.Forms.DataGridView();
            this.clWorkerNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGBInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGBType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGBOperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGBTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblWorkerNo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RtbGBInfo = new System.Windows.Forms.RichTextBox();
            this.CboType = new System.Windows.Forms.ComboBox();
            this.DtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGoodBadList)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvGoodBadList
            // 
            this.DgvGoodBadList.AllowUserToAddRows = false;
            this.DgvGoodBadList.AllowUserToDeleteRows = false;
            this.DgvGoodBadList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvGoodBadList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGoodBadList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clWorkerNo,
            this.clGBInfo,
            this.clGBType,
            this.clGBOperation,
            this.clGBTime});
            this.DgvGoodBadList.Location = new System.Drawing.Point(29, 350);
            this.DgvGoodBadList.MultiSelect = false;
            this.DgvGoodBadList.Name = "DgvGoodBadList";
            this.DgvGoodBadList.RowTemplate.Height = 23;
            this.DgvGoodBadList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvGoodBadList.Size = new System.Drawing.Size(489, 232);
            this.DgvGoodBadList.TabIndex = 0;
            // 
            // clWorkerNo
            // 
            this.clWorkerNo.DataPropertyName = "WorkNo";
            this.clWorkerNo.HeaderText = "员工编号";
            this.clWorkerNo.Name = "clWorkerNo";
            // 
            // clGBInfo
            // 
            this.clGBInfo.DataPropertyName = "GBInfo";
            this.clGBInfo.HeaderText = "奖罚情况";
            this.clGBInfo.Name = "clGBInfo";
            // 
            // clGBType
            // 
            this.clGBType.DataPropertyName = "TypeName";
            this.clGBType.HeaderText = "奖罚类型";
            this.clGBType.Name = "clGBType";
            // 
            // clGBOperation
            // 
            this.clGBOperation.DataPropertyName = "GBOperation";
            this.clGBOperation.HeaderText = "记录人";
            this.clGBOperation.Name = "clGBOperation";
            // 
            // clGBTime
            // 
            this.clGBTime.DataPropertyName = "GBTime";
            this.clGBTime.HeaderText = "奖罚日期";
            this.clGBTime.Name = "clGBTime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(49, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "员工编号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(196, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "员工姓名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(357, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "入职日期：";
            // 
            // lblWorkerNo
            // 
            this.lblWorkerNo.AutoSize = true;
            this.lblWorkerNo.BackColor = System.Drawing.Color.Transparent;
            this.lblWorkerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblWorkerNo.Location = new System.Drawing.Point(117, 74);
            this.lblWorkerNo.Name = "lblWorkerNo";
            this.lblWorkerNo.Size = new System.Drawing.Size(64, 17);
            this.lblWorkerNo.TabIndex = 4;
            this.lblWorkerNo.Text = "员工编号";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.Location = new System.Drawing.Point(268, 74);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 17);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "员工姓名";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDate.Location = new System.Drawing.Point(433, 74);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(64, 17);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "入职日期";
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::SYS.FormUI.Properties.Resources.button;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.Location = new System.Drawing.Point(437, 273);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 29);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(49, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "奖罚类型：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(49, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "奖罚时间：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(49, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "奖罚情况：";
            // 
            // RtbGBInfo
            // 
            this.RtbGBInfo.Location = new System.Drawing.Point(134, 189);
            this.RtbGBInfo.Name = "RtbGBInfo";
            this.RtbGBInfo.Size = new System.Drawing.Size(297, 152);
            this.RtbGBInfo.TabIndex = 11;
            this.RtbGBInfo.Text = "";
            // 
            // CboType
            // 
            this.CboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CboType.FormattingEnabled = true;
            this.CboType.Items.AddRange(new object[] {
            "奖励",
            "惩罚"});
            this.CboType.Location = new System.Drawing.Point(134, 106);
            this.CboType.Name = "CboType";
            this.CboType.Size = new System.Drawing.Size(121, 25);
            this.CboType.TabIndex = 12;
            // 
            // DtpDate
            // 
            this.DtpDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DtpDate.Location = new System.Drawing.Point(134, 148);
            this.DtpDate.Name = "DtpDate";
            this.DtpDate.Size = new System.Drawing.Size(121, 23);
            this.DtpDate.TabIndex = 13;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::SYS.FormUI.Properties.Resources.button;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Location = new System.Drawing.Point(437, 312);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(81, 29);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmGoodOrBad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(586, 631);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.DtpDate);
            this.Controls.Add(this.CboType);
            this.Controls.Add(this.RtbGBInfo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblWorkerNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DgvGoodBadList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGoodOrBad";
            this.ShowIcon = true;
            this.ShowRadius = false;
            this.ShowShadow = true;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "员工奖罚情况页";
            this.Load += new System.EventHandler(this.FrmGoodOrBad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvGoodBadList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvGoodBadList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWorkerNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWorkerNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGBInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGBType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGBOperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGBTime;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox RtbGBInfo;
        private System.Windows.Forms.ComboBox CboType;
        private System.Windows.Forms.DateTimePicker DtpDate;
        private System.Windows.Forms.Button btnClose;
    }
}