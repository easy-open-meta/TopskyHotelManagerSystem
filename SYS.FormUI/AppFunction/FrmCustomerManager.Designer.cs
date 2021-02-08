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
            this.gbCustoInfo = new System.Windows.Forms.GroupBox();
            this.txtCardID = new Sunny.UI.UITextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.btnSerach = new Sunny.UI.UIButton();
            this.btnAddCusto = new Sunny.UI.UIButton();
            this.gbCustoInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCustoInfo
            // 
            this.gbCustoInfo.Controls.Add(this.txtCardID);
            this.gbCustoInfo.Controls.Add(this.label2);
            this.gbCustoInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbCustoInfo.Location = new System.Drawing.Point(46, 420);
            this.gbCustoInfo.Name = "gbCustoInfo";
            this.gbCustoInfo.Size = new System.Drawing.Size(763, 57);
            this.gbCustoInfo.TabIndex = 73;
            this.gbCustoInfo.TabStop = false;
            this.gbCustoInfo.Text = "条件搜索栏";
            // 
            // txtCardID
            // 
            this.txtCardID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCardID.FillColor = System.Drawing.Color.White;
            this.txtCardID.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCardID.Location = new System.Drawing.Point(327, 16);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(232, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 87;
            this.label2.Text = "证件号码";
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
            this.dgvCustomerList.EnableHeadersVisualStyles = false;
            this.dgvCustomerList.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgvCustomerList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvCustomerList.Location = new System.Drawing.Point(12, 12);
            this.dgvCustomerList.Name = "dgvCustomerList";
            this.dgvCustomerList.ReadOnly = true;
            this.dgvCustomerList.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgvCustomerList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCustomerList.RowTemplate.Height = 29;
            this.dgvCustomerList.SelectedIndex = -1;
            this.dgvCustomerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerList.ShowRect = false;
            this.dgvCustomerList.Size = new System.Drawing.Size(1048, 402);
            this.dgvCustomerList.Style = Sunny.UI.UIStyle.Custom;
            this.dgvCustomerList.TabIndex = 83;
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
            // btnSerach
            // 
            this.btnSerach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSerach.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnSerach.Location = new System.Drawing.Point(815, 426);
            this.btnSerach.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSerach.Name = "btnSerach";
            this.btnSerach.Radius = 30;
            this.btnSerach.Size = new System.Drawing.Size(103, 49);
            this.btnSerach.TabIndex = 84;
            this.btnSerach.Text = "搜    索";
            this.btnSerach.Click += new System.EventHandler(this.btnSerach_BtnClick);
            // 
            // btnAddCusto
            // 
            this.btnAddCusto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCusto.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnAddCusto.Location = new System.Drawing.Point(924, 426);
            this.btnAddCusto.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAddCusto.Name = "btnAddCusto";
            this.btnAddCusto.Radius = 30;
            this.btnAddCusto.Size = new System.Drawing.Size(103, 49);
            this.btnAddCusto.TabIndex = 85;
            this.btnAddCusto.Text = "添加客户";
            this.btnAddCusto.Click += new System.EventHandler(this.btnAddCusto_BtnClick);
            // 
            // FrmCustomerManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1072, 490);
            this.Controls.Add(this.btnAddCusto);
            this.Controls.Add(this.btnSerach);
            this.Controls.Add(this.dgvCustomerList);
            this.Controls.Add(this.gbCustoInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCustomerManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TS酒店管理系统";
            this.Load += new System.EventHandler(this.FrmCustomerManager_Load);
            this.gbCustoInfo.ResumeLayout(false);
            this.gbCustoInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbCustoInfo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
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
        private Sunny.UI.UIButton btnSerach;
        private Sunny.UI.UITextBox txtCardID;
        private Sunny.UI.UIButton btnAddCusto;
    }
}