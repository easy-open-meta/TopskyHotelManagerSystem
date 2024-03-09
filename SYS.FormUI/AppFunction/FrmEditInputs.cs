
using EOM.TSHotelManager.Common.Core;
using Sunny.UI;
using SYS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SYS.FormUI
{
    public partial class FrmEditInputs : UIEditForm
    {
        public FrmEditInputs()
        {
            InitializeComponent();
        }

        Dictionary<string, string> dic = null;
        ResponseMsg result = null;

        protected override bool CheckData()
        {
            return CheckEmpty(txtCustoNo, "请输入客户ID")
                   && CheckEmpty(txtCustoName, "请输入姓名")
                   && CheckEmpty(cbCustoType, "请选择客户类型")
                   && CheckEmpty(cbPassportType, "请选择证件类型")
                   && CheckEmpty(cbSex, "请选择客户性别")
                   && CheckEmpty(dtpBirthday, "请选择客户生日")
                   && CheckEmpty(txtCardID, "请输入证件号码")
                   && CheckEmpty(txtTel, "输入11位手机号码")
                   && CheckEmpty(txtCustoAdress, "请填写居住地址");
        }

        private void FrmEditInputs_Load(object sender, EventArgs e)
        {
            string cardId = Util.GetListNewId("TS", 3, 1, "-").FirstOrDefault();
            txtCustoNo.Text = cardId;

            #region 加载客户类型信息
            var result = HttpHelper.Request("Base/SelectCustoTypeAllCanUse");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectCustoTypeAllCanUse+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            List<CustoType> lstSourceGrid = HttpHelper.JsonToList<CustoType>(result.message);
            this.cbCustoType.DataSource = lstSourceGrid;
            this.cbCustoType.DisplayMember = "TypeName";
            this.cbCustoType.ValueMember = "UserType";
            this.cbCustoType.SelectedIndex = 0;
            this.cbCustoType.ReadOnly = true;
            #endregion

            #region 加载证件类型信息
            result = HttpHelper.Request("Base/SelectPassPortTypeAllCanUse");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectPassPortTypeAllCanUse+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            List<PassPortType> passPorts = HttpHelper.JsonToList<PassPortType>(result.message);
            this.cbPassportType.DataSource = passPorts;
            this.cbPassportType.DisplayMember = "PassportName";
            this.cbPassportType.ValueMember = "PassportId";
            this.cbPassportType.SelectedIndex = 0;
            #endregion

            #region 加载性别信息
            result = HttpHelper.Request("Base/SelectSexTypeAll?delete_mk=0");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectSexTypeAll+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            List<SexType> listSexType = HttpHelper.JsonToList<SexType>(result.message);
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
                CustoSex = Convert.ToInt32(cbSex.SelectedValue.ToString()),
                CustoBirth = dtpBirthday.Value,
                CustoType = Convert.ToInt32(cbCustoType.SelectedValue.ToString()),
                PassportType = Convert.ToInt32(cbPassportType.SelectedValue.ToString()),
                CustoID = txtCardID.Text,
                CustoTel = txtTel.Text,
                CustoAdress = txtCustoAdress.Text,
                datachg_usr = LoginInfo.WorkerNo == null ? AdminInfo.Account : LoginInfo.WorkerNo,
            };

            result = HttpHelper.Request("Custo/UpdCustomerInfoByCustoNo", HttpHelper.ModelToJson(custo));
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("UpdCustomerInfoByCustoNo+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            bool t = result.message.ToString().Equals("true") ? true : false;
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
                CustoSex = Convert.ToInt32(cbSex.SelectedValue.ToString()),
                CustoBirth = dtpBirthday.Value,
                CustoType = Convert.ToInt32(cbCustoType.SelectedValue.ToString()),
                PassportType = Convert.ToInt32(cbPassportType.SelectedValue.ToString()),
                CustoID = txtCardID.Text,
                CustoTel = txtTel.Text,
                CustoAdress = txtCustoAdress.Text,
                datains_usr = LoginInfo.WorkerNo == null ? AdminInfo.Account : LoginInfo.WorkerNo,

            };

            result = HttpHelper.Request("Custo/InsertCustomerInfo", HttpHelper.ModelToJson<Custo>(custo), null);
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("InsertCustomerInfo+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            if (result.message.ToString().Equals("true"))
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

            if (identityCard.Length == 18)
            {
                var result = Util.searchCode(identityCard);
                if (result.message.IsNullOrEmpty()) //如果没有错误消息输出，则代表成功
                {
                    try
                    {
                        cbSex.Text = result.sex;
                        txtCustoAdress.Text = result.address;
                        dtpBirthday.Value = Convert.ToDateTime(result.birthday);
                    }
                    catch
                    {
                        UIMessageBox.ShowError("请正确输入证件号码！");
                        return;
                    }
                    finally
                    {
                        cbPassportType.SelectedIndex = 0;
                    }
                }
                else
                {
                    UIMessageBox.ShowError(result.message);
                    return;
                }
            }
            return;
        }
    }
}
