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
using EOM.TSHotelManager.Common.Core;
using Sunny.UI;
using SYS.Common;
using System;
using System.Collections.Generic;

namespace SYS.FormUI
{
    public partial class FrmGoodOrBad : UIForm
    {
        public FrmGoodOrBad()
        {
            InitializeComponent();
        }

        Dictionary<string, string> dic = null;
        ResponseMsg result = null;

        private void FrmGoodOrBad_Load(object sender, EventArgs e)
        {
            LoadGoodBadInfo();
            result = HttpHelper.Request("Base/SelectGBTypeAllCanUse");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectGBTypeAllCanUse+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            CboType.DataSource = HttpHelper.JsonToList<GBType>(result.message);
            CboType.DisplayMember = "GBName";
            CboType.ValueMember = "GBTypeId";
        }

        public void LoadGoodBadInfo()
        {
            DgvGoodBadList.Rows.Clear();
            lblWorkerNo.Text = FrmWorkerManager.wk_WorkerNo;
            lblName.Text = FrmWorkerManager.wk_WorkerName;
            lblDate.Text = Convert.ToDateTime(FrmWorkerManager.wk_WorkerTime).ToString("yyyy年MM月dd日").Substring(0, 9);
            dic = new Dictionary<string, string>()
            {
                { "wn",lblWorkerNo.Text}
            };
            result = HttpHelper.Request("WorkerGoodBad/SelectAllGoodBadByWorkNo", null, dic);
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectAllGoodBadByWorkNo+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            DgvGoodBadList.AutoGenerateColumns = false;
            DgvGoodBadList.DataSource = HttpHelper.JsonToList<WorkerGoodBad>(result.message);
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
            };
            if (CheckInput(goodBad))
            {
                bool dr = UIMessageBox.Show("确定录入？一旦录入后将无法修改及删除，或会影响员工的晋升！", "录入警告", UIStyle.Orange, UIMessageBoxButtons.OKCancel);
                if (dr)
                {
                    result = HttpHelper.Request("WorkerGoodBad​/AddGoodBad", HttpHelper.ModelToJson(goodBad));
                    if (result.statusCode != 200)
                    {
                        UIMessageBox.ShowError("AddGoodBad+接口服务异常，请提交Issue或尝试更新版本！");
                        return;
                    }
                    bool n = result.message.ToString().Equals("true");
                    if (n)
                    {
                        UIMessageBox.Show("新增成功！", "系统提示", UIStyle.Green, UIMessageBoxButtons.OK);
                        #region 获取添加操作日志所需的信息
                        RecordHelper.Record(AdminInfo.Account + "-" + AdminInfo.Name + "在" + DateTime.Now + "位于" + AdminInfo.SoftwareVersion + "执行：" + "录入员工奖惩操作！新增值为：" + goodBad.GBInfo, 2);
                        #endregion
                        LoadGoodBadInfo();
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
