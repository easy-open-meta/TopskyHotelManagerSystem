/*
 * MIT License
 *Copyright (c) 2021 咖啡与网络(java-and-net)

 *Permission is hereby granted, free of charge, to any person obtaining a copy
 *of this software and associated documentation files (the "Software"), to deal
 *in the Software without restriction, including without limitation the rights
 *to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 *copies of the Software, and to permit persons to whom the Software is
 *furnished to do so, subject to the following conditions:

 *The above copyright notice and this permission notice shall be included in all
 *copies or substantial portions of the Software.

 *THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 *IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 *FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 *AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 *LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 *OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 *SOFTWARE.
 *
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using SYS.Core;
using SYS.FormUI.Properties;
using System.Collections.Generic;
using Sunny.UI;
using SYS.Application;
using SYS.Common;

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
            foreach (Control item in this.Controls)
            {
                item.Font = UI_FontUtil.scorllingFont;
            }
            #region 加载客户类型信息
            List<CustoType> lstSourceGrid = new BaseService().SelectCustoTypeAllCanUse();
            this.cboCustoType.DataSource = lstSourceGrid;
            this.cboCustoType.DisplayMember = "TypeName";
            this.cboCustoType.ValueMember = "UserType";
            this.cboCustoType.SelectedIndex = 0;
            this.cboCustoType.ReadOnly = true;
            #endregion

            #region 加载证件类型信息
            List<PassPortType> passPorts = new BaseService().SelectPassPortTypeAllCanUse();
            this.cboPassportType.DataSource = passPorts;
            this.cboPassportType.DisplayMember = "PassportName";
            this.cboPassportType.ValueMember = "PassportId";
            this.cboPassportType.SelectedIndex = 0;
            #endregion

            #region 加载性别信息
            List<SexType> listSexType = new BaseService().SelectSexTypeAllCanUse();
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
            lblDay.Text = Convert.ToString(Convert.ToInt32(new RoomService().DayByRoomNo(txtRoomNo.Text).ToString()));
            w = new Wti()
            {
                CustoNo = txtCustoNo.Text,
                EndDate = Convert.ToDateTime(DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))),
                PowerUse = Convert.ToDecimal(Convert.ToInt32(new RoomService().DayByRoomNo(txtRoomNo.Text).ToString()) * 3 * 1),
                WaterUse = Convert.ToDecimal(Convert.ToDouble(new RoomService().DayByRoomNo(txtRoomNo.Text).ToString()) * 80 * 0.002),
                RoomNo = txtRoomNo.Text,
                Record = "admin",
                UseDate = Convert.ToDateTime(DateTime.Parse(dtpCheckTime.Text)),
            };

            #region 加载客户信息
            Custo cto = new CustoService().SelectCardInfoByCustoNo(CustoNo.Text.ToString());
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
            dgvSpendList.AutoGenerateColumns = false;
            dgvSpendList.DataSource = new SpendService().SelectSpendInfoRoomNo(RoomNo);
            double result = 0;
            if (dgvSpendList.Rows.Count == 0)
            {
                result = 0;
            }
            else
            {
                result = Convert.ToDouble(new SpendService().SelectMoneyByRoomNoAndTime(RoomNo, CustoNo.Text.ToString()));
            }

            #endregion

            #region 加载水电费信息
            var listWti = new WtiService().ListWtiInfoByRoomNo(txtRoomNo.Text.Trim());
            dgvWti.DataSource = listWti;
            dgvWti.AutoGenerateColumns = false;
            #endregion

            if (cboCustoType.Text == "钻石会员")
            {
                double m = result + sum;
                lblGetReceipts.Text = Decimal.Parse(m.ToString()).ToString("#,##0.00");
                lblVIPPrice.Text = Decimal.Parse((m * 0.80).ToString()).ToString("#,##0.00");
                lblVIP.Text = "八折";
            }
            else if (cboCustoType.Text == "白金会员")
            {

                double m = result + sum;
                lblGetReceipts.Text = Decimal.Parse(m.ToString()).ToString("#,##0.00");
                lblVIPPrice.Text = Decimal.Parse((m * 0.85).ToString()).ToString("#,##0.00");
                lblVIP.Text = "八五折";
            }
            else if (cboCustoType.Text == "黄金会员")
            {
                double m = result + sum;
                lblGetReceipts.Text = Decimal.Parse(m.ToString()).ToString("#,##0.00");
                lblVIPPrice.Text = Decimal.Parse((m * 0.90).ToString()).ToString("#,##0.00");
                lblVIP.Text = "九折";
            }
            else if (cboCustoType.Text == "普通会员")
            {
                double m = result + sum;
                lblGetReceipts.Text = Decimal.Parse(m.ToString()).ToString("#,##0.00");
                lblVIPPrice.Text = Decimal.Parse((m * 0.95).ToString()).ToString("#,##0.00");
                lblVIP.Text = "九五折";
            }
            else if (cboCustoType.Text == "普通用户")
            {
                double m = result + sum;
                lblGetReceipts.Text = Decimal.Parse(m.ToString()).ToString("#,##0.00");
                lblVIPPrice.Text = Decimal.Parse(m.ToString()).ToString("#,##0.00");
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
                    lblChange.Text = Decimal.Parse((n- h).ToString()).ToString("#,##0.00");
                }
                catch
                {
                    UIMessageBox.Show("非法输入，请重新输入！", "系统提示",UIStyle.Orange);
                    txtReceipts.Clear();
                    txtReceipts.Focus();
                    return;
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
            if (!txtReceipts.Text.IsNullOrEmpty() && Convert.ToDecimal(txtReceipts.Text) > Convert.ToDecimal(lblVIPPrice.Text))//判断实收金额是否为空以及是否小于应收金额
            {
                Room r = new RoomService().SelectRoomByRoomNo(txtRoomNo.Text);//根据房间编号查询房间信息
                string checktime = r.CheckTime.ToString();//获取入住时间
                if (dgvSpendList.Rows.Count == 0)
                {
                    bool n = new RoomService().UpdateRoomByRoomNo(txtRoomNo.Text);
                    if (n == true)
                    {
                        new WtiService().InsertWtiInfo(w);//添加水电费信息
                        this.Close();
                    }
                    else
                    {
                        return;
                    }
                    UIMessageBox.Show("结算成功！", "系统提示",UIStyle.Green);
                    FrmRoomManager.Reload("");

                    #region 获取添加操作日志所需的信息
                    RecordHelper.Record(LoginInfo.WorkerClub + "-" + LoginInfo.WorkerPosition + "-" + LoginInfo.WorkerName  + "于" + DateTime.Now + "帮助" + txtCustoNo.Text + "进行了退房结算操作！", 3);
                    #endregion

                }
                else
                {
                    if (new SpendService().UpdateMoneyState(txtRoomNo.Text, checktime) == true)
                    {
                        bool n = new RoomService().UpdateRoomByRoomNo(txtRoomNo.Text);
                        if (n == true)
                        {
                            new WtiService().InsertWtiInfo(w);//添加水电费信息
                            this.Close();
                        }
                        else
                        {
                            return;
                        }
                        UIMessageBox.Show("结算成功！", "系统提示",UIStyle.Green);
                        FrmRoomManager.Reload("");
                        #region 获取添加操作日志所需的信息
                        RecordHelper.Record(LoginInfo.WorkerClub + "-" + LoginInfo.WorkerPosition + "-" + LoginInfo.WorkerName + "于" + DateTime.Now + "帮助" + txtCustoNo.Text + "进行了退房结算操作！", 3);
                        #endregion
                        return;
                    }
                    else
                    {
                        UIMessageBox.Show("结算失败！", "系统提示", UIStyle.Red);
                        return;
                    }
                }
            }
            else
            {
                UIMessageBox.Show("实收金额不能为空或实收金额不能小于折后金额！", "系统提示", UIStyle.Orange);
                return;
            }
        }
        #endregion

    }
}
