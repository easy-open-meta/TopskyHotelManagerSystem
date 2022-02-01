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
using System.Collections.Generic;
using System.Windows.Forms;
using SYS.Core;
using Sunny.UI;
using SYS.Application;
using System.Transactions;
using SYS.Application.Zero;
using System.Linq;

namespace SYS.FormUI
{
    public partial class FrmCheckIn : UIForm
    {
        public FrmCheckIn()
        {
            InitializeComponent();
        }

        #region 窗体加载事件方法
        private void FrmCheckIn_Load(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                item.Font = UI_FontUtil.controlFont;
            }
            txtRoomNo.Text = ucRoomList.rm_RoomNo;
            Room r = new RoomService().SelectRoomByRoomNo(txtRoomNo.Text);
            RoomType t = new RoomTypeService().SelectRoomTypeByRoomNo(txtRoomNo.Text);
            txtType.Text = t.RoomName;
            txtMoney.Text = r.RoomMoney.ToString();
            txtRoomPosition.Text = r.RoomPosition;
            txtState.Text = r.RoomState;
            txtDeposit.Text = r.RoomDeposit.ToString();
            List<Custo> ctos = new CustoService().SelectCustoAll();
            List<Room> roms = new RoomService().SelectCanUseRoomAll();
            for (int i = 0; i < roms.Count; i++)
            {
                txtRoomNo.AutoCompleteCustomSource.Add(roms[i].RoomNo);
            }
            for (int j = 0; j < ctos.Count; j++)
            {
                txtCustoNo.AutoCompleteCustomSource.Add(ctos[j].CustoNo);
            }
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

        #region 验证输入完整性
        /// <summary>
        /// 验证输入完整性
        /// </summary>
        private bool CheckInupt()
        {
            if (txtCustoNo.Text == "")
            {
                UIMessageBox.Show("请输入客户编号！", "来自小T的提示",UIStyle.Orange);
                txtCustoNo.Focus();
                return false;
            }
            
            return true;
        }
        #endregion

        #region 入住按钮点击事件方法
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (CheckInupt())
            {
                if (new CustoService().SelectCardInfoByCustoNo(txtCustoNo.Text) != null)
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        Room r = new Room() 
                        {
                            CheckTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                            CustoNo = txtCustoNo.Text,
                            RoomStateId = 1,
                            RoomNo = txtRoomNo.Text,
                            datachg_usr = LoginInfo.WorkerNo,
                            datachg_date = DateTime.Now,
                        };
                        
                        bool n = new RoomService().UpdateRoomInfo(r);
                        if (n == true)
                        {
                            UIMessageBox.Show("登记入住成功！", "登记提示",UIStyle.Green);
                            txtCustoNo.Text = "";
                            FrmRoomManager.Reload("");
                            #region 获取添加操作日志所需的信息
                            RecordHelper.Record(LoginInfo.WorkerClub + LoginInfo.WorkerPosition + LoginInfo.WorkerName + "于" + DateTime.Now + "帮助" + r.CustoNo + "进行了入住操作！", 1);
                            #endregion
                            scope.Complete();
                            this.Close();
                            return;
                        }
                        else
                        {
                            UIMessageBox.Show("登记入住失败！", "登记提示",UIStyle.Red);
                            return;
                        }
                    }
                }
                else
                {
                    UIMessageBox.Show("客户编号不存在！", "来自小T的提示",UIStyle.Red);
                }
            }
        }
        #endregion

        #region 客户编号输入框的值发生改变时候的事件方法
        private void txtCustoNo_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void txtCustoNo_Validated(object sender, EventArgs e)
        {
            //在每次完成输入验证之后，对该用户的会员等级进行初始化或升级以及降级操作
            var listVipRule = new VipRuleAppService().SelectVipRuleList().OrderBy(a => a.rule_value).Distinct().ToList();
            var new_type = 0;
            //查询该用户以往的消费记录总额是否达到指定金额,不为空则为老客户
            var listCustoSpend = new SpendService().SeletHistorySpendInfoAll(txtCustoNo.Text.Trim());
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
                    new CustoService().UpdCustomerTypeByCustoNo(txtCustoNo.Text.Trim(), new_type);
                }

            }


            try
            {
                if (string.IsNullOrEmpty(txtCustoNo.Text))
                {
                    return;
                }
                Custo c = new CustoService().SelectCardInfoByCustoNo(txtCustoNo.Text);
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
    }
}
