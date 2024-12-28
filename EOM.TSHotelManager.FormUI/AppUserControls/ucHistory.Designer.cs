namespace EOM.TSHotelManager.FormUI
{
    partial class ucHistory
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
            this.dtpStartDate = new Sunny.UI.UIDatePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpEndDate = new Sunny.UI.UIDatePicker();
            this.txtPosition = new Sunny.UI.UITextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtCompany = new Sunny.UI.UITextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.dtpStartDate.FillColor = System.Drawing.Color.White;
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.dtpStartDate.Location = new System.Drawing.Point(95, 7);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpStartDate.MaxLength = 10;
            this.dtpStartDate.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.dtpStartDate.Radius = 20;
            this.dtpStartDate.Size = new System.Drawing.Size(166, 31);
            this.dtpStartDate.SymbolDropDown = 61555;
            this.dtpStartDate.SymbolNormal = 61555;
            this.dtpStartDate.TabIndex = 120;
            this.dtpStartDate.Text = "2020-11-24";
            this.dtpStartDate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtpStartDate.Value = new System.DateTime(2020, 11, 24, 22, 50, 36, 791);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(3, 10);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 25);
            this.label19.TabIndex = 119;
            this.label19.Text = "工作时间";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(299, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 25);
            this.label5.TabIndex = 121;
            this.label5.Text = "到";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.dtpEndDate.FillColor = System.Drawing.Color.White;
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.dtpEndDate.Location = new System.Drawing.Point(371, 7);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpEndDate.MaxLength = 10;
            this.dtpEndDate.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.dtpEndDate.Radius = 20;
            this.dtpEndDate.Size = new System.Drawing.Size(203, 31);
            this.dtpEndDate.SymbolDropDown = 61555;
            this.dtpEndDate.SymbolNormal = 61555;
            this.dtpEndDate.TabIndex = 122;
            this.dtpEndDate.Text = "2020-11-24";
            this.dtpEndDate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtpEndDate.Value = new System.DateTime(2020, 11, 24, 22, 50, 36, 791);
            // 
            // txtPosition
            // 
            this.txtPosition.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPosition.FillColor = System.Drawing.Color.White;
            this.txtPosition.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPosition.Location = new System.Drawing.Point(98, 55);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPosition.Maximum = 2147483647D;
            this.txtPosition.Minimum = -2147483648D;
            this.txtPosition.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Padding = new System.Windows.Forms.Padding(5);
            this.txtPosition.Radius = 20;
            this.txtPosition.Size = new System.Drawing.Size(166, 35);
            this.txtPosition.Style = Sunny.UI.UIStyle.Custom;
            this.txtPosition.StyleCustomMode = true;
            this.txtPosition.TabIndex = 124;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label22.Location = new System.Drawing.Point(3, 59);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(88, 25);
            this.label22.TabIndex = 123;
            this.label22.Text = "所任职位";
            // 
            // txtCompany
            // 
            this.txtCompany.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCompany.FillColor = System.Drawing.Color.White;
            this.txtCompany.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCompany.Location = new System.Drawing.Point(365, 55);
            this.txtCompany.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCompany.Maximum = 2147483647D;
            this.txtCompany.Minimum = -2147483648D;
            this.txtCompany.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Padding = new System.Windows.Forms.Padding(5);
            this.txtCompany.Radius = 20;
            this.txtCompany.Size = new System.Drawing.Size(209, 35);
            this.txtCompany.Style = Sunny.UI.UIStyle.Custom;
            this.txtCompany.StyleCustomMode = true;
            this.txtCompany.TabIndex = 126;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(270, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 125;
            this.label6.Text = "企业名称";
            // 
            // ucHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label19);
            this.Name = "ucHistory";
            this.Size = new System.Drawing.Size(581, 100);
            this.Load += new System.EventHandler(this.ucHistory_Load);
            this.SizeChanged += new System.EventHandler(this.ucHistory_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label6;
        public Sunny.UI.UIDatePicker dtpStartDate;
        public Sunny.UI.UIDatePicker dtpEndDate;
        public Sunny.UI.UITextBox txtPosition;
        public Sunny.UI.UITextBox txtCompany;
    }
}
