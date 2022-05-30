namespace SYS.FormUI
{
    partial class ucRoom
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
            this.leRoomNo = new Sunny.UI.UILine();
            this.leRoomType = new Sunny.UI.UILine();
            this.leCustoNo = new Sunny.UI.UILine();
            this.leRoomState = new Sunny.UI.UILine();
            this.cmsControlPanel = new Sunny.UI.UIContextMenuStrip();
            this.tsmiReserRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCheckIn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCheckOut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChangeRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChangeState = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSelectUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMark = new Sunny.UI.UILabel();
            this.cmsControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leRoomNo
            // 
            this.leRoomNo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.leRoomNo.Location = new System.Drawing.Point(0, 2);
            this.leRoomNo.MinimumSize = new System.Drawing.Size(2, 2);
            this.leRoomNo.Name = "leRoomNo";
            this.leRoomNo.Size = new System.Drawing.Size(150, 29);
            this.leRoomNo.TabIndex = 0;
            this.leRoomNo.Text = "BS001";
            this.leRoomNo.TextInterval = 15;
            this.leRoomNo.Click += new System.EventHandler(this.leRoomNo_Click);
            // 
            // leRoomType
            // 
            this.leRoomType.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.leRoomType.Location = new System.Drawing.Point(0, 37);
            this.leRoomType.MinimumSize = new System.Drawing.Size(2, 2);
            this.leRoomType.Name = "leRoomType";
            this.leRoomType.Size = new System.Drawing.Size(150, 29);
            this.leRoomType.TabIndex = 1;
            this.leRoomType.Text = "标准双人间";
            this.leRoomType.TextInterval = 15;
            this.leRoomType.Click += new System.EventHandler(this.leRoomType_Click);
            // 
            // leCustoNo
            // 
            this.leCustoNo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.leCustoNo.Location = new System.Drawing.Point(0, 72);
            this.leCustoNo.MinimumSize = new System.Drawing.Size(2, 2);
            this.leCustoNo.Name = "leCustoNo";
            this.leCustoNo.Size = new System.Drawing.Size(150, 29);
            this.leCustoNo.TabIndex = 2;
            this.leCustoNo.Text = "TS20212515416";
            this.leCustoNo.TextInterval = 15;
            this.leCustoNo.Click += new System.EventHandler(this.leCustoNo_Click);
            // 
            // leRoomState
            // 
            this.leRoomState.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.leRoomState.Location = new System.Drawing.Point(0, 107);
            this.leRoomState.MinimumSize = new System.Drawing.Size(2, 2);
            this.leRoomState.Name = "leRoomState";
            this.leRoomState.Size = new System.Drawing.Size(150, 29);
            this.leRoomState.TabIndex = 3;
            this.leRoomState.Text = "已住";
            this.leRoomState.TextInterval = 15;
            // 
            // cmsControlPanel
            // 
            this.cmsControlPanel.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmsControlPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiReserRoom,
            this.tsmiCheckIn,
            this.tsmiCheckOut,
            this.tsmiChangeRoom,
            this.tsmiChangeState,
            this.tsmiSelectUserInfo});
            this.cmsControlPanel.Name = "cmsControlPanel";
            this.cmsControlPanel.ShowCheckMargin = true;
            this.cmsControlPanel.Size = new System.Drawing.Size(199, 160);
            this.cmsControlPanel.Opening += new System.ComponentModel.CancelEventHandler(this.cmsControlPanel_Opening);
            // 
            // tsmiReserRoom
            // 
            this.tsmiReserRoom.Name = "tsmiReserRoom";
            this.tsmiReserRoom.Size = new System.Drawing.Size(198, 26);
            this.tsmiReserRoom.Text = "预约房间";
            this.tsmiReserRoom.Click += new System.EventHandler(this.tsmiReserRoom_Click);
            // 
            // tsmiCheckIn
            // 
            this.tsmiCheckIn.Name = "tsmiCheckIn";
            this.tsmiCheckIn.Size = new System.Drawing.Size(198, 26);
            this.tsmiCheckIn.Text = "入住房间";
            this.tsmiCheckIn.Click += new System.EventHandler(this.tsmiCheckIn_Click);
            // 
            // tsmiCheckOut
            // 
            this.tsmiCheckOut.Name = "tsmiCheckOut";
            this.tsmiCheckOut.Size = new System.Drawing.Size(198, 26);
            this.tsmiCheckOut.Text = "结算退房";
            this.tsmiCheckOut.Click += new System.EventHandler(this.tsmiCheckOut_Click);
            // 
            // tsmiChangeRoom
            // 
            this.tsmiChangeRoom.Name = "tsmiChangeRoom";
            this.tsmiChangeRoom.Size = new System.Drawing.Size(198, 26);
            this.tsmiChangeRoom.Text = "转换房间";
            this.tsmiChangeRoom.Click += new System.EventHandler(this.tsmiChangeRoom_Click);
            // 
            // tsmiChangeState
            // 
            this.tsmiChangeState.Name = "tsmiChangeState";
            this.tsmiChangeState.Size = new System.Drawing.Size(198, 26);
            this.tsmiChangeState.Text = "修改房间状态";
            this.tsmiChangeState.Click += new System.EventHandler(this.tsmiChangeState_Click);
            // 
            // tsmiSelectUserInfo
            // 
            this.tsmiSelectUserInfo.Name = "tsmiSelectUserInfo";
            this.tsmiSelectUserInfo.Size = new System.Drawing.Size(198, 26);
            this.tsmiSelectUserInfo.Text = "查看客户信息";
            this.tsmiSelectUserInfo.Click += new System.EventHandler(this.tsmiSelectUserInfo_Click);
            // 
            // lblMark
            // 
            this.lblMark.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblMark.Location = new System.Drawing.Point(68, 61);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(15, 23);
            this.lblMark.TabIndex = 12;
            this.lblMark.Text = "uiLabel1";
            this.lblMark.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMark.Visible = false;
            // 
            // ucRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.ContextMenuStrip = this.cmsControlPanel;
            this.Controls.Add(this.lblMark);
            this.Controls.Add(this.leRoomState);
            this.Controls.Add(this.leCustoNo);
            this.Controls.Add(this.leRoomType);
            this.Controls.Add(this.leRoomNo);
            this.Name = "ucRoom";
            this.Size = new System.Drawing.Size(150, 145);
            this.Load += new System.EventHandler(this.ucRoom_Load);
            this.Click += new System.EventHandler(this.ucRoom_Click);
            this.DoubleClick += new System.EventHandler(this.ucRoom_DoubleClick);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ucRoom_MouseClick);
            this.MouseEnter += new System.EventHandler(this.ucRoom_MouseEnter);
            this.MouseHover += new System.EventHandler(this.ucRoom_MouseHover);
            this.cmsControlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Sunny.UI.UILine leRoomNo;
        public Sunny.UI.UILine leRoomType;
        public Sunny.UI.UILine leCustoNo;
        public Sunny.UI.UILine leRoomState;
        private Sunny.UI.UIContextMenuStrip cmsControlPanel;
        private System.Windows.Forms.ToolStripMenuItem tsmiReserRoom;
        private System.Windows.Forms.ToolStripMenuItem tsmiCheckIn;
        private System.Windows.Forms.ToolStripMenuItem tsmiCheckOut;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangeRoom;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangeState;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectUserInfo;
        public Sunny.UI.UILabel lblMark;
    }
}
