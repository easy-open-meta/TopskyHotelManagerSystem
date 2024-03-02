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

using System.Windows.Forms;
using EOM.TSHotelManager.Common.Core;

using Sunny.UI;
using SYS.Common;
using System.Linq;

using System.Collections.Generic;

namespace SYS.FormUI
{
    public partial class FrmUpLoadNotice : UIForm
    {
        public FrmUpLoadNotice()
        {
            InitializeComponent();
        }

        Dictionary<string, string> dic = null;
        ResponseMsg result = null;

        public bool CheckInput(string Content) 
        {
            if (string.IsNullOrWhiteSpace(Content))
            {
                return false;
            }

            if (Content.Contains("alert") || Content.Contains("ALERT"))
            {
                return false;
            }
            return true;
        }

        private void btnUpLoad_Click(object sender, EventArgs e)
        {
            if (CheckInput(rtbNoticeContent.Html))
            {
                Notice notice = new Notice()
                {
                    NoticeNo = Util.GetListNewId("UP",3,1,"-").FirstOrDefault(),
                    Noticetheme = txtNoticeTheme.Text.Trim(),
                    NoticeContent = rtbNoticeContent.Html,
                    NoticeTime = dtpUpLoadDate.Value,
                    NoticeClub = cboSelectClub.SelectedValue.ToString(),
                    datains_usr = AdminInfo.Account,
                };

                switch (cbNoticeType.Text)
                {
                    case "人事变动":
                        notice.NoticeTypeName = "PersonnelChanges";
                        break;
                    case "普通公告":
                        notice.NoticeTypeName = "GeneralNotice";
                        break;
                }
                result = HttpHelper.Request("Notice​/InsertNotice", HttpHelper.ModelToJson(notice));
                if (result.statusCode != 200)
                {
                    UIMessageBox.ShowError("InsertNotice+接口服务异常，请提交Issue或尝试更新版本！");
                    return;
                }
                if (!result.message.ToString().Equals("true"))
                {
                    UIMessageBox.Show("上传失败！", "系统提示", UIStyle.Red, UIMessageBoxButtons.OK);
                    return;
                }
                UIMessageBox.ShowSuccess("上传成功！");
                #region 获取添加操作日志所需的信息
                RecordHelper.Record(AdminInfo.Account + "-" + AdminInfo.Name + "在" + DateTime.Now + "位于" + AdminInfo.SoftwareVersion + "执行：" + "上传公告操作！新增值为：" + notice.NoticeNo, 2);
                #endregion
            }
            else
            {
                UIMessageBox.ShowWarning("含有非法操作字符！");
                return;
            }
            foreach (Control Ctrol in this.Controls)
            {
                if (Ctrol is TextBox)
                {
                    Ctrol.Text = "";
                }
                if (Ctrol is KSharpEditor.KEditor)
                {
                    Ctrol.Text = "";
                }
            }
        }

        

        private void FrmUpLoad_Load(object sender, EventArgs e)
        {
            result = HttpHelper.Request("Base/SelectDeptAllCanUse");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectDeptAllCanUse+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            //加载部门信息
            cboSelectClub.DataSource = HttpHelper.JsonToList<Dept>(result.message);
            cboSelectClub.DisplayMember = "dept_name";
            cboSelectClub.ValueMember = "dept_no";
            
        }
    }
}
