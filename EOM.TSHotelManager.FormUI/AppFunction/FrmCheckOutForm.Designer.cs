namespace EOM.TSHotelManager.FormUI
{
    partial class FrmCheckOutForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCheckOutForm));
            btnBalance = new Sunny.UI.UIButton();
            lblVIPPrice = new Label();
            label15 = new Label();
            dgvSpendList = new Sunny.UI.UIDataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            clPrice = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            clSpendNo = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            lblDay = new Label();
            lable00 = new Label();
            label29 = new Label();
            lblVIP = new Label();
            dtpCheckTime = new Sunny.UI.UITextBox();
            label25 = new Label();
            txtRoomNo = new Sunny.UI.UITextBox();
            label27 = new Label();
            label28 = new Label();
            lblChange = new Label();
            CustoNo = new Sunny.UI.UITextBox();
            label21 = new Label();
            CustoName = new Sunny.UI.UITextBox();
            lblGetReceipts = new Label();
            label1 = new Label();
            label24 = new Label();
            label17 = new Label();
            label18 = new Label();
            cboCustoType = new Sunny.UI.UIComboBox();
            cboPassportType = new Sunny.UI.UIComboBox();
            cboCustoSex = new Sunny.UI.UIComboBox();
            txtCustoNo = new Sunny.UI.UITextBox();
            txtCustoName = new Sunny.UI.UITextBox();
            txtPassportNum = new Sunny.UI.UITextBox();
            txtTel = new Sunny.UI.UITextBox();
            dtpBirth = new Sunny.UI.UIDatePicker();
            txtAddress = new Sunny.UI.UITextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label16 = new Label();
            label22 = new Label();
            label30 = new Label();
            label31 = new Label();
            label32 = new Label();
            dgvWti = new Sunny.UI.UIDataGridView();
            uiTabControlMenu2 = new Sunny.UI.UITabControlMenu();
            tabPage1 = new TabPage();
            txtReceipts = new Sunny.UI.UITextBox();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            Column11 = new DataGridViewTextBoxColumn();
            token = new DataGridViewTextBoxColumn();
            clRoomNo = new DataGridViewTextBoxColumn();
            clCustoNo = new DataGridViewTextBoxColumn();
            clStartTime = new DataGridViewTextBoxColumn();
            clDealTime = new DataGridViewTextBoxColumn();
            clWater = new DataGridViewTextBoxColumn();
            clElectric = new DataGridViewTextBoxColumn();
            clMarkUser = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvSpendList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvWti).BeginInit();
            uiTabControlMenu2.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // btnBalance
            // 
            btnBalance.Cursor = Cursors.Hand;
            btnBalance.Font = new Font("微软雅黑", 12F);
            btnBalance.Location = new Point(459, 486);
            btnBalance.MinimumSize = new Size(1, 1);
            btnBalance.Name = "btnBalance";
            btnBalance.Radius = 30;
            btnBalance.Size = new Size(162, 46);
            btnBalance.Style = Sunny.UI.UIStyle.Custom;
            btnBalance.TabIndex = 116;
            btnBalance.Text = "结         算";
            btnBalance.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnBalance.Click += btnBalance_Click;
            // 
            // lblVIPPrice
            // 
            lblVIPPrice.AutoSize = true;
            lblVIPPrice.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVIPPrice.Location = new Point(549, 389);
            lblVIPPrice.Name = "lblVIPPrice";
            lblVIPPrice.Size = new Size(40, 20);
            lblVIPPrice.TabIndex = 28;
            lblVIPPrice.Text = "0.00";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label15.ForeColor = Color.Red;
            label15.Location = new Point(7, 525);
            label15.Name = "label15";
            label15.Size = new Size(253, 17);
            label15.TabIndex = 11;
            label15.Text = "Tips：请提醒客人不要忘记带齐行李哦~";
            // 
            // dgvSpendList
            // 
            dgvSpendList.AllowUserToAddRows = false;
            dgvSpendList.AllowUserToDeleteRows = false;
            dgvSpendList.AllowUserToResizeColumns = false;
            dgvSpendList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            dgvSpendList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvSpendList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSpendList.BackgroundColor = Color.White;
            dgvSpendList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvSpendList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvSpendList.ColumnHeadersHeight = 32;
            dgvSpendList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvSpendList.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, clPrice, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, clSpendNo, Column1, Column2, Column3, Column4, Column8 });
            dgvSpendList.EnableHeadersVisualStyles = false;
            dgvSpendList.Font = new Font("微软雅黑", 12F);
            dgvSpendList.GridColor = Color.FromArgb(80, 160, 255);
            dgvSpendList.Location = new Point(10, 113);
            dgvSpendList.Name = "dgvSpendList";
            dgvSpendList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle3.Font = new Font("微软雅黑", 12F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvSpendList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvSpendList.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.White;
            dgvSpendList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvSpendList.RowTemplate.Height = 29;
            dgvSpendList.SelectedIndex = -1;
            dgvSpendList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSpendList.ShowRowErrors = false;
            dgvSpendList.Size = new Size(648, 202);
            dgvSpendList.StripeOddColor = Color.FromArgb(235, 243, 255);
            dgvSpendList.Style = Sunny.UI.UIStyle.Custom;
            dgvSpendList.TabIndex = 115;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "RoomNo";
            dataGridViewTextBoxColumn1.FillWeight = 102.6831F;
            dataGridViewTextBoxColumn1.HeaderText = "房号";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // clPrice
            // 
            clPrice.DataPropertyName = "SpendPriceStr";
            clPrice.HeaderText = "单价(元)";
            clPrice.Name = "clPrice";
            clPrice.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "CustoNo";
            dataGridViewTextBoxColumn2.FillWeight = 102.6831F;
            dataGridViewTextBoxColumn2.HeaderText = "客户编号";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "SpendName";
            dataGridViewTextBoxColumn3.FillWeight = 102.6831F;
            dataGridViewTextBoxColumn3.HeaderText = "商品";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "SpendAmount";
            dataGridViewTextBoxColumn4.FillWeight = 60F;
            dataGridViewTextBoxColumn4.HeaderText = "数量";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "SpendPrice";
            dataGridViewTextBoxColumn5.FillWeight = 102.6831F;
            dataGridViewTextBoxColumn5.HeaderText = "单价(元)";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "SpendMoneyStr";
            dataGridViewTextBoxColumn6.FillWeight = 102.6831F;
            dataGridViewTextBoxColumn6.HeaderText = "总额";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "SpendTime";
            dataGridViewTextBoxColumn7.FillWeight = 102.6831F;
            dataGridViewTextBoxColumn7.HeaderText = "消费时间";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // clSpendNo
            // 
            clSpendNo.DataPropertyName = "delete_mk";
            clSpendNo.HeaderText = "Column1";
            clSpendNo.Name = "clSpendNo";
            clSpendNo.ReadOnly = true;
            clSpendNo.Visible = false;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "datains_usr";
            Column1.HeaderText = "Column1";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Visible = false;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "datains_date";
            Column2.HeaderText = "Column2";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Visible = false;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "datachg_usr";
            Column3.HeaderText = "Column3";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Visible = false;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "datachg_date";
            Column4.HeaderText = "Column4";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Visible = false;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "MoneyState";
            Column8.HeaderText = "Column8";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Visible = false;
            // 
            // lblDay
            // 
            lblDay.AutoSize = true;
            lblDay.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDay.Location = new Point(572, 76);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(45, 25);
            lblDay.TabIndex = 114;
            lblDay.Text = "Null";
            // 
            // lable00
            // 
            lable00.AutoSize = true;
            lable00.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lable00.Location = new Point(456, 388);
            lable00.Name = "lable00";
            lable00.Size = new Size(89, 20);
            lable00.TabIndex = 26;
            lable00.Text = "折后金额：";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label29.Location = new Point(551, 24);
            label29.Name = "label29";
            label29.Size = new Size(88, 25);
            label29.TabIndex = 113;
            label29.Text = "已住天数";
            // 
            // lblVIP
            // 
            lblVIP.AutoSize = true;
            lblVIP.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVIP.Location = new Point(549, 361);
            lblVIP.Name = "lblVIP";
            lblVIP.Size = new Size(73, 20);
            lblVIP.TabIndex = 24;
            lblVIP.Text = "不  打  折";
            // 
            // dtpCheckTime
            // 
            dtpCheckTime.Cursor = Cursors.IBeam;
            dtpCheckTime.Font = new Font("微软雅黑", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dtpCheckTime.Location = new Point(376, 18);
            dtpCheckTime.Margin = new Padding(4, 5, 4, 5);
            dtpCheckTime.MinimumSize = new Size(1, 1);
            dtpCheckTime.Name = "dtpCheckTime";
            dtpCheckTime.Padding = new Padding(5);
            dtpCheckTime.Radius = 20;
            dtpCheckTime.ReadOnly = true;
            dtpCheckTime.ShowText = false;
            dtpCheckTime.Size = new Size(168, 35);
            dtpCheckTime.Style = Sunny.UI.UIStyle.Custom;
            dtpCheckTime.StyleCustomMode = true;
            dtpCheckTime.Symbol = 559683;
            dtpCheckTime.TabIndex = 111;
            dtpCheckTime.TextAlignment = ContentAlignment.MiddleLeft;
            dtpCheckTime.Watermark = "";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label25.Location = new Point(456, 359);
            label25.Name = "label25";
            label25.Size = new Size(89, 20);
            label25.TabIndex = 23;
            label25.Text = "会员折扣：";
            // 
            // txtRoomNo
            // 
            txtRoomNo.Cursor = Cursors.IBeam;
            txtRoomNo.Font = new Font("微软雅黑", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtRoomNo.Location = new Point(376, 70);
            txtRoomNo.Margin = new Padding(4, 5, 4, 5);
            txtRoomNo.MinimumSize = new Size(1, 1);
            txtRoomNo.Name = "txtRoomNo";
            txtRoomNo.Padding = new Padding(5);
            txtRoomNo.Radius = 20;
            txtRoomNo.ReadOnly = true;
            txtRoomNo.ShowText = false;
            txtRoomNo.Size = new Size(168, 35);
            txtRoomNo.Style = Sunny.UI.UIStyle.Custom;
            txtRoomNo.StyleCustomMode = true;
            txtRoomNo.TabIndex = 112;
            txtRoomNo.TextAlignment = ContentAlignment.MiddleLeft;
            txtRoomNo.Watermark = "";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label27.Location = new Point(285, 76);
            label27.Name = "label27";
            label27.Size = new Size(88, 25);
            label27.TabIndex = 110;
            label27.Text = "房间编号";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label28.Location = new Point(285, 24);
            label28.Name = "label28";
            label28.Size = new Size(88, 25);
            label28.TabIndex = 109;
            label28.Text = "入住时间";
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChange.Location = new Point(548, 445);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(40, 20);
            lblChange.TabIndex = 21;
            lblChange.Text = "0.00";
            // 
            // CustoNo
            // 
            CustoNo.Cursor = Cursors.IBeam;
            CustoNo.Font = new Font("微软雅黑", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 134);
            CustoNo.Location = new Point(117, 18);
            CustoNo.Margin = new Padding(4, 5, 4, 5);
            CustoNo.MinimumSize = new Size(1, 1);
            CustoNo.Name = "CustoNo";
            CustoNo.Padding = new Padding(5);
            CustoNo.Radius = 20;
            CustoNo.ReadOnly = true;
            CustoNo.ShowText = false;
            CustoNo.Size = new Size(144, 35);
            CustoNo.Style = Sunny.UI.UIStyle.Custom;
            CustoNo.StyleCustomMode = true;
            CustoNo.TabIndex = 107;
            CustoNo.TextAlignment = ContentAlignment.MiddleLeft;
            CustoNo.Watermark = "";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.Location = new Point(455, 446);
            label21.Name = "label21";
            label21.Size = new Size(89, 20);
            label21.TabIndex = 20;
            label21.Text = "找        零：";
            // 
            // CustoName
            // 
            CustoName.Cursor = Cursors.IBeam;
            CustoName.Font = new Font("微软雅黑", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 134);
            CustoName.Location = new Point(117, 70);
            CustoName.Margin = new Padding(4, 5, 4, 5);
            CustoName.MinimumSize = new Size(1, 1);
            CustoName.Name = "CustoName";
            CustoName.Padding = new Padding(5);
            CustoName.Radius = 20;
            CustoName.ReadOnly = true;
            CustoName.ShowText = false;
            CustoName.Size = new Size(144, 35);
            CustoName.Style = Sunny.UI.UIStyle.Custom;
            CustoName.StyleCustomMode = true;
            CustoName.TabIndex = 108;
            CustoName.TextAlignment = ContentAlignment.MiddleLeft;
            CustoName.Watermark = "";
            // 
            // lblGetReceipts
            // 
            lblGetReceipts.AutoSize = true;
            lblGetReceipts.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGetReceipts.Location = new Point(548, 417);
            lblGetReceipts.Name = "lblGetReceipts";
            lblGetReceipts.Size = new Size(40, 20);
            lblGetReceipts.TabIndex = 19;
            lblGetReceipts.Text = "0.00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(26, 76);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 106;
            label1.Text = "客户姓名";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label24.Location = new Point(26, 24);
            label24.Name = "label24";
            label24.Size = new Size(88, 25);
            label24.TabIndex = 105;
            label24.Text = "客户编号";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(455, 330);
            label17.Name = "label17";
            label17.Size = new Size(89, 20);
            label17.TabIndex = 14;
            label17.Text = "实收金额：";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(455, 417);
            label18.Name = "label18";
            label18.Size = new Size(89, 20);
            label18.TabIndex = 15;
            label18.Text = "应收金额：";
            // 
            // cboCustoType
            // 
            cboCustoType.DataSource = null;
            cboCustoType.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cboCustoType.FillColor = Color.White;
            cboCustoType.Font = new Font("微软雅黑", 15.75F);
            cboCustoType.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cboCustoType.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cboCustoType.Location = new Point(437, 19);
            cboCustoType.Margin = new Padding(4, 5, 4, 5);
            cboCustoType.MinimumSize = new Size(63, 0);
            cboCustoType.Name = "cboCustoType";
            cboCustoType.Padding = new Padding(0, 0, 30, 2);
            cboCustoType.Radius = 20;
            cboCustoType.ReadOnly = true;
            cboCustoType.Size = new Size(203, 35);
            cboCustoType.Style = Sunny.UI.UIStyle.Custom;
            cboCustoType.SymbolSize = 24;
            cboCustoType.TabIndex = 125;
            cboCustoType.TextAlignment = ContentAlignment.MiddleLeft;
            cboCustoType.Watermark = "";
            // 
            // cboPassportType
            // 
            cboPassportType.DataSource = null;
            cboPassportType.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cboPassportType.FillColor = Color.White;
            cboPassportType.Font = new Font("微软雅黑", 15.75F);
            cboPassportType.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cboPassportType.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cboPassportType.Location = new Point(437, 70);
            cboPassportType.Margin = new Padding(4, 5, 4, 5);
            cboPassportType.MinimumSize = new Size(63, 0);
            cboPassportType.Name = "cboPassportType";
            cboPassportType.Padding = new Padding(0, 0, 30, 2);
            cboPassportType.Radius = 20;
            cboPassportType.ReadOnly = true;
            cboPassportType.Size = new Size(203, 35);
            cboPassportType.Style = Sunny.UI.UIStyle.Custom;
            cboPassportType.SymbolSize = 24;
            cboPassportType.TabIndex = 124;
            cboPassportType.TextAlignment = ContentAlignment.MiddleLeft;
            cboPassportType.Watermark = "";
            // 
            // cboCustoSex
            // 
            cboCustoSex.DataSource = null;
            cboCustoSex.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cboCustoSex.FillColor = Color.White;
            cboCustoSex.Font = new Font("微软雅黑", 15.75F);
            cboCustoSex.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cboCustoSex.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cboCustoSex.Location = new Point(134, 124);
            cboCustoSex.Margin = new Padding(4, 5, 4, 5);
            cboCustoSex.MinimumSize = new Size(63, 0);
            cboCustoSex.Name = "cboCustoSex";
            cboCustoSex.Padding = new Padding(0, 0, 30, 2);
            cboCustoSex.Radius = 20;
            cboCustoSex.ReadOnly = true;
            cboCustoSex.Size = new Size(203, 35);
            cboCustoSex.Style = Sunny.UI.UIStyle.Custom;
            cboCustoSex.SymbolSize = 24;
            cboCustoSex.TabIndex = 123;
            cboCustoSex.TextAlignment = ContentAlignment.MiddleLeft;
            cboCustoSex.Watermark = "";
            // 
            // txtCustoNo
            // 
            txtCustoNo.Cursor = Cursors.IBeam;
            txtCustoNo.Font = new Font("微软雅黑", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtCustoNo.Location = new Point(134, 20);
            txtCustoNo.Margin = new Padding(4, 5, 4, 5);
            txtCustoNo.MinimumSize = new Size(1, 1);
            txtCustoNo.Name = "txtCustoNo";
            txtCustoNo.Padding = new Padding(5);
            txtCustoNo.Radius = 20;
            txtCustoNo.ReadOnly = true;
            txtCustoNo.ShowText = false;
            txtCustoNo.Size = new Size(203, 35);
            txtCustoNo.Style = Sunny.UI.UIStyle.Custom;
            txtCustoNo.StyleCustomMode = true;
            txtCustoNo.TabIndex = 122;
            txtCustoNo.TextAlignment = ContentAlignment.MiddleLeft;
            txtCustoNo.Watermark = "";
            // 
            // txtCustoName
            // 
            txtCustoName.Cursor = Cursors.IBeam;
            txtCustoName.Font = new Font("微软雅黑", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtCustoName.Location = new Point(134, 72);
            txtCustoName.Margin = new Padding(4, 5, 4, 5);
            txtCustoName.MinimumSize = new Size(1, 1);
            txtCustoName.Name = "txtCustoName";
            txtCustoName.Padding = new Padding(5);
            txtCustoName.Radius = 20;
            txtCustoName.ReadOnly = true;
            txtCustoName.ShowText = false;
            txtCustoName.Size = new Size(203, 35);
            txtCustoName.Style = Sunny.UI.UIStyle.Custom;
            txtCustoName.StyleCustomMode = true;
            txtCustoName.TabIndex = 121;
            txtCustoName.TextAlignment = ContentAlignment.MiddleLeft;
            txtCustoName.Watermark = "";
            // 
            // txtPassportNum
            // 
            txtPassportNum.Cursor = Cursors.IBeam;
            txtPassportNum.Font = new Font("微软雅黑", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtPassportNum.Location = new Point(437, 121);
            txtPassportNum.Margin = new Padding(4, 5, 4, 5);
            txtPassportNum.MinimumSize = new Size(1, 1);
            txtPassportNum.Name = "txtPassportNum";
            txtPassportNum.Padding = new Padding(5);
            txtPassportNum.Radius = 20;
            txtPassportNum.ReadOnly = true;
            txtPassportNum.ShowText = false;
            txtPassportNum.Size = new Size(203, 35);
            txtPassportNum.Style = Sunny.UI.UIStyle.Custom;
            txtPassportNum.StyleCustomMode = true;
            txtPassportNum.TabIndex = 120;
            txtPassportNum.TextAlignment = ContentAlignment.MiddleLeft;
            txtPassportNum.Watermark = "";
            // 
            // txtTel
            // 
            txtTel.Cursor = Cursors.IBeam;
            txtTel.Font = new Font("微软雅黑", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtTel.Location = new Point(437, 172);
            txtTel.Margin = new Padding(4, 5, 4, 5);
            txtTel.MinimumSize = new Size(1, 1);
            txtTel.Name = "txtTel";
            txtTel.Padding = new Padding(5);
            txtTel.Radius = 20;
            txtTel.ReadOnly = true;
            txtTel.ShowText = false;
            txtTel.Size = new Size(203, 35);
            txtTel.Style = Sunny.UI.UIStyle.Custom;
            txtTel.StyleCustomMode = true;
            txtTel.TabIndex = 119;
            txtTel.TextAlignment = ContentAlignment.MiddleLeft;
            txtTel.Watermark = "";
            // 
            // dtpBirth
            // 
            dtpBirth.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            dtpBirth.FillColor = Color.White;
            dtpBirth.Font = new Font("Microsoft Sans Serif", 15.75F);
            dtpBirth.Location = new Point(134, 176);
            dtpBirth.Margin = new Padding(4, 5, 4, 5);
            dtpBirth.MaxLength = 10;
            dtpBirth.MinimumSize = new Size(63, 0);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Padding = new Padding(0, 0, 30, 2);
            dtpBirth.Radius = 20;
            dtpBirth.ReadOnly = true;
            dtpBirth.Size = new Size(203, 31);
            dtpBirth.Style = Sunny.UI.UIStyle.Custom;
            dtpBirth.SymbolDropDown = 61555;
            dtpBirth.SymbolNormal = 61555;
            dtpBirth.SymbolSize = 24;
            dtpBirth.TabIndex = 118;
            dtpBirth.Text = "2020-11-24";
            dtpBirth.TextAlignment = ContentAlignment.MiddleLeft;
            dtpBirth.Value = new DateTime(2020, 11, 24, 22, 50, 36, 791);
            dtpBirth.Watermark = "";
            // 
            // txtAddress
            // 
            txtAddress.Cursor = Cursors.IBeam;
            txtAddress.Font = new Font("微软雅黑", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtAddress.Location = new Point(132, 224);
            txtAddress.Margin = new Padding(4, 5, 4, 5);
            txtAddress.MinimumSize = new Size(1, 1);
            txtAddress.Name = "txtAddress";
            txtAddress.Padding = new Padding(5);
            txtAddress.Radius = 20;
            txtAddress.ReadOnly = true;
            txtAddress.ShowText = false;
            txtAddress.Size = new Size(508, 35);
            txtAddress.Style = Sunny.UI.UIStyle.Custom;
            txtAddress.StyleCustomMode = true;
            txtAddress.TabIndex = 117;
            txtAddress.TextAlignment = ContentAlignment.MiddleLeft;
            txtAddress.Watermark = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.Location = new Point(25, 234);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 115;
            label2.Text = "居住地址";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label3.Location = new Point(344, 179);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 114;
            label3.Text = "联系方式";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label4.Location = new Point(344, 128);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 113;
            label4.Text = "证件号码";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label5.Location = new Point(344, 77);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 112;
            label5.Text = "证件类型";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label16.Location = new Point(344, 26);
            label16.Name = "label16";
            label16.Size = new Size(88, 25);
            label16.TabIndex = 111;
            label16.Text = "客户类型";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label22.Location = new Point(27, 182);
            label22.Name = "label22";
            label22.Size = new Size(88, 25);
            label22.TabIndex = 110;
            label22.Text = "出生日期";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label30.Location = new Point(27, 130);
            label30.Name = "label30";
            label30.Size = new Size(86, 25);
            label30.TabIndex = 109;
            label30.Text = "性      别";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label31.Location = new Point(27, 78);
            label31.Name = "label31";
            label31.Size = new Size(88, 25);
            label31.TabIndex = 108;
            label31.Text = "客户姓名";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label32.Location = new Point(27, 26);
            label32.Name = "label32";
            label32.Size = new Size(88, 25);
            label32.TabIndex = 107;
            label32.Text = "客户编号";
            // 
            // dgvWti
            // 
            dgvWti.AllowUserToAddRows = false;
            dgvWti.AllowUserToDeleteRows = false;
            dgvWti.AllowUserToResizeColumns = false;
            dgvWti.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(235, 243, 255);
            dgvWti.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvWti.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvWti.BackgroundColor = Color.White;
            dgvWti.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle6.Font = new Font("微软雅黑", 12F);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvWti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvWti.ColumnHeadersHeight = 32;
            dgvWti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvWti.Columns.AddRange(new DataGridViewColumn[] { Column11, token, clRoomNo, clCustoNo, clStartTime, clDealTime, clWater, clElectric, clMarkUser, Column5, Column6, Column7, Column9, Column10 });
            dgvWti.EnableHeadersVisualStyles = false;
            dgvWti.Font = new Font("微软雅黑", 12F);
            dgvWti.GridColor = Color.FromArgb(80, 160, 255);
            dgvWti.Location = new Point(3, 3);
            dgvWti.Name = "dgvWti";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle7.Font = new Font("微软雅黑", 12F);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvWti.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvWti.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = Color.White;
            dgvWti.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvWti.RowTemplate.Height = 29;
            dgvWti.SelectedIndex = -1;
            dgvWti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvWti.Size = new Size(656, 291);
            dgvWti.StripeOddColor = Color.FromArgb(235, 243, 255);
            dgvWti.Style = Sunny.UI.UIStyle.Custom;
            dgvWti.TabIndex = 0;
            // 
            // uiTabControlMenu2
            // 
            uiTabControlMenu2.Alignment = TabAlignment.Left;
            uiTabControlMenu2.Controls.Add(tabPage1);
            uiTabControlMenu2.Controls.Add(tabPage2);
            uiTabControlMenu2.Controls.Add(tabPage3);
            uiTabControlMenu2.DrawMode = TabDrawMode.OwnerDrawFixed;
            uiTabControlMenu2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiTabControlMenu2.Location = new Point(3, 38);
            uiTabControlMenu2.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            uiTabControlMenu2.Multiline = true;
            uiTabControlMenu2.Name = "uiTabControlMenu2";
            uiTabControlMenu2.SelectedIndex = 0;
            uiTabControlMenu2.Size = new Size(865, 550);
            uiTabControlMenu2.SizeMode = TabSizeMode.Fixed;
            uiTabControlMenu2.TabBackColor = Color.FromArgb(235, 243, 255);
            uiTabControlMenu2.TabIndex = 15;
            uiTabControlMenu2.TabSelectedColor = Color.Snow;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtReceipts);
            tabPage1.Controls.Add(btnBalance);
            tabPage1.Controls.Add(label24);
            tabPage1.Controls.Add(lblVIPPrice);
            tabPage1.Controls.Add(label18);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(dgvSpendList);
            tabPage1.Controls.Add(label17);
            tabPage1.Controls.Add(lblDay);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(lable00);
            tabPage1.Controls.Add(lblGetReceipts);
            tabPage1.Controls.Add(label29);
            tabPage1.Controls.Add(CustoName);
            tabPage1.Controls.Add(lblVIP);
            tabPage1.Controls.Add(label21);
            tabPage1.Controls.Add(dtpCheckTime);
            tabPage1.Controls.Add(CustoNo);
            tabPage1.Controls.Add(label25);
            tabPage1.Controls.Add(lblChange);
            tabPage1.Controls.Add(txtRoomNo);
            tabPage1.Controls.Add(label28);
            tabPage1.Controls.Add(label27);
            tabPage1.Location = new Point(201, 0);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(664, 550);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "退房结算";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtReceipts
            // 
            txtReceipts.Cursor = Cursors.IBeam;
            txtReceipts.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtReceipts.Location = new Point(548, 329);
            txtReceipts.Margin = new Padding(4, 5, 4, 5);
            txtReceipts.MinimumSize = new Size(1, 16);
            txtReceipts.Name = "txtReceipts";
            txtReceipts.Padding = new Padding(5);
            txtReceipts.ShowText = false;
            txtReceipts.Size = new Size(74, 26);
            txtReceipts.TabIndex = 117;
            txtReceipts.TextAlignment = ContentAlignment.MiddleCenter;
            txtReceipts.Watermark = "";
            txtReceipts.TextChanged += txtReceipts_TextChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(cboCustoType);
            tabPage2.Controls.Add(label32);
            tabPage2.Controls.Add(cboPassportType);
            tabPage2.Controls.Add(label31);
            tabPage2.Controls.Add(cboCustoSex);
            tabPage2.Controls.Add(label30);
            tabPage2.Controls.Add(txtCustoNo);
            tabPage2.Controls.Add(label22);
            tabPage2.Controls.Add(txtCustoName);
            tabPage2.Controls.Add(label16);
            tabPage2.Controls.Add(txtPassportNum);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(txtTel);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(dtpBirth);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(txtAddress);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(201, 0);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(664, 550);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "客户信息";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgvWti);
            tabPage3.Location = new Point(201, 0);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(664, 550);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "历史水电情况";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // Column11
            // 
            Column11.DataPropertyName = "WtiNo";
            Column11.HeaderText = "Column11";
            Column11.Name = "Column11";
            Column11.Visible = false;
            // 
            // token
            // 
            token.DataPropertyName = "user_token";
            token.HeaderText = "token";
            token.Name = "token";
            token.Visible = false;
            // 
            // clRoomNo
            // 
            clRoomNo.DataPropertyName = "RoomNo";
            clRoomNo.HeaderText = "房间号";
            clRoomNo.Name = "clRoomNo";
            // 
            // clCustoNo
            // 
            clCustoNo.DataPropertyName = "CustoNo";
            clCustoNo.HeaderText = "客户编号";
            clCustoNo.Name = "clCustoNo";
            // 
            // clStartTime
            // 
            clStartTime.DataPropertyName = "UseDate";
            clStartTime.HeaderText = "开始时间";
            clStartTime.Name = "clStartTime";
            // 
            // clDealTime
            // 
            clDealTime.DataPropertyName = "EndDate";
            clDealTime.HeaderText = "结束时间";
            clDealTime.Name = "clDealTime";
            // 
            // clWater
            // 
            clWater.DataPropertyName = "WaterUse";
            clWater.HeaderText = "水费";
            clWater.Name = "clWater";
            // 
            // clElectric
            // 
            clElectric.DataPropertyName = "PowerUse";
            clElectric.HeaderText = "电费";
            clElectric.Name = "clElectric";
            // 
            // clMarkUser
            // 
            clMarkUser.DataPropertyName = "Record";
            clMarkUser.HeaderText = "记录员";
            clMarkUser.Name = "clMarkUser";
            // 
            // Column5
            // 
            Column5.DataPropertyName = "delete_mk";
            Column5.HeaderText = "Column5";
            Column5.Name = "Column5";
            Column5.Visible = false;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "datains_usr";
            Column6.HeaderText = "Column6";
            Column6.Name = "Column6";
            Column6.Visible = false;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "datains_date";
            Column7.HeaderText = "Column7";
            Column7.Name = "Column7";
            Column7.Visible = false;
            // 
            // Column9
            // 
            Column9.DataPropertyName = "datachg_usr";
            Column9.HeaderText = "Column9";
            Column9.Name = "Column9";
            Column9.Visible = false;
            // 
            // Column10
            // 
            Column10.DataPropertyName = "datachg_date";
            Column10.HeaderText = "Column10";
            Column10.Name = "Column10";
            Column10.Visible = false;
            // 
            // FrmCheckOutForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(235, 243, 255);
            ClientSize = new Size(873, 593);
            Controls.Add(uiTabControlMenu2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCheckOutForm";
            ShowTitleIcon = true;
            Text = "退房结算";
            ZoomScaleRect = new Rectangle(15, 15, 888, 603);
            Load += FrmCheckOutForm_Load;
            MouseDown += FrmCheckOutForm_MouseDown;
            MouseMove += FrmCheckOutForm_MouseMove;
            ((System.ComponentModel.ISupportInitialize)dgvSpendList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvWti).EndInit();
            uiTabControlMenu2.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UIButton btnBalance;
        private System.Windows.Forms.Label lblVIPPrice;
        private System.Windows.Forms.Label label15;
        private Sunny.UI.UIDataGridView dgvSpendList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSpendNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lable00;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lblVIP;
        private Sunny.UI.UITextBox dtpCheckTime;
        private System.Windows.Forms.Label label25;
        private Sunny.UI.UITextBox txtRoomNo;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label lblChange;
        private Sunny.UI.UITextBox CustoNo;
        private System.Windows.Forms.Label label21;
        private Sunny.UI.UITextBox CustoName;
        private System.Windows.Forms.Label lblGetReceipts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private Sunny.UI.UIComboBox cboCustoType;
        private Sunny.UI.UIComboBox cboPassportType;
        private Sunny.UI.UIComboBox cboCustoSex;
        private Sunny.UI.UITextBox txtCustoNo;
        private Sunny.UI.UITextBox txtCustoName;
        private Sunny.UI.UITextBox txtPassportNum;
        private Sunny.UI.UITextBox txtTel;
        private Sunny.UI.UIDatePicker dtpBirth;
        private Sunny.UI.UITextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private Sunny.UI.UIDataGridView dgvWti;
        private Sunny.UI.UITabControlMenu uiTabControlMenu2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private Sunny.UI.UITextBox txtReceipts;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn token;
        private DataGridViewTextBoxColumn clRoomNo;
        private DataGridViewTextBoxColumn clCustoNo;
        private DataGridViewTextBoxColumn clStartTime;
        private DataGridViewTextBoxColumn clDealTime;
        private DataGridViewTextBoxColumn clWater;
        private DataGridViewTextBoxColumn clElectric;
        private DataGridViewTextBoxColumn clMarkUser;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
    }
}