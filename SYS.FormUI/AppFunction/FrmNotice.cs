using Sunny.UI;
using SYS.Application;
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
    public partial class FrmNotice : UIForm
    {
        public FrmNotice()
        {
            InitializeComponent();
        }

        private void FrmNotice_Load(object sender, EventArgs e)
        {
            foreach (Control label in this.Controls)
            {
                label.Font = UI_FontUtil.controlFont;
            }

            List<Notice> notices = new NoticeService().SelectNoticeAll();
            notices.ForEach(source =>
            {
                dgvNoticeList.Items.Add(source.NoticeNo + ":" + source.Noticetheme);
            });
        }

        private void dgvNoticeList_ItemClick(object sender, EventArgs e)
        {
            //根据:来分割字符串并返回第一项数据即为公告编号
            var str = dgvNoticeList.SelectedItem.ToString().Split(":").First();
            Notice notice = new NoticeService().SelectNoticeByNoticeNo(str);
            if (notice != null)
            {
                rtbNoticeContent.Html = notice.NoticeContent;
            }
        }
    }
}
