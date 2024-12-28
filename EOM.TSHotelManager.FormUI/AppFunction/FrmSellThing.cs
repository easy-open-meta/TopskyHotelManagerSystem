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
using jvncorelib.EntityLib;
using Sunny.UI;

namespace EOM.TSHotelManager.FormUI
{
    public partial class FrmSellThing : Sunny.UI.UIForm
    {
        private int rs = 0;//用于判断房间是否可消费
        static string roomNo;

        Dictionary<string, string> dic = null;
        ResponseMsg result = null;
        Room r = null;

        public FrmSellThing()
        {
            InitializeComponent();
        }

        #region 窗体加载事件
        private void FrmSellThing_Load(object sender, EventArgs e)
        {
            result = HttpHelper.Request("Room/SelectRoomByStateAll");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectRoomByStateAll+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            List<Room> roms = HttpHelper.JsonToList<Room>(result.message);
            for (int i = 0; i < roms.Count; i++)
            {
                txtRoomNo.AutoCompleteCustomSource.Add(roms[i].RoomNo);
            }
            LoadSellThingInfo();

        }
        #endregion

        #region 查询事件
        private void btnFind_Click(object sender, EventArgs e)
        {
            LoadThingByName();
        }
        #endregion

        #region 查询文本框更改事件

        private void LoadThingByName()
        {
            dic = new Dictionary<string, string>()
            {
                { "SellNo",txtFind.Text.Trim()},
                {"SellName", txtFind.Text.Trim()}
            };
            result = HttpHelper.Request("Sellthing/SelectSellThingAll", null, dic);
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectSellThingAll+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            List<SellThing> lstSource = HttpHelper.JsonToList<SellThing>(result.message);
            this.dgvSellthing.DataSource = lstSource;
            this.dgvSellthing.AutoGenerateColumns = false;
        }
        #endregion

        #region 根据客户编号加载消费信息的方法
        private void LoadSpendInfoByRoomNo(string room)
        {
            dic = new Dictionary<string, string>()
            {
                { "No",room}
            };
            result = HttpHelper.Request("Spend/SelectSpendByRoomNo", null, dic);
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectSpendByRoomNo+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            this.dgvRoomSell.AutoGenerateColumns = false;
            List<Spend> lstSource = HttpHelper.JsonToList<Spend>(result.message);
            this.dgvRoomSell.DataSource = lstSource;
        }
        #endregion

        #region 商品加载事件方法
        public void LoadSellThingInfo()
        {
            result = HttpHelper.Request("Sellthing/SelectSellThingAll");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectSellThingAll+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            List<SellThing> lstSource = HttpHelper.JsonToList<SellThing>(result.message);
            this.dgvSellthing.AutoGenerateColumns = false;
            this.dgvSellthing.DataSource = lstSource;

        }
        #endregion

        #region 判断输入的完整性的方法
        public bool CheckInput()
        {
            if (txtRoomNo.Text == "")
            {
                UIMessageBox.Show("消费房间不能为空", "提示信息", UIStyle.Red, UIMessageBoxButtons.OKCancel);
                txtRoomNo.Focus();
                return false;
            }
            if (txtSellNo.Text == "")
            {
                UIMessageBox.Show("商品编号不能为空", "提示信息", UIStyle.Red, UIMessageBoxButtons.OKCancel);
                txtSellNo.Focus();
                return false;
            }
            if (txtSellName.Text == "")
            {
                UIMessageBox.Show("商品名称不能为空", "提示信息", UIStyle.Red, UIMessageBoxButtons.OKCancel);
                txtSellName.Focus();
                return false;
            }
            if (txtPrice.Text == "")
            {
                UIMessageBox.Show("商品单价不能为空", "提示信息", UIStyle.Red, UIMessageBoxButtons.OKCancel);
                txtPrice.Focus();
                return false;
            }
            if (nudNum.Value <= 0)
            {
                UIMessageBox.Show("数量不能小于0", "提示信息", UIStyle.Red, UIMessageBoxButtons.OKCancel);
                txtPrice.Focus();
                return false;
            }
            return true;
        }
        #endregion

        #region 添加事件
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lblState.Visible == false)
            {
                UIMessageBox.Show("请先输入消费的房间！", "提示信息", UIStyle.Red);
                return;
            }
            if (nudNum.Value <= 0)
            {
                UIMessageBox.Show("请输入消费数量！", "提示信息", UIStyle.Red);
                return;
            }
            if (lblState.Text == "该房间可消费")//判断房间编号是否可消费
            {
                if (CheckInput())
                {
                    dic = new Dictionary<string, string>()
                    {
                        { "SellNo",txtSellNo.Text.Trim()}
                    };
                    result = HttpHelper.Request("Sellthing/SelectSellThingAll", null, dic);
                    if (result.statusCode != 200)
                    {
                        UIMessageBox.ShowError("SelectSellThingAll+接口服务异常，请提交Issue或尝试更新版本！");
                        return;
                    }
                    List<SellThing> st = HttpHelper.JsonToList<SellThing>(result.message);
                    dic = new Dictionary<string, string>()
                    {
                        { "no",txtRoomNo.Text.Trim()}
                    };
                    result = HttpHelper.Request("Room/SelectRoomByRoomNo", null, dic);
                    if (result.statusCode != 200)
                    {
                        UIMessageBox.ShowError("SelectRoomByRoomNo+接口服务异常，请提交Issue或尝试更新版本！");
                        return;
                    }
                    r = HttpHelper.JsonToModel<Room>(result.message);
                    dic = new Dictionary<string, string>()
                    {
                        { "RoomNo",txtRoomNo.Text.Trim()}
                    };
                    result = HttpHelper.Request("Spend/SelectSpendInfoRoomNo", null, dic);
                    if (result.statusCode != 200)
                    {
                        UIMessageBox.ShowError("SelectSpendInfoRoomNo+接口服务异常，请提交Issue或尝试更新版本！");
                        return;
                    }
                    var listSource = HttpHelper.JsonToList<Spend>(result.message);
                    Spend s = null;
                    if (!listSource.IsNullOrEmpty())
                    {
                        var sellthing = listSource.FirstOrDefault(a => a.SpendName.Equals(txtSellName.Text));
                        if (!sellthing.IsNullOrEmpty())
                        {
                            s = new Spend()
                            {
                                RoomNo = txtRoomNo.Text,
                                SpendName = txtSellName.Text,
                                SpendAmount = (int)nudNum.Value + listSource.FirstOrDefault(a => a.SpendName.Equals(txtSellName.Text.Trim())).SpendAmount,
                                CustoNo = r.CustoNo,
                                SpendPrice = Convert.ToDecimal(txtPrice.Text),
                                SpendMoney = Convert.ToDecimal(Convert.ToDouble(txtPrice.Text) * nudNum.Value) + listSource.FirstOrDefault(a => a.SpendName.Equals(txtSellName.Text.Trim())).SpendMoney,
                                SpendTime = Convert.ToDateTime(Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss")),
                                MoneyState = SpendConsts.UnSettle,
                                datachg_usr = LoginInfo.WorkerNo
                            };
                            result = HttpHelper.Request("Spend/UpdSpenInfo", HttpHelper.ModelToJson(s));
                            if (result.statusCode != 200)
                            {
                                UIMessageBox.ShowError("UpdSpenInfo+接口服务异常，请提交Issue或尝试更新版本！");
                                return;
                            }
                            if (result.message.ToString().Equals("true"))
                            {
                                var stock = (st.First().Stock - (decimal)nudNum.Value);
                                var sellThing = new SellThing { SellName = st.First().SellName, SellPrice = st.First().SellPrice, Stock = stock, SellNo = st.First().SellNo, format = st.First().format };
                                result = HttpHelper.Request("Sellthing/UpdateSellthingInfo", HttpHelper.ModelToJson(sellThing));
                                if (result.statusCode != 200)
                                {
                                    UIMessageBox.ShowError("UpdateSellthingInfo+接口服务异常，请提交Issue或尝试更新版本！");
                                    return;
                                }
                                UIMessageBox.Show("添加成功", "系统提示", UIStyle.Green, UIMessageBoxButtons.OK, true);
                                LoadSpendInfoByRoomNo(r.RoomNo);
                                LoadSellThingInfo();
                                #region 获取添加操作日志所需的信息
                                RecordHelper.Record(LoginInfo.WorkerNo + "-" + LoginInfo.WorkerName + "在" + Convert.ToDateTime(DateTime.Now) + "位于" + LoginInfo.SoftwareVersion + "执行：" + "帮助" + s.CustoNo + "进行了消费商品:" + txtSellName.Text + "操作！", 2);
                                #endregion
                            }
                        }
                        else
                        {
                            s = new Spend()
                            {
                                RoomNo = txtRoomNo.Text,
                                SpendName = txtSellName.Text,
                                SpendAmount = (int)nudNum.Value,
                                CustoNo = r.CustoNo,
                                SpendPrice = Convert.ToDecimal(txtPrice.Text),
                                SpendMoney = Convert.ToDecimal(Convert.ToDouble(txtPrice.Text) * nudNum.Value),
                                SpendTime = Convert.ToDateTime(Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss")),
                                MoneyState = SpendConsts.UnSettle,
                                datains_usr = LoginInfo.WorkerNo,
                            };
                            result = HttpHelper.Request("Spend​/InsertSpendInfo", HttpHelper.ModelToJson(s));
                            if (result.statusCode != 200)
                            {
                                UIMessageBox.ShowError("InsertSpendInfo+接口服务异常，请提交Issue或尝试更新版本！");
                                return;
                            }
                            bool m = result.message.ToString().Equals("true");
                            if (m)
                            {
                                var stock = (st.First().Stock - (decimal)nudNum.Value);
                                var sellThing = new SellThing { SellName = st.First().SellName, SellPrice = st.First().SellPrice, Stock = stock, SellNo = st.First().SellNo, format = st.First().format };
                                result = HttpHelper.Request("Sellthing/UpdateSellthingInfo", HttpHelper.ModelToJson(sellThing));
                                if (result.statusCode != 200)
                                {
                                    UIMessageBox.ShowError("UpdateSellthingInfo+接口服务异常，请提交Issue或尝试更新版本！");
                                    return;
                                }
                                UIMessageBox.Show("添加成功", "系统提示", UIStyle.Green, UIMessageBoxButtons.OK, true);
                                LoadSpendInfoByRoomNo(r.RoomNo);
                                LoadSellThingInfo();
                                #region 获取添加操作日志所需的信息
                                RecordHelper.Record(LoginInfo.WorkerNo + "-" + LoginInfo.WorkerName + "在" + Convert.ToDateTime(DateTime.Now) + "位于" + LoginInfo.SoftwareVersion + "执行：" + "帮助" + s.CustoNo + "进行了消费商品:" + txtSellName.Text + "操作！", 2);
                                #endregion
                                nudNum.Value = 0;
                                return;
                            }
                            else
                            {
                                UIMessageBox.ShowError("添加失败");
                                return;
                            }
                        }
                    }
                    else
                    {
                        s = new Spend()
                        {
                            RoomNo = txtRoomNo.Text,
                            SpendName = txtSellName.Text,
                            SpendAmount = (int)nudNum.Value,
                            CustoNo = r.CustoNo,
                            SpendPrice = Convert.ToDecimal(txtPrice.Text),
                            SpendMoney = Convert.ToDecimal(Convert.ToDouble(txtPrice.Text) * nudNum.Value),
                            SpendTime = Convert.ToDateTime(Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss")),
                            MoneyState = SpendConsts.UnSettle,
                        };
                        result = HttpHelper.Request("Spend​/InsertSpendInfo", HttpHelper.ModelToJson(s));
                        if (result.statusCode != 200)
                        {
                            UIMessageBox.ShowError("InsertSpendInfo+接口服务异常，请提交Issue或尝试更新版本！");
                            return;
                        }
                        bool m = result.message.ToString().Equals("true");
                        if (m)
                        {
                            var stock = (st.First().Stock - (decimal)nudNum.Value);
                            var sellThing = new SellThing { SellName = st.First().SellName, SellPrice = st.First().SellPrice, Stock = stock, SellNo = st.First().SellNo, format = st.First().format };
                            result = HttpHelper.Request("Sellthing/UpdateSellthingInfo", HttpHelper.ModelToJson(sellThing));
                            if (result.statusCode != 200)
                            {
                                UIMessageBox.ShowError("UpdateSellthingInfo+接口服务异常，请提交Issue或尝试更新版本！");
                                return;
                            }
                            UIMessageBox.Show("添加成功", "系统提示", UIStyle.Green, UIMessageBoxButtons.OK, true);
                            LoadSpendInfoByRoomNo(r.RoomNo);
                            LoadSellThingInfo();
                            #region 获取添加操作日志所需的信息
                            RecordHelper.Record(LoginInfo.WorkerNo + "-" + LoginInfo.WorkerName + "在" + Convert.ToDateTime(DateTime.Now) + "位于" + LoginInfo.SoftwareVersion + "执行：" + "帮助" + s.CustoNo + "进行了消费商品:" + txtSellName.Text + "操作！", 2);
                            #endregion
                            nudNum.Value = 0;
                            return;
                        }
                        else
                        {
                            UIMessageBox.ShowError("添加失败");
                            return;
                        }
                    }
                }
            }
        }
        #endregion

        #region 撤回消费事件
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (lblState.Visible == false)
            {
                UIMessageBox.Show("请先输入消费的房间！", "提示信息", UIStyle.Red);
                return;
            }
            if (dgvRoomSell.SelectedRows.Count > 0)
            {
                if (dgvRoomSell.SelectedRows[0].Cells["clSpendName"].Value.ToString().Contains("居住"))
                {
                    UIMessageBox.Show("此条消费记录为住房记录，无法删除！", "提示信息", UIStyle.Red);
                    return;
                }
                if (UIMessageDialog.ShowMessageDialog("你确定要删除该消费记录吗？", UILocalize.WarningTitle, true, Style))
                {
                    var spendTime = Convert.ToDateTime(dgvRoomSell.SelectedRows[0].Cells["clSpendTime"].Value.ToString());
                    string custoNo = dgvRoomSell.SelectedRows[0].Cells["clCustoNo"].Value.ToString();
                    string name = dgvRoomSell.SelectedRows[0].Cells["clSpendName"].Value.ToString();
                    string price = dgvRoomSell.SelectedRows[0].Cells["clSpendPrice"].Value.ToString();
                    dic = new Dictionary<string, string>()
                    {
                        { "name",name},
                        { "price",price}
                    };
                    result = HttpHelper.Request("Sellthing/SelectSellThingByNameAndPrice", null, dic);
                    if (result.statusCode != 200)
                    {
                        UIMessageBox.ShowError("SelectSellThingByNameAndPrice+接口服务异常，请提交Issue或尝试更新版本！");
                        return;
                    }
                    SellThing s = HttpHelper.JsonToModel<SellThing>(result.message);
                    decimal num = Convert.ToDecimal(dgvRoomSell.SelectedRows[0].Cells["clSpendAmount"].Value.ToString());
                    string Stock = (s.Stock + num).ToString();
                    dic = new Dictionary<string, string>()
                    {
                        { "roomNo",txtRoomNo.Text.Trim()},
                        { "custoNo",custoNo},
                        { "sellName",name}
                    };
                    result = HttpHelper.Request("Sellthing/DeleteSellThing", null, dic);
                    if (result.statusCode != 200)
                    {
                        UIMessageBox.ShowError("DeleteSellThing+接口服务异常，请提交Issue或尝试更新版本！");
                        return;
                    }
                    if (result.message.ToString().Equals("true"))
                    {
                        var sellThing = new SellThing { SellName = s.SellName, SellPrice = s.SellPrice, Stock = s.Stock, SellNo = s.SellNo, format = s.format };
                        result = HttpHelper.Request("Sellthing/UpdateSellthingInfo", HttpHelper.ModelToJson(sellThing));
                        if (result.statusCode != 200)
                        {
                            UIMessageBox.ShowError("UpdateSellthingInfo+接口服务异常，请提交Issue或尝试更新版本！");
                            return;
                        }
                        UIMessageTip.ShowOk("撤销成功！", 1000);
                        #region 获取添加操作日志所需的信息
                        RecordHelper.Record(LoginInfo.WorkerNo + "-" + LoginInfo.WorkerName + "在" + Convert.ToDateTime(DateTime.Now) + "位于" + LoginInfo.SoftwareVersion + "执行：" + "帮助" + custoNo + "撤销了消费商品:" + txtSellName.Text + "操作！", 2);
                        #endregion
                        LoadSpendInfoByRoomNo(txtRoomNo.Text);
                        LoadSellThingInfo();
                        nudNum.Value = 0;
                    }
                    else
                    {
                        UIMessageTip.ShowOk("撤销失败！", 1000);
                    }
                }
                else
                {
                    UIMessageTip.ShowError("操作取消！", 1000);
                }
            }
            else
            {
                UIMessageBox.Show("请选择要删除的消费记录！", "提示信息", UIStyle.Red);
            }
        }
        #endregion


        private void dgvSellthing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lblState.Visible == false)
            {
                UIMessageBox.Show("请先输入消费的房间！", "提示信息", UIStyle.Red);
                return;
            }
            txtSellNo.Text = dgvSellthing.SelectedRows[0].Cells["clSellNo"].Value.ToString();
            txtSellName.Text = dgvSellthing.SelectedRows[0].Cells["clSellName"].Value.ToString();
            txtPrice.Text = dgvSellthing.SelectedRows[0].Cells["clSellPrice"].Value.ToString();
        }


        private void nudNum_ValueChanged(object sender, double value)
        {
            if (nudNum.Value < 0)
            {
                nudNum.Value = 0;
            }
        }

        private void txtRoomNo_Validated(object sender, EventArgs e)
        {

        }

        private void txtRoomNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string room = txtRoomNo.Text.Trim();
            if (string.IsNullOrWhiteSpace(room) == true)
            {
                UIMessageTip.ShowWarning("请输入消费房间号！", 1000);
                return;
            }
            dic = new Dictionary<string, string>()
            {
                { "no",room}
            };
            result = HttpHelper.Request("Room/SelectRoomByRoomNo", null, dic);
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectRoomByRoomNo+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            Room r = HttpHelper.JsonToModel<Room>(result.message);
            if (txtRoomNo.Text == "")
            {
                lblState.Text = "";
            }
            else if (r == null)
            {
                lblState.Visible = true;
                lblState.Text = "该房间不存在";
                lblState.ForeColor = Color.Red;
                rs = 0;
                //LoadSpendInfo();
                //清空
            }
            else if (!r.IsNullOrEmpty())
            {
                if (r.RoomStateId == 1)
                {
                    lblState.Visible = true;
                    lblState.Text = "该房间可消费";
                    lblState.ForeColor = Color.Black;
                    LoadSpendInfoByRoomNo(room);
                    rs = 1;
                }
                else
                {
                    lblState.Visible = true;
                    lblState.Text = "该房间不可消费";
                    lblState.ForeColor = Color.Red;
                    rs = 0;
                    //LoadSpendInfo();
                    //清空
                }
            }
        }

        private void lblState_Click(object sender, EventArgs e)
        {

        }

        private void FrmSellThing_Activated(object sender, EventArgs e)
        {

        }
    }
}
