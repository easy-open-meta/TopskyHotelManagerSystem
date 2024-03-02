using System;

using System.Windows.Forms;
using EOM.TSHotelManager.Common.Core;
using Sunny.UI;
using System.Transactions;
using System.Collections.Generic;

using System.Web.Script.Services;
using SYS.Common;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Security.Cryptography;

namespace SYS.FormUI
{
    public partial class FrmReserList : UIForm
    {
        public FrmReserList()
        {
            InitializeComponent();
        }

        ResponseMsg result = new ResponseMsg();

        private void FrmReserList_Load(object sender, EventArgs e)
        {
            result = HttpHelper.Request("Reser/SelectReserAll", null, null);
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectReserAll+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            dgvReserList.AutoGenerateColumns = false;
            dgvReserList.DataSource = HttpHelper.JsonToList<Reser>(result.message);

            #region 加载客户类型信息
            result = HttpHelper.Request("Base/SelectCustoTypeAllCanUse", null, null);
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
            result = HttpHelper.Request("Base/SelectPassPortTypeAllCanUse", null, null);
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
            result = HttpHelper.Request("Base/SelectSexTypeAll", null, null);
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectSexTypeAll+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            List<SexType> listSexType = HttpHelper.JsonToList<SexType>(result.message);
            this.cbSex.DataSource = listSexType;
            this.cbSex.DisplayMember = "sexName";
            this.cbSex.ValueMember = "sexId";
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
                    CustoSex = Convert.ToInt32(cbSex.SelectedValue.ToString()),
                    CustoTel = txtTel.Text.Trim(),
                    PassportType = cbPassportType.SelectedIndex,
                    CustoID = txtCardID.Text.Trim(),
                    CustoAdress = txtCustoAdress.Text.Trim(),
                    CustoBirth = dtpBirthday.Value,
                    CustoType = cbCustoType.SelectedIndex,
                    delete_mk = 0,
                    datains_usr = LoginInfo.WorkerNo
                };
                result = HttpHelper.Request("Custo​/InsertCustomerInfo", HttpHelper.ModelToJson(custo));
                if (result.statusCode != 200)
                {
                    UIMessageBox.ShowError("InsertCustomerInfo+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }

                Room r = new Room() 
                {
                    CheckTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                    CustoNo = custo.CustoNo,
                    RoomStateId = 1,
                    RoomNo = dgvReserList.SelectedRows[0].Cells["clRoomNo"].Value.ToString()
                };
                result = HttpHelper.Request("Room​/UpdateRoomInfo", HttpHelper.ModelToJson(r), null);
                if (result.statusCode != 200)
                {
                    UIMessageBox.ShowError("InsertCustomerInfo+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                var reser = new Reser
                {
                    ReserId = dgvReserList.SelectedRows[0].Cells["clReserNo"].Value.ToString()
                };
                result = HttpHelper.Request("Reser/DeleteReserInfo", HttpHelper.ModelToJson(reser));
                if (result.statusCode != 200)
                {
                    UIMessageBox.ShowError("DeleteReserInfo+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }

                UIMessageBox.ShowSuccess("操作成功");
                dgvReserList.AutoGenerateColumns = false;
                result = HttpHelper.Request("Reser/SelectReserAll", null, null);
                if (result.statusCode != 200)
                {
                    UIMessageBox.ShowError("SelectReserAll+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                dgvReserList.DataSource = HttpHelper.JsonToList<Reser>(result.message);
                FrmRoomManager.Reload("");
                scope.Complete();
                this.Close();
            }
        }

        private void dgvReserList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string custoNo = Util.GetListNewId("TS", 2, 1, "-").FirstOrDefault();
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
