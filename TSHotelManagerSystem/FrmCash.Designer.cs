namespace TSHotelManagerSystem
{
    partial class FrmCash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCash));
            this.dgvCashList = new System.Windows.Forms.DataGridView();
            this.clCashNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCashName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCashPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCashClub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCashTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCashSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCashPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbInfoWrite = new System.Windows.Forms.GroupBox();
            this.cboClub = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCashMoney = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCashName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCashNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashList)).BeginInit();
            this.gbInfoWrite.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCashList
            // 
            this.dgvCashList.AllowUserToAddRows = false;
            this.dgvCashList.AllowUserToDeleteRows = false;
            this.dgvCashList.AllowUserToResizeColumns = false;
            this.dgvCashList.AllowUserToResizeRows = false;
            this.dgvCashList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCashList.BackgroundColor = System.Drawing.Color.White;
            this.dgvCashList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCashList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCashNo,
            this.clCashName,
            this.clCashPrice,
            this.clCashClub,
            this.clCashTime,
            this.clCashSource,
            this.clCashPerson});
            this.dgvCashList.Location = new System.Drawing.Point(5, 5);
            this.dgvCashList.Name = "dgvCashList";
            this.dgvCashList.ReadOnly = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvCashList.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCashList.RowTemplate.Height = 23;
            this.dgvCashList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCashList.Size = new System.Drawing.Size(800, 485);
            this.dgvCashList.TabIndex = 0;
            // 
            // clCashNo
            // 
            this.clCashNo.DataPropertyName = "CashNo";
            this.clCashNo.HeaderText = "资产编号";
            this.clCashNo.Name = "clCashNo";
            this.clCashNo.ReadOnly = true;
            // 
            // clCashName
            // 
            this.clCashName.DataPropertyName = "CashName";
            this.clCashName.HeaderText = "资产名称";
            this.clCashName.Name = "clCashName";
            this.clCashName.ReadOnly = true;
            // 
            // clCashPrice
            // 
            this.clCashPrice.DataPropertyName = "CashPrice";
            this.clCashPrice.HeaderText = "资产价值";
            this.clCashPrice.Name = "clCashPrice";
            this.clCashPrice.ReadOnly = true;
            // 
            // clCashClub
            // 
            this.clCashClub.DataPropertyName = "CashClub";
            this.clCashClub.HeaderText = "所属部门";
            this.clCashClub.Name = "clCashClub";
            this.clCashClub.ReadOnly = true;
            // 
            // clCashTime
            // 
            this.clCashTime.DataPropertyName = "CashTime";
            this.clCashTime.HeaderText = "资产入库时间";
            this.clCashTime.Name = "clCashTime";
            this.clCashTime.ReadOnly = true;
            // 
            // clCashSource
            // 
            this.clCashSource.DataPropertyName = "CashSource";
            this.clCashSource.HeaderText = "资产来源";
            this.clCashSource.Name = "clCashSource";
            this.clCashSource.ReadOnly = true;
            // 
            // clCashPerson
            // 
            this.clCashPerson.DataPropertyName = "CashPerson";
            this.clCashPerson.HeaderText = "资产经办人";
            this.clCashPerson.Name = "clCashPerson";
            this.clCashPerson.ReadOnly = true;
            // 
            // gbInfoWrite
            // 
            this.gbInfoWrite.BackColor = System.Drawing.Color.Transparent;
            this.gbInfoWrite.Controls.Add(this.cboClub);
            this.gbInfoWrite.Controls.Add(this.btnOK);
            this.gbInfoWrite.Controls.Add(this.dtpDate);
            this.gbInfoWrite.Controls.Add(this.txtFrom);
            this.gbInfoWrite.Controls.Add(this.label6);
            this.gbInfoWrite.Controls.Add(this.label5);
            this.gbInfoWrite.Controls.Add(this.label4);
            this.gbInfoWrite.Controls.Add(this.txtCashMoney);
            this.gbInfoWrite.Controls.Add(this.label3);
            this.gbInfoWrite.Controls.Add(this.txtCashName);
            this.gbInfoWrite.Controls.Add(this.label2);
            this.gbInfoWrite.Controls.Add(this.txtCashNo);
            this.gbInfoWrite.Controls.Add(this.label1);
            this.gbInfoWrite.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbInfoWrite.Location = new System.Drawing.Point(808, 4);
            this.gbInfoWrite.Name = "gbInfoWrite";
            this.gbInfoWrite.Size = new System.Drawing.Size(177, 486);
            this.gbInfoWrite.TabIndex = 1;
            this.gbInfoWrite.TabStop = false;
            this.gbInfoWrite.Text = "信息录入栏";
            // 
            // cboClub
            // 
            this.cboClub.Font = new System.Drawing.Font("苹方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboClub.FormattingEnabled = true;
            this.cboClub.Items.AddRange(new object[] {
            "酒店部",
            "餐饮部",
            "行政部",
            "后勤部",
            "人资部"});
            this.cboClub.Location = new System.Drawing.Point(23, 246);
            this.cboClub.Name = "cboClub";
            this.cboClub.Size = new System.Drawing.Size(131, 30);
            this.cboClub.TabIndex = 14;
            // 
            // btnOK
            // 
            this.btnOK.BackgroundImage = global::TSHotelManagerSystem.Properties.Resources.button;
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.Font = new System.Drawing.Font("苹方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.ForeColor = System.Drawing.Color.Black;
            this.btnOK.Location = new System.Drawing.Point(41, 424);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(94, 39);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "录 入";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("苹方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpDate.Location = new System.Drawing.Point(23, 312);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(131, 30);
            this.dtpDate.TabIndex = 12;
            // 
            // txtFrom
            // 
            this.txtFrom.Font = new System.Drawing.Font("苹方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFrom.Location = new System.Drawing.Point(23, 375);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(131, 30);
            this.txtFrom.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(48, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "资 产 来 源";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(29, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "资 产 入 库 时 间";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(48, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "所 属 部 门";
            // 
            // txtCashMoney
            // 
            this.txtCashMoney.Font = new System.Drawing.Font("苹方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCashMoney.Location = new System.Drawing.Point(23, 182);
            this.txtCashMoney.Name = "txtCashMoney";
            this.txtCashMoney.Size = new System.Drawing.Size(131, 30);
            this.txtCashMoney.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(48, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "资 产 价 值";
            // 
            // txtCashName
            // 
            this.txtCashName.Font = new System.Drawing.Font("苹方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCashName.Location = new System.Drawing.Point(23, 119);
            this.txtCashName.Name = "txtCashName";
            this.txtCashName.Size = new System.Drawing.Size(131, 30);
            this.txtCashName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(48, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "资 产 名 称";
            // 
            // txtCashNo
            // 
            this.txtCashNo.Font = new System.Drawing.Font("苹方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCashNo.Location = new System.Drawing.Point(23, 55);
            this.txtCashNo.Name = "txtCashNo";
            this.txtCashNo.ReadOnly = true;
            this.txtCashNo.Size = new System.Drawing.Size(131, 30);
            this.txtCashNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(48, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "资 产 编 号";
            // 
            // FrmCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(989, 495);
            this.Controls.Add(this.gbInfoWrite);
            this.Controls.Add(this.dgvCashList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCash";
            this.Text = "FrmCash";
            this.Load += new System.EventHandler(this.FrmCash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashList)).EndInit();
            this.gbInfoWrite.ResumeLayout(false);
            this.gbInfoWrite.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCashList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCashNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCashName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCashPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCashClub;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCashTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCashSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCashPerson;
        private System.Windows.Forms.GroupBox gbInfoWrite;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCashMoney;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCashName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCashNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboClub;
    }
}