namespace TSHotelManagerSystem
{
    partial class FrmCustoSpend
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
            this.dgvSpendList = new System.Windows.Forms.DataGridView();
            this.clRoomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCustoNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSpendName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSpendAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSpendPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSpendMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSpendTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMoneyState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpendList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSpendList
            // 
            this.dgvSpendList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSpendList.BackgroundColor = System.Drawing.Color.White;
            this.dgvSpendList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpendList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clRoomNo,
            this.clCustoNo,
            this.clSpendName,
            this.clSpendAmount,
            this.clSpendPrice,
            this.clSpendMoney,
            this.clSpendTime,
            this.clMoneyState});
            this.dgvSpendList.Location = new System.Drawing.Point(9, 12);
            this.dgvSpendList.Name = "dgvSpendList";
            this.dgvSpendList.RowTemplate.Height = 23;
            this.dgvSpendList.Size = new System.Drawing.Size(971, 375);
            this.dgvSpendList.TabIndex = 11;
            // 
            // clRoomNo
            // 
            this.clRoomNo.DataPropertyName = "RoomNo";
            this.clRoomNo.HeaderText = "房间号";
            this.clRoomNo.Name = "clRoomNo";
            // 
            // clCustoNo
            // 
            this.clCustoNo.DataPropertyName = "CustoNo";
            this.clCustoNo.HeaderText = "客户编号";
            this.clCustoNo.Name = "clCustoNo";
            // 
            // clSpendName
            // 
            this.clSpendName.DataPropertyName = "SpendName";
            this.clSpendName.HeaderText = "消费名称";
            this.clSpendName.Name = "clSpendName";
            // 
            // clSpendAmount
            // 
            this.clSpendAmount.DataPropertyName = "SpendAmount";
            this.clSpendAmount.HeaderText = "消费数量";
            this.clSpendAmount.Name = "clSpendAmount";
            // 
            // clSpendPrice
            // 
            this.clSpendPrice.DataPropertyName = "SpendPrice";
            this.clSpendPrice.HeaderText = "消费单价";
            this.clSpendPrice.Name = "clSpendPrice";
            // 
            // clSpendMoney
            // 
            this.clSpendMoney.DataPropertyName = "SpendMoney";
            this.clSpendMoney.HeaderText = "产生消费金额";
            this.clSpendMoney.Name = "clSpendMoney";
            // 
            // clSpendTime
            // 
            this.clSpendTime.DataPropertyName = "SpendTime";
            this.clSpendTime.HeaderText = "产生消费时间";
            this.clSpendTime.Name = "clSpendTime";
            // 
            // clMoneyState
            // 
            this.clMoneyState.DataPropertyName = "MoneyState";
            this.clMoneyState.HeaderText = "结算状态";
            this.clMoneyState.Name = "clMoneyState";
            // 
            // FrmCustoSpend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(989, 400);
            this.Controls.Add(this.dgvSpendList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCustoSpend";
            this.Text = "FrmCustoSpend";
            this.Load += new System.EventHandler(this.FrmCustoSpend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpendList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSpendList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRoomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCustoNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSpendName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSpendAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSpendPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSpendMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSpendTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMoneyState;
    }
}