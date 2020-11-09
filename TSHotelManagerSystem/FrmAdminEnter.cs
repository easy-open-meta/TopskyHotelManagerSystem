using System;
using System.Windows.Forms;
using TSHotelManagerSystem.BLL;
using Core;

namespace TSHotelManagerSystem
{
    public partial class FrmAdminEnter : Form
    {
        public FrmAdminEnter()
        {
            InitializeComponent();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            string pass = txtAdminPassword.Text;//获取超管密码
            Admin a = AdminManager.SelectMangerByPass(pass);
            if (a != null)//判断超管是否存在
            {
                a = AdminManager.SelectMangerByPass(pass);
                if (a != null) //判断超管密码是否正确
                {
                    AdminInfo.Password = a.AdminPassword;
                    AdminInfo.adminType = a.AdminType;
                    AdminInfo.admingroup = a.AdminGroup;
                    AdminInfo.adminpwd = txtAdminPassword.Text;
                    FrmBackAdmin fm = new FrmBackAdmin();
                    fm.Show();//打开主窗体

                    this.Hide();//隐藏登录窗体

                }
                else
                {
                    MessageBox.Show("错误");
                }
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
