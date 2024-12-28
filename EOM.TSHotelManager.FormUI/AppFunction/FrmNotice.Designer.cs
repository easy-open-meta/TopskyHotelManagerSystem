
namespace EOM.TSHotelManager.FormUI
{
    partial class FrmNotice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotice));
            this.label5 = new System.Windows.Forms.Label();
            this.rtbNoticeContent = new KSharpEditor.KEditor();
            this.dgvNoticeList = new Sunny.UI.UIListBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(38, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 33);
            this.label5.TabIndex = 110;
            this.label5.Text = "历史公告";
            // 
            // rtbNoticeContent
            // 
            this.rtbNoticeContent.Enabled = false;
            this.rtbNoticeContent.Html = "<p>&nbsp;</p>";
            this.rtbNoticeContent.KEditorEventListener = null;
            this.rtbNoticeContent.Location = new System.Drawing.Point(206, 38);
            this.rtbNoticeContent.Name = "rtbNoticeContent";
            this.rtbNoticeContent.Size = new System.Drawing.Size(796, 582);
            this.rtbNoticeContent.TabIndex = 112;
            // 
            // dgvNoticeList
            // 
            this.dgvNoticeList.FillColor = System.Drawing.Color.White;
            this.dgvNoticeList.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgvNoticeList.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.dgvNoticeList.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvNoticeList.Location = new System.Drawing.Point(4, 84);
            this.dgvNoticeList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvNoticeList.MinimumSize = new System.Drawing.Size(1, 1);
            this.dgvNoticeList.Name = "dgvNoticeList";
            this.dgvNoticeList.Padding = new System.Windows.Forms.Padding(2);
            this.dgvNoticeList.ShowText = false;
            this.dgvNoticeList.Size = new System.Drawing.Size(195, 534);
            this.dgvNoticeList.TabIndex = 113;
            this.dgvNoticeList.Text = "uiListBox1";
            this.dgvNoticeList.Click += new System.EventHandler(this.dgvNoticeList_ItemClick);
            // 
            // FrmNotice
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1005, 623);
            this.ControlBox = false;
            this.Controls.Add(this.dgvNoticeList);
            this.Controls.Add(this.rtbNoticeContent);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNotice";
            this.ShowTitleIcon = true;
            this.Text = "历史公告";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 1005, 623);
            this.Load += new System.EventHandler(this.FrmNotice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private KSharpEditor.KEditor rtbNoticeContent;
        private Sunny.UI.UIListBox dgvNoticeList;
    }
}