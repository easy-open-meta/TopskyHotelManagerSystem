namespace TSHotelManagerSystem
{
    partial class FrmCash
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
            this.dgvCashList = new System.Windows.Forms.DataGridView();
            this.clCashNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCashName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCashPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCashClub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCashTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCashSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCashPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCashList
            // 
            this.dgvCashList.AllowUserToAddRows = false;
            this.dgvCashList.AllowUserToDeleteRows = false;
            this.dgvCashList.AllowUserToResizeColumns = false;
            this.dgvCashList.AllowUserToResizeRows = false;
            this.dgvCashList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCashList.BackgroundColor = System.Drawing.Color.White;
            this.dgvCashList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCashList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCashNo,
            this.clCashName,
            this.clCashPrice,
            this.clCashClub,
            this.clCashTime,
            this.clCashSource,
            this.clCashPerson});
            this.dgvCashList.Location = new System.Drawing.Point(12, 12);
            this.dgvCashList.Name = "dgvCashList";
            this.dgvCashList.ReadOnly = true;
            this.dgvCashList.RowTemplate.Height = 23;
            this.dgvCashList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCashList.Size = new System.Drawing.Size(965, 446);
            this.dgvCashList.TabIndex = 0;
            // 
            // clCashNo
            // 
            this.clCashNo.DataPropertyName = "CashNo";
            this.clCashNo.HeaderText = "资产编号";
            this.clCashNo.Name = "clCashNo";
            this.clCashNo.ReadOnly = true;
            // 
            // clCashName
            // 
            this.clCashName.DataPropertyName = "CashName";
            this.clCashName.HeaderText = "资产名称";
            this.clCashName.Name = "clCashName";
            this.clCashName.ReadOnly = true;
            // 
            // clCashPrice
            // 
            this.clCashPrice.DataPropertyName = "CashPrice";
            this.clCashPrice.HeaderText = "资产价值";
            this.clCashPrice.Name = "clCashPrice";
            this.clCashPrice.ReadOnly = true;
            // 
            // clCashClub
            // 
            this.clCashClub.DataPropertyName = "CashClub";
            this.clCashClub.HeaderText = "所属部门";
            this.clCashClub.Name = "clCashClub";
            this.clCashClub.ReadOnly = true;
            // 
            // clCashTime
            // 
            this.clCashTime.DataPropertyName = "CashTime";
            this.clCashTime.HeaderText = "资产入库时间";
            this.clCashTime.Name = "clCashTime";
            this.clCashTime.ReadOnly = true;
            // 
            // clCashSource
            // 
            this.clCashSource.DataPropertyName = "CashSource";
            this.clCashSource.HeaderText = "资产来源";
            this.clCashSource.Name = "clCashSource";
            this.clCashSource.ReadOnly = true;
            // 
            // clCashPerson
            // 
            this.clCashPerson.DataPropertyName = "CashPerson";
            this.clCashPerson.HeaderText = "资产经办人";
            this.clCashPerson.Name = "clCashPerson";
            this.clCashPerson.ReadOnly = true;
            // 
            // FrmCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = global::TSHotelManagerSystem.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(989, 495);
            this.Controls.Add(this.dgvCashList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCash";
            this.Text = "FrmCash";
            this.Load += new System.EventHandler(this.FrmCash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCashList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCashNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCashName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCashPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCashClub;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCashTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCashSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCashPerson;
    }
}