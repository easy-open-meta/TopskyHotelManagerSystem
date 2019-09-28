using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSHotelManagerSystem.BLL;
using TSHotelManagerSystem.DAL;
using TSHotelManagerSystem.Models;

namespace TSHotelManagerSystem
{
    public partial class FrmCheckIn : Form
    {
        public FrmCheckIn()
        {
            InitializeComponent();
        }

        public static string co_Day;
        public static string rm_RoomType;

        private void FrmCheckIn_Load(object sender, EventArgs e)
        {
            txtRoomNo.Text = ucRoomList.rm_RoomNo;
            Room r = RoomManager.SelectRoomByRoomNo(txtRoomNo.Text);
            RoomType t = RoomTypeManager.SelectRoomTypeByRoomNo(txtRoomNo.Text);
            txtType.Text = t.RoomName;
            txtMoney.Text = r.RoomMoney.ToString();
            txtRoomPosition.Text = r.RoomPosition;
            txtState.Text = r.RoomState;
            txtState.Text = RoomManager.SelectRoomStateNameByRoomNo(txtRoomNo.Text).ToString();
            List<Custo> ctos = CustoService.SelectCanUseCustoAll();
            List<Room> roms = RoomManager.SelectCanUseRoomAll();
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

        private void txtRoomNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Room r = RoomManager.SelectRoomByRoomNo(txtRoomNo.Text);
                RoomType t = RoomTypeManager.SelectRoomTypeByRoomNo(txtRoomNo.Text);
                txtType.Text = t.RoomName;
                txtMoney.Text = r.RoomMoney.ToString();
                txtRoomPosition.Text = r.RoomPosition;
                txtState.Text = r.RoomState;
                txtState.Text = RoomManager.SelectRoomStateNameByRoomNo(txtRoomNo.Text).ToString();
            }
            catch
            {
                txtType.Text = "";
                txtMoney.Text = "";
                txtRoomPosition.Text = "";
                txtState.Text = "";
                txtState.Text = "";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region 验证输入完整性
        /// <summary>
        /// 验证输入完整性
        /// </summary>
        private bool CheckInupt()
        {
            if(txtCustoNo.Text=="")
            {
                MessageBox.Show("请输入客户编号！", "来自小T的提示");
                txtCustoNo.Focus();
                return false;
            }
            if (txtCheckNum.Text == "")
            {
                MessageBox.Show("请输入入住天数！", "来自小T的提示");
                txtCheckNum.Focus();
                return false;
            }
            if (txtPersonNum.Text == "")
            {
                MessageBox.Show("请输入入住人数！", "来自小T的提示");
                txtPersonNum.Focus();
                return false;
            }
            return true;
        } 
        #endregion

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (CheckInupt())
            {
                #region 获取添加消费信息所需的信息
                Spend s = new Spend();
                s.RoomNo = txtRoomNo.Text;
                s.CustoNo = txtCustoNo.Text;
                s.SpendName = "住房";
                s.SpendAmount = Convert.ToInt32(txtCheckNum.Text);
                s.SpendPrice = Convert.ToDecimal(txtMoney.Text);
                s.SpendMoney = Convert.ToDecimal(Convert.ToDouble(txtMoney.Text) * Convert.ToDouble(txtCheckNum.Text));
                s.SpendTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                s.MoneyState = "未结算";
                #endregion

                if (CustoManager.SelectCustoByCustoNo(txtCustoNo.Text) != null)
                {
                    Room r = new Room();
                    r.CheckTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    r.CustoNo = txtCustoNo.Text;
                    r.PersonNum = txtPersonNum.Text;
                    r.RoomStateId = 1;
                    r.RoomNo = txtRoomNo.Text;

                    int n = RoomManager.UpdateRoomInfo(r);
                    if (n > 0)
                    {
                        MessageBox.Show("登记入住成功！", "登记提示");
                        SpendManager.InsertSpendInfo(s);
                        txtCustoNo.Text = "";
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("登记入住失败！", "登记提示");
                    }
                }
                else
                {
                    MessageBox.Show("客户编号不存在！", "来自小T的提示");
                }
            }
        }
    }
}
