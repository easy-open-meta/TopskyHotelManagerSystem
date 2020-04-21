using System;
using System.Windows.Forms;
using TSHotelManagerSystem.DAL;
using TSHotelManagerSystem.Models;

namespace TSHotelManagerSystem
{
    public partial class WtiInfo : Form
    {
        public WtiInfo()
        {
            InitializeComponent();
        }

        public void CmpSetDgv()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvWti.AllowUserToAddRows = false;
            this.dgvWti.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            this.dgvWti.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWti.BackgroundColor = System.Drawing.Color.White;
            this.dgvWti.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvWti.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;//211, 223, 240
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("苹方-简", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvWti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvWti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWti.EnableHeadersVisualStyles = false;
            this.dgvWti.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvWti.ReadOnly = true;
            this.dgvWti.RowHeadersVisible = false;
            this.dgvWti.RowTemplate.Height = 23;
            this.dgvWti.RowTemplate.ReadOnly = true;
        }

        #region 窗体加载事件
        private void WtiInfo_Load(object sender, EventArgs e)
        {
            CmpSetDgv();
            FirstTime();//初始化使用时间
            LoadWtiInfo();//加载水电费信息
            LoadToolTip();//加载鼠标到关联控件显示信息
        }
        #endregion

        #region 初始化使用时间
        /// <summary>
        /// 初始化使用时间
        /// </summary>
        public void FirstTime()
        {
            dtpUseDate.Value = DateTime.Now;//开始使用时间改为当前时间
            dtpEndDate.Value = DateTime.Now;//结束使用时间改为当前时间
        }
        #endregion

        #region 加载水电费信息到Dgv
        /// <summary>
        /// 加载水电费信息到Dgv
        /// </summary>
        private void LoadWtiInfo()
        {
            //将水电费信息加载到Dgv
            dgvWti.DataSource = WtiService.SelectWtiInfoAll();
        }
        #endregion

        #region 加载鼠标到关联控件显示信息
        /// <summary>
        /// 加载鼠标到关联控件显示信息
        /// </summary>
        private void LoadToolTip()
        {
            //绑定控件和显示显示信息
            ToolTip1.SetToolTip(picDelete, "删除");
            ToolTip1.SetToolTip(picFend, "查询");
            ToolTip1.SetToolTip(picUpdate, "修改");
        }
        #endregion

        #region 鼠标点击DGV事件
        private void dgvWti_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //将鼠标选中的行的信息加载到对应的控件里
            txtCustoNo.Text = dgvWti.SelectedRows[0].Cells["clCustoNo"].Value.ToString();
            txtPowerUse.Text = dgvWti.SelectedRows[0].Cells["clPowerUse"].Value.ToString();
            txtRecord.Text = dgvWti.SelectedRows[0].Cells["clRecord"].Value.ToString();
            txtRoomNo.Text = dgvWti.SelectedRows[0].Cells["clRoomNo"].Value.ToString();
            txtWaterUse.Text = dgvWti.SelectedRows[0].Cells["clWaterUse"].Value.ToString();
            dtpUseDate.Value = (DateTime)dgvWti.SelectedRows[0].Cells["clUseDate"].Value;
            dtpEndDate.Value = (DateTime)dgvWti.SelectedRows[0].Cells["clEndDate"].Value;
        }
        #endregion

        #region 检查输入完整性
        /// <summary>
        /// 检查输入完整性
        /// </summary>
        /// <returns></returns>
        private bool CheckInput()
        {
            if (txtRoomNo.Text == "")//判断房间编号是否为空
            {
                MessageBox.Show("请输入房间编号！", "输入提示");
                txtRoomNo.Focus();//聚焦
                return false;
            }
            return true;
        }
        #endregion

        #region 删除图片点击事件
        private void picDelete_Click(object sender, EventArgs e)
        {
            if (CheckInput())//检查输入完整性
            {
                DialogResult dr = MessageBox.Show("你确定删除该水电费信息吗？", "删除提示",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)//判断操作员是否删除水电费信息
                {
                    //获取房间编号、开始使用时间、结束使用时间
                    string no = txtRoomNo.Text;
                    string usedate = dtpUseDate.Value.ToString();
                    string enddate = dtpEndDate.Value.ToString();
                    int n = 0;//用于判断删除语句是否执行成功
                    //执行语句
                    n = WtiService.DeleteWtiInfoByRoomNoAndDateTime(no, usedate, enddate);

                    if (n > 0)//判断删除语句是否执行成功
                    {
                        MessageBox.Show("删除成功！", "删除提示");
                        LoadWtiInfo();//加载信息
                    }
                    else
                    {
                        MessageBox.Show("删除失败，请重新核对房间编号和使用时间！", "删除提示");
                        txtRoomNo.Focus();//聚焦
                    }
                }
                return;
            }
        }
        #endregion

        #region 遍历文本框(禁用)
        /// <summary>
        /// 遍历文本框(禁用)
        /// </summary>
        private void FendTextBox()
        {
            foreach (Control t in gbInfo.Controls)//遍历gbInfo里的文本框
            {
                //禁用文本框
                t.Enabled = false;
            }
        }
        #endregion

        #region 修改图片点击事件
        private void picUpdate_Click(object sender, EventArgs e)
        {

            //判断房间编号、开始使用时间和结束使用时间是否为空
            if (txtRoomNo.Text != "" && dtpUseDate.Text != "" && dtpEndDate.Text != "")
            {
                //获取房间编号和使用时间
                string no = txtRoomNo.Text;
                string usedate = dtpUseDate.Value.ToString();
                string enddate = dtpEndDate.Value.ToString();
                //根据用户输入的房间编号、开始使用时间和结束使用时间获取水电费信息
                Wti w = WtiService.SelectWtiInfoByRoomNoAndTime(no, usedate, enddate);

                //判断用户输入的房间编号、开始使用时间和结束使用时间是否能找到对应数据
                if (w != null)
                {
                    txtPowerUse.Text = w.PowerUse.ToString();
                    txtWaterUse.Text = w.WaterUse.ToString();
                    FendTextBox();//遍历文本框(禁用)

                    //启用部分文本框
                    txtPowerUse.Enabled = true;
                    txtWaterUse.Enabled = true;
                    btnOk.Enabled = true;
                    txtWaterUse.Focus();//水费文本框聚焦
                    btnOk.Text = "修改";
                }
                else
                {
                    MessageBox.Show("请核对水电费信息", "输入提示");
                }
            }
            else
            {
                MessageBox.Show("房间编号、开始使用时间和结束使用时间不能为空！", "输入提示");
                txtRoomNo.Focus();//房间编号文本框聚焦
            }
        }
        #endregion

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (btnOk.Text == "修改")
            {
                //获取房间编号和使用时间
                string no = txtRoomNo.Text;
                string usedate = dtpUseDate.Value.ToString();
                string enddate = dtpEndDate.Value.ToString();
                //根据用户输入的房间编号、开始使用时间和结束使用时间获取水电费信息
                Wti w = WtiService.SelectWtiInfoByRoomNoAndTime(no, usedate, enddate);
                string water = txtWaterUse.Text;
                string power = txtPowerUse.Text;
                if (water != w.WaterUse.ToString() || power != w.PowerUse.ToString())
                {
                    Wti w2 = new Wti()
                    {
                        RoomNo = txtRoomNo.Text,
                        EndDate = dtpEndDate.Value,
                        UseDate = dtpUseDate.Value,
                        PowerUse = Convert.ToDecimal(txtPowerUse.Text),
                        WaterUse = Convert.ToDecimal(txtWaterUse.Text),
                    };
                    int n = WtiService.UpdateWtiInfoByRoomNoAndDateTime(w2);
                    if (n > 0)
                    {
                        MessageBox.Show("修改成功！", "修改提示");
                        LoadWtiInfo();
                    }
                    else
                    {
                        MessageBox.Show("修改失败！", "修改提示");
                    }
                }
                return;
            }
        }

        private void picAdd_Click(object sender, EventArgs e)
        {

        }

        private void picFend_Click(object sender, EventArgs e)
        {

        }
    }
}
