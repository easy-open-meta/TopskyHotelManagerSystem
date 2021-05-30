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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustoManager));
            this.dgvCustomerList = new Sunny.UI.UIDataGridView();
            this.gbCustoInfo = new System.Windows.Forms.GroupBox();
            this.txtCardID = new Sunny.UI.UITextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSerach = new Sunny.UI.UIButton();
            this.btnAddCusto = new Sunny.UI.UIButton();
            this.btnExport = new Sunny.UI.UIButton();
            this.btnUpdate = new Sunny.UI.UIButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).BeginInit();
            this.gbCustoInfo.SuspendLayout();
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
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomerList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomerList.ColumnHeadersHeight = 32;
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
            this.dgvCustomerList.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvCustomerList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCustomerList.RowTemplate.Height = 29;
            this.dgvCustomerList.SelectedIndex = -1;
            this.dgvCustomerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerList.ShowRect = false;
            this.dgvCustomerList.Size = new System.Drawing.Size(999, 506);
            this.dgvCustomerList.TabIndex = 111;
            // 
            // gbCustoInfo
            // 
            this.gbCustoInfo.Controls.Add(this.txtCardID);
            this.gbCustoInfo.Controls.Add(this.label3);
            this.gbCustoInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbCustoInfo.Location = new System.Drawing.Point(10, 550);
            this.gbCustoInfo.Name = "gbCustoInfo";
            this.gbCustoInfo.Size = new System.Drawing.Size(538, 57);
            this.gbCustoInfo.TabIndex = 112;
            this.gbCustoInfo.TabStop = false;
            this.gbCustoInfo.Text = "条件搜索栏";
            // 
            // txtCardID
            // 
            this.txtCardID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCardID.FillColor = System.Drawing.Color.White;
            this.txtCardID.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCardID.Location = new System.Drawing.Point(227, 16);
            this.txtCardID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCardID.Maximum = 2147483647D;
            this.txtCardID.Minimum = -2147483648D;
            this.txtCardID.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtCardID.Name = "txtCardID";
            this.txtCardID.Padding = new System.Windows.Forms.Padding(5);
            this.txtCardID.Radius = 20;
            this.txtCardID.Size = new System.Drawing.Size(204, 33);
            this.txtCardID.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(132, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 87;
            this.label3.Text = "客户编号";
            // 
            // btnSerach
            // 
            this.btnSerach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSerach.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnSerach.Location = new System.Drawing.Point(559, 558);
            this.btnSerach.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSerach.Name = "btnSerach";
            this.btnSerach.Radius = 30;
            this.btnSerach.Size = new System.Drawing.Size(103, 49);
            this.btnSerach.TabIndex = 113;
            this.btnSerach.Text = "搜    索";
            this.btnSerach.Click += new System.EventHandler(this.picSearch_Click_1);
            // 
            // btnAddCusto
            // 
            this.btnAddCusto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCusto.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnAddCusto.Location = new System.Drawing.Point(668, 558);
            this.btnAddCusto.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAddCusto.Name = "btnAddCusto";
            this.btnAddCusto.Radius = 30;
            this.btnAddCusto.Size = new System.Drawing.Size(103, 49);
            this.btnAddCusto.TabIndex = 114;
            this.btnAddCusto.Text = "添加客户";
            this.btnAddCusto.Click += new System.EventHandler(this.picAddCusto_Click_1);
            // 
            // btnExport
            // 
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnExport.Location = new System.Drawing.Point(780, 558);
            this.btnExport.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnExport.Name = "btnExport";
            this.btnExport.Radius = 30;
            this.btnExport.Size = new System.Drawing.Size(103, 49);
            this.btnExport.TabIndex = 115;
            this.btnExport.Text = "导出列表";
            this.btnExport.Click += new System.EventHandler(this.picLoadOut_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnUpdate.Location = new System.Drawing.Point(889, 558);
            this.btnUpdate.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Radius = 30;
            this.btnUpdate.Size = new System.Drawing.Size(103, 49);
            this.btnUpdate.TabIndex = 116;
            this.btnUpdate.Text = "修改客户";
            this.btnUpdate.Click += new System.EventHandler(this.picUpdateCusto_Click_1);
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
            // FrmCustoManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1005, 623);
            this.ControlBox = false;
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnAddCusto);
            this.Controls.Add(this.btnSerach);
            this.Controls.Add(this.gbCustoInfo);
            this.Controls.Add(this.dgvCustomerList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCustoManager";
            this.ShowIcon = true;
            this.Text = "客户信息管理";
            this.Load += new System.EventHandler(this.FrmCustoManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).EndInit();
            this.gbCustoInfo.ResumeLayout(false);
            this.gbCustoInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIDataGridView dgvCustomerList;
        private System.Windows.Forms.GroupBox gbCustoInfo;
        private Sunny.UI.UITextBox txtCardID;
        private System.Windows.Forms.Label label3;
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
    }
}