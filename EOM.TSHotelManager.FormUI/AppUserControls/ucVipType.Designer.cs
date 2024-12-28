
namespace EOM.TSHotelManager.FormUI
{
    partial class ucVipType
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
            this.picVip = new System.Windows.Forms.PictureBox();
            this.lblValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picVip)).BeginInit();
            this.SuspendLayout();
            // 
            // picVip
            // 
            this.picVip.BackColor = System.Drawing.Color.Transparent;
            this.picVip.BackgroundImage = global::EOM.TSHotelManager.FormUI.Properties.Resources.普通会员;
            this.picVip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picVip.Location = new System.Drawing.Point(0, 0);
            this.picVip.Name = "picVip";
            this.picVip.Size = new System.Drawing.Size(80, 28);
            this.picVip.TabIndex = 0;
            this.picVip.TabStop = false;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("阿里巴巴普惠体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblValue.Location = new System.Drawing.Point(15, 47);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(51, 20);
            this.lblValue.TabIndex = 1;
            this.lblValue.Text = "label1";
            // 
            // ucVipType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.picVip);
            this.Name = "ucVipType";
            this.Size = new System.Drawing.Size(80, 80);
            this.Load += new System.EventHandler(this.ucVipType_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ucVipType_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.picVip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox picVip;
        public System.Windows.Forms.Label lblValue;
    }
}
