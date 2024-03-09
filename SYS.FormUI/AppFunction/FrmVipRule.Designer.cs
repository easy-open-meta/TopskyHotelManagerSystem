
namespace SYS.FormUI
{
    partial class FrmVipRule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVipRule));
            this.flpVipType = new Sunny.UI.UIFlowLayoutPanel();
            this.btnOK = new Sunny.UI.UIButton();
            this.txtRuleId = new Sunny.UI.UITextBox();
            this.txtRuleName = new Sunny.UI.UITextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCustoType = new Sunny.UI.UIComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dudSpendAmount = new Sunny.UI.UIDoubleUpDown();
            this.btnReset = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // flpVipType
            // 
            this.flpVipType.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flpVipType.Location = new System.Drawing.Point(4, 40);
            this.flpVipType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flpVipType.MinimumSize = new System.Drawing.Size(1, 1);
            this.flpVipType.Name = "flpVipType";
            this.flpVipType.Padding = new System.Windows.Forms.Padding(2);
            this.flpVipType.Size = new System.Drawing.Size(489, 578);
            this.flpVipType.TabIndex = 0;
            this.flpVipType.Text = "uiFlowLayoutPanel1";
            this.flpVipType.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOK
            // 
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnOK.Location = new System.Drawing.Point(569, 262);
            this.btnOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOK.Name = "btnOK";
            this.btnOK.Radius = 20;
            this.btnOK.Size = new System.Drawing.Size(144, 40);
            this.btnOK.TabIndex = 180;
            this.btnOK.Text = "录入";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtRuleId
            // 
            this.txtRuleId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRuleId.FillColor = System.Drawing.Color.White;
            this.txtRuleId.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRuleId.Location = new System.Drawing.Point(671, 53);
            this.txtRuleId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRuleId.Maximum = 2147483647D;
            this.txtRuleId.Minimum = -2147483648D;
            this.txtRuleId.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtRuleId.Name = "txtRuleId";
            this.txtRuleId.Padding = new System.Windows.Forms.Padding(5);
            this.txtRuleId.Radius = 20;
            this.txtRuleId.ReadOnly = true;
            this.txtRuleId.Size = new System.Drawing.Size(250, 35);
            this.txtRuleId.Style = Sunny.UI.UIStyle.Custom;
            this.txtRuleId.StyleCustomMode = true;
            this.txtRuleId.TabIndex = 184;
            this.txtRuleId.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRuleName
            // 
            this.txtRuleName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRuleName.FillColor = System.Drawing.Color.White;
            this.txtRuleName.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRuleName.Location = new System.Drawing.Point(671, 105);
            this.txtRuleName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRuleName.Maximum = 2147483647D;
            this.txtRuleName.Minimum = -2147483648D;
            this.txtRuleName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtRuleName.Name = "txtRuleName";
            this.txtRuleName.Padding = new System.Windows.Forms.Padding(5);
            this.txtRuleName.Radius = 20;
            this.txtRuleName.Size = new System.Drawing.Size(250, 35);
            this.txtRuleName.Style = Sunny.UI.UIStyle.Custom;
            this.txtRuleName.StyleCustomMode = true;
            this.txtRuleName.TabIndex = 185;
            this.txtRuleName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(564, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 183;
            this.label4.Text = "消费总额";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(564, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 182;
            this.label3.Text = "规则名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(564, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 181;
            this.label2.Text = "规则编号";
            // 
            // cboCustoType
            // 
            this.cboCustoType.DataSource = null;
            this.cboCustoType.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cboCustoType.FillColor = System.Drawing.Color.White;
            this.cboCustoType.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.cboCustoType.Location = new System.Drawing.Point(671, 209);
            this.cboCustoType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboCustoType.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboCustoType.Name = "cboCustoType";
            this.cboCustoType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboCustoType.Radius = 20;
            this.cboCustoType.Size = new System.Drawing.Size(250, 35);
            this.cboCustoType.TabIndex = 188;
            this.cboCustoType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(564, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 187;
            this.label1.Text = "会员类型";
            // 
            // dudSpendAmount
            // 
            this.dudSpendAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dudSpendAmount.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.dudSpendAmount.Location = new System.Drawing.Point(671, 157);
            this.dudSpendAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dudSpendAmount.Maximum = 999999999999999D;
            this.dudSpendAmount.Minimum = 0D;
            this.dudSpendAmount.MinimumSize = new System.Drawing.Size(100, 0);
            this.dudSpendAmount.Name = "dudSpendAmount";
            this.dudSpendAmount.Radius = 20;
            this.dudSpendAmount.Size = new System.Drawing.Size(250, 35);
            this.dudSpendAmount.Step = 5000D;
            this.dudSpendAmount.TabIndex = 189;
            this.dudSpendAmount.Text = null;
            this.dudSpendAmount.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.dudSpendAmount.Value = 0D;
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnReset.Location = new System.Drawing.Point(777, 262);
            this.btnReset.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnReset.Name = "btnReset";
            this.btnReset.Radius = 20;
            this.btnReset.Size = new System.Drawing.Size(144, 40);
            this.btnReset.TabIndex = 190;
            this.btnReset.Text = "重置";
            // 
            // FrmVipRule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 623);
            this.ControlBox = false;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dudSpendAmount);
            this.Controls.Add(this.cboCustoType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRuleId);
            this.Controls.Add(this.txtRuleName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.flpVipType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVipRule";
            this.ShowIcon = true;
            this.ShowTitleIcon = true;
            this.Text = "会员等级规则";
            this.Load += new System.EventHandler(this.FrmVipRule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIFlowLayoutPanel flpVipType;
        private Sunny.UI.UIButton btnOK;
        private Sunny.UI.UITextBox txtRuleId;
        private Sunny.UI.UITextBox txtRuleName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UIComboBox cboCustoType;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UIDoubleUpDown dudSpendAmount;
        private Sunny.UI.UIButton btnReset;
    }
}