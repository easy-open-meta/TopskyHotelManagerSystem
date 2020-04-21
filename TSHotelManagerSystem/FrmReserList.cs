using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using TSHotelManagerSystem.BLL;
using TSHotelManagerSystem.DAL;
using TSHotelManagerSystem.Models;

namespace TSHotelManagerSystem
{
    public partial class FrmReserList : Form
    {
        public FrmReserList()
        {
            InitializeComponent();
        }

        public void CmpSetDgv()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;//211, 223, 240
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("苹方-简", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.RowTemplate.ReadOnly = true;
        }

        private void FrmReserList_Load(object sender, EventArgs e)
        {
            CmpSetDgv();
            cboCustoType.SelectedIndex = 0;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ReserManager.SelectReserAll();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string sql = "insert USERINFO(CustoNo,CustoName,CustoSex,CustoTel,PassportType,CustoID,CustoAdress,CustoBirth,CustoType)";
            sql += " values('" + txtCustoNo.Text + "','" + txtCustoName.Text + "','" + cboSex.Text + "','" + txtTel.Text + "','" + cboPassport.SelectedIndex + "','" + txtCardID.Text + "','" + txtCustoAdress.Text + "','" + dtpBirthday.Value + "','" + cboCustoType.SelectedIndex + "') ";
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            int i = DBHelper.ExecuteNonQuery(sql);
            Room r = new Room();
            r.CheckTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            r.CustoNo = txtCustoNo.Text;
            r.PersonNum = "1";
            r.RoomStateId = 1;
            r.RoomNo = dataGridView1.SelectedRows[0].Cells["clReserRoom"].Value.ToString();
            int n = RoomManager.UpdateRoomInfo(r);
            int j = ReserManager.DeleteReserInfo(dataGridView1.SelectedRows[0].Cells["clReserId"].Value.ToString());
            MessageBox.Show("操作成功");

            //LoadCustomer();
            foreach (Control Ctrol in gbCustoInfo.Controls)
            {
                if (Ctrol is TextBox)
                {
                    Ctrol.Text = "";
                }
            }
            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string cardId = CustoManager.GetRandomCustoNo();
            txtCustoNo.Text = cardId;
            txtCustoName.Text = dataGridView1.SelectedRows[0].Cells["clCustoName"].Value.ToString();
            txtTel.Text = dataGridView1.SelectedRows[0].Cells["clCustoTel"].Value.ToString();

        }

        private void txtCardID_Validated(object sender, EventArgs e)
        {
            //获取得到输入的身份证号码
            string identityCard = txtCardID.Text.Trim();
            if (string.IsNullOrEmpty(identityCard))
            {
                //身份证号码不能为空，如果为空返回
                MessageBox.Show("身份证号码不能为空！");
                if (txtCardID.CanFocus)
                {
                    txtCardID.Focus();//设置当前输入焦点为txtCardID_identityCard
                }
                return;
            }
            else
            {
                //身份证号码只能为15位或18位其它不合法
                if (identityCard.Length != 15 && identityCard.Length != 18)
                {
                    MessageBox.Show("身份证号码为15位或18位，请检查！");
                    if (txtCardID.CanFocus)
                    {
                        txtCardID.Focus();
                    }
                    return;
                }
            }
            string birthday = "";
            string sex = "";
            if (identityCard.Length == 18)
            {
                SqlConnection con = DBHelper.GetConnection();
                con.Open();
                SqlDataReader dr = DBHelper.ExecuteReader("select Province,City,District from CARDCODES where bm='" + identityCard.Substring(0, 6).ToString() + "'");
                birthday = identityCard.Substring(6, 4) + "-" + identityCard.Substring(10, 2) + "-" + identityCard.Substring(12, 2);
                sex = identityCard.Substring(14, 3);
                while (dr.Read())
                {
                    txtCustoAdress.Text = dr["Province"].ToString() + dr["City"].ToString() + dr["District"].ToString();
                }
                //性别代码为偶数是女性奇数为男性
                if (int.Parse(sex) % 2 == 0)
                {
                    cboSex.Text = "女";
                }
                else
                {
                    cboSex.Text = "男";
                }
                dr.Close();
                con.Close();
            }
            try
            {
                dtpBirthday.Value = Convert.ToDateTime(birthday);
            }
            catch
            {
                MessageBox.Show("请正确输入证件号码！");
            }

            cboPassport.SelectedIndex = 0;

            return;

        }
    }
}
