using System;
using System.Windows.Forms;
using SYS.Core;
using Sunny.UI;
using System.Collections.Generic;
using SYS.Application;

namespace SYS.FormUI
{
    public partial class FrmSelectCustoInfo : UIForm
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

            #region 加载客户类型信息
            List<CustoType> lstSourceGrid = new BaseService().SelectCustoTypeAll();
            this.cbCustoType.DataSource = lstSourceGrid;
            this.cbCustoType.DisplayMember = "TypeName";
            this.cbCustoType.ValueMember = "UserType";
            this.cbCustoType.SelectedIndex = 0;
            this.cbCustoType.ReadOnly = true;
            #endregion

            #region 加载证件类型信息
            List<PassPortType> passPorts = new BaseService().SelectPassPortTypeAll();
            this.cbPassportType.DataSource = passPorts;
            this.cbPassportType.DisplayMember = "PassportName";
            this.cbPassportType.ValueMember = "PassportId";
            this.cbPassportType.SelectedIndex = 0;
            #endregion

            #region 加载性别信息
            List<SexType> listSexType = new BaseService().SelectSexTypeAll();
            this.cbSex.DataSource = listSexType;
            this.cbSex.DisplayMember = "sexName";
            this.cbSex.ValueMember = "sexId";
            this.cbSex.SelectedIndex = 0;
            #endregion
            
            txtCustoNo.Text = ucRoomList.rm_CustoNo;
            Custo c = new CustoService().SelectCardInfoByCustoNo(txtCustoNo.Text);
            txtCustoAdress.Text = c.CustoAdress;
            txtCustoName.Text = c.CustoName;
            txtCardID.Text = c.CustoID;
            txtCustoTel.Text = c.CustoTel;
            cbSex.Text = c.CustoSex == 1 ? "男" : "女";
            cbCustoType.SelectedIndex = c.CustoType;
            cbPassportType.SelectedIndex = c.PassportType;
            dtpBirthday.Value = c.CustoBirth;
        }
    }
}
