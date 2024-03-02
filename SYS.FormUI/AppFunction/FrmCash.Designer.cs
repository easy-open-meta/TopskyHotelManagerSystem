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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCash));
            this.dgvCashList = new Sunny.UI.UIDataGridView();
            this.clAssetsNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAssetsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAssetsValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStorageTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAssetsSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAssetsManager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboCashPerson = new Sunny.UI.UIComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new Sunny.UI.UIButton();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFrom = new Sunny.UI.UITextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboClub = new Sunny.UI.UIComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCashMoney = new Sunny.UI.UITextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCashName = new Sunny.UI.UITextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtCashNo = new Sunny.UI.UITextBox();
            this.dtpDate = new Sunny.UI.UIDatePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashList)).BeginInit();
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
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCashList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCashList.EnableHeadersVisualStyles = false;
            this.dgvCashList.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgvCashList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvCashList.Location = new System.Drawing.Point(3, 38);
            this.dgvCashList.Name = "dgvCashList";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCashList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCashList.RowHeadersVisible = false;
            this.dgvCashList.RowHeight = 29;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvCashList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCashList.RowTemplate.Height = 29;
            this.dgvCashList.SelectedIndex = -1;
            this.dgvCashList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCashList.ShowGridLine = true;
            this.dgvCashList.Size = new System.Drawing.Size(809, 582);
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
            this.clAssetsValue.DataPropertyName = "CashPriceStr";
            this.clAssetsValue.HeaderText = "资产总值";
            this.clAssetsValue.Name = "clAssetsValue";
            // 
            // clDepartment
            // 
            this.clDepartment.DataPropertyName = "DeptName";
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
            this.clAssetsManager.DataPropertyName = "PersonName";
            this.clAssetsManager.HeaderText = "资产经办人";
            this.clAssetsManager.Name = "clAssetsManager";
            // 
            // cboCashPerson
            // 
            this.cboCashPerson.DataSource = null;
            this.cboCashPerson.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cboCashPerson.FillColor = System.Drawing.Color.White;
            this.cboCashPerson.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboCashPerson.Location = new System.Drawing.Point(826, 520);
            this.cboCashPerson.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboCashPerson.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboCashPerson.Name = "cboCashPerson";
            this.cboCashPerson.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboCashPerson.Radius = 20;
            this.cboCashPerson.Size = new System.Drawing.Size(165, 23);
            this.cboCashPerson.TabIndex = 167;
            this.cboCashPerson.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboCashPerson.Watermark = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(864, 492);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 166;
            this.label1.Text = "资产经办人";
            // 
            // btnOK
            // 
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnOK.Location = new System.Drawing.Point(852, 565);
            this.btnOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOK.Name = "btnOK";
            this.btnOK.Radius = 20;
            this.btnOK.Size = new System.Drawing.Size(112, 33);
            this.btnOK.TabIndex = 165;
            this.btnOK.Text = "录入";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(864, 419);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 14);
            this.label11.TabIndex = 164;
            this.label11.Text = "资产来源";
            // 
            // txtFrom
            // 
            this.txtFrom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFrom.FillColor = System.Drawing.Color.White;
            this.txtFrom.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFrom.Location = new System.Drawing.Point(826, 451);
            this.txtFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFrom.Maximum = 2147483647D;
            this.txtFrom.Minimum = -2147483648D;
            this.txtFrom.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Padding = new System.Windows.Forms.Padding(5);
            this.txtFrom.Radius = 20;
            this.txtFrom.Size = new System.Drawing.Size(165, 23);
            this.txtFrom.Style = Sunny.UI.UIStyle.Custom;
            this.txtFrom.StyleCustomMode = true;
            this.txtFrom.TabIndex = 163;
            this.txtFrom.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(845, 346);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 14);
            this.label10.TabIndex = 161;
            this.label10.Text = "资产入库时间";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(864, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 14);
            this.label9.TabIndex = 160;
            this.label9.Text = "所属部门";
            // 
            // cboClub
            // 
            this.cboClub.DataSource = null;
            this.cboClub.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cboClub.FillColor = System.Drawing.Color.White;
            this.cboClub.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboClub.Location = new System.Drawing.Point(826, 305);
            this.cboClub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboClub.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboClub.Name = "cboClub";
            this.cboClub.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboClub.Radius = 20;
            this.cboClub.Size = new System.Drawing.Size(165, 23);
            this.cboClub.TabIndex = 159;
            this.cboClub.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboClub.Watermark = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(864, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 14);
            this.label8.TabIndex = 158;
            this.label8.Text = "资产总值";
            // 
            // txtCashMoney
            // 
            this.txtCashMoney.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCashMoney.FillColor = System.Drawing.Color.White;
            this.txtCashMoney.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCashMoney.Location = new System.Drawing.Point(826, 232);
            this.txtCashMoney.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCashMoney.Maximum = 2147483647D;
            this.txtCashMoney.Minimum = -2147483648D;
            this.txtCashMoney.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtCashMoney.Name = "txtCashMoney";
            this.txtCashMoney.Padding = new System.Windows.Forms.Padding(5);
            this.txtCashMoney.Radius = 20;
            this.txtCashMoney.Size = new System.Drawing.Size(165, 23);
            this.txtCashMoney.Style = Sunny.UI.UIStyle.Custom;
            this.txtCashMoney.StyleCustomMode = true;
            this.txtCashMoney.TabIndex = 157;
            this.txtCashMoney.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(864, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 14);
            this.label7.TabIndex = 156;
            this.label7.Text = "资产名称";
            // 
            // txtCashName
            // 
            this.txtCashName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCashName.FillColor = System.Drawing.Color.White;
            this.txtCashName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCashName.Location = new System.Drawing.Point(826, 159);
            this.txtCashName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCashName.Maximum = 2147483647D;
            this.txtCashName.Minimum = -2147483648D;
            this.txtCashName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtCashName.Name = "txtCashName";
            this.txtCashName.Padding = new System.Windows.Forms.Padding(5);
            this.txtCashName.Radius = 20;
            this.txtCashName.Size = new System.Drawing.Size(165, 23);
            this.txtCashName.Style = Sunny.UI.UIStyle.Custom;
            this.txtCashName.StyleCustomMode = true;
            this.txtCashName.TabIndex = 155;
            this.txtCashName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(864, 59);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 14);
            this.label20.TabIndex = 154;
            this.label20.Text = "资产编号";
            // 
            // txtCashNo
            // 
            this.txtCashNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCashNo.FillColor = System.Drawing.Color.White;
            this.txtCashNo.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCashNo.Location = new System.Drawing.Point(826, 86);
            this.txtCashNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCashNo.Maximum = 2147483647D;
            this.txtCashNo.Minimum = -2147483648D;
            this.txtCashNo.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtCashNo.Name = "txtCashNo";
            this.txtCashNo.Padding = new System.Windows.Forms.Padding(5);
            this.txtCashNo.Radius = 20;
            this.txtCashNo.ReadOnly = true;
            this.txtCashNo.Size = new System.Drawing.Size(165, 23);
            this.txtCashNo.Style = Sunny.UI.UIStyle.Custom;
            this.txtCashNo.StyleCustomMode = true;
            this.txtCashNo.TabIndex = 153;
            this.txtCashNo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpDate
            // 
            this.dtpDate.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.dtpDate.FillColor = System.Drawing.Color.White;
            this.dtpDate.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpDate.Location = new System.Drawing.Point(826, 378);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDate.MaxLength = 10;
            this.dtpDate.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dtpDate.Radius = 20;
            this.dtpDate.Size = new System.Drawing.Size(165, 23);
            this.dtpDate.SymbolDropDown = 61555;
            this.dtpDate.SymbolNormal = 61555;
            this.dtpDate.TabIndex = 162;
            this.dtpDate.Text = "2021-01-31";
            this.dtpDate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtpDate.Value = new System.DateTime(2021, 1, 31, 14, 30, 7, 297);
            // 
            // FrmCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1005, 623);
            this.ControlBox = false;
            this.Controls.Add(this.cboCashPerson);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboClub);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCashMoney);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCashName);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtCashNo);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.dgvCashList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsForbidAltF4 = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCash";
            this.ShowIcon = true;
            this.ShowTitleIcon = true;
            this.Text = "内部财务账单";
            this.Load += new System.EventHandler(this.FrmCash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UIDataGridView dgvCashList;
        private Sunny.UI.UIComboBox cboCashPerson;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UIButton btnOK;
        private System.Windows.Forms.Label label11;
        private Sunny.UI.UITextBox txtFrom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private Sunny.UI.UIComboBox cboClub;
        private System.Windows.Forms.Label label8;
        private Sunny.UI.UITextBox txtCashMoney;
        private System.Windows.Forms.Label label7;
        private Sunny.UI.UITextBox txtCashName;
        private System.Windows.Forms.Label label20;
        private Sunny.UI.UITextBox txtCashNo;
        private Sunny.UI.UIDatePicker dtpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAssetsNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAssetsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAssetsValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStorageTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAssetsSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAssetsManager;
    }
}