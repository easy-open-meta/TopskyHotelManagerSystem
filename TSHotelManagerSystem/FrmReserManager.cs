using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using TSHotelManagerSystem.DAL;
using TSHotelManagerSystem.Models;
using TSHotelManagerSystem.BLL;

namespace TSHotelManagerSystem
{
    public partial class FrmReserManager : Form
    {
        public FrmReserManager()
        {
            InitializeComponent();
            #region 防止背景闪屏方法
            this.DoubleBuffered = true;//设置本窗体
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲 
            #endregion
        }

        public void CmpSetDgv()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvBou.AllowUserToAddRows = false;
            this.dgvBou.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            this.dgvBou.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBou.BackgroundColor = System.Drawing.Color.White;
            this.dgvBou.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBou.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;//211, 223, 240
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvBou.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBou.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBou.EnableHeadersVisualStyles = false;
            this.dgvBou.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvBou.ReadOnly = true;
            this.dgvBou.RowHeadersVisible = false;
            this.dgvBou.RowTemplate.Height = 23;
            this.dgvBou.RowTemplate.ReadOnly = true;
        }

        private void FrmRoomManager_Load_1(object sender, EventArgs e)
        {
            CmpSetDgv();
            cboReserWay.SelectedIndex = 0;
            dgvBou.DataSource = ReserService.SelectReserAll();
            Type.DataSource = RoomTypeManager.SelectRoomTypesAll();
            Type.DisplayMember = "RoomName";//显示的列名
            Type.ValueMember = "Roomtype";//绑定的值
        }

        #region DataGridView点击数据加载到控件上
        private void dgvBou_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtReserNo.Text = dgvBou.SelectedRows[0].Cells["clReserId"].Value.ToString();
            txtCustoName.Text = dgvBou.SelectedRows[0].Cells["clCustoName"].Value.ToString();
            txtCustoTel.Text = dgvBou.SelectedRows[0].Cells["clCustoTel"].Value.ToString();
            cboReserWay.Text = dgvBou.SelectedRows[0].Cells["clReserWay"].Value.ToString();
            Type.Text = dgvBou.SelectedRows[0].Cells["clReserRoom"].Value.ToString();
            ReserCash.Text = dgvBou.SelectedRows[0].Cells["clReserCash"].Value.ToString();
            dtpBouDate.Text = dgvBou.SelectedRows[0].Cells["clReserDate"].Value.ToString();
            txtReserNum.Text = dgvBou.SelectedRows[0].Cells["clReserPerson"].Value.ToString();
            try
            {
                txtMessage.Text = dgvBou.SelectedRows[0].Cells["clReserRemark"].Value.ToString();
            }
            catch
            {

                txtMessage.Text = "";
            }
            
        }
        #endregion
        
        private void picUpdate_Click(object sender, EventArgs e)
        {
            if (txtReserNo.Text == "")
            {
                MessageBox.Show("还没选择预约客户信息，无法进行修改！");
            }
            else
            {
                int n = 0;
                string sql = "update RESER set CustoName='" + txtCustoName.Text + "',CustoTel='" + txtCustoTel.Text + "',ReserWay='" + cboReserWay.Text + "',ReserRoom='" + Type.SelectedIndex + "',ReserCash='" + ReserCash.Text + "',ReserDate='" + dtpBouDate.Value.ToShortDateString() + "',ReserPerson='" + txtReserNum.Text + "',ReserRemark='" + txtMessage.Text + "' where ReserId='" + txtReserNo.Text + "'";
                SqlConnection con = DBHelper.GetConnection();
                n = DBHelper.ExecuteNonQuery(sql);
                MessageBox.Show("修改预约信息成功");
                dgvBou.DataSource = ReserService.SelectReserAll();
            }
        }

        private void picAddReserInfo_Click(object sender, EventArgs e)
        {
            if (txtReserNo.Text == "")
            {
                MessageBox.Show("预约编号不能为空！", "TS提醒");
            }
            else
            {
                int n = 0;
                string sql = "insert RESER values('" + txtReserNo.Text + "','" + txtCustoName.Text + "','" + txtCustoTel.Text + "','" + cboReserWay.Text + "','" + Type.SelectedIndex + "','" + ReserCash.Text + "','" + dtpBouDate.Value + "','" + txtReserNum.Text + "','" + txtMessage.Text + "')";
                SqlConnection con = DBHelper.GetConnection();
                n = DBHelper.ExecuteNonQuery(sql);
                MessageBox.Show("添加预约信息成功");
                dgvBou.DataSource = ReserService.SelectReserAll();
                txtCustoName.Text = "";
                txtCustoTel.Text = "";
                cboReserWay.Text = "";
                Type.Text = "";
                ReserCash.Text = "";
                dtpBouDate.Text = "";
                txtReserNum.Text = "";
                txtMessage.Text = "";
            }

        }

        private void picDeleteReser_Click(object sender, EventArgs e)
        {
            string sql = "delete from RESER where ReserId='" + txtReserNo.Text + "'";
            SqlConnection con = DBHelper.GetConnection();
            int n = DBHelper.ExecuteNonQuery(sql);
            MessageBox.Show("删除预约信息成功", "删除提示");
            txtReserNo.Text = "";
            dgvBou.DataSource = ReserService.SelectReserAll();
        }

        private void picSearch_Click(object sender, EventArgs e)
        {
            if(txtCustoTel.Text=="")
            {
                MessageBox.Show("请输入预约电话！", "提示信息");
                txtCustoTel.Focus();
            }
            else
            {
                string tel = txtCustoTel.Text;
                dgvBou.DataSource = ReserService.SelectReserInfoByConn(tel);
            }
        }
    }
}