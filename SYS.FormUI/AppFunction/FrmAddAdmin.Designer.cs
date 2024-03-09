
namespace SYS.FormUI
{
    partial class FrmAddAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddAdmin));
            this.cbAccountType = new Sunny.UI.UIComboBox();
            this.txtAccount = new Sunny.UI.UITextBox();
            this.txtName = new Sunny.UI.UITextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new Sunny.UI.UITextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvAdminList = new Sunny.UI.UIDataGridView();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAdminAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAdminPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAdminType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAdminName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIsAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDeleteMk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.btnAdd = new Sunny.UI.UIButton();
            this.btnReset = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminList)).BeginInit();
            this.SuspendLayout();
            // 
            // cbAccountType
            // 
            this.cbAccountType.DataSource = null;
            this.cbAccountType.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbAccountType.FillColor = System.Drawing.Color.White;
            this.cbAccountType.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.cbAccountType.Location = new System.Drawing.Point(175, 124);
            this.cbAccountType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbAccountType.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbAccountType.Name = "cbAccountType";
            this.cbAccountType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbAccountType.Radius = 20;
            this.cbAccountType.Size = new System.Drawing.Size(250, 35);
            this.cbAccountType.TabIndex = 118;
            this.cbAccountType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbAccountType.Watermark = "";
            this.cbAccountType.SelectedIndexChanged += new System.EventHandler(this.cbAccountType_SelectedIndexChanged);
            // 
            // txtAccount
            // 
            this.txtAccount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccount.FillColor = System.Drawing.Color.White;
            this.txtAccount.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAccount.Location = new System.Drawing.Point(173, 63);
            this.txtAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAccount.Maximum = 2147483647D;
            this.txtAccount.Minimum = -2147483648D;
            this.txtAccount.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Padding = new System.Windows.Forms.Padding(5);
            this.txtAccount.Radius = 20;
            this.txtAccount.Size = new System.Drawing.Size(250, 35);
            this.txtAccount.Style = Sunny.UI.UIStyle.Custom;
            this.txtAccount.StyleCustomMode = true;
            this.txtAccount.TabIndex = 111;
            this.txtAccount.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.FillColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.Location = new System.Drawing.Point(563, 124);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Maximum = 2147483647D;
            this.txtName.Minimum = -2147483648D;
            this.txtName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(5);
            this.txtName.Radius = 20;
            this.txtName.Size = new System.Drawing.Size(250, 35);
            this.txtName.Style = Sunny.UI.UIStyle.Custom;
            this.txtName.StyleCustomMode = true;
            this.txtName.TabIndex = 119;
            this.txtName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(62, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 109;
            this.label6.Text = "账户类型";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(450, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 108;
            this.label3.Text = "真实姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(62, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 107;
            this.label2.Text = "账      号";
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.FillColor = System.Drawing.Color.White;
            this.txtPassword.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPassword.Location = new System.Drawing.Point(561, 63);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Maximum = 2147483647D;
            this.txtPassword.Minimum = -2147483648D;
            this.txtPassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(5);
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Radius = 20;
            this.txtPassword.Size = new System.Drawing.Size(250, 35);
            this.txtPassword.Style = Sunny.UI.UIStyle.Custom;
            this.txtPassword.StyleCustomMode = true;
            this.txtPassword.TabIndex = 117;
            this.txtPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(448, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 115;
            this.label4.Text = "账号密码";
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
            this.clDeleteMk});
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
            this.dgvAdminList.Location = new System.Drawing.Point(11, 224);
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
            //this.dgvAdminList.RowHeight = 29;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvAdminList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAdminList.RowTemplate.Height = 29;
            this.dgvAdminList.SelectedIndex = -1;
            this.dgvAdminList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            //this.dgvAdminList.ShowGridLine = true;
            this.dgvAdminList.Size = new System.Drawing.Size(979, 386);
            this.dgvAdminList.TabIndex = 118;
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
            this.clDeleteMk.DataPropertyName = "DeleteMk";
            this.clDeleteMk.HeaderText = "删除标记";
            this.clDeleteMk.Name = "clDeleteMk";
            this.clDeleteMk.ReadOnly = true;
            this.clDeleteMk.Visible = false;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox1.Location = new System.Drawing.Point(4, 189);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(994, 429);
            this.uiGroupBox1.TabIndex = 119;
            this.uiGroupBox1.Text = "现有管理员列表";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiGroupBox1.TitleAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnAdd.Location = new System.Drawing.Point(836, 63);
            this.btnAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Radius = 20;
            this.btnAdd.Size = new System.Drawing.Size(101, 35);
            this.btnAdd.TabIndex = 120;
            this.btnAdd.Text = "添       加";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnReset.Location = new System.Drawing.Point(838, 124);
            this.btnReset.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnReset.Name = "btnReset";
            this.btnReset.Radius = 20;
            this.btnReset.Size = new System.Drawing.Size(101, 35);
            this.btnReset.TabIndex = 121;
            this.btnReset.Text = "重       置";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FrmAddAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 623);
            this.ControlBox = false;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvAdminList);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbAccountType);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uiGroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsForbidAltF4 = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddAdmin";
            this.ShowIcon = true;
            this.ShowTitleIcon = true;
            this.Text = "添加管理员";
            this.Load += new System.EventHandler(this.FrmAddAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIComboBox cbAccountType;
        private Sunny.UI.UITextBox txtAccount;
        private Sunny.UI.UITextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UITextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private Sunny.UI.UIDataGridView dgvAdminList;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIButton btnAdd;
        private Sunny.UI.UIButton btnReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAdminAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAdminPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAdminType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAdminName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIsAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDeleteMk;
    }
}