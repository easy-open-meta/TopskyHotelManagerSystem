/*
 * MIT License
 *Copyright (c) 2021 咖啡与网络(java-and-net)

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
using MySql.Data.MySqlClient;
using Sunny.UI;
using SYS.Application;
using SYS.Core;
using SYS.Core.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYS.FormUI
{
    public partial class FrmInputs : Sunny.UI.UIForm
    {
        public FrmInputs()
        {
            InitializeComponent();
        }

        private void FrmInputs_Load(object sender, EventArgs e)
        {
            foreach (Control label in this.Controls)
            {
                label.Font = UI_FontUtil.controlFont;
            }

            string cardId = new CounterHelper().GetNewId("CustoId");
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
            List<SexType> listSexType = new BaseService().SelectSexTypeAllCanUse();
            this.cbSex.DataSource = listSexType;
            this.cbSex.DisplayMember = "sexName";
            this.cbSex.ValueMember = "sexId";
            this.cbSex.SelectedIndex = 0;
            #endregion

            if (this.Text == "修改客户")
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
                this.btnOK.Click -= new EventHandler(btnOK_BtnClick);
                this.btnOK.Click += new EventHandler(btnOK_UpdClick);
            }

        }


        private void btnClose_BtnClick(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool CheckInput(Custo custo)
        {
            if (string.IsNullOrWhiteSpace(custo.CustoNo))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(custo.CustoName))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(custo.CustoSex + ""))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(custo.CustoType + ""))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(custo.CustoBirth + ""))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(custo.PassportType + ""))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(custo.CustoID))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(custo.CustoAdress))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(custo.CustoTel))
            {
                return false;
            }
            return true;
        }
        private void btnOK_BtnClick(object sender, EventArgs e)
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
            try
            {
                if (CheckInput(custo))
                {
                    bool t = new CustoService().InsertCustomerInfo(custo);
                    if (t == true)
                    {
                        UIMessageBox.Show("添加成功","系统提示",UIStyle.Green,UIMessageBoxButtons.OK);
                        #region 获取添加操作日志所需的信息
                        OperationLog o = new OperationLog()
                        {
                            OperationTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd,HH:mm:ss")),
                            Operationlog = "编号：" + LoginInfo.WorkerNo + "【" + FrmMain.wk_WorkerName + "】" + "于" + DateTime.Now + "添加了一名客户，客户编号为：" + custo.CustoNo,
                            OperationAccount = LoginInfo.WorkerNo,
                            datains_usr = LoginInfo.WorkerNo == null ? AdminInfo.Account : LoginInfo.WorkerNo,
                            datains_date = DateTime.Now
                        };
                        new OperationlogService().InsertOperationLog(o);
                        #endregion
                        FrmCustoManager.Reload();
                    }
                    else 
                    {
                        UIMessageBox.Show("添加失败", "系统提示", UIStyle.Red, UIMessageBoxButtons.OK);
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
                    
                    
            }
            catch
            {


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
            try
            {
                if (CheckInput(custo))
                {
                    //启用MD5对涉密信息进行加密
                    var NewID = Md5LockedUtil.MD5Encrypt32(custo.CustoID);
                    var NewTel = Md5LockedUtil.MD5Encrypt32(custo.CustoTel);
                    var NewAddress = Md5LockedUtil.MD5Encrypt32(custo.CustoAdress);
                    custo.CustoID = NewID;
                    custo.CustoTel = NewTel;
                    custo.CustoAdress = NewAddress;
                    bool t = new CustoService().UpdCustomerInfoByCustoNo(custo);
                    if (t == true)
                    {
                        UIMessageBox.Show("修改成功", "系统提示", UIStyle.Green, UIMessageBoxButtons.OK);
                        #region 获取添加操作日志所需的信息
                        OperationLog o = new OperationLog()
                        {
                            OperationTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd,HH:mm:ss")),
                            Operationlog = "编号：" + LoginInfo.WorkerNo + "【" + FrmMain.wk_WorkerName + "】" + "于" + DateTime.Now + "修改了一名客户信息，客户编号为：" + custo.CustoNo,
                            OperationAccount = LoginInfo.WorkerNo,
                            datains_usr = LoginInfo.WorkerNo == null ? AdminInfo.Account : LoginInfo.WorkerNo,
                            datains_date = DateTime.Now
                        };
                        new OperationlogService().InsertOperationLog(o);
                        #endregion
                        FrmCustoManager.Reload();
                    }
                    else
                    {
                        UIMessageBox.Show("修改失败", "系统提示", UIStyle.Red, UIMessageBoxButtons.OK);
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
            }
            catch
            {


            }
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
