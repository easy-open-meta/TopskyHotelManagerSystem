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
using EOM.TSHotelManager.Common.Core;
using Sunny.UI;
using SYS.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Transactions;
using System.Windows.Forms;

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

        ResponseMsg result = null;
        Dictionary<string, string> dic = null;

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
            #region 加载客户类型信息
            result = HttpHelper.Request("Base/SelectCustoTypeAllCanUse");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectCustoTypeAllCanUse+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            List<CustoType> lstSourceGrid = HttpHelper.JsonToList<CustoType>(result.message);
            this.cboCustoType.DataSource = lstSourceGrid;
            this.cboCustoType.DisplayMember = "TypeName";
            this.cboCustoType.ValueMember = "UserType";
            this.cboCustoType.SelectedIndex = 0;
            this.cboCustoType.ReadOnly = true;
            #endregion

            #region 加载证件类型信息
            result = HttpHelper.Request("Base/SelectPassPortTypeAllCanUse");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectPassPortTypeAllCanUse+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            List<PassPortType> passPorts = HttpHelper.JsonToList<PassPortType>(result.message);
            this.cboPassportType.DataSource = passPorts;
            this.cboPassportType.DisplayMember = "PassportName";
            this.cboPassportType.ValueMember = "PassportId";
            this.cboPassportType.SelectedIndex = 0;
            #endregion

            #region 加载性别信息
            result = HttpHelper.Request("Base/SelectSexTypeAll?delete_mk=0");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectSexTypeAll+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            List<SexType> listSexType = HttpHelper.JsonToList<SexType>(result.message);
            this.cboCustoSex.DataSource = listSexType;
            this.cboCustoSex.DisplayMember = "sexName";
            this.cboCustoSex.ValueMember = "sexId";
            this.cboCustoSex.SelectedIndex = 0;
            #endregion

            double sum = 0;
            txtCustoNo.Text = ucRoomList.rm_CustoNo;
            CustoNo.Text = ucRoomList.rm_CustoNo;
            txtRoomNo.Text = ucRoomList.rm_RoomNo;

            dic = new Dictionary<string, string>()
            {
                { "no",txtRoomNo.Text.ToString()}
            };

            result = HttpHelper.Request("Room/SelectRoomByRoomNo", null, dic);
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectSexTypeAll+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }

            Room room = HttpHelper.JsonToModel<Room>(result.message);

            if (room.CheckTime == null)
            {
                dtpCheckTime.Text = DateTime.Now.ToString("yyyy年MM月dd日");
            }
            else
            {
                dtpCheckTime.Text = Convert.ToDateTime(room.CheckTime).ToString("yyyy年MM月dd日");
            }
            dic = new Dictionary<string, string>()
            {
                { "roomno",txtRoomNo.Text}
            };
            result = HttpHelper.Request("Room/DayByRoomNo", null, dic);
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("DayByRoomNo+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }

            sum = Convert.ToDouble(Convert.ToString(Convert.ToInt32(result.message) * room.RoomMoney));

            lblDay.Text = Convert.ToString(Convert.ToInt32(result.message));
            w = new Wti()
            {
                CustoNo = txtCustoNo.Text,
                EndDate = Convert.ToDateTime(DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))),
                PowerUse = Convert.ToDecimal(Convert.ToInt32(result.message) * 3 * 1),
                WaterUse = Convert.ToDecimal(Convert.ToDouble(result.message) * 80 * 0.002),
                RoomNo = txtRoomNo.Text,
                Record = "admin",
                UseDate = Convert.ToDateTime(DateTime.Parse(dtpCheckTime.Text)),
            };

            #region 加载客户信息
            dic = new Dictionary<string, string>()
            {
                { "CustoNo",CustoNo.Text.ToString()}
            };
            result = HttpHelper.Request("Custo​/SelectCardInfoByCustoNo", null, dic);
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectCardInfoByCustoNo+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            Custo cto = HttpHelper.JsonToModel<Custo>(result.message);
            try
            {
                CustoName.Text = cto.CustoName;
                txtCustoName.Text = cto.CustoName;
                txtTel.Text = cto.CustoTel;
                cboCustoSex.SelectedIndex = cto.CustoSex;
                cboCustoType.SelectedIndex = cto.CustoType;
                cboPassportType.SelectedIndex = cto.PassportType;
                dtpBirth.Value = Convert.ToDateTime(cto.CustoBirth);
                txtPassportNum.Text = cto.CustoID;
            }
            catch
            {


            }


            #endregion

            #region 加载消费信息
            string RoomNo = txtRoomNo.Text;
            dic = new Dictionary<string, string>()
            {
                { "RoomNo",RoomNo}
            };
            result = HttpHelper.Request("Spend/SelectSpendInfoRoomNo", null, dic);
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectSpendInfoRoomNo+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            dgvSpendList.AutoGenerateColumns = false;
            dgvSpendList.DataSource = HttpHelper.JsonToList<Spend>(result.message);
            double total = 0;
            if (dgvSpendList.Rows.Count == 0)
            {
                total = 0;
            }
            else
            {
                dic = new Dictionary<string, string>()
                {
                    { "roomno",RoomNo},
                    { "custono",CustoNo.Text.ToString()}
                };
                result = HttpHelper.Request("Spend/SelectMoneyByRoomNoAndTime", null, dic);
                if (result.statusCode != 200)
                {
                    UIMessageBox.ShowError("SelectMoneyByRoomNoAndTime+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                total = Convert.ToDouble(result.message);
            }

            #endregion

            #region 加载水电费信息
            dic = new Dictionary<string, string>()
            {
                { "roomno",txtRoomNo.Text.Trim()}
            };
            result = HttpHelper.Request("Wti/ListWtiInfoByRoomNo", null, dic);
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("ListWtiInfoByRoomNo+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            var listWti = HttpHelper.JsonToList<Wti>(result.message);
            dgvWti.DataSource = listWti;
            dgvWti.AutoGenerateColumns = false;
            #endregion

            if (cboCustoType.Text == "钻石会员")
            {
                double m = total + sum;
                lblGetReceipts.Text = Decimal.Parse(m.ToString()).ToString("#,##0.00");
                lblVIPPrice.Text = Decimal.Parse((m * 0.80).ToString()).ToString("#,##0.00");
                lblVIP.Text = "八折";
            }
            else if (cboCustoType.Text == "白金会员")
            {

                double m = total + sum;
                lblGetReceipts.Text = Decimal.Parse(m.ToString()).ToString("#,##0.00");
                lblVIPPrice.Text = Decimal.Parse((m * 0.85).ToString()).ToString("#,##0.00");
                lblVIP.Text = "八五折";
            }
            else if (cboCustoType.Text == "黄金会员")
            {
                double m = total + sum;
                lblGetReceipts.Text = Decimal.Parse(m.ToString()).ToString("#,##0.00");
                lblVIPPrice.Text = Decimal.Parse((m * 0.90).ToString()).ToString("#,##0.00");
                lblVIP.Text = "九折";
            }
            else if (cboCustoType.Text == "普通会员")
            {
                double m = total + sum;
                lblGetReceipts.Text = Decimal.Parse(m.ToString()).ToString("#,##0.00");
                lblVIPPrice.Text = Decimal.Parse((m * 0.95).ToString()).ToString("#,##0.00");
                lblVIP.Text = "九五折";
            }
            else if (cboCustoType.Text == "普通用户")
            {
                double m = total + sum;
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
                    lblChange.Text = Decimal.Parse((n - h).ToString()).ToString("#,##0.00");
                }
                catch
                {
                    UIMessageBox.Show("非法输入，请重新输入！", "系统提示", UIStyle.Orange);
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
                using (TransactionScope scope = new TransactionScope())
                {
                    dic = new Dictionary<string, string>()
                    {
                        { "no",txtRoomNo.Text}
                    };
                    result = HttpHelper.Request("Room/SelectRoomByRoomNo", null, dic);
                    if (result.statusCode != 200)
                    {
                        UIMessageBox.ShowError("SelectRoomByRoomNo+接口服务异常，请提交Issue或尝试更新版本！");
                        return;
                    }
                    Room r = HttpHelper.JsonToModel<Room>(result.message);//根据房间编号查询房间信息
                    string checktime = r.CheckTime.ToString();//获取入住时间
                    if (dgvSpendList.Rows.Count == 0)
                    {
                        dic = new Dictionary<string, string>()
                        {
                            { "room",txtRoomNo.Text}
                        };
                        result = HttpHelper.Request("Room/UpdateRoomByRoomNo", null, dic);
                        if (result.statusCode != 200)
                        {
                            UIMessageBox.ShowError("UpdateRoomByRoomNo+接口服务异常，请提交Issue或尝试更新版本！");
                            return;
                        }
                        bool n = result.message.ToString().Equals("true");
                        if (n)
                        {
                            result = HttpHelper.Request("Wti​/InsertWtiInfo", HttpHelper.ModelToJson(w));
                            if (result.statusCode != 200)
                            {
                                UIMessageBox.ShowError("InsertWtiInfo+接口服务异常，请提交Issue或尝试更新版本！");
                                return;
                            }
                            this.Close();
                        }
                        else
                        {
                            return;
                        }
                        UIMessageBox.Show("结算成功！", "系统提示", UIStyle.Green);
                        FrmRoomManager.Reload("");

                        #region 获取添加操作日志所需的信息
                        RecordHelper.Record(LoginInfo.WorkerClub + "-" + LoginInfo.WorkerPosition + "-" + LoginInfo.WorkerName + "于" + DateTime.Now + "帮助" + txtCustoNo.Text + "进行了退房结算操作！", 3);
                        #endregion
                        scope.Complete();
                    }
                    else
                    {
                        dic = new Dictionary<string, string>()
                        {
                            { "roomno",txtRoomNo.Text},
                            { "checktime",checktime}
                        };
                        result = HttpHelper.Request("Spend​/UpdateMoneyState", null, dic);
                        if (result.statusCode != 200)
                        {
                            UIMessageBox.ShowError("UpdateMoneyState+接口服务异常，请提交Issue或尝试更新版本！");
                            return;
                        }
                        if (result.message.ToString().Equals("true"))
                        {
                            dic = new Dictionary<string, string>()
                            {
                                { "room",txtRoomNo.Text}
                            };
                            result = HttpHelper.Request("Room/UpdateRoomByRoomNo", null, dic);
                            if (result.statusCode != 200)
                            {
                                UIMessageBox.ShowError("UpdateMoneyState+接口服务异常，请提交Issue或尝试更新版本！");
                                return;
                            }
                            bool n = result.message.ToString().Equals("true");
                            if (n)
                            {
                                result = HttpHelper.Request("Wti​/InsertWtiInfo", HttpHelper.ModelToJson(w));
                                if (result.statusCode != 200)
                                {
                                    UIMessageBox.ShowError("InsertWtiInfo+接口服务异常，请提交Issue或尝试更新版本！");
                                    return;
                                }
                                this.Close();
                            }
                            else
                            {
                                return;
                            }
                            UIMessageBox.Show("结算成功！", "系统提示", UIStyle.Green);
                            FrmRoomManager.Reload("");
                            #region 获取添加操作日志所需的信息
                            RecordHelper.Record(LoginInfo.WorkerClub + "-" + LoginInfo.WorkerPosition + "-" + LoginInfo.WorkerName + "于" + DateTime.Now + "帮助" + txtCustoNo.Text + "进行了退房结算操作！", 3);
                            #endregion
                            scope.Complete();
                            return;
                        }
                        else
                        {
                            UIMessageBox.Show("结算失败！", "系统提示", UIStyle.Red);
                            return;
                        }
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
