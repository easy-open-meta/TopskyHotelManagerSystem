using Sunny.UI;
using SYS.Core;
using SYS.Manager;
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
    public partial class FrmNation : UIForm
    {

        public delegate void OperationInfo();


        //定义委托类型的变量
        public static OperationInfo operation;

        public static OperationInfo reload;

        public FrmNation()
        {
            InitializeComponent();
            operation = Visited;
            reload = ReloadNationList;
        }

        ucBaseInformation baseInfo = null;
        List<Nation> nations = null;
        public static string info = null;
        private void FrmNation_Load(object sender, EventArgs e)
        {
            ReloadNationList();
            
        }

        public void ReloadNationList() 
        {
            flpInformation.Controls.Clear();
            nations = new BaseManager().SelectNationAll();
            for (int i = 0; i < nations.Count; i++)
            {
                baseInfo = new ucBaseInformation();
                baseInfo.lbName.Text = "名称:" + nations[i].nation_name;
                flpInformation.Controls.Add(baseInfo);
            }
        }

        private void flpInformation_SizeChanged(object sender, EventArgs e)
        {
            flpInformation.Width = 660;
            flpInformation.Height = 582;
        }

        public void Visited() 
        {
            //筛选出只与当前民族对应的数据
            Nation nation = nations.FirstOrDefault(a => !a.nation_name.Equals(info));
            if (nation.nation_name.Equals(info))
            {
                var _nation = new Nation()
                {
                    nation_no = nation.nation_no,
                    delete_mk = 1,
                    datachg_usr = LoginInfo.WorkerNo,
                    datachg_date = DateTime.Now
                };
                if (_nation != null)
                {
                    int n = new BaseManager().DelNation(_nation);
                    if (n > 0)
                    {
                        UIMessageBox.ShowSuccess("删除成功！");
                        ReloadNationList();
                    }
                }
            }

            

        }

    }
}
