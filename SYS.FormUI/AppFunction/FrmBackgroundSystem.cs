using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYS.FormUI
{
    public partial class FrmBackgroundSystem : UIForm
    {
        public FrmBackgroundSystem()
        {
            InitializeComponent();
            
        }

        private void FrmBackgroundSystem_Load(object sender, EventArgs e)
        {

        }

        private void uiNavMenu1_MenuItemClick(TreeNode node, NavMenuItem item, int pageIndex)
        {

        }

        private void Aside_MenuItemClick(TreeNode node, NavMenuItem item, int pageIndex)
        {
            if (!node.Text.IsNullOrEmpty())
            {
                switch (node.Text)
                {
                    case "基础信息":
                        break;
                    case "职位类型维护":
                        pnlForm.Controls.Clear();
                        FrmPosition frmPosition = new FrmPosition();
                        frmPosition.TopLevel = false;
                        pnlForm.Controls.Add(frmPosition);
                        frmPosition.Show();
                        break;
                    case "民族类型维护":
                        pnlForm.Controls.Clear();
                        FrmNation frmNation = new FrmNation();
                        frmNation.TopLevel = false;
                        pnlForm.Controls.Add(frmNation);
                        frmNation.Show();
                        break;
                    case "性别类型维护":
                        pnlForm.Controls.Clear();
                        FrmSexType frmSexType = new FrmSexType();
                        frmSexType.TopLevel = false;
                        pnlForm.Controls.Add(frmSexType);
                        frmSexType.Show();
                        break;
                    case "学历类型维护":
                        pnlForm.Controls.Clear();
                        FrmEducation frmEducation = new FrmEducation();
                        frmEducation.TopLevel = false;
                        pnlForm.Controls.Add(frmEducation);
                        frmEducation.Show();
                        break;
                    case "部门信息维护":
                        pnlForm.Controls.Clear();
                        FrmDepartment frmDepartment = new FrmDepartment();
                        frmDepartment.TopLevel = false;
                        pnlForm.Controls.Add(frmDepartment);
                        frmDepartment.Show();
                        break;
                    case "员工工资账单":
                        //MessageBox.Show("1");
                        //pnlForm.Controls.Clear();
                        //FrmRoomManager frm1 = new FrmRoomManager();
                        //frm1.TopLevel = false;
                        //pnlForm.Controls.Add(frm1);
                        //frm1.Show();
                        break;
                    case "内部财务账单":
                        pnlForm.Controls.Clear();
                        FrmCash frmCash = new FrmCash();
                        frmCash.TopLevel = false;
                        pnlForm.Controls.Add(frmCash);
                        frmCash.Show();
                        break;
                    case "酒店盈利情况":
                        pnlForm.Controls.Clear();
                        FrmChart frmChart = new FrmChart();
                        frmChart.TopLevel = false;
                        pnlForm.Controls.Add(frmChart);
                        frmChart.Show();
                        break;
                    case "水电管理":
                        
                        break;
                    case "水电信息":
                        pnlForm.Controls.Clear();
                        WtiInfo wtiInfo = new WtiInfo();
                        wtiInfo.TopLevel = false;
                        pnlForm.Controls.Add(wtiInfo);
                        wtiInfo.Show();
                        break;
                    case "监管统计":
                        break;
                    case "监管部门情况":
                        pnlForm.Controls.Clear();
                        FrmCheckList frmCheckList = new FrmCheckList();
                        frmCheckList.TopLevel = false;
                        pnlForm.Controls.Add(frmCheckList);
                        frmCheckList.Show();
                        break;
                    case "客房管理":
                        break;
                    case "房态图一览":
                        MessageBox.Show("6");
                        break;
                    case "新增客房":
                        pnlForm.Controls.Clear();
                        FrmAddRoom frmAddRoom = new FrmAddRoom();
                        frmAddRoom.TopLevel = false;
                        pnlForm.Controls.Add(frmAddRoom);
                        frmAddRoom.Show();
                        break;
                    case "客户管理":
                        break;
                    case "客户信息管理":
                        pnlForm.Controls.Clear();
                        FrmCustoManager frmCustoManager = new FrmCustoManager();
                        frmCustoManager.TopLevel = false;
                        pnlForm.Controls.Add(frmCustoManager);
                        frmCustoManager.Show();
                        break;
                    case "顾客消费账单":
                        pnlForm.Controls.Clear();
                        FrmCustoSpend frmCustoSpend = new FrmCustoSpend();
                        frmCustoSpend.TopLevel = false;
                        pnlForm.Controls.Add(frmCustoSpend);
                        frmCustoSpend.Show();
                        break;
                    case "人事管理":
                        break;
                    case "员工管理":
                        pnlForm.Controls.Clear();
                        FrmWorkerManager frmWorkerManager = new FrmWorkerManager();
                        frmWorkerManager.TopLevel = false;
                        pnlForm.Controls.Add(frmWorkerManager);
                        frmWorkerManager.Show();
                        break;
                    case "任命日志":
                        pnlForm.Controls.Clear();
                        FrmNotice frmNotice = new FrmNotice();
                        frmNotice.TopLevel = false;
                        pnlForm.Controls.Add(frmNotice);
                        frmNotice.Show();
                        break;
                    case "上传任命日志":
                        pnlForm.Controls.Clear();
                        FrmUpLoadNotice frmUpLoadNotice = new FrmUpLoadNotice();
                        frmUpLoadNotice.TopLevel = false;
                        pnlForm.Controls.Add(frmUpLoadNotice);
                        frmUpLoadNotice.Show();
                        break;
                    case "物资管理":
                        break;
                    case "商品管理":
                        pnlForm.Controls.Clear();
                        FrmSellThingManager frmSellThingManager = new FrmSellThingManager();
                        frmSellThingManager.TopLevel = false;
                        pnlForm.Controls.Add(frmSellThingManager);
                        frmSellThingManager.Show();
                        break;
                    case "仓库物资":
                        break;
                    case "员工操作日志":
                        pnlForm.Controls.Clear();
                        FrmOperation frmOperation = new FrmOperation();
                        frmOperation.TopLevel = false;
                        pnlForm.Controls.Add(frmOperation);
                        frmOperation.Show();
                        break;
                }
            }
        }

        private void btnSetting_MouseHover(object sender, EventArgs e)
        {
            this.btnSetting.RectHoverColor = Color.Black;
            this.btnSetting.Radius = 20;
            this.btnSetting.RadiusSides = UICornerRadiusSides.All;
            
        }

        private void btnLocked_MouseHover(object sender, EventArgs e)
        {
            this.btnLocked.RectHoverColor = Color.Black;
            this.btnLocked.Radius = 20;
            this.btnLocked.RadiusSides = UICornerRadiusSides.All;
        }

        private void btnSetting_MouseLeave(object sender, EventArgs e)
        {
            this.btnSetting.RectColor = System.Drawing.Color.FromArgb(111, 168, 255);
            this.btnLocked.Radius = 20;
        }

        private void btnLocked_MouseLeave(object sender, EventArgs e)
        {
            this.btnLocked.RectColor = System.Drawing.Color.FromArgb(111, 168, 255);
            this.btnLocked.Radius = 20;
        }

        private void btnLocked_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要锁定屏幕吗？锁定后不能做任何操作!", "锁屏", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                new FrmUnLockSystem().ShowDialog();
            }
        }
    }
}
