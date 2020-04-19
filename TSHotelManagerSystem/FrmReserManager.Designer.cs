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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReserManager));
            this.label14 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnReser = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cboReserRoomNo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpBouDate = new System.Windows.Forms.DateTimePicker();
            this.txtCustoName = new System.Windows.Forms.TextBox();
            this.cboReserWay = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustoTel = new System.Windows.Forms.TextBox();
            this.btnReserList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("苹方-简", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(110, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 41);
            this.label14.TabIndex = 43;
            this.label14.Text = "预约房间";
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRemark.Location = new System.Drawing.Point(151, 308);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(137, 61);
            this.txtRemark.TabIndex = 70;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Location = new System.Drawing.Point(193, 396);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 31);
            this.btnClose.TabIndex = 69;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(81, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 68;
            this.label8.Text = "预约备注";
            // 
            // btnReser
            // 
            this.btnReser.FlatAppearance.BorderSize = 0;
            this.btnReser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReser.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReser.Location = new System.Drawing.Point(64, 396);
            this.btnReser.Name = "btnReser";
            this.btnReser.Size = new System.Drawing.Size(94, 31);
            this.btnReser.TabIndex = 67;
            this.btnReser.Text = "预约";
            this.btnReser.UseVisualStyleBackColor = true;
            this.btnReser.Click += new System.EventHandler(this.btnReser_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(81, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 65;
            this.label7.Text = "预约止日";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpEndDate.Location = new System.Drawing.Point(151, 273);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(137, 27);
            this.dtpEndDate.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(81, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 64;
            this.label5.Text = "预约房号";
            // 
            // cboReserRoomNo
            // 
            this.cboReserRoomNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReserRoomNo.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboReserRoomNo.FormattingEnabled = true;
            this.cboReserRoomNo.Location = new System.Drawing.Point(151, 202);
            this.cboReserRoomNo.Name = "cboReserRoomNo";
            this.cboReserRoomNo.Size = new System.Drawing.Size(137, 28);
            this.cboReserRoomNo.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(81, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 56;
            this.label4.Text = "预约渠道";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(81, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 57;
            this.label6.Text = "预约起始";
            // 
            // dtpBouDate
            // 
            this.dtpBouDate.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpBouDate.Location = new System.Drawing.Point(151, 238);
            this.dtpBouDate.Name = "dtpBouDate";
            this.dtpBouDate.Size = new System.Drawing.Size(137, 27);
            this.dtpBouDate.TabIndex = 61;
            this.dtpBouDate.Validated += new System.EventHandler(this.dtpBouDate_Validated_1);
            // 
            // txtCustoName
            // 
            this.txtCustoName.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCustoName.Location = new System.Drawing.Point(151, 96);
            this.txtCustoName.Name = "txtCustoName";
            this.txtCustoName.Size = new System.Drawing.Size(137, 27);
            this.txtCustoName.TabIndex = 58;
            // 
            // cboReserWay
            // 
            this.cboReserWay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReserWay.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboReserWay.FormattingEnabled = true;
            this.cboReserWay.Items.AddRange(new object[] {
            "前台"});
            this.cboReserWay.Location = new System.Drawing.Point(151, 166);
            this.cboReserWay.Name = "cboReserWay";
            this.cboReserWay.Size = new System.Drawing.Size(137, 28);
            this.cboReserWay.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(81, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 55;
            this.label3.Text = "预约号码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(81, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 54;
            this.label2.Text = "客户姓名";
            // 
            // txtCustoTel
            // 
            this.txtCustoTel.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCustoTel.Location = new System.Drawing.Point(151, 131);
            this.txtCustoTel.Name = "txtCustoTel";
            this.txtCustoTel.Size = new System.Drawing.Size(137, 27);
            this.txtCustoTel.TabIndex = 59;
            // 
            // btnReserList
            // 
            this.btnReserList.FlatAppearance.BorderSize = 0;
            this.btnReserList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReserList.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReserList.Location = new System.Drawing.Point(114, 55);
            this.btnReserList.Name = "btnReserList";
            this.btnReserList.Size = new System.Drawing.Size(128, 25);
            this.btnReserList.TabIndex = 71;
            this.btnReserList.Text = "预约列表";
            this.btnReserList.UseVisualStyleBackColor = true;
            this.btnReserList.Click += new System.EventHandler(this.btnReserList_Click);
            // 
            // FrmReserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(352, 456);
            this.Controls.Add(this.btnReserList);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnReser);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboReserRoomNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpBouDate);
            this.Controls.Add(this.txtCustoName);
            this.Controls.Add(this.cboReserWay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCustoTel);
            this.Controls.Add(this.label14);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReserManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "预约管理";
            this.Load += new System.EventHandler(this.FrmRoomManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnReser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboReserRoomNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpBouDate;
        private System.Windows.Forms.TextBox txtCustoName;
        private System.Windows.Forms.ComboBox cboReserWay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustoTel;
        private System.Windows.Forms.Button btnReserList;
    }
}