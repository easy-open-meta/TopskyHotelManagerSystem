namespace SYS.FormUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRoomManager));
            this.flpRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlRoomState = new System.Windows.Forms.Panel();
            this.lblReser = new System.Windows.Forms.Label();
            this.lblFix = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblNotClear = new System.Windows.Forms.Label();
            this.lblCheck = new System.Windows.Forms.Label();
            this.lblCanUse = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.btnAll = new Sunny.UI.UIButton();
            this.btnBD = new Sunny.UI.UIButton();
            this.btnBS = new Sunny.UI.UIButton();
            this.btnHD = new Sunny.UI.UIButton();
            this.btnHS = new Sunny.UI.UIButton();
            this.btnQL = new Sunny.UI.UIButton();
            this.btnZT = new Sunny.UI.UIButton();
            this.picRefrech = new System.Windows.Forms.PictureBox();
            this.pnlRoomState.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlRoomInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRefrech)).BeginInit();
            this.SuspendLayout();
            // 
            // flpRoom
            // 
            this.flpRoom.AutoScroll = true;
            this.flpRoom.BackColor = System.Drawing.Color.Transparent;
            this.flpRoom.Location = new System.Drawing.Point(227, 59);
            this.flpRoom.Name = "flpRoom";
            this.flpRoom.Size = new System.Drawing.Size(838, 424);
            this.flpRoom.TabIndex = 71;
            // 
            // pnlRoomState
            // 
            this.pnlRoomState.BackColor = System.Drawing.Color.Transparent;
            this.pnlRoomState.Controls.Add(this.lblReser);
            this.pnlRoomState.Controls.Add(this.lblFix);
            this.pnlRoomState.Controls.Add(this.pictureBox5);
            this.pnlRoomState.Controls.Add(this.pictureBox4);
            this.pnlRoomState.Controls.Add(this.lblNotClear);
            this.pnlRoomState.Controls.Add(this.lblCheck);
            this.pnlRoomState.Controls.Add(this.lblCanUse);
            this.pnlRoomState.Controls.Add(this.pictureBox3);
            this.pnlRoomState.Controls.Add(this.pictureBox2);
            this.pnlRoomState.Controls.Add(this.pictureBox1);
            this.pnlRoomState.Location = new System.Drawing.Point(2, 3);
            this.pnlRoomState.Name = "pnlRoomState";
            this.pnlRoomState.Size = new System.Drawing.Size(219, 259);
            this.pnlRoomState.TabIndex = 5;
            // 
            // lblReser
            // 
            this.lblReser.AutoSize = true;
            this.lblReser.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblReser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblReser.ForeColor = System.Drawing.Color.White;
            this.lblReser.Location = new System.Drawing.Point(176, 222);
            this.lblReser.Name = "lblReser";
            this.lblReser.Size = new System.Drawing.Size(19, 20);
            this.lblReser.TabIndex = 14;
            this.lblReser.Text = "0";
            // 
            // lblFix
            // 
            this.lblFix.AutoSize = true;
            this.lblFix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(167)))), ((int)(((byte)(203)))));
            this.lblFix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFix.ForeColor = System.Drawing.Color.White;
            this.lblFix.Location = new System.Drawing.Point(176, 171);
            this.lblFix.Name = "lblFix";
            this.lblFix.Size = new System.Drawing.Size(19, 20);
            this.lblFix.TabIndex = 13;
            this.lblFix.Text = "0";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.BackgroundImage = global::SYS.FormUI.Properties.Resources.预约房icon;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(4, 212);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(212, 41);
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            this.pictureBox5.MouseLeave += new System.EventHandler(this.pictureBox5_MouseLeave);
            this.pictureBox5.MouseHover += new System.EventHandler(this.pictureBox5_MouseHover);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.BackgroundImage = global::SYS.FormUI.Properties.Resources.维修房icon;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(5, 160);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(212, 41);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            this.pictureBox4.MouseHover += new System.EventHandler(this.pictureBox4_MouseHover);
            // 
            // lblNotClear
            // 
            this.lblNotClear.AutoSize = true;
            this.lblNotClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(138)))));
            this.lblNotClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNotClear.ForeColor = System.Drawing.Color.White;
            this.lblNotClear.Location = new System.Drawing.Point(176, 119);
            this.lblNotClear.Name = "lblNotClear";
            this.lblNotClear.Size = new System.Drawing.Size(19, 20);
            this.lblNotClear.TabIndex = 11;
            this.lblNotClear.Text = "0";
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(96)))));
            this.lblCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCheck.ForeColor = System.Drawing.Color.White;
            this.lblCheck.Location = new System.Drawing.Point(176, 67);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(19, 20);
            this.lblCheck.TabIndex = 10;
            this.lblCheck.Text = "0";
            // 
            // lblCanUse
            // 
            this.lblCanUse.AutoSize = true;
            this.lblCanUse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.lblCanUse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCanUse.ForeColor = System.Drawing.Color.White;
            this.lblCanUse.Location = new System.Drawing.Point(176, 14);
            this.lblCanUse.Name = "lblCanUse";
            this.lblCanUse.Size = new System.Drawing.Size(19, 20);
            this.lblCanUse.TabIndex = 9;
            this.lblCanUse.Text = "0";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BackgroundImage = global::SYS.FormUI.Properties.Resources.脏房icon1;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(4, 108);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(212, 41);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            this.pictureBox3.MouseHover += new System.EventHandler(this.pictureBox3_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox2.BackgroundImage = global::SYS.FormUI.Properties.Resources.已住房icon;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(4, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(212, 41);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::SYS.FormUI.Properties.Resources.可住房icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // pnlRoomInfo
            // 
            this.pnlRoomInfo.BackColor = System.Drawing.Color.Transparent;
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
            this.pnlRoomInfo.Location = new System.Drawing.Point(2, 268);
            this.pnlRoomInfo.Name = "pnlRoomInfo";
            this.pnlRoomInfo.Size = new System.Drawing.Size(219, 215);
            this.pnlRoomInfo.TabIndex = 72;
            // 
            // lblRoomState
            // 
            this.lblRoomState.AutoSize = true;
            this.lblRoomState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRoomState.Location = new System.Drawing.Point(104, 190);
            this.lblRoomState.Name = "lblRoomState";
            this.lblRoomState.Size = new System.Drawing.Size(10, 15);
            this.lblRoomState.TabIndex = 16;
            this.lblRoomState.Text = " ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(1, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 15;
            this.label11.Text = "房间状态：";
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.AutoSize = true;
            this.lblRoomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRoomNo.Location = new System.Drawing.Point(104, 10);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(10, 15);
            this.lblRoomNo.TabIndex = 14;
            this.lblRoomNo.Text = " ";
            // 
            // lblCustoNo
            // 
            this.lblCustoNo.AutoSize = true;
            this.lblCustoNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCustoNo.Location = new System.Drawing.Point(104, 55);
            this.lblCustoNo.Name = "lblCustoNo";
            this.lblCustoNo.Size = new System.Drawing.Size(10, 15);
            this.lblCustoNo.TabIndex = 12;
            this.lblCustoNo.Text = " ";
            // 
            // lblRoomPosition
            // 
            this.lblRoomPosition.AutoSize = true;
            this.lblRoomPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRoomPosition.Location = new System.Drawing.Point(104, 145);
            this.lblRoomPosition.Name = "lblRoomPosition";
            this.lblRoomPosition.Size = new System.Drawing.Size(10, 15);
            this.lblRoomPosition.TabIndex = 10;
            this.lblRoomPosition.Text = " ";
            // 
            // lblCheckTime
            // 
            this.lblCheckTime.AutoSize = true;
            this.lblCheckTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCheckTime.Location = new System.Drawing.Point(80, 100);
            this.lblCheckTime.Name = "lblCheckTime";
            this.lblCheckTime.Size = new System.Drawing.Size(10, 15);
            this.lblCheckTime.TabIndex = 9;
            this.lblCheckTime.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(1, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "所在区域：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(1, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "入住时间：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(1, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "客户名字：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(1, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "房间号码：";
            // 
            // btnAll
            // 
            this.btnAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAll.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnAll.Location = new System.Drawing.Point(233, 13);
            this.btnAll.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(108, 31);
            this.btnAll.TabIndex = 0;
            this.btnAll.Text = "全部房间";
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnBD
            // 
            this.btnBD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBD.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnBD.Location = new System.Drawing.Point(346, 13);
            this.btnBD.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnBD.Name = "btnBD";
            this.btnBD.Size = new System.Drawing.Size(108, 31);
            this.btnBD.TabIndex = 1;
            this.btnBD.Text = "标准单人间";
            this.btnBD.Click += new System.EventHandler(this.btnBD_Click);
            // 
            // btnBS
            // 
            this.btnBS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBS.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnBS.Location = new System.Drawing.Point(459, 13);
            this.btnBS.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnBS.Name = "btnBS";
            this.btnBS.Size = new System.Drawing.Size(108, 31);
            this.btnBS.TabIndex = 2;
            this.btnBS.Text = "标准双人间";
            this.btnBS.Click += new System.EventHandler(this.btnBS_Click);
            // 
            // btnHD
            // 
            this.btnHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHD.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnHD.Location = new System.Drawing.Point(572, 13);
            this.btnHD.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnHD.Name = "btnHD";
            this.btnHD.Size = new System.Drawing.Size(108, 31);
            this.btnHD.TabIndex = 3;
            this.btnHD.Text = "豪华单人间";
            this.btnHD.Click += new System.EventHandler(this.btnHD_Click);
            // 
            // btnHS
            // 
            this.btnHS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHS.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnHS.Location = new System.Drawing.Point(685, 13);
            this.btnHS.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnHS.Name = "btnHS";
            this.btnHS.Size = new System.Drawing.Size(108, 31);
            this.btnHS.TabIndex = 4;
            this.btnHS.Text = "豪华双人间";
            this.btnHS.Click += new System.EventHandler(this.btnHS_Click);
            // 
            // btnQL
            // 
            this.btnQL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQL.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnQL.Location = new System.Drawing.Point(798, 13);
            this.btnQL.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnQL.Name = "btnQL";
            this.btnQL.Size = new System.Drawing.Size(108, 31);
            this.btnQL.TabIndex = 5;
            this.btnQL.Text = "情侣套房";
            this.btnQL.Click += new System.EventHandler(this.btnQL_Click);
            // 
            // btnZT
            // 
            this.btnZT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZT.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnZT.Location = new System.Drawing.Point(911, 13);
            this.btnZT.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnZT.Name = "btnZT";
            this.btnZT.Size = new System.Drawing.Size(108, 31);
            this.btnZT.TabIndex = 6;
            this.btnZT.Text = "总统套房";
            this.btnZT.Click += new System.EventHandler(this.btnZT_Click);
            // 
            // picRefrech
            // 
            this.picRefrech.BackColor = System.Drawing.Color.Transparent;
            this.picRefrech.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picRefrech.BackgroundImage")));
            this.picRefrech.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRefrech.Location = new System.Drawing.Point(1024, 14);
            this.picRefrech.Name = "picRefrech";
            this.picRefrech.Size = new System.Drawing.Size(32, 29);
            this.picRefrech.TabIndex = 94;
            this.picRefrech.TabStop = false;
            this.picRefrech.Click += new System.EventHandler(this.picRefrech_Click);
            // 
            // FrmRoomManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1072, 490);
            this.Controls.Add(this.btnZT);
            this.Controls.Add(this.btnQL);
            this.Controls.Add(this.btnHS);
            this.Controls.Add(this.btnHD);
            this.Controls.Add(this.btnBS);
            this.Controls.Add(this.btnBD);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.picRefrech);
            this.Controls.Add(this.pnlRoomInfo);
            this.Controls.Add(this.pnlRoomState);
            this.Controls.Add(this.flpRoom);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRoomManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRoomManager";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.FrmRoomManager_Load);
            this.pnlRoomState.ResumeLayout(false);
            this.pnlRoomState.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlRoomInfo.ResumeLayout(false);
            this.pnlRoomInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRefrech)).EndInit();
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picRefrech;
        public System.Windows.Forms.Label lblFix;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        public System.Windows.Forms.Label lblReser;
        private Sunny.UI.UIButton btnAll;
        private Sunny.UI.UIButton btnBD;
        private Sunny.UI.UIButton btnBS;
        private Sunny.UI.UIButton btnHD;
        private Sunny.UI.UIButton btnHS;
        private Sunny.UI.UIButton btnQL;
        private Sunny.UI.UIButton btnZT;
        public System.Windows.Forms.Label lblRoomState;
        public System.Windows.Forms.Label lblRoomNo;
        public System.Windows.Forms.Label lblCustoNo;
        public System.Windows.Forms.Label lblRoomPosition;
        public System.Windows.Forms.Label lblCheckTime;
        public System.Windows.Forms.Panel pnlRoomInfo;
    }
}