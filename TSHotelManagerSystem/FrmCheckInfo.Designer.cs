namespace TSHotelManagerSystem
{
    partial class FrmCheckInfo
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
            this.dgvCheckInfo = new System.Windows.Forms.DataGridView();
            this.clCheckNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCheckClub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCheckProgres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCheckCash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCheckScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCheckPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCheckAdvice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCheckInfo
            // 
            this.dgvCheckInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCheckInfo.BackgroundColor = System.Drawing.Color.White;
            this.dgvCheckInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCheckNo,
            this.clCheckClub,
            this.clCheckProgres,
            this.clCheckCash,
            this.clCheckScore,
            this.clCheckPerson,
            this.clCheckAdvice});
            this.dgvCheckInfo.Location = new System.Drawing.Point(12, 12);
            this.dgvCheckInfo.Name = "dgvCheckInfo";
            this.dgvCheckInfo.RowTemplate.Height = 23;
            this.dgvCheckInfo.Size = new System.Drawing.Size(970, 429);
            this.dgvCheckInfo.TabIndex = 0;
            // 
            // clCheckNo
            // 
            this.clCheckNo.DataPropertyName = "CheckNo";
            this.clCheckNo.HeaderText = "监管编号";
            this.clCheckNo.Name = "clCheckNo";
            // 
            // clCheckClub
            // 
            this.clCheckClub.DataPropertyName = "CheckClub";
            this.clCheckClub.HeaderText = "受监管部门";
            this.clCheckClub.Name = "clCheckClub";
            // 
            // clCheckProgres
            // 
            this.clCheckProgres.DataPropertyName = "CheckProgres";
            this.clCheckProgres.HeaderText = "受监管概述";
            this.clCheckProgres.Name = "clCheckProgres";
            // 
            // clCheckCash
            // 
            this.clCheckCash.DataPropertyName = "CheckCash";
            this.clCheckCash.HeaderText = "受监管交易情况";
            this.clCheckCash.Name = "clCheckCash";
            // 
            // clCheckScore
            // 
            this.clCheckScore.DataPropertyName = "CheckScore";
            this.clCheckScore.HeaderText = "受监管部门得分";
            this.clCheckScore.Name = "clCheckScore";
            // 
            // clCheckPerson
            // 
            this.clCheckPerson.DataPropertyName = "CheckPerson";
            this.clCheckPerson.HeaderText = "监管负责人";
            this.clCheckPerson.Name = "clCheckPerson";
            // 
            // clCheckAdvice
            // 
            this.clCheckAdvice.DataPropertyName = "CheckAdvice";
            this.clCheckAdvice.HeaderText = "监管人建议";
            this.clCheckAdvice.Name = "clCheckAdvice";
            // 
            // FrmCheckInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(994, 453);
            this.Controls.Add(this.dgvCheckInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCheckInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "监管统计情况";
            this.Load += new System.EventHandler(this.FrmCheckInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCheckInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCheckNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCheckClub;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCheckProgres;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCheckCash;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCheckScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCheckPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCheckAdvice;
    }
}