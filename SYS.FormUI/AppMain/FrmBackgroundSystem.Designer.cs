
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("职位类型维护");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("民族类型维护");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("学历类型维护");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("部门信息维护");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("基础信息", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("员工工资账单");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("内部财务账单");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("酒店盈利情况");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("财务信息", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("水电信息");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("水电管理", new System.Windows.Forms.TreeNode[] {
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("监管部门情况");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("监管统计", new System.Windows.Forms.TreeNode[] {
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("房态图一览");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("新增客房");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("客房管理", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("会员等级规则");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("客户信息管理");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("顾客消费账单");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("客户管理", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("员工管理");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("公告日志");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("上传公告日志");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("人事管理", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode22,
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("商品管理");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("仓库物资");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("物资管理", new System.Windows.Forms.TreeNode[] {
            treeNode25,
            treeNode26});
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("员工操作日志");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("添加管理员");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("权限分配");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("启/禁用管理员");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("系统模块管理");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("系统管理", new System.Windows.Forms.TreeNode[] {
            treeNode29,
            treeNode30,
            treeNode31,
            treeNode32});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBackgroundSystem));
            this.Aside = new Sunny.UI.UINavMenu();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlForm = new Sunny.UI.UIPanel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.lblScroll = new Sunny.UI.UIScrollingText();
            this.lbTime = new Sunny.UI.UILabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cmsMenu = new Sunny.UI.UIContextMenuStrip();
            this.tsmiMySpace = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdatePwd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSetting = new Sunny.UI.UIButton();
            this.btnLocked = new Sunny.UI.UIButton();
            this.cmsMenu.SuspendLayout();
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
            treeNode1.Name = "节点1";
            treeNode1.Text = "职位类型维护";
            treeNode2.Name = "节点2";
            treeNode2.Text = "民族类型维护";
            treeNode3.Name = "节点4";
            treeNode3.Text = "学历类型维护";
            treeNode4.Name = "节点5";
            treeNode4.Text = "部门信息维护";
            treeNode5.Name = "BaseInfo";
            treeNode5.Text = "基础信息";
            treeNode6.Name = "节点0";
            treeNode6.Text = "员工工资账单";
            treeNode7.Name = "节点1";
            treeNode7.Text = "内部财务账单";
            treeNode8.Name = "节点2";
            treeNode8.Text = "酒店盈利情况";
            treeNode9.Name = "CashInfo";
            treeNode9.Text = "财务信息";
            treeNode10.Name = "节点0";
            treeNode10.Text = "水电信息";
            treeNode11.Name = "WtiInfo";
            treeNode11.Text = "水电管理";
            treeNode12.Name = "节点3";
            treeNode12.Text = "监管部门情况";
            treeNode13.Name = "CheckInfo";
            treeNode13.Text = "监管统计";
            treeNode14.Name = "节点6";
            treeNode14.Text = "房态图一览";
            treeNode15.Name = "节点7";
            treeNode15.Text = "新增客房";
            treeNode16.Name = "RoomManager";
            treeNode16.Text = "客房管理";
            treeNode17.Name = "节点0";
            treeNode17.Text = "会员等级规则";
            treeNode18.Name = "节点8";
            treeNode18.Text = "客户信息管理";
            treeNode19.Name = "节点9";
            treeNode19.Text = "顾客消费账单";
            treeNode20.Name = "CustomerManager";
            treeNode20.Text = "客户管理";
            treeNode21.Name = "节点6";
            treeNode21.Text = "员工管理";
            treeNode22.Name = "节点15";
            treeNode22.Text = "公告日志";
            treeNode23.Name = "节点16";
            treeNode23.Text = "上传公告日志";
            treeNode24.Name = "HumanResourcesManager";
            treeNode24.Text = "人事管理";
            treeNode25.Name = "节点11";
            treeNode25.Text = "商品管理";
            treeNode26.Name = "节点12";
            treeNode26.Text = "仓库物资";
            treeNode27.Name = "MaterialManager";
            treeNode27.Text = "物资管理";
            treeNode28.Name = "OperationLogManager";
            treeNode28.Text = "员工操作日志";
            treeNode29.Name = "节点2";
            treeNode29.Text = "添加管理员";
            treeNode30.Name = "节点1";
            treeNode30.Text = "权限分配";
            treeNode31.Name = "节点3";
            treeNode31.Text = "启/禁用管理员";
            treeNode32.Name = "节点2";
            treeNode32.Text = "系统模块管理";
            treeNode33.Name = "AdminManager";
            treeNode33.Text = "系统管理";
            this.Aside.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode9,
            treeNode11,
            treeNode13,
            treeNode16,
            treeNode20,
            treeNode24,
            treeNode27,
            treeNode28,
            treeNode33});
            this.Aside.ShowLines = false;
            this.Aside.Size = new System.Drawing.Size(234, 624);
            this.Aside.Style = Sunny.UI.UIStyle.Custom;
            this.Aside.TabIndex = 0;
            this.Aside.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Aside.MenuItemClick += new Sunny.UI.UINavMenu.OnMenuItemClick(this.Aside_MenuItemClick);
            this.Aside.Enter += new System.EventHandler(this.Aside_Enter);
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
            this.pnlForm.Size = new System.Drawing.Size(1001, 623);
            this.pnlForm.Style = Sunny.UI.UIStyle.Custom;
            this.pnlForm.TabIndex = 1;
            this.pnlForm.Text = "点击左侧导航栏";
            this.pnlForm.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(250, 44);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(217, 35);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 32;
            this.uiLabel1.Text = "早上好，Admin";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblScroll
            // 
            this.lblScroll.Active = true;
            this.lblScroll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.lblScroll.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblScroll.Interval = 800;
            this.lblScroll.Location = new System.Drawing.Point(473, 41);
            this.lblScroll.MinimumSize = new System.Drawing.Size(1, 1);
            this.lblScroll.Name = "lblScroll";
            this.lblScroll.Offset = 20;
            this.lblScroll.Size = new System.Drawing.Size(693, 42);
            this.lblScroll.Style = Sunny.UI.UIStyle.Custom;
            this.lblScroll.TabIndex = 33;
            this.lblScroll.Text = "欢迎使用TS酒店管理后台安全系统，为了您的账号安全，离开座位请点击右侧锁定键锁定系统确保安全！";
            // 
            // lbTime
            // 
            this.lbTime.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lbTime.Location = new System.Drawing.Point(11, 44);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(229, 35);
            this.lbTime.Style = Sunny.UI.UIStyle.Custom;
            this.lbTime.TabIndex = 34;
            this.lbTime.Text = "早上好，Admin";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cmsMenu
            // 
            this.cmsMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.cmsMenu.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMySpace,
            this.tsmiUpdatePwd,
            this.toolStripSeparator1});
            this.cmsMenu.Name = "cmsMenu";
            this.cmsMenu.Size = new System.Drawing.Size(145, 62);
            this.cmsMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmsMenu_MouseDown);
            // 
            // tsmiMySpace
            // 
            this.tsmiMySpace.Image = global::SYS.FormUI.Properties.Resources.个人中心;
            this.tsmiMySpace.Name = "tsmiMySpace";
            this.tsmiMySpace.Size = new System.Drawing.Size(144, 26);
            this.tsmiMySpace.Text = "个人中心";
            this.tsmiMySpace.Click += new System.EventHandler(this.tsmiMySpace_Click);
            // 
            // tsmiUpdatePwd
            // 
            this.tsmiUpdatePwd.Image = global::SYS.FormUI.Properties.Resources.修改;
            this.tsmiUpdatePwd.Name = "tsmiUpdatePwd";
            this.tsmiUpdatePwd.Size = new System.Drawing.Size(144, 26);
            this.tsmiUpdatePwd.Text = "修改密码";
            this.tsmiUpdatePwd.Click += new System.EventHandler(this.tsmiUpdatePwd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(141, 6);
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
            this.btnSetting.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            this.btnSetting.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSetting_MouseDown);
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
            this.btnLocked.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLocked.Click += new System.EventHandler(this.btnLocked_Click);
            this.btnLocked.MouseLeave += new System.EventHandler(this.btnLocked_MouseLeave);
            this.btnLocked.MouseHover += new System.EventHandler(this.btnLocked_MouseHover);
            // 
            // FrmBackgroundSystem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1255, 718);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lblScroll);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnLocked);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.Aside);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsForbidAltF4 = true;
            this.MaximizeBox = false;
            this.Name = "FrmBackgroundSystem";
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "TS酒店管理后台安全系统";
            this.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 1255, 718);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBackgroundSystem_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmBackgroundSystem_FormClosed);
            this.Load += new System.EventHandler(this.FrmBackgroundSystem_Load);
            this.cmsMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UINavMenu Aside;
        private System.Windows.Forms.ImageList imageList1;
        private Sunny.UI.UIPanel pnlForm;
        private Sunny.UI.UIButton btnLocked;
        private Sunny.UI.UIButton btnSetting;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIScrollingText lblScroll;
        private Sunny.UI.UILabel lbTime;
        private System.Windows.Forms.Timer timer1;
        private Sunny.UI.UIContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdatePwd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiMySpace;
    }
}