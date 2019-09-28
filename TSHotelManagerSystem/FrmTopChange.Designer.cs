namespace TSHotelManagerSystem
{
    partial class FrmTopChange
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
            this.dgvWorkerList = new System.Windows.Forms.DataGridView();
            this.clWorkerNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clWorkerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clWorkerBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clWorkerSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clWorkerTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clWorkerClub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clWorkerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clWorkerPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clWorkerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clWorkerPwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clWorkerTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clWorkerFace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiRefresh = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkerList)).BeginInit();
            this.cmsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvWorkerList
            // 
            this.dgvWorkerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWorkerList.BackgroundColor = System.Drawing.Color.White;
            this.dgvWorkerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clWorkerNo,
            this.clWorkerName,
            this.clWorkerBirth,
            this.clWorkerSex,
            this.clWorkerTel,
            this.clWorkerClub,
            this.clWorkerAddress,
            this.clWorkerPosition,
            this.clWorkerID,
            this.clWorkerPwd,
            this.clWorkerTime,
            this.clWorkerFace});
            this.dgvWorkerList.ContextMenuStrip = this.cmsMain;
            this.dgvWorkerList.Location = new System.Drawing.Point(2, 1);
            this.dgvWorkerList.Name = "dgvWorkerList";
            this.dgvWorkerList.ReadOnly = true;
            this.dgvWorkerList.RowTemplate.Height = 23;
            this.dgvWorkerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWorkerList.Size = new System.Drawing.Size(985, 493);
            this.dgvWorkerList.TabIndex = 0;
            this.dgvWorkerList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorkerList_CellClick);
            // 
            // clWorkerNo
            // 
            this.clWorkerNo.DataPropertyName = "WorkerID";
            this.clWorkerNo.HeaderText = "工号";
            this.clWorkerNo.Name = "clWorkerNo";
            this.clWorkerNo.ReadOnly = true;
            // 
            // clWorkerName
            // 
            this.clWorkerName.DataPropertyName = "WorkerName";
            this.clWorkerName.HeaderText = "员工姓名";
            this.clWorkerName.Name = "clWorkerName";
            this.clWorkerName.ReadOnly = true;
            // 
            // clWorkerBirth
            // 
            this.clWorkerBirth.DataPropertyName = "WorkerBirth";
            this.clWorkerBirth.HeaderText = "出生日期";
            this.clWorkerBirth.Name = "clWorkerBirth";
            this.clWorkerBirth.ReadOnly = true;
            // 
            // clWorkerSex
            // 
            this.clWorkerSex.DataPropertyName = "WorkerSex";
            this.clWorkerSex.HeaderText = "性别";
            this.clWorkerSex.Name = "clWorkerSex";
            this.clWorkerSex.ReadOnly = true;
            // 
            // clWorkerTel
            // 
            this.clWorkerTel.DataPropertyName = "WorkerTel";
            this.clWorkerTel.HeaderText = "员工电话";
            this.clWorkerTel.Name = "clWorkerTel";
            this.clWorkerTel.ReadOnly = true;
            // 
            // clWorkerClub
            // 
            this.clWorkerClub.DataPropertyName = "WorkerClub";
            this.clWorkerClub.HeaderText = "所属部门";
            this.clWorkerClub.Name = "clWorkerClub";
            this.clWorkerClub.ReadOnly = true;
            // 
            // clWorkerAddress
            // 
            this.clWorkerAddress.DataPropertyName = "WorkerAddress";
            this.clWorkerAddress.HeaderText = "员工住址";
            this.clWorkerAddress.Name = "clWorkerAddress";
            this.clWorkerAddress.ReadOnly = true;
            // 
            // clWorkerPosition
            // 
            this.clWorkerPosition.DataPropertyName = "WorkerPosition";
            this.clWorkerPosition.HeaderText = "职位";
            this.clWorkerPosition.Name = "clWorkerPosition";
            this.clWorkerPosition.ReadOnly = true;
            // 
            // clWorkerID
            // 
            this.clWorkerID.DataPropertyName = "CardID";
            this.clWorkerID.HeaderText = "身份证号码";
            this.clWorkerID.Name = "clWorkerID";
            this.clWorkerID.ReadOnly = true;
            // 
            // clWorkerPwd
            // 
            this.clWorkerPwd.DataPropertyName = "WorkerPwd";
            this.clWorkerPwd.HeaderText = "员工密码";
            this.clWorkerPwd.Name = "clWorkerPwd";
            this.clWorkerPwd.ReadOnly = true;
            this.clWorkerPwd.Visible = false;
            // 
            // clWorkerTime
            // 
            this.clWorkerTime.DataPropertyName = "WorkerTime";
            this.clWorkerTime.HeaderText = "入职日期";
            this.clWorkerTime.Name = "clWorkerTime";
            this.clWorkerTime.ReadOnly = true;
            // 
            // clWorkerFace
            // 
            this.clWorkerFace.DataPropertyName = "WorkerFace";
            this.clWorkerFace.HeaderText = "员工面貌";
            this.clWorkerFace.Name = "clWorkerFace";
            this.clWorkerFace.ReadOnly = true;
            // 
            // cmsMain
            // 
            this.cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRefresh});
            this.cmsMain.Name = "cmsMain";
            this.cmsMain.Size = new System.Drawing.Size(125, 26);
            // 
            // tsmiRefresh
            // 
            this.tsmiRefresh.Name = "tsmiRefresh";
            this.tsmiRefresh.Size = new System.Drawing.Size(152, 22);
            this.tsmiRefresh.Text = "刷新列表";
            this.tsmiRefresh.Click += new System.EventHandler(this.tsmiRefresh_Click);
            // 
            // FrmTopChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(989, 497);
            this.Controls.Add(this.dgvWorkerList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTopChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTopChange";
            this.Load += new System.EventHandler(this.FrmTopChange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkerList)).EndInit();
            this.cmsMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWorkerList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWorkerNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWorkerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWorkerBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWorkerSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWorkerTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWorkerClub;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWorkerAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWorkerPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWorkerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWorkerPwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWorkerTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWorkerFace;
        private System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiRefresh;
    }
}