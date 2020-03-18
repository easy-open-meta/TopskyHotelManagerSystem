namespace TSHotelManagerSystem
{
    partial class FrmUpLoad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpLoad));
            this.UpLoadNotice = new System.Windows.Forms.Button();
            this.pnlUpLoad = new System.Windows.Forms.Panel();
            this.txtNoticePerson = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboSelectClub = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpLoad = new System.Windows.Forms.Button();
            this.rtbNoticeContent = new System.Windows.Forms.RichTextBox();
            this.dtpUpLoadDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNoticeTheme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUpLoadNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvNoticeList = new System.Windows.Forms.DataGridView();
            this.clNoticeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNoticetheme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNoticeContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlUpLoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoticeList)).BeginInit();
            this.SuspendLayout();
            // 
            // UpLoadNotice
            // 
            this.UpLoadNotice.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.UpLoadNotice.FlatAppearance.BorderSize = 0;
            this.UpLoadNotice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpLoadNotice.Location = new System.Drawing.Point(12, 12);
            this.UpLoadNotice.Name = "UpLoadNotice";
            this.UpLoadNotice.Size = new System.Drawing.Size(103, 23);
            this.UpLoadNotice.TabIndex = 0;
            this.UpLoadNotice.Text = "上传任命公告";
            this.UpLoadNotice.UseVisualStyleBackColor = false;
            this.UpLoadNotice.Click += new System.EventHandler(this.UpLoadNotice_Click);
            // 
            // pnlUpLoad
            // 
            this.pnlUpLoad.Controls.Add(this.txtNoticePerson);
            this.pnlUpLoad.Controls.Add(this.label6);
            this.pnlUpLoad.Controls.Add(this.cboSelectClub);
            this.pnlUpLoad.Controls.Add(this.label4);
            this.pnlUpLoad.Controls.Add(this.btnUpLoad);
            this.pnlUpLoad.Controls.Add(this.rtbNoticeContent);
            this.pnlUpLoad.Controls.Add(this.dtpUpLoadDate);
            this.pnlUpLoad.Controls.Add(this.label3);
            this.pnlUpLoad.Controls.Add(this.txtNoticeTheme);
            this.pnlUpLoad.Controls.Add(this.label2);
            this.pnlUpLoad.Controls.Add(this.txtUpLoadNo);
            this.pnlUpLoad.Controls.Add(this.label1);
            this.pnlUpLoad.Location = new System.Drawing.Point(3, 37);
            this.pnlUpLoad.Name = "pnlUpLoad";
            this.pnlUpLoad.Size = new System.Drawing.Size(614, 456);
            this.pnlUpLoad.TabIndex = 1;
            this.pnlUpLoad.Visible = false;
            // 
            // txtNoticePerson
            // 
            this.txtNoticePerson.Location = new System.Drawing.Point(403, 423);
            this.txtNoticePerson.Name = "txtNoticePerson";
            this.txtNoticePerson.Size = new System.Drawing.Size(88, 21);
            this.txtNoticePerson.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 427);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "发布人：";
            // 
            // cboSelectClub
            // 
            this.cboSelectClub.FormattingEnabled = true;
            this.cboSelectClub.Items.AddRange(new object[] {
            "人力资源管理部"});
            this.cboSelectClub.Location = new System.Drawing.Point(229, 424);
            this.cboSelectClub.Name = "cboSelectClub";
            this.cboSelectClub.Size = new System.Drawing.Size(114, 20);
            this.cboSelectClub.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "发布部门：";
            // 
            // btnUpLoad
            // 
            this.btnUpLoad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpLoad.BackgroundImage")));
            this.btnUpLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpLoad.FlatAppearance.BorderSize = 0;
            this.btnUpLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpLoad.Location = new System.Drawing.Point(497, 422);
            this.btnUpLoad.Name = "btnUpLoad";
            this.btnUpLoad.Size = new System.Drawing.Size(75, 23);
            this.btnUpLoad.TabIndex = 7;
            this.btnUpLoad.Text = "发布";
            this.btnUpLoad.UseVisualStyleBackColor = true;
            this.btnUpLoad.Click += new System.EventHandler(this.btnUpLoad_Click);
            // 
            // rtbNoticeContent
            // 
            this.rtbNoticeContent.Font = new System.Drawing.Font("华文中宋", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtbNoticeContent.Location = new System.Drawing.Point(0, 47);
            this.rtbNoticeContent.Name = "rtbNoticeContent";
            this.rtbNoticeContent.Size = new System.Drawing.Size(611, 365);
            this.rtbNoticeContent.TabIndex = 6;
            this.rtbNoticeContent.Text = "";
            // 
            // dtpUpLoadDate
            // 
            this.dtpUpLoadDate.Location = new System.Drawing.Point(509, 14);
            this.dtpUpLoadDate.Name = "dtpUpLoadDate";
            this.dtpUpLoadDate.Size = new System.Drawing.Size(101, 21);
            this.dtpUpLoadDate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(428, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "发布日期：";
            // 
            // txtNoticeTheme
            // 
            this.txtNoticeTheme.Location = new System.Drawing.Point(277, 14);
            this.txtNoticeTheme.Name = "txtNoticeTheme";
            this.txtNoticeTheme.Size = new System.Drawing.Size(145, 21);
            this.txtNoticeTheme.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(194, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "公告主题：";
            // 
            // txtUpLoadNo
            // 
            this.txtUpLoadNo.Location = new System.Drawing.Point(88, 14);
            this.txtUpLoadNo.Name = "txtUpLoadNo";
            this.txtUpLoadNo.Size = new System.Drawing.Size(100, 21);
            this.txtUpLoadNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "公告编号：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("隶书", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(756, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 29);
            this.label5.TabIndex = 108;
            this.label5.Text = "历史公告";
            // 
            // dgvNoticeList
            // 
            this.dgvNoticeList.AllowUserToAddRows = false;
            this.dgvNoticeList.AllowUserToDeleteRows = false;
            this.dgvNoticeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNoticeList.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgvNoticeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNoticeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clNoticeNo,
            this.clNoticetheme,
            this.clNoticeContent});
            this.dgvNoticeList.Location = new System.Drawing.Point(619, 37);
            this.dgvNoticeList.Name = "dgvNoticeList";
            this.dgvNoticeList.ReadOnly = true;
            this.dgvNoticeList.RowTemplate.Height = 23;
            this.dgvNoticeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNoticeList.Size = new System.Drawing.Size(368, 456);
            this.dgvNoticeList.TabIndex = 109;
            this.dgvNoticeList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNoticeList_CellClick);
            // 
            // clNoticeNo
            // 
            this.clNoticeNo.DataPropertyName = "NoticeNo";
            this.clNoticeNo.HeaderText = "公告编号";
            this.clNoticeNo.Name = "clNoticeNo";
            this.clNoticeNo.ReadOnly = true;
            // 
            // clNoticetheme
            // 
            this.clNoticetheme.DataPropertyName = "Noticetheme";
            this.clNoticetheme.HeaderText = "公告主题";
            this.clNoticetheme.Name = "clNoticetheme";
            this.clNoticetheme.ReadOnly = true;
            // 
            // clNoticeContent
            // 
            this.clNoticeContent.DataPropertyName = "NoticeContent";
            this.clNoticeContent.HeaderText = "公告正文";
            this.clNoticeContent.Name = "clNoticeContent";
            this.clNoticeContent.ReadOnly = true;
            // 
            // FrmUpLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(989, 497);
            this.Controls.Add(this.dgvNoticeList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnlUpLoad);
            this.Controls.Add(this.UpLoadNotice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUpLoad";
            this.Text = "FrmCashList";
            this.Load += new System.EventHandler(this.FrmUpLoad_Load);
            this.pnlUpLoad.ResumeLayout(false);
            this.pnlUpLoad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoticeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpLoadNotice;
        private System.Windows.Forms.Panel pnlUpLoad;
        private System.Windows.Forms.Button btnUpLoad;
        private System.Windows.Forms.RichTextBox rtbNoticeContent;
        private System.Windows.Forms.DateTimePicker dtpUpLoadDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNoticeTheme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUpLoadNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSelectClub;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvNoticeList;
        private System.Windows.Forms.TextBox txtNoticePerson;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNoticeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNoticetheme;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNoticeContent;
    }
}