namespace TSHotelManagerSystem
{
    partial class FrmSellThing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSellThing));
            this.dgvSellthing = new System.Windows.Forms.DataGridView();
            this.SellNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.format = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtSellNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudNum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSellName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRoomNo = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.dgvRoomSell = new System.Windows.Forms.DataGridView();
            this.RoomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustoNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpendName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpendAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpendPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpendMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpendTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMoneyState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellthing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNum)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomSell)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSellthing
            // 
            this.dgvSellthing.AllowUserToAddRows = false;
            this.dgvSellthing.AllowUserToDeleteRows = false;
            this.dgvSellthing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSellthing.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSellthing.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgvSellthing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSellthing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SellNo,
            this.SellName,
            this.SellPrice,
            this.format,
            this.Stock});
            this.dgvSellthing.Location = new System.Drawing.Point(12, 41);
            this.dgvSellthing.MultiSelect = false;
            this.dgvSellthing.Name = "dgvSellthing";
            this.dgvSellthing.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSellthing.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSellthing.RowTemplate.Height = 23;
            this.dgvSellthing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSellthing.ShowEditingIcon = false;
            this.dgvSellthing.Size = new System.Drawing.Size(482, 397);
            this.dgvSellthing.TabIndex = 0;
            this.dgvSellthing.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSellthing_CellClick);
            // 
            // SellNo
            // 
            this.SellNo.DataPropertyName = "SellNo";
            this.SellNo.FillWeight = 89.19898F;
            this.SellNo.HeaderText = "商品编号";
            this.SellNo.Name = "SellNo";
            this.SellNo.ReadOnly = true;
            // 
            // SellName
            // 
            this.SellName.DataPropertyName = "SellName";
            this.SellName.FillWeight = 156.261F;
            this.SellName.HeaderText = "商品名称";
            this.SellName.Name = "SellName";
            this.SellName.ReadOnly = true;
            // 
            // SellPrice
            // 
            this.SellPrice.DataPropertyName = "SellPrice";
            this.SellPrice.FillWeight = 89.19898F;
            this.SellPrice.HeaderText = "商品价格";
            this.SellPrice.Name = "SellPrice";
            this.SellPrice.ReadOnly = true;
            // 
            // format
            // 
            this.format.DataPropertyName = "format";
            this.format.FillWeight = 76.14214F;
            this.format.HeaderText = "规格";
            this.format.Name = "format";
            this.format.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.DataPropertyName = "Stock";
            this.Stock.FillWeight = 89.19898F;
            this.Stock.HeaderText = "库存";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // txtFind
            // 
            this.txtFind.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFind.Location = new System.Drawing.Point(199, 5);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(176, 26);
            this.txtFind.TabIndex = 1;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "请您输入你要查找的东西：";
            // 
            // btnFind
            // 
            this.btnFind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFind.BackgroundImage")));
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFind.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFind.Location = new System.Drawing.Point(396, 3);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 28);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "查找";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtSellNo
            // 
            this.txtSellNo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSellNo.Location = new System.Drawing.Point(132, 27);
            this.txtSellNo.Name = "txtSellNo";
            this.txtSellNo.Size = new System.Drawing.Size(125, 23);
            this.txtSellNo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(60, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "商品编号：";
            // 
            // nudNum
            // 
            this.nudNum.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nudNum.Location = new System.Drawing.Point(132, 99);
            this.nudNum.Name = "nudNum";
            this.nudNum.Size = new System.Drawing.Size(125, 23);
            this.nudNum.TabIndex = 6;
            this.nudNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(60, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "数      量：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtSellName);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.nudNum);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtSellNo);
            this.groupBox2.Location = new System.Drawing.Point(500, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 175);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "订购中心";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(60, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "商品名称：";
            // 
            // txtSellName
            // 
            this.txtSellName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSellName.Location = new System.Drawing.Point(132, 63);
            this.txtSellName.Name = "txtSellName";
            this.txtSellName.Size = new System.Drawing.Size(125, 23);
            this.txtSellName.TabIndex = 10;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPrice.Location = new System.Drawing.Point(132, 135);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(125, 23);
            this.txtPrice.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(60, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "单      价：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(556, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "房间编号：";
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtRoomNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtRoomNo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRoomNo.Location = new System.Drawing.Point(650, 6);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Size = new System.Drawing.Size(148, 26);
            this.txtRoomNo.TabIndex = 6;
            this.txtRoomNo.TextChanged += new System.EventHandler(this.txtRoomNo_TextChanged);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("华文行楷", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblState.Location = new System.Drawing.Point(805, 9);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(0, 21);
            this.lblState.TabIndex = 11;
            // 
            // dgvRoomSell
            // 
            this.dgvRoomSell.AllowUserToAddRows = false;
            this.dgvRoomSell.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoomSell.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgvRoomSell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomSell.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomNo,
            this.CustoNo,
            this.SpendName,
            this.SpendAmount,
            this.SpendPrice,
            this.SpendMoney,
            this.SpendTime,
            this.clMoneyState});
            this.dgvRoomSell.Location = new System.Drawing.Point(500, 219);
            this.dgvRoomSell.MultiSelect = false;
            this.dgvRoomSell.Name = "dgvRoomSell";
            this.dgvRoomSell.ReadOnly = true;
            this.dgvRoomSell.RowTemplate.Height = 23;
            this.dgvRoomSell.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoomSell.Size = new System.Drawing.Size(482, 219);
            this.dgvRoomSell.TabIndex = 12;
            this.dgvRoomSell.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoomSell_CellClick);
            // 
            // RoomNo
            // 
            this.RoomNo.DataPropertyName = "RoomNo";
            this.RoomNo.HeaderText = "房间编号";
            this.RoomNo.Name = "RoomNo";
            this.RoomNo.ReadOnly = true;
            // 
            // CustoNo
            // 
            this.CustoNo.DataPropertyName = "CustoNo";
            this.CustoNo.HeaderText = "客户编号";
            this.CustoNo.Name = "CustoNo";
            this.CustoNo.ReadOnly = true;
            // 
            // SpendName
            // 
            this.SpendName.DataPropertyName = "SpendName";
            this.SpendName.HeaderText = "商品名称";
            this.SpendName.Name = "SpendName";
            this.SpendName.ReadOnly = true;
            // 
            // SpendAmount
            // 
            this.SpendAmount.DataPropertyName = "SpendAmount";
            this.SpendAmount.HeaderText = "数量";
            this.SpendAmount.Name = "SpendAmount";
            this.SpendAmount.ReadOnly = true;
            // 
            // SpendPrice
            // 
            this.SpendPrice.DataPropertyName = "SpendPrice";
            this.SpendPrice.HeaderText = "商品单价";
            this.SpendPrice.Name = "SpendPrice";
            this.SpendPrice.ReadOnly = true;
            // 
            // SpendMoney
            // 
            this.SpendMoney.DataPropertyName = "SpendMoney";
            this.SpendMoney.HeaderText = "消费金额";
            this.SpendMoney.Name = "SpendMoney";
            this.SpendMoney.ReadOnly = true;
            // 
            // SpendTime
            // 
            this.SpendTime.DataPropertyName = "SpendTime";
            this.SpendTime.HeaderText = "消费时间";
            this.SpendTime.Name = "SpendTime";
            this.SpendTime.ReadOnly = true;
            // 
            // clMoneyState
            // 
            this.clMoneyState.DataPropertyName = "MoneyState";
            this.clMoneyState.HeaderText = "结算状态";
            this.clMoneyState.Name = "clMoneyState";
            this.clMoneyState.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.ForeColor = System.Drawing.Color.Navy;
            this.btnAdd.Location = new System.Drawing.Point(308, 103);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 36);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "确定添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.btnCancel.ForeColor = System.Drawing.Color.Navy;
            this.btnCancel.Location = new System.Drawing.Point(308, 41);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 36);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "撤回添加";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmSellThing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(994, 453);
            this.Controls.Add(this.dgvRoomSell);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRoomNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.dgvSellthing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSellThing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSellThing";
            this.Load += new System.EventHandler(this.FrmSellThing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellthing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNum)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomSell)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSellthing;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn format;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSellNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudNum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSellName;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.DataGridView dgvRoomSell;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustoNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpendName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpendAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpendPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpendMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpendTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMoneyState;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}