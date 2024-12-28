namespace EOM.TSHotelManager.FormUI
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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            dgvCustomerList = new Sunny.UI.UIDataGridView();
            CustoNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CustoName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CustoSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CustoTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CustoBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            typeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PassportName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CustoAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cmsCustoManager = new Sunny.UI.UIContextMenuStrip();
            tsmiCustoNo = new System.Windows.Forms.ToolStripMenuItem();
            uiGroupBox1 = new Sunny.UI.UIGroupBox();
            txtCustoName = new Sunny.UI.UITextBox();
            label1 = new System.Windows.Forms.Label();
            txtCustoNo = new Sunny.UI.UITextBox();
            label3 = new System.Windows.Forms.Label();
            btnPg = new Sunny.UI.UIPagination();
            uiLine1 = new Sunny.UI.UILine();
            cbOnlyVip = new Sunny.UI.UICheckBox();
            btnSerach = new AntdUI.Button();
            btnAddCusto = new AntdUI.Button();
            btnUpdCustomer = new AntdUI.Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerList).BeginInit();
            cmsCustoManager.SuspendLayout();
            uiGroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "获取账号";
            // 
            // dgvCustomerList
            // 
            dgvCustomerList.AllowUserToAddRows = false;
            dgvCustomerList.AllowUserToDeleteRows = false;
            dgvCustomerList.AllowUserToResizeColumns = false;
            dgvCustomerList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(235, 243, 255);
            dgvCustomerList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCustomerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomerList.BackgroundColor = System.Drawing.Color.White;
            dgvCustomerList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvCustomerList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dgvCustomerList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvCustomerList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCustomerList.ColumnHeadersHeight = 25;
            dgvCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCustomerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { CustoNo, CustoName, CustoSex, CustoTel, CustoBirth, typeName, PassportName, CustoAdress, Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9 });
            dgvCustomerList.ContextMenuStrip = cmsCustoManager;
            dgvCustomerList.EnableHeadersVisualStyles = false;
            dgvCustomerList.Font = new System.Drawing.Font("微软雅黑", 12F);
            dgvCustomerList.GridColor = System.Drawing.Color.FromArgb(80, 160, 255);
            dgvCustomerList.Location = new System.Drawing.Point(14, 7);
            dgvCustomerList.Margin = new System.Windows.Forms.Padding(4);
            dgvCustomerList.Name = "dgvCustomerList";
            dgvCustomerList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvCustomerList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCustomerList.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dgvCustomerList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvCustomerList.RowTemplate.Height = 29;
            dgvCustomerList.SelectedIndex = -1;
            dgvCustomerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCustomerList.Size = new System.Drawing.Size(1053, 352);
            dgvCustomerList.StripeOddColor = System.Drawing.Color.FromArgb(235, 243, 255);
            dgvCustomerList.Style = Sunny.UI.UIStyle.Custom;
            dgvCustomerList.TabIndex = 83;
            toolTip1.SetToolTip(dgvCustomerList, "选中客户右键可进行更多操作");
            dgvCustomerList.CellClick += dgvCustomerList_CellClick;
            // 
            // CustoNo
            // 
            CustoNo.DataPropertyName = "CustoNo";
            CustoNo.HeaderText = "客户编号";
            CustoNo.Name = "CustoNo";
            CustoNo.ReadOnly = true;
            // 
            // CustoName
            // 
            CustoName.DataPropertyName = "CustoName";
            CustoName.HeaderText = "客户姓名";
            CustoName.Name = "CustoName";
            CustoName.ReadOnly = true;
            // 
            // CustoSex
            // 
            CustoSex.DataPropertyName = "SexName";
            CustoSex.HeaderText = "性别";
            CustoSex.Name = "CustoSex";
            CustoSex.ReadOnly = true;
            // 
            // CustoTel
            // 
            CustoTel.DataPropertyName = "CustoTel";
            CustoTel.HeaderText = "联系方式";
            CustoTel.Name = "CustoTel";
            CustoTel.ReadOnly = true;
            // 
            // CustoBirth
            // 
            CustoBirth.DataPropertyName = "CustoBirth";
            CustoBirth.HeaderText = "出生日期";
            CustoBirth.Name = "CustoBirth";
            CustoBirth.ReadOnly = true;
            // 
            // typeName
            // 
            typeName.DataPropertyName = "typeName";
            typeName.HeaderText = "客户类型";
            typeName.Name = "typeName";
            typeName.ReadOnly = true;
            // 
            // PassportName
            // 
            PassportName.DataPropertyName = "PassportName";
            PassportName.HeaderText = "证件类型";
            PassportName.Name = "PassportName";
            PassportName.ReadOnly = true;
            // 
            // CustoAdress
            // 
            CustoAdress.DataPropertyName = "CustoAdress";
            CustoAdress.HeaderText = "客户地址";
            CustoAdress.Name = "CustoAdress";
            CustoAdress.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "PassportType";
            Column1.HeaderText = "Column1";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Visible = false;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "CustoType";
            Column2.HeaderText = "Column2";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Visible = false;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "CustoID";
            Column3.HeaderText = "Column3";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Visible = false;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "CustoSex";
            Column4.HeaderText = "Column4";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Visible = false;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "delete_mk";
            Column5.HeaderText = "Column5";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Visible = false;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "datains_usr";
            Column6.HeaderText = "Column6";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Visible = false;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "datains_date";
            Column7.HeaderText = "Column7";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Visible = false;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "datachg_usr";
            Column8.HeaderText = "Column8";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Visible = false;
            // 
            // Column9
            // 
            Column9.DataPropertyName = "datachg_date";
            Column9.HeaderText = "Column9";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Visible = false;
            // 
            // cmsCustoManager
            // 
            cmsCustoManager.BackColor = System.Drawing.Color.FromArgb(243, 249, 255);
            cmsCustoManager.Font = new System.Drawing.Font("微软雅黑", 12F);
            cmsCustoManager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmiCustoNo });
            cmsCustoManager.Name = "cmsCustoManager";
            cmsCustoManager.Size = new System.Drawing.Size(177, 30);
            // 
            // tsmiCustoNo
            // 
            tsmiCustoNo.Image = Properties.Resources.复制;
            tsmiCustoNo.Name = "tsmiCustoNo";
            tsmiCustoNo.Size = new System.Drawing.Size(176, 26);
            tsmiCustoNo.Text = "复制用户编号";
            tsmiCustoNo.Click += tsmiCustoNo_Click;
            // 
            // uiGroupBox1
            // 
            uiGroupBox1.Controls.Add(txtCustoName);
            uiGroupBox1.Controls.Add(label1);
            uiGroupBox1.Controls.Add(txtCustoNo);
            uiGroupBox1.Controls.Add(label3);
            uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiGroupBox1.Location = new System.Drawing.Point(14, 405);
            uiGroupBox1.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            uiGroupBox1.Name = "uiGroupBox1";
            uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 45, 0, 0);
            uiGroupBox1.Size = new System.Drawing.Size(591, 81);
            uiGroupBox1.TabIndex = 119;
            uiGroupBox1.Text = "条件搜索";
            uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCustoName
            // 
            txtCustoName.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtCustoName.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            txtCustoName.Location = new System.Drawing.Point(387, 34);
            txtCustoName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtCustoName.MinimumSize = new System.Drawing.Size(1, 1);
            txtCustoName.Name = "txtCustoName";
            txtCustoName.Padding = new System.Windows.Forms.Padding(5);
            txtCustoName.Radius = 20;
            txtCustoName.ShowText = false;
            txtCustoName.Size = new System.Drawing.Size(173, 33);
            txtCustoName.TabIndex = 94;
            txtCustoName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            txtCustoName.Watermark = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            label1.Location = new System.Drawing.Point(292, 37);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(88, 25);
            label1.TabIndex = 93;
            label1.Text = "客户姓名";
            // 
            // txtCustoNo
            // 
            txtCustoNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtCustoNo.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            txtCustoNo.Location = new System.Drawing.Point(112, 34);
            txtCustoNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtCustoNo.MinimumSize = new System.Drawing.Size(1, 1);
            txtCustoNo.Name = "txtCustoNo";
            txtCustoNo.Padding = new System.Windows.Forms.Padding(5);
            txtCustoNo.Radius = 20;
            txtCustoNo.ShowText = false;
            txtCustoNo.Size = new System.Drawing.Size(173, 33);
            txtCustoNo.TabIndex = 92;
            txtCustoNo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            txtCustoNo.Watermark = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            label3.Location = new System.Drawing.Point(17, 37);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(88, 25);
            label3.TabIndex = 91;
            label3.Text = "客户编号";
            // 
            // btnPg
            // 
            btnPg.BackColor = System.Drawing.Color.Transparent;
            btnPg.ButtonInterval = 5;
            btnPg.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnPg.Location = new System.Drawing.Point(14, 370);
            btnPg.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            btnPg.MinimumSize = new System.Drawing.Size(1, 1);
            btnPg.Name = "btnPg";
            btnPg.PageSize = 15;
            btnPg.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            btnPg.ShowText = false;
            btnPg.Size = new System.Drawing.Size(643, 35);
            btnPg.TabIndex = 120;
            btnPg.Text = null;
            btnPg.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            btnPg.PageChanged += btnPg_PageChanged;
            // 
            // uiLine1
            // 
            uiLine1.BackColor = System.Drawing.Color.Transparent;
            uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiLine1.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            uiLine1.Location = new System.Drawing.Point(776, 377);
            uiLine1.Margin = new System.Windows.Forms.Padding(4);
            uiLine1.MinimumSize = new System.Drawing.Size(2, 3);
            uiLine1.Name = "uiLine1";
            uiLine1.Size = new System.Drawing.Size(291, 24);
            uiLine1.TabIndex = 124;
            uiLine1.Text = "右键可复制快速客户编号";
            // 
            // cbOnlyVip
            // 
            cbOnlyVip.Cursor = System.Windows.Forms.Cursors.Hand;
            cbOnlyVip.Font = new System.Drawing.Font("微软雅黑", 12F);
            cbOnlyVip.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            cbOnlyVip.Location = new System.Drawing.Point(657, 377);
            cbOnlyVip.Margin = new System.Windows.Forms.Padding(4);
            cbOnlyVip.MinimumSize = new System.Drawing.Size(1, 1);
            cbOnlyVip.Name = "cbOnlyVip";
            cbOnlyVip.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            cbOnlyVip.Size = new System.Drawing.Size(111, 24);
            cbOnlyVip.Style = Sunny.UI.UIStyle.Custom;
            cbOnlyVip.TabIndex = 126;
            cbOnlyVip.Text = "仅查看会员";
            cbOnlyVip.CheckedChanged += cbOnlyVip_CheckedChanged;
            // 
            // btnSerach
            // 
            btnSerach.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            btnSerach.Location = new System.Drawing.Point(613, 426);
            btnSerach.Name = "btnSerach";
            btnSerach.Radius = 15;
            btnSerach.Size = new System.Drawing.Size(113, 54);
            btnSerach.TabIndex = 127;
            btnSerach.Text = "搜    索";
            btnSerach.Type = AntdUI.TTypeMini.Primary;
            btnSerach.Click += btnSerach_BtnClick;
            // 
            // btnAddCusto
            // 
            btnAddCusto.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            btnAddCusto.Location = new System.Drawing.Point(783, 426);
            btnAddCusto.Name = "btnAddCusto";
            btnAddCusto.Radius = 15;
            btnAddCusto.Size = new System.Drawing.Size(113, 54);
            btnAddCusto.TabIndex = 128;
            btnAddCusto.Text = "添加客户";
            btnAddCusto.Type = AntdUI.TTypeMini.Primary;
            btnAddCusto.Click += btnAddCusto_BtnClick;
            // 
            // btnUpdCustomer
            // 
            btnUpdCustomer.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            btnUpdCustomer.Location = new System.Drawing.Point(953, 426);
            btnUpdCustomer.Name = "btnUpdCustomer";
            btnUpdCustomer.Radius = 15;
            btnUpdCustomer.Size = new System.Drawing.Size(113, 54);
            btnUpdCustomer.TabIndex = 129;
            btnUpdCustomer.Text = "修改客户";
            btnUpdCustomer.Type = AntdUI.TTypeMini.Primary;
            btnUpdCustomer.Click += btnUpdCustomer_Click;
            // 
            // FrmCustomerManager
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(235, 243, 255);
            ClientSize = new System.Drawing.Size(1072, 490);
            Controls.Add(btnUpdCustomer);
            Controls.Add(btnAddCusto);
            Controls.Add(btnSerach);
            Controls.Add(cbOnlyVip);
            Controls.Add(uiLine1);
            Controls.Add(btnPg);
            Controls.Add(uiGroupBox1);
            Controls.Add(dgvCustomerList);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4);
            Name = "FrmCustomerManager";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "TS酒店管理系统";
            Load += FrmCustomerManager_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomerList).EndInit();
            cmsCustoManager.ResumeLayout(false);
            uiGroupBox1.ResumeLayout(false);
            uiGroupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private Sunny.UI.UIDataGridView dgvCustomerList;
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
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UITextBox txtCustoNo;
        private System.Windows.Forms.Label label3;
        private Sunny.UI.UITextBox txtCustoName;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UIPagination btnPg;
        private Sunny.UI.UIContextMenuStrip cmsCustoManager;
        private System.Windows.Forms.ToolStripMenuItem tsmiCustoNo;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UICheckBox cbOnlyVip;
        private AntdUI.Button btnSerach;
        private AntdUI.Button btnAddCusto;
        private AntdUI.Button btnUpdCustomer;
    }
}