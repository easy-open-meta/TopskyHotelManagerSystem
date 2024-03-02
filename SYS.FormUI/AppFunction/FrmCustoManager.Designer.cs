namespace SYS.FormUI
{
    partial class FrmCustoManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustoManager));
            this.dgvCustomerList = new Sunny.UI.UIDataGridView();
            this.CustoNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustoName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustoSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustoTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustoBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassportName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustoAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsCustoManager = new Sunny.UI.UIContextMenuStrip();
            this.tsmiCustoNo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSerach = new Sunny.UI.UIButton();
            this.btnAddCusto = new Sunny.UI.UIButton();
            this.btnExport = new Sunny.UI.UIButton();
            this.btnUpdate = new Sunny.UI.UIButton();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.txtCustoName = new Sunny.UI.UITextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustoNo = new Sunny.UI.UITextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPg = new Sunny.UI.UIPagination();
            this.uiLine1 = new Sunny.UI.UILine();
            this.cbExportAll = new Sunny.UI.UICheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).BeginInit();
            this.cmsCustoManager.SuspendLayout();
            this.uiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCustomerList
            // 
            this.dgvCustomerList.AllowUserToAddRows = false;
            this.dgvCustomerList.AllowUserToDeleteRows = false;
            this.dgvCustomerList.AllowUserToResizeColumns = false;
            this.dgvCustomerList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvCustomerList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomerList.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomerList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustomerList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvCustomerList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomerList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomerList.ColumnHeadersHeight = 25;
            this.dgvCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCustomerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustoNo,
            this.CustoName,
            this.CustoSex,
            this.CustoTel,
            this.CustoBirth,
            this.typeName,
            this.PassportName,
            this.CustoAdress,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvCustomerList.ContextMenuStrip = this.cmsCustoManager;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomerList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCustomerList.EnableHeadersVisualStyles = false;
            this.dgvCustomerList.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgvCustomerList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvCustomerList.Location = new System.Drawing.Point(3, 38);
            this.dgvCustomerList.Name = "dgvCustomerList";
            this.dgvCustomerList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomerList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCustomerList.RowHeadersVisible = false;
            this.dgvCustomerList.RowHeight = 29;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvCustomerList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCustomerList.RowTemplate.Height = 29;
            this.dgvCustomerList.SelectedIndex = -1;
            this.dgvCustomerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerList.ShowRect = false;
            this.dgvCustomerList.Size = new System.Drawing.Size(999, 482);
            this.dgvCustomerList.Style = Sunny.UI.UIStyle.Custom;
            this.dgvCustomerList.TabIndex = 111;
            // 
            // CustoNo
            // 
            this.CustoNo.DataPropertyName = "CustoNo";
            this.CustoNo.HeaderText = "客户编号";
            this.CustoNo.Name = "CustoNo";
            this.CustoNo.ReadOnly = true;
            // 
            // CustoName
            // 
            this.CustoName.DataPropertyName = "CustoName";
            this.CustoName.HeaderText = "客户姓名";
            this.CustoName.Name = "CustoName";
            this.CustoName.ReadOnly = true;
            // 
            // CustoSex
            // 
            this.CustoSex.DataPropertyName = "SexName";
            this.CustoSex.HeaderText = "性别";
            this.CustoSex.Name = "CustoSex";
            this.CustoSex.ReadOnly = true;
            // 
            // CustoTel
            // 
            this.CustoTel.DataPropertyName = "CustoTel";
            this.CustoTel.HeaderText = "联系方式";
            this.CustoTel.Name = "CustoTel";
            this.CustoTel.ReadOnly = true;
            // 
            // CustoBirth
            // 
            this.CustoBirth.DataPropertyName = "CustoBirth";
            this.CustoBirth.HeaderText = "出生日期";
            this.CustoBirth.Name = "CustoBirth";
            this.CustoBirth.ReadOnly = true;
            // 
            // typeName
            // 
            this.typeName.DataPropertyName = "typeName";
            this.typeName.HeaderText = "客户类型";
            this.typeName.Name = "typeName";
            this.typeName.ReadOnly = true;
            // 
            // PassportName
            // 
            this.PassportName.DataPropertyName = "PassportName";
            this.PassportName.HeaderText = "证件类型";
            this.PassportName.Name = "PassportName";
            this.PassportName.ReadOnly = true;
            // 
            // CustoAdress
            // 
            this.CustoAdress.DataPropertyName = "CustoAdress";
            this.CustoAdress.HeaderText = "客户地址";
            this.CustoAdress.Name = "CustoAdress";
            this.CustoAdress.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PassportType";
            this.Column1.HeaderText = "证照类型";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CustoType";
            this.Column2.HeaderText = "客户类型";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CustoID";
            this.Column3.HeaderText = "证件号码";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "CustoSex";
            this.Column4.HeaderText = "客户性别";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // cmsCustoManager
            // 
            this.cmsCustoManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.cmsCustoManager.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmsCustoManager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCustoNo});
            this.cmsCustoManager.Name = "cmsCustoManager";
            this.cmsCustoManager.Size = new System.Drawing.Size(177, 30);
            // 
            // tsmiCustoNo
            // 
            this.tsmiCustoNo.Image = global::SYS.FormUI.Properties.Resources.复制;
            this.tsmiCustoNo.Name = "tsmiCustoNo";
            this.tsmiCustoNo.Size = new System.Drawing.Size(176, 26);
            this.tsmiCustoNo.Text = "复制用户编号";
            this.tsmiCustoNo.Click += new System.EventHandler(this.tsmiCustoNo_Click);
            // 
            // btnSerach
            // 
            this.btnSerach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSerach.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnSerach.Location = new System.Drawing.Point(583, 570);
            this.btnSerach.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSerach.Name = "btnSerach";
            this.btnSerach.Radius = 30;
            this.btnSerach.Size = new System.Drawing.Size(97, 41);
            this.btnSerach.Style = Sunny.UI.UIStyle.Custom;
            this.btnSerach.TabIndex = 113;
            this.btnSerach.Text = "搜    索";
            this.btnSerach.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSerach.Click += new System.EventHandler(this.picSearch_Click_1);
            // 
            // btnAddCusto
            // 
            this.btnAddCusto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCusto.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnAddCusto.Location = new System.Drawing.Point(688, 570);
            this.btnAddCusto.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAddCusto.Name = "btnAddCusto";
            this.btnAddCusto.Radius = 30;
            this.btnAddCusto.Size = new System.Drawing.Size(97, 41);
            this.btnAddCusto.Style = Sunny.UI.UIStyle.Custom;
            this.btnAddCusto.TabIndex = 114;
            this.btnAddCusto.Text = "添加客户";
            this.btnAddCusto.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddCusto.Click += new System.EventHandler(this.picAddCusto_Click_1);
            // 
            // btnExport
            // 
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnExport.Location = new System.Drawing.Point(793, 570);
            this.btnExport.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnExport.Name = "btnExport";
            this.btnExport.Radius = 30;
            this.btnExport.Size = new System.Drawing.Size(97, 41);
            this.btnExport.Style = Sunny.UI.UIStyle.Custom;
            this.btnExport.TabIndex = 115;
            this.btnExport.Text = "导出列表";
            this.btnExport.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExport.Click += new System.EventHandler(this.picLoadOut_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnUpdate.Location = new System.Drawing.Point(898, 570);
            this.btnUpdate.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Radius = 30;
            this.btnUpdate.Size = new System.Drawing.Size(97, 41);
            this.btnUpdate.Style = Sunny.UI.UIStyle.Custom;
            this.btnUpdate.TabIndex = 116;
            this.btnUpdate.Text = "修改客户";
            this.btnUpdate.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdate.Click += new System.EventHandler(this.picUpdateCusto_Click_1);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.txtCustoName);
            this.uiGroupBox1.Controls.Add(this.label1);
            this.uiGroupBox1.Controls.Add(this.txtCustoNo);
            this.uiGroupBox1.Controls.Add(this.label3);
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox1.Location = new System.Drawing.Point(4, 552);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(572, 62);
            this.uiGroupBox1.Style = Sunny.UI.UIStyle.Custom;
            this.uiGroupBox1.TabIndex = 117;
            this.uiGroupBox1.Text = "条件搜索";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCustoName
            // 
            this.txtCustoName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustoName.FillColor = System.Drawing.Color.White;
            this.txtCustoName.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCustoName.Location = new System.Drawing.Point(385, 23);
            this.txtCustoName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustoName.Maximum = 2147483647D;
            this.txtCustoName.Minimum = -2147483648D;
            this.txtCustoName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtCustoName.Name = "txtCustoName";
            this.txtCustoName.Padding = new System.Windows.Forms.Padding(5);
            this.txtCustoName.Radius = 20;
            this.txtCustoName.Size = new System.Drawing.Size(173, 33);
            this.txtCustoName.Style = Sunny.UI.UIStyle.Custom;
            this.txtCustoName.TabIndex = 98;
            this.txtCustoName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtCustoName.Watermark = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(290, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 97;
            this.label1.Text = "客户姓名";
            // 
            // txtCustoNo
            // 
            this.txtCustoNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustoNo.FillColor = System.Drawing.Color.White;
            this.txtCustoNo.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCustoNo.Location = new System.Drawing.Point(110, 23);
            this.txtCustoNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustoNo.Maximum = 2147483647D;
            this.txtCustoNo.Minimum = -2147483648D;
            this.txtCustoNo.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtCustoNo.Name = "txtCustoNo";
            this.txtCustoNo.Padding = new System.Windows.Forms.Padding(5);
            this.txtCustoNo.Radius = 20;
            this.txtCustoNo.Size = new System.Drawing.Size(173, 33);
            this.txtCustoNo.Style = Sunny.UI.UIStyle.Custom;
            this.txtCustoNo.TabIndex = 96;
            this.txtCustoNo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtCustoNo.Watermark = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(15, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 95;
            this.label3.Text = "客户编号";
            // 
            // btnPg
            // 
            this.btnPg.ButtonInterval = 5;
            this.btnPg.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnPg.Location = new System.Drawing.Point(3, 528);
            this.btnPg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPg.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPg.Name = "btnPg";
            this.btnPg.PageSize = 15;
            this.btnPg.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btnPg.Size = new System.Drawing.Size(677, 34);
            this.btnPg.Style = Sunny.UI.UIStyle.Custom;
            this.btnPg.TabIndex = 121;
            this.btnPg.Text = null;
            this.btnPg.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPg.PageChanged += new Sunny.UI.UIPagination.OnPageChangeEventHandler(this.btnPg_PageChanged);
            // 
            // uiLine1
            // 
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine1.Location = new System.Drawing.Point(792, 533);
            this.uiLine1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(203, 29);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 123;
            this.uiLine1.Text = "右键可复制客户编号";
            // 
            // cbExportAll
            // 
            this.cbExportAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbExportAll.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cbExportAll.Location = new System.Drawing.Point(687, 533);
            this.cbExportAll.MinimumSize = new System.Drawing.Size(1, 1);
            this.cbExportAll.Name = "cbExportAll";
            this.cbExportAll.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.cbExportAll.Size = new System.Drawing.Size(98, 29);
            this.cbExportAll.Style = Sunny.UI.UIStyle.Custom;
            this.cbExportAll.TabIndex = 124;
            this.cbExportAll.Text = "导出全部";
            // 
            // FrmCustoManager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1005, 623);
            this.ControlBox = false;
            this.Controls.Add(this.cbExportAll);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.btnPg);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnAddCusto);
            this.Controls.Add(this.btnSerach);
            this.Controls.Add(this.dgvCustomerList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCustoManager";
            this.ShowTitleIcon = true;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "客户信息管理";
            this.Load += new System.EventHandler(this.FrmCustoManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).EndInit();
            this.cmsCustoManager.ResumeLayout(false);
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIDataGridView dgvCustomerList;
        private Sunny.UI.UIButton btnSerach;
        private Sunny.UI.UIButton btnAddCusto;
        private Sunny.UI.UIButton btnExport;
        private Sunny.UI.UIButton btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustoNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustoName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustoSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustoTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustoBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassportName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustoAdress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UITextBox txtCustoName;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UITextBox txtCustoNo;
        private System.Windows.Forms.Label label3;
        private Sunny.UI.UIPagination btnPg;
        private Sunny.UI.UIContextMenuStrip cmsCustoManager;
        private System.Windows.Forms.ToolStripMenuItem tsmiCustoNo;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UICheckBox cbExportAll;
    }
}