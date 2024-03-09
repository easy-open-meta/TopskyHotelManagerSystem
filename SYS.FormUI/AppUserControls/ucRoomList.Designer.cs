namespace SYS.FormUI
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
            this.cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiReserRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCheckIn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCheckOut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChangeRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSelectUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChangeState = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCustoNo = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.uttTips = new Sunny.UI.UIToolTip(this.components);
            this.lblMark = new Sunny.UI.UILabel();
            this.cmsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsMain
            // 
            this.cmsMain.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiReserRoom,
            this.tsmiCheckIn,
            this.tsmiCheckOut,
            this.tsmiChangeRoom,
            this.tsmiSelectUserInfo,
            this.tsmiChangeState});
            this.cmsMain.Name = "cmsMain";
            this.cmsMain.Size = new System.Drawing.Size(211, 208);
            this.cmsMain.Opening += new System.ComponentModel.CancelEventHandler(this.cmsMain_Opening);
            // 
            // tsmiReserRoom
            // 
            this.tsmiReserRoom.Name = "tsmiReserRoom";
            this.tsmiReserRoom.Size = new System.Drawing.Size(210, 34);
            this.tsmiReserRoom.Text = "预约房间";
            this.tsmiReserRoom.Click += new System.EventHandler(this.tsmiReserRoom_Click);
            // 
            // tsmiCheckIn
            // 
            this.tsmiCheckIn.Name = "tsmiCheckIn";
            this.tsmiCheckIn.Size = new System.Drawing.Size(210, 34);
            this.tsmiCheckIn.Text = "入住房间";
            this.tsmiCheckIn.Click += new System.EventHandler(this.tsmiCheckIn_Click);
            // 
            // tsmiCheckOut
            // 
            this.tsmiCheckOut.Name = "tsmiCheckOut";
            this.tsmiCheckOut.Size = new System.Drawing.Size(210, 34);
            this.tsmiCheckOut.Text = "结算退房";
            this.tsmiCheckOut.Click += new System.EventHandler(this.tsmiCheckOut_Click);
            // 
            // tsmiChangeRoom
            // 
            this.tsmiChangeRoom.Name = "tsmiChangeRoom";
            this.tsmiChangeRoom.Size = new System.Drawing.Size(210, 34);
            this.tsmiChangeRoom.Text = "转换房间";
            this.tsmiChangeRoom.Click += new System.EventHandler(this.tsmiChangeRoom_Click);
            // 
            // tsmiSelectUserInfo
            // 
            this.tsmiSelectUserInfo.Name = "tsmiSelectUserInfo";
            this.tsmiSelectUserInfo.Size = new System.Drawing.Size(210, 34);
            this.tsmiSelectUserInfo.Text = "查看用户信息";
            this.tsmiSelectUserInfo.Click += new System.EventHandler(this.tsmiSelectUserInfo_Click);
            // 
            // tsmiChangeState
            // 
            this.tsmiChangeState.Name = "tsmiChangeState";
            this.tsmiChangeState.Size = new System.Drawing.Size(210, 34);
            this.tsmiChangeState.Text = "修改房间状态";
            this.tsmiChangeState.Click += new System.EventHandler(this.tsmiChangeState_Click);
            // 
            // lblCustoNo
            // 
            this.lblCustoNo.AutoSize = true;
            this.lblCustoNo.BackColor = System.Drawing.Color.Transparent;
            this.lblCustoNo.ContextMenuStrip = this.cmsMain;
            this.lblCustoNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCustoNo.Location = new System.Drawing.Point(40, 103);
            this.lblCustoNo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCustoNo.Name = "lblCustoNo";
            this.lblCustoNo.Size = new System.Drawing.Size(111, 29);
            this.lblCustoNo.TabIndex = 10;
            this.lblCustoNo.Text = "CustoNo";
            this.lblCustoNo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblCustoNo_MouseClick);
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomType.ContextMenuStrip = this.cmsMain;
            this.lblRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRoomType.Location = new System.Drawing.Point(42, 5);
            this.lblRoomType.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(109, 29);
            this.lblRoomType.TabIndex = 9;
            this.lblRoomType.Text = "RoomTy";
            this.lblRoomType.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblRoomType_MouseClick);
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.AutoSize = true;
            this.lblRoomNo.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomNo.ContextMenuStrip = this.cmsMain;
            this.lblRoomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRoomNo.ForeColor = System.Drawing.Color.Black;
            this.lblRoomNo.Location = new System.Drawing.Point(42, 54);
            this.lblRoomNo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(113, 29);
            this.lblRoomNo.TabIndex = 8;
            this.lblRoomNo.Text = "RoomNo";
            this.lblRoomNo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblRoomNo_MouseClick);
            // 
            // uttTips
            // 
            this.uttTips.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.uttTips.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.uttTips.OwnerDraw = true;
            this.uttTips.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.uttTips.ToolTipTitle = "点击提示";
            // 
            // lblMark
            // 
            this.lblMark.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblMark.Location = new System.Drawing.Point(68, 84);
            this.lblMark.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(28, 40);
            this.lblMark.TabIndex = 11;
            this.lblMark.Text = "uiLabel1";
            this.lblMark.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMark.Visible = false;
            // 
            // ucRoomList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = global::SYS.FormUI.Properties.Resources.可住状态;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ContextMenuStrip = this.cmsMain;
            this.Controls.Add(this.lblMark);
            this.Controls.Add(this.lblCustoNo);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.lblRoomNo);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "ucRoomList";
            this.Size = new System.Drawing.Size(174, 138);
            this.uttTips.SetToolTip(this, "a)、点击鼠标左键查看房间信息\r\nb)、点击鼠标右键打开选项菜单\r\nc)、快速双击鼠标左键可快速入住/查看信息");
            this.Load += new System.EventHandler(this.ucRoomList_Load);
            this.SizeChanged += new System.EventHandler(this.ucRoomList_SizeChanged);
            this.Click += new System.EventHandler(this.ucRoomList_Click);
            this.DoubleClick += new System.EventHandler(this.ucRoomList_DoubleClick);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ucRoomList_MouseClick);
            this.cmsMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiCheckIn;
        private System.Windows.Forms.ToolStripMenuItem tsmiCheckOut;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectUserInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangeState;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangeRoom;
        private System.Windows.Forms.ToolStripMenuItem tsmiReserRoom;
        public System.Windows.Forms.Label lblCustoNo;
        public System.Windows.Forms.Label lblRoomType;
        public System.Windows.Forms.Label lblRoomNo;
        private Sunny.UI.UIToolTip uttTips;
        public Sunny.UI.UILabel lblMark;
    }
}
