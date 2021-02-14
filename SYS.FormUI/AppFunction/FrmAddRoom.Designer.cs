namespace SYS.FormUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddRoom));
            this.txtRoomNo = new Sunny.UI.UITextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRoomPosition = new Sunny.UI.UITextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMoney = new Sunny.UI.UITextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboRoomType = new Sunny.UI.UIComboBox();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddRoom = new Sunny.UI.UIButton();
            this.flpRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomNo.FillColor = System.Drawing.Color.White;
            this.txtRoomNo.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRoomNo.Location = new System.Drawing.Point(238, 501);
            this.txtRoomNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoomNo.Maximum = 2147483647D;
            this.txtRoomNo.Minimum = -2147483648D;
            this.txtRoomNo.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Padding = new System.Windows.Forms.Padding(5);
            this.txtRoomNo.Radius = 20;
            this.txtRoomNo.Size = new System.Drawing.Size(127, 35);
            this.txtRoomNo.Style = Sunny.UI.UIStyle.Custom;
            this.txtRoomNo.StyleCustomMode = true;
            this.txtRoomNo.TabIndex = 106;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(130, 507);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 105;
            this.label3.Text = "房间编号";
            // 
            // txtRoomPosition
            // 
            this.txtRoomPosition.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomPosition.FillColor = System.Drawing.Color.White;
            this.txtRoomPosition.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRoomPosition.Location = new System.Drawing.Point(493, 501);
            this.txtRoomPosition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoomPosition.Maximum = 2147483647D;
            this.txtRoomPosition.Minimum = -2147483648D;
            this.txtRoomPosition.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtRoomPosition.Name = "txtRoomPosition";
            this.txtRoomPosition.Padding = new System.Windows.Forms.Padding(5);
            this.txtRoomPosition.Radius = 20;
            this.txtRoomPosition.Size = new System.Drawing.Size(127, 35);
            this.txtRoomPosition.Style = Sunny.UI.UIStyle.Custom;
            this.txtRoomPosition.StyleCustomMode = true;
            this.txtRoomPosition.TabIndex = 108;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(385, 507);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 107;
            this.label1.Text = "房间位置";
            // 
            // txtMoney
            // 
            this.txtMoney.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoney.FillColor = System.Drawing.Color.White;
            this.txtMoney.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMoney.Location = new System.Drawing.Point(748, 501);
            this.txtMoney.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMoney.Maximum = 2147483647D;
            this.txtMoney.Minimum = -2147483648D;
            this.txtMoney.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Padding = new System.Windows.Forms.Padding(5);
            this.txtMoney.Radius = 20;
            this.txtMoney.Size = new System.Drawing.Size(127, 35);
            this.txtMoney.Style = Sunny.UI.UIStyle.Custom;
            this.txtMoney.StyleCustomMode = true;
            this.txtMoney.TabIndex = 110;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(640, 507);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 109;
            this.label4.Text = "房间单价";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(130, 568);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 111;
            this.label6.Text = "房间类型";
            // 
            // cboRoomType
            // 
            this.cboRoomType.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cboRoomType.FillColor = System.Drawing.Color.White;
            this.cboRoomType.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.cboRoomType.Location = new System.Drawing.Point(238, 564);
            this.cboRoomType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboRoomType.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboRoomType.Name = "cboRoomType";
            this.cboRoomType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cboRoomType.Radius = 20;
            this.cboRoomType.Size = new System.Drawing.Size(184, 35);
            this.cboRoomType.TabIndex = 112;
            this.cboRoomType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboRoomType.TextChanged += new System.EventHandler(this.cboRoomType_TextChanged);
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.FillColor = System.Drawing.Color.White;
            this.uiTextBox1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox1.Location = new System.Drawing.Point(553, 564);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.Maximum = 2147483647D;
            this.uiTextBox1.Minimum = -2147483648D;
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox1.Radius = 20;
            this.uiTextBox1.ReadOnly = true;
            this.uiTextBox1.Size = new System.Drawing.Size(128, 35);
            this.uiTextBox1.Style = Sunny.UI.UIStyle.Custom;
            this.uiTextBox1.StyleCustomMode = true;
            this.uiTextBox1.TabIndex = 114;
            this.uiTextBox1.Text = "空房";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(448, 568);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 113;
            this.label2.Text = "房间状态";
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRoom.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnAddRoom.Location = new System.Drawing.Point(723, 564);
            this.btnAddRoom.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Radius = 30;
            this.btnAddRoom.Size = new System.Drawing.Size(152, 35);
            this.btnAddRoom.TabIndex = 115;
            this.btnAddRoom.Text = "新增客房";
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // flpRoom
            // 
            this.flpRoom.AutoScroll = true;
            this.flpRoom.BackColor = System.Drawing.Color.Transparent;
            this.flpRoom.Location = new System.Drawing.Point(83, 56);
            this.flpRoom.Name = "flpRoom";
            this.flpRoom.Size = new System.Drawing.Size(838, 424);
            this.flpRoom.TabIndex = 116;
            // 
            // FrmAddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1005, 623);
            this.ControlBox = false;
            this.Controls.Add(this.flpRoom);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.uiTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboRoomType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRoomPosition);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRoomNo);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddRoom";
            this.ShowIcon = true;
            this.Text = "新增客房";
            this.Load += new System.EventHandler(this.FrmAddRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UITextBox txtRoomNo;
        private System.Windows.Forms.Label label3;
        private Sunny.UI.UITextBox txtRoomPosition;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UITextBox txtMoney;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private Sunny.UI.UIComboBox cboRoomType;
        private Sunny.UI.UITextBox uiTextBox1;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UIButton btnAddRoom;
        private System.Windows.Forms.FlowLayoutPanel flpRoom;
    }
}