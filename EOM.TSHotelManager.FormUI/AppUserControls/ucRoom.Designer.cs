namespace EOM.TSHotelManager.FormUI
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
            components = new System.ComponentModel.Container();
            btnRoom = new AntdUI.Button();
            cmsMain = new System.Windows.Forms.ContextMenuStrip(components);
            tsmiReserRoom = new System.Windows.Forms.ToolStripMenuItem();
            tsmiCheckIn = new System.Windows.Forms.ToolStripMenuItem();
            tsmiCheckOut = new System.Windows.Forms.ToolStripMenuItem();
            tsmiChangeRoom = new System.Windows.Forms.ToolStripMenuItem();
            tsmiSelectUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            tsmiChangeState = new System.Windows.Forms.ToolStripMenuItem();
            cmsMain.SuspendLayout();
            SuspendLayout();
            // 
            // btnRoom
            // 
            btnRoom.AutoEllipsis = true;
            btnRoom.BackColor = System.Drawing.Color.Transparent;
            btnRoom.BackgroundImage = Properties.Resources.可住状态;
            btnRoom.BackgroundImageLayout = AntdUI.TFit.Cover;
            btnRoom.ContextMenuStrip = cmsMain;
            btnRoom.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnRoom.Ghost = true;
            btnRoom.IconRatio = 0.5F;
            btnRoom.JoinLeft = true;
            btnRoom.JoinRight = true;
            btnRoom.Location = new System.Drawing.Point(0, 0);
            btnRoom.Name = "btnRoom";
            btnRoom.Radius = 12;
            btnRoom.Size = new System.Drawing.Size(122, 102);
            btnRoom.TabIndex = 0;
            btnRoom.Text = "总统套房\r\n\r\nBS001\r\n\r\n梁静茹";
            btnRoom.Click += btnRoom_Click;
            // 
            // cmsMain
            // 
            cmsMain.ImageScalingSize = new System.Drawing.Size(28, 28);
            cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmiReserRoom, tsmiCheckIn, tsmiCheckOut, tsmiChangeRoom, tsmiSelectUserInfo, tsmiChangeState });
            cmsMain.Name = "cmsMain";
            cmsMain.Size = new System.Drawing.Size(149, 136);
            cmsMain.Opening += cmsMain_Opening;
            // 
            // tsmiReserRoom
            // 
            tsmiReserRoom.Name = "tsmiReserRoom";
            tsmiReserRoom.Size = new System.Drawing.Size(148, 22);
            tsmiReserRoom.Text = "预约房间";
            tsmiReserRoom.Click += tsmiReserRoom_Click;
            // 
            // tsmiCheckIn
            // 
            tsmiCheckIn.Name = "tsmiCheckIn";
            tsmiCheckIn.Size = new System.Drawing.Size(148, 22);
            tsmiCheckIn.Text = "入住房间";
            tsmiCheckIn.Click += tsmiCheckIn_Click;
            // 
            // tsmiCheckOut
            // 
            tsmiCheckOut.Name = "tsmiCheckOut";
            tsmiCheckOut.Size = new System.Drawing.Size(148, 22);
            tsmiCheckOut.Text = "结算退房";
            tsmiCheckOut.Click += tsmiCheckOut_Click;
            // 
            // tsmiChangeRoom
            // 
            tsmiChangeRoom.Name = "tsmiChangeRoom";
            tsmiChangeRoom.Size = new System.Drawing.Size(148, 22);
            tsmiChangeRoom.Text = "转换房间";
            tsmiChangeRoom.Click += tsmiChangeRoom_Click;
            // 
            // tsmiSelectUserInfo
            // 
            tsmiSelectUserInfo.Name = "tsmiSelectUserInfo";
            tsmiSelectUserInfo.Size = new System.Drawing.Size(148, 22);
            tsmiSelectUserInfo.Text = "查看用户信息";
            tsmiSelectUserInfo.Click += tsmiSelectUserInfo_Click;
            // 
            // tsmiChangeState
            // 
            tsmiChangeState.Name = "tsmiChangeState";
            tsmiChangeState.Size = new System.Drawing.Size(148, 22);
            tsmiChangeState.Text = "修改房间状态";
            tsmiChangeState.Click += tsmiChangeState_Click;
            // 
            // ucRoom
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(btnRoom);
            Name = "ucRoom";
            Size = new System.Drawing.Size(122, 102);
            Load += ucRoom_Load;
            cmsMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public AntdUI.Button btnRoom;
        private AntdUI.Button button1;
        private System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiReserRoom;
        private System.Windows.Forms.ToolStripMenuItem tsmiCheckIn;
        private System.Windows.Forms.ToolStripMenuItem tsmiCheckOut;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangeRoom;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectUserInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangeState;
    }
}
