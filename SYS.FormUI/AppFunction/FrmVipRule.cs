
using Sunny.UI;

using SYS.Common;
using EOM.TSHotelManager.Common.Core;
using SYS.FormUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYS.FormUI
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
            txtRuleId.Text = Util.GetListNewId("VR", 3, 1, "-").FirstOrDefault();
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
                flpVipType.AddControl(ucVipType);
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
            result = HttpHelper.Request("VipRule/AddVipRule",HttpHelper.ModelToJson(vipRule1));
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
                    RecordHelper.Record(AdminInfo.Account + "-" + AdminInfo.Name + "在" + DateTime.Now + "位于" + AdminInfo.SoftwareVersion + "执行：" + "添加会员规则操作！新增值为：" + vipRule1.rule_id, 2);
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
