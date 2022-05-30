
namespace SYS.FormUI
{
    partial class ucEducationInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBaseInformation));
            this.btnOperation = new Sunny.UI.UIButton();
            this.lbName = new Sunny.UI.UITextBox();
            this.SuspendLayout();
            // 
            // btnOperation
            // 
            this.btnOperation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOperation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOperation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(29)))), ((int)(((byte)(35)))));
            this.btnOperation.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnOperation.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnOperation.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOperation.Location = new System.Drawing.Point(34, 4);
            this.btnOperation.Margin = new System.Windows.Forms.Padding(0);
            this.btnOperation.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOperation.Name = "btnOperation";
            this.btnOperation.Radius = 20;
            this.btnOperation.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOperation.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btnOperation.Size = new System.Drawing.Size(44, 26);
            this.btnOperation.Style = Sunny.UI.UIStyle.Custom;
            this.btnOperation.StyleCustomMode = true;
            this.btnOperation.TabIndex = 15;
            this.btnOperation.Text = "删除";
            this.btnOperation.SizeChanged += new System.EventHandler(this.btnOperation_SizeChanged);
            this.btnOperation.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbName.Enabled = false;
            this.lbName.FillColor = System.Drawing.Color.White;
            this.lbName.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.lbName.FocusedSelectAll = true;
            this.lbName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbName.Location = new System.Drawing.Point(6, 35);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbName.Maximum = 2147483647D;
            this.lbName.Minimum = -2147483648D;
            this.lbName.MinimumSize = new System.Drawing.Size(1, 1);
            this.lbName.Name = "lbName";
            this.lbName.Padding = new System.Windows.Forms.Padding(5);
            this.lbName.Radius = 20;
            this.lbName.ReadOnly = true;
            this.lbName.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.lbName.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.lbName.Size = new System.Drawing.Size(74, 29);
            this.lbName.Style = Sunny.UI.UIStyle.Custom;
            this.lbName.TabIndex = 17;
            this.lbName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbName.MouseLeave += new System.EventHandler(this.lbName_MouseLeave);
            this.lbName.MouseHover += new System.EventHandler(this.lbName_MouseHover);
            this.lbName.Validated += new System.EventHandler(this.lbName_Validated);
            // 
            // ucBaseInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnOperation);
            this.DoubleBuffered = true;
            this.Name = "ucBaseInformation";
            this.Size = new System.Drawing.Size(86, 66);
            this.Tag = "";
            this.Load += new System.EventHandler(this.ucBaseInformation_Load);
            this.SizeChanged += new System.EventHandler(this.ucBaseInformation_SizeChanged);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.ucBaseInformation_Layout);
            this.Resize += new System.EventHandler(this.ucBaseInformation_Resize);
            this.ResumeLayout(false);

        }

        #endregion
        public Sunny.UI.UIButton btnOperation;
        public Sunny.UI.UITextBox lbName;
    }
}
