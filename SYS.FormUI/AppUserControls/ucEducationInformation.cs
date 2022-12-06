/*
 * MIT License
 *Copyright (c) 2021 咖啡与网络(java-and-net)

 *Permission is hereby granted, free of charge, to any person obtaining a copy
 *of this software and associated documentation files (the "Software"), to deal
 *in the Software without restriction, including without limitation the rights
 *to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 *copies of the Software, and to permit persons to whom the Software is
 *furnished to do so, subject to the following conditions:

 *The above copyright notice and this permission notice shall be included in all
 *copies or substantial portions of the Software.

 *THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 *IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 *FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 *AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 *LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 *OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 *SOFTWARE.
 *
 */
using SYS.Core;
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
    public partial class ucEducationInformation : UserControl
    {


        public ucEducationInformation()
        {
            InitializeComponent();
        }

        private void ucBaseInformation_Load(object sender, EventArgs e)
        {
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
            if (btnOperation.Text == "恢复")
            {
                FrmEducation.info = lbName.Text.Replace("名称:", string.Empty).ToString();
                FrmEducation.Accessed();
                return;
            }
            FrmEducation.info = lbName.Text.Replace("名称:", string.Empty).ToString();
            FrmEducation.operation();
            return;
        }

        private void lbName_MouseLeave(object sender, EventArgs e)
        {
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
            //FrmEducation.info = lbName.Text.ToString();
            //FrmEducation.insert();
        }
    }
}
