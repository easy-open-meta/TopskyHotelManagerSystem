
namespace SYS.FormUI
{
    partial class FrmDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepartment));
            this.dgvDeptList = new Sunny.UI.UIDataGridView();
            this.clDeptNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDeptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDeptDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDeptDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDeptLeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDeptParent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboDeptParent = new Sunny.UI.UIComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddDept = new Sunny.UI.UIButton();
            this.label9 = new System.Windows.Forms.Label();
            this.cboDeptLeader = new Sunny.UI.UIComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDeptDesc = new Sunny.UI.UITextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDeptName = new Sunny.UI.UITextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtDeptNo = new Sunny.UI.UITextBox();
            this.btnUpdateDept = new Sunny.UI.UIButton();
            this.btnDeleteDept = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeptList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDeptList
            // 
            this.dgvDeptList.AllowUserToAddRows = false;
            this.dgvDeptList.AllowUserToDeleteRows = false;
            this.dgvDeptList.AllowUserToResizeColumns = false;
            this.dgvDeptList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvDeptList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDeptList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeptList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvDeptList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeptList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDeptList.ColumnHeadersHeight = 32;
            this.dgvDeptList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDeptList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clDeptNo,
            this.clDeptName,
            this.clDeptDesc,
            this.clDeptDate,
            this.clDeptLeader,
            this.clDeptParent,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDeptList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDeptList.EnableHeadersVisualStyles = false;
            this.dgvDeptList.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgvDeptList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvDeptList.Location = new System.Drawing.Point(3, 38);
            this.dgvDeptList.MultiSelect = false;
            this.dgvDeptList.Name = "dgvDeptList";
            this.dgvDeptList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeptList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDeptList.RowHeadersVisible = false;
            this.dgvDeptList.RowHeight = 29;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvDeptList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDeptList.RowTemplate.Height = 29;
            this.dgvDeptList.SelectedIndex = -1;
            this.dgvDeptList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeptList.ShowGridLine = true;
            this.dgvDeptList.Size = new System.Drawing.Size(788, 582);
            this.dgvDeptList.TabIndex = 0;
            this.dgvDeptList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDeptList_CellMouseClick);
            // 
            // clDeptNo
            // 
            this.clDeptNo.DataPropertyName = "dept_no";
            this.clDeptNo.HeaderText = "部门编号";
            this.clDeptNo.Name = "clDeptNo";
            this.clDeptNo.ReadOnly = true;
            // 
            // clDeptName
            // 
            this.clDeptName.DataPropertyName = "dept_name";
            this.clDeptName.HeaderText = "部门名称";
            this.clDeptName.Name = "clDeptName";
            this.clDeptName.ReadOnly = true;
            // 
            // clDeptDesc
            // 
            this.clDeptDesc.DataPropertyName = "dept_desc";
            this.clDeptDesc.HeaderText = "部门描述";
            this.clDeptDesc.Name = "clDeptDesc";
            this.clDeptDesc.ReadOnly = true;
            // 
            // clDeptDate
            // 
            this.clDeptDate.DataPropertyName = "dept_date";
            this.clDeptDate.HeaderText = "部门创建时间";
            this.clDeptDate.Name = "clDeptDate";
            this.clDeptDate.ReadOnly = true;
            // 
            // clDeptLeader
            // 
            this.clDeptLeader.DataPropertyName = "leader_name";
            this.clDeptLeader.HeaderText = "部门主管";
            this.clDeptLeader.Name = "clDeptLeader";
            this.clDeptLeader.ReadOnly = true;
            // 
            // clDeptParent
            // 
            this.clDeptParent.DataPropertyName = "parent_name";
            this.clDeptParent.HeaderText = "上级部门";
            this.clDeptParent.Name = "clDeptParent";
            this.clDeptParent.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "delete_mk";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "datains_usr";
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "datains_date";
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "datachg_usr";
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "datachg_date";
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "dept_leader";
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "dept_parent";
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // cboDeptParent
            // 
            this.cboDeptParent.DataSource = null;
            this.cboDeptParent.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cboDeptParent.FillColor = System.Drawing.Color.White;
            this.cboDeptParent.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboDeptParent.Location = new System.Drawing.Point(820, 443);
            this.cboDeptParent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboDeptParent.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboDeptParent.Name = "cboDeptParent";
            this.cboDeptParent.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboDeptParent.Radius = 20;
            this.cboDeptParent.Size = new System.Drawing.Size(165, 29);
            this.cboDeptParent.Sorted = true;
            this.cboDeptParent.TabIndex = 182;
            this.cboDeptParent.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboDeptParent.Watermark = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(858, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 181;
            this.label1.Text = "上级部门";
            // 
            // btnAddDept
            // 
            this.btnAddDept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDept.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnAddDept.Location = new System.Drawing.Point(820, 484);
            this.btnAddDept.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAddDept.Name = "btnAddDept";
            this.btnAddDept.Radius = 20;
            this.btnAddDept.Size = new System.Drawing.Size(165, 33);
            this.btnAddDept.TabIndex = 180;
            this.btnAddDept.Text = "新增部门";
            this.btnAddDept.Click += new System.EventHandler(this.btnAddDept_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(858, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 19);
            this.label9.TabIndex = 175;
            this.label9.Text = "部门主管";
            // 
            // cboDeptLeader
            // 
            this.cboDeptLeader.DataSource = null;
            this.cboDeptLeader.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cboDeptLeader.FillColor = System.Drawing.Color.White;
            this.cboDeptLeader.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboDeptLeader.Location = new System.Drawing.Point(820, 371);
            this.cboDeptLeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboDeptLeader.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboDeptLeader.Name = "cboDeptLeader";
            this.cboDeptLeader.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboDeptLeader.Radius = 20;
            this.cboDeptLeader.Size = new System.Drawing.Size(165, 29);
            this.cboDeptLeader.Sorted = true;
            this.cboDeptLeader.TabIndex = 174;
            this.cboDeptLeader.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboDeptLeader.Watermark = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(858, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 19);
            this.label8.TabIndex = 173;
            this.label8.Text = "部门描述";
            // 
            // txtDeptDesc
            // 
            this.txtDeptDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDeptDesc.FillColor = System.Drawing.Color.White;
            this.txtDeptDesc.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDeptDesc.Location = new System.Drawing.Point(820, 225);
            this.txtDeptDesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDeptDesc.Maximum = 2147483647D;
            this.txtDeptDesc.Minimum = -2147483648D;
            this.txtDeptDesc.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtDeptDesc.Multiline = true;
            this.txtDeptDesc.Name = "txtDeptDesc";
            this.txtDeptDesc.Padding = new System.Windows.Forms.Padding(5);
            this.txtDeptDesc.Radius = 10;
            this.txtDeptDesc.Size = new System.Drawing.Size(165, 103);
            this.txtDeptDesc.Style = Sunny.UI.UIStyle.Custom;
            this.txtDeptDesc.StyleCustomMode = true;
            this.txtDeptDesc.TabIndex = 172;
            this.txtDeptDesc.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(858, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 19);
            this.label7.TabIndex = 171;
            this.label7.Text = "部门名称";
            // 
            // txtDeptName
            // 
            this.txtDeptName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDeptName.FillColor = System.Drawing.Color.White;
            this.txtDeptName.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDeptName.Location = new System.Drawing.Point(820, 153);
            this.txtDeptName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDeptName.Maximum = 2147483647D;
            this.txtDeptName.Minimum = -2147483648D;
            this.txtDeptName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Padding = new System.Windows.Forms.Padding(5);
            this.txtDeptName.Radius = 20;
            this.txtDeptName.Size = new System.Drawing.Size(165, 29);
            this.txtDeptName.Style = Sunny.UI.UIStyle.Custom;
            this.txtDeptName.StyleCustomMode = true;
            this.txtDeptName.TabIndex = 170;
            this.txtDeptName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(858, 50);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(85, 19);
            this.label20.TabIndex = 169;
            this.label20.Text = "部门编号";
            // 
            // txtDeptNo
            // 
            this.txtDeptNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDeptNo.FillColor = System.Drawing.Color.White;
            this.txtDeptNo.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDeptNo.Location = new System.Drawing.Point(820, 81);
            this.txtDeptNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDeptNo.Maximum = 2147483647D;
            this.txtDeptNo.Minimum = -2147483648D;
            this.txtDeptNo.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtDeptNo.Name = "txtDeptNo";
            this.txtDeptNo.Padding = new System.Windows.Forms.Padding(5);
            this.txtDeptNo.Radius = 20;
            this.txtDeptNo.ReadOnly = true;
            this.txtDeptNo.Size = new System.Drawing.Size(165, 29);
            this.txtDeptNo.Style = Sunny.UI.UIStyle.Custom;
            this.txtDeptNo.StyleCustomMode = true;
            this.txtDeptNo.TabIndex = 168;
            this.txtDeptNo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnUpdateDept
            // 
            this.btnUpdateDept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateDept.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnUpdateDept.Location = new System.Drawing.Point(820, 529);
            this.btnUpdateDept.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnUpdateDept.Name = "btnUpdateDept";
            this.btnUpdateDept.Radius = 20;
            this.btnUpdateDept.Size = new System.Drawing.Size(165, 33);
            this.btnUpdateDept.TabIndex = 183;
            this.btnUpdateDept.Text = "更新部门";
            this.btnUpdateDept.Click += new System.EventHandler(this.btnUpdateDept_Click);
            // 
            // btnDeleteDept
            // 
            this.btnDeleteDept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteDept.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnDeleteDept.Location = new System.Drawing.Point(820, 574);
            this.btnDeleteDept.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDeleteDept.Name = "btnDeleteDept";
            this.btnDeleteDept.Radius = 20;
            this.btnDeleteDept.Size = new System.Drawing.Size(165, 33);
            this.btnDeleteDept.TabIndex = 184;
            this.btnDeleteDept.Text = "删除部门";
            this.btnDeleteDept.Click += new System.EventHandler(this.btnDeleteDept_Click);
            // 
            // FrmDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 623);
            this.ControlBox = false;
            this.Controls.Add(this.btnDeleteDept);
            this.Controls.Add(this.btnUpdateDept);
            this.Controls.Add(this.cboDeptParent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddDept);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboDeptLeader);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDeptDesc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDeptName);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtDeptNo);
            this.Controls.Add(this.dgvDeptList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDepartment";
            this.ShowIcon = true;
            this.ShowTitleIcon = true;
            this.Text = "部门信息";
            this.Load += new System.EventHandler(this.FrmDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeptList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIDataGridView dgvDeptList;
        private Sunny.UI.UIComboBox cboDeptParent;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UIButton btnAddDept;
        private System.Windows.Forms.Label label9;
        private Sunny.UI.UIComboBox cboDeptLeader;
        private System.Windows.Forms.Label label8;
        private Sunny.UI.UITextBox txtDeptDesc;
        private System.Windows.Forms.Label label7;
        private Sunny.UI.UITextBox txtDeptName;
        private System.Windows.Forms.Label label20;
        private Sunny.UI.UITextBox txtDeptNo;
        private Sunny.UI.UIButton btnUpdateDept;
        private Sunny.UI.UIButton btnDeleteDept;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDeptNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDeptName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDeptDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDeptDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDeptLeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDeptParent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}