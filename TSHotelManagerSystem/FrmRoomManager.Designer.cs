namespace TSHotelManagerSystem
{
    partial class FrmRoomManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRoomManager));
            this.flpRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlRoomState = new System.Windows.Forms.Panel();
            this.lblFix = new System.Windows.Forms.Label();
            this.lblNotClear = new System.Windows.Forms.Label();
            this.lblCheck = new System.Windows.Forms.Label();
            this.lblCanUse = new System.Windows.Forms.Label();
            this.pnlRoomInfo = new System.Windows.Forms.Panel();
            this.lblRoomState = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.lblCustoNo = new System.Windows.Forms.Label();
            this.lblRoomPosition = new System.Windows.Forms.Label();
            this.lblCheckTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrGetData = new System.Windows.Forms.Timer(this.components);
            this.picRefrech = new System.Windows.Forms.PictureBox();
            this.btnZT = new System.Windows.Forms.Button();
            this.btnQL = new System.Windows.Forms.Button();
            this.btnHS = new System.Windows.Forms.Button();
            this.btnHD = new System.Windows.Forms.Button();
            this.btnBS = new System.Windows.Forms.Button();
            this.btnBD = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlRoomState.SuspendLayout();
            this.pnlRoomInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRefrech)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flpRoom
            // 
            this.flpRoom.AutoScroll = true;
            this.flpRoom.BackColor = System.Drawing.Color.White;
            this.flpRoom.Location = new System.Drawing.Point(168, 27);
            this.flpRoom.Name = "flpRoom";
            this.flpRoom.Size = new System.Drawing.Size(824, 415);
            this.flpRoom.TabIndex = 71;
            // 
            // pnlRoomState
            // 
            this.pnlRoomState.BackColor = System.Drawing.Color.Transparent;
            this.pnlRoomState.Controls.Add(this.lblFix);
            this.pnlRoomState.Controls.Add(this.pictureBox4);
            this.pnlRoomState.Controls.Add(this.lblNotClear);
            this.pnlRoomState.Controls.Add(this.lblCheck);
            this.pnlRoomState.Controls.Add(this.lblCanUse);
            this.pnlRoomState.Controls.Add(this.pictureBox3);
            this.pnlRoomState.Controls.Add(this.pictureBox2);
            this.pnlRoomState.Controls.Add(this.pictureBox1);
            this.pnlRoomState.Location = new System.Drawing.Point(2, 3);
            this.pnlRoomState.Name = "pnlRoomState";
            this.pnlRoomState.Size = new System.Drawing.Size(164, 188);
            this.pnlRoomState.TabIndex = 5;
            // 
            // lblFix
            // 
            this.lblFix.AutoSize = true;
            this.lblFix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(167)))), ((int)(((byte)(203)))));
            this.lblFix.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.lblFix.ForeColor = System.Drawing.Color.Black;
            this.lblFix.Location = new System.Drawing.Point(128, 153);
            this.lblFix.Name = "lblFix";
            this.lblFix.Size = new System.Drawing.Size(17, 16);
            this.lblFix.TabIndex = 13;
            this.lblFix.Text = "0";
            // 
            // lblNotClear
            // 
            this.lblNotClear.AutoSize = true;
            this.lblNotClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(138)))));
            this.lblNotClear.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.lblNotClear.Location = new System.Drawing.Point(128, 108);
            this.lblNotClear.Name = "lblNotClear";
            this.lblNotClear.Size = new System.Drawing.Size(17, 16);
            this.lblNotClear.TabIndex = 11;
            this.lblNotClear.Text = "0";
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(96)))));
            this.lblCheck.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.lblCheck.Location = new System.Drawing.Point(128, 63);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(17, 16);
            this.lblCheck.TabIndex = 10;
            this.lblCheck.Text = "0";
            // 
            // lblCanUse
            // 
            this.lblCanUse.AutoSize = true;
            this.lblCanUse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.lblCanUse.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCanUse.Location = new System.Drawing.Point(128, 17);
            this.lblCanUse.Name = "lblCanUse";
            this.lblCanUse.Size = new System.Drawing.Size(17, 16);
            this.lblCanUse.TabIndex = 9;
            this.lblCanUse.Text = "0";
            // 
            // pnlRoomInfo
            // 
            this.pnlRoomInfo.Controls.Add(this.lblRoomState);
            this.pnlRoomInfo.Controls.Add(this.label11);
            this.pnlRoomInfo.Controls.Add(this.lblRoomNo);
            this.pnlRoomInfo.Controls.Add(this.lblCustoNo);
            this.pnlRoomInfo.Controls.Add(this.lblRoomPosition);
            this.pnlRoomInfo.Controls.Add(this.lblCheckTime);
            this.pnlRoomInfo.Controls.Add(this.label4);
            this.pnlRoomInfo.Controls.Add(this.label3);
            this.pnlRoomInfo.Controls.Add(this.label2);
            this.pnlRoomInfo.Controls.Add(this.label1);
            this.pnlRoomInfo.Location = new System.Drawing.Point(2, 194);
            this.pnlRoomInfo.Name = "pnlRoomInfo";
            this.pnlRoomInfo.Size = new System.Drawing.Size(164, 248);
            this.pnlRoomInfo.TabIndex = 72;
            // 
            // lblRoomState
            // 
            this.lblRoomState.AutoSize = true;
            this.lblRoomState.Location = new System.Drawing.Point(102, 217);
            this.lblRoomState.Name = "lblRoomState";
            this.lblRoomState.Size = new System.Drawing.Size(41, 12);
            this.lblRoomState.TabIndex = 16;
            this.lblRoomState.Text = "label9";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 15;
            this.label11.Text = "房间状态：";
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.AutoSize = true;
            this.lblRoomNo.Location = new System.Drawing.Point(102, 37);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(41, 12);
            this.lblRoomNo.TabIndex = 14;
            this.lblRoomNo.Text = "label7";
            // 
            // lblCustoNo
            // 
            this.lblCustoNo.AutoSize = true;
            this.lblCustoNo.Location = new System.Drawing.Point(102, 82);
            this.lblCustoNo.Name = "lblCustoNo";
            this.lblCustoNo.Size = new System.Drawing.Size(41, 12);
            this.lblCustoNo.TabIndex = 12;
            this.lblCustoNo.Text = "label7";
            // 
            // lblRoomPosition
            // 
            this.lblRoomPosition.AutoSize = true;
            this.lblRoomPosition.Location = new System.Drawing.Point(102, 172);
            this.lblRoomPosition.Name = "lblRoomPosition";
            this.lblRoomPosition.Size = new System.Drawing.Size(41, 12);
            this.lblRoomPosition.TabIndex = 10;
            this.lblRoomPosition.Text = "label8";
            // 
            // lblCheckTime
            // 
            this.lblCheckTime.AutoSize = true;
            this.lblCheckTime.Location = new System.Drawing.Point(102, 127);
            this.lblCheckTime.Name = "lblCheckTime";
            this.lblCheckTime.Size = new System.Drawing.Size(41, 12);
            this.lblCheckTime.TabIndex = 9;
            this.lblCheckTime.Text = "label7";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "所在区域：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "入住时间：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "客户编号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "房间号码：";
            // 
            // tmrGetData
            // 
            this.tmrGetData.Enabled = true;
            this.tmrGetData.Tick += new System.EventHandler(this.tmrGetData_Tick);
            // 
            // picRefrech
            // 
            this.picRefrech.BackColor = System.Drawing.Color.Transparent;
            this.picRefrech.BackgroundImage = global::TSHotelManagerSystem.Properties.Resources.获取用户编号;
            this.picRefrech.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRefrech.Location = new System.Drawing.Point(736, 3);
            this.picRefrech.Name = "picRefrech";
            this.picRefrech.Size = new System.Drawing.Size(25, 23);
            this.picRefrech.TabIndex = 94;
            this.picRefrech.TabStop = false;
            this.picRefrech.Click += new System.EventHandler(this.picRefrech_Click);
            // 
            // btnZT
            // 
            this.btnZT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnZT.BackgroundImage")));
            this.btnZT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnZT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZT.Location = new System.Drawing.Point(655, 3);
            this.btnZT.Name = "btnZT";
            this.btnZT.Size = new System.Drawing.Size(75, 23);
            this.btnZT.TabIndex = 74;
            this.btnZT.Text = "总统套房";
            this.btnZT.UseVisualStyleBackColor = true;
            this.btnZT.Click += new System.EventHandler(this.btnZT_Click);
            // 
            // btnQL
            // 
            this.btnQL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQL.BackgroundImage")));
            this.btnQL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQL.Location = new System.Drawing.Point(574, 3);
            this.btnQL.Name = "btnQL";
            this.btnQL.Size = new System.Drawing.Size(75, 23);
            this.btnQL.TabIndex = 74;
            this.btnQL.Text = "情侣套房";
            this.btnQL.UseVisualStyleBackColor = true;
            this.btnQL.Click += new System.EventHandler(this.btnQL_Click);
            // 
            // btnHS
            // 
            this.btnHS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHS.BackgroundImage")));
            this.btnHS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHS.Location = new System.Drawing.Point(493, 3);
            this.btnHS.Name = "btnHS";
            this.btnHS.Size = new System.Drawing.Size(75, 23);
            this.btnHS.TabIndex = 74;
            this.btnHS.Text = "豪华双人间";
            this.btnHS.UseVisualStyleBackColor = true;
            this.btnHS.Click += new System.EventHandler(this.btnHS_Click);
            // 
            // btnHD
            // 
            this.btnHD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHD.BackgroundImage")));
            this.btnHD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHD.Location = new System.Drawing.Point(412, 3);
            this.btnHD.Name = "btnHD";
            this.btnHD.Size = new System.Drawing.Size(75, 23);
            this.btnHD.TabIndex = 74;
            this.btnHD.Text = "豪华单人间";
            this.btnHD.UseVisualStyleBackColor = true;
            this.btnHD.Click += new System.EventHandler(this.btnHD_Click);
            // 
            // btnBS
            // 
            this.btnBS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBS.BackgroundImage")));
            this.btnBS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBS.Location = new System.Drawing.Point(331, 3);
            this.btnBS.Name = "btnBS";
            this.btnBS.Size = new System.Drawing.Size(75, 23);
            this.btnBS.TabIndex = 74;
            this.btnBS.Text = "标准双人间";
            this.btnBS.UseVisualStyleBackColor = true;
            this.btnBS.Click += new System.EventHandler(this.btnBS_Click);
            // 
            // btnBD
            // 
            this.btnBD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBD.BackgroundImage")));
            this.btnBD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBD.Location = new System.Drawing.Point(250, 3);
            this.btnBD.Name = "btnBD";
            this.btnBD.Size = new System.Drawing.Size(75, 23);
            this.btnBD.TabIndex = 74;
            this.btnBD.Text = "标准单人间";
            this.btnBD.UseVisualStyleBackColor = true;
            this.btnBD.Click += new System.EventHandler(this.btnBD_Click);
            // 
            // btnAll
            // 
            this.btnAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAll.BackgroundImage")));
            this.btnAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAll.Location = new System.Drawing.Point(169, 3);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(75, 23);
            this.btnAll.TabIndex = 73;
            this.btnAll.Text = "全部";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.BackgroundImage = global::TSHotelManagerSystem.Properties.Resources.维修中2;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(6, 141);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(155, 41);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BackgroundImage = global::TSHotelManagerSystem.Properties.Resources.脏房2;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(5, 96);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(155, 41);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox2.BackgroundImage = global::TSHotelManagerSystem.Properties.Resources.已住房;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(5, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(155, 41);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::TSHotelManagerSystem.Properties.Resources.可住房;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(5, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmRoomManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(994, 454);
            this.Controls.Add(this.picRefrech);
            this.Controls.Add(this.btnZT);
            this.Controls.Add(this.btnQL);
            this.Controls.Add(this.btnHS);
            this.Controls.Add(this.btnHD);
            this.Controls.Add(this.btnBS);
            this.Controls.Add(this.btnBD);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.pnlRoomInfo);
            this.Controls.Add(this.pnlRoomState);
            this.Controls.Add(this.flpRoom);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRoomManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRoomManager";
            this.Load += new System.EventHandler(this.FrmRoomManager_Load);
            this.pnlRoomState.ResumeLayout(false);
            this.pnlRoomState.PerformLayout();
            this.pnlRoomInfo.ResumeLayout(false);
            this.pnlRoomInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRefrech)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.FlowLayoutPanel pe;
        private System.Windows.Forms.FlowLayoutPanel flpRoom;
        private System.Windows.Forms.Panel pnlRoomState;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblNotClear;
        public System.Windows.Forms.Label lblCheck;
        public System.Windows.Forms.Label lblCanUse;
        private System.Windows.Forms.Panel pnlRoomInfo;
        private System.Windows.Forms.Label lblRoomState;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.Label lblCustoNo;
        private System.Windows.Forms.Label lblRoomPosition;
        private System.Windows.Forms.Label lblCheckTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrGetData;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnBD;
        private System.Windows.Forms.Button btnBS;
        private System.Windows.Forms.Button btnHD;
        private System.Windows.Forms.Button btnHS;
        private System.Windows.Forms.Button btnQL;
        private System.Windows.Forms.Button btnZT;
        private System.Windows.Forms.PictureBox picRefrech;
        public System.Windows.Forms.Label lblFix;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}