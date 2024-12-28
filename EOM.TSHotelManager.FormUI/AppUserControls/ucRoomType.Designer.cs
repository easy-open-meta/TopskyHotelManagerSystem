namespace EOM.TSHotelManager.FormUI.AppUserControls
{
    partial class ucRoomType
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
            btnRoomType = new Sunny.UI.UIButton();
            SuspendLayout();
            // 
            // btnRoomType
            // 
            btnRoomType.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRoomType.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnRoomType.Location = new System.Drawing.Point(0, 2);
            btnRoomType.Margin = new System.Windows.Forms.Padding(4);
            btnRoomType.MinimumSize = new System.Drawing.Size(1, 1);
            btnRoomType.Name = "btnRoomType";
            btnRoomType.Size = new System.Drawing.Size(107, 33);
            btnRoomType.TabIndex = 1;
            btnRoomType.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            // 
            // ucRoomType
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(btnRoomType);
            Name = "ucRoomType";
            Size = new System.Drawing.Size(107, 37);
            ResumeLayout(false);
        }

        #endregion

        public Sunny.UI.UIButton btnRoomType;
    }
}
