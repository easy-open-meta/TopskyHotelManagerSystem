
namespace EOM.TSHotelManager.FormUI
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
            components = new System.ComponentModel.Container();
            TreeNode treeNode1 = new TreeNode("职位类型维护");
            TreeNode treeNode2 = new TreeNode("民族类型维护");
            TreeNode treeNode3 = new TreeNode("学历类型维护");
            TreeNode treeNode4 = new TreeNode("部门信息维护");
            TreeNode treeNode5 = new TreeNode("基础信息", new TreeNode[] { treeNode1, treeNode2, treeNode3, treeNode4 });
            TreeNode treeNode6 = new TreeNode("内部财务账单");
            TreeNode treeNode7 = new TreeNode("财务信息", new TreeNode[] { treeNode6 });
            TreeNode treeNode8 = new TreeNode("水电信息");
            TreeNode treeNode9 = new TreeNode("水电管理", new TreeNode[] { treeNode8 });
            TreeNode treeNode10 = new TreeNode("监管部门情况");
            TreeNode treeNode11 = new TreeNode("监管统计", new TreeNode[] { treeNode10 });
            TreeNode treeNode12 = new TreeNode("房态图一览");
            TreeNode treeNode13 = new TreeNode("新增客房");
            TreeNode treeNode14 = new TreeNode("客房配置");
            TreeNode treeNode15 = new TreeNode("客房管理", new TreeNode[] { treeNode12, treeNode13, treeNode14 });
            TreeNode treeNode16 = new TreeNode("会员等级规则");
            TreeNode treeNode17 = new TreeNode("客户信息管理");
            TreeNode treeNode18 = new TreeNode("顾客消费账单");
            TreeNode treeNode19 = new TreeNode("客户管理", new TreeNode[] { treeNode16, treeNode17, treeNode18 });
            TreeNode treeNode20 = new TreeNode("员工管理");
            TreeNode treeNode21 = new TreeNode("人事管理", new TreeNode[] { treeNode20 });
            TreeNode treeNode22 = new TreeNode("商品管理");
            TreeNode treeNode23 = new TreeNode("物资管理", new TreeNode[] { treeNode22 });
            TreeNode treeNode24 = new TreeNode("员工操作日志");
            TreeNode treeNode25 = new TreeNode("添加管理员");
            TreeNode treeNode26 = new TreeNode("权限分配");
            TreeNode treeNode27 = new TreeNode("启/禁用管理员");
            TreeNode treeNode28 = new TreeNode("系统模块管理");
            TreeNode treeNode29 = new TreeNode("系统管理", new TreeNode[] { treeNode25, treeNode26, treeNode27, treeNode28 });
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBackgroundSystem));
            Aside = new Sunny.UI.UINavMenu();
            pnlForm = new Sunny.UI.UIPanel();
            uiLabel1 = new Sunny.UI.UILabel();
            lblScroll = new Sunny.UI.UIScrollingText();
            lbTime = new Sunny.UI.UILabel();
            timer1 = new System.Windows.Forms.Timer(components);
            cmsMenu = new Sunny.UI.UIContextMenuStrip();
            tsmiUpdatePwd = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            btnSetting = new Sunny.UI.UIButton();
            btnLocked = new Sunny.UI.UIButton();
            cmsMenu.SuspendLayout();
            SuspendLayout();
            // 
            // Aside
            // 
            Aside.BorderStyle = BorderStyle.None;
            Aside.DrawMode = TreeViewDrawMode.OwnerDrawText;
            Aside.Font = new Font("微软雅黑", 12F);
            Aside.FullRowSelect = true;
            Aside.ItemHeight = 50;
            Aside.Location = new Point(6, 87);
            Aside.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            Aside.Name = "Aside";
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
            treeNode6.Name = "节点1";
            treeNode6.Text = "内部财务账单";
            treeNode7.Name = "CashInfo";
            treeNode7.Text = "财务信息";
            treeNode8.Name = "节点0";
            treeNode8.Text = "水电信息";
            treeNode9.Name = "WtiInfo";
            treeNode9.Text = "水电管理";
            treeNode10.Name = "节点3";
            treeNode10.Text = "监管部门情况";
            treeNode11.Name = "CheckInfo";
            treeNode11.Text = "监管统计";
            treeNode12.Name = "节点6";
            treeNode12.Text = "房态图一览";
            treeNode13.Name = "节点7";
            treeNode13.Text = "新增客房";
            treeNode14.Name = "节点0";
            treeNode14.Text = "客房配置";
            treeNode15.Name = "RoomManager";
            treeNode15.Text = "客房管理";
            treeNode16.Name = "节点0";
            treeNode16.Text = "会员等级规则";
            treeNode17.Name = "节点8";
            treeNode17.Text = "客户信息管理";
            treeNode18.Name = "节点9";
            treeNode18.Text = "顾客消费账单";
            treeNode19.Name = "CustomerManager";
            treeNode19.Text = "客户管理";
            treeNode20.Name = "节点6";
            treeNode20.Text = "员工管理";
            treeNode21.Name = "HumanResourcesManager";
            treeNode21.Text = "人事管理";
            treeNode22.Name = "节点11";
            treeNode22.Text = "商品管理";
            treeNode23.Name = "MaterialManager";
            treeNode23.Text = "物资管理";
            treeNode24.Name = "OperationLogManager";
            treeNode24.Text = "员工操作日志";
            treeNode25.Name = "节点2";
            treeNode25.Text = "添加管理员";
            treeNode26.Name = "节点1";
            treeNode26.Text = "权限分配";
            treeNode27.Name = "节点3";
            treeNode27.Text = "启/禁用管理员";
            treeNode28.Name = "节点2";
            treeNode28.Text = "系统模块管理";
            treeNode29.Name = "AdminManager";
            treeNode29.Text = "系统管理";
            Aside.Nodes.AddRange(new TreeNode[] { treeNode5, treeNode7, treeNode9, treeNode11, treeNode15, treeNode19, treeNode21, treeNode23, treeNode24, treeNode29 });
            Aside.ShowLines = false;
            Aside.Size = new Size(234, 624);
            Aside.Style = Sunny.UI.UIStyle.Custom;
            Aside.TabIndex = 0;
            Aside.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            Aside.MenuItemClick += Aside_MenuItemClick;
            Aside.Enter += Aside_Enter;
            // 
            // pnlForm
            // 
            pnlForm.Font = new Font("微软雅黑", 12F);
            pnlForm.Location = new Point(247, 88);
            pnlForm.Margin = new Padding(4, 5, 4, 5);
            pnlForm.MinimumSize = new Size(1, 1);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(1001, 623);
            pnlForm.Style = Sunny.UI.UIStyle.Custom;
            pnlForm.TabIndex = 1;
            pnlForm.Text = "点击左侧导航栏";
            pnlForm.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("微软雅黑", 12F);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(250, 44);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(217, 35);
            uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            uiLabel1.TabIndex = 32;
            uiLabel1.Text = "早上好，Admin";
            uiLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblScroll
            // 
            lblScroll.Active = true;
            lblScroll.FillColor = Color.FromArgb(235, 243, 255);
            lblScroll.Font = new Font("微软雅黑", 12F);
            lblScroll.Interval = 800;
            lblScroll.Location = new Point(473, 41);
            lblScroll.MinimumSize = new Size(1, 1);
            lblScroll.Name = "lblScroll";
            lblScroll.Offset = 20;
            lblScroll.Size = new Size(693, 42);
            lblScroll.Style = Sunny.UI.UIStyle.Custom;
            lblScroll.TabIndex = 33;
            lblScroll.Text = "欢迎使用TS酒店管理后台安全系统，为了您的账号安全，离开座位请点击右侧锁定键锁定系统确保安全！";
            // 
            // lbTime
            // 
            lbTime.Font = new Font("微软雅黑", 12F);
            lbTime.ForeColor = Color.FromArgb(48, 48, 48);
            lbTime.Location = new Point(11, 44);
            lbTime.Name = "lbTime";
            lbTime.Size = new Size(229, 35);
            lbTime.Style = Sunny.UI.UIStyle.Custom;
            lbTime.TabIndex = 34;
            lbTime.Text = "早上好，Admin";
            lbTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // cmsMenu
            // 
            cmsMenu.BackColor = Color.FromArgb(243, 249, 255);
            cmsMenu.Font = new Font("微软雅黑", 12F);
            cmsMenu.Items.AddRange(new ToolStripItem[] { tsmiUpdatePwd, toolStripSeparator1 });
            cmsMenu.Name = "cmsMenu";
            cmsMenu.Size = new Size(145, 36);
            cmsMenu.MouseDown += cmsMenu_MouseDown;
            // 
            // tsmiUpdatePwd
            // 
            tsmiUpdatePwd.Image = Properties.Resources.修改;
            tsmiUpdatePwd.Name = "tsmiUpdatePwd";
            tsmiUpdatePwd.Size = new Size(144, 26);
            tsmiUpdatePwd.Text = "修改密码";
            tsmiUpdatePwd.Click += tsmiUpdatePwd_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(141, 6);
            // 
            // btnSetting
            // 
            btnSetting.BackColor = Color.Transparent;
            btnSetting.BackgroundImage = Properties.Resources.settings2;
            btnSetting.BackgroundImageLayout = ImageLayout.Stretch;
            btnSetting.FillColor = Color.Transparent;
            btnSetting.Font = new Font("微软雅黑", 12F);
            btnSetting.ForeColor = Color.FromArgb(111, 168, 255);
            btnSetting.ForeHoverColor = Color.FromArgb(111, 168, 255);
            btnSetting.ForePressColor = Color.FromArgb(111, 168, 255);
            btnSetting.ForeSelectedColor = Color.FromArgb(111, 168, 255);
            btnSetting.Location = new Point(1172, 45);
            btnSetting.MinimumSize = new Size(1, 1);
            btnSetting.Name = "btnSetting";
            btnSetting.Radius = 20;
            btnSetting.Size = new Size(35, 35);
            btnSetting.Style = Sunny.UI.UIStyle.Custom;
            btnSetting.StyleCustomMode = true;
            btnSetting.TabIndex = 31;
            btnSetting.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnSetting.Click += btnSetting_Click;
            btnSetting.MouseDown += btnSetting_MouseDown;
            btnSetting.MouseLeave += btnSetting_MouseLeave;
            btnSetting.MouseHover += btnSetting_MouseHover;
            // 
            // btnLocked
            // 
            btnLocked.BackColor = Color.Transparent;
            btnLocked.BackgroundImage = (Image)resources.GetObject("btnLocked.BackgroundImage");
            btnLocked.BackgroundImageLayout = ImageLayout.Zoom;
            btnLocked.FillColor = Color.Transparent;
            btnLocked.Font = new Font("微软雅黑", 12F);
            btnLocked.ForeHoverColor = Color.FromArgb(111, 168, 255);
            btnLocked.ForePressColor = Color.FromArgb(111, 168, 255);
            btnLocked.ForeSelectedColor = Color.FromArgb(111, 168, 255);
            btnLocked.Location = new Point(1213, 45);
            btnLocked.MinimumSize = new Size(1, 1);
            btnLocked.Name = "btnLocked";
            btnLocked.Radius = 20;
            btnLocked.Size = new Size(35, 35);
            btnLocked.Style = Sunny.UI.UIStyle.Custom;
            btnLocked.StyleCustomMode = true;
            btnLocked.TabIndex = 30;
            btnLocked.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnLocked.Click += btnLocked_Click;
            btnLocked.MouseLeave += btnLocked_MouseLeave;
            btnLocked.MouseHover += btnLocked_MouseHover;
            // 
            // FrmBackgroundSystem
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1255, 718);
            Controls.Add(lbTime);
            Controls.Add(lblScroll);
            Controls.Add(uiLabel1);
            Controls.Add(btnSetting);
            Controls.Add(btnLocked);
            Controls.Add(pnlForm);
            Controls.Add(Aside);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsForbidAltF4 = true;
            MaximizeBox = false;
            Name = "FrmBackgroundSystem";
            Style = Sunny.UI.UIStyle.Custom;
            Text = "TS酒店管理后台安全系统";
            TextAlignment = StringAlignment.Center;
            ZoomScaleRect = new Rectangle(15, 15, 1255, 718);
            FormClosing += FrmBackgroundSystem_FormClosing;
            FormClosed += FrmBackgroundSystem_FormClosed;
            Load += FrmBackgroundSystem_Load;
            cmsMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UINavMenu Aside;
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
    }
}