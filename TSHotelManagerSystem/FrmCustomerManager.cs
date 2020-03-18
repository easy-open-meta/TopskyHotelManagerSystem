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
using Excel = Microsoft.Office.Interop.Excel;
using TSHotelManagerSystem.Properties;
using System.Text.RegularExpressions;

namespace TSHotelManagerSystem
{
    public partial class FrmCustomerManager : Form
    {
        public FrmCustomerManager()
        {
            InitializeComponent();
        }

        public void CmpSetDgv()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCustomerList.AllowUserToAddRows = false;
            this.dgvCustomerList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            this.dgvCustomerList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomerList.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomerList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCustomerList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;//211, 223, 240
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 14, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvCustomerList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerList.EnableHeadersVisualStyles = false;
            this.dgvCustomerList.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvCustomerList.ReadOnly = true;
            this.dgvCustomerList.RowHeadersVisible = false;
            this.dgvCustomerList.RowTemplate.Height = 23;
            this.dgvCustomerList.RowTemplate.ReadOnly = true;
        }

        #region 用户管理界面加载事件方法
        private void FrmCustomerManager_Load(object sender, EventArgs e)
        {
            CmpSetDgv();
            dgvCustomerList.AutoGenerateColumns = false;
            LoadCustomer();
            LoadCustoType();
            txtCustoNo.ReadOnly = true;

            cboSex.SelectedIndex = 0;
            cboCustoType.SelectedIndex = 0;


        }
        #endregion

        #region 加载客户类型事件方法
        public void LoadCustoType()
        {
            cboCustoType.DataSource = CustoTypeManager.SelectCustoTypesAll();
            cboCustoType.DisplayMember = "TypeName";//显示的列名
            cboCustoType.ValueMember = "UserType";//绑定的值
        }
        #endregion

        #region 加载用户信息列表
        private void LoadCustomer()
        {
            dgvCustomerList.DataSource = CustoService.SelectCustoAll();
        }
        #endregion

        #region 点击DataGridView数据加载到控件上
        private void dgvCustomerList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCardID.PasswordChar = Convert.ToChar("*");
            picShow.BackgroundImage = Resources.隐藏;
            txtCustoNo.Text = dgvCustomerList.SelectedRows[0].Cells["clCustoNo"].Value.ToString();
            txtCustoName.Text = dgvCustomerList.SelectedRows[0].Cells["clCustoName"].Value.ToString();
            cboSex.Text = dgvCustomerList.SelectedRows[0].Cells["clCustoSex"].Value.ToString();
            txtTel.Text = dgvCustomerList.SelectedRows[0].Cells["clCustoTel"].Value.ToString();
            cboPassport.Text = dgvCustomerList.SelectedRows[0].Cells["clPassport"].Value.ToString();
            txtCardID.Text = dgvCustomerList.SelectedRows[0].Cells["clCustoID"].Value.ToString();
            txtCustoAdress.Text = dgvCustomerList.SelectedRows[0].Cells["clCustoAdress"].Value.ToString();
            dtpBirthday.Text = dgvCustomerList.SelectedRows[0].Cells["clCustoBirth"].Value.ToString();
            cboCustoType.Text = dgvCustomerList.SelectedRows[0].Cells["clCustoType"].Value.ToString();

        }
        #endregion

        #region 添加会员信息事件方法
        private void picAddCusto_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCustoName.Text == "")
                {
                    MessageBox.Show("添加失败，必填信息不可为空");
                }
                else
                {
                    string sql = "insert USERINFO(CustoNo,CustoName,CustoSex,CustoTel,PassportType,CustoID,CustoAdress,CustoBirth,CustoType)";
                    sql += " values('" + txtCustoNo.Text + "','" + txtCustoName.Text + "','" + cboSex.Text + "','" + txtTel.Text + "','" + cboPassport.SelectedIndex + "','" + txtCardID.Text + "','" + txtCustoAdress.Text + "','" + dtpBirthday.Value + "','" + cboCustoType.SelectedIndex + "') ";
                    SqlConnection con = DBHelper.GetConnection();
                    con.Open();
                    int i = DBHelper.ExecuteNonQuery(sql);
                    MessageBox.Show("添加成功");

                    LoadCustomer();
                    foreach (Control Ctrol in gbCustoInfo.Controls)
                    {
                        if (Ctrol is TextBox)
                        {
                            Ctrol.Text = "";
                        }
                    }
                    con.Close();

                }
            }
            catch
            {

                
            }
            
            picAddCusto.BackgroundImage = Resources.添_加a;



        }
        #endregion

        #region 修改会员信息事件方法
        private void picUpdateCusto_Click(object sender, EventArgs e)
        {
            string sql = "update USERINFO set CustoName='" + txtCustoName.Text + "',CustoSex='" + cboSex.Text + "',CustoTel='" + txtTel.Text + "',PassportType='" + cboPassport.SelectedIndex + "',CustoID='" + txtCardID.Text + "',CustoAdress='" + txtCustoAdress.Text + "',CustoBirth='" + dtpBirthday.Value.ToShortTimeString() + "',CustoType='" + cboCustoType.SelectedIndex + "' where CustoNo='" + txtCustoNo.Text + "'";
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            int i = DBHelper.ExecuteNonQuery(sql);
            MessageBox.Show("修改成功");
            LoadCustomer();
            foreach (Control Ctrol in gbCustoInfo.Controls)
            {
                if (Ctrol is TextBox)
                {
                    Ctrol.Text = "";
                }
            }
            picAddCusto.BackgroundImage = Resources.添_加a;

        }
        #endregion

        #region 搜索会员信息事件方法
        private void picSearch_Click(object sender, EventArgs e)
        {
            picAddCusto.BackgroundImage = Resources.添_加a;
            picSearch.BackgroundImage = Resources.搜索__1a;
            if (txtCardID.Text != "")
            {
                Custo c = CustoService.SelectCustoInfoByCardId(txtCardID.Text);
                if (c != null)
                {
                    dgvCustomerList.DataSource = c;
                }
                else
                {
                    MessageBox.Show("用户不存在！", "来自小T的提示");
                }
            }
            else
            {
                MessageBox.Show("请输入证件号码！", "来自小T的提示");
                txtCardID.Focus();
            }
        }
        #endregion

        #region 计算点击次数
        private int n = 0;
        #endregion

        #region 隐藏显示信息
        private void picShow_Click(object sender, EventArgs e)
        {
            if (n == 0)
            {
                this.picShow.BackgroundImage = Resources.隐藏;
                n = 1;
                txtCardID.PasswordChar = Convert.ToChar("*");

            }
            else if (n == 1)
            {
                DialogResult ret = MessageBox.Show("证件号码为敏感信息，确定要进行查看吗？(此步操作将写入操作日志)", "信息提醒", MessageBoxButtons.YesNo);
                if (ret == DialogResult.Yes)
                {
                    this.picShow.BackgroundImage = Resources.显示;
                    n = 0;
                    txtCardID.PasswordChar = new char();
                    #region 获取添加操作日志所需的信息
                    Operation o = new Operation();
                    o.OperationTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd,HH:mm:ss"));
                    o.Operationlog = LoginInfo.WorkerClub + LoginInfo.WorkerPosition + LoginInfo.WorkerName + "于" + DateTime.Now + "查看了" + txtCustoNo.Text + "的证件号码!";
                    o.OperationAccount = LoginInfo.WorkerClub + LoginInfo.WorkerPosition + LoginInfo.WorkerName;
                    #endregion
                    OperationManager.InsertOperationLog(o);
                }
                else
                {
                    MessageBox.Show("操作不成功！");
                }

            }
        }
        #endregion

        #region 导出事件方法
        private void picLoadOut_Click(object sender, EventArgs e)
        {
            #region 导出信息保存为Excel表
            DialogResult ret = MessageBox.Show("导出信息为敏感操作，确定要继续导出吗？(此步操作将写入操作日志)", "信息提醒", MessageBoxButtons.YesNo);
            if (ret == DialogResult.Yes)
            {

                //Response.ContentEncoding = System.Text.Encoding.UTF8;
                string fileName = "";
                string saveFileName = "";
                //fileName.Charset = "GB2312";
                SaveFileDialog saveDialog = new SaveFileDialog();
                //saveDialog.DefaultExt = "xls";
                saveDialog.FileName = fileName;
                saveDialog.Filter = "2003~2007工作表*.xls|*.xls|2010及以上版本工作表*.xlsx|*.xlsx";
                saveDialog.ShowDialog();
                saveFileName = saveDialog.FileName;
                if (saveFileName.IndexOf(":") < 0) return;
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                if (xlApp == null)
                {
                    MessageBox.Show("无法创建Excel对象,您的电脑可能未安装Excel！", "来自T仔的提醒");
                    return;
                }
                Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;
                Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
                Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];
                for (int i = 0; i < this.dgvCustomerList.Columns.Count; i++)
                {
                    xlApp.Cells[1, i + 1] = dgvCustomerList.Columns[i].HeaderText;
                }
                for (int i = 0; i < dgvCustomerList.Rows.Count; i++)//添加每一项
                {
                    for (int j = 0; j < dgvCustomerList.Columns.Count; j++)
                    {
                        xlApp.Cells[i + 2, j + 1] = dgvCustomerList.Rows[i].Cells[j].Value.ToString();
                    }
                }
                System.Windows.Forms.Application.DoEvents();
                worksheet.Columns.EntireColumn.AutoFit();//列宽自适应
                MessageBox.Show(fileName + "信息导出成功", "来自T仔提示", MessageBoxButtons.OK);
                #region 获取添加操作日志所需的信息
                Operation o = new Operation();
                o.OperationTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd,HH:mm:ss"));
                o.Operationlog = LoginInfo.WorkerClub + LoginInfo.WorkerName + LoginInfo.WorkerPosition + LoginInfo.WorkerName + "于" + DateTime.Now + "导出了" + "用户信息!";
                o.OperationAccount = LoginInfo.WorkerClub + LoginInfo.WorkerName + LoginInfo.WorkerPosition;
                #endregion
                OperationManager.InsertOperationLog(o);
                System.Diagnostics.Process.Start("Explorer.exe", saveFileName);
                if (saveFileName != "")
                {
                    try
                    {
                        workbook.Saved = true;
                        workbook.SaveCopyAs(saveFileName);  //fileSaved = true;                 
                    }
                    catch (Exception ex)
                    {//fileSaved = false;                      
                        MessageBox.Show("导出文件时出错,文件可能正被打开！\n" + ex.Message);
                    }
                }
                xlApp.Quit();
                GC.Collect();
                #endregion
            }
        }
        #endregion

        private void picGetCustoNo_Click(object sender, EventArgs e)
        {
            string cardId = CustoManager.GetRandomCustoNo();
            txtCustoNo.Text = cardId;
            picGetCustoNo.BackgroundImage = Resources.获取用户编号_ia;
        }

        private void picGetCustoNo_MouseLeave(object sender, EventArgs e)
        {
            picGetCustoNo.BackgroundImage = Resources.获取用户编号;
        }

        private void txtCardID_TextChanged(object sender, EventArgs e)
        {
            if (txtCardID.Text != "")
            {
                int num = txtCardID.TextLength;
                if (num <= 17)
                {
                    Regex reg = new Regex("^[0-9]+$");
                    Match ma = reg.Match(txtCardID.Text);
                    if (ma.Success)
                    {

                    }
                    else
                    {
                        MessageBox.Show("不可输入非数字");
                    }
                }
                if (num > 17)
                {
                    Regex reg = new Regex("^[0-9Xx]+$");
                    Match ma = reg.Match(txtCardID.Text);
                    if (ma.Success)
                    {

                    }
                    else
                    {
                        MessageBox.Show("最后一位只能数字和X");
                    }
                }
            }
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
