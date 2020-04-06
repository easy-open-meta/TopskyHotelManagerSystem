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
using TSHotelManagerSystem.Models;

namespace TSHotelManagerSystem
{
    public partial class FrmSelectCustoInfo : Form
    {
        public FrmSelectCustoInfo()
        {
            InitializeComponent();
        }

        #region 存放客户信息类
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
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSelectCustoInfo_Load(object sender, EventArgs e)
        {
            txtCustoNo.Text = ucRoomList.rm_CustoNo;
            Custo c = CustoManager.SelectCustoByCustoNo(txtCustoNo.Text);
            txtAddress.Text = c.CustoAdress;
            txtCustoName.Text = c.CustoName;
            txtPassportNum.Text = c.CustoID;
            txtTel.Text = c.CustoTel;
            cboCustoSex.Text = c.CustoSex;
            cboCustoType.SelectedIndex = c.CustoType;
            cboPassportType.SelectedIndex = c.PassportType;
            dtpBirth.Value = c.CustoBirth;
            //txtCustoName.Text = ucRoomList.us_CustoName;
            //cboCustoSex.Text = ucRoomList.us_CustoSex;
            //dtpBirth.Value = DateTime.Parse(ucRoomList.us_CustoBirthday);
            //txtAddress.Text = ucRoomList.us_CustoAddress;
            //txtTel.Text = ucRoomList.us_CustoTel;
            //cboCustoType.SelectedIndex = ucRoomList.us_CustoType;
            //txtPassportNum.Text = ucRoomList.us_CustoID;
            //cboPassportType.SelectedIndex = ucRoomList.us_CustoPassportType;
        }
    }
}
