
namespace SYS.FormUI
{
    partial class FrmBackgroundSystem
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
            System.Windows.Forms.TreeNode treeNode85 = new System.Windows.Forms.TreeNode("职位类型维护");
            System.Windows.Forms.TreeNode treeNode86 = new System.Windows.Forms.TreeNode("民族类型维护");
            System.Windows.Forms.TreeNode treeNode87 = new System.Windows.Forms.TreeNode("性别类型维护");
            System.Windows.Forms.TreeNode treeNode88 = new System.Windows.Forms.TreeNode("学历类型维护");
            System.Windows.Forms.TreeNode treeNode89 = new System.Windows.Forms.TreeNode("部门信息维护");
            System.Windows.Forms.TreeNode treeNode90 = new System.Windows.Forms.TreeNode("基础信息", new System.Windows.Forms.TreeNode[] {
            treeNode85,
            treeNode86,
            treeNode87,
            treeNode88,
            treeNode89});
            System.Windows.Forms.TreeNode treeNode91 = new System.Windows.Forms.TreeNode("员工工资账单");
            System.Windows.Forms.TreeNode treeNode92 = new System.Windows.Forms.TreeNode("内部财务账单");
            System.Windows.Forms.TreeNode treeNode93 = new System.Windows.Forms.TreeNode("酒店盈利情况");
            System.Windows.Forms.TreeNode treeNode94 = new System.Windows.Forms.TreeNode("财务信息", new System.Windows.Forms.TreeNode[] {
            treeNode91,
            treeNode92,
            treeNode93});
            System.Windows.Forms.TreeNode treeNode95 = new System.Windows.Forms.TreeNode("水电信息");
            System.Windows.Forms.TreeNode treeNode96 = new System.Windows.Forms.TreeNode("水电管理", new System.Windows.Forms.TreeNode[] {
            treeNode95});
            System.Windows.Forms.TreeNode treeNode97 = new System.Windows.Forms.TreeNode("监管部门情况");
            System.Windows.Forms.TreeNode treeNode98 = new System.Windows.Forms.TreeNode("监管统计", new System.Windows.Forms.TreeNode[] {
            treeNode97});
            System.Windows.Forms.TreeNode treeNode99 = new System.Windows.Forms.TreeNode("房态图一览");
            System.Windows.Forms.TreeNode treeNode100 = new System.Windows.Forms.TreeNode("新增客房");
            System.Windows.Forms.TreeNode treeNode101 = new System.Windows.Forms.TreeNode("客房管理", new System.Windows.Forms.TreeNode[] {
            treeNode99,
            treeNode100});
            System.Windows.Forms.TreeNode treeNode102 = new System.Windows.Forms.TreeNode("客户信息管理");
            System.Windows.Forms.TreeNode treeNode103 = new System.Windows.Forms.TreeNode("顾客消费账单");
            System.Windows.Forms.TreeNode treeNode104 = new System.Windows.Forms.TreeNode("客户管理", new System.Windows.Forms.TreeNode[] {
            treeNode102,
            treeNode103});
            System.Windows.Forms.TreeNode treeNode105 = new System.Windows.Forms.TreeNode("员工管理");
            System.Windows.Forms.TreeNode treeNode106 = new System.Windows.Forms.TreeNode("任命日志");
            System.Windows.Forms.TreeNode treeNode107 = new System.Windows.Forms.TreeNode("上传任命日志");
            System.Windows.Forms.TreeNode treeNode108 = new System.Windows.Forms.TreeNode("人事管理", new System.Windows.Forms.TreeNode[] {
            treeNode105,
            treeNode106,
            treeNode107});
            System.Windows.Forms.TreeNode treeNode109 = new System.Windows.Forms.TreeNode("商品管理");
            System.Windows.Forms.TreeNode treeNode110 = new System.Windows.Forms.TreeNode("仓库物资");
            System.Windows.Forms.TreeNode treeNode111 = new System.Windows.Forms.TreeNode("物资管理", new System.Windows.Forms.TreeNode[] {
            treeNode109,
            treeNode110});
            System.Windows.Forms.TreeNode treeNode112 = new System.Windows.Forms.TreeNode("员工操作日志");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBackgroundSystem));
            this.Aside = new Sunny.UI.UINavMenu();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlForm = new Sunny.UI.UIPanel();
            this.SuspendLayout();
            // 
            // Aside
            // 
            this.Aside.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Aside.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.Aside.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Aside.FullRowSelect = true;
            this.Aside.ItemHeight = 50;
            this.Aside.Location = new System.Drawing.Point(3, 38);
            this.Aside.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.Aside.Name = "Aside";
            treeNode85.Name = "节点1";
            treeNode85.Text = "职位类型维护";
            treeNode86.Name = "节点2";
            treeNode86.Text = "民族类型维护";
            treeNode87.Name = "节点3";
            treeNode87.Text = "性别类型维护";
            treeNode88.Name = "节点4";
            treeNode88.Text = "学历类型维护";
            treeNode89.Name = "节点5";
            treeNode89.Text = "部门信息维护";
            treeNode90.Name = "节点0";
            treeNode90.Text = "基础信息";
            treeNode91.Name = "节点0";
            treeNode91.Text = "员工工资账单";
            treeNode92.Name = "节点1";
            treeNode92.Text = "内部财务账单";
            treeNode93.Name = "节点2";
            treeNode93.Text = "酒店盈利情况";
            treeNode94.Name = "btnCash";
            treeNode94.Text = "财务信息";
            treeNode95.Name = "节点0";
            treeNode95.Text = "水电信息";
            treeNode96.Name = "节点1";
            treeNode96.Text = "水电管理";
            treeNode97.Name = "节点3";
            treeNode97.Text = "监管部门情况";
            treeNode98.Name = "节点2";
            treeNode98.Text = "监管统计";
            treeNode99.Name = "节点6";
            treeNode99.Text = "房态图一览";
            treeNode100.Name = "节点7";
            treeNode100.Text = "新增客房";
            treeNode101.Name = "节点3";
            treeNode101.Text = "客房管理";
            treeNode102.Name = "节点8";
            treeNode102.Text = "客户信息管理";
            treeNode103.Name = "节点9";
            treeNode103.Text = "顾客消费账单";
            treeNode104.Name = "节点4";
            treeNode104.Text = "客户管理";
            treeNode105.Name = "节点6";
            treeNode105.Text = "员工管理";
            treeNode106.Name = "节点15";
            treeNode106.Text = "任命日志";
            treeNode107.Name = "节点16";
            treeNode107.Text = "上传任命日志";
            treeNode108.Name = "节点5";
            treeNode108.Text = "人事管理";
            treeNode109.Name = "节点11";
            treeNode109.Text = "商品管理";
            treeNode110.Name = "节点12";
            treeNode110.Text = "仓库物资";
            treeNode111.Name = "节点10";
            treeNode111.Text = "物资管理";
            treeNode112.Name = "节点13";
            treeNode112.Text = "员工操作日志";
            this.Aside.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode90,
            treeNode94,
            treeNode96,
            treeNode98,
            treeNode101,
            treeNode104,
            treeNode108,
            treeNode111,
            treeNode112});
            this.Aside.ShowLines = false;
            this.Aside.Size = new System.Drawing.Size(234, 625);
            this.Aside.Style = Sunny.UI.UIStyle.Custom;
            this.Aside.TabIndex = 0;
            this.Aside.MenuItemClick += new Sunny.UI.UINavMenu.OnMenuItemClick(this.Aside_MenuItemClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "财务.png");
            // 
            // pnlForm
            // 
            this.pnlForm.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.pnlForm.Location = new System.Drawing.Point(244, 40);
            this.pnlForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlForm.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(1005, 623);
            this.pnlForm.Style = Sunny.UI.UIStyle.Custom;
            this.pnlForm.TabIndex = 1;
            this.pnlForm.Text = "点击左侧导航栏";
            // 
            // FrmBackgroundSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 666);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.Aside);
            this.EscClose = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBackgroundSystem";
            this.ShowIcon = true;
            this.ShowRadius = false;
            this.ShowShadow = true;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "TS酒店管理后台安全系统";
            this.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Load += new System.EventHandler(this.FrmBackgroundSystem_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UINavMenu Aside;
        private System.Windows.Forms.ImageList imageList1;
        private Sunny.UI.UIPanel pnlForm;
    }
}