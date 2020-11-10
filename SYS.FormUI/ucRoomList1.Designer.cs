namespace TSHotelManagerSystem
{
    partial class ucRoomList
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblCustoNo = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiReserRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCheckIn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCheckOut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChangeRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSelectUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChangeState = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.AutoSize = true;
            this.lblRoomNo.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomNo.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRoomNo.ForeColor = System.Drawing.Color.Red;
            this.lblRoomNo.Location = new System.Drawing.Point(23, 32);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(65, 16);
            this.lblRoomNo.TabIndex = 0;
            this.lblRoomNo.Text = "RoomNo";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomType.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRoomType.Location = new System.Drawing.Point(21, 4);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(27, 16);
            this.lblRoomType.TabIndex = 1;
            this.lblRoomType.Text = "RT";
            // 
            // lblCustoNo
            // 
            this.lblCustoNo.AutoSize = true;
            this.lblCustoNo.BackColor = System.Drawing.Color.Transparent;
            this.lblCustoNo.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCustoNo.Location = new System.Drawing.Point(21, 60);
            this.lblCustoNo.Name = "lblCustoNo";
            this.lblCustoNo.Size = new System.Drawing.Size(66, 16);
            this.lblCustoNo.TabIndex = 2;
            this.lblCustoNo.Text = "CustoNo";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.BackColor = System.Drawing.Color.Transparent;
            this.lblState.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblState.ForeColor = System.Drawing.Color.Black;
            this.lblState.Location = new System.Drawing.Point(7, 33);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(15, 14);
            this.lblState.TabIndex = 3;
            this.lblState.Text = "*";
            // 
            // cmsMain
            // 
            this.cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiReserRoom,
            this.tsmiCheckIn,
            this.tsmiCheckOut,
            this.tsmiChangeRoom,
            this.tsmiSelectUserInfo,
            this.tsmiChangeState});
            this.cmsMain.Name = "cmsMain";
            this.cmsMain.Size = new System.Drawing.Size(149, 136);
            this.cmsMain.Opening += new System.ComponentModel.CancelEventHandler(this.cmsMain_Opening);
            // 
            // tsmiReserRoom
            // 
            this.tsmiReserRoom.Name = "tsmiReserRoom";
            this.tsmiReserRoom.Size = new System.Drawing.Size(148, 22);
            this.tsmiReserRoom.Text = "预约房间";
            // 
            // tsmiCheckIn
            // 
            this.tsmiCheckIn.Name = "tsmiCheckIn";
            this.tsmiCheckIn.Size = new System.Drawing.Size(148, 22);
            this.tsmiCheckIn.Text = "入住房间";
            this.tsmiCheckIn.Click += new System.EventHandler(this.tsmiCheckIn_Click);
            // 
            // tsmiCheckOut
            // 
            this.tsmiCheckOut.Name = "tsmiCheckOut";
            this.tsmiCheckOut.Size = new System.Drawing.Size(148, 22);
            this.tsmiCheckOut.Text = "结算退房";
            this.tsmiCheckOut.Click += new System.EventHandler(this.tsmiCheckOut_Click);
            // 
            // tsmiChangeRoom
            // 
            this.tsmiChangeRoom.Name = "tsmiChangeRoom";
            this.tsmiChangeRoom.Size = new System.Drawing.Size(148, 22);
            this.tsmiChangeRoom.Text = "转换房间";
            this.tsmiChangeRoom.Click += new System.EventHandler(this.tsmiChangeRoom_Click);
            // 
            // tsmiSelectUserInfo
            // 
            this.tsmiSelectUserInfo.Name = "tsmiSelectUserInfo";
            this.tsmiSelectUserInfo.Size = new System.Drawing.Size(148, 22);
            this.tsmiSelectUserInfo.Text = "查看用户信息";
            this.tsmiSelectUserInfo.Click += new System.EventHandler(this.tsmiSelectUserInfo_Click);
            // 
            // tsmiChangeState
            // 
            this.tsmiChangeState.Name = "tsmiChangeState";
            this.tsmiChangeState.Size = new System.Drawing.Size(148, 22);
            this.tsmiChangeState.Text = "修改房间状态";
            this.tsmiChangeState.Click += new System.EventHandler(this.tsmiChangeState_Click);
            // 
            // ucRoomList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = global::TSHotelManagerSystem.Properties.Resources.空房22;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ContextMenuStrip = this.cmsMain;
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblCustoNo);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.lblRoomNo);
            this.DoubleBuffered = true;
            this.Name = "ucRoomList";
            this.Size = new System.Drawing.Size(95, 79);
            this.Load += new System.EventHandler(this.ucRoomList_Load);
            this.Click += new System.EventHandler(this.ucRoomList_Click);
            this.DoubleClick += new System.EventHandler(this.ucRoomList_DoubleClick);
            this.MouseEnter += new System.EventHandler(this.ucRoomList_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ucRoomList_MouseLeave);
            this.cmsMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblCustoNo;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiCheckIn;
        private System.Windows.Forms.ToolStripMenuItem tsmiCheckOut;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectUserInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangeState;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangeRoom;
        private System.Windows.Forms.ToolStripMenuItem tsmiReserRoom;
    }
}
