namespace SYS.FormUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSellThingManager));
            this.dgvSellthing = new System.Windows.Forms.DataGridView();
            this.SellNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.format = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSellThingInfo = new System.Windows.Forms.Panel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.txtFind = new Sunny.UI.UITextBox();
            this.btnFind = new Sunny.UI.UIButton();
            this.btnAddSellThing = new Sunny.UI.UIButton();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.btnDeleteSellThing = new Sunny.UI.UIButton();
            this.label20 = new System.Windows.Forms.Label();
            this.txtSellNo = new Sunny.UI.UITextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSellName = new Sunny.UI.UITextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSellPrice = new Sunny.UI.UITextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtformat = new Sunny.UI.UITextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStock = new Sunny.UI.UIDoubleUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellthing)).BeginInit();
            this.pnlSellThingInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSellthing
            // 
            this.dgvSellthing.AllowUserToAddRows = false;
            this.dgvSellthing.AllowUserToDeleteRows = false;
            this.dgvSellthing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSellthing.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSellthing.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvSellthing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSellthing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SellNo,
            this.SellName,
            this.SellPrice,
            this.format,
            this.Stock});
            this.dgvSellthing.Location = new System.Drawing.Point(3, 87);
            this.dgvSellthing.MultiSelect = false;
            this.dgvSellthing.Name = "dgvSellthing";
            this.dgvSellthing.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvSellthing.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSellthing.RowTemplate.Height = 23;
            this.dgvSellthing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSellthing.ShowEditingIcon = false;
            this.dgvSellthing.Size = new System.Drawing.Size(803, 533);
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
            // pnlSellThingInfo
            // 
            this.pnlSellThingInfo.Controls.Add(this.txtStock);
            this.pnlSellThingInfo.Controls.Add(this.label4);
            this.pnlSellThingInfo.Controls.Add(this.label3);
            this.pnlSellThingInfo.Controls.Add(this.txtformat);
            this.pnlSellThingInfo.Controls.Add(this.label2);
            this.pnlSellThingInfo.Controls.Add(this.txtSellPrice);
            this.pnlSellThingInfo.Controls.Add(this.label1);
            this.pnlSellThingInfo.Controls.Add(this.txtSellName);
            this.pnlSellThingInfo.Controls.Add(this.label20);
            this.pnlSellThingInfo.Controls.Add(this.txtSellNo);
            this.pnlSellThingInfo.Location = new System.Drawing.Point(812, 45);
            this.pnlSellThingInfo.Name = "pnlSellThingInfo";
            this.pnlSellThingInfo.Size = new System.Drawing.Size(187, 438);
            this.pnlSellThingInfo.TabIndex = 111;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(173, 45);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(125, 29);
            this.uiLabel1.TabIndex = 114;
            this.uiLabel1.Text = "要查找的商品：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFind
            // 
            this.txtFind.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFind.FillColor = System.Drawing.Color.White;
            this.txtFind.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtFind.Location = new System.Drawing.Point(305, 45);
            this.txtFind.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFind.Maximum = 2147483647D;
            this.txtFind.Minimum = -2147483648D;
            this.txtFind.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtFind.Name = "txtFind";
            this.txtFind.Padding = new System.Windows.Forms.Padding(5);
            this.txtFind.Radius = 20;
            this.txtFind.Size = new System.Drawing.Size(197, 29);
            this.txtFind.TabIndex = 113;
            // 
            // btnFind
            // 
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnFind.Location = new System.Drawing.Point(509, 45);
            this.btnFind.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnFind.Name = "btnFind";
            this.btnFind.Radius = 20;
            this.btnFind.Size = new System.Drawing.Size(101, 28);
            this.btnFind.TabIndex = 112;
            this.btnFind.Text = "查     找";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnAddSellThing
            // 
            this.btnAddSellThing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSellThing.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnAddSellThing.Location = new System.Drawing.Point(818, 489);
            this.btnAddSellThing.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAddSellThing.Name = "btnAddSellThing";
            this.btnAddSellThing.Radius = 20;
            this.btnAddSellThing.Size = new System.Drawing.Size(176, 37);
            this.btnAddSellThing.TabIndex = 115;
            this.btnAddSellThing.Text = "新增商品信息";
            this.btnAddSellThing.Click += new System.EventHandler(this.btnAddSellThing_Click);
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton2.Location = new System.Drawing.Point(818, 532);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Radius = 20;
            this.uiButton2.Size = new System.Drawing.Size(176, 37);
            this.uiButton2.TabIndex = 116;
            this.uiButton2.Text = "修改商品信息";
            // 
            // btnDeleteSellThing
            // 
            this.btnDeleteSellThing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteSellThing.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnDeleteSellThing.Location = new System.Drawing.Point(818, 575);
            this.btnDeleteSellThing.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDeleteSellThing.Name = "btnDeleteSellThing";
            this.btnDeleteSellThing.Radius = 20;
            this.btnDeleteSellThing.Size = new System.Drawing.Size(176, 37);
            this.btnDeleteSellThing.TabIndex = 117;
            this.btnDeleteSellThing.Text = "删除商品信息";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(49, 29);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(88, 25);
            this.label20.TabIndex = 139;
            this.label20.Text = "商品编号";
            // 
            // txtSellNo
            // 
            this.txtSellNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSellNo.FillColor = System.Drawing.Color.White;
            this.txtSellNo.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSellNo.Location = new System.Drawing.Point(11, 63);
            this.txtSellNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSellNo.Maximum = 2147483647D;
            this.txtSellNo.Minimum = -2147483648D;
            this.txtSellNo.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSellNo.Name = "txtSellNo";
            this.txtSellNo.Padding = new System.Windows.Forms.Padding(5);
            this.txtSellNo.Radius = 20;
            this.txtSellNo.ReadOnly = true;
            this.txtSellNo.Size = new System.Drawing.Size(165, 35);
            this.txtSellNo.Style = Sunny.UI.UIStyle.Custom;
            this.txtSellNo.StyleCustomMode = true;
            this.txtSellNo.TabIndex = 138;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(49, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 141;
            this.label1.Text = "商品名称";
            // 
            // txtSellName
            // 
            this.txtSellName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSellName.FillColor = System.Drawing.Color.White;
            this.txtSellName.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSellName.Location = new System.Drawing.Point(11, 141);
            this.txtSellName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSellName.Maximum = 2147483647D;
            this.txtSellName.Minimum = -2147483648D;
            this.txtSellName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSellName.Name = "txtSellName";
            this.txtSellName.Padding = new System.Windows.Forms.Padding(5);
            this.txtSellName.Radius = 20;
            this.txtSellName.ReadOnly = true;
            this.txtSellName.Size = new System.Drawing.Size(165, 35);
            this.txtSellName.Style = Sunny.UI.UIStyle.Custom;
            this.txtSellName.StyleCustomMode = true;
            this.txtSellName.TabIndex = 140;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(49, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 143;
            this.label2.Text = "商品价格";
            // 
            // txtSellPrice
            // 
            this.txtSellPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSellPrice.FillColor = System.Drawing.Color.White;
            this.txtSellPrice.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSellPrice.Location = new System.Drawing.Point(11, 219);
            this.txtSellPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSellPrice.Maximum = 2147483647D;
            this.txtSellPrice.Minimum = -2147483648D;
            this.txtSellPrice.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSellPrice.Name = "txtSellPrice";
            this.txtSellPrice.Padding = new System.Windows.Forms.Padding(5);
            this.txtSellPrice.Radius = 20;
            this.txtSellPrice.ReadOnly = true;
            this.txtSellPrice.Size = new System.Drawing.Size(165, 35);
            this.txtSellPrice.Style = Sunny.UI.UIStyle.Custom;
            this.txtSellPrice.StyleCustomMode = true;
            this.txtSellPrice.TabIndex = 142;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(49, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 145;
            this.label3.Text = "商品规格";
            // 
            // txtformat
            // 
            this.txtformat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtformat.FillColor = System.Drawing.Color.White;
            this.txtformat.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtformat.Location = new System.Drawing.Point(11, 297);
            this.txtformat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtformat.Maximum = 2147483647D;
            this.txtformat.Minimum = -2147483648D;
            this.txtformat.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtformat.Name = "txtformat";
            this.txtformat.Padding = new System.Windows.Forms.Padding(5);
            this.txtformat.Radius = 20;
            this.txtformat.ReadOnly = true;
            this.txtformat.Size = new System.Drawing.Size(165, 35);
            this.txtformat.Style = Sunny.UI.UIStyle.Custom;
            this.txtformat.StyleCustomMode = true;
            this.txtformat.TabIndex = 144;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(49, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 147;
            this.label4.Text = "商品库存";
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.txtStock.Location = new System.Drawing.Point(11, 375);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStock.MinimumSize = new System.Drawing.Size(100, 0);
            this.txtStock.Name = "txtStock";
            this.txtStock.Radius = 20;
            this.txtStock.Size = new System.Drawing.Size(165, 35);
            this.txtStock.TabIndex = 148;
            this.txtStock.Text = "uiDoubleUpDown1";
            this.txtStock.Value = 0D;
            // 
            // FrmSellThingManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1005, 623);
            this.ControlBox = false;
            this.Controls.Add(this.btnDeleteSellThing);
            this.Controls.Add(this.uiButton2);
            this.Controls.Add(this.btnAddSellThing);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.pnlSellThingInfo);
            this.Controls.Add(this.dgvSellthing);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSellThingManager";
            this.ShowIcon = true;
            this.Text = "商品管理";
            this.Load += new System.EventHandler(this.FrmSellThingManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellthing)).EndInit();
            this.pnlSellThingInfo.ResumeLayout(false);
            this.pnlSellThingInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSellthing;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn format;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.Panel pnlSellThingInfo;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox txtFind;
        private Sunny.UI.UIButton btnFind;
        private Sunny.UI.UIButton btnAddSellThing;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIButton btnDeleteSellThing;
        private Sunny.UI.UIDoubleUpDown txtStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Sunny.UI.UITextBox txtformat;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UITextBox txtSellPrice;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UITextBox txtSellName;
        private System.Windows.Forms.Label label20;
        private Sunny.UI.UITextBox txtSellNo;
    }
}