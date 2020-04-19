namespace TSHotelManagerSystem
{
    partial class FrmCustomerManager
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
            this.dgvCustomerList = new System.Windows.Forms.DataGridView();
            this.clCustoNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCustoName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCustoSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCustoTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPassport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCustoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCustoType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCustoAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCustoBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbCustoInfo = new System.Windows.Forms.GroupBox();
            this.picGetCustoNo = new System.Windows.Forms.PictureBox();
            this.picShow = new System.Windows.Forms.PictureBox();
            this.cboPassport = new System.Windows.Forms.ComboBox();
            this.cboCustoType = new System.Windows.Forms.ComboBox();
            this.txtCustoAdress = new System.Windows.Forms.TextBox();
            this.txtCardID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtCustoName = new System.Windows.Forms.TextBox();
            this.txtCustoNo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.picAddCusto = new System.Windows.Forms.PictureBox();
            this.picSearch = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).BeginInit();
            this.gbCustoInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGetCustoNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddCusto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomerList
            // 
            this.dgvCustomerList.AllowUserToAddRows = false;
            this.dgvCustomerList.AllowUserToDeleteRows = false;
            this.dgvCustomerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomerList.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomerList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustomerList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCustoNo,
            this.clCustoName,
            this.clCustoSex,
            this.clCustoTel,
            this.clPassport,
            this.clCustoID,
            this.clCustoType,
            this.clCustoAdress,
            this.clCustoBirth});
            this.dgvCustomerList.GridColor = System.Drawing.Color.Black;
            this.dgvCustomerList.Location = new System.Drawing.Point(12, 12);
            this.dgvCustomerList.MultiSelect = false;
            this.dgvCustomerList.Name = "dgvCustomerList";
            this.dgvCustomerList.ReadOnly = true;
            this.dgvCustomerList.RowHeadersWidth = 20;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvCustomerList.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomerList.RowTemplate.Height = 23;
            this.dgvCustomerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerList.ShowEditingIcon = false;
            this.dgvCustomerList.Size = new System.Drawing.Size(970, 290);
            this.dgvCustomerList.TabIndex = 0;
            this.dgvCustomerList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerList_CellClick);
            // 
            // clCustoNo
            // 
            this.clCustoNo.DataPropertyName = "CustoNo";
            this.clCustoNo.HeaderText = "客户编号";
            this.clCustoNo.Name = "clCustoNo";
            this.clCustoNo.ReadOnly = true;
            // 
            // clCustoName
            // 
            this.clCustoName.DataPropertyName = "CustoName";
            this.clCustoName.HeaderText = "客户姓名";
            this.clCustoName.Name = "clCustoName";
            this.clCustoName.ReadOnly = true;
            // 
            // clCustoSex
            // 
            this.clCustoSex.DataPropertyName = "CustoSex";
            this.clCustoSex.HeaderText = "性别";
            this.clCustoSex.Name = "clCustoSex";
            this.clCustoSex.ReadOnly = true;
            // 
            // clCustoTel
            // 
            this.clCustoTel.DataPropertyName = "CustoTel";
            this.clCustoTel.HeaderText = "手机号码";
            this.clCustoTel.Name = "clCustoTel";
            this.clCustoTel.ReadOnly = true;
            // 
            // clPassport
            // 
            this.clPassport.DataPropertyName = "PassportName";
            this.clPassport.HeaderText = "证件类型";
            this.clPassport.Name = "clPassport";
            this.clPassport.ReadOnly = true;
            this.clPassport.Visible = false;
            // 
            // clCustoID
            // 
            this.clCustoID.DataPropertyName = "CustoID";
            this.clCustoID.HeaderText = "证件号码";
            this.clCustoID.Name = "clCustoID";
            this.clCustoID.ReadOnly = true;
            this.clCustoID.Visible = false;
            // 
            // clCustoType
            // 
            this.clCustoType.DataPropertyName = "TypeName";
            this.clCustoType.HeaderText = "客户类型";
            this.clCustoType.Name = "clCustoType";
            this.clCustoType.ReadOnly = true;
            // 
            // clCustoAdress
            // 
            this.clCustoAdress.DataPropertyName = "CustoAdress";
            this.clCustoAdress.HeaderText = "客户地址";
            this.clCustoAdress.Name = "clCustoAdress";
            this.clCustoAdress.ReadOnly = true;
            // 
            // clCustoBirth
            // 
            this.clCustoBirth.DataPropertyName = "CustoBirth";
            this.clCustoBirth.HeaderText = "出生日期";
            this.clCustoBirth.Name = "clCustoBirth";
            this.clCustoBirth.ReadOnly = true;
            this.clCustoBirth.Visible = false;
            // 
            // gbCustoInfo
            // 
            this.gbCustoInfo.Controls.Add(this.picGetCustoNo);
            this.gbCustoInfo.Controls.Add(this.picShow);
            this.gbCustoInfo.Controls.Add(this.cboPassport);
            this.gbCustoInfo.Controls.Add(this.cboCustoType);
            this.gbCustoInfo.Controls.Add(this.txtCustoAdress);
            this.gbCustoInfo.Controls.Add(this.txtCardID);
            this.gbCustoInfo.Controls.Add(this.label12);
            this.gbCustoInfo.Controls.Add(this.label6);
            this.gbCustoInfo.Controls.Add(this.label13);
            this.gbCustoInfo.Controls.Add(this.dtpBirthday);
            this.gbCustoInfo.Controls.Add(this.txtCustoName);
            this.gbCustoInfo.Controls.Add(this.txtCustoNo);
            this.gbCustoInfo.Controls.Add(this.label15);
            this.gbCustoInfo.Controls.Add(this.label9);
            this.gbCustoInfo.Controls.Add(this.label10);
            this.gbCustoInfo.Controls.Add(this.label14);
            this.gbCustoInfo.Controls.Add(this.label11);
            this.gbCustoInfo.Controls.Add(this.label3);
            this.gbCustoInfo.Controls.Add(this.cboSex);
            this.gbCustoInfo.Controls.Add(this.txtTel);
            this.gbCustoInfo.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbCustoInfo.Location = new System.Drawing.Point(14, 310);
            this.gbCustoInfo.Name = "gbCustoInfo";
            this.gbCustoInfo.Size = new System.Drawing.Size(905, 131);
            this.gbCustoInfo.TabIndex = 73;
            this.gbCustoInfo.TabStop = false;
            this.gbCustoInfo.Text = "客户信息栏";
            // 
            // picGetCustoNo
            // 
            this.picGetCustoNo.BackColor = System.Drawing.Color.Transparent;
            this.picGetCustoNo.BackgroundImage = global::TSHotelManagerSystem.Properties.Resources.获取用户编号;
            this.picGetCustoNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picGetCustoNo.Location = new System.Drawing.Point(225, 33);
            this.picGetCustoNo.Name = "picGetCustoNo";
            this.picGetCustoNo.Size = new System.Drawing.Size(21, 20);
            this.picGetCustoNo.TabIndex = 93;
            this.picGetCustoNo.TabStop = false;
            this.toolTip1.SetToolTip(this.picGetCustoNo, "随机获取用户编号");
            this.picGetCustoNo.Click += new System.EventHandler(this.picGetCustoNo_Click);
            this.picGetCustoNo.MouseLeave += new System.EventHandler(this.picGetCustoNo_MouseLeave);
            // 
            // picShow
            // 
            this.picShow.BackgroundImage = global::TSHotelManagerSystem.Properties.Resources.显示;
            this.picShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picShow.Location = new System.Drawing.Point(834, 33);
            this.picShow.Name = "picShow";
            this.picShow.Size = new System.Drawing.Size(32, 21);
            this.picShow.TabIndex = 92;
            this.picShow.TabStop = false;
            this.picShow.Click += new System.EventHandler(this.picShow_Click);
            // 
            // cboPassport
            // 
            this.cboPassport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPassport.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboPassport.FormattingEnabled = true;
            this.cboPassport.Items.AddRange(new object[] {
            "中国居民身份证",
            "港澳通行证",
            "台胞证",
            "军官证",
            "外国护照"});
            this.cboPassport.Location = new System.Drawing.Point(385, 93);
            this.cboPassport.Name = "cboPassport";
            this.cboPassport.Size = new System.Drawing.Size(125, 28);
            this.cboPassport.TabIndex = 91;
            // 
            // cboCustoType
            // 
            this.cboCustoType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCustoType.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboCustoType.FormattingEnabled = true;
            this.cboCustoType.Items.AddRange(new object[] {
            "普通用户",
            "钻石会员",
            "白金会员",
            "黄金会员"});
            this.cboCustoType.Location = new System.Drawing.Point(385, 61);
            this.cboCustoType.Name = "cboCustoType";
            this.cboCustoType.Size = new System.Drawing.Size(125, 28);
            this.cboCustoType.TabIndex = 87;
            // 
            // txtCustoAdress
            // 
            this.txtCustoAdress.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCustoAdress.Location = new System.Drawing.Point(638, 61);
            this.txtCustoAdress.Name = "txtCustoAdress";
            this.txtCustoAdress.Size = new System.Drawing.Size(191, 27);
            this.txtCustoAdress.TabIndex = 89;
            // 
            // txtCardID
            // 
            this.txtCardID.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCardID.Location = new System.Drawing.Point(638, 30);
            this.txtCardID.MaxLength = 18;
            this.txtCardID.Name = "txtCardID";
            this.txtCardID.Size = new System.Drawing.Size(191, 27);
            this.txtCardID.TabIndex = 85;
            this.txtCardID.TextChanged += new System.EventHandler(this.txtCardID_TextChanged);
            this.txtCardID.Validated += new System.EventHandler(this.txtCardID_Validated);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(579, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 17);
            this.label12.TabIndex = 76;
            this.label12.Text = "证件号码";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(326, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 90;
            this.label6.Text = "证件类型";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(581, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 17);
            this.label13.TabIndex = 77;
            this.label13.Text = "客户地址";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.CalendarFont = new System.Drawing.Font("华文中宋", 8.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpBirthday.CustomFormat = "yyyy-MM-dd";
            this.dtpBirthday.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthday.Location = new System.Drawing.Point(385, 30);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(125, 27);
            this.dtpBirthday.TabIndex = 86;
            // 
            // txtCustoName
            // 
            this.txtCustoName.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCustoName.Location = new System.Drawing.Point(98, 62);
            this.txtCustoName.Name = "txtCustoName";
            this.txtCustoName.Size = new System.Drawing.Size(125, 27);
            this.txtCustoName.TabIndex = 82;
            // 
            // txtCustoNo
            // 
            this.txtCustoNo.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCustoNo.Location = new System.Drawing.Point(98, 30);
            this.txtCustoNo.Name = "txtCustoNo";
            this.txtCustoNo.Size = new System.Drawing.Size(125, 27);
            this.txtCustoNo.TabIndex = 81;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(326, 67);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 17);
            this.label15.TabIndex = 79;
            this.label15.Text = "客户类型";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(39, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 73;
            this.label9.Text = "客户姓名";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(39, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 74;
            this.label10.Text = "性      别";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(326, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 17);
            this.label14.TabIndex = 78;
            this.label14.Text = "出生日期";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(581, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 75;
            this.label11.Text = "客户电话";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(39, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 72;
            this.label3.Text = "客户编号";
            // 
            // cboSex
            // 
            this.cboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSex.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboSex.FormattingEnabled = true;
            this.cboSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cboSex.Location = new System.Drawing.Point(98, 94);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(125, 28);
            this.cboSex.TabIndex = 83;
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTel.Location = new System.Drawing.Point(638, 92);
            this.txtTel.MaxLength = 11;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(191, 27);
            this.txtTel.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(942, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 79;
            this.label1.Text = "查 询";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(941, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 76;
            this.label5.Text = "添 加";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "获取账号";
            // 
            // picAddCusto
            // 
            this.picAddCusto.BackgroundImage = global::TSHotelManagerSystem.Properties.Resources.添_加a;
            this.picAddCusto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAddCusto.Location = new System.Drawing.Point(940, 325);
            this.picAddCusto.Name = "picAddCusto";
            this.picAddCusto.Size = new System.Drawing.Size(40, 40);
            this.picAddCusto.TabIndex = 20;
            this.picAddCusto.TabStop = false;
            this.picAddCusto.Click += new System.EventHandler(this.picAddCusto_Click);
            // 
            // picSearch
            // 
            this.picSearch.BackgroundImage = global::TSHotelManagerSystem.Properties.Resources.搜索__1a;
            this.picSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSearch.Location = new System.Drawing.Point(940, 387);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(40, 40);
            this.picSearch.TabIndex = 21;
            this.picSearch.TabStop = false;
            this.picSearch.Click += new System.EventHandler(this.picSearch_Click);
            // 
            // FrmCustomerManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(994, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbCustoInfo);
            this.Controls.Add(this.dgvCustomerList);
            this.Controls.Add(this.picAddCusto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.picSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCustomerManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TS酒店管理系统";
            this.Load += new System.EventHandler(this.FrmCustomerManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).EndInit();
            this.gbCustoInfo.ResumeLayout(false);
            this.gbCustoInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGetCustoNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddCusto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomerList;
        private System.Windows.Forms.GroupBox gbCustoInfo;
        private System.Windows.Forms.TextBox txtCustoAdress;
        private System.Windows.Forms.ComboBox cboCustoType;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.TextBox txtCardID;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.ComboBox cboSex;
        private System.Windows.Forms.TextBox txtCustoName;
        private System.Windows.Forms.TextBox txtCustoNo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.PictureBox picAddCusto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboPassport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picShow;
        private System.Windows.Forms.PictureBox picGetCustoNo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCustoNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCustoName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCustoSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCustoTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPassport;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCustoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCustoType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCustoAdress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCustoBirth;
    }
}