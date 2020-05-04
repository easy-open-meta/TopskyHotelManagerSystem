namespace TSHotelManagerSystem
{
    partial class FrmAddWorker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddWorker));
            this.btnClose = new System.Windows.Forms.Button();
            this.cboWorkerFace = new System.Windows.Forms.ComboBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.cboWorkerPosition = new System.Windows.Forms.ComboBox();
            this.cboClub = new System.Windows.Forms.ComboBox();
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.Pwd = new System.Windows.Forms.TextBox();
            this.WorkerID = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.WorkerTel = new System.Windows.Forms.TextBox();
            this.WorkerName = new System.Windows.Forms.TextBox();
            this.WorkerNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblChecked = new System.Windows.Forms.Label();
            this.cboEducation = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpHistory = new System.Windows.Forms.FlowLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Location = new System.Drawing.Point(513, 542);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 31);
            this.btnClose.TabIndex = 52;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cboWorkerFace
            // 
            this.cboWorkerFace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWorkerFace.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboWorkerFace.FormattingEnabled = true;
            this.cboWorkerFace.Items.AddRange(new object[] {
            "群众",
            "团员",
            "党员"});
            this.cboWorkerFace.Location = new System.Drawing.Point(301, 32);
            this.cboWorkerFace.Name = "cboWorkerFace";
            this.cboWorkerFace.Size = new System.Drawing.Size(147, 25);
            this.cboWorkerFace.TabIndex = 51;
            // 
            // dtpTime
            // 
            this.dtpTime.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpTime.Location = new System.Drawing.Point(300, 179);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(148, 24);
            this.dtpTime.TabIndex = 50;
            // 
            // cboWorkerPosition
            // 
            this.cboWorkerPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWorkerPosition.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboWorkerPosition.FormattingEnabled = true;
            this.cboWorkerPosition.Items.AddRange(new object[] {
            "职员",
            "经理",
            "总经理"});
            this.cboWorkerPosition.Location = new System.Drawing.Point(69, 63);
            this.cboWorkerPosition.Name = "cboWorkerPosition";
            this.cboWorkerPosition.Size = new System.Drawing.Size(147, 25);
            this.cboWorkerPosition.TabIndex = 49;
            // 
            // cboClub
            // 
            this.cboClub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClub.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboClub.FormattingEnabled = true;
            this.cboClub.Items.AddRange(new object[] {
            "酒店部",
            "餐饮部",
            "人事部",
            "财务部",
            "经理部",
            "后勤部"});
            this.cboClub.Location = new System.Drawing.Point(301, 62);
            this.cboClub.Name = "cboClub";
            this.cboClub.Size = new System.Drawing.Size(147, 25);
            this.cboClub.TabIndex = 48;
            // 
            // cboSex
            // 
            this.cboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSex.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboSex.FormattingEnabled = true;
            this.cboSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cboSex.Location = new System.Drawing.Point(69, 34);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(147, 25);
            this.cboSex.TabIndex = 47;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpBirthday.Location = new System.Drawing.Point(69, 92);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(147, 24);
            this.dtpBirthday.TabIndex = 46;
            // 
            // Pwd
            // 
            this.Pwd.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Pwd.Location = new System.Drawing.Point(300, 92);
            this.Pwd.Name = "Pwd";
            this.Pwd.PasswordChar = '*';
            this.Pwd.Size = new System.Drawing.Size(148, 24);
            this.Pwd.TabIndex = 45;
            // 
            // WorkerID
            // 
            this.WorkerID.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.WorkerID.Location = new System.Drawing.Point(77, 121);
            this.WorkerID.Name = "WorkerID";
            this.WorkerID.Size = new System.Drawing.Size(359, 24);
            this.WorkerID.TabIndex = 44;
            this.WorkerID.Validated += new System.EventHandler(this.WorkerID_Validated);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAddress.Location = new System.Drawing.Point(69, 150);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(379, 24);
            this.txtAddress.TabIndex = 43;
            // 
            // WorkerTel
            // 
            this.WorkerTel.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.WorkerTel.Location = new System.Drawing.Point(69, 179);
            this.WorkerTel.Name = "WorkerTel";
            this.WorkerTel.Size = new System.Drawing.Size(147, 24);
            this.WorkerTel.TabIndex = 42;
            // 
            // WorkerName
            // 
            this.WorkerName.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.WorkerName.Location = new System.Drawing.Point(301, 3);
            this.WorkerName.Name = "WorkerName";
            this.WorkerName.Size = new System.Drawing.Size(147, 24);
            this.WorkerName.TabIndex = 41;
            // 
            // WorkerNo
            // 
            this.WorkerNo.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.WorkerNo.Location = new System.Drawing.Point(69, 6);
            this.WorkerNo.Name = "WorkerNo";
            this.WorkerNo.ReadOnly = true;
            this.WorkerNo.Size = new System.Drawing.Size(147, 24);
            this.WorkerNo.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(230, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 20);
            this.label11.TabIndex = 39;
            this.label11.Text = "员工密码";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(0, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 20);
            this.label12.TabIndex = 38;
            this.label12.Text = "身份证号码";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 37;
            this.label9.Text = "员工职位";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 36;
            this.label10.Text = "员工住址";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(230, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "员工面貌";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(227, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "入职日期";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(230, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "所属部门";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "电话号码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "员工性别";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "出生日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(230, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "员工姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "员工编号";
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.Location = new System.Drawing.Point(417, 542);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 31);
            this.btnAdd.TabIndex = 53;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("苹方-简", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(9, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(145, 26);
            this.label13.TabIndex = 54;
            this.label13.Text = "员工信息添加页";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::TSHotelManagerSystem.Properties.Resources._77377282_p0_master1200;
            this.pictureBox1.Location = new System.Drawing.Point(456, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // lblChecked
            // 
            this.lblChecked.AutoSize = true;
            this.lblChecked.BackColor = System.Drawing.Color.Transparent;
            this.lblChecked.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblChecked.ForeColor = System.Drawing.Color.Red;
            this.lblChecked.Location = new System.Drawing.Point(436, 124);
            this.lblChecked.Name = "lblChecked";
            this.lblChecked.Size = new System.Drawing.Size(20, 17);
            this.lblChecked.TabIndex = 56;
            this.lblChecked.Text = "◆";
            this.lblChecked.Visible = false;
            // 
            // cboEducation
            // 
            this.cboEducation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEducation.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboEducation.FormattingEnabled = true;
            this.cboEducation.Items.AddRange(new object[] {
            "小学",
            "初中",
            "高中",
            "中职",
            "大专",
            "本科"});
            this.cboEducation.Location = new System.Drawing.Point(69, 209);
            this.cboEducation.Name = "cboEducation";
            this.cboEducation.Size = new System.Drawing.Size(147, 25);
            this.cboEducation.TabIndex = 58;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(1, 211);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 20);
            this.label14.TabIndex = 57;
            this.label14.Text = "最高学历";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.flpHistory);
            this.panel1.Location = new System.Drawing.Point(4, 281);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 218);
            this.panel1.TabIndex = 59;
            // 
            // flpHistory
            // 
            this.flpHistory.AutoScroll = true;
            this.flpHistory.Location = new System.Drawing.Point(3, 3);
            this.flpHistory.Name = "flpHistory";
            this.flpHistory.Size = new System.Drawing.Size(589, 212);
            this.flpHistory.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("苹方-简", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(175, 242);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(249, 26);
            this.label15.TabIndex = 60;
            this.label15.Text = "履               历               栏";
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.Transparent;
            this.pnlInfo.Controls.Add(this.label15);
            this.pnlInfo.Controls.Add(this.panel1);
            this.pnlInfo.Controls.Add(this.cboEducation);
            this.pnlInfo.Controls.Add(this.label14);
            this.pnlInfo.Controls.Add(this.lblChecked);
            this.pnlInfo.Controls.Add(this.pictureBox1);
            this.pnlInfo.Controls.Add(this.cboWorkerFace);
            this.pnlInfo.Controls.Add(this.dtpTime);
            this.pnlInfo.Controls.Add(this.cboWorkerPosition);
            this.pnlInfo.Controls.Add(this.cboClub);
            this.pnlInfo.Controls.Add(this.cboSex);
            this.pnlInfo.Controls.Add(this.dtpBirthday);
            this.pnlInfo.Controls.Add(this.Pwd);
            this.pnlInfo.Controls.Add(this.WorkerID);
            this.pnlInfo.Controls.Add(this.txtAddress);
            this.pnlInfo.Controls.Add(this.WorkerTel);
            this.pnlInfo.Controls.Add(this.WorkerName);
            this.pnlInfo.Controls.Add(this.WorkerNo);
            this.pnlInfo.Controls.Add(this.label11);
            this.pnlInfo.Controls.Add(this.label12);
            this.pnlInfo.Controls.Add(this.label9);
            this.pnlInfo.Controls.Add(this.label10);
            this.pnlInfo.Controls.Add(this.label5);
            this.pnlInfo.Controls.Add(this.label6);
            this.pnlInfo.Controls.Add(this.label7);
            this.pnlInfo.Controls.Add(this.label8);
            this.pnlInfo.Controls.Add(this.label4);
            this.pnlInfo.Controls.Add(this.label3);
            this.pnlInfo.Controls.Add(this.label2);
            this.pnlInfo.Controls.Add(this.label1);
            this.pnlInfo.Location = new System.Drawing.Point(1, 37);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(612, 505);
            this.pnlInfo.TabIndex = 61;
            this.pnlInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlInfo_Paint);
            // 
            // FrmAddWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TSHotelManagerSystem.Properties.Resources.main_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(611, 577);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddWorker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加员工";
            this.Load += new System.EventHandler(this.FrmAddWorker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cboWorkerFace;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.ComboBox cboWorkerPosition;
        private System.Windows.Forms.ComboBox cboClub;
        private System.Windows.Forms.ComboBox cboSex;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.TextBox Pwd;
        private System.Windows.Forms.TextBox WorkerID;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox WorkerTel;
        private System.Windows.Forms.TextBox WorkerName;
        private System.Windows.Forms.TextBox WorkerNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblChecked;
        private System.Windows.Forms.ComboBox cboEducation;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.FlowLayoutPanel flpHistory;
    }
}