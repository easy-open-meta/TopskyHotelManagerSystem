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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSellThingManager));
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.txtFind = new Sunny.UI.UITextBox();
            this.btnFind = new Sunny.UI.UIButton();
            this.btnAddSellThing = new Sunny.UI.UIButton();
            this.btnUpdateSellthing = new Sunny.UI.UIButton();
            this.btnDeleteSellThing = new Sunny.UI.UIButton();
            this.dgvSellthing = new Sunny.UI.UIDataGridView();
            this.clSellNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSellName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFormat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtStock = new Sunny.UI.UIDoubleUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtformat = new Sunny.UI.UITextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSellPrice = new Sunny.UI.UITextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSellName = new Sunny.UI.UITextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtSellNo = new Sunny.UI.UITextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellthing)).BeginInit();
            this.SuspendLayout();
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
            this.txtFind.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
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
            // btnUpdateSellthing
            // 
            this.btnUpdateSellthing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateSellthing.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnUpdateSellthing.Location = new System.Drawing.Point(818, 532);
            this.btnUpdateSellthing.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnUpdateSellthing.Name = "btnUpdateSellthing";
            this.btnUpdateSellthing.Radius = 20;
            this.btnUpdateSellthing.Size = new System.Drawing.Size(176, 37);
            this.btnUpdateSellthing.TabIndex = 116;
            this.btnUpdateSellthing.Text = "修改商品信息";
            this.btnUpdateSellthing.Click += new System.EventHandler(this.btnUpdateSellthing_Click);
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
            this.btnDeleteSellThing.Click += new System.EventHandler(this.btnDeleteSellThing_Click);
            // 
            // dgvSellthing
            // 
            this.dgvSellthing.AllowUserToAddRows = false;
            this.dgvSellthing.AllowUserToDeleteRows = false;
            this.dgvSellthing.AllowUserToResizeColumns = false;
            this.dgvSellthing.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvSellthing.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSellthing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSellthing.BackgroundColor = System.Drawing.Color.White;
            this.dgvSellthing.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSellthing.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSellthing.ColumnHeadersHeight = 32;
            this.dgvSellthing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSellthing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSellNo,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.clSellName,
            this.clSellPrice,
            this.clFormat,
            this.clStock});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSellthing.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSellthing.EnableHeadersVisualStyles = false;
            this.dgvSellthing.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgvSellthing.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvSellthing.Location = new System.Drawing.Point(3, 82);
            this.dgvSellthing.Name = "dgvSellthing";
            this.dgvSellthing.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSellthing.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSellthing.RowHeadersVisible = false;
            this.dgvSellthing.RowHeight = 29;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvSellthing.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSellthing.RowTemplate.Height = 29;
            this.dgvSellthing.SelectedIndex = -1;
            this.dgvSellthing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSellthing.ShowGridLine = true;
            this.dgvSellthing.Size = new System.Drawing.Size(803, 538);
            this.dgvSellthing.TabIndex = 118;
            this.dgvSellthing.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSellthing_CellClick);
            // 
            // clSellNo
            // 
            this.clSellNo.DataPropertyName = "SellNo";
            this.clSellNo.HeaderText = "商品编号";
            this.clSellNo.Name = "clSellNo";
            this.clSellNo.ReadOnly = true;
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
            this.Column2.DataPropertyName = "datains_usr";
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "datains_date";
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "datachg_usr";
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "datachg_date";
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // clSellName
            // 
            this.clSellName.DataPropertyName = "SellName";
            this.clSellName.HeaderText = "商品名称";
            this.clSellName.Name = "clSellName";
            this.clSellName.ReadOnly = true;
            // 
            // clSellPrice
            // 
            this.clSellPrice.DataPropertyName = "SellPriceStr";
            this.clSellPrice.HeaderText = "价格(元)";
            this.clSellPrice.Name = "clSellPrice";
            this.clSellPrice.ReadOnly = true;
            // 
            // clFormat
            // 
            this.clFormat.DataPropertyName = "format";
            this.clFormat.HeaderText = "规格";
            this.clFormat.Name = "clFormat";
            this.clFormat.ReadOnly = true;
            // 
            // clStock
            // 
            this.clStock.DataPropertyName = "Stock";
            this.clStock.FillWeight = 60F;
            this.clStock.HeaderText = "库存";
            this.clStock.Name = "clStock";
            this.clStock.ReadOnly = true;
            // 
            // txtStock
            // 
            this.txtStock.Decimal = 0;
            this.txtStock.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.txtStock.Location = new System.Drawing.Point(825, 422);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStock.MinimumSize = new System.Drawing.Size(100, 0);
            this.txtStock.Name = "txtStock";
            this.txtStock.Radius = 20;
            this.txtStock.Size = new System.Drawing.Size(165, 35);
            this.txtStock.Step = 1D;
            this.txtStock.TabIndex = 158;
            this.txtStock.Text = null;
            this.txtStock.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtStock.Value = 0D;
            this.txtStock.ValueChanged += new Sunny.UI.UIDoubleUpDown.OnValueChanged(this.txtStock_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(863, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 157;
            this.label4.Text = "商品库存";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(863, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 156;
            this.label3.Text = "商品规格";
            // 
            // txtformat
            // 
            this.txtformat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtformat.FillColor = System.Drawing.Color.White;
            this.txtformat.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtformat.Location = new System.Drawing.Point(825, 344);
            this.txtformat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtformat.Maximum = 2147483647D;
            this.txtformat.Minimum = -2147483648D;
            this.txtformat.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtformat.Name = "txtformat";
            this.txtformat.Padding = new System.Windows.Forms.Padding(5);
            this.txtformat.Radius = 20;
            this.txtformat.Size = new System.Drawing.Size(165, 35);
            this.txtformat.Style = Sunny.UI.UIStyle.Custom;
            this.txtformat.StyleCustomMode = true;
            this.txtformat.TabIndex = 155;
            this.txtformat.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(863, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 154;
            this.label2.Text = "商品价格";
            // 
            // txtSellPrice
            // 
            this.txtSellPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSellPrice.FillColor = System.Drawing.Color.White;
            this.txtSellPrice.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSellPrice.Location = new System.Drawing.Point(825, 266);
            this.txtSellPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSellPrice.Maximum = 2147483647D;
            this.txtSellPrice.MaxLength = 10;
            this.txtSellPrice.Minimum = -2147483648D;
            this.txtSellPrice.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSellPrice.Name = "txtSellPrice";
            this.txtSellPrice.Padding = new System.Windows.Forms.Padding(5);
            this.txtSellPrice.Radius = 20;
            this.txtSellPrice.Size = new System.Drawing.Size(165, 35);
            this.txtSellPrice.Style = Sunny.UI.UIStyle.Custom;
            this.txtSellPrice.StyleCustomMode = true;
            this.txtSellPrice.TabIndex = 153;
            this.txtSellPrice.Text = "0.00";
            this.txtSellPrice.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSellPrice.Type = Sunny.UI.UITextBox.UIEditType.Double;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(863, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 152;
            this.label1.Text = "商品名称";
            // 
            // txtSellName
            // 
            this.txtSellName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSellName.FillColor = System.Drawing.Color.White;
            this.txtSellName.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSellName.Location = new System.Drawing.Point(825, 188);
            this.txtSellName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSellName.Maximum = 2147483647D;
            this.txtSellName.Minimum = -2147483648D;
            this.txtSellName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSellName.Name = "txtSellName";
            this.txtSellName.Padding = new System.Windows.Forms.Padding(5);
            this.txtSellName.Radius = 20;
            this.txtSellName.Size = new System.Drawing.Size(165, 35);
            this.txtSellName.Style = Sunny.UI.UIStyle.Custom;
            this.txtSellName.StyleCustomMode = true;
            this.txtSellName.TabIndex = 151;
            this.txtSellName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(863, 82);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(88, 25);
            this.label20.TabIndex = 150;
            this.label20.Text = "商品编号";
            // 
            // txtSellNo
            // 
            this.txtSellNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSellNo.FillColor = System.Drawing.Color.White;
            this.txtSellNo.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSellNo.Location = new System.Drawing.Point(825, 110);
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
            this.txtSellNo.TabIndex = 149;
            this.txtSellNo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmSellThingManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1005, 623);
            this.ControlBox = false;
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtformat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSellPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSellName);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtSellNo);
            this.Controls.Add(this.dgvSellthing);
            this.Controls.Add(this.btnDeleteSellThing);
            this.Controls.Add(this.btnUpdateSellthing);
            this.Controls.Add(this.btnAddSellThing);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.btnFind);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSellThingManager";
            this.ShowIcon = true;
            this.ShowTitleIcon = true;
            this.Text = "商品管理";
            this.Load += new System.EventHandler(this.FrmSellThingManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellthing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox txtFind;
        private Sunny.UI.UIButton btnFind;
        private Sunny.UI.UIButton btnAddSellThing;
        private Sunny.UI.UIButton btnUpdateSellthing;
        private Sunny.UI.UIButton btnDeleteSellThing;
        private Sunny.UI.UIDataGridView dgvSellthing;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn clSellNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSellName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFormat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStock;
    }
}