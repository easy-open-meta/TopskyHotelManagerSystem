using MySql.Data.MySqlClient;
using SYS.Application;
using SYS.Core;
using SYS.Manager;
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
                if (label.GetType().ToString() == "System.Windows.Forms.Label")
                {
                    label.Font = UI_FontUtil.SetControlFont();
                }
            }
            txtCustoNo.Text = CustoManager.GetRandomCustoNo();
            
            #region 加载客户类型信息
            List<CustoType> lstSourceGrid = CustoTypeManager.SelectCustoTypesAll();
            this.cbCustoType.DataSource = lstSourceGrid;
            this.cbCustoType.DisplayMember = "TypeName";
            this.cbCustoType.ValueMember = "UserType";
            this.cbCustoType.SelectedIndex = 0;
            this.cbCustoType.ReadOnly = true;
            #endregion

            #region 加载证件类型信息
            List<PassPortType> passPorts = CustoTypeManager.SelectPassPortTypeAll();
            this.cbPassportType.DataSource = passPorts;
            this.cbPassportType.DisplayMember = "PassportName";
            this.cbPassportType.ValueMember = "PassportId";
            this.cbPassportType.SelectedIndex = 0;
            #endregion

            #region 加载性别信息
<<<<<<< HEAD:SYS.FormUI/FrmInputs.cs
<<<<<<< HEAD:SYS.FormUI/FrmInputs.cs
            List<SexType> listSexType = CustoTypeManager.SelectSexTypeAll();
=======
            List<SexType> listSexType = new BaseService().SelectSexTypeAll();
>>>>>>> InitProject_v1.4.8_happy_new_year:SYS.FormUI/AppFunction/FrmInputs.cs
=======
            List<SexType> listSexType = new BaseService().SelectSexTypeAll();
>>>>>>> master:SYS.FormUI/AppFunction/FrmInputs.cs
            this.cbSex.DataSource = listSexType;
            this.cbSex.DisplayMember = "sexName";
            this.cbSex.ValueMember = "sexId";
            this.cbSex.SelectedIndex = 0;
            #endregion
        }


        private void btnClose_BtnClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_BtnClick(object sender, EventArgs e)
        {
            try
            {
                if (txtCustoName.Text == "")
                {
                    MessageBox.Show("添加失败，必填信息不可为空");
                }
                else
                {
                    Custo custo = new Custo() 
                    {
                        CustoNo = txtCustoNo.Text,
                        CustoName  = txtCustoName.Text,
                        CustoSex = cbSex.SelectedIndex,
                        CustoBirth = dtpBirthday.Value,
                        CustoType = cbCustoType.SelectedIndex,
                        PassportType = cbPassportType.SelectedIndex,
                        CustoID = txtCardID.Text,
                        CustoTel = txtTel.Text,
                        CustoAdress = txtCustoAdress.Text

                    };
                    int count = CustoManager.InsertCustomerInfo(custo);
                    if (count > 0)
                    {
                        MessageBox.Show("添加成功");

                        #region 获取添加操作日志所需的信息
                        OperationLog o = new OperationLog();
                        o.OperationTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd,HH:mm:ss"));
                        o.Operationlog = "编号："+ LoginInfo.WorkerNo + "【"+FrmMain.wk_WorkerName + "】" + "于" + DateTime.Now + "插入了一条数据！";
                        o.OperationAccount = LoginInfo.WorkerNo;
                        OperationManager.InsertOperationLog(o);
                        #endregion
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

        private void picGetCustoNo_Click(object sender, EventArgs e)
        {
            string cardId = CustoManager.GetRandomCustoNo();
            txtCustoNo.Text = cardId;
        }

        private void txtCardID_Validated(object sender, EventArgs e)
        {
            //获取得到输入的身份证号码
            string identityCard = txtCardID.Text.Trim();
            if (string.IsNullOrEmpty(identityCard))
            {
                //身份证号码不能为空，如果为空返回
                MessageBox.Show("身份证号码不能为空！");
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
                    MessageBox.Show("身份证号码为15位或18位，请检查！");
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
                MySqlConnection con = DBHelper.GetConnection();
                con.Open();
                MySqlDataReader dr = DBHelper.ExecuteReader("select Province,City,District from CARDCODES where bm='" + identityCard.Substring(0, 6).ToString() + "'");
                birthday = identityCard.Substring(6, 4) + "-" + identityCard.Substring(10, 2) + "-" + identityCard.Substring(12, 2);
                sex = identityCard.Substring(14, 3);
                while (dr.Read())
                {
                    txtCustoAdress.Text = dr["Province"].ToString() + dr["City"].ToString() + dr["District"].ToString();
                }
                //性别代码为偶数是女性奇数为男性
                if (int.Parse(sex) % 2 == 0)
                {
                    cbSex.SelectedIndex = 1;
                }
                else
                {
                    cbSex.SelectedIndex = 0;
                }
                dr.Close();
                con.Close();
            }
            try
            {
                dtpBirthday.Value = Convert.ToDateTime(birthday);
            }
            catch
            {
                MessageBox.Show("请正确输入证件号码！");
            }

            cbPassportType.SelectedIndex = 0;

            return;
        }

        private void uiSwitch1_ValueChanged(object sender, bool value)
        {

        }
    }
}
