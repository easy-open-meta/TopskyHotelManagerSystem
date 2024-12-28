/*
 * MIT License
 *Copyright (c) 2021 易开元(EOM)

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


using EOM.TSHotelManager.Common;
using EOM.TSHotelManager.Common.Core;
using Sunny.UI;
using System.Transactions;

namespace EOM.TSHotelManager.FormUI
{
    public partial class FrmCheckIn : UIEditForm
    {
        public FrmCheckIn()
        {
            InitializeComponent();
        }

        ResponseMsg result = new ResponseMsg();

        private void FrmCheckIn_Load(object sender, EventArgs e)
        {
            txtRoomNo.Text = ucRoom.rm_RoomNo;
            Dictionary<string, string> pairs = new Dictionary<string, string>();
            pairs.Add("no", txtRoomNo.Text.Trim()!);
            result = HttpHelper.Request("Room/SelectRoomByRoomNo", null, pairs);
            if (result.statusCode != 200)
            {
                UIMessageTip.ShowError("SelectRoomByRoomNo+接口服务异常，请提交issue");
                return;
            }
            Room r = HttpHelper.JsonToModel<Room>(result.message!)!;
            result = HttpHelper.Request("RoomType/SelectRoomTypeByRoomNo", null, pairs);
            if (result.statusCode != 200)
            {
                UIMessageTip.ShowError("SelectRoomTypeByRoomNo+接口服务异常，请提交issue");
                return;
            }
            RoomType t = HttpHelper.JsonToModel<RoomType>(result.message!)!;
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
            var custoList = HttpHelper.JsonToPageList<OSelectAllDto<Custo>>(result.message!);
            if (custoList != null && custoList != null)
            {
                var ctos = custoList.listSource.Select(custo => custo.CustoNo).ToArray();
                txtCustoNo.AutoCompleteCustomSource.AddRange(ctos);
            }
            try
            {
                txtCustoNo.Text = "";
            }
            catch
            {
                txtCustoNo.Text = ucRoom.rm_CustoNo;
            }
        }

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
            try
            {
                ValidateAndUpdateCustomerInfo();
            }
            catch (Exception ex)
            {
                UIMessageTip.ShowError($"接口服务异常，请提交issue: {ex.Message}");
            }
        }

        private void ValidateAndUpdateCustomerInfo()
        {
            // 获取会员规则列表
            var result = HttpHelper.Request("VipRule/SelectVipRuleList", null, null);
            if (result.statusCode != 200)
            {
                throw new Exception("SelectVipRuleList+接口服务异常");
            }

            var listVipRule = HttpHelper.JsonToList<VipRule>(result.message!)!
                .OrderBy(a => a.rule_value)
                .Distinct()
                .ToList();

            // 查询用户消费记录
            var user = new Dictionary<string, string> { { "custoNo", txtCustoNo.Text.Trim() } };
            result = HttpHelper.Request("Spend/SeletHistorySpendInfoAll", null, user);
            if (result.statusCode != 200)
            {
                throw new Exception("SeletHistorySpendInfoAll+接口服务异常");
            }

            var listCustoSpend = HttpHelper.JsonToList<Spend>(result.message!)!;
            if (!listCustoSpend.IsNullOrEmpty())
            {
                var spendAmount = listCustoSpend.Sum(a => a.SpendMoney);
                var new_type = listVipRule
                    .Where(vipRule => spendAmount >= vipRule.rule_value)
                    .OrderByDescending(vipRule => vipRule.rule_value)
                    .FirstOrDefault()?.type_id ?? 0;

                // 如果会员等级有变，更新会员等级
                if (new_type != 0)
                {
                    user = new Dictionary<string, string>
            {
                { "custoNo", txtCustoNo.Text.Trim() },
                { "userType", new_type.ToString() }
            };
                    result = HttpHelper.Request("Custo/UpdCustomerTypeByCustoNo", null, user);
                    if (result.statusCode != 200)
                    {
                        throw new Exception("UpdCustomerTypeByCustoNo+接口服务异常");
                    }
                }
            }

            // 获取用户卡片信息
            if (!string.IsNullOrEmpty(txtCustoNo.Text))
            {
                user = new Dictionary<string, string> { { "CustoNo", txtCustoNo.Text.Trim() } };
                result = HttpHelper.Request("Custo/SelectCardInfoByCustoNo", null, user);
                if (result.statusCode != 200)
                {
                    throw new Exception("SelectCardInfoByCustoNo+接口服务异常");
                }

                var custo = HttpHelper.JsonToModel<Custo>(result.message!);
                txtCustoName.Text = custo?.CustoName ?? "";
                txtCustoTel.Text = custo?.CustoTel ?? "";
                txtCustoType.Text = custo?.typeName ?? "";
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
                        CheckTime = Convert.ToDateTime(Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss")),
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
                        FrmRoomManager._RefreshRoomCount();
                        #region 获取添加操作日志所需的信息
                        RecordHelper.Record(LoginInfo.WorkerClub + "-" + LoginInfo.WorkerPosition + "-" + LoginInfo.WorkerName + "于" + Convert.ToDateTime(DateTime.Now) + "帮助" + r.CustoNo + "进行了入住操作！", 1);
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
