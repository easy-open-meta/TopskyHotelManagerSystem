using System;
using System.Drawing;
using System.Windows.Forms;
using SYS.Manager;
using SYS.Core;
using SYS.FormUI.Properties;
using System.Collections.Generic;
using Sunny.UI;
using SYS.Application;

namespace SYS.FormUI
{
    public partial class FrmCheckOutForm : UIForm
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

        #region 窗体加载事件
        private void FrmCheckOutForm_Load(object sender, EventArgs e)
        {
            foreach (Control label in this.Controls)
            {
                if (label.GetType().ToString() == "Sunny.UI.UITabControlMenu")
                {
                    label.Font = UI_FontUtil.SetChildControlsFont();
                }
            }
            #region 加载客户类型信息
            List<CustoType> lstSourceGrid = CustoTypeManager.SelectCustoTypesAll();
            this.cboCustoType.DataSource = lstSourceGrid;
            this.cboCustoType.DisplayMember = "TypeName";
            this.cboCustoType.ValueMember = "UserType";
            this.cboCustoType.SelectedIndex = 0;
            this.cboCustoType.ReadOnly = true;
            #endregion

            #region 加载证件类型信息
            List<PassPortType> passPorts = CustoTypeManager.SelectPassPortTypeAll();
            this.cboPassportType.DataSource = passPorts;
            this.cboPassportType.DisplayMember = "PassportName";
            this.cboPassportType.ValueMember = "PassportId";
            this.cboPassportType.SelectedIndex = 0;
            #endregion

            #region 加载性别信息
            List<SexType> listSexType = new BaseService().SelectSexTypeAll();
            this.cboCustoSex.DataSource = listSexType;
            this.cboCustoSex.DisplayMember = "sexName";
            this.cboCustoSex.ValueMember = "sexId";
            this.cboCustoSex.SelectedIndex = 0;
            #endregion

            double sum = 0;
            txtCustoNo.Text = ucRoomList.rm_CustoNo;
            CustoNo.Text = ucRoomList.rm_CustoNo;
            txtRoomNo.Text = ucRoomList.rm_RoomNo;
            string rn = txtRoomNo.Text.ToString();
            string rs = rn.Substring(0, 2);

            if (ucRoomList.co_CheckTime == null)
            {
                dtpCheckTime.Text = DateTime.Now.ToString("yyyy年MM月dd日");
            }
            else
            {
                dtpCheckTime.Text = Convert.ToDateTime(ucRoomList.co_CheckTime).ToString("yyyy年MM月dd日");
            }
            if (rs == "BD")
            {
                sum = Convert.ToDouble(Convert.ToString(Convert.ToInt32(new RoomService().DayByRoomNo(txtRoomNo.Text).ToString()) * 300));
            }
            if (rs == "BS")
            {
                sum = Convert.ToDouble(Convert.ToString(Convert.ToInt32(new RoomService().DayByRoomNo(txtRoomNo.Text).ToString()) * 425));
            }
            if (rs == "HD")
            {
                sum = Convert.ToDouble(Convert.ToString(Convert.ToInt32(new RoomService().DayByRoomNo(txtRoomNo.Text).ToString()) * 625));
            }
            if (rs == "HS")
            {
                sum = Convert.ToDouble(Convert.ToString(Convert.ToInt32(new RoomService().DayByRoomNo(txtRoomNo.Text).ToString()) * 660));
            }
            if (rs == "QL")
            {
                sum = Convert.ToDouble(Convert.ToString(Convert.ToInt32(new RoomService().DayByRoomNo(txtRoomNo.Text).ToString()) * 845));
            }
            if (rs == "ZT")
            {
                sum = Convert.ToDouble(Convert.ToString(Convert.ToInt32(new RoomService().DayByRoomNo(txtRoomNo.Text).ToString()) * 1080));
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
                cboCustoSex.SelectedIndex = cto.CustoSex;
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

            #region 加载水电费信息
            var listWti = WtiManager.SelectWtiInfoAll();
            dgvWti.DataSource = listWti;
            dgvWti.AutoGenerateColumns = false;
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
                    OperationLog o = new OperationLog();
                    o.OperationTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd,HH:mm:ss"));
                    o.Operationlog = LoginInfo.WorkerClub + LoginInfo.WorkerPosition + LoginInfo.WorkerName + "于" + DateTime.Now + "帮助" + txtCustoNo.Text + "进行了退房结算操作！";
                    o.OperationAccount = LoginInfo.WorkerClub + LoginInfo.WorkerPosition + LoginInfo.WorkerName;
                    #endregion
                    OperationlogManager.InsertOperationLog(o);
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
                        OperationLog o = new OperationLog();
                        o.OperationTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd,HH:mm:ss"));
                        o.Operationlog = LoginInfo.WorkerClub + LoginInfo.WorkerPosition + LoginInfo.WorkerName + "于" + DateTime.Now + "帮助" + txtCustoNo.Text + "进行了退房结算操作！";
                        o.OperationAccount = LoginInfo.WorkerClub + LoginInfo.WorkerPosition + LoginInfo.WorkerName;
                        #endregion
                        OperationlogManager.InsertOperationLog(o);
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
            //pnlMobile.Visible = true;
            //pnlCreditCard.Visible = false;
            //btnChangePay.Visible = true;
        }

        private void btnCreditCard_Click(object sender, EventArgs e)
        {
            //pnlMobile.Visible = false;
            //pnlCreditCard.Visible = true;
            //btnChangePay.Visible = false;
        }


        private void btnChangePay_Click(object sender, EventArgs e)
        {
            //DialogResult ret = MessageBox.Show("请选择支付类型：是:支付宝，否:微信？", "T仔的提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //if (ret == DialogResult.Yes)
            //{
            //    pnlMobile.BackgroundImage = Resources._1G_Q__21_3JZZCFW68O7NF;
            //}
            //else
            //{
            //    pnlMobile.BackgroundImage = Resources._1545891726;
            //}
        }

        private void txtCardNo_TextChanged(object sender, EventArgs e)
        {
            //if (txtCardNo.TextLength == 19 || txtCardNo.TextLength <= 16)
            //{
            //    lblState.Text = "该卡为有效银行卡，可进行消费";
            //    lblState.ForeColor = Color.Green;
            //}
            //else
            //{
            //    lblState.Text = "该卡为无效银行卡,不可进行消费";
            //    lblState.ForeColor = Color.Red;
            //}
        }

        private void llbCardReader_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //txtCardNo.Text = "6212260000000006222";
            //lblReaderState.Text = "卡号读取成功且有效，可继续进行结算操作";
            //lblReaderState.ForeColor = Color.Green;
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            //Graphics g = e.Graphics;
            //Font font = new Font("微软雅黑", 14f, System.Drawing.GraphicsUnit.Pixel);
            //SolidBrush brush = new SolidBrush(Color.Black);
            //if (e.Index == this.tabControl1.SelectedIndex)
            //{
            //    brush = new SolidBrush(Color.Blue);
            //}

            //RectangleF rectangle = (RectangleF)(tabControl1.GetTabRect(e.Index));
            //RectangleF rectangle2 = new RectangleF(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
            //g.FillRectangle(new SolidBrush(SystemColors.ButtonHighlight), rectangle2);
            //StringFormat sformat = new StringFormat();
            //sformat.LineAlignment = StringAlignment.Center;
            //sformat.Alignment = StringAlignment.Center;
            //g.DrawString(((TabControl)sender).TabPages[e.Index].Text, font, brush, rectangle2, sformat);
        }
    }
}
