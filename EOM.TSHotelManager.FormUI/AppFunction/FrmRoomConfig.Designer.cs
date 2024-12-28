namespace EOM.TSHotelManager.FormUI.AppFunction
{
    partial class FrmRoomConfig
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRoomConfig));
            this.btnDeleteRoomType = new Sunny.UI.UIButton();
            this.btnUpdateRoomType = new Sunny.UI.UIButton();
            this.btnAddRoomType = new Sunny.UI.UIButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRoomTypeName = new Sunny.UI.UITextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtRoomTypeId = new Sunny.UI.UITextBox();
            this.dgvRoomTypeList = new Sunny.UI.UIDataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dudRent = new Sunny.UI.UIDoubleUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.dudDeposit = new Sunny.UI.UIDoubleUpDown();
            this.clRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRoomTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRoomRent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRoomDeposit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDeleteMk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDeleteMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomTypeList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteRoomType
            // 
            this.btnDeleteRoomType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteRoomType.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnDeleteRoomType.Location = new System.Drawing.Point(821, 519);
            this.btnDeleteRoomType.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDeleteRoomType.Name = "btnDeleteRoomType";
            this.btnDeleteRoomType.Radius = 20;
            this.btnDeleteRoomType.Size = new System.Drawing.Size(165, 33);
            this.btnDeleteRoomType.TabIndex = 206;
            this.btnDeleteRoomType.Text = "删除状态";
            this.btnDeleteRoomType.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDeleteRoomType.Click += new System.EventHandler(this.btnDeleteRoomType_Click);
            // 
            // btnUpdateRoomType
            // 
            this.btnUpdateRoomType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateRoomType.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnUpdateRoomType.Location = new System.Drawing.Point(821, 470);
            this.btnUpdateRoomType.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnUpdateRoomType.Name = "btnUpdateRoomType";
            this.btnUpdateRoomType.Radius = 20;
            this.btnUpdateRoomType.Size = new System.Drawing.Size(165, 33);
            this.btnUpdateRoomType.TabIndex = 205;
            this.btnUpdateRoomType.Text = "更新状态";
            this.btnUpdateRoomType.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdateRoomType.Click += new System.EventHandler(this.btnUpdateRoomType_Click);
            // 
            // btnAddRoomType
            // 
            this.btnAddRoomType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRoomType.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnAddRoomType.Location = new System.Drawing.Point(821, 421);
            this.btnAddRoomType.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAddRoomType.Name = "btnAddRoomType";
            this.btnAddRoomType.Radius = 20;
            this.btnAddRoomType.Size = new System.Drawing.Size(165, 33);
            this.btnAddRoomType.TabIndex = 204;
            this.btnAddRoomType.Text = "新增状态";
            this.btnAddRoomType.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddRoomType.Click += new System.EventHandler(this.btnAddRoomType_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(859, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 19);
            this.label7.TabIndex = 203;
            this.label7.Text = "状态描述";
            // 
            // txtRoomTypeName
            // 
            this.txtRoomTypeName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomTypeName.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRoomTypeName.Location = new System.Drawing.Point(821, 204);
            this.txtRoomTypeName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoomTypeName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtRoomTypeName.Name = "txtRoomTypeName";
            this.txtRoomTypeName.Padding = new System.Windows.Forms.Padding(5);
            this.txtRoomTypeName.Radius = 20;
            this.txtRoomTypeName.ShowText = false;
            this.txtRoomTypeName.Size = new System.Drawing.Size(165, 29);
            this.txtRoomTypeName.Style = Sunny.UI.UIStyle.Custom;
            this.txtRoomTypeName.StyleCustomMode = true;
            this.txtRoomTypeName.TabIndex = 202;
            this.txtRoomTypeName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtRoomTypeName.Watermark = "";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(859, 89);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(85, 19);
            this.label20.TabIndex = 201;
            this.label20.Text = "状态编码";
            // 
            // txtRoomTypeId
            // 
            this.txtRoomTypeId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomTypeId.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRoomTypeId.Location = new System.Drawing.Point(821, 124);
            this.txtRoomTypeId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoomTypeId.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtRoomTypeId.Name = "txtRoomTypeId";
            this.txtRoomTypeId.Padding = new System.Windows.Forms.Padding(5);
            this.txtRoomTypeId.Radius = 20;
            this.txtRoomTypeId.ShowText = false;
            this.txtRoomTypeId.Size = new System.Drawing.Size(165, 29);
            this.txtRoomTypeId.Style = Sunny.UI.UIStyle.Custom;
            this.txtRoomTypeId.StyleCustomMode = true;
            this.txtRoomTypeId.TabIndex = 200;
            this.txtRoomTypeId.Text = "0";
            this.txtRoomTypeId.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtRoomTypeId.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.txtRoomTypeId.Watermark = "";
            // 
            // dgvRoomTypeList
            // 
            this.dgvRoomTypeList.AllowUserToAddRows = false;
            this.dgvRoomTypeList.AllowUserToDeleteRows = false;
            this.dgvRoomTypeList.AllowUserToResizeColumns = false;
            this.dgvRoomTypeList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvRoomTypeList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRoomTypeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoomTypeList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvRoomTypeList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoomTypeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRoomTypeList.ColumnHeadersHeight = 32;
            this.dgvRoomTypeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRoomTypeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clRoomType,
            this.clRoomTypeName,
            this.clRoomRent,
            this.clRoomDeposit,
            this.clDeleteMk,
            this.clDeleteMark,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRoomTypeList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRoomTypeList.EnableHeadersVisualStyles = false;
            this.dgvRoomTypeList.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgvRoomTypeList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvRoomTypeList.Location = new System.Drawing.Point(3, 38);
            this.dgvRoomTypeList.MultiSelect = false;
            this.dgvRoomTypeList.Name = "dgvRoomTypeList";
            this.dgvRoomTypeList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoomTypeList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRoomTypeList.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvRoomTypeList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRoomTypeList.RowTemplate.Height = 29;
            this.dgvRoomTypeList.SelectedIndex = -1;
            this.dgvRoomTypeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoomTypeList.Size = new System.Drawing.Size(788, 582);
            this.dgvRoomTypeList.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvRoomTypeList.TabIndex = 199;
            this.dgvRoomTypeList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRoomTypeList_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(859, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 208;
            this.label1.Text = "租金配置";
            // 
            // dudRent
            // 
            this.dudRent.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.dudRent.Location = new System.Drawing.Point(821, 284);
            this.dudRent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dudRent.MinimumSize = new System.Drawing.Size(100, 0);
            this.dudRent.Name = "dudRent";
            this.dudRent.Radius = 20;
            this.dudRent.ShowText = false;
            this.dudRent.Size = new System.Drawing.Size(165, 35);
            this.dudRent.Step = 1D;
            this.dudRent.TabIndex = 209;
            this.dudRent.Text = null;
            this.dudRent.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(859, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 210;
            this.label2.Text = "押金配置";
            // 
            // dudDeposit
            // 
            this.dudDeposit.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.dudDeposit.Location = new System.Drawing.Point(821, 370);
            this.dudDeposit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dudDeposit.MinimumSize = new System.Drawing.Size(100, 0);
            this.dudDeposit.Name = "dudDeposit";
            this.dudDeposit.Radius = 20;
            this.dudDeposit.ShowText = false;
            this.dudDeposit.Size = new System.Drawing.Size(165, 35);
            this.dudDeposit.Step = 1D;
            this.dudDeposit.TabIndex = 211;
            this.dudDeposit.Text = null;
            this.dudDeposit.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clRoomType
            // 
            this.clRoomType.DataPropertyName = "Roomtype";
            this.clRoomType.HeaderText = "状态编码";
            this.clRoomType.Name = "clRoomType";
            this.clRoomType.ReadOnly = true;
            // 
            // clRoomTypeName
            // 
            this.clRoomTypeName.DataPropertyName = "RoomName";
            this.clRoomTypeName.HeaderText = "状态描述";
            this.clRoomTypeName.Name = "clRoomTypeName";
            this.clRoomTypeName.ReadOnly = true;
            // 
            // clRoomRent
            // 
            this.clRoomRent.DataPropertyName = "RoomRent";
            this.clRoomRent.HeaderText = "租金";
            this.clRoomRent.Name = "clRoomRent";
            this.clRoomRent.ReadOnly = true;
            // 
            // clRoomDeposit
            // 
            this.clRoomDeposit.DataPropertyName = "RoomDeposit";
            this.clRoomDeposit.HeaderText = "押金";
            this.clRoomDeposit.Name = "clRoomDeposit";
            this.clRoomDeposit.ReadOnly = true;
            // 
            // clDeleteMk
            // 
            this.clDeleteMk.DataPropertyName = "DeleteMkNm";
            this.clDeleteMk.HeaderText = "删除标记";
            this.clDeleteMk.Name = "clDeleteMk";
            this.clDeleteMk.ReadOnly = true;
            // 
            // clDeleteMark
            // 
            this.clDeleteMark.DataPropertyName = "delete_mk";
            this.clDeleteMark.HeaderText = "Column1";
            this.clDeleteMark.Name = "clDeleteMark";
            this.clDeleteMark.ReadOnly = true;
            this.clDeleteMark.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "datains_usr";
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "datains_date";
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "datachg_usr";
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "datachg_date";
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // FrmRoomConfig
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1005, 623);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dudDeposit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteRoomType);
            this.Controls.Add(this.dudRent);
            this.Controls.Add(this.btnUpdateRoomType);
            this.Controls.Add(this.btnAddRoomType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRoomTypeName);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtRoomTypeId);
            this.Controls.Add(this.dgvRoomTypeList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRoomConfig";
            this.ShowTitleIcon = true;
            this.Text = "客房配置";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Load += new System.EventHandler(this.FrmRoomConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomTypeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIButton btnDeleteRoomType;
        private Sunny.UI.UIButton btnUpdateRoomType;
        private Sunny.UI.UIButton btnAddRoomType;
        private System.Windows.Forms.Label label7;
        private Sunny.UI.UITextBox txtRoomTypeName;
        private System.Windows.Forms.Label label20;
        private Sunny.UI.UITextBox txtRoomTypeId;
        private Sunny.UI.UIDataGridView dgvRoomTypeList;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UIDoubleUpDown dudRent;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UIDoubleUpDown dudDeposit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRoomTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRoomRent;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRoomDeposit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDeleteMk;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDeleteMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}