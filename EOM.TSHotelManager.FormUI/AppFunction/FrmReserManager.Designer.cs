namespace EOM.TSHotelManager.FormUI
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
            this.btnReserList = new Sunny.UI.UIButton();
            this.txtCustoName = new Sunny.UI.UITextBox();
            this.txtCustoTel = new Sunny.UI.UITextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboReserWay = new Sunny.UI.UIComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboReserRoomNo = new Sunny.UI.UIComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpBouDate = new Sunny.UI.UIDatePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpEndDate = new Sunny.UI.UIDatePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.btnReser = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // btnReserList
            // 
            this.btnReserList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReserList.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnReserList.Location = new System.Drawing.Point(89, 50);
            this.btnReserList.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnReserList.Name = "btnReserList";
            this.btnReserList.Radius = 15;
            this.btnReserList.Size = new System.Drawing.Size(136, 35);
            this.btnReserList.Style = Sunny.UI.UIStyle.Custom;
            this.btnReserList.TabIndex = 72;
            this.btnReserList.Text = "查看预约列表";
            this.btnReserList.Click += new System.EventHandler(this.btnReserList_Click);
            // 
            // txtCustoName
            // 
            this.txtCustoName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustoName.FillColor = System.Drawing.Color.White;
            this.txtCustoName.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCustoName.Location = new System.Drawing.Point(122, 94);
            this.txtCustoName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustoName.Maximum = 2147483647D;
            this.txtCustoName.Minimum = -2147483648D;
            this.txtCustoName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtCustoName.Name = "txtCustoName";
            this.txtCustoName.Padding = new System.Windows.Forms.Padding(5);
            this.txtCustoName.Radius = 20;
            this.txtCustoName.Size = new System.Drawing.Size(159, 35);
            this.txtCustoName.Style = Sunny.UI.UIStyle.Custom;
            this.txtCustoName.StyleCustomMode = true;
            this.txtCustoName.TabIndex = 107;
            this.txtCustoName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCustoTel
            // 
            this.txtCustoTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustoTel.FillColor = System.Drawing.Color.White;
            this.txtCustoTel.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCustoTel.Location = new System.Drawing.Point(122, 147);
            this.txtCustoTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustoTel.Maximum = 2147483647D;
            this.txtCustoTel.MaxLength = 11;
            this.txtCustoTel.Minimum = -2147483648D;
            this.txtCustoTel.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtCustoTel.Name = "txtCustoTel";
            this.txtCustoTel.Padding = new System.Windows.Forms.Padding(5);
            this.txtCustoTel.Radius = 20;
            this.txtCustoTel.Size = new System.Drawing.Size(159, 35);
            this.txtCustoTel.Style = Sunny.UI.UIStyle.Custom;
            this.txtCustoTel.StyleCustomMode = true;
            this.txtCustoTel.TabIndex = 108;
            this.txtCustoTel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(30, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 106;
            this.label1.Text = "预约号码";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(30, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 25);
            this.label9.TabIndex = 105;
            this.label9.Text = "客户姓名";
            // 
            // cboReserWay
            // 
            this.cboReserWay.DataSource = null;
            this.cboReserWay.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cboReserWay.FillColor = System.Drawing.Color.White;
            this.cboReserWay.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.cboReserWay.Items.AddRange(new object[] {
            "前台",
            "小程序",
            "电话"});
            this.cboReserWay.Location = new System.Drawing.Point(122, 200);
            this.cboReserWay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboReserWay.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboReserWay.Name = "cboReserWay";
            this.cboReserWay.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboReserWay.Radius = 20;
            this.cboReserWay.ReadOnly = true;
            this.cboReserWay.Size = new System.Drawing.Size(159, 35);
            this.cboReserWay.Style = Sunny.UI.UIStyle.Custom;
            this.cboReserWay.TabIndex = 110;
            this.cboReserWay.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboReserWay.Watermark = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(33, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 25);
            this.label10.TabIndex = 109;
            this.label10.Text = "预约渠道";
            // 
            // cboReserRoomNo
            // 
            this.cboReserRoomNo.DataSource = null;
            this.cboReserRoomNo.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cboReserRoomNo.FillColor = System.Drawing.Color.White;
            this.cboReserRoomNo.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.cboReserRoomNo.Location = new System.Drawing.Point(122, 253);
            this.cboReserRoomNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboReserRoomNo.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboReserRoomNo.Name = "cboReserRoomNo";
            this.cboReserRoomNo.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboReserRoomNo.Radius = 20;
            this.cboReserRoomNo.Size = new System.Drawing.Size(159, 35);
            this.cboReserRoomNo.Style = Sunny.UI.UIStyle.Custom;
            this.cboReserRoomNo.TabIndex = 112;
            this.cboReserRoomNo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboReserRoomNo.Watermark = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(33, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 25);
            this.label11.TabIndex = 111;
            this.label11.Text = "预约房号";
            // 
            // dtpBouDate
            // 
            this.dtpBouDate.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.dtpBouDate.FillColor = System.Drawing.Color.White;
            this.dtpBouDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.dtpBouDate.Location = new System.Drawing.Point(122, 307);
            this.dtpBouDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpBouDate.MaxLength = 10;
            this.dtpBouDate.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtpBouDate.Name = "dtpBouDate";
            this.dtpBouDate.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dtpBouDate.Radius = 20;
            this.dtpBouDate.Size = new System.Drawing.Size(159, 31);
            this.dtpBouDate.Style = Sunny.UI.UIStyle.Custom;
            this.dtpBouDate.SymbolDropDown = 61555;
            this.dtpBouDate.SymbolNormal = 61555;
            this.dtpBouDate.TabIndex = 114;
            this.dtpBouDate.Text = "2021-05-13";
            this.dtpBouDate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtpBouDate.Value = new System.DateTime(2021, 5, 13, 0, 0, 0, 0);
            this.dtpBouDate.ValueChanged += new Sunny.UI.UIDatePicker.OnDateTimeChanged(this.dtpBouDate_ValueChanged);
            this.dtpBouDate.TextChanged += new System.EventHandler(this.dtpBouDate_TextChanged);
            this.dtpBouDate.Validated += new System.EventHandler(this.dtpBouDate_Validated);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(30, 307);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 25);
            this.label12.TabIndex = 113;
            this.label12.Text = "预约起始";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.dtpEndDate.FillColor = System.Drawing.Color.White;
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.dtpEndDate.Location = new System.Drawing.Point(125, 356);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpEndDate.MaxLength = 10;
            this.dtpEndDate.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dtpEndDate.Radius = 20;
            this.dtpEndDate.ReadOnly = true;
            this.dtpEndDate.Size = new System.Drawing.Size(156, 31);
            this.dtpEndDate.Style = Sunny.UI.UIStyle.Custom;
            this.dtpEndDate.SymbolDropDown = 61555;
            this.dtpEndDate.SymbolNormal = 61555;
            this.dtpEndDate.TabIndex = 116;
            this.dtpEndDate.Text = "2021-05-13";
            this.dtpEndDate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtpEndDate.Value = new System.DateTime(2021, 5, 13, 0, 0, 0, 0);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(33, 359);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 25);
            this.label13.TabIndex = 115;
            this.label13.Text = "预约止日";
            // 
            // btnReser
            // 
            this.btnReser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReser.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnReser.Location = new System.Drawing.Point(109, 411);
            this.btnReser.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnReser.Name = "btnReser";
            this.btnReser.Radius = 15;
            this.btnReser.Size = new System.Drawing.Size(97, 35);
            this.btnReser.Style = Sunny.UI.UIStyle.Custom;
            this.btnReser.TabIndex = 117;
            this.btnReser.Text = "预约";
            this.btnReser.Click += new System.EventHandler(this.btnReser_Click);
            // 
            // FrmReserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(315, 461);
            this.Controls.Add(this.btnReser);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtpBouDate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cboReserRoomNo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cboReserWay);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCustoName);
            this.Controls.Add(this.txtCustoTel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnReserList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReserManager";
            this.ShowIcon = true;
            this.ShowTitleIcon = true;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "预约管理";
            this.Load += new System.EventHandler(this.FrmRoomManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UIButton btnReserList;
        private Sunny.UI.UITextBox txtCustoName;
        private Sunny.UI.UITextBox txtCustoTel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private Sunny.UI.UIComboBox cboReserWay;
        private System.Windows.Forms.Label label10;
        private Sunny.UI.UIComboBox cboReserRoomNo;
        private System.Windows.Forms.Label label11;
        private Sunny.UI.UIDatePicker dtpBouDate;
        private System.Windows.Forms.Label label12;
        private Sunny.UI.UIDatePicker dtpEndDate;
        private System.Windows.Forms.Label label13;
        private Sunny.UI.UIButton btnReser;
    }
}