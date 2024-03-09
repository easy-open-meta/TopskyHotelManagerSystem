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
using System.Linq;
using System.Transactions;

namespace SYS.FormUI
{
    public partial class FrmCheckIn : UIEditForm
    {
        public FrmCheckIn()
        {
            InitializeComponent();
        }

        protected override bool CheckData()
        {
            return CheckEmpty(txtCustoName, "请输入姓名")
                   && CheckEmpty(txtCustoNo, "请输入客户编号")
                   && CheckEmpty(txtCustoTel, "输入11位手机号码");
        }
        int count = 0;

        ResponseMsg result = new ResponseMsg();

        #region 窗体加载事件方法
        private void FrmCheckIn_Load(object sender, EventArgs e)
        {
            txtRoomNo.Text = ucRoomList.rm_RoomNo;
            Dictionary<string, string> pairs = new Dictionary<string, string>();
            pairs.Add("no", txtRoomNo.Text.Trim());
            result = HttpHelper.Request("Room/SelectRoomByRoomNo", null, pairs);
            if (result.statusCode != 200)
            {
                UIMessageTip.ShowError("SelectRoomByRoomNo+接口服务异常，请提交issue");
                return;
            }
            Room r = HttpHelper.JsonToModel<Room>(result.message);
            result = HttpHelper.Request("RoomType/SelectRoomTypeByRoomNo", null, pairs);
            if (result.statusCode != 200)
            {
                UIMessageTip.ShowError("SelectRoomTypeByRoomNo+接口服务异常，请提交issue");
                return;
            }
            RoomType t = HttpHelper.JsonToModel<RoomType>(result.message);
            txtType.Text = t.RoomName;
            txtMoney.Text = r.RoomMoney.ToString();
            txtRoomPosition.Text = r.RoomPosition;
            txtState.Text = r.RoomState;
            txtDeposit.Text = r.RoomDeposit.ToString();
            result = HttpHelper.Request("Custo/SelectCustoAll", null, null);
            if (result.statusCode != 200)
            {
                UIMessageTip.ShowError("SelectCustoAll+接口服务异常，请提交issue");
                return;
            }
            var ctos = HttpHelper.JsonToList<Custo>(result.message).Select(a => a.CustoNo).ToArray();
            //List<Room> roms = new RoomService().SelectCanUseRoomAll();

            txtCustoNo.AutoCompleteCustomSource.AddRange(ctos);
            try
            {
                txtCustoNo.Text = "";
            }
            catch
            {
                txtCustoNo.Text = ucRoomList.rm_CustoNo;
            }

        }
        #endregion

        #region 关闭窗口
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 入住按钮点击事件方法
        private void btnCheckIn_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region 客户编号输入框的值发生改变时候的事件方法
        private void txtCustoNo_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void txtCustoNo_Validated(object sender, EventArgs e)
        {
            result = HttpHelper.Request("VipRule/SelectVipRuleList", null, null);
            if (result.statusCode != 200)
            {
                UIMessageTip.ShowError("SelectVipRuleList+接口服务异常，请提交issue");
                return;
            }
            //在每次完成输入验证之后，对该用户的会员等级进行初始化或升级以及降级操作
            var listVipRule = HttpHelper.JsonToList<VipRule>(result.message).OrderBy(a => a.rule_value).Distinct().ToList();
            var new_type = 0;
            //查询该用户以往的消费记录总额是否达到指定金额,不为空则为老客户
            Dictionary<string, string> user = new Dictionary<string, string>();
            user.Add("custoNo", txtCustoNo.Text.Trim());
            result = HttpHelper.Request("Spend/SeletHistorySpendInfoAll", null, user);
            if (result.statusCode != 200)
            {
                UIMessageTip.ShowError("SeletHistorySpendInfoAll+接口服务异常，请提交issue");
                return;
            }
            var listCustoSpend = HttpHelper.JsonToList<Spend>(result.message);
            if (!listCustoSpend.IsNullOrEmpty())
            {
                var spendAmount = listCustoSpend.Sum(a => a.SpendMoney);
                listVipRule.ForEach(vipRule =>
                {
                    if (spendAmount >= vipRule.rule_value)
                    {
                        new_type = vipRule.type_id;
                    }
                });

                //不等于0即会员等级有变，需进行及时会员等级
                if (new_type != 0)
                {
                    user = new Dictionary<string, string>();
                    user.Add("custoNo", txtCustoNo.Text.Trim());
                    user.Add("userType", new_type.ToString());
                    result = HttpHelper.Request("Custo/UpdCustomerTypeByCustoNo", null, user);
                    if (result.statusCode != 200)
                    {
                        UIMessageTip.ShowError("UpdCustomerTypeByCustoNo+接口服务异常，请提交issue");
                        return;
                    }
                }

            }

            try
            {
                if (string.IsNullOrEmpty(txtCustoNo.Text))
                {
                    return;
                }
                user = new Dictionary<string, string>();
                user.Add("CustoNo", txtCustoNo.Text.Trim());
                result = HttpHelper.Request("Custo/SelectCardInfoByCustoNo", null, user);
                if (result.statusCode != 200)
                {
                    UIMessageTip.ShowError("SelectCardInfoByCustoNo+接口服务异常，请提交issue");
                    return;
                }

                Custo c = HttpHelper.JsonToModel<Custo>(result.message);
                txtCustoName.Text = c.CustoName;
                txtCustoTel.Text = c.CustoTel;
                txtCustoType.Text = c.typeName;
            }
            catch
            {
                txtCustoName.Text = "";
                txtCustoTel.Text = "";
                txtCustoType.Text = "";
            }
        }

        private void FrmCheckIn_ButtonOkClick(object sender, EventArgs e)
        {
            Dictionary<string, string> user = new Dictionary<string, string>();
            user.Add("CustoNo", txtCustoNo.Text.Trim());
            result = HttpHelper.Request("Custo/SelectCardInfoByCustoNo", null, user);
            if (result.statusCode != 200)
            {
                UIMessageTip.ShowError("SelectCardInfoByCustoNo+接口服务异常，请提交issue");
                return;
            }
            if (!result.message.IsNullOrEmpty())
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    Room r = new Room()
                    {
                        CheckTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                        CustoNo = txtCustoNo.Text,
                        RoomStateId = 1,
                        RoomNo = txtRoomNo.Text,
                        datachg_usr = LoginInfo.WorkerNo
                    };
                    result = HttpHelper.Request("Room/UpdateRoomInfo", HttpHelper.ModelToJson(r), null);
                    if (result.statusCode != 200)
                    {
                        UIMessageTip.ShowError("UpdateRoomInfo+接口服务异常，请提交issue");
                        return;
                    }
                    bool n = result.message.Equals("true") ? true : false;
                    if (n)
                    {
                        UIMessageBox.Show("登记入住成功！", "登记提示", UIStyle.Green);
                        txtCustoNo.Text = "";
                        FrmRoomManager.Reload("");
                        #region 获取添加操作日志所需的信息
                        RecordHelper.Record(LoginInfo.WorkerClub + "-" + LoginInfo.WorkerPosition + "-" + LoginInfo.WorkerName + "于" + DateTime.Now + "帮助" + r.CustoNo + "进行了入住操作！", 1);
                        #endregion
                        scope.Complete();
                        this.Close();
                        return;
                    }
                    else
                    {
                        UIMessageBox.Show("登记入住失败！", "登记提示", UIStyle.Red);
                        return;
                    }
                }
            }
            else
            {
                UIMessageBox.Show("客户编号不存在！", "来自小T的提示", UIStyle.Red);
            }
        }

        private void FrmCheckIn_ButtonCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
