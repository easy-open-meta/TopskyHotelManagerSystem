using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSHotelManagerSystem.BLL;
using TSHotelManagerSystem.Models;

namespace TSHotelManagerSystem
{
    public partial class FrmRoomStateManager : Form
    {
        public FrmRoomStateManager()
        {
            InitializeComponent();
        }

        #region 窗体加载事件
        private void FrmRoomStateManager_Load(object sender, EventArgs e)
        {
            txtRoomNo.Text = RoomStatic.RoomNo;
            cboState.DataSource = RoomManager.SelectRoomStateAll();
            cboState.DisplayMember = "RoomState";
            cboState.ValueMember = "RoomStateId";
            cboState.SelectedIndex = RoomStatic.RoomStateId;
        }
        #endregion

        #region 确定按钮点击事件
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cboState.SelectedIndex != 1)
            {
                if (RoomManager.UpdateRoomStateByRoomNo(txtRoomNo.Text, cboState.SelectedIndex) > 0)
                {
                    MessageBox.Show("房间" + txtRoomNo.Text + "成功修改为" + cboState.Text, "修改提示");
                    FrmRoomManager.Reload() ;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改失败", "来自小T的提示");
                }
            }
            else
            {
                MessageBox.Show("不能设置已住状态", "来自小T的提示");
            }
        } 
        #endregion
    }
}
