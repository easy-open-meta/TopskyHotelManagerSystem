using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SYS.FormUI.BLL;
using SYS.Core;

namespace SYS.FormUI
{
    public partial class FrmSellThing : Form
    {
        private int rs = 0;//用于判断房间是否可消费

        public FrmSellThing()
        {
            InitializeComponent();
        }

        public void CmpSetDgv()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvRoomSell.AllowUserToAddRows = false;
            this.dgvRoomSell.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            this.dgvRoomSell.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRoomSell.BackgroundColor = System.Drawing.Color.White;
            this.dgvRoomSell.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRoomSell.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;//211, 223, 240
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("苹方-简", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvRoomSell.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRoomSell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomSell.EnableHeadersVisualStyles = false;
            this.dgvRoomSell.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvRoomSell.ReadOnly = true;
            this.dgvRoomSell.RowHeadersVisible = false;
            this.dgvRoomSell.RowTemplate.Height = 23;
            this.dgvRoomSell.RowTemplate.ReadOnly = true;
        }

        public void CmpSetDgv1()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSellthing.AllowUserToAddRows = false;
            this.dgvSellthing.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            this.dgvSellthing.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSellthing.BackgroundColor = System.Drawing.Color.White;
            this.dgvSellthing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSellthing.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;//211, 223, 240
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvSellthing.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSellthing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSellthing.EnableHeadersVisualStyles = false;
            this.dgvSellthing.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvSellthing.ReadOnly = true;
            this.dgvSellthing.RowHeadersVisible = false;
            this.dgvSellthing.RowTemplate.Height = 23;
            this.dgvSellthing.RowTemplate.ReadOnly = true;
        }

        #region 窗体加载事件
        private void FrmSellThing_Load(object sender, EventArgs e)
        {
            CmpSetDgv();
            CmpSetDgv1();
            List<Room> roms = RoomManager.SelectRoomByStateAll();
            for (int i = 0; i < roms.Count; i++)
            {
                txtRoomNo.AutoCompleteCustomSource.Add(roms[i].RoomNo);
            }
            LoadSellThingInfo();
            //LoadSpendInfo();
        }
        #endregion

        #region 查询事件
        private void btnFind_Click(object sender, EventArgs e)
        {
            LoadThingByName();
        }
        #endregion

        #region dgvSellThing加载数据事件
        private void dgvSellthing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSellthing.SelectedRows.Count > 0)
            {
                txtSellNo.Text = dgvSellthing.SelectedRows[0].Cells["SellNo"].Value.ToString();
                txtSellName.Text = dgvSellthing.SelectedRows[0].Cells["SellName"].Value.ToString();
                txtPrice.Text = dgvSellthing.SelectedRows[0].Cells["SellPrice"].Value.ToString();
            }
        }
        #endregion

        #region 查询文本框更改事件
        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            LoadThingByName();
        }

        private void LoadThingByName()
        {
            dgvSellthing.DataSource = SellThingManager.SelectThingByName(txtFind.Text);
        }
        #endregion

        #region 房间编号文本框更改事件
        private void txtRoomNo_TextChanged(object sender, EventArgs e)
        {
            string room = txtRoomNo.Text;
            Room r = RoomManager.SelectRoomByRoomNo(room);
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
                    LoadSpendInfo(room);
                    rs = 1;
                }
                else
                {
                    lblState.Text = "该房间不可消费";
                    lblState.ForeColor = Color.Red;
                    rs = 0;
                    //LoadSpendInfo();
                    //清空
                }
            }
        }
        #endregion

        #region 根据客户编号加载消费信息的方法
        private void LoadSpendInfo(string room)
        {
            dgvRoomSell.DataSource = SpendManager.SelectSpendByCustoNo(room);
        }
        #endregion

        #region 商品加载事件方法
        public void LoadSellThingInfo()
        {
            dgvSellthing.DataSource = SellThingManager.SelectSellThingAll();
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

        #region 加载消费信息方法
        public void LoadSpendInfo()
        {
            dgvRoomSell.AutoGenerateColumns = false;
            dgvRoomSell.DataSource = SpendManager.SelectSpendInfoAll();
        }
        #endregion

        #region 添加事件
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (rs == 1)//判断房间编号是否可消费
            {
                if (CheckInput())
                {
                    SellThing st = SellThingManager.SelectSellThingByNo(txtSellNo.Text);

                    Room r = RoomManager.SelectRoomByRoomNo(txtRoomNo.Text);
                    Spend s = new Spend()
                    {
                        RoomNo = txtRoomNo.Text,
                        SpendName = txtSellName.Text,
                        SpendAmount = (int)nudNum.Value,
                        CustoNo = r.CustoNo,
                        SpendPrice = Convert.ToDecimal(txtPrice.Text),
                        SpendMoney = Convert.ToDecimal(txtPrice.Text) * nudNum.Value,
                        SpendTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                        MoneyState = "未结算",
                    };
                    int m = SpendManager.InsertSpendInfo(s);
                    if (m > 0)
                    {
                        MessageBox.Show("添加成功");
                        string Stock = (st.Stock - nudNum.Value).ToString();
                        int n = SellThingManager.UpdateSellThing(Stock, st.SellNo);
                        LoadSpendInfo(r.RoomNo);
                        LoadSellThingInfo();
                        #region 获取添加操作日志所需的信息
                        Operation o = new Operation();
                        o.OperationTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd,HH:mm:ss"));
                        o.Operationlog = LoginInfo.WorkerClub + LoginInfo.WorkerPosition + LoginInfo.WorkerName + "于" + DateTime.Now + "帮助" + dgvRoomSell.SelectedRows[0].Cells["CustoNo"].Value.ToString() + "进行了消费商品:" + txtSellName.Text + "操作！";
                        o.OperationAccount = LoginInfo.WorkerClub + LoginInfo.WorkerPosition + LoginInfo.WorkerName;
                        #endregion
                        OperationManager.InsertOperationLog(o);
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
            if (dgvSellthing.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("你确定要删除该消费记录吗？", "删除提示",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dr == DialogResult.Yes)
                {

                    string time = dgvRoomSell.SelectedRows[0].Cells["SpendTime"].Value.ToString();
                    string name = dgvRoomSell.SelectedRows[0].Cells["SpendName"].Value.ToString();
                    string price = dgvRoomSell.SelectedRows[0].Cells["SpendPrice"].Value.ToString();
                    SellThing s = SellThingManager.SelectSellThingByNameAndPrice(name, price);
                    decimal num = Convert.ToDecimal(dgvRoomSell.SelectedRows[0].Cells["SpendAmount"].Value.ToString());
                    string Stock = (s.Stock + num).ToString();
                    if (SellThingManager.DeleteSellThing(txtRoomNo.Text, time) > 0)
                    {
                        MessageBox.Show("删除成功！", "删除提示");
                        int n = SellThingManager.UpdateSellThing(Stock, s.SellNo);
                        LoadSpendInfo(txtRoomNo.Text);
                        LoadSellThingInfo();
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("请选择要删除的消费记录！", "提示信息");
            }
        }
        #endregion

        #region dgvRoomSell消费数据加载事件
        private void dgvRoomSell_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvSellthing.SelectedRows.Count > 0)
                {
                    txtRoomNo.Text = dgvRoomSell.SelectedRows[0].Cells["RoomNo"].Value.ToString();
                    txtSellName.Text = dgvRoomSell.SelectedRows[0].Cells["SpendName"].Value.ToString();
                    nudNum.Value = Convert.ToDecimal(dgvRoomSell.SelectedRows[0].Cells["SpendAmount"].Value.ToString());
                    txtPrice.Text = dgvRoomSell.SelectedRows[0].Cells["SpendPrice"].Value.ToString();
                    SellThing s = SellThingManager.SelectSellThingByNameAndPrice(txtSellName.Text, txtPrice.Text);
                    txtSellNo.Text = s.SellNo;
                }
            }
            catch { return; }
        }
        #endregion
    }
}
