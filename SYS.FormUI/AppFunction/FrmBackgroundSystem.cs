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
                        MessageBox.Show("2");
                        break;
                    case "酒店盈利情况":
                        MessageBox.Show("3");
                        break;
                    case "水电管理":
                        break;
                    case "水电信息":
                        MessageBox.Show("4");
                        break;
                    case "监管统计":
                        break;
                    case "监管部门情况":
                        MessageBox.Show("5");
                        break;
                    case "客房管理":
                        break;
                    case "房态图一览":
                        MessageBox.Show("6");
                        break;
                    case "新增客房":
                        MessageBox.Show("7");
                        break;
                    case "客户管理":
                        break;
                    case "客户信息管理":
                        MessageBox.Show("8");
                        break;
                    case "顾客消费账单":
                        MessageBox.Show("9");
                        break;
                    case "人事管理":
                        break;
                    case "员工管理":
                        MessageBox.Show("10");
                        break;
                    case "任命日志":
                        MessageBox.Show("11");
                        break;
                    case "上传任命日志":
                        MessageBox.Show("12");
                        break;
                    case "物资管理":
                        break;
                    case "商品管理":
                        MessageBox.Show("13");
                        break;
                    case "仓库物资":
                        MessageBox.Show("14");
                        break;
                    case "员工操作日志":
                        MessageBox.Show("15");
                        break;
                }
            }
        }
    }
}
