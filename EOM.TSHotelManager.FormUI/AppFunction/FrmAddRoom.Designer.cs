namespace EOM.TSHotelManager.FormUI
{
    partial class FrmAddRoom
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddRoom));
            flpRoom = new System.Windows.Forms.FlowLayoutPanel();
            ttTips = new Sunny.UI.UIToolTip(components);
            txtRoomPosition = new AntdUI.Input();
            label5 = new AntdUI.Label();
            txtRoomNo = new AntdUI.Input();
            label7 = new AntdUI.Label();
            label8 = new AntdUI.Label();
            txtMoney = new AntdUI.InputNumber();
            label9 = new AntdUI.Label();
            cboRoomType = new AntdUI.Select();
            txtDeposit = new AntdUI.InputNumber();
            label10 = new AntdUI.Label();
            btnAddRoom = new AntdUI.Button();
            windowBar1 = new AntdUI.WindowBar();
            SuspendLayout();
            // 
            // flpRoom
            // 
            flpRoom.AutoScroll = true;
            flpRoom.BackColor = System.Drawing.Color.Transparent;
            flpRoom.Location = new System.Drawing.Point(83, 56);
            flpRoom.Name = "flpRoom";
            flpRoom.Size = new System.Drawing.Size(838, 424);
            flpRoom.TabIndex = 116;
            flpRoom.MouseEnter += flpRoom_MouseEnter;
            // 
            // ttTips
            // 
            ttTips.BackColor = System.Drawing.Color.FromArgb(54, 54, 54);
            ttTips.ForeColor = System.Drawing.Color.FromArgb(239, 239, 239);
            ttTips.OwnerDraw = true;
            // 
            // txtRoomPosition
            // 
            txtRoomPosition.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            txtRoomPosition.Location = new System.Drawing.Point(493, 500);
            txtRoomPosition.Name = "txtRoomPosition";
            txtRoomPosition.PasswordChar = '*';
            txtRoomPosition.PasswordCopy = true;
            txtRoomPosition.PlaceholderText = "房间位置...";
            txtRoomPosition.Size = new System.Drawing.Size(127, 39);
            txtRoomPosition.TabIndex = 129;
            // 
            // label5
            // 
            label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            label5.Location = new System.Drawing.Point(385, 508);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(86, 23);
            label5.TabIndex = 128;
            label5.Text = "房间位置";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRoomNo
            // 
            txtRoomNo.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            txtRoomNo.Location = new System.Drawing.Point(238, 500);
            txtRoomNo.Name = "txtRoomNo";
            txtRoomNo.PlaceholderText = "房号...";
            txtRoomNo.Size = new System.Drawing.Size(127, 39);
            txtRoomNo.TabIndex = 127;
            txtRoomNo.Validated += txtRoomNo_Validated;
            // 
            // label7
            // 
            label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            label7.Location = new System.Drawing.Point(130, 508);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(86, 23);
            label7.TabIndex = 126;
            label7.Text = "房间编号";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            label8.Location = new System.Drawing.Point(640, 508);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(86, 23);
            label8.TabIndex = 130;
            label8.Text = "房间单价";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMoney
            // 
            txtMoney.DecimalPlaces = 2;
            txtMoney.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            txtMoney.Location = new System.Drawing.Point(748, 500);
            txtMoney.Name = "txtMoney";
            txtMoney.PlaceholderText = "房间单价...";
            txtMoney.Size = new System.Drawing.Size(127, 39);
            txtMoney.TabIndex = 131;
            txtMoney.Text = "0.00";
            // 
            // label9
            // 
            label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            label9.Location = new System.Drawing.Point(130, 572);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(86, 23);
            label9.TabIndex = 132;
            label9.Text = "房间类型";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboRoomType
            // 
            cboRoomType.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            cboRoomType.Location = new System.Drawing.Point(238, 562);
            cboRoomType.Name = "cboRoomType";
            cboRoomType.Size = new System.Drawing.Size(127, 39);
            cboRoomType.TabIndex = 133;
            cboRoomType.TextChanged += cboRoomType_TextChanged;
            // 
            // txtDeposit
            // 
            txtDeposit.DecimalPlaces = 2;
            txtDeposit.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            txtDeposit.Location = new System.Drawing.Point(493, 562);
            txtDeposit.Name = "txtDeposit";
            txtDeposit.PlaceholderText = "房间单价...";
            txtDeposit.Size = new System.Drawing.Size(127, 39);
            txtDeposit.TabIndex = 135;
            txtDeposit.Text = "0.00";
            // 
            // label10
            // 
            label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            label10.Location = new System.Drawing.Point(385, 570);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(86, 23);
            label10.TabIndex = 134;
            label10.Text = "房间押金";
            label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddRoom
            // 
            btnAddRoom.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnAddRoom.Location = new System.Drawing.Point(748, 562);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.Size = new System.Drawing.Size(127, 39);
            btnAddRoom.TabIndex = 136;
            btnAddRoom.Text = "新增客房";
            btnAddRoom.Type = AntdUI.TTypeMini.Primary;
            btnAddRoom.Click += btnAddRoom_Click;
            // 
            // windowBar1
            // 
            windowBar1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            windowBar1.Icon = (System.Drawing.Image)resources.GetObject("windowBar1.Icon");
            windowBar1.Location = new System.Drawing.Point(1, 3);
            windowBar1.MaximizeBox = false;
            windowBar1.MinimizeBox = false;
            windowBar1.Name = "windowBar1";
            windowBar1.Size = new System.Drawing.Size(999, 40);
            windowBar1.TabIndex = 137;
            windowBar1.Text = "新增客房";
            // 
            // FrmAddRoom
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            BackColor = System.Drawing.Color.FromArgb(235, 243, 255);
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1001, 623);
            ControlBox = false;
            Controls.Add(windowBar1);
            Controls.Add(btnAddRoom);
            Controls.Add(txtDeposit);
            Controls.Add(label10);
            Controls.Add(cboRoomType);
            Controls.Add(label9);
            Controls.Add(txtMoney);
            Controls.Add(label8);
            Controls.Add(txtRoomPosition);
            Controls.Add(label5);
            Controls.Add(txtRoomNo);
            Controls.Add(label7);
            Controls.Add(flpRoom);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAddRoom";
            Text = "新增客房";
            Load += FrmAddRoom_Load;
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpRoom;
        private Sunny.UI.UIToolTip ttTips;
        private AntdUI.Input txtRoomPosition;
        private AntdUI.Label label5;
        private AntdUI.Input txtRoomNo;
        private AntdUI.Label label7;
        private AntdUI.Label label8;
        private AntdUI.InputNumber txtMoney;
        private AntdUI.Label label9;
        private AntdUI.Select cboRoomType;
        private AntdUI.InputNumber txtDeposit;
        private AntdUI.Label label10;
        private AntdUI.Button btnAddRoom;
        private AntdUI.WindowBar windowBar1;
    }
}