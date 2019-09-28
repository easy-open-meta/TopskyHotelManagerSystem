namespace TSHotelManagerSystem
{
    partial class FrmReserManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReserManager));
            this.dgvBou = new System.Windows.Forms.DataGridView();
            this.clReserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCustoName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCustoTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clReserWay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clReserRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clReserCash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clReserDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clReserPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clReserRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picDeleteReser = new System.Windows.Forms.PictureBox();
            this.picUpdate = new System.Windows.Forms.PictureBox();
            this.picAddReserInfo = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.ReserCash = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtReserNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtReserNum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpBouDate = new System.Windows.Forms.DateTimePicker();
            this.txtCustoName = new System.Windows.Forms.TextBox();
            this.cboReserWay = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustoTel = new System.Windows.Forms.TextBox();
            this.ttpInformation = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBou)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeleteReser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddReserInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBou
            // 
            this.dgvBou.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBou.BackgroundColor = System.Drawing.Color.White;
            this.dgvBou.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBou.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clReserId,
            this.clCustoName,
            this.clCustoTel,
            this.clReserWay,
            this.clReserRoom,
            this.clReserCash,
            this.clReserDate,
            this.clReserPerson,
            this.clReserRemark});
            this.dgvBou.Location = new System.Drawing.Point(177, 6);
            this.dgvBou.MultiSelect = false;
            this.dgvBou.Name = "dgvBou";
            this.dgvBou.ReadOnly = true;
            this.dgvBou.RowTemplate.Height = 23;
            this.dgvBou.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBou.Size = new System.Drawing.Size(810, 443);
            this.dgvBou.TabIndex = 13;
            this.dgvBou.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBou_CellClick);
            // 
            // clReserId
            // 
            this.clReserId.DataPropertyName = "ReserId";
            this.clReserId.HeaderText = "预约编号";
            this.clReserId.Name = "clReserId";
            this.clReserId.ReadOnly = true;
            // 
            // clCustoName
            // 
            this.clCustoName.DataPropertyName = "CustoName";
            this.clCustoName.HeaderText = "客户姓名";
            this.clCustoName.Name = "clCustoName";
            this.clCustoName.ReadOnly = true;
            // 
            // clCustoTel
            // 
            this.clCustoTel.DataPropertyName = "CustoTel";
            this.clCustoTel.HeaderText = "预约号码";
            this.clCustoTel.Name = "clCustoTel";
            this.clCustoTel.ReadOnly = true;
            // 
            // clReserWay
            // 
            this.clReserWay.DataPropertyName = "ReserWay";
            this.clReserWay.HeaderText = "预约渠道";
            this.clReserWay.Name = "clReserWay";
            this.clReserWay.ReadOnly = true;
            // 
            // clReserRoom
            // 
            this.clReserRoom.DataPropertyName = "typeName";
            this.clReserRoom.HeaderText = "房间类型";
            this.clReserRoom.Name = "clReserRoom";
            this.clReserRoom.ReadOnly = true;
            // 
            // clReserCash
            // 
            this.clReserCash.DataPropertyName = "ReserCash";
            this.clReserCash.HeaderText = "预约定金";
            this.clReserCash.Name = "clReserCash";
            this.clReserCash.ReadOnly = true;
            // 
            // clReserDate
            // 
            this.clReserDate.DataPropertyName = "ReserDate";
            this.clReserDate.HeaderText = "预约日期";
            this.clReserDate.Name = "clReserDate";
            this.clReserDate.ReadOnly = true;
            // 
            // clReserPerson
            // 
            this.clReserPerson.DataPropertyName = "ReserPerson";
            this.clReserPerson.HeaderText = "预订人数";
            this.clReserPerson.Name = "clReserPerson";
            this.clReserPerson.ReadOnly = true;
            // 
            // clReserRemark
            // 
            this.clReserRemark.DataPropertyName = "ReserRemark";
            this.clReserRemark.HeaderText = "预约留言";
            this.clReserRemark.Name = "clReserRemark";
            this.clReserRemark.ReadOnly = true;
            // 
            // picDeleteReser
            // 
            this.picDeleteReser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picDeleteReser.BackgroundImage")));
            this.picDeleteReser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picDeleteReser.Location = new System.Drawing.Point(54, 388);
            this.picDeleteReser.Name = "picDeleteReser";
            this.picDeleteReser.Size = new System.Drawing.Size(31, 32);
            this.picDeleteReser.TabIndex = 18;
            this.picDeleteReser.TabStop = false;
            this.picDeleteReser.Click += new System.EventHandler(this.picDeleteReser_Click);
            // 
            // picUpdate
            // 
            this.picUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picUpdate.BackgroundImage")));
            this.picUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picUpdate.Location = new System.Drawing.Point(96, 388);
            this.picUpdate.Name = "picUpdate";
            this.picUpdate.Size = new System.Drawing.Size(31, 32);
            this.picUpdate.TabIndex = 19;
            this.picUpdate.TabStop = false;
            this.picUpdate.Click += new System.EventHandler(this.picUpdate_Click);
            // 
            // picAddReserInfo
            // 
            this.picAddReserInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picAddReserInfo.BackgroundImage")));
            this.picAddReserInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAddReserInfo.Location = new System.Drawing.Point(12, 388);
            this.picAddReserInfo.Name = "picAddReserInfo";
            this.picAddReserInfo.Size = new System.Drawing.Size(31, 32);
            this.picAddReserInfo.TabIndex = 20;
            this.picAddReserInfo.TabStop = false;
            this.picAddReserInfo.Click += new System.EventHandler(this.picAddReserInfo_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(139, 423);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 24;
            this.label13.Text = "查询";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(55, 423);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 23;
            this.label12.Text = "删除";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(97, 423);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 23;
            this.label11.Text = "修改";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 423);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 22;
            this.label10.Text = "添加";
            // 
            // picSearch
            // 
            this.picSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picSearch.BackgroundImage")));
            this.picSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSearch.Location = new System.Drawing.Point(138, 388);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(31, 32);
            this.picSearch.TabIndex = 21;
            this.picSearch.TabStop = false;
            this.picSearch.Click += new System.EventHandler(this.picSearch_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 304);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(159, 61);
            this.txtMessage.TabIndex = 38;
            // 
            // ReserCash
            // 
            this.ReserCash.Location = new System.Drawing.Point(71, 147);
            this.ReserCash.Name = "ReserCash";
            this.ReserCash.Size = new System.Drawing.Size(100, 21);
            this.ReserCash.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 32;
            this.label8.Text = "预约留言";
            // 
            // txtReserNo
            // 
            this.txtReserNo.Location = new System.Drawing.Point(71, 19);
            this.txtReserNo.Name = "txtReserNo";
            this.txtReserNo.Size = new System.Drawing.Size(100, 21);
            this.txtReserNo.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 28;
            this.label4.Text = "预约渠道";
            // 
            // Type
            // 
            this.Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Type.FormattingEnabled = true;
            this.Type.Location = new System.Drawing.Point(71, 179);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(100, 20);
            this.Type.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 30;
            this.label6.Text = "预约日期";
            // 
            // txtReserNum
            // 
            this.txtReserNum.Location = new System.Drawing.Point(71, 115);
            this.txtReserNum.Name = "txtReserNum";
            this.txtReserNum.Size = new System.Drawing.Size(100, 21);
            this.txtReserNum.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 33;
            this.label9.Text = "房间类型";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 25;
            this.label1.Text = "预约编号";
            // 
            // dtpBouDate
            // 
            this.dtpBouDate.Location = new System.Drawing.Point(71, 240);
            this.dtpBouDate.Name = "dtpBouDate";
            this.dtpBouDate.Size = new System.Drawing.Size(100, 21);
            this.dtpBouDate.TabIndex = 41;
            // 
            // txtCustoName
            // 
            this.txtCustoName.Location = new System.Drawing.Point(71, 83);
            this.txtCustoName.Name = "txtCustoName";
            this.txtCustoName.Size = new System.Drawing.Size(100, 21);
            this.txtCustoName.TabIndex = 35;
            // 
            // cboReserWay
            // 
            this.cboReserWay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReserWay.FormattingEnabled = true;
            this.cboReserWay.Items.AddRange(new object[] {
            "互联网",
            "手机客户端",
            "电话"});
            this.cboReserWay.Location = new System.Drawing.Point(71, 211);
            this.cboReserWay.Name = "cboReserWay";
            this.cboReserWay.Size = new System.Drawing.Size(100, 20);
            this.cboReserWay.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 31;
            this.label7.Text = "预订人数";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 29;
            this.label5.Text = "预约定金";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 27;
            this.label3.Text = "预约号码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 26;
            this.label2.Text = "客户姓名";
            // 
            // txtCustoTel
            // 
            this.txtCustoTel.Location = new System.Drawing.Point(71, 51);
            this.txtCustoTel.Name = "txtCustoTel";
            this.txtCustoTel.Size = new System.Drawing.Size(100, 21);
            this.txtCustoTel.TabIndex = 36;
            this.ttpInformation.SetToolTip(this.txtCustoTel, "请输入预约电话！");
            // 
            // FrmReserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(994, 454);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.ReserCash);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtReserNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtReserNum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpBouDate);
            this.Controls.Add(this.txtCustoName);
            this.Controls.Add(this.cboReserWay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCustoTel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.picSearch);
            this.Controls.Add(this.picAddReserInfo);
            this.Controls.Add(this.picUpdate);
            this.Controls.Add(this.picDeleteReser);
            this.Controls.Add(this.dgvBou);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReserManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "客房管理";
            this.Load += new System.EventHandler(this.FrmRoomManager_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBou)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeleteReser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddReserInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvBou;
        private System.Windows.Forms.DataGridViewTextBoxColumn clReserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCustoName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCustoTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clReserWay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clReserRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn clReserCash;
        private System.Windows.Forms.DataGridViewTextBoxColumn clReserDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clReserPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn clReserRemark;
        private System.Windows.Forms.PictureBox picDeleteReser;
        private System.Windows.Forms.PictureBox picUpdate;
        private System.Windows.Forms.PictureBox picAddReserInfo;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox ReserCash;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtReserNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtReserNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpBouDate;
        private System.Windows.Forms.TextBox txtCustoName;
        private System.Windows.Forms.ComboBox cboReserWay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustoTel;
        private System.Windows.Forms.ToolTip ttpInformation;
    }
}