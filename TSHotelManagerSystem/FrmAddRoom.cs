using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSHotelManagerSystem.BLL;
using TSHotelManagerSystem.DAL;
using TSHotelManagerSystem.Models;

namespace TSHotelManagerSystem
{
    public partial class FrmAddRoom : Form
    {
        public FrmAddRoom()
        {
            InitializeComponent();
        }

        public static Room rn;

        public void CmpSetDgv()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvRoomList.AllowUserToAddRows = false;
            this.dgvRoomList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            this.dgvRoomList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRoomList.BackgroundColor = System.Drawing.Color.White;
            this.dgvRoomList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRoomList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;//211, 223, 240
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("苹方-简", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvRoomList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRoomList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomList.EnableHeadersVisualStyles = false;
            this.dgvRoomList.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvRoomList.ReadOnly = true;
            this.dgvRoomList.RowHeadersVisible = false;
            this.dgvRoomList.RowTemplate.Height = 23;
            this.dgvRoomList.RowTemplate.ReadOnly = true;
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (txtRoomNo.TextLength > 6)
            {
                rn = new Room()
                {
                    RoomNo = txtRoomNo.Text,
                    RoomType = cboRoomType.SelectedIndex,
                    RoomMoney = Convert.ToDecimal(txtMoney.Text),
                    RoomPosition = txtRoomPosition.Text,
                };
                RoomManager.InsertRoom(rn);
                MessageBox.Show("添加房间成功！");
                dgvRoomList.DataSource = RoomService.SelectCanUseRoomAll();
                #region 获取添加操作日志所需的信息
                Operation o = new Operation();
                o.OperationTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd,HH:mm:ss"));
                o.Operationlog = AdminInfo.adminType + AdminInfo.admingroup + "于" + DateTime.Now + "新增了房间，房间号为：" + txtRoomNo.Text + "，房间类型为："+cboRoomType.Text;
                o.OperationAccount = AdminInfo.adminType + AdminInfo.admingroup;
                #endregion
                OperationManager.InsertOperationLog(o);
            }
            else
            {
                MessageBox.Show("房间信息不完整，请重试！");
            }
            
        }



        private void FrmAddRoom_Load(object sender, EventArgs e)
        {
            CmpSetDgv();
            dgvRoomList.AutoGenerateColumns = false;
            dgvRoomList.DataSource = RoomService.SelectCanUseRoomAll();
            cboRoomType.DataSource = RoomTypeManager.SelectRoomTypesAll();
            cboRoomType.DisplayMember = "RoomName";
            cboRoomType.ValueMember = "RoomType";
            cboRoomType.SelectedIndex = 0;
            cboState.SelectedIndex = 0;
        }

        private void cboRoomType_TextChanged(object sender, EventArgs e)
        {
            Random random = new Random();
            if (cboRoomType.Text == "标准单人间")
            {
                txtRoomNo.Text = "BD" + random.Next(0, 9).ToString() + random.Next(0, 9).ToString() + random.Next(0, 9).ToString() + random.Next(0, 9).ToString();
                txtMoney.Text = "300";
                txtRoomPosition.Text = "A层";
                txtPersonNum.Text = "1";
            }
            else if (cboRoomType.Text == "标准双人间")
            {
                txtRoomNo.Text = "BS" + random.Next(0, 9).ToString() + random.Next(0, 9).ToString() + random.Next(0, 9).ToString() + random.Next(0, 9).ToString();
                txtMoney.Text = "425";
                txtRoomPosition.Text = "A层";
                txtPersonNum.Text = "2";
            }
            else if (cboRoomType.Text == "豪华单人间")
            {
                txtRoomNo.Text = "HD" + random.Next(0, 9).ToString() + random.Next(0, 9).ToString() + random.Next(0, 9).ToString() + random.Next(0, 9).ToString();
                txtMoney.Text = "625";
                txtRoomPosition.Text = "B层";
                txtPersonNum.Text = "1";
            }
            else if (cboRoomType.Text == "豪华双人间")
            {
                txtRoomNo.Text = "HS" + random.Next(0, 9).ToString() + random.Next(0, 9).ToString() + random.Next(0, 9).ToString() + random.Next(0, 9).ToString();
                txtMoney.Text = "660";
                txtRoomPosition.Text = "B层";
                txtPersonNum.Text = "2";
            }
            else if (cboRoomType.Text == "情侣套房")
            {
                txtRoomNo.Text = "QL" + random.Next(0, 9).ToString() + random.Next(0, 9).ToString() + random.Next(0, 9).ToString() + random.Next(0, 9).ToString();
                txtMoney.Text = "845";
                txtRoomPosition.Text = "C层";
                txtPersonNum.Text = "2";
            }
            else if (cboRoomType.Text == "总统套房")
            {
                txtRoomNo.Text = "ZT" + random.Next(0, 9).ToString() + random.Next(0, 9).ToString() + random.Next(0, 9).ToString() + random.Next(0, 9).ToString();
                txtMoney.Text = "2080";
                txtRoomPosition.Text = "D层";
                txtPersonNum.Text = "4";
            }
        }

        private void txtRoomNo_TextChanged(object sender, EventArgs e)
        {
            if (CheckRoomExists(txtRoomNo.Text))
            {
                MessageBox.Show("该房间已存在，无法进行添加操作");
                return;
            }
        }

        private bool CheckRoomExists(string RoomNo)
        {
            bool ret = false;
            string sql = "select count(*) from ROOM where RoomNo=@RoomNo";
            int n = (int)DBHelper.ExecuteScalar(sql,
                    CommandType.Text,
                    new SqlParameter[]
                    {
                        new SqlParameter("@RoomNo",txtRoomNo.Text)
                    }
                    );
            if (n > 0)
            {
                ret = true;
            }
            return ret;
        }
    }
}
