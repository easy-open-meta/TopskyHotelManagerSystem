
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
            System.Windows.Forms.TreeNode treeNode113 = new System.Windows.Forms.TreeNode("职位类型维护");
            System.Windows.Forms.TreeNode treeNode114 = new System.Windows.Forms.TreeNode("民族类型维护");
            System.Windows.Forms.TreeNode treeNode115 = new System.Windows.Forms.TreeNode("性别类型维护");
            System.Windows.Forms.TreeNode treeNode116 = new System.Windows.Forms.TreeNode("学历类型维护");
            System.Windows.Forms.TreeNode treeNode117 = new System.Windows.Forms.TreeNode("部门信息维护");
            System.Windows.Forms.TreeNode treeNode118 = new System.Windows.Forms.TreeNode("基础信息", new System.Windows.Forms.TreeNode[] {
            treeNode113,
            treeNode114,
            treeNode115,
            treeNode116,
            treeNode117});
            System.Windows.Forms.TreeNode treeNode119 = new System.Windows.Forms.TreeNode("员工工资账单");
            System.Windows.Forms.TreeNode treeNode120 = new System.Windows.Forms.TreeNode("内部财务账单");
            System.Windows.Forms.TreeNode treeNode121 = new System.Windows.Forms.TreeNode("酒店盈利情况");
            System.Windows.Forms.TreeNode treeNode122 = new System.Windows.Forms.TreeNode("财务信息", new System.Windows.Forms.TreeNode[] {
            treeNode119,
            treeNode120,
            treeNode121});
            System.Windows.Forms.TreeNode treeNode123 = new System.Windows.Forms.TreeNode("水电信息");
            System.Windows.Forms.TreeNode treeNode124 = new System.Windows.Forms.TreeNode("水电管理", new System.Windows.Forms.TreeNode[] {
            treeNode123});
            System.Windows.Forms.TreeNode treeNode125 = new System.Windows.Forms.TreeNode("监管部门情况");
            System.Windows.Forms.TreeNode treeNode126 = new System.Windows.Forms.TreeNode("监管统计", new System.Windows.Forms.TreeNode[] {
            treeNode125});
            System.Windows.Forms.TreeNode treeNode127 = new System.Windows.Forms.TreeNode("房态图一览");
            System.Windows.Forms.TreeNode treeNode128 = new System.Windows.Forms.TreeNode("新增客房");
            System.Windows.Forms.TreeNode treeNode129 = new System.Windows.Forms.TreeNode("客房管理", new System.Windows.Forms.TreeNode[] {
            treeNode127,
            treeNode128});
            System.Windows.Forms.TreeNode treeNode130 = new System.Windows.Forms.TreeNode("客户信息管理");
            System.Windows.Forms.TreeNode treeNode131 = new System.Windows.Forms.TreeNode("顾客消费账单");
            System.Windows.Forms.TreeNode treeNode132 = new System.Windows.Forms.TreeNode("客户管理", new System.Windows.Forms.TreeNode[] {
            treeNode130,
            treeNode131});
            System.Windows.Forms.TreeNode treeNode133 = new System.Windows.Forms.TreeNode("员工管理");
            System.Windows.Forms.TreeNode treeNode134 = new System.Windows.Forms.TreeNode("任命日志");
            System.Windows.Forms.TreeNode treeNode135 = new System.Windows.Forms.TreeNode("上传任命日志");
            System.Windows.Forms.TreeNode treeNode136 = new System.Windows.Forms.TreeNode("人事管理", new System.Windows.Forms.TreeNode[] {
            treeNode133,
            treeNode134,
            treeNode135});
            System.Windows.Forms.TreeNode treeNode137 = new System.Windows.Forms.TreeNode("商品管理");
            System.Windows.Forms.TreeNode treeNode138 = new System.Windows.Forms.TreeNode("仓库物资");
            System.Windows.Forms.TreeNode treeNode139 = new System.Windows.Forms.TreeNode("物资管理", new System.Windows.Forms.TreeNode[] {
            treeNode137,
            treeNode138});
            System.Windows.Forms.TreeNode treeNode140 = new System.Windows.Forms.TreeNode("员工操作日志");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBackgroundSystem));
            this.Aside = new Sunny.UI.UINavMenu();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlForm = new Sunny.UI.UIPanel();
            this.btnSetting = new Sunny.UI.UIButton();
            this.btnLocked = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // Aside
            // 
            this.Aside.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Aside.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.Aside.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Aside.FullRowSelect = true;
            this.Aside.ItemHeight = 50;
            this.Aside.Location = new System.Drawing.Point(6, 87);
            this.Aside.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.Aside.Name = "Aside";
            treeNode113.Name = "节点1";
            treeNode113.Text = "职位类型维护";
            treeNode114.Name = "节点2";
            treeNode114.Text = "民族类型维护";
            treeNode115.Name = "节点3";
            treeNode115.Text = "性别类型维护";
            treeNode116.Name = "节点4";
            treeNode116.Text = "学历类型维护";
            treeNode117.Name = "节点5";
            treeNode117.Text = "部门信息维护";
            treeNode118.Name = "节点0";
            treeNode118.Text = "基础信息";
            treeNode119.Name = "节点0";
            treeNode119.Text = "员工工资账单";
            treeNode120.Name = "节点1";
            treeNode120.Text = "内部财务账单";
            treeNode121.Name = "节点2";
            treeNode121.Text = "酒店盈利情况";
            treeNode122.Name = "btnCash";
            treeNode122.Text = "财务信息";
            treeNode123.Name = "节点0";
            treeNode123.Text = "水电信息";
            treeNode124.Name = "节点1";
            treeNode124.Text = "水电管理";
            treeNode125.Name = "节点3";
            treeNode125.Text = "监管部门情况";
            treeNode126.Name = "节点2";
            treeNode126.Text = "监管统计";
            treeNode127.Name = "节点6";
            treeNode127.Text = "房态图一览";
            treeNode128.Name = "节点7";
            treeNode128.Text = "新增客房";
            treeNode129.Name = "节点3";
            treeNode129.Text = "客房管理";
            treeNode130.Name = "节点8";
            treeNode130.Text = "客户信息管理";
            treeNode131.Name = "节点9";
            treeNode131.Text = "顾客消费账单";
            treeNode132.Name = "节点4";
            treeNode132.Text = "客户管理";
            treeNode133.Name = "节点6";
            treeNode133.Text = "员工管理";
            treeNode134.Name = "节点15";
            treeNode134.Text = "任命日志";
            treeNode135.Name = "节点16";
            treeNode135.Text = "上传任命日志";
            treeNode136.Name = "节点5";
            treeNode136.Text = "人事管理";
            treeNode137.Name = "节点11";
            treeNode137.Text = "商品管理";
            treeNode138.Name = "节点12";
            treeNode138.Text = "仓库物资";
            treeNode139.Name = "节点10";
            treeNode139.Text = "物资管理";
            treeNode140.Name = "节点13";
            treeNode140.Text = "员工操作日志";
            this.Aside.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode118,
            treeNode122,
            treeNode124,
            treeNode126,
            treeNode129,
            treeNode132,
            treeNode136,
            treeNode139,
            treeNode140});
            this.Aside.ShowLines = false;
            this.Aside.Size = new System.Drawing.Size(234, 624);
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
            this.pnlForm.Location = new System.Drawing.Point(247, 88);
            this.pnlForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlForm.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(1005, 623);
            this.pnlForm.Style = Sunny.UI.UIStyle.Custom;
            this.pnlForm.TabIndex = 1;
            this.pnlForm.Text = "点击左侧导航栏";
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.BackgroundImage = global::SYS.FormUI.Properties.Resources.settings2;
            this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnSetting.FillColor = System.Drawing.Color.Transparent;
            this.btnSetting.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btnSetting.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btnSetting.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btnSetting.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btnSetting.Location = new System.Drawing.Point(1172, 45);
            this.btnSetting.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Radius = 20;
            this.btnSetting.Size = new System.Drawing.Size(35, 35);
            this.btnSetting.Style = Sunny.UI.UIStyle.Custom;
            this.btnSetting.StyleCustomMode = true;
            this.btnSetting.TabIndex = 31;
            this.btnSetting.MouseLeave += new System.EventHandler(this.btnSetting_MouseLeave);
            this.btnSetting.MouseHover += new System.EventHandler(this.btnSetting_MouseHover);
            // 
            // btnLocked
            // 
            this.btnLocked.BackColor = System.Drawing.Color.Transparent;
            this.btnLocked.BackgroundImage = global::SYS.FormUI.Properties.Resources._lock;
            this.btnLocked.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLocked.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnLocked.FillColor = System.Drawing.Color.Transparent;
            this.btnLocked.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnLocked.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btnLocked.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btnLocked.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btnLocked.Location = new System.Drawing.Point(1213, 45);
            this.btnLocked.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLocked.Name = "btnLocked";
            this.btnLocked.Radius = 20;
            this.btnLocked.Size = new System.Drawing.Size(35, 35);
            this.btnLocked.Style = Sunny.UI.UIStyle.Custom;
            this.btnLocked.StyleCustomMode = true;
            this.btnLocked.TabIndex = 30;
            this.btnLocked.Click += new System.EventHandler(this.btnLocked_Click);
            this.btnLocked.MouseLeave += new System.EventHandler(this.btnLocked_MouseLeave);
            this.btnLocked.MouseHover += new System.EventHandler(this.btnLocked_MouseHover);
            // 
            // FrmBackgroundSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 718);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnLocked);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.Aside);
            this.EscClose = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsForbidAltF4 = true;
            this.MaximizeBox = false;
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
        private Sunny.UI.UIButton btnLocked;
        private Sunny.UI.UIButton btnSetting;
    }
}