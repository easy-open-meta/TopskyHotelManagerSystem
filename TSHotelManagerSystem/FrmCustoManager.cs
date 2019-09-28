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
using TSHotelManagerSystem.Properties;

namespace TSHotelManagerSystem
{
    public partial class FrmCustoManager : Form
    {
        public FrmCustoManager()
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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

        private void FrmCustoManager_Load(object sender, EventArgs e)
        {
            dgvCustomerList.AutoGenerateColumns = false;
            LoadCustomer();
            LoadCustoType();
            txtCustoNo.ReadOnly = true;
            CmpSetDgv();
            cboSex.SelectedIndex = 0;
            cboCustoType.SelectedIndex = 3;
        }
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
        private void picAddCusto_Click_1(object sender, EventArgs e)
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
            picAddCusto.BackgroundImage = Resources.添_加a;
        }
        #endregion

        #region 修改会员信息事件方法
        private void picUpdateCusto_Click_1(object sender, EventArgs e)
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
        private void picSearch_Click_1(object sender, EventArgs e)
        {
            picAddCusto.BackgroundImage = Resources.添_加a;
            picSearch.BackgroundImage = Resources.搜索__1a;
            dgvCustomerList.DataSource = CustoService.SelectCustoInfoByCardId(txtSerach.Text);
        }
        #endregion

        #region 导出事件方法
        private void picLoadOut_Click_1(object sender, EventArgs e)
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

        private void picGetCustoNo_Click_1(object sender, EventArgs e)
        {
            string cardId = CustoManager.GetRandomCustoNo();
            txtCustoNo.Text = cardId;
            picGetCustoNo.BackgroundImage = Resources.获取用户编号_ia;
        }

        private void picGetCustoNo_MouseLeave_1(object sender, EventArgs e)
        {
            picGetCustoNo.BackgroundImage = Resources.获取用户编号;
        }

        private void txtCardID_Validated(object sender, EventArgs e)
        {

        }
    }
}
