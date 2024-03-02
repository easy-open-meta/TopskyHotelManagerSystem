
namespace SYS.FormUI
{
    partial class FrmMySpace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMySpace));
            this.uiTabControlMenu1 = new Sunny.UI.UITabControlMenu();
            this.tpWorkerInfo = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUpdWorker = new Sunny.UI.UIButton();
            this.cbWorkerNation = new Sunny.UI.UIComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboWorkerClub = new Sunny.UI.UIComboBox();
            this.cboWorkerPosition = new Sunny.UI.UIComboBox();
            this.cboSex = new Sunny.UI.UIComboBox();
            this.txtWorkerNo = new Sunny.UI.UITextBox();
            this.txtWorkerName = new Sunny.UI.UITextBox();
            this.txtTel = new Sunny.UI.UITextBox();
            this.txtAddress = new Sunny.UI.UITextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.tpSecurity = new System.Windows.Forms.TabPage();
            this.btnUpdPwd = new Sunny.UI.UIButton();
            this.lblNewMsg = new Sunny.UI.UILabel();
            this.lblOldMsg = new Sunny.UI.UILabel();
            this.lgCheckNewPwd = new Sunny.UI.UILight();
            this.lgCheckOldPwd = new Sunny.UI.UILight();
            this.txtOldPwd = new Sunny.UI.UITextBox();
            this.txtNewPwd = new Sunny.UI.UITextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tpPhoto = new System.Windows.Forms.TabPage();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.picWorkerPic = new System.Windows.Forms.PictureBox();
            this.openPic = new System.Windows.Forms.OpenFileDialog();
            this.uiTabControlMenu1.SuspendLayout();
            this.tpWorkerInfo.SuspendLayout();
            this.tpSecurity.SuspendLayout();
            this.tpPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWorkerPic)).BeginInit();
            this.SuspendLayout();
            // 
            // uiTabControlMenu1
            // 
            this.uiTabControlMenu1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.uiTabControlMenu1.Controls.Add(this.tpWorkerInfo);
            this.uiTabControlMenu1.Controls.Add(this.tpSecurity);
            this.uiTabControlMenu1.Controls.Add(this.tpPhoto);
            this.uiTabControlMenu1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControlMenu1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTabControlMenu1.ItemSize = new System.Drawing.Size(40, 200);
            this.uiTabControlMenu1.Location = new System.Drawing.Point(3, 38);
            this.uiTabControlMenu1.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.uiTabControlMenu1.Multiline = true;
            this.uiTabControlMenu1.Name = "uiTabControlMenu1";
            this.uiTabControlMenu1.SelectedIndex = 0;
            this.uiTabControlMenu1.Size = new System.Drawing.Size(867, 546);
            this.uiTabControlMenu1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControlMenu1.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiTabControlMenu1.TabIndex = 14;
            this.uiTabControlMenu1.TabSelectedColor = System.Drawing.Color.Snow;
            // 
            // tpWorkerInfo
            // 
            this.tpWorkerInfo.Controls.Add(this.label7);
            this.tpWorkerInfo.Controls.Add(this.btnUpdWorker);
            this.tpWorkerInfo.Controls.Add(this.cbWorkerNation);
            this.tpWorkerInfo.Controls.Add(this.label1);
            this.tpWorkerInfo.Controls.Add(this.cboWorkerClub);
            this.tpWorkerInfo.Controls.Add(this.cboWorkerPosition);
            this.tpWorkerInfo.Controls.Add(this.cboSex);
            this.tpWorkerInfo.Controls.Add(this.txtWorkerNo);
            this.tpWorkerInfo.Controls.Add(this.txtWorkerName);
            this.tpWorkerInfo.Controls.Add(this.txtTel);
            this.tpWorkerInfo.Controls.Add(this.txtAddress);
            this.tpWorkerInfo.Controls.Add(this.label2);
            this.tpWorkerInfo.Controls.Add(this.label5);
            this.tpWorkerInfo.Controls.Add(this.label16);
            this.tpWorkerInfo.Controls.Add(this.label30);
            this.tpWorkerInfo.Controls.Add(this.label31);
            this.tpWorkerInfo.Controls.Add(this.label32);
            this.tpWorkerInfo.Location = new System.Drawing.Point(201, 0);
            this.tpWorkerInfo.Name = "tpWorkerInfo";
            this.tpWorkerInfo.Size = new System.Drawing.Size(666, 546);
            this.tpWorkerInfo.TabIndex = 1;
            this.tpWorkerInfo.Text = "个人信息";
            this.tpWorkerInfo.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(26, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 25);
            this.label7.TabIndex = 131;
            this.label7.Text = "联系方式";
            // 
            // btnUpdWorker
            // 
            this.btnUpdWorker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdWorker.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnUpdWorker.Location = new System.Drawing.Point(530, 267);
            this.btnUpdWorker.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnUpdWorker.Name = "btnUpdWorker";
            this.btnUpdWorker.Radius = 20;
            this.btnUpdWorker.Size = new System.Drawing.Size(109, 42);
            this.btnUpdWorker.TabIndex = 130;
            this.btnUpdWorker.Text = "修    改";
            this.btnUpdWorker.Click += new System.EventHandler(this.btnUpdWorker_Click);
            // 
            // cbWorkerNation
            // 
            this.cbWorkerNation.DataSource = null;
            this.cbWorkerNation.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbWorkerNation.FillColor = System.Drawing.Color.White;
            this.cbWorkerNation.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.cbWorkerNation.Location = new System.Drawing.Point(434, 113);
            this.cbWorkerNation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbWorkerNation.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbWorkerNation.Name = "cbWorkerNation";
            this.cbWorkerNation.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbWorkerNation.Radius = 20;
            this.cbWorkerNation.Size = new System.Drawing.Size(203, 35);
            this.cbWorkerNation.Style = Sunny.UI.UIStyle.Custom;
            this.cbWorkerNation.TabIndex = 129;
            this.cbWorkerNation.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbWorkerNation.SelectedIndexChanged += new System.EventHandler(this.cbWorkerNation_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(337, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 128;
            this.label1.Text = "民      族";
            // 
            // cboWorkerClub
            // 
            this.cboWorkerClub.DataSource = null;
            this.cboWorkerClub.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cboWorkerClub.FillColor = System.Drawing.Color.White;
            this.cboWorkerClub.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.cboWorkerClub.Location = new System.Drawing.Point(435, 9);
            this.cboWorkerClub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboWorkerClub.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboWorkerClub.Name = "cboWorkerClub";
            this.cboWorkerClub.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboWorkerClub.Radius = 20;
            this.cboWorkerClub.ReadOnly = true;
            this.cboWorkerClub.Size = new System.Drawing.Size(203, 35);
            this.cboWorkerClub.Style = Sunny.UI.UIStyle.Custom;
            this.cboWorkerClub.TabIndex = 125;
            this.cboWorkerClub.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboWorkerClub.Watermark = "";
            // 
            // cboWorkerPosition
            // 
            this.cboWorkerPosition.DataSource = null;
            this.cboWorkerPosition.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cboWorkerPosition.FillColor = System.Drawing.Color.White;
            this.cboWorkerPosition.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.cboWorkerPosition.Location = new System.Drawing.Point(435, 61);
            this.cboWorkerPosition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboWorkerPosition.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboWorkerPosition.Name = "cboWorkerPosition";
            this.cboWorkerPosition.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboWorkerPosition.Radius = 20;
            this.cboWorkerPosition.ReadOnly = true;
            this.cboWorkerPosition.Size = new System.Drawing.Size(203, 35);
            this.cboWorkerPosition.Style = Sunny.UI.UIStyle.Custom;
            this.cboWorkerPosition.TabIndex = 124;
            this.cboWorkerPosition.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboSex
            // 
            this.cboSex.DataSource = null;
            this.cboSex.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cboSex.FillColor = System.Drawing.Color.White;
            this.cboSex.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.cboSex.Location = new System.Drawing.Point(123, 113);
            this.cboSex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboSex.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboSex.Name = "cboSex";
            this.cboSex.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboSex.Radius = 20;
            this.cboSex.Size = new System.Drawing.Size(203, 35);
            this.cboSex.Style = Sunny.UI.UIStyle.Custom;
            this.cboSex.TabIndex = 123;
            this.cboSex.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtWorkerNo
            // 
            this.txtWorkerNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWorkerNo.FillColor = System.Drawing.Color.White;
            this.txtWorkerNo.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtWorkerNo.Location = new System.Drawing.Point(124, 9);
            this.txtWorkerNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWorkerNo.Maximum = 2147483647D;
            this.txtWorkerNo.Minimum = -2147483648D;
            this.txtWorkerNo.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtWorkerNo.Name = "txtWorkerNo";
            this.txtWorkerNo.Padding = new System.Windows.Forms.Padding(5);
            this.txtWorkerNo.Radius = 20;
            this.txtWorkerNo.ReadOnly = true;
            this.txtWorkerNo.Size = new System.Drawing.Size(203, 35);
            this.txtWorkerNo.Style = Sunny.UI.UIStyle.Custom;
            this.txtWorkerNo.StyleCustomMode = true;
            this.txtWorkerNo.TabIndex = 122;
            this.txtWorkerNo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtWorkerName
            // 
            this.txtWorkerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWorkerName.FillColor = System.Drawing.Color.White;
            this.txtWorkerName.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtWorkerName.Location = new System.Drawing.Point(124, 61);
            this.txtWorkerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWorkerName.Maximum = 2147483647D;
            this.txtWorkerName.Minimum = -2147483648D;
            this.txtWorkerName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtWorkerName.Name = "txtWorkerName";
            this.txtWorkerName.Padding = new System.Windows.Forms.Padding(5);
            this.txtWorkerName.Radius = 20;
            this.txtWorkerName.Size = new System.Drawing.Size(203, 35);
            this.txtWorkerName.Style = Sunny.UI.UIStyle.Custom;
            this.txtWorkerName.StyleCustomMode = true;
            this.txtWorkerName.TabIndex = 121;
            this.txtWorkerName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTel
            // 
            this.txtTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTel.FillColor = System.Drawing.Color.White;
            this.txtTel.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTel.Location = new System.Drawing.Point(124, 161);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTel.Maximum = 2147483647D;
            this.txtTel.Minimum = -2147483648D;
            this.txtTel.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtTel.Name = "txtTel";
            this.txtTel.Padding = new System.Windows.Forms.Padding(5);
            this.txtTel.Radius = 20;
            this.txtTel.Size = new System.Drawing.Size(515, 35);
            this.txtTel.Style = Sunny.UI.UIStyle.Custom;
            this.txtTel.StyleCustomMode = true;
            this.txtTel.TabIndex = 119;
            this.txtTel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTel.Watermark = "";
            // 
            // txtAddress
            // 
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.FillColor = System.Drawing.Color.White;
            this.txtAddress.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAddress.Location = new System.Drawing.Point(124, 213);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Maximum = 2147483647D;
            this.txtAddress.Minimum = -2147483648D;
            this.txtAddress.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Padding = new System.Windows.Forms.Padding(5);
            this.txtAddress.Radius = 20;
            this.txtAddress.Size = new System.Drawing.Size(515, 35);
            this.txtAddress.Style = Sunny.UI.UIStyle.Custom;
            this.txtAddress.StyleCustomMode = true;
            this.txtAddress.TabIndex = 117;
            this.txtAddress.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(26, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 115;
            this.label2.Text = "居住地址";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(337, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 112;
            this.label5.Text = "现任职位";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(337, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 25);
            this.label16.TabIndex = 111;
            this.label16.Text = "所在部门";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label30.Location = new System.Drawing.Point(26, 116);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(86, 25);
            this.label30.TabIndex = 109;
            this.label30.Text = "性      别";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label31.Location = new System.Drawing.Point(26, 66);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(88, 25);
            this.label31.TabIndex = 108;
            this.label31.Text = "员工姓名";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label32.Location = new System.Drawing.Point(26, 15);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(88, 25);
            this.label32.TabIndex = 107;
            this.label32.Text = "员工编号";
            // 
            // tpSecurity
            // 
            this.tpSecurity.Controls.Add(this.btnUpdPwd);
            this.tpSecurity.Controls.Add(this.lblNewMsg);
            this.tpSecurity.Controls.Add(this.lblOldMsg);
            this.tpSecurity.Controls.Add(this.lgCheckNewPwd);
            this.tpSecurity.Controls.Add(this.lgCheckOldPwd);
            this.tpSecurity.Controls.Add(this.txtOldPwd);
            this.tpSecurity.Controls.Add(this.txtNewPwd);
            this.tpSecurity.Controls.Add(this.label4);
            this.tpSecurity.Controls.Add(this.label6);
            this.tpSecurity.Location = new System.Drawing.Point(201, 0);
            this.tpSecurity.Name = "tpSecurity";
            this.tpSecurity.Size = new System.Drawing.Size(666, 546);
            this.tpSecurity.TabIndex = 2;
            this.tpSecurity.Text = "账号安全";
            this.tpSecurity.UseVisualStyleBackColor = true;
            this.tpSecurity.Click += new System.EventHandler(this.tpSecurity_Click);
            // 
            // btnUpdPwd
            // 
            this.btnUpdPwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdPwd.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnUpdPwd.Location = new System.Drawing.Point(244, 260);
            this.btnUpdPwd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnUpdPwd.Name = "btnUpdPwd";
            this.btnUpdPwd.Radius = 20;
            this.btnUpdPwd.Size = new System.Drawing.Size(175, 42);
            this.btnUpdPwd.TabIndex = 131;
            this.btnUpdPwd.Text = "修    改";
            this.btnUpdPwd.Click += new System.EventHandler(this.btnUpdPwd_Click);
            // 
            // lblNewMsg
            // 
            this.lblNewMsg.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblNewMsg.Location = new System.Drawing.Point(209, 196);
            this.lblNewMsg.Name = "lblNewMsg";
            this.lblNewMsg.Size = new System.Drawing.Size(267, 23);
            this.lblNewMsg.Style = Sunny.UI.UIStyle.Custom;
            this.lblNewMsg.TabIndex = 130;
            this.lblNewMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOldMsg
            // 
            this.lblOldMsg.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblOldMsg.Location = new System.Drawing.Point(209, 105);
            this.lblOldMsg.Name = "lblOldMsg";
            this.lblOldMsg.Size = new System.Drawing.Size(267, 23);
            this.lblOldMsg.Style = Sunny.UI.UIStyle.Custom;
            this.lblOldMsg.TabIndex = 129;
            this.lblOldMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lgCheckNewPwd
            // 
            this.lgCheckNewPwd.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.lgCheckNewPwd.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lgCheckNewPwd.Location = new System.Drawing.Point(499, 144);
            this.lgCheckNewPwd.MinimumSize = new System.Drawing.Size(1, 1);
            this.lgCheckNewPwd.Name = "lgCheckNewPwd";
            this.lgCheckNewPwd.OnCenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.lgCheckNewPwd.Radius = 35;
            this.lgCheckNewPwd.Size = new System.Drawing.Size(35, 35);
            this.lgCheckNewPwd.TabIndex = 128;
            this.lgCheckNewPwd.Text = "uiLight2";
            this.lgCheckNewPwd.Visible = false;
            // 
            // lgCheckOldPwd
            // 
            this.lgCheckOldPwd.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.lgCheckOldPwd.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lgCheckOldPwd.Location = new System.Drawing.Point(499, 56);
            this.lgCheckOldPwd.MinimumSize = new System.Drawing.Size(1, 1);
            this.lgCheckOldPwd.Name = "lgCheckOldPwd";
            this.lgCheckOldPwd.OnCenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.lgCheckOldPwd.Radius = 35;
            this.lgCheckOldPwd.Size = new System.Drawing.Size(35, 35);
            this.lgCheckOldPwd.TabIndex = 127;
            this.lgCheckOldPwd.Text = "uiLight1";
            this.lgCheckOldPwd.Visible = false;
            // 
            // txtOldPwd
            // 
            this.txtOldPwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOldPwd.FillColor = System.Drawing.Color.White;
            this.txtOldPwd.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOldPwd.Location = new System.Drawing.Point(204, 56);
            this.txtOldPwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOldPwd.Maximum = 2147483647D;
            this.txtOldPwd.Minimum = -2147483648D;
            this.txtOldPwd.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtOldPwd.Name = "txtOldPwd";
            this.txtOldPwd.Padding = new System.Windows.Forms.Padding(5);
            this.txtOldPwd.PasswordChar = '*';
            this.txtOldPwd.Radius = 20;
            this.txtOldPwd.Size = new System.Drawing.Size(272, 35);
            this.txtOldPwd.Style = Sunny.UI.UIStyle.Custom;
            this.txtOldPwd.StyleCustomMode = true;
            this.txtOldPwd.TabIndex = 126;
            this.txtOldPwd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtOldPwd.Validated += new System.EventHandler(this.txtOldPwd_Validated);
            this.txtOldPwd.TextChanged += new System.EventHandler(this.txtOldPwd_TextChanged);
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPwd.FillColor = System.Drawing.Color.White;
            this.txtNewPwd.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNewPwd.Location = new System.Drawing.Point(204, 144);
            this.txtNewPwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNewPwd.Maximum = 2147483647D;
            this.txtNewPwd.Minimum = -2147483648D;
            this.txtNewPwd.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.Padding = new System.Windows.Forms.Padding(5);
            this.txtNewPwd.PasswordChar = '*';
            this.txtNewPwd.Radius = 20;
            this.txtNewPwd.Size = new System.Drawing.Size(272, 35);
            this.txtNewPwd.Style = Sunny.UI.UIStyle.Custom;
            this.txtNewPwd.StyleCustomMode = true;
            this.txtNewPwd.TabIndex = 125;
            this.txtNewPwd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtNewPwd.Validated += new System.EventHandler(this.txtNewPwd_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(128, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 124;
            this.label4.Text = "新密码";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(128, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 123;
            this.label6.Text = "旧密码";
            // 
            // tpPhoto
            // 
            this.tpPhoto.Controls.Add(this.uiLabel1);
            this.tpPhoto.Controls.Add(this.picWorkerPic);
            this.tpPhoto.Location = new System.Drawing.Point(201, 0);
            this.tpPhoto.Name = "tpPhoto";
            this.tpPhoto.Size = new System.Drawing.Size(666, 546);
            this.tpPhoto.TabIndex = 3;
            this.tpPhoto.Text = "我的头像";
            this.tpPhoto.UseVisualStyleBackColor = true;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.Red;
            this.uiLabel1.Location = new System.Drawing.Point(128, 400);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(410, 23);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 57;
            this.uiLabel1.Text = "点击上方头像框即可更换头像，记得不要超过2MB哦~";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picWorkerPic
            // 
            this.picWorkerPic.BackColor = System.Drawing.Color.Transparent;
            this.picWorkerPic.BackgroundImage = global::SYS.FormUI.Properties.Resources.上传照片;
            this.picWorkerPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picWorkerPic.Location = new System.Drawing.Point(250, 35);
            this.picWorkerPic.Name = "picWorkerPic";
            this.picWorkerPic.Size = new System.Drawing.Size(167, 211);
            this.picWorkerPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWorkerPic.TabIndex = 56;
            this.picWorkerPic.TabStop = false;
            this.picWorkerPic.Click += new System.EventHandler(this.picWorkerPic_Click);
            // 
            // openPic
            // 
            this.openPic.FileName = "openFileDialog1";
            this.openPic.Filter = "PNG文件|*.png|JPG文件|*.jpg|位图文件|*.bmp";
            this.openPic.FileOk += new System.ComponentModel.CancelEventHandler(this.openPic_FileOk);
            // 
            // FrmMySpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 587);
            this.Controls.Add(this.uiTabControlMenu1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMySpace";
            this.ShowIcon = true;
            this.ShowTitleIcon = true;
            this.Text = "个人中心";
            this.Load += new System.EventHandler(this.FrmMySpace_Load);
            this.uiTabControlMenu1.ResumeLayout(false);
            this.tpWorkerInfo.ResumeLayout(false);
            this.tpWorkerInfo.PerformLayout();
            this.tpSecurity.ResumeLayout(false);
            this.tpSecurity.PerformLayout();
            this.tpPhoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picWorkerPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITabControlMenu uiTabControlMenu1;
        private System.Windows.Forms.TabPage tpWorkerInfo;
        private Sunny.UI.UIComboBox cbWorkerNation;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UIComboBox cboWorkerClub;
        private Sunny.UI.UIComboBox cboWorkerPosition;
        private Sunny.UI.UIComboBox cboSex;
        private Sunny.UI.UITextBox txtWorkerNo;
        private Sunny.UI.UITextBox txtWorkerName;
        private Sunny.UI.UITextBox txtTel;
        private Sunny.UI.UITextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TabPage tpSecurity;
        private Sunny.UI.UITextBox txtOldPwd;
        private Sunny.UI.UITextBox txtNewPwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private Sunny.UI.UIButton btnUpdWorker;
        private Sunny.UI.UILight lgCheckNewPwd;
        private Sunny.UI.UILight lgCheckOldPwd;
        private Sunny.UI.UILabel lblOldMsg;
        private Sunny.UI.UILabel lblNewMsg;
        private Sunny.UI.UIButton btnUpdPwd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tpPhoto;
        private Sunny.UI.UILabel uiLabel1;
        private System.Windows.Forms.PictureBox picWorkerPic;
        private System.Windows.Forms.OpenFileDialog openPic;
    }
}