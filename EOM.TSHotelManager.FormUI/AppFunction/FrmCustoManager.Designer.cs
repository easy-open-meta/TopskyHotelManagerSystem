namespace EOM.TSHotelManager.FormUI
{
    partial class FrmCustoManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustoManager));
            cmsCustoManager = new Sunny.UI.UIContextMenuStrip();
            tsmiCustoNo = new ToolStripMenuItem();
            dgvCustomerList = new AntdUI.Table();
            btnPg = new AntdUI.Pagination();
            windowBar1 = new AntdUI.WindowBar();
            txtCustoNo = new AntdUI.Input();
            txtCustoName = new AntdUI.Input();
            label2 = new AntdUI.Label();
            label1 = new AntdUI.Label();
            btnSerach = new AntdUI.Button();
            btnAddCusto = new AntdUI.Button();
            btnExport = new AntdUI.Button();
            btnUpdate = new AntdUI.Button();
            cbOnlyVip = new AntdUI.Checkbox();
            cbExportAll = new AntdUI.Checkbox();
            divider1 = new AntdUI.Divider();
            cmsCustoManager.SuspendLayout();
            SuspendLayout();
            // 
            // cmsCustoManager
            // 
            cmsCustoManager.BackColor = Color.FromArgb(243, 249, 255);
            cmsCustoManager.Font = new Font("微软雅黑", 12F);
            cmsCustoManager.Items.AddRange(new ToolStripItem[] { tsmiCustoNo });
            cmsCustoManager.Name = "cmsCustoManager";
            cmsCustoManager.Size = new Size(177, 30);
            // 
            // tsmiCustoNo
            // 
            tsmiCustoNo.Image = Properties.Resources.复制;
            tsmiCustoNo.Name = "tsmiCustoNo";
            tsmiCustoNo.Size = new Size(176, 26);
            tsmiCustoNo.Text = "复制用户编号";
            tsmiCustoNo.Click += tsmiCustoNo_Click;
            // 
            // dgvCustomerList
            // 
            dgvCustomerList.Bordered = true;
            dgvCustomerList.ContextMenuStrip = cmsCustoManager;
            dgvCustomerList.Location = new Point(4, 49);
            dgvCustomerList.Name = "dgvCustomerList";
            dgvCustomerList.Size = new Size(998, 476);
            dgvCustomerList.TabIndex = 126;
            dgvCustomerList.CellClick += dgvCustomerList_CellClick;
            // 
            // btnPg
            // 
            btnPg.Current = 0;
            btnPg.Location = new Point(4, 531);
            btnPg.Name = "btnPg";
            btnPg.PageSize = 15;
            btnPg.ShowSizeChanger = true;
            btnPg.Size = new Size(405, 31);
            btnPg.TabIndex = 133;
            btnPg.Total = 100;
            btnPg.ValueChanged += btnPg_ValueChanged;
            btnPg.ShowTotalChanged += btnPg_ShowTotalChanged;
            // 
            // windowBar1
            // 
            windowBar1.Font = new Font("Microsoft YaHei UI", 12F);
            windowBar1.Icon = (Image)resources.GetObject("windowBar1.Icon");
            windowBar1.IsMax = false;
            windowBar1.Location = new Point(4, 3);
            windowBar1.MaximizeBox = false;
            windowBar1.MinimizeBox = false;
            windowBar1.Name = "windowBar1";
            windowBar1.Size = new Size(999, 40);
            windowBar1.TabIndex = 138;
            windowBar1.Text = "客户信息管理";
            // 
            // txtCustoNo
            // 
            txtCustoNo.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtCustoNo.Location = new Point(104, 573);
            txtCustoNo.Name = "txtCustoNo";
            txtCustoNo.PlaceholderText = "请输入客户编号...";
            txtCustoNo.Size = new Size(173, 42);
            txtCustoNo.TabIndex = 139;
            // 
            // txtCustoName
            // 
            txtCustoName.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtCustoName.Location = new Point(375, 573);
            txtCustoName.Name = "txtCustoName";
            txtCustoName.PlaceholderText = "请输入客户姓名...";
            txtCustoName.Size = new Size(173, 42);
            txtCustoName.TabIndex = 140;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft YaHei UI", 12.5F);
            label2.Location = new Point(12, 582);
            label2.Name = "label2";
            label2.Size = new Size(86, 26);
            label2.TabIndex = 141;
            label2.Text = "客户编号";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.TooltipConfig = null;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei UI", 12.5F);
            label1.Location = new Point(283, 582);
            label1.Name = "label1";
            label1.Size = new Size(86, 26);
            label1.TabIndex = 142;
            label1.Text = "客户姓名";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.TooltipConfig = null;
            // 
            // btnSerach
            // 
            btnSerach.Font = new Font("Microsoft YaHei UI", 12F);
            btnSerach.Location = new Point(567, 568);
            btnSerach.Name = "btnSerach";
            btnSerach.Size = new Size(93, 47);
            btnSerach.TabIndex = 143;
            btnSerach.Text = "搜     索";
            btnSerach.Type = AntdUI.TTypeMini.Primary;
            btnSerach.Click += btnSerach_Click;
            // 
            // btnAddCusto
            // 
            btnAddCusto.Font = new Font("Microsoft YaHei UI", 12F);
            btnAddCusto.Location = new Point(678, 568);
            btnAddCusto.Name = "btnAddCusto";
            btnAddCusto.Size = new Size(93, 47);
            btnAddCusto.TabIndex = 144;
            btnAddCusto.Text = "添加客户";
            btnAddCusto.Type = AntdUI.TTypeMini.Primary;
            btnAddCusto.Click += btnAddCusto_Click;
            // 
            // btnExport
            // 
            btnExport.Enabled = false;
            btnExport.Font = new Font("Microsoft YaHei UI", 12F);
            btnExport.Location = new Point(900, 568);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(93, 47);
            btnExport.TabIndex = 145;
            btnExport.Text = "导出列表";
            btnExport.Type = AntdUI.TTypeMini.Primary;
            btnExport.Click += btnExport_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Font = new Font("Microsoft YaHei UI", 12F);
            btnUpdate.Location = new Point(789, 568);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(93, 47);
            btnUpdate.TabIndex = 146;
            btnUpdate.Text = "修改客户";
            btnUpdate.Type = AntdUI.TTypeMini.Primary;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cbOnlyVip
            // 
            cbOnlyVip.AutoCheck = true;
            cbOnlyVip.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            cbOnlyVip.Location = new Point(422, 538);
            cbOnlyVip.Name = "cbOnlyVip";
            cbOnlyVip.Size = new Size(120, 23);
            cbOnlyVip.TabIndex = 147;
            cbOnlyVip.Text = "仅查看会员";
            cbOnlyVip.CheckedChanged += cbOnlyVip_CheckedChanged;
            // 
            // cbExportAll
            // 
            cbExportAll.AutoCheck = true;
            cbExportAll.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            cbExportAll.Location = new Point(559, 538);
            cbExportAll.Name = "cbExportAll";
            cbExportAll.Size = new Size(108, 23);
            cbExportAll.TabIndex = 148;
            cbExportAll.Text = "导出全部";
            // 
            // divider1
            // 
            divider1.ColorSplit = Color.Blue;
            divider1.Font = new Font("Microsoft YaHei UI", 12F);
            divider1.Location = new Point(678, 538);
            divider1.Name = "divider1";
            divider1.Size = new Size(325, 23);
            divider1.TabIndex = 149;
            divider1.Text = "右键列表复制客户编号";
            // 
            // FrmCustoManager
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(235, 243, 255);
            ClientSize = new Size(1005, 623);
            ControlBox = false;
            Controls.Add(divider1);
            Controls.Add(cbExportAll);
            Controls.Add(cbOnlyVip);
            Controls.Add(btnUpdate);
            Controls.Add(btnExport);
            Controls.Add(btnAddCusto);
            Controls.Add(btnSerach);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtCustoName);
            Controls.Add(txtCustoNo);
            Controls.Add(windowBar1);
            Controls.Add(btnPg);
            Controls.Add(dgvCustomerList);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCustoManager";
            Text = "客户信息管理";
            Load += FrmCustoManager_Load;
            cmsCustoManager.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UIContextMenuStrip cmsCustoManager;
        private System.Windows.Forms.ToolStripMenuItem tsmiCustoNo;
        private AntdUI.Table dgvCustomerList;
        private AntdUI.Pagination btnPg;
        private AntdUI.WindowBar windowBar1;
        private AntdUI.Input txtCustoNo;
        private AntdUI.Input txtCustoName;
        private AntdUI.Label label2;
        private AntdUI.Label label1;
        private AntdUI.Button btnSerach;
        private AntdUI.Button btnAddCusto;
        private AntdUI.Button btnExport;
        private AntdUI.Button btnUpdate;
        private AntdUI.Checkbox cbOnlyVip;
        private AntdUI.Checkbox cbExportAll;
        private AntdUI.Divider divider1;
    }
}