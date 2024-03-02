namespace SYS.FormUI
{
    partial class FrmCustomerManager
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsCustoManager = new Sunny.UI.UIContextMenuStrip();
            this.tsmiCustoNo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSerach = new Sunny.UI.UIButton();
            this.btnAddCusto = new Sunny.UI.UIButton();
            this.btnUpdCustomer = new Sunny.UI.UIButton();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.txtCustoName = new Sunny.UI.UITextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustoNo = new Sunny.UI.UITextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPg = new Sunny.UI.UIPagination();
            this.uiLine1 = new Sunny.UI.UILine();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).BeginInit();
            this.cmsCustoManager.SuspendLayout();
            this.uiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "获取账号";
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
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
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
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvCustomerList.ContextMenuStrip = this.cmsCustoManager;
            this.dgvCustomerList.EnableHeadersVisualStyles = false;
            this.dgvCustomerList.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgvCustomerList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvCustomerList.Location = new System.Drawing.Point(12, 12);
            this.dgvCustomerList.Name = "dgvCustomerList";
            this.dgvCustomerList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomerList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCustomerList.RowHeadersVisible = false;
            this.dgvCustomerList.RowHeight = 29;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvCustomerList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCustomerList.RowTemplate.Height = 29;
            this.dgvCustomerList.SelectedIndex = -1;
            this.dgvCustomerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerList.ShowRect = false;
            this.dgvCustomerList.Size = new System.Drawing.Size(1048, 381);
            this.dgvCustomerList.Style = Sunny.UI.UIStyle.Custom;
            this.dgvCustomerList.TabIndex = 83;
            this.toolTip1.SetToolTip(this.dgvCustomerList, "选中客户右键可进行更多操作");
            this.dgvCustomerList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerList_CellClick);
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
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CustoType";
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CustoID";
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "CustoSex";
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "delete_mk";
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "datains_usr";
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "datains_date";
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "datachg_usr";
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "datachg_date";
            this.Column9.HeaderText = "Column9";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // cmsCustoManager
            // 
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
            this.btnSerach.Location = new System.Drawing.Point(591, 443);
            this.btnSerach.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSerach.Name = "btnSerach";
            this.btnSerach.Radius = 30;
            this.btnSerach.Size = new System.Drawing.Size(97, 41);
            this.btnSerach.TabIndex = 84;
            this.btnSerach.Text = "搜    索";
            this.btnSerach.Click += new System.EventHandler(this.btnSerach_BtnClick);
            // 
            // btnAddCusto
            // 
            this.btnAddCusto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCusto.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnAddCusto.Location = new System.Drawing.Point(774, 443);
            this.btnAddCusto.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAddCusto.Name = "btnAddCusto";
            this.btnAddCusto.Radius = 30;
            this.btnAddCusto.Size = new System.Drawing.Size(97, 41);
            this.btnAddCusto.TabIndex = 85;
            this.btnAddCusto.Text = "添加客户";
            this.btnAddCusto.Click += new System.EventHandler(this.btnAddCusto_BtnClick);
            // 
            // btnUpdCustomer
            // 
            this.btnUpdCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdCustomer.Enabled = false;
            this.btnUpdCustomer.FillDisableColor = System.Drawing.Color.Silver;
            this.btnUpdCustomer.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnUpdCustomer.Location = new System.Drawing.Point(957, 443);
            this.btnUpdCustomer.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnUpdCustomer.Name = "btnUpdCustomer";
            this.btnUpdCustomer.Radius = 30;
            this.btnUpdCustomer.Size = new System.Drawing.Size(97, 41);
            this.btnUpdCustomer.Style = Sunny.UI.UIStyle.Custom;
            this.btnUpdCustomer.TabIndex = 87;
            this.btnUpdCustomer.Text = "修改客户";
            this.btnUpdCustomer.Click += new System.EventHandler(this.btnUpdCustomer_Click);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.txtCustoName);
            this.uiGroupBox1.Controls.Add(this.label1);
            this.uiGroupBox1.Controls.Add(this.txtCustoNo);
            this.uiGroupBox1.Controls.Add(this.label3);
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox1.Location = new System.Drawing.Point(12, 426);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(572, 62);
            this.uiGroupBox1.TabIndex = 119;
            this.uiGroupBox1.Text = "条件搜索";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCustoName
            // 
            this.txtCustoName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustoName.FillColor = System.Drawing.Color.White;
            this.txtCustoName.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCustoName.Location = new System.Drawing.Point(387, 23);
            this.txtCustoName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustoName.Maximum = 2147483647D;
            this.txtCustoName.Minimum = -2147483648D;
            this.txtCustoName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtCustoName.Name = "txtCustoName";
            this.txtCustoName.Padding = new System.Windows.Forms.Padding(5);
            this.txtCustoName.Radius = 20;
            this.txtCustoName.Size = new System.Drawing.Size(173, 33);
            this.txtCustoName.TabIndex = 94;
            this.txtCustoName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(292, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 93;
            this.label1.Text = "客户姓名";
            // 
            // txtCustoNo
            // 
            this.txtCustoNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustoNo.FillColor = System.Drawing.Color.White;
            this.txtCustoNo.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCustoNo.Location = new System.Drawing.Point(112, 23);
            this.txtCustoNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustoNo.Maximum = 2147483647D;
            this.txtCustoNo.Minimum = -2147483648D;
            this.txtCustoNo.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtCustoNo.Name = "txtCustoNo";
            this.txtCustoNo.Padding = new System.Windows.Forms.Padding(5);
            this.txtCustoNo.Radius = 20;
            this.txtCustoNo.Size = new System.Drawing.Size(173, 33);
            this.txtCustoNo.TabIndex = 92;
            this.txtCustoNo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(17, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 91;
            this.label3.Text = "客户编号";
            // 
            // btnPg
            // 
            this.btnPg.ButtonInterval = 5;
            this.btnPg.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnPg.Location = new System.Drawing.Point(12, 401);
            this.btnPg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPg.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPg.Name = "btnPg";
            this.btnPg.PageSize = 15;
            this.btnPg.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btnPg.Size = new System.Drawing.Size(755, 34);
            this.btnPg.TabIndex = 120;
            this.btnPg.Text = null;
            this.btnPg.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPg.PageChanged += new Sunny.UI.UIPagination.OnPageChangeEventHandler(this.btnPg_PageChanged);
            // 
            // uiLine1
            // 
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine1.Location = new System.Drawing.Point(774, 404);
            this.uiLine1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(286, 29);
            this.uiLine1.TabIndex = 124;
            this.uiLine1.Text = "右键可复制快速客户编号";
            // 
            // FrmCustomerManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1072, 490);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.btnPg);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.btnUpdCustomer);
            this.Controls.Add(this.btnAddCusto);
            this.Controls.Add(this.btnSerach);
            this.Controls.Add(this.dgvCustomerList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCustomerManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TS酒店管理系统";
            this.Load += new System.EventHandler(this.FrmCustomerManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).EndInit();
            this.cmsCustoManager.ResumeLayout(false);
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private Sunny.UI.UIDataGridView dgvCustomerList;
        private Sunny.UI.UIButton btnSerach;
        private Sunny.UI.UIButton btnAddCusto;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private Sunny.UI.UIButton btnUpdCustomer;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UITextBox txtCustoNo;
        private System.Windows.Forms.Label label3;
        private Sunny.UI.UITextBox txtCustoName;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UIPagination btnPg;
        private Sunny.UI.UIContextMenuStrip cmsCustoManager;
        private System.Windows.Forms.ToolStripMenuItem tsmiCustoNo;
        private Sunny.UI.UILine uiLine1;
    }
}