namespace SYS.FormUI
{
    partial class FrmCheckIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCheckIn));
            this.txtCustoNo = new Sunny.UI.UITextBox();
            this.txtCustoTel = new Sunny.UI.UITextBox();
            this.txtCustoType = new Sunny.UI.UITextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCustoName = new Sunny.UI.UITextBox();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.txtRoomPosition = new Sunny.UI.UITextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtType = new Sunny.UI.UIComboBox();
            this.txtRoomNo = new Sunny.UI.UITextBox();
            this.txtState = new Sunny.UI.UITextBox();
            this.txtMoney = new Sunny.UI.UITextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnCheckIn = new Sunny.UI.UIButton();
            this.btnClose = new Sunny.UI.UIButton();
            this.uiGroupBox1.SuspendLayout();
            this.uiGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCustoNo
            // 
            this.txtCustoNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCustoNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCustoNo.BackColor = System.Drawing.Color.Transparent;
            this.txtCustoNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustoNo.FillColor = System.Drawing.Color.White;
            this.txtCustoNo.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCustoNo.Location = new System.Drawing.Point(145, 53);
            this.txtCustoNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustoNo.Maximum = 2147483647D;
            this.txtCustoNo.Minimum = -2147483648D;
            this.txtCustoNo.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtCustoNo.Name = "txtCustoNo";
            this.txtCustoNo.Padding = new System.Windows.Forms.Padding(5);
            this.txtCustoNo.Radius = 20;
            this.txtCustoNo.Size = new System.Drawing.Size(250, 35);
            this.txtCustoNo.Style = Sunny.UI.UIStyle.Custom;
            this.txtCustoNo.StyleCustomMode = true;
            this.txtCustoNo.TabIndex = 135;
            this.txtCustoNo.TextChanged += new System.EventHandler(this.txtCustoNo_TextChanged);
            this.txtCustoNo.Validated += new System.EventHandler(this.txtCustoNo_Validated);
            // 
            // txtCustoTel
            // 
            this.txtCustoTel.BackColor = System.Drawing.Color.Transparent;
            this.txtCustoTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustoTel.FillColor = System.Drawing.Color.White;
            this.txtCustoTel.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCustoTel.Location = new System.Drawing.Point(145, 108);
            this.txtCustoTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustoTel.Maximum = 2147483647D;
            this.txtCustoTel.Minimum = -2147483648D;
            this.txtCustoTel.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtCustoTel.Name = "txtCustoTel";
            this.txtCustoTel.Padding = new System.Windows.Forms.Padding(5);
            this.txtCustoTel.Radius = 20;
            this.txtCustoTel.ReadOnly = true;
            this.txtCustoTel.Size = new System.Drawing.Size(250, 35);
            this.txtCustoTel.Style = Sunny.UI.UIStyle.Custom;
            this.txtCustoTel.StyleCustomMode = true;
            this.txtCustoTel.TabIndex = 134;
            // 
            // txtCustoType
            // 
            this.txtCustoType.BackColor = System.Drawing.Color.Transparent;
            this.txtCustoType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustoType.FillColor = System.Drawing.Color.White;
            this.txtCustoType.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCustoType.Location = new System.Drawing.Point(521, 109);
            this.txtCustoType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustoType.Maximum = 2147483647D;
            this.txtCustoType.Minimum = -2147483648D;
            this.txtCustoType.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtCustoType.Name = "txtCustoType";
            this.txtCustoType.Padding = new System.Windows.Forms.Padding(5);
            this.txtCustoType.Radius = 20;
            this.txtCustoType.ReadOnly = true;
            this.txtCustoType.Size = new System.Drawing.Size(250, 35);
            this.txtCustoType.Style = Sunny.UI.UIStyle.Custom;
            this.txtCustoType.StyleCustomMode = true;
            this.txtCustoType.TabIndex = 133;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(417, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 25);
            this.label12.TabIndex = 132;
            this.label12.Text = "会员等级";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(417, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 25);
            this.label14.TabIndex = 131;
            this.label14.Text = "客户姓名";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(38, 112);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 25);
            this.label16.TabIndex = 130;
            this.label16.Text = "客户电话";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(38, 60);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 25);
            this.label18.TabIndex = 129;
            this.label18.Text = "客户编号";
            // 
            // txtCustoName
            // 
            this.txtCustoName.BackColor = System.Drawing.Color.Transparent;
            this.txtCustoName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustoName.FillColor = System.Drawing.Color.White;
            this.txtCustoName.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCustoName.Location = new System.Drawing.Point(521, 53);
            this.txtCustoName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustoName.Maximum = 2147483647D;
            this.txtCustoName.Minimum = -2147483648D;
            this.txtCustoName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtCustoName.Name = "txtCustoName";
            this.txtCustoName.Padding = new System.Windows.Forms.Padding(5);
            this.txtCustoName.Radius = 20;
            this.txtCustoName.ReadOnly = true;
            this.txtCustoName.Size = new System.Drawing.Size(250, 35);
            this.txtCustoName.Style = Sunny.UI.UIStyle.Custom;
            this.txtCustoName.StyleCustomMode = true;
            this.txtCustoName.TabIndex = 136;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.txtCustoNo);
            this.uiGroupBox1.Controls.Add(this.txtCustoName);
            this.uiGroupBox1.Controls.Add(this.label18);
            this.uiGroupBox1.Controls.Add(this.label16);
            this.uiGroupBox1.Controls.Add(this.txtCustoTel);
            this.uiGroupBox1.Controls.Add(this.label14);
            this.uiGroupBox1.Controls.Add(this.txtCustoType);
            this.uiGroupBox1.Controls.Add(this.label12);
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox1.Location = new System.Drawing.Point(24, 282);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(812, 164);
            this.uiGroupBox1.Style = Sunny.UI.UIStyle.Custom;
            this.uiGroupBox1.TabIndex = 137;
            this.uiGroupBox1.Text = "用户信息CustomerInformation";
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.txtRoomPosition);
            this.uiGroupBox2.Controls.Add(this.label3);
            this.uiGroupBox2.Controls.Add(this.txtType);
            this.uiGroupBox2.Controls.Add(this.txtRoomNo);
            this.uiGroupBox2.Controls.Add(this.txtState);
            this.uiGroupBox2.Controls.Add(this.txtMoney);
            this.uiGroupBox2.Controls.Add(this.label13);
            this.uiGroupBox2.Controls.Add(this.label15);
            this.uiGroupBox2.Controls.Add(this.label19);
            this.uiGroupBox2.Controls.Add(this.label20);
            this.uiGroupBox2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox2.Location = new System.Drawing.Point(24, 56);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.Size = new System.Drawing.Size(812, 205);
            this.uiGroupBox2.Style = Sunny.UI.UIStyle.Custom;
            this.uiGroupBox2.TabIndex = 138;
            this.uiGroupBox2.Text = "房间信息RoomInformation";
            // 
            // txtRoomPosition
            // 
            this.txtRoomPosition.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomPosition.FillColor = System.Drawing.Color.White;
            this.txtRoomPosition.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRoomPosition.Location = new System.Drawing.Point(146, 150);
            this.txtRoomPosition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoomPosition.Maximum = 2147483647D;
            this.txtRoomPosition.Minimum = -2147483648D;
            this.txtRoomPosition.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtRoomPosition.Name = "txtRoomPosition";
            this.txtRoomPosition.Padding = new System.Windows.Forms.Padding(5);
            this.txtRoomPosition.Radius = 20;
            this.txtRoomPosition.ReadOnly = true;
            this.txtRoomPosition.Size = new System.Drawing.Size(628, 35);
            this.txtRoomPosition.Style = Sunny.UI.UIStyle.Custom;
            this.txtRoomPosition.StyleCustomMode = true;
            this.txtRoomPosition.TabIndex = 138;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(39, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 137;
            this.label3.Text = "房间位置";
            // 
            // txtType
            // 
            this.txtType.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.txtType.FillColor = System.Drawing.Color.White;
            this.txtType.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.txtType.Location = new System.Drawing.Point(523, 42);
            this.txtType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtType.MinimumSize = new System.Drawing.Size(63, 0);
            this.txtType.Name = "txtType";
            this.txtType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.txtType.Radius = 20;
            this.txtType.Size = new System.Drawing.Size(250, 35);
            this.txtType.Style = Sunny.UI.UIStyle.Custom;
            this.txtType.TabIndex = 136;
            this.txtType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtType.Watermark = "";
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomNo.FillColor = System.Drawing.Color.White;
            this.txtRoomNo.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRoomNo.Location = new System.Drawing.Point(147, 42);
            this.txtRoomNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoomNo.Maximum = 2147483647D;
            this.txtRoomNo.Minimum = -2147483648D;
            this.txtRoomNo.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Padding = new System.Windows.Forms.Padding(5);
            this.txtRoomNo.Radius = 20;
            this.txtRoomNo.ReadOnly = true;
            this.txtRoomNo.Size = new System.Drawing.Size(250, 35);
            this.txtRoomNo.Style = Sunny.UI.UIStyle.Custom;
            this.txtRoomNo.StyleCustomMode = true;
            this.txtRoomNo.TabIndex = 135;
            // 
            // txtState
            // 
            this.txtState.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtState.FillColor = System.Drawing.Color.White;
            this.txtState.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtState.Location = new System.Drawing.Point(147, 97);
            this.txtState.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtState.Maximum = 2147483647D;
            this.txtState.Minimum = -2147483648D;
            this.txtState.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtState.Name = "txtState";
            this.txtState.Padding = new System.Windows.Forms.Padding(5);
            this.txtState.Radius = 20;
            this.txtState.ReadOnly = true;
            this.txtState.Size = new System.Drawing.Size(250, 35);
            this.txtState.Style = Sunny.UI.UIStyle.Custom;
            this.txtState.StyleCustomMode = true;
            this.txtState.TabIndex = 134;
            // 
            // txtMoney
            // 
            this.txtMoney.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoney.FillColor = System.Drawing.Color.White;
            this.txtMoney.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMoney.Location = new System.Drawing.Point(523, 98);
            this.txtMoney.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMoney.Maximum = 2147483647D;
            this.txtMoney.Minimum = -2147483648D;
            this.txtMoney.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Padding = new System.Windows.Forms.Padding(5);
            this.txtMoney.Radius = 20;
            this.txtMoney.ReadOnly = true;
            this.txtMoney.Size = new System.Drawing.Size(250, 35);
            this.txtMoney.Style = Sunny.UI.UIStyle.Custom;
            this.txtMoney.StyleCustomMode = true;
            this.txtMoney.TabIndex = 133;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(419, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 25);
            this.label13.TabIndex = 132;
            this.label13.Text = "房间单价";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(419, 49);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 25);
            this.label15.TabIndex = 131;
            this.label15.Text = "房间类型";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(40, 101);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 25);
            this.label19.TabIndex = 130;
            this.label19.Text = "房间状态";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(40, 49);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(88, 25);
            this.label20.TabIndex = 129;
            this.label20.Text = "房间编号";
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckIn.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnCheckIn.Location = new System.Drawing.Point(214, 463);
            this.btnCheckIn.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Radius = 30;
            this.btnCheckIn.Size = new System.Drawing.Size(137, 46);
            this.btnCheckIn.Style = Sunny.UI.UIStyle.Custom;
            this.btnCheckIn.TabIndex = 139;
            this.btnCheckIn.Text = "入    住";
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnClose.Location = new System.Drawing.Point(509, 463);
            this.btnClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Radius = 30;
            this.btnClose.Size = new System.Drawing.Size(137, 46);
            this.btnClose.Style = Sunny.UI.UIStyle.Custom;
            this.btnClose.TabIndex = 140;
            this.btnClose.Text = "关    闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(861, 528);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.uiGroupBox2);
            this.EscClose = false;
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsForbidAltF4 = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCheckIn";
            this.ShowIcon = true;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "房间入住CheckIn Room";
            this.Load += new System.EventHandler(this.FrmCheckIn_Load);
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            this.uiGroupBox2.ResumeLayout(false);
            this.uiGroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UITextBox txtCustoNo;
        private Sunny.UI.UITextBox txtCustoTel;
        private Sunny.UI.UITextBox txtCustoType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private Sunny.UI.UITextBox txtCustoName;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UITextBox txtRoomPosition;
        private System.Windows.Forms.Label label3;
        private Sunny.UI.UIComboBox txtType;
        private Sunny.UI.UITextBox txtRoomNo;
        private Sunny.UI.UITextBox txtState;
        private Sunny.UI.UITextBox txtMoney;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private Sunny.UI.UIButton btnCheckIn;
        private Sunny.UI.UIButton btnClose;
    }
}