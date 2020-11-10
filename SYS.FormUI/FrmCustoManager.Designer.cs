namespace SYS.FormUI
{
    partial class FrmCustoManager
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtSerach = new System.Windows.Forms.TextBox();
            this.gbCustoInfo = new System.Windows.Forms.GroupBox();
            this.picGetCustoNo = new System.Windows.Forms.PictureBox();
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
            this.label7 = new System.Windows.Forms.Label();
            this.picLoadOut = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.picUpdateCusto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picAddCusto = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.gbCustoInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGetCustoNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoadOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdateCusto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddCusto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(799, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 102;
            this.label2.Text = "请输入证件号码查找：";
            // 
            // txtSerach
            // 
            this.txtSerach.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSerach.Location = new System.Drawing.Point(801, 417);
            this.txtSerach.Multiline = true;
            this.txtSerach.Name = "txtSerach";
            this.txtSerach.Size = new System.Drawing.Size(177, 23);
            this.txtSerach.TabIndex = 101;
            // 
            // gbCustoInfo
            // 
            this.gbCustoInfo.Controls.Add(this.picGetCustoNo);
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
            this.gbCustoInfo.Location = new System.Drawing.Point(12, 310);
            this.gbCustoInfo.Name = "gbCustoInfo";
            this.gbCustoInfo.Size = new System.Drawing.Size(770, 131);
            this.gbCustoInfo.TabIndex = 98;
            this.gbCustoInfo.TabStop = false;
            this.gbCustoInfo.Text = "客户信息栏";
            this.gbCustoInfo.Enter += new System.EventHandler(this.gbCustoInfo_Enter);
            // 
            // picGetCustoNo
            // 
            this.picGetCustoNo.BackColor = System.Drawing.Color.Transparent;
            this.picGetCustoNo.BackgroundImage = global::SYS.FormUI.Properties.Resources.获取用户编号;
            this.picGetCustoNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picGetCustoNo.Location = new System.Drawing.Point(213, 31);
            this.picGetCustoNo.Name = "picGetCustoNo";
            this.picGetCustoNo.Size = new System.Drawing.Size(21, 20);
            this.picGetCustoNo.TabIndex = 93;
            this.picGetCustoNo.TabStop = false;
            this.picGetCustoNo.Click += new System.EventHandler(this.picGetCustoNo_Click_1);
            this.picGetCustoNo.MouseLeave += new System.EventHandler(this.picGetCustoNo_MouseLeave_1);
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
            this.cboPassport.Location = new System.Drawing.Point(309, 93);
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
            this.cboCustoType.Location = new System.Drawing.Point(309, 61);
            this.cboCustoType.Name = "cboCustoType";
            this.cboCustoType.Size = new System.Drawing.Size(125, 28);
            this.cboCustoType.TabIndex = 87;
            // 
            // txtCustoAdress
            // 
            this.txtCustoAdress.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCustoAdress.Location = new System.Drawing.Point(533, 61);
            this.txtCustoAdress.Name = "txtCustoAdress";
            this.txtCustoAdress.Size = new System.Drawing.Size(191, 27);
            this.txtCustoAdress.TabIndex = 89;
            // 
            // txtCardID
            // 
            this.txtCardID.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCardID.Location = new System.Drawing.Point(533, 30);
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
            this.label12.Location = new System.Drawing.Point(474, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 17);
            this.label12.TabIndex = 76;
            this.label12.Text = "证件号码";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(250, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 90;
            this.label6.Text = "证件类型";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(476, 68);
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
            this.dtpBirthday.Location = new System.Drawing.Point(309, 30);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(125, 27);
            this.dtpBirthday.TabIndex = 86;
            // 
            // txtCustoName
            // 
            this.txtCustoName.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCustoName.Location = new System.Drawing.Point(84, 60);
            this.txtCustoName.Name = "txtCustoName";
            this.txtCustoName.Size = new System.Drawing.Size(125, 27);
            this.txtCustoName.TabIndex = 82;
            // 
            // txtCustoNo
            // 
            this.txtCustoNo.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCustoNo.Location = new System.Drawing.Point(84, 28);
            this.txtCustoNo.Name = "txtCustoNo";
            this.txtCustoNo.Size = new System.Drawing.Size(125, 27);
            this.txtCustoNo.TabIndex = 81;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(250, 69);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 17);
            this.label15.TabIndex = 79;
            this.label15.Text = "客户类型";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(27, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 73;
            this.label9.Text = "客户姓名";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(27, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 74;
            this.label10.Text = "性      别";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(250, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 17);
            this.label14.TabIndex = 78;
            this.label14.Text = "出生日期";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(476, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 75;
            this.label11.Text = "客户电话";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(27, 36);
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
            this.cboSex.Location = new System.Drawing.Point(84, 92);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(125, 28);
            this.cboSex.TabIndex = 83;
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTel.Location = new System.Drawing.Point(533, 92);
            this.txtTel.MaxLength = 11;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(191, 27);
            this.txtTel.TabIndex = 84;
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
            this.dgvCustomerList.TabIndex = 95;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(949, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 17);
            this.label7.TabIndex = 106;
            this.label7.Text = "导出";
            // 
            // picLoadOut
            // 
            this.picLoadOut.BackgroundImage = global::SYS.FormUI.Properties.Resources.导出__4_;
            this.picLoadOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLoadOut.Location = new System.Drawing.Point(948, 310);
            this.picLoadOut.Name = "picLoadOut";
            this.picLoadOut.Size = new System.Drawing.Size(33, 30);
            this.picLoadOut.TabIndex = 105;
            this.picLoadOut.TabStop = false;
            this.picLoadOut.Click += new System.EventHandler(this.picLoadOut_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(852, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 104;
            this.label4.Text = "修改";
            // 
            // picUpdateCusto
            // 
            this.picUpdateCusto.BackgroundImage = global::SYS.FormUI.Properties.Resources.修改a;
            this.picUpdateCusto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picUpdateCusto.Location = new System.Drawing.Point(850, 310);
            this.picUpdateCusto.Name = "picUpdateCusto";
            this.picUpdateCusto.Size = new System.Drawing.Size(33, 30);
            this.picUpdateCusto.TabIndex = 103;
            this.picUpdateCusto.TabStop = false;
            this.picUpdateCusto.Click += new System.EventHandler(this.picUpdateCusto_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(900, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 110;
            this.label1.Text = "查询";
            // 
            // picAddCusto
            // 
            this.picAddCusto.BackgroundImage = global::SYS.FormUI.Properties.Resources.添_加a;
            this.picAddCusto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAddCusto.Location = new System.Drawing.Point(801, 310);
            this.picAddCusto.Name = "picAddCusto";
            this.picAddCusto.Size = new System.Drawing.Size(33, 30);
            this.picAddCusto.TabIndex = 107;
            this.picAddCusto.TabStop = false;
            this.picAddCusto.Click += new System.EventHandler(this.picAddCusto_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(805, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 109;
            this.label5.Text = "添加";
            // 
            // picSearch
            // 
            this.picSearch.BackgroundImage = global::SYS.FormUI.Properties.Resources.搜索__1a;
            this.picSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSearch.Location = new System.Drawing.Point(899, 310);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(33, 30);
            this.picSearch.TabIndex = 108;
            this.picSearch.TabStop = false;
            this.picSearch.Click += new System.EventHandler(this.picSearch_Click_1);
            // 
            // FrmCustoManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(994, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picAddCusto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.picSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.picLoadOut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picUpdateCusto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSerach);
            this.Controls.Add(this.gbCustoInfo);
            this.Controls.Add(this.dgvCustomerList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCustoManager";
            this.Text = "FrmCustoManager";
            this.Load += new System.EventHandler(this.FrmCustoManager_Load);
            this.gbCustoInfo.ResumeLayout(false);
            this.gbCustoInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGetCustoNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoadOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdateCusto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddCusto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSerach;
        private System.Windows.Forms.GroupBox gbCustoInfo;
        private System.Windows.Forms.PictureBox picGetCustoNo;
        private System.Windows.Forms.ComboBox cboPassport;
        private System.Windows.Forms.ComboBox cboCustoType;
        private System.Windows.Forms.TextBox txtCustoAdress;
        private System.Windows.Forms.TextBox txtCardID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.TextBox txtCustoName;
        private System.Windows.Forms.TextBox txtCustoNo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboSex;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.DataGridView dgvCustomerList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCustoNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCustoName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCustoSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCustoTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPassport;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCustoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCustoType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCustoAdress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCustoBirth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picLoadOut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picUpdateCusto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picAddCusto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picSearch;
    }
}