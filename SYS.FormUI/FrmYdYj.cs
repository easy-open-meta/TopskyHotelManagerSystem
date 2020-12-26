using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace TSHotelManagerSystem
{
    public partial class FrmYdYj : Form
    {
        public FrmYdYj()
        {
            InitializeComponent();
            this.ShowYd("");
        }
        private void ShowYd(string sql)
        {
            string sql = "select *,ReserEndDay=convert(varchar(20),DATEDIFF(MINUTE,GETDATE(),e.Reserdate))+'分钟' from Reser e,Room r,UserInfo u where  e.ReserRoomNo=r.RoomNo and e.CustoName=u.CustoName and DATEDIFF(HH,GETDATE(),e.ReserDate)<=3";
        }
        private void txtGl_TextChanged(object sender, EventArgs e)
        {
            this.ShowYd(String.Format(" and (e.yname like '%{0}%' or r.fno like '%{0}%')", txtGl.Text));
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            this.ShowYd("");
        }
        private void btnXD_Click(object sender, EventArgs e)
        {
            if (dgvYj.SelectedRows.Count <= 0)
            {
                MessageBoxEx.Show("请选择要续订的客户!", "续订", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            uint hh = 0;
            try
            {
                hh = uint.Parse(Microsoft.VisualBasic.Interaction.InputBox("请输入要续订多少小时", "预订续期", "1"));
                if (MessageBoxEx.Show("请确定为【" + dgvYj.CurrentRow.Cells["yname"].Value + "】续订【" + hh + "】小时吗？", "预订续期", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                    return;
                if (DBhelper.update(String.Format("update engage set ydtime=DATEADD(hh,{0},ydtime) where yid={1}", hh, dgvYj.CurrentRow.Cells["yid"].Value)))
                {
                    MessageBoxEx.Show("为【" + dgvYj.CurrentRow.Cells["yname"].Value + "】续订【" + hh + "】小时成功", "预订续期", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ShowYd("");
                }
            }
            catch (System.Exception)
            {
                MessageBoxEx.Show("你输入的格式不正确，请输入一个整数", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void FrmYdYj_Load(object sender, EventArgs e)
        {

        }
        //删除预订信息
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvYj.SelectedRows.Count <= 0)
            {
                MessageBoxEx.Show("请选择要删除预订信息的客户!", "续订", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBoxEx.Show(this, "确定要删除【" + dgvYj.CurrentRow.Cells["yname"].Value + "】的预订信息吗？", "删除", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                return;
            if (DBhelper.update("delete engage where yid=" + dgvYj.SelectedRows[0].Cells["yid"].Value.ToString()))
            {
                MessageBoxEx.Show(this, "删除【" + dgvYj.CurrentRow.Cells["yname"].Value + "】预订成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DBhelper.update("update roominfo set fstate='空房' where fno=" + dgvYj.SelectedRows[0].Cells["fno"].Value.ToString());//修改房间状态
                DBhelper.AddRiZhi("客房", "删除客户【" + dgvYj.CurrentRow.Cells["yname"].Value + "】预订信息");
                this.ShowYd("");//刷新
            }
            else
            {
                MessageBoxEx.Show("删除预定失败", "续订", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmYdYj_Shown(object sender, EventArgs e)
        {
            dgvYj.BackgroundColor = this.BackColor;
        }
    }
}
