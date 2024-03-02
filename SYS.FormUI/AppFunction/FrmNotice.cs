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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYS.FormUI
{
    public partial class FrmNotice : UIForm
    {
        public FrmNotice()
        {
            InitializeComponent();
        }

        Dictionary<string, string> dic = null;
        ResponseMsg result = null;

        private void FrmNotice_Load(object sender, EventArgs e)
        {
            result = HttpHelper.Request("Notice/SelectNoticeAll");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectNoticeAll+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            List<Notice> notices = HttpHelper.JsonToList<Notice>(result.message);
            notices.ForEach(source =>
            {
                dgvNoticeList.Items.Add(source.NoticeNo + ":" + source.Noticetheme);
            });
        }

        private void dgvNoticeList_ItemClick(object sender, EventArgs e)
        {
            //根据:来分割字符串并返回第一项数据即为公告编号
            var str = dgvNoticeList.SelectedItem.ToString().Split(":").First();
            dic= new Dictionary<string, string>()
            {
                { "noticeId",str}
            };
            result = HttpHelper.Request("Notice/SelectNoticeByNoticeNo",null,dic);
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectNoticeAll+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            Notice notice = HttpHelper.JsonToModel<Notice>(result.message);
            if (notice != null)
            {
                rtbNoticeContent.Html = notice.NoticeContent;
            }
        }
    }
}
