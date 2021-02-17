using Sunny.UI;
using SYS.Core;
using SYS.FormUI.AppFunction;
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
        public delegate void UpdPwd();

        public static UpdPwd closeform;

        public FrmBackgroundSystem()
        {
            InitializeComponent();
            closeform = Closeform;
        }



        private void FrmBackgroundSystem_Load(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                switch (item.GetType().ToString())
                {
                    case "Sunny.UI.UILabel":
                        item.Font = UI_FontUtil.mainFont;
                        break;
                    case "Sunny.UI.UIScrollingText":
                        item.Font = UI_FontUtil.scorllingFont;
                        break;
                    case "Sunny.UI.UINavMenu":
                        item.Font = UI_FontUtil.scorllingFont;
                        break;
                }
            }
            DateTime tmCur = DateTime.Now;

            if (tmCur.Hour < 8 || tmCur.Hour > 18)
            {//晚上
                uiLabel1.Text = "(*´▽｀)ノノ晚上好," + AdminInfo.Name;
            }
            else if (tmCur.Hour > 8 && tmCur.Hour < 12)
            {//上午
                uiLabel1.Text = "上午好," + AdminInfo.Name;
            }
            else
            {//下午
                uiLabel1.Text = "下午好," + AdminInfo.Name;
            }
        }

        /// <summary>
        /// 关闭当前窗体
        /// </summary>
        public void Closeform() 
        {
            this.Close();
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
                        FrmWtiInfo frmWtiInfo = new FrmWtiInfo();
                        frmWtiInfo.TopLevel = false;
                        pnlForm.Controls.Add(frmWtiInfo);
                        frmWtiInfo.Show();
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
                        pnlForm.Controls.Clear();
                        FrmRoomMap frmRoomMap = new FrmRoomMap();
                        frmRoomMap.TopLevel = false;
                        pnlForm.Controls.Add(frmRoomMap);
                        frmRoomMap.Show();
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
                    case "公告日志":
                        pnlForm.Controls.Clear();
                        FrmNotice frmNotice = new FrmNotice();
                        frmNotice.TopLevel = false;
                        pnlForm.Controls.Add(frmNotice);
                        frmNotice.Show();
                        break;
                    case "上传公告日志":
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss");
        }

        private void FrmBackgroundSystem_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            this.btnSetting.ContextMenuStrip = cmsMenu;
        }

        private void cmsMenu_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void btnSetting_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                cmsMenu.Show(MousePosition);
            }

        }

        private void tsmiUpdatePwd_Click(object sender, EventArgs e)
        {
            FrmChangeAdminPwd frmChangeAdminPwd = new FrmChangeAdminPwd();
            frmChangeAdminPwd.ShowDialog();
        }
    }
}
