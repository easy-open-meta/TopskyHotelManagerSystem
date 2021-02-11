
namespace SYS.FormUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvNoticeList = new System.Windows.Forms.DataGridView();
            this.clNoticeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNoticetheme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNoticeContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoticeList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNoticeList
            // 
            this.dgvNoticeList.AllowUserToAddRows = false;
            this.dgvNoticeList.AllowUserToDeleteRows = false;
            this.dgvNoticeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNoticeList.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgvNoticeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNoticeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clNoticeNo,
            this.clNoticetheme,
            this.clNoticeContent});
            this.dgvNoticeList.Location = new System.Drawing.Point(216, 54);
            this.dgvNoticeList.Name = "dgvNoticeList";
            this.dgvNoticeList.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvNoticeList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNoticeList.RowTemplate.Height = 23;
            this.dgvNoticeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNoticeList.Size = new System.Drawing.Size(368, 456);
            this.dgvNoticeList.TabIndex = 111;
            // 
            // clNoticeNo
            // 
            this.clNoticeNo.DataPropertyName = "NoticeNo";
            this.clNoticeNo.HeaderText = "公告编号";
            this.clNoticeNo.Name = "clNoticeNo";
            this.clNoticeNo.ReadOnly = true;
            // 
            // clNoticetheme
            // 
            this.clNoticetheme.DataPropertyName = "Noticetheme";
            this.clNoticetheme.HeaderText = "公告主题";
            this.clNoticetheme.Name = "clNoticetheme";
            this.clNoticetheme.ReadOnly = true;
            // 
            // clNoticeContent
            // 
            this.clNoticeContent.DataPropertyName = "NoticeContent";
            this.clNoticeContent.HeaderText = "公告正文";
            this.clNoticeContent.Name = "clNoticeContent";
            this.clNoticeContent.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(353, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 33);
            this.label5.TabIndex = 110;
            this.label5.Text = "历史公告";
            // 
            // FrmNotice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 553);
            this.Controls.Add(this.dgvNoticeList);
            this.Controls.Add(this.label5);
            this.Name = "FrmNotice";
            this.Text = "FrmNotice";
            this.Load += new System.EventHandler(this.FrmNotice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoticeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNoticeList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNoticeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNoticetheme;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNoticeContent;
        private System.Windows.Forms.Label label5;
    }
}