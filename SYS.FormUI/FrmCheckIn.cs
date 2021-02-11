using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SYS.Manager;
using SYS.Core;
<<<<<<< HEAD:SYS.FormUI/FrmCheckIn.cs
using SYS.Application;
=======
using Sunny.UI;
using SYS.Application;
using System.Transactions;
>>>>>>> InitProject_v1.4.8_happy_new_year:SYS.FormUI/AppFunction/FrmCheckIn.cs

namespace SYS.FormUI
{
    public partial class FrmCheckIn : Form
    {
        public FrmCheckIn()
        {
            InitializeComponent();
        }

        #region 窗体加载事件方法
        private void FrmCheckIn_Load(object sender, EventArgs e)
        {

            txtRoomNo.Text = ucRoomList.rm_RoomNo;
            Room r = new RoomService().SelectRoomByRoomNo(txtRoomNo.Text);
            RoomType t = new RoomTypeService().SelectRoomTypeByRoomNo(txtRoomNo.Text);
            txtType.Text = t.RoomName;
            txtMoney.Text = r.RoomMoney.ToString();
            txtRoomPosition.Text = r.RoomPosition;
            txtState.Text = r.RoomState;
<<<<<<< HEAD:SYS.FormUI/FrmCheckIn.cs
            txtState.Text = RoomManager.SelectRoomStateNameByRoomNo(txtRoomNo.Text).ToString();
            List<Custo> ctos = CustoService.SelectCanUseCustoAll();
            List<Room> roms = RoomManager.SelectCanUseRoomAll();
=======
            List<Custo> ctos = new CustoService().SelectCustoAll();
            List<Room> roms = new RoomService().SelectCanUseRoomAll();
>>>>>>> InitProject_v1.4.8_happy_new_year:SYS.FormUI/AppFunction/FrmCheckIn.cs
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
        #endregion

        

        #region 关闭窗口
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 验证输入完整性
        /// <summary>
        /// 验证输入完整性
        /// </summary>
        private bool CheckInupt()
        {
            if (txtCustoNo.Text == "")
            {
                MessageBox.Show("请输入客户编号！", "来自小T的提示");
                txtCustoNo.Focus();
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

        #region 入住按钮点击事件方法
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (CheckInupt())
            {
<<<<<<< HEAD:SYS.FormUI/FrmCheckIn.cs

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
                        //SpendManager.InsertSpendInfo(s);
                        txtCustoNo.Text = "";
                        FrmRoomManager.Reload();
                        this.Close();
                        #region 获取添加操作日志所需的信息
                        Operation o = new Operation();
                        o.OperationTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd,HH:mm:ss"));
                        o.Operationlog = LoginInfo.WorkerClub + LoginInfo.WorkerPosition + LoginInfo.WorkerName + "于" + DateTime.Now + "帮助" + r.CustoNo + "进行了入住操作！";
                        o.OperationAccount = LoginInfo.WorkerClub + LoginInfo.WorkerPosition + LoginInfo.WorkerName;
                        #endregion
                        OperationManager.InsertOperationLog(o);
                    }
                    else
=======
                if (new CustoService().SelectCardInfoByCustoNo(txtCustoNo.Text) != null)
                {
                    using (TransactionScope scope = new TransactionScope())
>>>>>>> InitProject_v1.4.8_happy_new_year:SYS.FormUI/AppFunction/FrmCheckIn.cs
                    {
                        Room r = new Room() 
                        {
                            CheckTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                            CustoNo = txtCustoNo.Text,
                            RoomStateId = 1,
                            RoomNo = txtRoomNo.Text,
                            datachg_usr = LoginInfo.WorkerNo,
                            datachg_date = DateTime.Now,
                        };
                        
                        bool n = new RoomService().UpdateRoomInfo(r);
                        if (n == true)
                        {
                            MessageBox.Show("登记入住成功！", "登记提示");
                            txtCustoNo.Text = "";
                            FrmRoomManager.Reload();
                            #region 获取添加操作日志所需的信息
                            OperationLog o = new OperationLog();
                            o.OperationTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd,HH:mm:ss"));
                            o.Operationlog = LoginInfo.WorkerClub + LoginInfo.WorkerPosition + LoginInfo.WorkerName + "于" + DateTime.Now + "帮助" + r.CustoNo + "进行了入住操作！";
                            o.OperationAccount = LoginInfo.WorkerClub + LoginInfo.WorkerPosition + LoginInfo.WorkerName;
                            o.datains_usr = LoginInfo.WorkerNo;
                            o.datains_date = DateTime.Now;
                            #endregion
                            new OperationlogService().InsertOperationLog(o);
                            scope.Complete();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("登记入住失败！", "登记提示");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("客户编号不存在！", "来自小T的提示");
                }
            }
        }
        #endregion

        #region 客户编号输入框的值发生改变时候的事件方法
        private void txtCustoNo_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void txtCustoNo_Validated(object sender, EventArgs e)
        {
            try
            {
                Custo c = new CustoService().SelectCardInfoByCustoNo(txtCustoNo.Text);
                txtCustoName.Text = c.CustoName;
                txtCustoTel.Text = c.CustoTel;
                txtCustoType.Text = c.typeName;
            }
            catch
            {
                txtCustoName.Text = "";
                txtCustoTel.Text = "";
                txtCustoType.Text = "";
            }
        }
    }
}
