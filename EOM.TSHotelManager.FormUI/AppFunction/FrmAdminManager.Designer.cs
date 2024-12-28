
namespace EOM.TSHotelManager.FormUI
{
    partial class FrmAdminManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminManager));
            this.btnAuthority = new Sunny.UI.UIButton();
            this.dgvAdminList = new Sunny.UI.UIDataGridView();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAdminAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAdminPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAdminType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAdminName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIsAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDeleteMk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAuthority
            // 
            this.btnAuthority.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAuthority.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnAuthority.Location = new System.Drawing.Point(888, 580);
            this.btnAuthority.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAuthority.Name = "btnAuthority";
            this.btnAuthority.Radius = 20;
            this.btnAuthority.Size = new System.Drawing.Size(106, 35);
            this.btnAuthority.TabIndex = 129;
            this.btnAuthority.Text = "启/禁用账号";
            this.btnAuthority.Click += new System.EventHandler(this.btnAuthority_Click);
            // 
            // dgvAdminList
            // 
            this.dgvAdminList.AllowUserToAddRows = false;
            this.dgvAdminList.AllowUserToDeleteRows = false;
            this.dgvAdminList.AllowUserToResizeColumns = false;
            this.dgvAdminList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvAdminList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAdminList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdminList.BackgroundColor = System.Drawing.Color.White;
            this.dgvAdminList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdminList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAdminList.ColumnHeadersHeight = 32;
            this.dgvAdminList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAdminList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clId,
            this.clAdminAccount,
            this.clAdminPassword,
            this.clAdminType,
            this.clAdminName,
            this.clIsAdmin,
            this.clDeleteMk,
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
            this.dgvAdminList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAdminList.EnableHeadersVisualStyles = false;
            this.dgvAdminList.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgvAdminList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvAdminList.Location = new System.Drawing.Point(3, 38);
            this.dgvAdminList.Name = "dgvAdminList";
            this.dgvAdminList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdminList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAdminList.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvAdminList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAdminList.RowTemplate.Height = 29;
            this.dgvAdminList.SelectedIndex = -1;
            this.dgvAdminList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdminList.Size = new System.Drawing.Size(991, 535);
            this.dgvAdminList.TabIndex = 130;
            // 
            // clId
            // 
            this.clId.DataPropertyName = "Id";
            this.clId.HeaderText = "编号";
            this.clId.Name = "clId";
            this.clId.ReadOnly = true;
            // 
            // clAdminAccount
            // 
            this.clAdminAccount.DataPropertyName = "AdminAccount";
            this.clAdminAccount.HeaderText = "管理员账号";
            this.clAdminAccount.Name = "clAdminAccount";
            this.clAdminAccount.ReadOnly = true;
            // 
            // clAdminPassword
            // 
            this.clAdminPassword.DataPropertyName = "AdminPassword";
            this.clAdminPassword.HeaderText = "管理员密码";
            this.clAdminPassword.Name = "clAdminPassword";
            this.clAdminPassword.ReadOnly = true;
            this.clAdminPassword.Visible = false;
            // 
            // clAdminType
            // 
            this.clAdminType.DataPropertyName = "TypeName";
            this.clAdminType.HeaderText = "管理员类型";
            this.clAdminType.Name = "clAdminType";
            this.clAdminType.ReadOnly = true;
            // 
            // clAdminName
            // 
            this.clAdminName.DataPropertyName = "AdminName";
            this.clAdminName.HeaderText = "真实姓名";
            this.clAdminName.Name = "clAdminName";
            this.clAdminName.ReadOnly = true;
            // 
            // clIsAdmin
            // 
            this.clIsAdmin.DataPropertyName = "IsAdminNm";
            this.clIsAdmin.HeaderText = "是否为超级管理";
            this.clIsAdmin.Name = "clIsAdmin";
            this.clIsAdmin.ReadOnly = true;
            // 
            // clDeleteMk
            // 
            this.clDeleteMk.DataPropertyName = "DeleteNm";
            this.clDeleteMk.HeaderText = "删除标记";
            this.clDeleteMk.Name = "clDeleteMk";
            this.clDeleteMk.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "DeleteMk";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "AdminType";
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "IsAdmin";
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "datains_usr";
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "datains_date";
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "datachg_usr";
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "datachg_date";
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // FrmAdminManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 623);
            this.ControlBox = false;
            this.Controls.Add(this.dgvAdminList);
            this.Controls.Add(this.btnAuthority);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdminManager";
            this.ShowIcon = true;
            this.ShowTitleIcon = true;
            this.Text = "启/禁用管理员";
            this.Load += new System.EventHandler(this.FrmAdminManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIButton btnAuthority;
        private Sunny.UI.UIDataGridView dgvAdminList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAdminAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAdminPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAdminType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAdminName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIsAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDeleteMk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}