
namespace SYS.FormUI
{
    partial class FrmPosition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPosition));
            this.flpInformation = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new Sunny.UI.UIButton();
            this.txtJobNm = new Sunny.UI.UITextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // flpInformation
            // 
            this.flpInformation.AutoScroll = true;
            this.flpInformation.BackColor = System.Drawing.Color.Transparent;
            this.flpInformation.Location = new System.Drawing.Point(2, 117);
            this.flpInformation.Margin = new System.Windows.Forms.Padding(2);
            this.flpInformation.Name = "flpInformation";
            this.flpInformation.Size = new System.Drawing.Size(1001, 504);
            this.flpInformation.TabIndex = 73;
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnAdd.Location = new System.Drawing.Point(582, 56);
            this.btnAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Radius = 20;
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.TabIndex = 134;
            this.btnAdd.Text = "添     加";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtJobNm
            // 
            this.txtJobNm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtJobNm.FillColor = System.Drawing.Color.White;
            this.txtJobNm.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtJobNm.Location = new System.Drawing.Point(280, 56);
            this.txtJobNm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtJobNm.Maximum = 2147483647D;
            this.txtJobNm.Minimum = -2147483648D;
            this.txtJobNm.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtJobNm.Name = "txtJobNm";
            this.txtJobNm.Padding = new System.Windows.Forms.Padding(5);
            this.txtJobNm.Radius = 20;
            this.txtJobNm.Size = new System.Drawing.Size(250, 35);
            this.txtJobNm.Style = Sunny.UI.UIStyle.Custom;
            this.txtJobNm.StyleCustomMode = true;
            this.txtJobNm.TabIndex = 133;
            this.txtJobNm.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(173, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 132;
            this.label2.Text = "职位名称";
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnSearch.Location = new System.Drawing.Point(732, 56);
            this.btnSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Radius = 20;
            this.btnSearch.Size = new System.Drawing.Size(100, 35);
            this.btnSearch.TabIndex = 135;
            this.btnSearch.Text = "搜     索";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FrmPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 623);
            this.ControlBox = false;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtJobNm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flpInformation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPosition";
            this.ShowIcon = true;
            this.ShowTitleIcon = true;
            this.Text = "职位类型维护";
            this.Load += new System.EventHandler(this.FrmPosition_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpInformation;
        private Sunny.UI.UIButton btnAdd;
        private Sunny.UI.UITextBox txtJobNm;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UIButton btnSearch;
    }
}