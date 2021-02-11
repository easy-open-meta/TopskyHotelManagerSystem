namespace SYS.FormUI
{
    partial class FrmCash
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCashList = new Sunny.UI.UIDataGridView();
            this.clAssetsNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAssetsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAssetsValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStorageTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAssetsSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAssetsManager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.txtCashNo = new Sunny.UI.UITextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCashName = new Sunny.UI.UITextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCashMoney = new Sunny.UI.UITextBox();
            this.cboClub = new Sunny.UI.UIComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDate = new Sunny.UI.UIDatePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFrom = new Sunny.UI.UITextBox();
            this.btnOK = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashList)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCashList
            // 
            this.dgvCashList.AllowUserToAddRows = false;
            this.dgvCashList.AllowUserToDeleteRows = false;
            this.dgvCashList.AllowUserToResizeColumns = false;
            this.dgvCashList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvCashList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCashList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCashList.BackgroundColor = System.Drawing.Color.White;
            this.dgvCashList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCashList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCashList.ColumnHeadersHeight = 32;
            this.dgvCashList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCashList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clAssetsNo,
            this.clAssetsName,
            this.clAssetsValue,
            this.clDepartment,
            this.clStorageTime,
            this.clAssetsSource,
            this.clAssetsManager});
            this.dgvCashList.EnableHeadersVisualStyles = false;
            this.dgvCashList.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgvCashList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvCashList.Location = new System.Drawing.Point(12, 12);
            this.dgvCashList.Name = "dgvCashList";
            this.dgvCashList.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgvCashList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCashList.RowTemplate.Height = 29;
            this.dgvCashList.SelectedIndex = -1;
            this.dgvCashList.ShowGridLine = true;
            this.dgvCashList.Size = new System.Drawing.Size(800, 599);
            this.dgvCashList.Style = Sunny.UI.UIStyle.Custom;
            this.dgvCashList.TabIndex = 2;
            // 
            // clAssetsNo
            // 
            this.clAssetsNo.DataPropertyName = "CashNo";
            this.clAssetsNo.HeaderText = "资产编号";
            this.clAssetsNo.Name = "clAssetsNo";
            // 
            // clAssetsName
            // 
            this.clAssetsName.DataPropertyName = "CashName";
            this.clAssetsName.HeaderText = "资产名称";
            this.clAssetsName.Name = "clAssetsName";
            // 
            // clAssetsValue
            // 
            this.clAssetsValue.DataPropertyName = "CashPrice";
            this.clAssetsValue.HeaderText = "资产总值";
            this.clAssetsValue.Name = "clAssetsValue";
            // 
            // clDepartment
            // 
            this.clDepartment.DataPropertyName = "CashClub";
            this.clDepartment.HeaderText = "所属部门";
            this.clDepartment.Name = "clDepartment";
            // 
            // clStorageTime
            // 
            this.clStorageTime.DataPropertyName = "CashTime";
            this.clStorageTime.HeaderText = "入库时间";
            this.clStorageTime.Name = "clStorageTime";
            // 
            // clAssetsSource
            // 
            this.clAssetsSource.DataPropertyName = "CashSource";
            this.clAssetsSource.HeaderText = "资产来源";
            this.clAssetsSource.Name = "clAssetsSource";
            // 
            // clAssetsManager
            // 
            this.clAssetsManager.DataPropertyName = "CashPerson";
            this.clAssetsManager.HeaderText = "资产经办人";
            this.clAssetsManager.Name = "clAssetsManager";
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.btnOK);
            this.uiGroupBox1.Controls.Add(this.label11);
            this.uiGroupBox1.Controls.Add(this.txtFrom);
            this.uiGroupBox1.Controls.Add(this.label10);
            this.uiGroupBox1.Controls.Add(this.label9);
            this.uiGroupBox1.Controls.Add(this.cboClub);
            this.uiGroupBox1.Controls.Add(this.label8);
            this.uiGroupBox1.Controls.Add(this.txtCashMoney);
            this.uiGroupBox1.Controls.Add(this.label7);
            this.uiGroupBox1.Controls.Add(this.txtCashName);
            this.uiGroupBox1.Controls.Add(this.label20);
            this.uiGroupBox1.Controls.Add(this.txtCashNo);
            this.uiGroupBox1.Controls.Add(this.dtpDate);
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox1.Location = new System.Drawing.Point(819, 12);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(173, 599);
            this.uiGroupBox1.TabIndex = 3;
            this.uiGroupBox1.Text = "信息录入栏";
            // 
            // txtCashNo
            // 
            this.txtCashNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCashNo.FillColor = System.Drawing.Color.White;
            this.txtCashNo.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCashNo.Location = new System.Drawing.Point(4, 67);
            this.txtCashNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCashNo.Maximum = 2147483647D;
            this.txtCashNo.Minimum = -2147483648D;
            this.txtCashNo.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtCashNo.Name = "txtCashNo";
            this.txtCashNo.Padding = new System.Windows.Forms.Padding(5);
            this.txtCashNo.Radius = 20;
            this.txtCashNo.ReadOnly = true;
            this.txtCashNo.Size = new System.Drawing.Size(165, 35);
            this.txtCashNo.Style = Sunny.UI.UIStyle.Custom;
            this.txtCashNo.StyleCustomMode = true;
            this.txtCashNo.TabIndex = 136;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(42, 33);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(88, 25);
            this.label20.TabIndex = 137;
            this.label20.Text = "资产编号";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(42, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 25);
            this.label7.TabIndex = 139;
            this.label7.Text = "资产名称";
            // 
            // txtCashName
            // 
            this.txtCashName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCashName.FillColor = System.Drawing.Color.White;
            this.txtCashName.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCashName.Location = new System.Drawing.Point(4, 145);
            this.txtCashName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCashName.Maximum = 2147483647D;
            this.txtCashName.Minimum = -2147483648D;
            this.txtCashName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtCashName.Name = "txtCashName";
            this.txtCashName.Padding = new System.Windows.Forms.Padding(5);
            this.txtCashName.Radius = 20;
            this.txtCashName.ReadOnly = true;
            this.txtCashName.Size = new System.Drawing.Size(165, 35);
            this.txtCashName.Style = Sunny.UI.UIStyle.Custom;
            this.txtCashName.StyleCustomMode = true;
            this.txtCashName.TabIndex = 138;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(42, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 25);
            this.label8.TabIndex = 141;
            this.label8.Text = "资产总值";
            // 
            // txtCashMoney
            // 
            this.txtCashMoney.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCashMoney.FillColor = System.Drawing.Color.White;
            this.txtCashMoney.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCashMoney.Location = new System.Drawing.Point(4, 223);
            this.txtCashMoney.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCashMoney.Maximum = 2147483647D;
            this.txtCashMoney.Minimum = -2147483648D;
            this.txtCashMoney.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtCashMoney.Name = "txtCashMoney";
            this.txtCashMoney.Padding = new System.Windows.Forms.Padding(5);
            this.txtCashMoney.Radius = 20;
            this.txtCashMoney.ReadOnly = true;
            this.txtCashMoney.Size = new System.Drawing.Size(165, 35);
            this.txtCashMoney.Style = Sunny.UI.UIStyle.Custom;
            this.txtCashMoney.StyleCustomMode = true;
            this.txtCashMoney.TabIndex = 140;
            // 
            // cboClub
            // 
            this.cboClub.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cboClub.FillColor = System.Drawing.Color.White;
            this.cboClub.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.cboClub.Location = new System.Drawing.Point(4, 301);
            this.cboClub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboClub.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboClub.Name = "cboClub";
            this.cboClub.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cboClub.Radius = 20;
            this.cboClub.Size = new System.Drawing.Size(165, 35);
            this.cboClub.TabIndex = 142;
            this.cboClub.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboClub.Watermark = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(42, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 25);
            this.label9.TabIndex = 143;
            this.label9.Text = "所属部门";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(23, 345);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 25);
            this.label10.TabIndex = 145;
            this.label10.Text = "资产入库时间";
            // 
            // dtpDate
            // 
            this.dtpDate.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.dtpDate.FillColor = System.Drawing.Color.White;
            this.dtpDate.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.dtpDate.Location = new System.Drawing.Point(4, 379);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDate.MaxLength = 10;
            this.dtpDate.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.dtpDate.Radius = 20;
            this.dtpDate.Size = new System.Drawing.Size(165, 35);
            this.dtpDate.SymbolDropDown = 61555;
            this.dtpDate.SymbolNormal = 61555;
            this.dtpDate.TabIndex = 146;
            this.dtpDate.Value = new System.DateTime(2021, 1, 31, 14, 30, 7, 297);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(42, 423);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 25);
            this.label11.TabIndex = 148;
            this.label11.Text = "资产来源";
            // 
            // txtFrom
            // 
            this.txtFrom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFrom.FillColor = System.Drawing.Color.White;
            this.txtFrom.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFrom.Location = new System.Drawing.Point(4, 457);
            this.txtFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFrom.Maximum = 2147483647D;
            this.txtFrom.Minimum = -2147483648D;
            this.txtFrom.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Padding = new System.Windows.Forms.Padding(5);
            this.txtFrom.Radius = 20;
            this.txtFrom.ReadOnly = true;
            this.txtFrom.Size = new System.Drawing.Size(165, 35);
            this.txtFrom.Style = Sunny.UI.UIStyle.Custom;
            this.txtFrom.StyleCustomMode = true;
            this.txtFrom.TabIndex = 147;
            // 
            // btnOK
            // 
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnOK.Location = new System.Drawing.Point(30, 522);
            this.btnOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOK.Name = "btnOK";
            this.btnOK.Radius = 20;
            this.btnOK.Size = new System.Drawing.Size(112, 43);
            this.btnOK.TabIndex = 149;
            this.btnOK.Text = "录入";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FrmCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1005, 623);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.dgvCashList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCash";
            this.Text = "FrmCash";
            this.Load += new System.EventHandler(this.FrmCash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashList)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIDataGridView dgvCashList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAssetsNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAssetsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAssetsValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStorageTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAssetsSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAssetsManager;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UITextBox txtCashNo;
        private System.Windows.Forms.Label label8;
        private Sunny.UI.UITextBox txtCashMoney;
        private System.Windows.Forms.Label label7;
        private Sunny.UI.UITextBox txtCashName;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private Sunny.UI.UIComboBox cboClub;
        private Sunny.UI.UIButton btnOK;
        private System.Windows.Forms.Label label11;
        private Sunny.UI.UITextBox txtFrom;
        private Sunny.UI.UIDatePicker dtpDate;
    }
}