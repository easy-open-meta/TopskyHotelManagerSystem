
namespace EOM.TSHotelManager.FormUI
{
    partial class FrmEducation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEducation));
            this.btnDeleteEducation = new Sunny.UI.UIButton();
            this.btnUpdateEducation = new Sunny.UI.UIButton();
            this.btnAddEducation = new Sunny.UI.UIButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEducationName = new Sunny.UI.UITextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtEducationNo = new Sunny.UI.UITextBox();
            this.dgvEducationList = new Sunny.UI.UIDataGridView();
            this.clEducationNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEducationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDeleteMk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEducationList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteEducation
            // 
            this.btnDeleteEducation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteEducation.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnDeleteEducation.Location = new System.Drawing.Point(821, 419);
            this.btnDeleteEducation.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDeleteEducation.Name = "btnDeleteEducation";
            this.btnDeleteEducation.Radius = 20;
            this.btnDeleteEducation.Size = new System.Drawing.Size(165, 33);
            this.btnDeleteEducation.TabIndex = 198;
            this.btnDeleteEducation.Text = "删除学历";
            this.btnDeleteEducation.Click += new System.EventHandler(this.btnDeleteEducation_Click);
            // 
            // btnUpdateEducation
            // 
            this.btnUpdateEducation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateEducation.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnUpdateEducation.Location = new System.Drawing.Point(821, 374);
            this.btnUpdateEducation.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnUpdateEducation.Name = "btnUpdateEducation";
            this.btnUpdateEducation.Radius = 20;
            this.btnUpdateEducation.Size = new System.Drawing.Size(165, 33);
            this.btnUpdateEducation.TabIndex = 197;
            this.btnUpdateEducation.Text = "更新学历";
            this.btnUpdateEducation.Click += new System.EventHandler(this.btnUpdateEducation_Click);
            // 
            // btnAddEducation
            // 
            this.btnAddEducation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEducation.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnAddEducation.Location = new System.Drawing.Point(821, 329);
            this.btnAddEducation.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAddEducation.Name = "btnAddEducation";
            this.btnAddEducation.Radius = 20;
            this.btnAddEducation.Size = new System.Drawing.Size(165, 33);
            this.btnAddEducation.TabIndex = 194;
            this.btnAddEducation.Text = "新增学历";
            this.btnAddEducation.Click += new System.EventHandler(this.btnAddEducation_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(859, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 19);
            this.label7.TabIndex = 189;
            this.label7.Text = "学历名称";
            // 
            // txtEducationName
            // 
            this.txtEducationName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEducationName.FillColor = System.Drawing.Color.White;
            this.txtEducationName.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtEducationName.Location = new System.Drawing.Point(821, 278);
            this.txtEducationName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEducationName.Maximum = 2147483647D;
            this.txtEducationName.Minimum = -2147483648D;
            this.txtEducationName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtEducationName.Name = "txtEducationName";
            this.txtEducationName.Padding = new System.Windows.Forms.Padding(5);
            this.txtEducationName.Radius = 20;
            this.txtEducationName.Size = new System.Drawing.Size(165, 29);
            this.txtEducationName.Style = Sunny.UI.UIStyle.Custom;
            this.txtEducationName.StyleCustomMode = true;
            this.txtEducationName.TabIndex = 188;
            this.txtEducationName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(859, 175);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(85, 19);
            this.label20.TabIndex = 187;
            this.label20.Text = "学历编号";
            // 
            // txtEducationNo
            // 
            this.txtEducationNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEducationNo.FillColor = System.Drawing.Color.White;
            this.txtEducationNo.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtEducationNo.Location = new System.Drawing.Point(821, 206);
            this.txtEducationNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEducationNo.Maximum = 2147483647D;
            this.txtEducationNo.Minimum = -2147483648D;
            this.txtEducationNo.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtEducationNo.Name = "txtEducationNo";
            this.txtEducationNo.Padding = new System.Windows.Forms.Padding(5);
            this.txtEducationNo.Radius = 20;
            this.txtEducationNo.ReadOnly = true;
            this.txtEducationNo.Size = new System.Drawing.Size(165, 29);
            this.txtEducationNo.Style = Sunny.UI.UIStyle.Custom;
            this.txtEducationNo.StyleCustomMode = true;
            this.txtEducationNo.TabIndex = 186;
            this.txtEducationNo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvEducationList
            // 
            this.dgvEducationList.AllowUserToAddRows = false;
            this.dgvEducationList.AllowUserToDeleteRows = false;
            this.dgvEducationList.AllowUserToResizeColumns = false;
            this.dgvEducationList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvEducationList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEducationList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEducationList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvEducationList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEducationList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEducationList.ColumnHeadersHeight = 32;
            this.dgvEducationList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEducationList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clEducationNo,
            this.clEducationName,
            this.clDeleteMk,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEducationList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEducationList.EnableHeadersVisualStyles = false;
            this.dgvEducationList.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgvEducationList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvEducationList.Location = new System.Drawing.Point(3, 38);
            this.dgvEducationList.MultiSelect = false;
            this.dgvEducationList.Name = "dgvEducationList";
            this.dgvEducationList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEducationList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEducationList.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvEducationList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEducationList.RowTemplate.Height = 29;
            this.dgvEducationList.SelectedIndex = -1;
            this.dgvEducationList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEducationList.Size = new System.Drawing.Size(788, 582);
            this.dgvEducationList.TabIndex = 185;
            this.dgvEducationList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEducationList_CellMouseClick);
            // 
            // clEducationNo
            // 
            this.clEducationNo.DataPropertyName = "education_no";
            this.clEducationNo.HeaderText = "学历编号";
            this.clEducationNo.Name = "clEducationNo";
            this.clEducationNo.ReadOnly = true;
            // 
            // clEducationName
            // 
            this.clEducationName.DataPropertyName = "education_name";
            this.clEducationName.HeaderText = "学历名称";
            this.clEducationName.Name = "clEducationName";
            this.clEducationName.ReadOnly = true;
            // 
            // clDeleteMk
            // 
            this.clDeleteMk.DataPropertyName = "delete_mk";
            this.clDeleteMk.HeaderText = "Column1";
            this.clDeleteMk.Name = "clDeleteMk";
            this.clDeleteMk.ReadOnly = true;
            this.clDeleteMk.Visible = false;
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
            // FrmEducation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 627);
            this.ControlBox = false;
            this.Controls.Add(this.btnDeleteEducation);
            this.Controls.Add(this.btnUpdateEducation);
            this.Controls.Add(this.btnAddEducation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEducationName);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtEducationNo);
            this.Controls.Add(this.dgvEducationList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEducation";
            this.ShowIcon = true;
            this.ShowTitleIcon = true;
            this.Text = "学历类型维护";
            this.Load += new System.EventHandler(this.FrmEducation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEducationList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIButton btnDeleteEducation;
        private Sunny.UI.UIButton btnUpdateEducation;
        private Sunny.UI.UIButton btnAddEducation;
        private System.Windows.Forms.Label label7;
        private Sunny.UI.UITextBox txtEducationName;
        private System.Windows.Forms.Label label20;
        private Sunny.UI.UITextBox txtEducationNo;
        private Sunny.UI.UIDataGridView dgvEducationList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEducationNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEducationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDeleteMk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}