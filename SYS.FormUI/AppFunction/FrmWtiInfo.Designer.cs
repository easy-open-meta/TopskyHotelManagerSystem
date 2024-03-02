namespace SYS.FormUI
{
    partial class FrmWtiInfo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWtiInfo));
            this.dgvWti = new Sunny.UI.UIDataGridView();
            this.clWtiNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRoomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clWaterUse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPowerUse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRecord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCustoNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdWti = new Sunny.UI.UIButton();
            this.pnlWtiInfo = new Sunny.UI.UIPanel();
            this.btnClose = new Sunny.UI.UIButton();
            this.txtCustoNo = new Sunny.UI.UITextBox();
            this.dtpEndDate = new Sunny.UI.UIDatePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStartDate = new Sunny.UI.UIDatePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWInfo = new Sunny.UI.UITextBox();
            this.txtRecordNo = new Sunny.UI.UITextBox();
            this.txtRoomNo = new Sunny.UI.UITextBox();
            this.txtTInfo = new Sunny.UI.UITextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uiToolTip1 = new Sunny.UI.UIToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWti)).BeginInit();
            this.pnlWtiInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvWti
            // 
            this.dgvWti.AllowUserToAddRows = false;
            this.dgvWti.AllowUserToDeleteRows = false;
            this.dgvWti.AllowUserToResizeColumns = false;
            this.dgvWti.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvWti.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWti.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvWti.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvWti.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvWti.ColumnHeadersHeight = 32;
            this.dgvWti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvWti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clWtiNo,
            this.clRoomNo,
            this.clUseDate,
            this.clEndDate,
            this.clWaterUse,
            this.clPowerUse,
            this.clRecord,
            this.clCustoNo,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWti.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvWti.EnableHeadersVisualStyles = false;
            this.dgvWti.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgvWti.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvWti.Location = new System.Drawing.Point(12, 48);
            this.dgvWti.MultiSelect = false;
            this.dgvWti.Name = "dgvWti";
            this.dgvWti.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWti.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvWti.RowHeadersVisible = false;
            this.dgvWti.RowHeight = 29;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvWti.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvWti.RowTemplate.Height = 29;
            this.dgvWti.SelectedIndex = -1;
            this.dgvWti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWti.Size = new System.Drawing.Size(981, 528);
            this.dgvWti.Style = Sunny.UI.UIStyle.Custom;
            this.dgvWti.TabIndex = 58;
            this.uiToolTip1.SetToolTip(this.dgvWti, "双击数据可进行修改！");
            this.dgvWti.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWti_CellDoubleClick);
            // 
            // clWtiNo
            // 
            this.clWtiNo.DataPropertyName = "WtiNo";
            this.clWtiNo.HeaderText = "记录编号";
            this.clWtiNo.Name = "clWtiNo";
            this.clWtiNo.ReadOnly = true;
            // 
            // clRoomNo
            // 
            this.clRoomNo.DataPropertyName = "RoomNo";
            this.clRoomNo.HeaderText = "房号";
            this.clRoomNo.Name = "clRoomNo";
            this.clRoomNo.ReadOnly = true;
            // 
            // clUseDate
            // 
            this.clUseDate.DataPropertyName = "UseDate";
            this.clUseDate.HeaderText = "开始使用时间";
            this.clUseDate.Name = "clUseDate";
            this.clUseDate.ReadOnly = true;
            // 
            // clEndDate
            // 
            this.clEndDate.DataPropertyName = "EndDate";
            this.clEndDate.HeaderText = "结束使用时间";
            this.clEndDate.Name = "clEndDate";
            this.clEndDate.ReadOnly = true;
            // 
            // clWaterUse
            // 
            this.clWaterUse.DataPropertyName = "WaterUse";
            this.clWaterUse.HeaderText = "水费";
            this.clWaterUse.Name = "clWaterUse";
            this.clWaterUse.ReadOnly = true;
            // 
            // clPowerUse
            // 
            this.clPowerUse.DataPropertyName = "PowerUse";
            this.clPowerUse.HeaderText = "电费";
            this.clPowerUse.Name = "clPowerUse";
            this.clPowerUse.ReadOnly = true;
            // 
            // clRecord
            // 
            this.clRecord.DataPropertyName = "Record";
            this.clRecord.HeaderText = "记录员";
            this.clRecord.Name = "clRecord";
            this.clRecord.ReadOnly = true;
            // 
            // clCustoNo
            // 
            this.clCustoNo.DataPropertyName = "CustoNo";
            this.clCustoNo.HeaderText = "客户编号";
            this.clCustoNo.Name = "clCustoNo";
            this.clCustoNo.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "delete_mk";
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "datains_usr";
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "datains_date";
            this.Column9.HeaderText = "Column9";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "datachg_usr";
            this.Column10.HeaderText = "Column10";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "datachg_date";
            this.Column11.HeaderText = "Column11";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Visible = false;
            // 
            // btnUpdWti
            // 
            this.btnUpdWti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdWti.Enabled = false;
            this.btnUpdWti.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnUpdWti.Location = new System.Drawing.Point(525, 416);
            this.btnUpdWti.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnUpdWti.Name = "btnUpdWti";
            this.btnUpdWti.Radius = 20;
            this.btnUpdWti.Size = new System.Drawing.Size(109, 28);
            this.btnUpdWti.Style = Sunny.UI.UIStyle.Custom;
            this.btnUpdWti.TabIndex = 131;
            this.btnUpdWti.Text = "修    改";
            this.btnUpdWti.Click += new System.EventHandler(this.btnUpdWti_Click);
            // 
            // pnlWtiInfo
            // 
            this.pnlWtiInfo.Controls.Add(this.btnClose);
            this.pnlWtiInfo.Controls.Add(this.txtCustoNo);
            this.pnlWtiInfo.Controls.Add(this.btnUpdWti);
            this.pnlWtiInfo.Controls.Add(this.dtpEndDate);
            this.pnlWtiInfo.Controls.Add(this.label1);
            this.pnlWtiInfo.Controls.Add(this.dtpStartDate);
            this.pnlWtiInfo.Controls.Add(this.label5);
            this.pnlWtiInfo.Controls.Add(this.txtWInfo);
            this.pnlWtiInfo.Controls.Add(this.txtRecordNo);
            this.pnlWtiInfo.Controls.Add(this.txtRoomNo);
            this.pnlWtiInfo.Controls.Add(this.txtTInfo);
            this.pnlWtiInfo.Controls.Add(this.label8);
            this.pnlWtiInfo.Controls.Add(this.label6);
            this.pnlWtiInfo.Controls.Add(this.label4);
            this.pnlWtiInfo.Controls.Add(this.label3);
            this.pnlWtiInfo.Controls.Add(this.label2);
            this.pnlWtiInfo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.pnlWtiInfo.Location = new System.Drawing.Point(129, 96);
            this.pnlWtiInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlWtiInfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlWtiInfo.Name = "pnlWtiInfo";
            this.pnlWtiInfo.Size = new System.Drawing.Size(763, 458);
            this.pnlWtiInfo.Style = Sunny.UI.UIStyle.Custom;
            this.pnlWtiInfo.TabIndex = 132;
            this.pnlWtiInfo.Text = "水电信息查看面板v1.0";
            this.pnlWtiInfo.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlWtiInfo.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Enabled = false;
            this.btnClose.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnClose.Location = new System.Drawing.Point(640, 416);
            this.btnClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Radius = 20;
            this.btnClose.Size = new System.Drawing.Size(109, 28);
            this.btnClose.Style = Sunny.UI.UIStyle.Custom;
            this.btnClose.TabIndex = 136;
            this.btnClose.Text = "关    闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtCustoNo
            // 
            this.txtCustoNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustoNo.FillColor = System.Drawing.Color.White;
            this.txtCustoNo.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCustoNo.Location = new System.Drawing.Point(498, 15);
            this.txtCustoNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustoNo.Maximum = 2147483647D;
            this.txtCustoNo.Minimum = -2147483648D;
            this.txtCustoNo.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtCustoNo.Name = "txtCustoNo";
            this.txtCustoNo.Padding = new System.Windows.Forms.Padding(5);
            this.txtCustoNo.Radius = 20;
            this.txtCustoNo.ReadOnly = true;
            this.txtCustoNo.Size = new System.Drawing.Size(250, 35);
            this.txtCustoNo.Style = Sunny.UI.UIStyle.Custom;
            this.txtCustoNo.StyleCustomMode = true;
            this.txtCustoNo.TabIndex = 135;
            this.txtCustoNo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.dtpEndDate.FillColor = System.Drawing.Color.White;
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.dtpEndDate.Location = new System.Drawing.Point(498, 171);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpEndDate.MaxLength = 10;
            this.dtpEndDate.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dtpEndDate.Radius = 20;
            this.dtpEndDate.ReadOnly = true;
            this.dtpEndDate.Size = new System.Drawing.Size(250, 31);
            this.dtpEndDate.Style = Sunny.UI.UIStyle.Custom;
            this.dtpEndDate.SymbolDropDown = 61555;
            this.dtpEndDate.SymbolNormal = 61555;
            this.dtpEndDate.TabIndex = 134;
            this.dtpEndDate.Text = "2020-11-24";
            this.dtpEndDate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtpEndDate.Value = new System.DateTime(2020, 11, 24, 22, 50, 36, 791);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(394, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 133;
            this.label1.Text = "结束时间";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.dtpStartDate.FillColor = System.Drawing.Color.White;
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.dtpStartDate.Location = new System.Drawing.Point(122, 171);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpStartDate.MaxLength = 10;
            this.dtpStartDate.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dtpStartDate.Radius = 20;
            this.dtpStartDate.ReadOnly = true;
            this.dtpStartDate.Size = new System.Drawing.Size(265, 31);
            this.dtpStartDate.Style = Sunny.UI.UIStyle.Custom;
            this.dtpStartDate.SymbolDropDown = 61555;
            this.dtpStartDate.SymbolNormal = 61555;
            this.dtpStartDate.TabIndex = 132;
            this.dtpStartDate.Text = "2020-11-24";
            this.dtpStartDate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtpStartDate.Value = new System.DateTime(2020, 11, 24, 22, 50, 36, 791);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(15, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 131;
            this.label5.Text = "开始时间";
            // 
            // txtWInfo
            // 
            this.txtWInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWInfo.FillColor = System.Drawing.Color.White;
            this.txtWInfo.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtWInfo.Location = new System.Drawing.Point(499, 119);
            this.txtWInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWInfo.Maximum = 2147483647D;
            this.txtWInfo.Minimum = -2147483648D;
            this.txtWInfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtWInfo.Name = "txtWInfo";
            this.txtWInfo.Padding = new System.Windows.Forms.Padding(5);
            this.txtWInfo.Radius = 20;
            this.txtWInfo.Size = new System.Drawing.Size(249, 35);
            this.txtWInfo.Style = Sunny.UI.UIStyle.Custom;
            this.txtWInfo.StyleCustomMode = true;
            this.txtWInfo.TabIndex = 130;
            this.txtWInfo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRecordNo
            // 
            this.txtRecordNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRecordNo.FillColor = System.Drawing.Color.White;
            this.txtRecordNo.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRecordNo.Location = new System.Drawing.Point(122, 15);
            this.txtRecordNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRecordNo.Maximum = 2147483647D;
            this.txtRecordNo.Minimum = -2147483648D;
            this.txtRecordNo.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtRecordNo.Name = "txtRecordNo";
            this.txtRecordNo.Padding = new System.Windows.Forms.Padding(5);
            this.txtRecordNo.Radius = 20;
            this.txtRecordNo.ReadOnly = true;
            this.txtRecordNo.Size = new System.Drawing.Size(265, 35);
            this.txtRecordNo.Style = Sunny.UI.UIStyle.Custom;
            this.txtRecordNo.StyleCustomMode = true;
            this.txtRecordNo.TabIndex = 126;
            this.txtRecordNo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomNo.FillColor = System.Drawing.Color.White;
            this.txtRoomNo.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRoomNo.Location = new System.Drawing.Point(122, 67);
            this.txtRoomNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoomNo.Maximum = 2147483647D;
            this.txtRoomNo.Minimum = -2147483648D;
            this.txtRoomNo.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Padding = new System.Windows.Forms.Padding(5);
            this.txtRoomNo.Radius = 20;
            this.txtRoomNo.ReadOnly = true;
            this.txtRoomNo.Size = new System.Drawing.Size(626, 35);
            this.txtRoomNo.Style = Sunny.UI.UIStyle.Custom;
            this.txtRoomNo.StyleCustomMode = true;
            this.txtRoomNo.TabIndex = 127;
            this.txtRoomNo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTInfo
            // 
            this.txtTInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTInfo.FillColor = System.Drawing.Color.White;
            this.txtTInfo.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTInfo.Location = new System.Drawing.Point(122, 119);
            this.txtTInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTInfo.Maximum = 2147483647D;
            this.txtTInfo.Minimum = -2147483648D;
            this.txtTInfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtTInfo.Name = "txtTInfo";
            this.txtTInfo.Padding = new System.Windows.Forms.Padding(5);
            this.txtTInfo.Radius = 20;
            this.txtTInfo.Size = new System.Drawing.Size(265, 35);
            this.txtTInfo.Style = Sunny.UI.UIStyle.Custom;
            this.txtTInfo.StyleCustomMode = true;
            this.txtTInfo.TabIndex = 125;
            this.txtTInfo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(15, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 25);
            this.label8.TabIndex = 124;
            this.label8.Text = "电  费(/元)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(394, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 122;
            this.label6.Text = "客户编号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(391, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 121;
            this.label4.Text = "水  费(/元)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(15, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 120;
            this.label3.Text = "房      号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(15, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 119;
            this.label2.Text = "记录编号";
            // 
            // uiToolTip1
            // 
            this.uiToolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.uiToolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.uiToolTip1.OwnerDraw = true;
            // 
            // FrmWtiInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1005, 623);
            this.ControlBox = false;
            this.Controls.Add(this.pnlWtiInfo);
            this.Controls.Add(this.dgvWti);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmWtiInfo";
            this.ShowIcon = true;
            this.ShowInTaskbar = false;
            this.ShowTitleIcon = true;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "水电信息";
            this.Load += new System.EventHandler(this.WtiInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWti)).EndInit();
            this.pnlWtiInfo.ResumeLayout(false);
            this.pnlWtiInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIDataGridView dgvWti;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWtiNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRoomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWaterUse;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPowerUse;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCustoNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private Sunny.UI.UIButton btnUpdWti;
        private Sunny.UI.UIPanel pnlWtiInfo;
        private Sunny.UI.UITextBox txtWInfo;
        private Sunny.UI.UITextBox txtRecordNo;
        private Sunny.UI.UITextBox txtRoomNo;
        private Sunny.UI.UITextBox txtTInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UIDatePicker dtpEndDate;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UIDatePicker dtpStartDate;
        private System.Windows.Forms.Label label5;
        private Sunny.UI.UITextBox txtCustoNo;
        private Sunny.UI.UIToolTip uiToolTip1;
        private Sunny.UI.UIButton btnClose;
    }
}