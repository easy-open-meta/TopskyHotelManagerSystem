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
using Sunny.UI;

using SYS.Common;
using EOM.TSHotelManager.Common.Core;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SYS.FormUI
{
    public partial class FrmWorkerCheckInfo : UIForm
    {
        public FrmWorkerCheckInfo()
        {
            InitializeComponent();

        }

        Dictionary<string, string> dic = null;
        ResponseMsg result = null;

        private void FrmWorkerCheckInfo_Load(object sender, EventArgs e)
        {
            lblWorkerInfo.Text = "以下为员工：" + FrmChangeWorker.wk_WorkerNo + "-员工姓名：" + FrmChangeWorker.wk_WorkerName + "的所有打卡考勤记录:";
            dic= new Dictionary<string, string>()
            {
                { "wid",FrmChangeWorker.wk_WorkerNo}
            };
            result = HttpHelper.Request("WorkerCheck/SelectCheckInfoByWorkerNo", null, dic);
            if (result.statusCode != 200)
            {
                UIMessageTip.ShowError("SelectCheckInfoByWorkerNo+接口服务异常，请提交issue");
                return;
            }
            DgvCheckInfoList.AutoGenerateColumns = false;
            DgvCheckInfoList.DataSource = HttpHelper.JsonToList<WorkerCheck>(result.message);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
