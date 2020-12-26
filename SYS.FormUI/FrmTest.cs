using Sunny.UI;
using SYS.Application;
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
    public partial class FrmTest : UIForm
    {
        public FrmTest()
        {
            InitializeComponent();
        }

        private void FrmTest_Load(object sender, EventArgs e)
        {
            //List<ListEntity> lst = new List<ListEntity>();
            ////List<Custo> custos = CustoService.SelectCustoAll();
            //for (int i = 0; i < 5; i++)
            //{
            //    lst.Add(new ListEntity()
            //    {
            //        ID = i.ToString(),
            //        Title = "选项" + i,
            //        ShowMoreBtn = true,
            //        Source = i
            //    });
            //}
            ////ucListExt1.SetList(lst);
        }
    }
}
