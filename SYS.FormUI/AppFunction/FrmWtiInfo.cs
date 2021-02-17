using System;
using System.Windows.Forms;
using Sunny.UI;
using SYS.Application;
using SYS.Core;

namespace SYS.FormUI
{
    public partial class FrmWtiInfo : UIForm
    {
        public FrmWtiInfo()
        {
            InitializeComponent();
        }

        #region 窗体加载事件
        private void WtiInfo_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
=======
            foreach (Control item in this.Controls)
            {
                item.Font = UI_FontUtil.childControlFont;
            }
>>>>>>> fb009c4fe69c0285ef7856f5960db104eecbccf7
            LoadWtiInfo();//加载水电费信息
        }
        #endregion

        #region 加载水电费信息到Dgv
        /// <summary>
        /// 加载水电费信息到Dgv
        /// </summary>
        private void LoadWtiInfo()
        {
            //将水电费信息加载到Dgv
            dgvWti.DataSource = new WtiService().SelectWtiInfoAll();
        }
        #endregion
       
    }
}
