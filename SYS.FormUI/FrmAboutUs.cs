using System;
using System.Drawing;
using System.Windows.Forms;

namespace SYS.FormUI
{
    public partial class FrmAboutUs : Form
    {
        public FrmAboutUs()
        {
            InitializeComponent();
        }

        #region 记录鼠标和窗体坐标的方法
        private Point mouseOld;//鼠标旧坐标
        private Point formOld;//窗体旧坐标 
        #endregion

        #region 记录移动的窗体坐标
        private void FrmAboutUs_MouseDown(object sender, MouseEventArgs e)
        {
            formOld = this.Location;
            mouseOld = MousePosition;
        }
        #endregion

        #region 记录窗体移动的坐标
        private void FrmAboutUs_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mouseNew = MousePosition;
                int moveX = mouseNew.X - mouseOld.X;
                int moveY = mouseNew.Y - mouseOld.Y;
                this.Location = new Point(formOld.X + moveX, formOld.Y + moveY);
            }
        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAboutUs_Load(object sender, EventArgs e)
        {

        }
    }
}
