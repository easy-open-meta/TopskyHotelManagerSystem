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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SYS.Core;
using Sunny.UI;
using SYS.Application;

namespace SYS.FormUI
{
    public partial class FrmGoodOrBad : UIForm
    {
        public FrmGoodOrBad()
        {
            InitializeComponent();
        }



        private void FrmGoodOrBad_Load(object sender, EventArgs e)
        {
            lblWorkerNo.Text = FrmWorkerManager.wk_WorkerNo;
            lblName.Text = FrmWorkerManager.wk_WorkerName;
            lblDate.Text = Convert.ToDateTime(FrmWorkerManager.wk_WorkerTime).ToString("yyyy年MM月dd日").Substring(0,9);
            DgvGoodBadList.AutoGenerateColumns = false;
            DgvGoodBadList.DataSource = new WorkerGoodBadService().SelectAllGoodBadByWorkNo(lblWorkerNo.Text);
            CboType.DataSource = new BaseService().SelectGBTypeAll();
            CboType.DisplayMember = "GBName";
            CboType.ValueMember = "GBTypeId";
        }

        public bool CheckInput(WorkerGoodBad workerGoodBad)
        {
            if (string.IsNullOrWhiteSpace(workerGoodBad.WorkNo))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(workerGoodBad.GBType + ""))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(workerGoodBad.GBInfo))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(workerGoodBad.GBTime + ""))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(workerGoodBad.GBOperation))
            {
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            WorkerGoodBad goodBad = new WorkerGoodBad()
            {
                WorkNo = lblWorkerNo.Text,
                GBType = (int)CboType.SelectedValue,
                GBInfo = RtbGBInfo.Text,
                GBOperation = AdminInfo.Account,
                GBTime = DtpDate.Value,
                datains_usr = AdminInfo.Account,
                datains_date = DateTime.Now
            };
            if (CheckInput(goodBad))
            {
                bool dr = UIMessageBox.Show("确定录入？一旦录入后将无法修改及删除，或会影响员工的晋升！", "录入警告",UIStyle.Orange, UIMessageBoxButtons.OKCancel);
                if (!dr)
                {
                    bool n = new WorkerGoodBadService().AddGoodBad(goodBad);
                    if (n == true)
                    {
                        UIMessageBox.Show("新增成功！","系统提示",UIStyle.Green,UIMessageBoxButtons.OK);
                        #region 获取添加操作日志所需的信息
                        OperationLog o = new OperationLog();
                        o.OperationTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd,HH:mm:ss"));
                        o.Operationlog = AdminInfo.Account + AdminInfo.Name + "于" + DateTime.Now + "对员工：" + lblName.Text + "进行了奖罚情况录入！";
                        o.OperationAccount = LoginInfo.WorkerNo;
                        o.datains_usr = LoginInfo.WorkerNo;
                        o.datains_date = DateTime.Now;
                        new OperationlogService().InsertOperationLog(o);
                        #endregion
                        DgvGoodBadList.DataSource = new WorkerGoodBadService().SelectAllGoodBadByWorkNo(lblWorkerNo.Text);
                    }
                    else
                    {
                        UIMessageBox.Show("或是服务器错误所致！", "系统提示", UIStyle.Red, UIMessageBoxButtons.OK);
                        return;
                    }
                }
                else
                {
                    UIMessageBox.Show("取消录入操作！", "系统提示", UIStyle.Orange, UIMessageBoxButtons.OK);
                    return;
                }

            }
            else
            {
                UIMessageBox.Show("信息不能为空！", "系统提示", UIStyle.Red, UIMessageBoxButtons.OK);
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
