namespace SYS.FormUI
{
    partial class FrmChangeRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChangeRoom));
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.cboRoomList = new Sunny.UI.UIComboBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.lblRoomType = new Sunny.UI.UILabel();
            this.btnChangeRoom = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(15, 54);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(202, 28);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 6;
            this.uiLabel1.Text = "请选择需要转换的新房间：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboRoomList
            // 
            this.cboRoomList.DataSource = null;
            this.cboRoomList.FillColor = System.Drawing.Color.White;
            this.cboRoomList.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cboRoomList.Location = new System.Drawing.Point(208, 55);
            this.cboRoomList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboRoomList.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboRoomList.Name = "cboRoomList";
            this.cboRoomList.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboRoomList.Radius = 15;
            this.cboRoomList.Size = new System.Drawing.Size(150, 29);
            this.cboRoomList.Style = Sunny.UI.UIStyle.Custom;
            this.cboRoomList.TabIndex = 7;
            this.cboRoomList.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboRoomList.TextChanged += new System.EventHandler(this.cboRoomList_TextChanged);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(15, 96);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(183, 28);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 8;
            this.uiLabel2.Text = "新  房  间  类  型  为：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRoomType
            // 
            this.lblRoomType.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblRoomType.Location = new System.Drawing.Point(208, 96);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(150, 28);
            this.lblRoomType.Style = Sunny.UI.UIStyle.Custom;
            this.lblRoomType.TabIndex = 9;
            this.lblRoomType.Text = "新  房  间  类  型";
            this.lblRoomType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnChangeRoom
            // 
            this.btnChangeRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeRoom.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnChangeRoom.Location = new System.Drawing.Point(133, 138);
            this.btnChangeRoom.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnChangeRoom.Name = "btnChangeRoom";
            this.btnChangeRoom.Radius = 15;
            this.btnChangeRoom.Size = new System.Drawing.Size(107, 40);
            this.btnChangeRoom.Style = Sunny.UI.UIStyle.Custom;
            this.btnChangeRoom.TabIndex = 10;
            this.btnChangeRoom.Text = "转    房";
            this.btnChangeRoom.Click += new System.EventHandler(this.btnChangeRoom_Click);
            // 
            // FrmChangeRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(372, 198);
            this.Controls.Add(this.btnChangeRoom);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.cboRoomList);
            this.Controls.Add(this.uiLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmChangeRoom";
            this.ShowIcon = true;
            this.ShowTitleIcon = true;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "转换房间";
            this.Load += new System.EventHandler(this.FrmChangeRoom_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIComboBox cboRoomList;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel lblRoomType;
        private Sunny.UI.UIButton btnChangeRoom;
    }
}