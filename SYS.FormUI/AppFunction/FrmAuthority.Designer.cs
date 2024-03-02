
namespace SYS.FormUI
{
    partial class FrmAuthority
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAuthority));
            this.tfModuleZero = new Sunny.UI.UITransfer();
            this.cbAccountType = new Sunny.UI.UIComboBox();
            this.txtAccount = new Sunny.UI.UITextBox();
            this.txtName = new Sunny.UI.UITextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFind = new Sunny.UI.UIButton();
            this.btnAuthority = new Sunny.UI.UIButton();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.SuspendLayout();
            // 
            // tfModuleZero
            // 
            this.tfModuleZero.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tfModuleZero.Location = new System.Drawing.Point(7, 227);
            this.tfModuleZero.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.tfModuleZero.MinimumSize = new System.Drawing.Size(1, 1);
            this.tfModuleZero.Name = "tfModuleZero";
            this.tfModuleZero.Padding = new System.Windows.Forms.Padding(1);
            this.tfModuleZero.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.tfModuleZero.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.tfModuleZero.Size = new System.Drawing.Size(987, 341);
            this.tfModuleZero.TabIndex = 0;
            this.tfModuleZero.Text = "uiTransfer1";
            this.tfModuleZero.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbAccountType
            // 
            this.cbAccountType.DataSource = null;
            this.cbAccountType.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbAccountType.Enabled = false;
            this.cbAccountType.FillColor = System.Drawing.Color.White;
            this.cbAccountType.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.cbAccountType.Items.AddRange(new object[] {
            "管理员",
            "超级管理员"});
            this.cbAccountType.Location = new System.Drawing.Point(238, 118);
            this.cbAccountType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbAccountType.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbAccountType.Name = "cbAccountType";
            this.cbAccountType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbAccountType.Radius = 20;
            this.cbAccountType.Size = new System.Drawing.Size(250, 35);
            this.cbAccountType.TabIndex = 123;
            this.cbAccountType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbAccountType.Watermark = "";
            // 
            // txtAccount
            // 
            this.txtAccount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccount.FillColor = System.Drawing.Color.White;
            this.txtAccount.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAccount.Location = new System.Drawing.Point(236, 57);
            this.txtAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAccount.Maximum = 2147483647D;
            this.txtAccount.Minimum = -2147483648D;
            this.txtAccount.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Padding = new System.Windows.Forms.Padding(5);
            this.txtAccount.Radius = 20;
            this.txtAccount.Size = new System.Drawing.Size(506, 35);
            this.txtAccount.Style = Sunny.UI.UIStyle.Custom;
            this.txtAccount.StyleCustomMode = true;
            this.txtAccount.TabIndex = 121;
            this.txtAccount.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Enabled = false;
            this.txtName.FillColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.Location = new System.Drawing.Point(626, 118);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Maximum = 2147483647D;
            this.txtName.Minimum = -2147483648D;
            this.txtName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(5);
            this.txtName.Radius = 20;
            this.txtName.Size = new System.Drawing.Size(250, 35);
            this.txtName.Style = Sunny.UI.UIStyle.Custom;
            this.txtName.StyleCustomMode = true;
            this.txtName.TabIndex = 122;
            this.txtName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(125, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 120;
            this.label6.Text = "账户类型";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(513, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 119;
            this.label3.Text = "真实姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(125, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 118;
            this.label2.Text = "账      号";
            // 
            // btnFind
            // 
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnFind.Location = new System.Drawing.Point(770, 57);
            this.btnFind.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnFind.Name = "btnFind";
            this.btnFind.Radius = 20;
            this.btnFind.Size = new System.Drawing.Size(106, 35);
            this.btnFind.TabIndex = 124;
            this.btnFind.Text = "查       询";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnAuthority
            // 
            this.btnAuthority.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAuthority.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnAuthority.Location = new System.Drawing.Point(888, 577);
            this.btnAuthority.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAuthority.Name = "btnAuthority";
            this.btnAuthority.Radius = 20;
            this.btnAuthority.Size = new System.Drawing.Size(106, 35);
            this.btnAuthority.TabIndex = 125;
            this.btnAuthority.Text = "分配权限";
            this.btnAuthority.Click += new System.EventHandler(this.btnAuthority_Click);
            // 
            // uiPanel1
            // 
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel1.Location = new System.Drawing.Point(7, 186);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(454, 35);
            this.uiPanel1.TabIndex = 126;
            this.uiPanel1.Text = "我未拥有的系统模块";
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel2
            // 
            this.uiPanel2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel2.Location = new System.Drawing.Point(541, 183);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Size = new System.Drawing.Size(453, 38);
            this.uiPanel2.TabIndex = 127;
            this.uiPanel2.Text = "我拥有的系统模块";
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmAuthority
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 623);
            this.ControlBox = false;
            this.Controls.Add(this.uiPanel2);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.btnAuthority);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.cbAccountType);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tfModuleZero);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAuthority";
            this.ShowIcon = true;
            this.ShowTitleIcon = true;
            this.Text = "权限分配";
            this.Load += new System.EventHandler(this.FrmAuthority_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UITransfer tfModuleZero;
        private Sunny.UI.UIComboBox cbAccountType;
        private Sunny.UI.UITextBox txtAccount;
        private Sunny.UI.UITextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UIButton btnFind;
        private Sunny.UI.UIButton btnAuthority;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIPanel uiPanel2;
    }
}