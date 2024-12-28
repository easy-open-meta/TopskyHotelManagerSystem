namespace EOM.TSHotelManager.FormUI
{
    partial class FrmWorkerManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWorkerManager));
            this.dgvWorkerList = new Sunny.UI.UIDataGridView();
            this.clWorkerNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clWorkerPwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clWorkerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clWorkerBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clWorkerSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clWorkerTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clWorkerClub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clWorkerNation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clWorkerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clWorkerPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clWorkerCardID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clWorkerTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clWorkerFace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clWorkerEducation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefush = new Sunny.UI.UIButton();
            this.btnAddWorker = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkerList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWorkerList
            // 
            this.dgvWorkerList.AllowUserToAddRows = false;
            this.dgvWorkerList.AllowUserToDeleteRows = false;
            this.dgvWorkerList.AllowUserToResizeColumns = false;
            this.dgvWorkerList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvWorkerList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWorkerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWorkerList.BackgroundColor = System.Drawing.Color.White;
            this.dgvWorkerList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorkerList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvWorkerList.ColumnHeadersHeight = 32;
            this.dgvWorkerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvWorkerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clWorkerNo,
            this.clWorkerPwd,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.clWorkerName,
            this.clWorkerBirthday,
            this.clWorkerSex,
            this.clWorkerTel,
            this.clWorkerClub,
            this.clWorkerNation,
            this.clWorkerAddress,
            this.clWorkerPosition,
            this.clWorkerCardID,
            this.clWorkerTime,
            this.clWorkerFace,
            this.clWorkerEducation});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWorkerList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvWorkerList.EnableHeadersVisualStyles = false;
            this.dgvWorkerList.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgvWorkerList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvWorkerList.Location = new System.Drawing.Point(3, 38);
            this.dgvWorkerList.Name = "dgvWorkerList";
            this.dgvWorkerList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorkerList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvWorkerList.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvWorkerList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvWorkerList.RowTemplate.Height = 29;
            this.dgvWorkerList.SelectedIndex = -1;
            this.dgvWorkerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWorkerList.Size = new System.Drawing.Size(999, 540);
            this.dgvWorkerList.Style = Sunny.UI.UIStyle.Custom;
            this.dgvWorkerList.TabIndex = 3;
            this.dgvWorkerList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorkerList_CellClick);
            // 
            // clWorkerNo
            // 
            this.clWorkerNo.DataPropertyName = "WorkerId";
            this.clWorkerNo.HeaderText = "工号";
            this.clWorkerNo.Name = "clWorkerNo";
            this.clWorkerNo.ReadOnly = true;
            // 
            // clWorkerPwd
            // 
            this.clWorkerPwd.DataPropertyName = "WorkerPwd";
            this.clWorkerPwd.HeaderText = "Column11";
            this.clWorkerPwd.Name = "clWorkerPwd";
            this.clWorkerPwd.ReadOnly = true;
            this.clWorkerPwd.Visible = false;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "datains_usr";
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "datains_date";
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "datachg_usr";
            this.Column9.HeaderText = "Column9";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "datachg_date";
            this.Column10.HeaderText = "Column10";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
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
            this.Column2.DataPropertyName = "WorkerSex";
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "WorkerNation";
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "WorkerPosition";
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "WorkerClub";
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "WorkerEducation";
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // clWorkerName
            // 
            this.clWorkerName.DataPropertyName = "WorkerName";
            this.clWorkerName.HeaderText = "名字";
            this.clWorkerName.Name = "clWorkerName";
            this.clWorkerName.ReadOnly = true;
            // 
            // clWorkerBirthday
            // 
            this.clWorkerBirthday.DataPropertyName = "WorkerBirthday";
            this.clWorkerBirthday.HeaderText = "出生日期";
            this.clWorkerBirthday.Name = "clWorkerBirthday";
            this.clWorkerBirthday.ReadOnly = true;
            // 
            // clWorkerSex
            // 
            this.clWorkerSex.DataPropertyName = "WorkerSexName";
            this.clWorkerSex.HeaderText = "性别";
            this.clWorkerSex.Name = "clWorkerSex";
            this.clWorkerSex.ReadOnly = true;
            // 
            // clWorkerTel
            // 
            this.clWorkerTel.DataPropertyName = "WorkerTel";
            this.clWorkerTel.HeaderText = "联系方式";
            this.clWorkerTel.Name = "clWorkerTel";
            this.clWorkerTel.ReadOnly = true;
            this.clWorkerTel.Visible = false;
            // 
            // clWorkerClub
            // 
            this.clWorkerClub.DataPropertyName = "ClubName";
            this.clWorkerClub.HeaderText = "部门";
            this.clWorkerClub.Name = "clWorkerClub";
            this.clWorkerClub.ReadOnly = true;
            // 
            // clWorkerNation
            // 
            this.clWorkerNation.DataPropertyName = "NationName";
            this.clWorkerNation.HeaderText = "民族";
            this.clWorkerNation.Name = "clWorkerNation";
            this.clWorkerNation.ReadOnly = true;
            // 
            // clWorkerAddress
            // 
            this.clWorkerAddress.DataPropertyName = "WorkerAddress";
            this.clWorkerAddress.HeaderText = "居住地址";
            this.clWorkerAddress.Name = "clWorkerAddress";
            this.clWorkerAddress.ReadOnly = true;
            this.clWorkerAddress.Visible = false;
            // 
            // clWorkerPosition
            // 
            this.clWorkerPosition.DataPropertyName = "PositionName";
            this.clWorkerPosition.HeaderText = "职位";
            this.clWorkerPosition.Name = "clWorkerPosition";
            this.clWorkerPosition.ReadOnly = true;
            // 
            // clWorkerCardID
            // 
            this.clWorkerCardID.DataPropertyName = "CardID";
            this.clWorkerCardID.HeaderText = "证件号码";
            this.clWorkerCardID.Name = "clWorkerCardID";
            this.clWorkerCardID.ReadOnly = true;
            this.clWorkerCardID.Visible = false;
            // 
            // clWorkerTime
            // 
            this.clWorkerTime.DataPropertyName = "WorkerTime";
            this.clWorkerTime.HeaderText = "入职时间";
            this.clWorkerTime.Name = "clWorkerTime";
            this.clWorkerTime.ReadOnly = true;
            // 
            // clWorkerFace
            // 
            this.clWorkerFace.DataPropertyName = "WorkerFace";
            this.clWorkerFace.HeaderText = "面貌";
            this.clWorkerFace.Name = "clWorkerFace";
            this.clWorkerFace.ReadOnly = true;
            // 
            // clWorkerEducation
            // 
            this.clWorkerEducation.DataPropertyName = "EducationName";
            this.clWorkerEducation.HeaderText = "学历";
            this.clWorkerEducation.Name = "clWorkerEducation";
            this.clWorkerEducation.ReadOnly = true;
            // 
            // btnRefush
            // 
            this.btnRefush.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefush.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnRefush.Location = new System.Drawing.Point(818, 584);
            this.btnRefush.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRefush.Name = "btnRefush";
            this.btnRefush.Radius = 30;
            this.btnRefush.Size = new System.Drawing.Size(88, 30);
            this.btnRefush.Style = Sunny.UI.UIStyle.Custom;
            this.btnRefush.TabIndex = 99;
            this.btnRefush.Text = "刷新列表";
            this.btnRefush.Click += new System.EventHandler(this.btnRefush_Click);
            // 
            // btnAddWorker
            // 
            this.btnAddWorker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddWorker.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnAddWorker.Location = new System.Drawing.Point(912, 584);
            this.btnAddWorker.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAddWorker.Name = "btnAddWorker";
            this.btnAddWorker.Radius = 30;
            this.btnAddWorker.Size = new System.Drawing.Size(86, 30);
            this.btnAddWorker.Style = Sunny.UI.UIStyle.Custom;
            this.btnAddWorker.TabIndex = 100;
            this.btnAddWorker.Text = "添加员工";
            this.btnAddWorker.Click += new System.EventHandler(this.btnAddWorker_Click);
            // 
            // FrmWorkerManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1005, 623);
            this.ControlBox = false;
            this.Controls.Add(this.btnAddWorker);
            this.Controls.Add(this.btnRefush);
            this.Controls.Add(this.dgvWorkerList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmWorkerManager";
            this.ShowIcon = true;
            this.ShowTitleIcon = true;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "员工管理";
            this.Load += new System.EventHandler(this.FrmTopChange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkerList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIDataGridView dgvWorkerList;
        private Sunny.UI.UIButton btnRefush;
        private Sunny.UI.UIButton btnAddWorker;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWorkerNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWorkerPwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWorkerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWorkerBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWorkerSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWorkerTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWorkerClub;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWorkerNation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWorkerAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWorkerPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWorkerCardID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWorkerTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWorkerFace;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWorkerEducation;
    }
}