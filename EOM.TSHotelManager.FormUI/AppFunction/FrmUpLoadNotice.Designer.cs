namespace EOM.TSHotelManager.FormUI
{
    partial class FrmUpLoadNotice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpLoadNotice));
            this.rtbNoticeContent = new KSharpEditor.KEditor();
            this.txtNoticeTheme = new Sunny.UI.UITextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpUpLoadDate = new Sunny.UI.UIDatePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSelectClub = new Sunny.UI.UIComboBox();
            this.btnUpLoad = new Sunny.UI.UIButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNoticeType = new Sunny.UI.UIComboBox();
            this.SuspendLayout();
            // 
            // rtbNoticeContent
            // 
            this.rtbNoticeContent.Html = "<p>&nbsp;</p>";
            this.rtbNoticeContent.KEditorEventListener = null;
            this.rtbNoticeContent.Location = new System.Drawing.Point(6, 99);
            this.rtbNoticeContent.Name = "rtbNoticeContent";
            this.rtbNoticeContent.Size = new System.Drawing.Size(992, 475);
            this.rtbNoticeContent.TabIndex = 24;
            // 
            // txtNoticeTheme
            // 
            this.txtNoticeTheme.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoticeTheme.FillColor = System.Drawing.Color.White;
            this.txtNoticeTheme.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNoticeTheme.Location = new System.Drawing.Point(113, 50);
            this.txtNoticeTheme.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNoticeTheme.Maximum = 2147483647D;
            this.txtNoticeTheme.Minimum = -2147483648D;
            this.txtNoticeTheme.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtNoticeTheme.Name = "txtNoticeTheme";
            this.txtNoticeTheme.Padding = new System.Windows.Forms.Padding(5);
            this.txtNoticeTheme.Radius = 20;
            this.txtNoticeTheme.Size = new System.Drawing.Size(297, 35);
            this.txtNoticeTheme.Style = Sunny.UI.UIStyle.Custom;
            this.txtNoticeTheme.StyleCustomMode = true;
            this.txtNoticeTheme.TabIndex = 112;
            this.txtNoticeTheme.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(12, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 111;
            this.label5.Text = "公告主题";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(702, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 25);
            this.label8.TabIndex = 113;
            this.label8.Text = "发布日期";
            // 
            // dtpUpLoadDate
            // 
            this.dtpUpLoadDate.FillColor = System.Drawing.Color.White;
            this.dtpUpLoadDate.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.dtpUpLoadDate.Location = new System.Drawing.Point(803, 50);
            this.dtpUpLoadDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpUpLoadDate.MaxLength = 10;
            this.dtpUpLoadDate.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtpUpLoadDate.Name = "dtpUpLoadDate";
            this.dtpUpLoadDate.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dtpUpLoadDate.Radius = 20;
            this.dtpUpLoadDate.Size = new System.Drawing.Size(188, 35);
            this.dtpUpLoadDate.SymbolDropDown = 61555;
            this.dtpUpLoadDate.SymbolNormal = 61555;
            this.dtpUpLoadDate.TabIndex = 115;
            this.dtpUpLoadDate.Text = "2021-02-13";
            this.dtpUpLoadDate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtpUpLoadDate.Value = new System.DateTime(2021, 2, 13, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(423, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 116;
            this.label1.Text = "发布部门";
            // 
            // cboSelectClub
            // 
            this.cboSelectClub.DataSource = null;
            this.cboSelectClub.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cboSelectClub.FillColor = System.Drawing.Color.White;
            this.cboSelectClub.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.cboSelectClub.Location = new System.Drawing.Point(524, 50);
            this.cboSelectClub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboSelectClub.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboSelectClub.Name = "cboSelectClub";
            this.cboSelectClub.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboSelectClub.Radius = 20;
            this.cboSelectClub.Size = new System.Drawing.Size(165, 35);
            this.cboSelectClub.TabIndex = 118;
            this.cboSelectClub.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnUpLoad
            // 
            this.btnUpLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpLoad.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnUpLoad.Location = new System.Drawing.Point(857, 582);
            this.btnUpLoad.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnUpLoad.Name = "btnUpLoad";
            this.btnUpLoad.Radius = 20;
            this.btnUpLoad.Size = new System.Drawing.Size(139, 35);
            this.btnUpLoad.TabIndex = 119;
            this.btnUpLoad.Text = "发布任命公告";
            this.btnUpLoad.Click += new System.EventHandler(this.btnUpLoad_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(594, 586);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 120;
            this.label2.Text = "公告类型";
            // 
            // cbNoticeType
            // 
            this.cbNoticeType.DataSource = null;
            this.cbNoticeType.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbNoticeType.FillColor = System.Drawing.Color.White;
            this.cbNoticeType.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.cbNoticeType.Items.AddRange(new object[] {
            "人事变动",
            "普通公告"});
            this.cbNoticeType.Location = new System.Drawing.Point(685, 582);
            this.cbNoticeType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbNoticeType.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbNoticeType.Name = "cbNoticeType";
            this.cbNoticeType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbNoticeType.Radius = 20;
            this.cbNoticeType.Size = new System.Drawing.Size(165, 35);
            this.cbNoticeType.TabIndex = 121;
            this.cbNoticeType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmUpLoadNotice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1005, 623);
            this.ControlBox = false;
            this.Controls.Add(this.cbNoticeType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUpLoad);
            this.Controls.Add(this.cboSelectClub);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpUpLoadDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNoticeTheme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtbNoticeContent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUpLoadNotice";
            this.ShowIcon = true;
            this.ShowTitleIcon = true;
            this.Text = "上传任命公告";
            this.Load += new System.EventHandler(this.FrmUpLoad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private KSharpEditor.KEditor rtbNoticeContent;
        private Sunny.UI.UITextBox txtNoticeTheme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private Sunny.UI.UIDatePicker dtpUpLoadDate;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UIComboBox cboSelectClub;
        private Sunny.UI.UIButton btnUpLoad;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UIComboBox cbNoticeType;
    }
}