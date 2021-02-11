using SYS.Core;
using SYS.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYS.FormUI
{
    public partial class ucBaseInformation : UserControl
    {


        public ucBaseInformation()
        {
            InitializeComponent();
        }

        private void ucBaseInformation_Load(object sender, EventArgs e)
        {
            foreach (Control label in this.Controls)
            {
                if (label.GetType().ToString() == "System.Windows.Forms.Label")
                {
                    label.Font = UI_FontUtil.SetRoomControlsFont();
                }
            }
        }

        private void btnOperation_SizeChanged(object sender, EventArgs e)
        {
            btnOperation.Width = 63;
            btnOperation.Height = 26;
        }

        private void ucBaseInformation_SizeChanged(object sender, EventArgs e)
        {
            this.Width = 130;
            this.Height = 90;
            lbName.Width = 70;
            lbName.Height = 20;
            lbName.FillColor = Color.FromArgb(235, 243, 255);
            lbName.FillDisableColor = Color.FromArgb(235, 243, 255);
            lbName.RectColor = Color.FromArgb(235, 243, 255);
        }

        private void ucBaseInformation_Resize(object sender, EventArgs e)
        {
            btnOperation.Width = 63;
            btnOperation.Height = 26;
            this.Width = 130;
            this.Height = 90;
        }

        private void ucBaseInformation_Layout(object sender, LayoutEventArgs e)
        {
           
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            //lbName.Enabled = true;
            //lbName.ReadOnly = false;
            if (btnOperation.Text == "恢复")
            {
                FrmNation.info = lbName.Text.Replace("名称:", string.Empty).ToString();
                FrmNation.Accessed();
                return;
            }
            if (btnOperation.Text == "新增")
            {
                lbName.Enabled = true;
                lbName.ReadOnly = false;
                return;
            }

            FrmNation.info = lbName.Text.Replace("名称:", string.Empty).ToString();
            FrmNation.operation();
            //MessageBox.Show(lbName.Text.Replace("名称:", string.Empty).ToString());
        }

        private void lbName_MouseLeave(object sender, EventArgs e)
        {
            //lbName.Enabled = false;
            //lbName.ReadOnly = true;
            lbName.FillColor = Color.FromArgb(235, 243, 255);
            lbName.FillDisableColor = Color.FromArgb(235, 243, 255);
            lbName.RectColor = Color.FromArgb(235, 243, 255);
        }

        private void lbName_MouseHover(object sender, EventArgs e)
        {
            //lbName.Enabled = true;
            //lbName.ReadOnly = false;
        }

        private void lbName_Validated(object sender, EventArgs e)
        {
            FrmNation.info = lbName.Text.ToString();
            FrmNation.insert();
        }
    }
}
