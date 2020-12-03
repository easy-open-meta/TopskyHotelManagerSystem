using System;
using System.Drawing;
using System.Windows.Forms;
using SYS.Manager;
using SYS.Core;
using SYS.FormUI.Properties;

namespace SYS.FormUI
{
    public partial class FrmCheckOutForm : Form
    {
        public static string co_CustoNo;
        public static string co_RoomNo;
        public static string co_CustoName;
        public static string co_CustoBirthday;
        public static string co_CustoSex;
        public static string co_CustoTel;
        public static string co_CustoPassportType;
        public static string co_CustoAddress;
        public static string co_CustoType;
        public static string co_CustoID;
        public static Wti w;

        public FrmCheckOutForm()
        {
            InitializeComponent();
        }




        #region 记录鼠标和窗体坐标的方法
        private Point mouseOld;//鼠标旧坐标
        private Point formOld;//窗体旧坐标 
        #endregion

        #region 记录移动的窗体坐标
        private void FrmCheckOutForm_MouseDown(object sender, MouseEventArgs e)
        {
            formOld = this.Location;
            mouseOld = MousePosition;
        }
        #endregion

        #region 记录窗体移动的坐标
        private void FrmCheckOutForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mouseNew = MousePosition;
                int moveX = mouseNew.X - mouseOld.X;
                int moveY = mouseNew.Y - mouseOld.Y;
                this.Location = new Point(formOld.X + moveX, formOld.Y + moveY);
            }
        }
        #endregion

        public void CmpSetDgv()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSpendList.AllowUserToAddRows = false;
            this.dgvSpendList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            this.dgvSpendList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSpendList.BackgroundColor = System.Drawing.Color.White;
            this.dgvSpendList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSpendList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;//211, 223, 240
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 10, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvSpendList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSpendList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpendList.EnableHeadersVisualStyles = false;
            this.dgvSpendList.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvSpendList.ReadOnly = true;
            this.dgvSpendList.RowHeadersVisible = false;
            this.dgvSpendList.RowTemplate.Height = 23;
            this.dgvSpendList.RowTemplate.ReadOnly = true;
        }

        #region 窗体加载事件
        private void FrmCheckOutForm_Load(object sender, EventArgs e)
        {
            double sum = 0;
            txtCustoNo.Text = ucRoomList.rm_CustoNo;
            CustoNo.Text = ucRoomList.rm_CustoNo;
            txtRoomNo.Text = ucRoomList.rm_RoomNo;
            string rn = txtRoomNo.Text.ToString();
            string rs = rn.Substring(0, 2);

            CmpSetDgv();
            if (ucRoomList.co_CheckTime == null)
            {
                dtpCheckTime.Value = DateTime.Now;
            }
            else
            {
                dtpCheckTime.Value = Convert.ToDateTime(ucRoomList.co_CheckTime);
            }
            if (rs == "BD")
            {
                sum = Convert.ToDouble(Convert.ToString(Convert.ToInt32(RoomManager.DayByRoomNo(txtRoomNo.Text).ToString()) * 300));
            }
            if (rs == "BS")
            {
                sum = Convert.ToDouble(Convert.ToString(Convert.ToInt32(RoomManager.DayByRoomNo(txtRoomNo.Text).ToString()) * 425));
            }
            if (rs == "HD")
            {
                sum = Convert.ToDouble(Convert.ToString(Convert.ToInt32(RoomManager.DayByRoomNo(txtRoomNo.Text).ToString()) * 625));
            }
            if (rs == "HS")
            {
                sum = Convert.ToDouble(Convert.ToString(Convert.ToInt32(RoomManager.DayByRoomNo(txtRoomNo.Text).ToString()) * 660));
            }
            if (rs == "QL")
            {
                sum = Convert.ToDouble(Convert.ToString(Convert.ToInt32(RoomManager.DayByRoomNo(txtRoomNo.Text).ToString()) * 845));
            }
            if (rs == "ZT")
            {
                sum = Convert.ToDouble(Convert.ToString(Convert.ToInt32(RoomManager.DayByRoomNo(txtRoomNo.Text).ToString()) * 1080));
            }
            lblDay.Text = Convert.ToString(Convert.ToInt32(RoomManager.DayByRoomNo(txtRoomNo.Text).ToString()));
            w = new Wti()
            {
                CustoNo = txtCustoNo.Text,
                EndDate = Convert.ToDateTime(DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))),
                PowerUse = Convert.ToDecimal(Convert.ToInt32(RoomManager.DayByRoomNo(txtRoomNo.Text).ToString()) * 3 * 1),
                WaterUse = Convert.ToDecimal(Convert.ToDouble(RoomManager.DayByRoomNo(txtRoomNo.Text).ToString()) * 80 * 0.002),
                RoomNo = txtRoomNo.Text,
                Record = "admin",
                UseDate = Convert.ToDateTime(DateTime.Parse(dtpCheckTime.Text)),
            };

            #region 加载客户信息
            Custo cto = CustoManager.SelectCustoByCustoNo(CustoNo.Text.ToString());
            try
            {
                CustoName.Text = cto.CustoName;
                txtCustoName.Text = cto.CustoName;
                txtTel.Text = cto.CustoTel;
                cboCustoSex.Text = cto.CustoSex == 1 ? "男" : "女";
                cboCustoType.SelectedIndex = cto.CustoType;
                cboPassportType.SelectedIndex = cto.PassportType;
                dtpBirth.Value = cto.CustoBirth;
                txtPassportNum.Text = cto.CustoID;
            }
            catch
            {


            }


            #endregion

            #region 加载消费信息
            string RoomNo = txtRoomNo.Text;
            dgvSpendList.DataSource = SpendManager.SelectSpendInfoRoomNo(RoomNo);
            dgvSpendList.AutoGenerateColumns = false;
            double result = 0;
            if (dgvSpendList.Rows.Count == 0)
            {
                result = 0;
            }
            else
            {
                result = Convert.ToDouble(SpendManager.SelectMoneyByRoomNoAndTime(RoomNo, CustoNo.Text.ToString()));
            }

            #endregion

            if (cboCustoType.Text == "钻石会员")
            {
                double m = result + sum;
                lblGetReceipts.Text = m.ToString();
                lblVIPPrice.Text = Convert.ToString(m * 0.60);
                lblVIP.Text = "六折";
            }
            else if (cboCustoType.Text == "白金会员")
            {

                double m = result + sum;
                lblGetReceipts.Text = m.ToString();
                lblVIPPrice.Text = Convert.ToString(m * 0.80);
                lblVIP.Text = "八折";
            }
            else if (cboCustoType.Text == "黄金会员")
            {
                double m = result + sum;
                lblGetReceipts.Text = m.ToString();
                lblVIPPrice.Text = Convert.ToString(m * 0.90);
                lblVIP.Text = "九折";
            }
            else if (cboCustoType.Text == "普通会员")
            {
                double m = result + sum;
                lblGetReceipts.Text = m.ToString();
                lblVIPPrice.Text = Convert.ToString(m * 0.95);
                lblVIP.Text = "九五折";
            }
            else if (cboCustoType.Text == "普通用户")
            {
                //39525
                double m = result + sum;
                lblGetReceipts.Text = m.ToString();
                lblVIPPrice.Text = Convert.ToString(m);
                lblVIP.Text = "不  打  折";

            }

        }
        #endregion

        #region 关闭
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 实收金额文本框值改变时事件
        private void txtReceipts_TextChanged(object sender, EventArgs e)
        {
            if (txtReceipts.Text != "")
            {
                try
                {
                    double n = Convert.ToDouble(Convert.ToDecimal(txtReceipts.Text));
                    double m = Convert.ToDouble(Convert.ToDecimal(lblGetReceipts.Text));
                    double h = Convert.ToDouble(Convert.ToDecimal(lblVIPPrice.Text));
                    lblChange.Text = Convert.ToString(n - h);
                    if (n >= m)
                    {

                    }
                }
                catch
                {
                    MessageBox.Show("非法输入，请重新输入！", "系统提示",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtReceipts.Clear();
                    txtReceipts.Focus();
                }
            }
            else
            {
                lblChange.Text = "-" + lblGetReceipts.Text;
                return;
            }
        }
        #endregion

        #region 结算按钮点击事件
        private void btnBalance_Click(object sender, EventArgs e)
        {
            if (txtReceipts.Text != "")//判断实收金额是否为空
            {
                Room r = RoomManager.SelectRoomByRoomNo(txtRoomNo.Text);//根据房间编号查询房间信息
                string checktime = r.CheckTime.ToString();//获取入住时间
                if (dgvSpendList.Rows.Count == 0)
                {
                    int n = RoomManager.UpdateRoomByRoomNo(txtRoomNo.Text);
                    if (n > 0)
                    {
                        WtiManager.InsertWtiInfo(w);//添加水电费信息
                        this.Close();
                    }
                    else
                    {
                        return;
                    }
                    MessageBox.Show("结算成功！", "系统提示");
                    FrmRoomManager.Reload();
                    
                    #region 获取添加操作日志所需的信息
                    Operation o = new Operation();
                    o.OperationTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd,HH:mm:ss"));
                    o.Operationlog = LoginInfo.WorkerClub + LoginInfo.WorkerPosition + LoginInfo.WorkerName + "于" + DateTime.Now + "帮助" + txtCustoNo.Text + "进行了退房结算操作！";
                    o.OperationAccount = LoginInfo.WorkerClub + LoginInfo.WorkerPosition + LoginInfo.WorkerName;
                    #endregion
                    OperationManager.InsertOperationLog(o);
                }
                else
                {
                    if (SpendManager.UpdateMoneyState(txtRoomNo.Text, checktime) > 0)
                    {
                        int n = RoomManager.UpdateRoomByRoomNo(txtRoomNo.Text);
                        if (n > 0)
                        {
                            WtiManager.InsertWtiInfo(w);//添加水电费信息
                            this.Close();
                        }
                        else
                        {
                            return;
                        }
                        MessageBox.Show("结算成功！", "系统提示");
                        FrmRoomManager.Reload();
                        #region 获取添加操作日志所需的信息
                        Operation o = new Operation();
                        o.OperationTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd,HH:mm:ss"));
                        o.Operationlog = LoginInfo.WorkerClub + LoginInfo.WorkerPosition + LoginInfo.WorkerName + "于" + DateTime.Now + "帮助" + txtCustoNo.Text + "进行了退房结算操作！";
                        o.OperationAccount = LoginInfo.WorkerClub + LoginInfo.WorkerPosition + LoginInfo.WorkerName;
                        #endregion
                        OperationManager.InsertOperationLog(o);
                    }
                    else
                    {
                        MessageBox.Show("结算失败！", "系统提示");
                    }
                }
            }
            else
            {
                MessageBox.Show("实收金额不能为空！", "系统提示");
            }
        }
        #endregion

        private void btnReceiptsType_Click(object sender, EventArgs e)
        {
            pnlMobile.Visible = true;
            pnlCreditCard.Visible = false;
            btnChangePay.Visible = true;
        }

        private void btnCreditCard_Click(object sender, EventArgs e)
        {
            pnlMobile.Visible = false;
            pnlCreditCard.Visible = true;
            btnChangePay.Visible = false;
        }


        private void btnChangePay_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("请选择支付类型：是:支付宝，否:微信？", "T仔的提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (ret == DialogResult.Yes)
            {
                pnlMobile.BackgroundImage = Resources._1G_Q__21_3JZZCFW68O7NF;
            }
            else
            {
                pnlMobile.BackgroundImage = Resources._1545891726;
            }
        }

        private void txtCardNo_TextChanged(object sender, EventArgs e)
        {
            if (txtCardNo.TextLength == 19 || txtCardNo.TextLength <= 16)
            {
                lblState.Text = "该卡为有效银行卡，可进行消费";
                lblState.ForeColor = Color.Green;
            }
            else
            {
                lblState.Text = "该卡为无效银行卡,不可进行消费";
                lblState.ForeColor = Color.Red;
            }
        }

        private void llbCardReader_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtCardNo.Text = "6212260000000006222";
            lblReaderState.Text = "卡号读取成功且有效，可继续进行结算操作";
            lblReaderState.ForeColor = Color.Green;
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("微软雅黑", 14f, System.Drawing.GraphicsUnit.Pixel);
            SolidBrush brush = new SolidBrush(Color.Black);
            if (e.Index == this.tabControl1.SelectedIndex)
            {
                brush = new SolidBrush(Color.Blue);
            }

            RectangleF rectangle = (RectangleF)(tabControl1.GetTabRect(e.Index));
            RectangleF rectangle2 = new RectangleF(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
            g.FillRectangle(new SolidBrush(SystemColors.ButtonHighlight), rectangle2);
            StringFormat sformat = new StringFormat();
            sformat.LineAlignment = StringAlignment.Center;
            sformat.Alignment = StringAlignment.Center;
            g.DrawString(((TabControl)sender).TabPages[e.Index].Text, font, brush, rectangle2, sformat);
        }
    }
}
