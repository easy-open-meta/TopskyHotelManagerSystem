namespace TSHotelManagerSystem
{
    partial class FrmSellThingManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSellThingManager));
            this.label1 = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.dgvSellthing = new System.Windows.Forms.DataGridView();
            this.SellNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.format = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFind = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddSellThing = new System.Windows.Forms.Button();
            this.btnDeleteSellThing = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlSellThingInfo = new System.Windows.Forms.Panel();
            this.picGetCustoNo = new System.Windows.Forms.PictureBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtformat = new System.Windows.Forms.TextBox();
            this.txtSellPrice = new System.Windows.Forms.TextBox();
            this.txtSellName = new System.Windows.Forms.TextBox();
            this.txtSellNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellthing)).BeginInit();
            this.pnlSellThingInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGetCustoNo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(269, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "请您输入你要查找的东西：";
            // 
            // txtFind
            // 
            this.txtFind.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFind.Location = new System.Drawing.Point(447, 46);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(184, 27);
            this.txtFind.TabIndex = 5;
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
            this.dgvSellthing.Location = new System.Drawing.Point(12, 87);
            this.dgvSellthing.MultiSelect = false;
            this.dgvSellthing.Name = "dgvSellthing";
            this.dgvSellthing.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSellthing.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvSellthing.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSellthing.RowTemplate.Height = 23;
            this.dgvSellthing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSellthing.ShowEditingIcon = false;
            this.dgvSellthing.Size = new System.Drawing.Size(772, 396);
            this.dgvSellthing.TabIndex = 4;
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
            // btnFind
            // 
            this.btnFind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFind.BackgroundImage")));
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFind.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFind.Location = new System.Drawing.Point(644, 44);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 29);
            this.btnFind.TabIndex = 6;
            this.btnFind.Text = "查找";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("苹方-简", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(398, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 41);
            this.label4.TabIndex = 108;
            this.label4.Text = "商品后台管理";
            // 
            // btnAddSellThing
            // 
            this.btnAddSellThing.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddSellThing.BackgroundImage")));
            this.btnAddSellThing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddSellThing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSellThing.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddSellThing.Location = new System.Drawing.Point(790, 127);
            this.btnAddSellThing.Name = "btnAddSellThing";
            this.btnAddSellThing.Size = new System.Drawing.Size(187, 36);
            this.btnAddSellThing.TabIndex = 109;
            this.btnAddSellThing.Text = "新增商品";
            this.btnAddSellThing.UseVisualStyleBackColor = true;
            this.btnAddSellThing.Click += new System.EventHandler(this.btnAddSellThing_Click);
            // 
            // btnDeleteSellThing
            // 
            this.btnDeleteSellThing.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteSellThing.BackgroundImage")));
            this.btnDeleteSellThing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteSellThing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSellThing.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDeleteSellThing.Location = new System.Drawing.Point(790, 169);
            this.btnDeleteSellThing.Name = "btnDeleteSellThing";
            this.btnDeleteSellThing.Size = new System.Drawing.Size(187, 36);
            this.btnDeleteSellThing.TabIndex = 109;
            this.btnDeleteSellThing.Text = "删除商品";
            this.btnDeleteSellThing.UseVisualStyleBackColor = true;
            this.btnDeleteSellThing.Click += new System.EventHandler(this.btnDeleteSellThing_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(790, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 36);
            this.button2.TabIndex = 109;
            this.button2.Text = "修改商品信息";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pnlSellThingInfo
            // 
            this.pnlSellThingInfo.Controls.Add(this.picGetCustoNo);
            this.pnlSellThingInfo.Controls.Add(this.txtStock);
            this.pnlSellThingInfo.Controls.Add(this.txtformat);
            this.pnlSellThingInfo.Controls.Add(this.txtSellPrice);
            this.pnlSellThingInfo.Controls.Add(this.txtSellName);
            this.pnlSellThingInfo.Controls.Add(this.txtSellNo);
            this.pnlSellThingInfo.Controls.Add(this.label7);
            this.pnlSellThingInfo.Controls.Add(this.label6);
            this.pnlSellThingInfo.Controls.Add(this.label5);
            this.pnlSellThingInfo.Controls.Add(this.label3);
            this.pnlSellThingInfo.Controls.Add(this.label2);
            this.pnlSellThingInfo.Location = new System.Drawing.Point(790, 255);
            this.pnlSellThingInfo.Name = "pnlSellThingInfo";
            this.pnlSellThingInfo.Size = new System.Drawing.Size(187, 228);
            this.pnlSellThingInfo.TabIndex = 111;
            // 
            // picGetCustoNo
            // 
            this.picGetCustoNo.BackColor = System.Drawing.Color.Transparent;
            this.picGetCustoNo.BackgroundImage = global::TSHotelManagerSystem.Properties.Resources.获取用户编号;
            this.picGetCustoNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picGetCustoNo.Location = new System.Drawing.Point(162, 19);
            this.picGetCustoNo.Name = "picGetCustoNo";
            this.picGetCustoNo.Size = new System.Drawing.Size(20, 20);
            this.picGetCustoNo.TabIndex = 94;
            this.picGetCustoNo.TabStop = false;
            this.picGetCustoNo.Click += new System.EventHandler(this.picGetCustoNo_Click);
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtStock.Location = new System.Drawing.Point(59, 190);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 24);
            this.txtStock.TabIndex = 9;
            // 
            // txtformat
            // 
            this.txtformat.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtformat.Location = new System.Drawing.Point(59, 147);
            this.txtformat.Name = "txtformat";
            this.txtformat.Size = new System.Drawing.Size(100, 24);
            this.txtformat.TabIndex = 8;
            // 
            // txtSellPrice
            // 
            this.txtSellPrice.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSellPrice.Location = new System.Drawing.Point(59, 104);
            this.txtSellPrice.Name = "txtSellPrice";
            this.txtSellPrice.Size = new System.Drawing.Size(100, 24);
            this.txtSellPrice.TabIndex = 7;
            // 
            // txtSellName
            // 
            this.txtSellName.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSellName.Location = new System.Drawing.Point(59, 61);
            this.txtSellName.Name = "txtSellName";
            this.txtSellName.Size = new System.Drawing.Size(100, 24);
            this.txtSellName.TabIndex = 6;
            // 
            // txtSellNo
            // 
            this.txtSellNo.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSellNo.Location = new System.Drawing.Point(59, 18);
            this.txtSellNo.Name = "txtSellNo";
            this.txtSellNo.ReadOnly = true;
            this.txtSellNo.Size = new System.Drawing.Size(100, 24);
            this.txtSellNo.TabIndex = 5;
            this.txtSellNo.TextChanged += new System.EventHandler(this.txtSellNo_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(3, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "库    存";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(3, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "规    格";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(3, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "商品价格";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "商品名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "商品编号";
            // 
            // FrmSellThingManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(989, 495);
            this.Controls.Add(this.pnlSellThingInfo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDeleteSellThing);
            this.Controls.Add(this.btnAddSellThing);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.dgvSellthing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSellThingManager";
            this.Text = "FrmSellThingManager";
            this.Load += new System.EventHandler(this.FrmSellThingManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellthing)).EndInit();
            this.pnlSellThingInfo.ResumeLayout(false);
            this.pnlSellThingInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGetCustoNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.DataGridView dgvSellthing;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn format;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddSellThing;
        private System.Windows.Forms.Button btnDeleteSellThing;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnlSellThingInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtformat;
        private System.Windows.Forms.TextBox txtSellPrice;
        private System.Windows.Forms.TextBox txtSellName;
        private System.Windows.Forms.TextBox txtSellNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picGetCustoNo;
    }
}