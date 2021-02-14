using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SYS.Core;
using Sunny.UI;
using SYS.Application;

namespace SYS.FormUI
{
    public partial class FrmSellThing : Sunny.UI.UIForm
    {
        private int rs = 0;//用于判断房间是否可消费

        public FrmSellThing()
        {
            InitializeComponent();
        }

        #region 窗体加载事件
        private void FrmSellThing_Load(object sender, EventArgs e)
        {

            foreach (Control label in this.Controls)
            {
                label.Font = UI_FontUtil.SetChildControlsFont();
            }

            List<Room> roms = new RoomService().SelectRoomByStateAll();
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
            
            List<SellThing> lstSource = new SellService().SelectSellThingByName(txtFind.Text);
            this.dgvSellthing.DataSource = lstSource;
            this.dgvSellthing.AutoGenerateColumns = false;
        }
        #endregion


        #region 根据客户编号加载消费信息的方法
        private void LoadSpendInfoByRoomNo(string room)
        {
            List<Spend> lstSource = new SpendService().SelectSpendByRoomNo(room);
            this.dgvRoomSell.DataSource = lstSource;
            this.dgvRoomSell.AutoGenerateColumns = false;
        }

        private void LoadSpendInfoByCustoNo(string custoNo)
        {
            List<Spend> lstSource = new SpendService().SelectSpendByCustoNo(custoNo);
            this.dgvRoomSell.DataSource = lstSource;
            this.dgvRoomSell.AutoGenerateColumns = false;
        }
        #endregion

        #region 商品加载事件方法
        public void LoadSellThingInfo()
        {
            
            List<SellThing> lstSource = new SellService().SelectSellThingAll();
            this.dgvSellthing.DataSource = lstSource;
            this.dgvSellthing.AutoGenerateColumns = false;
        }
        #endregion

        #region 判断输入的完整性的方法
        public bool CheckInput()
        {
            if (txtRoomNo.Text == "")
            {
                MessageBox.Show("消费房间不能为空", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtRoomNo.Focus();
                return false;
            }
            if (txtSellNo.Text == "")
            {
                MessageBox.Show("商品编号不能为空", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtSellNo.Focus();
                return false;
            }
            if (txtSellName.Text == "")
            {
                MessageBox.Show("商品名称不能为空", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtSellName.Focus();
                return false;
            }
            if (txtPrice.Text == "")
            {
                MessageBox.Show("商品单价不能为空", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtPrice.Focus();
                return false;
            }
            if (nudNum.Value <= 0)
            {
                MessageBox.Show("数量不能小于0", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtPrice.Focus();
                return false;
            }
            return true;
        }
        #endregion

        #region 添加事件
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (rs == 1)//判断房间编号是否可消费
            {
                if (CheckInput())
                {
                    SellThing st = new SellService().SelectSellThingByNo(txtSellNo.Text);

                    Room r = new RoomService().SelectRoomByRoomNo(txtRoomNo.Text);
                    Spend s = new Spend()
                    {
                        RoomNo = txtRoomNo.Text,
                        SpendName = txtSellName.Text,
                        SpendAmount = (int)nudNum.Value,
                        CustoNo = r.CustoNo,
                        SpendPrice = Convert.ToDecimal(txtPrice.Text),
                        SpendMoney = Convert.ToDecimal(Convert.ToDouble(txtPrice.Text) * nudNum.Value),
                        SpendTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                        MoneyState = "未结算",
                    };
                    bool m = new SpendService().InsertSpendInfo(s);
                    if (m == true)
                    {
                        string Stock = (st.Stock - nudNum.Value).ToString();
                        bool n = new SellService().UpdateSellThing(Stock, st.SellNo);
                        MessageBox.Show("添加成功");
                        LoadSpendInfoByCustoNo(r.CustoNo);
                        LoadSellThingInfo();
                        #region 获取添加操作日志所需的信息
                        OperationLog o = new OperationLog();
                        o.OperationTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd,HH:mm:ss"));
                        o.Operationlog = LoginInfo.WorkerClub + LoginInfo.WorkerPosition + LoginInfo.WorkerName + "于" + DateTime.Now + "帮助" + s.CustoNo + "进行了消费商品:" + txtSellName.Text + "操作！";
                        o.OperationAccount = LoginInfo.WorkerNo;
                        o.datains_usr = LoginInfo.WorkerNo;
                        o.datains_date = DateTime.Now;
                        #endregion
                        new OperationlogService().InsertOperationLog(o);
                    }
                    else
                    {
                        MessageBox.Show("添加失败");
                    }
                }
            }
        }
        #endregion

        #region 撤回消费事件
        private void btnCancel_Click(object sender, EventArgs e)
        {

            if (dgvRoomSell.SelectedRows.Count > 0)
            {
                if(UIMessageDialog.ShowMessageDialog("你确定要删除该消费记录吗？", UILocalize.WarningTitle, true,Style))
                {
                    string time = dgvRoomSell.SelectedRows[0].Cells["clSpendTime"].Value.ToString();
                    string name = dgvRoomSell.SelectedRows[0].Cells["clSpendName"].Value.ToString();
                    string price = dgvRoomSell.SelectedRows[0].Cells["clSpendPrice"].Value.ToString();
                    SellThing s = new SellService().SelectSellThingByNameAndPrice(name, price);
                    decimal num = Convert.ToDecimal(dgvRoomSell.SelectedRows[0].Cells["clSpendAmount"].Value.ToString());
                    string Stock = (s.Stock + num).ToString();
                    if (new SellService().DeleteSellThing(txtRoomNo.Text, time) == true)
                    {

                        bool n = new SellService().UpdateSellThing(Stock, s.SellNo);
                        UIMessageTip.ShowOk("撤销成功！",1000);
                        LoadSpendInfoByRoomNo(txtRoomNo.Text);
                        LoadSellThingInfo();
                    }
                }
                else
                {
                    UIMessageTip.ShowError("操作取消！",1000);
                }
            }
            else
            {
                MessageBox.Show("请选择要删除的消费记录！", "提示信息");
            }
        }
        #endregion


        private void dgvSellthing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
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
            string room = txtRoomNo.Text;
            Room r = new RoomService().SelectRoomByRoomNo(room);
            if (txtRoomNo.Text == "")
            {
                lblState.Text = "";
            }
            else if (r == null)
            {
                lblState.Text = "该房间不存在";
                lblState.ForeColor = Color.Red;
                rs = 0;
                //LoadSpendInfo();
                //清空
            }
            else if (r != null)
            {
                if (r.RoomStateId == 1)
                {
                    lblState.Text = "该房间可消费";
                    lblState.ForeColor = Color.Black;
                    LoadSpendInfoByRoomNo(room);
                    rs = 1;
                }
                else
                {
                    lblState.Text = "该房间不可消费";
                    lblState.ForeColor = Color.Red;
                    rs = 0;
                    this.dgvSellthing.DataSource = null;
                    //LoadSpendInfo();
                    //清空
                }
            }
        }
    }
}
