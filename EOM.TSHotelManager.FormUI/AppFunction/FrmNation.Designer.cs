
namespace EOM.TSHotelManager.FormUI
{
    partial class FrmNation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNation));
            this.btnDeleteNation = new Sunny.UI.UIButton();
            this.btnUpdateNation = new Sunny.UI.UIButton();
            this.btnAddNation = new Sunny.UI.UIButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNationName = new Sunny.UI.UITextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtNationNo = new Sunny.UI.UITextBox();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDeleteMk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNationNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNationList = new Sunny.UI.UIDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNationList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteNation
            // 
            this.btnDeleteNation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteNation.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnDeleteNation.Location = new System.Drawing.Point(823, 419);
            this.btnDeleteNation.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDeleteNation.Name = "btnDeleteNation";
            this.btnDeleteNation.Radius = 20;
            this.btnDeleteNation.Size = new System.Drawing.Size(165, 33);
            this.btnDeleteNation.TabIndex = 206;
            this.btnDeleteNation.Text = "删除民族";
            this.btnDeleteNation.Click += new System.EventHandler(this.btnDeleteNation_Click);
            // 
            // btnUpdateNation
            // 
            this.btnUpdateNation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateNation.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnUpdateNation.Location = new System.Drawing.Point(823, 374);
            this.btnUpdateNation.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnUpdateNation.Name = "btnUpdateNation";
            this.btnUpdateNation.Radius = 20;
            this.btnUpdateNation.Size = new System.Drawing.Size(165, 33);
            this.btnUpdateNation.TabIndex = 205;
            this.btnUpdateNation.Text = "更新民族";
            this.btnUpdateNation.Click += new System.EventHandler(this.btnUpdateNation_Click);
            // 
            // btnAddNation
            // 
            this.btnAddNation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNation.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnAddNation.Location = new System.Drawing.Point(823, 329);
            this.btnAddNation.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAddNation.Name = "btnAddNation";
            this.btnAddNation.Radius = 20;
            this.btnAddNation.Size = new System.Drawing.Size(165, 33);
            this.btnAddNation.TabIndex = 204;
            this.btnAddNation.Text = "新增民族";
            this.btnAddNation.Click += new System.EventHandler(this.btnAddNation_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(861, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 19);
            this.label7.TabIndex = 203;
            this.label7.Text = "民族名称";
            // 
            // txtNationName
            // 
            this.txtNationName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNationName.FillColor = System.Drawing.Color.White;
            this.txtNationName.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNationName.Location = new System.Drawing.Point(823, 278);
            this.txtNationName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNationName.Maximum = 2147483647D;
            this.txtNationName.Minimum = -2147483648D;
            this.txtNationName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtNationName.Name = "txtNationName";
            this.txtNationName.Padding = new System.Windows.Forms.Padding(5);
            this.txtNationName.Radius = 20;
            this.txtNationName.Size = new System.Drawing.Size(165, 29);
            this.txtNationName.StyleCustomMode = true;
            this.txtNationName.TabIndex = 202;
            this.txtNationName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(861, 175);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(85, 19);
            this.label20.TabIndex = 201;
            this.label20.Text = "民族编号";
            // 
            // txtNationNo
            // 
            this.txtNationNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNationNo.FillColor = System.Drawing.Color.White;
            this.txtNationNo.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNationNo.Location = new System.Drawing.Point(823, 206);
            this.txtNationNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNationNo.Maximum = 2147483647D;
            this.txtNationNo.Minimum = -2147483648D;
            this.txtNationNo.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtNationNo.Name = "txtNationNo";
            this.txtNationNo.Padding = new System.Windows.Forms.Padding(5);
            this.txtNationNo.Radius = 20;
            this.txtNationNo.ReadOnly = true;
            this.txtNationNo.Size = new System.Drawing.Size(165, 29);
            this.txtNationNo.StyleCustomMode = true;
            this.txtNationNo.TabIndex = 200;
            this.txtNationNo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "datachg_date";
            this.Column5.HeaderText = "datachg_date";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "datachg_usr";
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "datains_date";
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "datains_usr";
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // clDeleteMk
            // 
            this.clDeleteMk.DataPropertyName = "delete_mk";
            this.clDeleteMk.HeaderText = "Column1";
            this.clDeleteMk.Name = "clDeleteMk";
            this.clDeleteMk.ReadOnly = true;
            this.clDeleteMk.Visible = false;
            // 
            // clNationName
            // 
            this.clNationName.DataPropertyName = "nation_name";
            this.clNationName.HeaderText = "民族名称";
            this.clNationName.Name = "clNationName";
            this.clNationName.ReadOnly = true;
            // 
            // clNationNo
            // 
            this.clNationNo.DataPropertyName = "nation_no";
            this.clNationNo.HeaderText = "民族编号";
            this.clNationNo.Name = "clNationNo";
            this.clNationNo.ReadOnly = true;
            // 
            // dgvNationList
            // 
            this.dgvNationList.AllowUserToAddRows = false;
            this.dgvNationList.AllowUserToDeleteRows = false;
            this.dgvNationList.AllowUserToResizeColumns = false;
            this.dgvNationList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgvNationList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNationList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNationList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvNationList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNationList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNationList.ColumnHeadersHeight = 32;
            this.dgvNationList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvNationList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clNationNo,
            this.clNationName,
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
            this.dgvNationList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNationList.EnableHeadersVisualStyles = false;
            this.dgvNationList.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgvNationList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvNationList.Location = new System.Drawing.Point(5, 38);
            this.dgvNationList.MultiSelect = false;
            this.dgvNationList.Name = "dgvNationList";
            this.dgvNationList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNationList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNationList.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvNationList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvNationList.RowTemplate.Height = 29;
            this.dgvNationList.SelectedIndex = -1;
            this.dgvNationList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNationList.Size = new System.Drawing.Size(788, 582);
            this.dgvNationList.TabIndex = 199;
            this.dgvNationList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvNationList_CellMouseClick);
            // 
            // FrmNation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 623);
            this.ControlBox = false;
            this.Controls.Add(this.btnDeleteNation);
            this.Controls.Add(this.btnUpdateNation);
            this.Controls.Add(this.btnAddNation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNationName);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtNationNo);
            this.Controls.Add(this.dgvNationList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNation";
            this.ShowIcon = true;
            this.ShowTitleIcon = true;
            this.Text = "民族类型维护";
            this.Load += new System.EventHandler(this.FrmNation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNationList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIButton btnDeleteNation;
        private Sunny.UI.UIButton btnUpdateNation;
        private Sunny.UI.UIButton btnAddNation;
        private System.Windows.Forms.Label label7;
        private Sunny.UI.UITextBox txtNationName;
        private System.Windows.Forms.Label label20;
        private Sunny.UI.UITextBox txtNationNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDeleteMk;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNationNo;
        private Sunny.UI.UIDataGridView dgvNationList;
    }
}