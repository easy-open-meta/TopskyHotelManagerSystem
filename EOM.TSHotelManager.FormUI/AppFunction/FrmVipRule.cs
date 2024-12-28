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
using EOM.TSHotelManager.FormUI.Properties;
using Sunny.UI;

namespace EOM.TSHotelManager.FormUI
{
    public partial class FrmVipRule : UIForm
    {
        public FrmVipRule()
        {
            InitializeComponent();
        }

        ResponseMsg result = new ResponseMsg();

        private void FrmVipRule_Load(object sender, EventArgs e)
        {
            #region 加载客户类型信息
            result = HttpHelper.Request("Base/SelectCustoTypeAllCanUse", null, null);
            if (result.statusCode != 200)
            {
                UIMessageTip.ShowError("SelectCustoTypeAllCanUse+接口服务异常，请提交issue");
                return;
            }
            List<CustoType> lstSourceGrid = HttpHelper.JsonToList<CustoType>(result.message);
            this.cboCustoType.DataSource = lstSourceGrid;
            this.cboCustoType.DisplayMember = "TypeName";
            this.cboCustoType.ValueMember = "UserType";
            this.cboCustoType.SelectedIndex = 0;
            #endregion
            //生成流水号
            txtRuleId.Text = ApplicationUtil.GetListNewId("VR", 3, 1, "-").FirstOrDefault();
            LoadVipType();
        }

        /// <summary>
        /// 加载会员等级规则列表
        /// </summary>
        public void LoadVipType()
        {
            flpVipType.Clear();
            result = HttpHelper.Request("VipRule/SelectVipRuleList");
            if (result.statusCode != 200)
            {
                UIMessageTip.ShowError("SelectVipRuleList+接口服务异常，请提交issue");
                return;
            }
            var listVipTypes = HttpHelper.JsonToList<VipRule>(result.message);
            listVipTypes.ForEach(vipType =>
            {
                ucVipType ucVipType = new ucVipType();
                ucVipType.picVip.BackgroundImage = vipType.type_id == 0 ? Resources.普通会员
                : vipType.type_id == 1 ? Resources.钻石会员 : vipType.type_id == 2 ? Resources.白金会员 : Resources.黄金会员;
                ucVipType.lblValue.Text = vipType.type_name;
                flpVipType.Add(ucVipType);
            });

        }

        /// <summary>
        /// 添加会员等级规则方法
        /// </summary>
        /// <param name="vipRule"></param>
        /// <returns></returns>
        public bool InsertVipRule(VipRule vipRule)
        {
            VipRule vipRule1 = new VipRule
            {
                rule_id = vipRule.rule_id,
                rule_name = vipRule.rule_name,
                rule_value = vipRule.rule_value,
                type_id = vipRule.type_id,
                delete_mk = 0,
                datains_usr = AdminInfo.Account
            };
            result = HttpHelper.Request("VipRule/AddVipRule", HttpHelper.ModelToJson(vipRule1));
            if (result.statusCode != 200)
            {
                UIMessageTip.ShowError("AddVipRule+接口服务异常，请提交issue");
                return false;
            }
            return true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!txtRuleId.Text.Trim().IsNullOrEmpty() && !txtRuleName.Text.Trim().IsNullOrEmpty()
                && !dudSpendAmount.Value.IsZero())
            {
                VipRule vipRule1 = new VipRule
                {
                    rule_id = txtRuleId.Text.Trim(),
                    rule_name = txtRuleName.Text.Trim(),
                    rule_value = Convert.ToDecimal(dudSpendAmount.Value),
                    type_id = Convert.ToInt32(cboCustoType.SelectedValue),
                    datains_usr = AdminInfo.Account
                };
                if (InsertVipRule(vipRule1))
                {
                    UIMessageBox.ShowSuccess("录入成功！");
                    #region 获取添加操作日志所需的信息
                    RecordHelper.Record(AdminInfo.Account + "-" + AdminInfo.Name + "在" + Convert.ToDateTime(DateTime.Now) + "位于" + AdminInfo.SoftwareVersion + "执行：" + "添加会员规则操作！新增值为：" + vipRule1.rule_id, 2);
                    #endregion
                    LoadVipType();
                    return;
                }
                else
                {
                    UIMessageBox.ShowError("录入失败，请稍后再试！");
                    return;
                }
            }
        }
    }
}
