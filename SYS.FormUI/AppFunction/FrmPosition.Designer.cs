
namespace SYS.FormUI
{
    partial class FrmPosition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPosition));
            this.btnDeletePosition = new Sunny.UI.UIButton();
            this.btnUpdatePosition = new Sunny.UI.UIButton();
            this.btnAddPosition = new Sunny.UI.UIButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPositionName = new Sunny.UI.UITextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtPositionNo = new Sunny.UI.UITextBox();
            this.dgvPositionList = new Sunny.UI.UIDataGridView();
            this.clPositionNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPositionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDeleteMk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPositionList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeletePosition
            // 
            this.btnDeletePosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletePosition.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnDeletePosition.Location = new System.Drawing.Point(821, 419);
            this.btnDeletePosition.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDeletePosition.Name = "btnDeletePosition";
            this.btnDeletePosition.Radius = 20;
            this.btnDeletePosition.Size = new System.Drawing.Size(165, 33);
            this.btnDeletePosition.TabIndex = 214;
            this.btnDeletePosition.Text = "删除职位";
            this.btnDeletePosition.Click += new System.EventHandler(this.btnDeletePosition_Click);
            // 
            // btnUpdatePosition
            // 
            this.btnUpdatePosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdatePosition.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnUpdatePosition.Location = new System.Drawing.Point(821, 374);
            this.btnUpdatePosition.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnUpdatePosition.Name = "btnUpdatePosition";
            this.btnUpdatePosition.Radius = 20;
            this.btnUpdatePosition.Size = new System.Drawing.Size(165, 33);
            this.btnUpdatePosition.TabIndex = 213;
            this.btnUpdatePosition.Text = "更新职位";
            this.btnUpdatePosition.Click += new System.EventHandler(this.btnUpdatePosition_Click);
            // 
            // btnAddPosition
            // 
            this.btnAddPosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPosition.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnAddPosition.Location = new System.Drawing.Point(821, 329);
            this.btnAddPosition.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAddPosition.Name = "btnAddPosition";
            this.btnAddPosition.Radius = 20;
            this.btnAddPosition.Size = new System.Drawing.Size(165, 33);
            this.btnAddPosition.TabIndex = 212;
            this.btnAddPosition.Text = "新增职位";
            this.btnAddPosition.Click += new System.EventHandler(this.btnAddPosition_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(859, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 19);
            this.label7.TabIndex = 211;
            this.label7.Text = "职位名称";
            // 
            // txtPositionName
            // 
            this.txtPositionName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPositionName.FillColor = System.Drawing.Color.White;
            this.txtPositionName.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPositionName.Location = new System.Drawing.Point(821, 278);
            this.txtPositionName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPositionName.Maximum = 2147483647D;
            this.txtPositionName.Minimum = -2147483648D;
            this.txtPositionName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPositionName.Name = "txtPositionName";
            this.txtPositionName.Padding = new System.Windows.Forms.Padding(5);
            this.txtPositionName.Radius = 20;
            this.txtPositionName.Size = new System.Drawing.Size(165, 29);
            this.txtPositionName.Style = Sunny.UI.UIStyle.Custom;
            this.txtPositionName.StyleCustomMode = true;
            this.txtPositionName.TabIndex = 210;
            this.txtPositionName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(859, 175);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(85, 19);
            this.label20.TabIndex = 209;
            this.label20.Text = "职位编号";
            // 
            // txtPositionNo
            // 
            this.txtPositionNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPositionNo.FillColor = System.Drawing.Color.White;
            this.txtPositionNo.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPositionNo.Location = new System.Drawing.Point(821, 206);
            this.txtPositionNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPositionNo.Maximum = 2147483647D;
            this.txtPositionNo.Minimum = -2147483648D;
            this.txtPositionNo.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPositionNo.Name = "txtPositionNo";
            this.txtPositionNo.Padding = new System.Windows.Forms.Padding(5);
            this.txtPositionNo.Radius = 20;
            this.txtPositionNo.ReadOnly = true;
            this.txtPositionNo.Size = new System.Drawing.Size(165, 29);
            this.txtPositionNo.Style = Sunny.UI.UIStyle.Custom;
            this.txtPositionNo.StyleCustomMode = true;
            this.txtPositionNo.TabIndex = 208;
            this.txtPositionNo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvPositionList
            // 
            this.dgvPositionList.AllowUserToAddRows = false;
            this.dgvPositionList.AllowUserToDeleteRows = false;
            this.dgvPositionList.AllowUserToResizeColumns = false;
            this.dgvPositionList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvPositionList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPositionList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPositionList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvPositionList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPositionList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPositionList.ColumnHeadersHeight = 32;
            this.dgvPositionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPositionList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clPositionNo,
            this.clPositionName,
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
            this.dgvPositionList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPositionList.EnableHeadersVisualStyles = false;
            this.dgvPositionList.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgvPositionList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvPositionList.Location = new System.Drawing.Point(3, 38);
            this.dgvPositionList.MultiSelect = false;
            this.dgvPositionList.Name = "dgvPositionList";
            this.dgvPositionList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPositionList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPositionList.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvPositionList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPositionList.RowTemplate.Height = 29;
            this.dgvPositionList.SelectedIndex = -1;
            this.dgvPositionList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPositionList.Size = new System.Drawing.Size(788, 582);
            this.dgvPositionList.TabIndex = 207;
            this.dgvPositionList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPositionList_CellMouseClick);
            // 
            // clPositionNo
            // 
            this.clPositionNo.DataPropertyName = "position_no";
            this.clPositionNo.HeaderText = "职位编号";
            this.clPositionNo.Name = "clPositionNo";
            this.clPositionNo.ReadOnly = true;
            // 
            // clPositionName
            // 
            this.clPositionName.DataPropertyName = "position_name";
            this.clPositionName.HeaderText = "职位名称";
            this.clPositionName.Name = "clPositionName";
            this.clPositionName.ReadOnly = true;
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
            this.Column5.HeaderText = "datachg_date";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // FrmPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 623);
            this.ControlBox = false;
            this.Controls.Add(this.btnDeletePosition);
            this.Controls.Add(this.btnUpdatePosition);
            this.Controls.Add(this.btnAddPosition);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPositionName);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtPositionNo);
            this.Controls.Add(this.dgvPositionList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPosition";
            this.ShowIcon = true;
            this.ShowTitleIcon = true;
            this.Text = "职位类型维护";
            this.Load += new System.EventHandler(this.FrmPosition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPositionList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIButton btnDeletePosition;
        private Sunny.UI.UIButton btnUpdatePosition;
        private Sunny.UI.UIButton btnAddPosition;
        private System.Windows.Forms.Label label7;
        private Sunny.UI.UITextBox txtPositionName;
        private System.Windows.Forms.Label label20;
        private Sunny.UI.UITextBox txtPositionNo;
        private Sunny.UI.UIDataGridView dgvPositionList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPositionNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPositionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDeleteMk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}