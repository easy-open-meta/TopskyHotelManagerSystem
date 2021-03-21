using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using SYS.Core;
using Sunny.UI;
using System.Transactions;
using SYS.Core.Util;
using System.Collections.Generic;
using SYS.Application;

namespace SYS.FormUI
{
    public partial class FrmReserList : UIForm
    {
        public FrmReserList()
        {
            InitializeComponent();
        }

        

        private void FrmReserList_Load(object sender, EventArgs e)
        {
            foreach (Control label in this.Controls)
            {
                label.Font = UI_FontUtil.controlFont;
            }
            //cbCustoType.SelectedIndex = 0;
            dgvReserList.AutoGenerateColumns = false;
            dgvReserList.DataSource = new ReserService().SelectReserAll();

            #region 加载客户类型信息
            List<CustoType> lstSourceGrid = new BaseService().SelectCustoTypeAllCanUse();
            this.cbCustoType.DataSource = lstSourceGrid;
            this.cbCustoType.DisplayMember = "TypeName";
            this.cbCustoType.ValueMember = "UserType";
            this.cbCustoType.SelectedIndex = 0;
            this.cbCustoType.ReadOnly = true;
            #endregion

            #region 加载证件类型信息
            List<PassPortType> passPorts = new BaseService().SelectPassPortTypeAllCanUse();
            this.cbPassportType.DataSource = passPorts;
            this.cbPassportType.DisplayMember = "PassportName";
            this.cbPassportType.ValueMember = "PassportId";
            this.cbPassportType.SelectedIndex = 0;
            #endregion

            #region 加载性别信息
            List<SexType> listSexType = new BaseService().SelectSexTypeAllCanUse();
            this.cbSex.DataSource = listSexType;
            this.cbSex.DisplayMember = "sexName";
            this.cbSex.ValueMember = "sexId";
            this.cbSex.SelectedIndex = 0;
            #endregion
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                Custo custo = new Custo()
                {
                    CustoNo = txtCustoNo.Text.Trim(),
                    CustoName = txtCustoName.Text.Trim(),
                    CustoSex = cbSex.SelectedIndex,
                    CustoTel = txtTel.Text.Trim(),
                    PassportType = cbPassportType.SelectedIndex,
                    CustoID = txtCardID.Text.Trim(),
                    CustoAdress = txtCustoAdress.Text.Trim(),
                    CustoBirth = dtpBirthday.Value,
                    CustoType = cbCustoType.SelectedIndex
                };
                new CustoService().InsertCustomerInfo(custo);

                Room r = new Room() 
                {
                    CheckTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                    CustoNo = custo.CustoNo,
                    RoomStateId = 1,
                    RoomNo = dgvReserList.SelectedRows[0].Cells["clRoomNo"].Value.ToString()
                };
                
                new RoomService().UpdateRoomInfo(r);
                new ReserService().DeleteReserInfo(dgvReserList.SelectedRows[0].Cells["clReserNo"].Value.ToString());
                scope.Complete();
            }
            UIMessageBox.ShowSuccess("操作成功");
            dgvReserList.AutoGenerateColumns = false;
            dgvReserList.DataSource = new ReserService().SelectReserAll();

        }

        private void dgvReserList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string custoNo = new CounterHelper().GetNewId("CustoId");
            txtCustoNo.Text = custoNo;
            txtCustoName.Text = dgvReserList.SelectedRows[0].Cells["clCustoNm"].Value.ToString();
            txtTel.Text = dgvReserList.SelectedRows[0].Cells["clTel"].Value.ToString();
        }

        private void txtCardID_Validated(object sender, EventArgs e)
        {
            //获取得到输入的身份证号码
            string identityCard = txtCardID.Text.Trim();
            if (string.IsNullOrEmpty(identityCard))
            {
                //身份证号码不能为空，如果为空返回
                UIMessageBox.ShowError("身份证号码不能为空！");
                if (txtCardID.CanFocus)
                {
                    txtCardID.Focus();//设置当前输入焦点为txtCardID_identityCard
                }
                return;
            }
            else
            {
                //身份证号码只能为15位或18位其它不合法
                if (identityCard.Length != 15 && identityCard.Length != 18)
                {
                    UIMessageBox.ShowWarning("身份证号码为15位或18位，请检查！");
                    if (txtCardID.CanFocus)
                    {
                        txtCardID.Focus();
                    }
                    return;
                }
            }
            string birthday = "";
            string sex = "";
            if (identityCard.Length == 18)
            {
                var result = new IDCardUtil().SelectCardCode(identityCard);
                var address = result.Replace(",","").ToString();
                birthday = identityCard.Substring(6, 4) + "-" + identityCard.Substring(10, 2) + "-" + identityCard.Substring(12, 2);
                sex = identityCard.Substring(14, 3);
                txtCustoAdress.Text = address;
                //性别代码为偶数是女性奇数为男性
                if (int.Parse(sex) % 2 == 0)
                {
                    cbSex.Text = "女";
                }
                else
                {
                    cbSex.Text = "男";
                }
            }
            try
            {
                dtpBirthday.Value = Convert.ToDateTime(birthday);
            }
            catch
            {
                UIMessageBox.ShowError("请正确输入证件号码！");
            }

        }
    }
}
