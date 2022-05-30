using Sunny.UI;
using SYS.Application;
using SYS.Common;
using SYS.Core;
using SYS.Core.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace SYS.FormUI
{
    public partial class FrmEditInputs : UIEditForm
    {
        public FrmEditInputs()
        {
            InitializeComponent();
        }

        protected override bool CheckData()
        {
            return CheckEmpty(txtCustoName, "请输入姓名")
                   && CheckEmpty(txtCardID, "请输入证件号码")
                   && CheckEmpty(txtTel, "输入11位手机号码")
                   && CheckEmpty(txtCustoAdress, "请填写居住地址");
        }

        private void FrmEditInputs_Load(object sender, EventArgs e)
        {
            foreach (Control label in this.Controls)
            {
                label.Font = UI_FontUtil.controlFont;
            }

            string cardId = new CounterHelper().GetNewId(CounterRuleConsts.CustoId);
            txtCustoNo.Text = cardId;

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
            List<SexType> listSexType = new BaseService().SelectSexTypeAll(new SexType { delete_mk = 0 });
            this.cbSex.DataSource = listSexType;
            this.cbSex.DisplayMember = "sexName";
            this.cbSex.ValueMember = "sexId";
            this.cbSex.SelectedIndex = 0;
            #endregion

            if (this.Text.Equals("修改客户信息"))
            {
                txtCustoNo.Text = FrmCustoManager.cm_CustoNo;
                txtCustoName.Text = FrmCustoManager.cm_CustoName;
                txtCustoAdress.Text = FrmCustoManager.cm_CustoAddress;
                cbCustoType.SelectedIndex = FrmCustoManager.cm_CustoType;
                cbSex.SelectedIndex = FrmCustoManager.cm_CustoSex;
                cbPassportType.SelectedIndex = FrmCustoManager.cm_PassportType;
                dtpBirthday.Value = FrmCustoManager.cm_CustoBirth;
                txtCardID.Text = FrmCustoManager.cm_CustoID;
                txtCustoAdress.Text = FrmCustoManager.cm_CustoAddress;
                txtTel.Text = FrmCustoManager.cm_CustoTel;
                btnOK.Text = "修改";

                this.ButtonOkClick -= new EventHandler(FrmEditInputs_ButtonOkClick);
                this.ButtonOkClick += new EventHandler(btnOK_UpdClick);

                if (!cbPassportType.SelectedText.ToString().Contains("身份证"))
                {
                    dtpBirthday.Enabled = true;
                    dtpBirthday.ReadOnly = false;
                    return;
                }
                
            }
        }

        private void btnOK_UpdClick(object sender, EventArgs e)
        {
            Custo custo = new Custo()
            {
                CustoNo = txtCustoNo.Text,
                CustoName = txtCustoName.Text,
                CustoSex = cbSex.SelectedIndex,
                CustoBirth = dtpBirthday.Value,
                CustoType = cbCustoType.SelectedIndex,
                PassportType = cbPassportType.SelectedIndex,
                CustoID = txtCardID.Text,
                CustoTel = txtTel.Text,
                CustoAdress = txtCustoAdress.Text,
                datachg_usr = LoginInfo.WorkerNo == null ? AdminInfo.Account : LoginInfo.WorkerNo,
                datachg_date = DateTime.Now

            };

            bool t = new CustoService().UpdCustomerInfoByCustoNo(custo);
            if (!t)
            {
                UIMessageBox.Show("修改失败", "系统提示", UIStyle.Red, UIMessageBoxButtons.OK);
                return;
                
            }

            UIMessageBox.Show("修改成功", "系统提示", UIStyle.Green, UIMessageBoxButtons.OK);
            #region 获取添加操作日志所需的信息
            RecordHelper.Record(LoginInfo.WorkerNo + "-" + LoginInfo.WorkerName + "在" + DateTime.Now + "位于" + LoginInfo.SoftwareVersion + "执行：" + "修改了一名客户信息，客户编号为：" + custo.CustoNo, 3);
            #endregion
            this.Close();
            FrmCustomerManager.ReloadCustomer();

            foreach (Control Ctrol in this.Controls)
            {
                if (Ctrol is Sunny.UI.UITextBox)
                {
                    Ctrol.Text = "";
                }
                if (Ctrol is Sunny.UI.UIComboBox)
                {
                    this.cbSex.SelectedIndex = 0;
                    this.cbCustoType.SelectedIndex = 0;
                    this.cbPassportType.SelectedIndex = 0;
                }
            }
        }

        private void FrmEditInputs_ButtonOkClick(object sender, EventArgs e)
        {
            Custo custo = new Custo()
            {
                CustoNo = txtCustoNo.Text,
                CustoName = txtCustoName.Text,
                CustoSex = cbSex.SelectedIndex,
                CustoBirth = dtpBirthday.Value,
                CustoType = cbCustoType.SelectedIndex,
                PassportType = cbPassportType.SelectedIndex,
                CustoID = txtCardID.Text,
                CustoTel = txtTel.Text,
                CustoAdress = txtCustoAdress.Text,
                datains_usr = LoginInfo.WorkerNo == null ? AdminInfo.Account : LoginInfo.WorkerNo,
                datains_date = DateTime.Now

            };

            if (new CustoService().InsertCustomerInfo(custo))
            {
                UIMessageBox.Show("添加成功", "系统提示", UIStyle.Green, UIMessageBoxButtons.OK);
                FrmCustomerManager.ReloadCustomer();
                #region 获取添加操作日志所需的信息
                RecordHelper.Record(LoginInfo.WorkerNo + "-" + LoginInfo.WorkerName + "在" + DateTime.Now + "位于" + LoginInfo.SoftwareVersion + "执行：" + "添加了一名客户，客户编号为：" + custo.CustoNo, 3);
                #endregion
                this.Close();
            }
            else
            {
                UIMessageBox.Show("添加失败", "系统提示", UIStyle.Red, UIMessageBoxButtons.OK);
                return;
            }


            foreach (Control Ctrol in this.Controls)
            {
                if (Ctrol is Sunny.UI.UITextBox)
                {
                    Ctrol.Text = "";
                }
                if (Ctrol is Sunny.UI.UIComboBox)
                {
                    this.cbSex.SelectedIndex = 0;
                    this.cbCustoType.SelectedIndex = 0;
                    this.cbPassportType.SelectedIndex = 0;
                }
            }
        }


        private void FrmEditInputs_ButtonCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCardID_Validated(object sender, EventArgs e)
        {
            //获取得到输入的身份证号码
            string identityCard = txtCardID.Text.Trim();

            if (!cbPassportType.SelectedText.ToString().Contains("身份证"))
            {
                dtpBirthday.Enabled = true;
                dtpBirthday.ReadOnly = false;
                return;
            }
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
                var address = result.Replace(",", "").ToString();
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

            cbPassportType.SelectedIndex = 0;

            return;
        }
    }
}
