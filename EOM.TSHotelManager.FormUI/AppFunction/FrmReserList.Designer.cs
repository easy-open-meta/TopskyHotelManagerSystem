namespace EOM.TSHotelManager.FormUI
{
    partial class FrmReserList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReserList));
            this.dgvReserList = new Sunny.UI.UIDataGridView();
            this.clReserNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCustoNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clway = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRoomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDealTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clReserMemo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbCustoType = new Sunny.UI.UIComboBox();
            this.cbPassportType = new Sunny.UI.UIComboBox();
            this.cbSex = new Sunny.UI.UIComboBox();
            this.txtCustoNo = new Sunny.UI.UITextBox();
            this.txtCustoName = new Sunny.UI.UITextBox();
            this.txtCardID = new Sunny.UI.UITextBox();
            this.txtTel = new Sunny.UI.UITextBox();
            this.dtpBirthday = new Sunny.UI.UIDatePicker();
            this.txtCustoAdress = new Sunny.UI.UITextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelect = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReserList
            // 
            this.dgvReserList.AllowUserToAddRows = false;
            this.dgvReserList.AllowUserToDeleteRows = false;
            this.dgvReserList.AllowUserToResizeColumns = false;
            this.dgvReserList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvReserList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReserList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReserList.BackgroundColor = System.Drawing.Color.White;
            this.dgvReserList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReserList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReserList.ColumnHeadersHeight = 32;
            this.dgvReserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReserList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clReserNo,
            this.clCustoNm,
            this.clTel,
            this.clway,
            this.clRoomNo,
            this.clStartTime,
            this.clDealTime,
            this.clReserMemo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReserList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReserList.EnableHeadersVisualStyles = false;
            this.dgvReserList.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgvReserList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvReserList.Location = new System.Drawing.Point(18, 104);
            this.dgvReserList.Name = "dgvReserList";
            this.dgvReserList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReserList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReserList.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvReserList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvReserList.RowTemplate.Height = 29;
            this.dgvReserList.SelectedIndex = -1;
            this.dgvReserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReserList.Size = new System.Drawing.Size(726, 169);
            this.dgvReserList.TabIndex = 113;
            this.dgvReserList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReserList_CellClick);
            // 
            // clReserNo
            // 
            this.clReserNo.DataPropertyName = "ReserId";
            this.clReserNo.HeaderText = "预约编号";
            this.clReserNo.Name = "clReserNo";
            this.clReserNo.ReadOnly = true;
            // 
            // clCustoNm
            // 
            this.clCustoNm.DataPropertyName = "CustoName";
            this.clCustoNm.HeaderText = "客户姓名";
            this.clCustoNm.Name = "clCustoNm";
            this.clCustoNm.ReadOnly = true;
            // 
            // clTel
            // 
            this.clTel.DataPropertyName = "CustoTel";
            this.clTel.HeaderText = "预约电话";
            this.clTel.Name = "clTel";
            this.clTel.ReadOnly = true;
            // 
            // clway
            // 
            this.clway.DataPropertyName = "ReserWay";
            this.clway.HeaderText = "预约方式";
            this.clway.Name = "clway";
            this.clway.ReadOnly = true;
            // 
            // clRoomNo
            // 
            this.clRoomNo.DataPropertyName = "ReserRoom";
            this.clRoomNo.HeaderText = "预约房号";
            this.clRoomNo.Name = "clRoomNo";
            this.clRoomNo.ReadOnly = true;
            // 
            // clStartTime
            // 
            this.clStartTime.DataPropertyName = "ReserDate";
            this.clStartTime.HeaderText = "开始时间";
            this.clStartTime.Name = "clStartTime";
            this.clStartTime.ReadOnly = true;
            // 
            // clDealTime
            // 
            this.clDealTime.DataPropertyName = "ReserEndDay";
            this.clDealTime.HeaderText = "截止时间";
            this.clDealTime.Name = "clDealTime";
            this.clDealTime.ReadOnly = true;
            // 
            // clReserMemo
            // 
            this.clReserMemo.DataPropertyName = "ReserRemark";
            this.clReserMemo.HeaderText = "预约备注";
            this.clReserMemo.Name = "clReserMemo";
            this.clReserMemo.ReadOnly = true;
            // 
            // cbCustoType
            // 
            this.cbCustoType.DataSource = null;
            this.cbCustoType.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbCustoType.FillColor = System.Drawing.Color.White;
            this.cbCustoType.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.cbCustoType.Location = new System.Drawing.Point(499, 290);
            this.cbCustoType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCustoType.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbCustoType.Name = "cbCustoType";
            this.cbCustoType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbCustoType.Radius = 20;
            this.cbCustoType.ReadOnly = true;
            this.cbCustoType.Size = new System.Drawing.Size(250, 35);
            this.cbCustoType.TabIndex = 134;
            this.cbCustoType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbCustoType.Watermark = "";
            // 
            // cbPassportType
            // 
            this.cbPassportType.DataSource = null;
            this.cbPassportType.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbPassportType.FillColor = System.Drawing.Color.White;
            this.cbPassportType.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.cbPassportType.Location = new System.Drawing.Point(499, 341);
            this.cbPassportType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPassportType.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbPassportType.Name = "cbPassportType";
            this.cbPassportType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbPassportType.Radius = 20;
            this.cbPassportType.Size = new System.Drawing.Size(250, 35);
            this.cbPassportType.TabIndex = 133;
            this.cbPassportType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbSex
            // 
            this.cbSex.DataSource = null;
            this.cbSex.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbSex.FillColor = System.Drawing.Color.White;
            this.cbSex.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.cbSex.Location = new System.Drawing.Point(123, 397);
            this.cbSex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSex.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbSex.Name = "cbSex";
            this.cbSex.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbSex.Radius = 20;
            this.cbSex.Size = new System.Drawing.Size(250, 35);
            this.cbSex.TabIndex = 132;
            this.cbSex.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCustoNo
            // 
            this.txtCustoNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustoNo.FillColor = System.Drawing.Color.White;
            this.txtCustoNo.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCustoNo.Location = new System.Drawing.Point(123, 293);
            this.txtCustoNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustoNo.Maximum = 2147483647D;
            this.txtCustoNo.Minimum = -2147483648D;
            this.txtCustoNo.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtCustoNo.Name = "txtCustoNo";
            this.txtCustoNo.Padding = new System.Windows.Forms.Padding(5);
            this.txtCustoNo.Radius = 20;
            this.txtCustoNo.ReadOnly = true;
            this.txtCustoNo.Size = new System.Drawing.Size(250, 35);
            this.txtCustoNo.Style = Sunny.UI.UIStyle.Custom;
            this.txtCustoNo.StyleCustomMode = true;
            this.txtCustoNo.TabIndex = 131;
            this.txtCustoNo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCustoName
            // 
            this.txtCustoName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustoName.FillColor = System.Drawing.Color.White;
            this.txtCustoName.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCustoName.Location = new System.Drawing.Point(123, 345);
            this.txtCustoName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustoName.Maximum = 2147483647D;
            this.txtCustoName.Minimum = -2147483648D;
            this.txtCustoName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtCustoName.Name = "txtCustoName";
            this.txtCustoName.Padding = new System.Windows.Forms.Padding(5);
            this.txtCustoName.Radius = 20;
            this.txtCustoName.Size = new System.Drawing.Size(250, 35);
            this.txtCustoName.Style = Sunny.UI.UIStyle.Custom;
            this.txtCustoName.StyleCustomMode = true;
            this.txtCustoName.TabIndex = 130;
            this.txtCustoName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCardID
            // 
            this.txtCardID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCardID.FillColor = System.Drawing.Color.White;
            this.txtCardID.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCardID.Location = new System.Drawing.Point(499, 392);
            this.txtCardID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCardID.Maximum = 2147483647D;
            this.txtCardID.Minimum = -2147483648D;
            this.txtCardID.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtCardID.Name = "txtCardID";
            this.txtCardID.Padding = new System.Windows.Forms.Padding(5);
            this.txtCardID.Radius = 20;
            this.txtCardID.Size = new System.Drawing.Size(250, 35);
            this.txtCardID.Style = Sunny.UI.UIStyle.Custom;
            this.txtCardID.StyleCustomMode = true;
            this.txtCardID.TabIndex = 129;
            this.txtCardID.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtCardID.Validated += new System.EventHandler(this.txtCardID_Validated);
            // 
            // txtTel
            // 
            this.txtTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTel.FillColor = System.Drawing.Color.White;
            this.txtTel.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTel.Location = new System.Drawing.Point(499, 443);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTel.Maximum = 2147483647D;
            this.txtTel.Minimum = -2147483648D;
            this.txtTel.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtTel.Name = "txtTel";
            this.txtTel.Padding = new System.Windows.Forms.Padding(5);
            this.txtTel.Radius = 20;
            this.txtTel.Size = new System.Drawing.Size(250, 35);
            this.txtTel.Style = Sunny.UI.UIStyle.Custom;
            this.txtTel.StyleCustomMode = true;
            this.txtTel.TabIndex = 128;
            this.txtTel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.dtpBirthday.FillColor = System.Drawing.Color.White;
            this.dtpBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.dtpBirthday.Location = new System.Drawing.Point(123, 449);
            this.dtpBirthday.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpBirthday.MaxLength = 10;
            this.dtpBirthday.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dtpBirthday.Radius = 20;
            this.dtpBirthday.ReadOnly = true;
            this.dtpBirthday.Size = new System.Drawing.Size(250, 31);
            this.dtpBirthday.SymbolDropDown = 61555;
            this.dtpBirthday.SymbolNormal = 61555;
            this.dtpBirthday.TabIndex = 127;
            this.dtpBirthday.Text = "2020-11-24";
            this.dtpBirthday.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtpBirthday.Value = new System.DateTime(2020, 11, 24, 22, 50, 36, 791);
            // 
            // txtCustoAdress
            // 
            this.txtCustoAdress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustoAdress.FillColor = System.Drawing.Color.White;
            this.txtCustoAdress.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCustoAdress.Location = new System.Drawing.Point(121, 497);
            this.txtCustoAdress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustoAdress.Maximum = 2147483647D;
            this.txtCustoAdress.Minimum = -2147483648D;
            this.txtCustoAdress.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtCustoAdress.Name = "txtCustoAdress";
            this.txtCustoAdress.Padding = new System.Windows.Forms.Padding(5);
            this.txtCustoAdress.Radius = 20;
            this.txtCustoAdress.Size = new System.Drawing.Size(628, 35);
            this.txtCustoAdress.Style = Sunny.UI.UIStyle.Custom;
            this.txtCustoAdress.StyleCustomMode = true;
            this.txtCustoAdress.TabIndex = 126;
            this.txtCustoAdress.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(14, 505);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 25);
            this.label10.TabIndex = 122;
            this.label10.Text = "居住地址";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(403, 450);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 25);
            this.label9.TabIndex = 121;
            this.label9.Text = "联系方式";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(403, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 25);
            this.label8.TabIndex = 120;
            this.label8.Text = "证件号码";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(403, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 25);
            this.label7.TabIndex = 119;
            this.label7.Text = "证件类型";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(403, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 118;
            this.label6.Text = "客户类型";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(16, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 117;
            this.label5.Text = "出生日期";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(16, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 116;
            this.label4.Text = "性      别";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(16, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 115;
            this.label3.Text = "客户姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(16, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 114;
            this.label2.Text = "客户编号";
            // 
            // btnSelect
            // 
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnSelect.Location = new System.Drawing.Point(19, 48);
            this.btnSelect.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Radius = 15;
            this.btnSelect.Size = new System.Drawing.Size(146, 44);
            this.btnSelect.TabIndex = 135;
            this.btnSelect.Text = "入住并注册";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // FrmReserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(763, 556);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.cbCustoType);
            this.Controls.Add(this.cbPassportType);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.txtCustoNo);
            this.Controls.Add(this.txtCustoName);
            this.Controls.Add(this.txtCardID);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.txtCustoAdress);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvReserList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReserList";
            this.ShowIcon = true;
            this.ShowTitleIcon = true;
            this.Text = "预约列表";
            this.Load += new System.EventHandler(this.FrmReserList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UIDataGridView dgvReserList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clReserNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCustoNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clway;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRoomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDealTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clReserMemo;
        private Sunny.UI.UIComboBox cbCustoType;
        private Sunny.UI.UIComboBox cbPassportType;
        private Sunny.UI.UIComboBox cbSex;
        private Sunny.UI.UITextBox txtCustoNo;
        private Sunny.UI.UITextBox txtCustoName;
        private Sunny.UI.UITextBox txtCardID;
        private Sunny.UI.UITextBox txtTel;
        private Sunny.UI.UIDatePicker dtpBirthday;
        private Sunny.UI.UITextBox txtCustoAdress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UIButton btnSelect;
    }
}