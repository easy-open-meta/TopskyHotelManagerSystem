namespace TSHotelManagerSystem
{
    partial class FrmYdYj
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dgvYj = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.yid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ytel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ytime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ydtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFind = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtGl = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.contextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem3 = new DevComponents.DotNetBar.ButtonItem();
            this.btnShow = new DevComponents.DotNetBar.ButtonX();
            this.btnXD = new DevComponents.DotNetBar.ButtonX();
            this.btnDel = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.Location = new System.Drawing.Point(250, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(302, 49);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "预订到期信息一览";
            // 
            // dgvYj
            // 
            this.dgvYj.AllowUserToAddRows = false;
            this.dgvYj.AllowUserToDeleteRows = false;
            this.dgvYj.AllowUserToResizeRows = false;
            this.dgvYj.AutoGenerateColumns = global::MyHotelSystem.Properties.Settings.Default.kong;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvYj.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvYj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yid,
            this.yname,
            this.fno,
            this.ytel,
            this.ytime,
            this.ydtime,
            this.endtime,
            this.uname});
            this.contextMenuBar1.SetContextMenuEx(this.dgvYj, this.buttonItem1);
            this.dgvYj.DataBindings.Add(new System.Windows.Forms.Binding("AutoGenerateColumns", global::MyHotelSystem.Properties.Settings.Default, "kong", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvYj.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvYj.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvYj.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvYj.HighlightSelectedColumnHeaders = false;
            this.dgvYj.Location = new System.Drawing.Point(0, 127);
            this.dgvYj.MultiSelect = false;
            this.dgvYj.Name = "dgvYj";
            this.dgvYj.ReadOnly = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Red;
            this.dgvYj.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvYj.RowTemplate.Height = 23;
            this.dgvYj.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvYj.Size = new System.Drawing.Size(802, 228);
            this.dgvYj.TabIndex = 0;
            // 
            // yid
            // 
            this.yid.DataPropertyName = "yid";
            this.yid.HeaderText = "yid";
            this.yid.Name = "yid";
            this.yid.ReadOnly = true;
            this.yid.Visible = false;
            // 
            // yname
            // 
            this.yname.DataPropertyName = "yname";
            this.yname.HeaderText = "客户姓名";
            this.yname.Name = "yname";
            this.yname.ReadOnly = true;
            this.yname.Width = 110;
            // 
            // fno
            // 
            this.fno.DataPropertyName = "fno";
            this.fno.HeaderText = "房间号";
            this.fno.Name = "fno";
            this.fno.ReadOnly = true;
            this.fno.Width = 70;
            // 
            // ytel
            // 
            this.ytel.DataPropertyName = "ytel";
            this.ytel.HeaderText = "联系电话";
            this.ytel.Name = "ytel";
            this.ytel.ReadOnly = true;
            this.ytel.Width = 120;
            // 
            // ytime
            // 
            this.ytime.DataPropertyName = "ytime";
            dataGridViewCellStyle2.Format = "yyyy-MM-dd HH:mm";
            this.ytime.DefaultCellStyle = dataGridViewCellStyle2;
            this.ytime.HeaderText = "预订时间";
            this.ytime.Name = "ytime";
            this.ytime.ReadOnly = true;
            this.ytime.Width = 130;
            // 
            // ydtime
            // 
            this.ydtime.DataPropertyName = "ydtime";
            dataGridViewCellStyle3.Format = "yyyy-MM-dd HH:mm";
            this.ydtime.DefaultCellStyle = dataGridViewCellStyle3;
            this.ydtime.HeaderText = "预订期限";
            this.ydtime.Name = "ydtime";
            this.ydtime.ReadOnly = true;
            this.ydtime.Width = 130;
            // 
            // endtime
            // 
            this.endtime.DataPropertyName = "endtime";
            this.endtime.HeaderText = "剩余时间";
            this.endtime.Name = "endtime";
            this.endtime.ReadOnly = true;
            this.endtime.Width = 78;
            // 
            // uname
            // 
            this.uname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.uname.DataPropertyName = "uname";
            this.uname.HeaderText = "操作员";
            this.uname.Name = "uname";
            this.uname.ReadOnly = true;
            // 
            // btnFind
            // 
            this.btnFind.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFind.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFind.Image = global::MyHotelSystem.Properties.Resources.TuQuery;
            this.btnFind.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnFind.Location = new System.Drawing.Point(287, 75);
            this.btnFind.Name = "btnFind";
            this.btnFind.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnFind.Size = new System.Drawing.Size(118, 35);
            this.btnFind.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFind.TabIndex = 42;
            this.btnFind.Text = "查 找";
            this.btnFind.Click += new System.EventHandler(this.txtGl_TextChanged);
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(40, 83);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(105, 18);
            this.labelX2.TabIndex = 43;
            this.labelX2.Text = "客户姓名/房间号:";
            // 
            // txtGl
            // 
            // 
            // 
            // 
            this.txtGl.Border.Class = "TextBoxBorder";
            this.txtGl.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGl.Location = new System.Drawing.Point(146, 82);
            this.txtGl.MaxLength = 20;
            this.txtGl.Name = "txtGl";
            this.txtGl.Size = new System.Drawing.Size(131, 21);
            this.txtGl.TabIndex = 44;
            this.txtGl.TextChanged += new System.EventHandler(this.txtGl_TextChanged);
            // 
            // contextMenuBar1
            // 
            this.contextMenuBar1.AntiAlias = true;
            this.contextMenuBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1});
            this.contextMenuBar1.Location = new System.Drawing.Point(0, 0);
            this.contextMenuBar1.Name = "contextMenuBar1";
            this.contextMenuBar1.Size = new System.Drawing.Size(124, 27);
            this.contextMenuBar1.Stretch = true;
            this.contextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.contextMenuBar1.TabIndex = 45;
            this.contextMenuBar1.TabStop = false;
            this.contextMenuBar1.Text = "contextMenuBar1";
            // 
            // buttonItem1
            // 
            this.buttonItem1.AutoExpandOnClick = true;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem2,
            this.buttonItem3});
            this.buttonItem1.Text = "buttonItem1";
            // 
            // buttonItem2
            // 
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.Text = "刷新信息";
            this.buttonItem2.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // buttonItem3
            // 
            this.buttonItem3.Name = "buttonItem3";
            this.buttonItem3.Text = "续订时间";
            this.buttonItem3.Click += new System.EventHandler(this.btnXD_Click);
            // 
            // btnShow
            // 
            this.btnShow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnShow.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnShow.Image = global::MyHotelSystem.Properties.Resources.TuQueryAll;
            this.btnShow.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnShow.Location = new System.Drawing.Point(421, 75);
            this.btnShow.Name = "btnShow";
            this.btnShow.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnShow.Size = new System.Drawing.Size(104, 35);
            this.btnShow.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnShow.TabIndex = 64;
            this.btnShow.Text = "刷 新";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnXD
            // 
            this.btnXD.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXD.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXD.Image = global::MyHotelSystem.Properties.Resources.TuAdd;
            this.btnXD.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnXD.Location = new System.Drawing.Point(541, 75);
            this.btnXD.Name = "btnXD";
            this.btnXD.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnXD.Size = new System.Drawing.Size(104, 35);
            this.btnXD.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXD.TabIndex = 64;
            this.btnXD.Text = "续订时间";
            this.btnXD.Click += new System.EventHandler(this.btnXD_Click);
            // 
            // btnDel
            // 
            this.btnDel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDel.Image = global::MyHotelSystem.Properties.Resources.TuCancel;
            this.btnDel.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnDel.Location = new System.Drawing.Point(661, 75);
            this.btnDel.Name = "btnDel";
            this.btnDel.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnDel.Size = new System.Drawing.Size(104, 35);
            this.btnDel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDel.TabIndex = 64;
            this.btnDel.Text = "取消预订";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // FrmYdYj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 355);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnXD);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.contextMenuBar1);
            this.Controls.Add(this.txtGl);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.dgvYj);
            this.Name = "FrmYdYj";
            this.Text = "预订预警信息";
            this.Load += new System.EventHandler(this.FrmYdYj_Load);
            this.Shown += new System.EventHandler(this.FrmYdYj_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvYj;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn yid;
        private System.Windows.Forms.DataGridViewTextBoxColumn yname;
        private System.Windows.Forms.DataGridViewTextBoxColumn fno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ytel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ytime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ydtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn endtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn uname;
        private DevComponents.DotNetBar.ButtonX btnFind;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGl;
        private DevComponents.DotNetBar.ContextMenuBar contextMenuBar1;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.ButtonX btnShow;
        private DevComponents.DotNetBar.ButtonX btnXD;
        private DevComponents.DotNetBar.ButtonItem buttonItem3;
        private DevComponents.DotNetBar.ButtonX btnDel;
    }
}