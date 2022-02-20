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
using SYS.Application;
using SYS.Common;
using SYS.Core;
using SYS.FormUI.Properties;
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
    public partial class FrmPosition : UIForm
    {
        public delegate void PositionInfo();


        //定义委托类型的变量
        public static PositionInfo operation;

        public static PositionInfo reload;

        public static PositionInfo Accessed;

        public static PositionInfo insert;

        public FrmPosition()
        {
            InitializeComponent();
            operation = Visited;
            reload = ReloadPositionList;
            Accessed = Access;
            insert = Insert;
        }

        ucPositionInformation baseInfo = null;
        List<Position> positions = null;
        public static string info = null;
        private void FrmPosition_Load(object sender, EventArgs e)
        {
            ReloadPositionList();
        }

        public void ReloadPositionList()
        {
            flpInformation.Controls.Clear();
            baseInfo = new ucPositionInformation();
            baseInfo.BackgroundImage = Resources.添加__增加___加;
            baseInfo.lbName.Text = "新增职位类型";
            baseInfo.btnOperation.Text = "新增";
            baseInfo.btnOperation.FillColor = Color.FromArgb(80, 160, 255);
            baseInfo.btnOperation.FillHoverColor = Color.FromArgb(80, 180, 255);
            flpInformation.Controls.Add(baseInfo);
            positions = new BaseService().SelectPositionAll();
            for (int i = 0; i < positions.Count; i++)
            {
                baseInfo = new ucPositionInformation();
                baseInfo.lbName.Text = "名称:" + positions[i].position_name;
                if (positions[i].delete_mk == 1)
                {
                    baseInfo.btnOperation.Text = "恢复";
                    baseInfo.btnOperation.FillColor = Color.FromArgb(33, 179, 81);
                    baseInfo.lbName.BackColor = Color.Red;
                    baseInfo.btnOperation.FillHoverColor = Color.FromArgb(128, 255, 128);
                }
                flpInformation.Controls.Add(baseInfo);
            }
        }

        private void flpInformation_SizeChanged(object sender, EventArgs e)
        {
            flpInformation.Width = 660;
            flpInformation.Height = 582;
        }

        public void Visited()
        {
            //筛选出只与当前职位对应的数据
            Position position = positions.FirstOrDefault(a => a.position_name.Equals(info));
            if (position.position_name.Equals(info))
            {
                var _position = new Position()
                {
                    position_no = position.position_no,
                    delete_mk = 1,
                    datachg_usr = AdminInfo.Account,
                    datachg_date = DateTime.Now
                };
                if (_position != null)
                {
                    bool n = new BaseService().DelPosition(_position);
                    if (n == true)
                    {
                        UIMessageBox.ShowSuccess("删除成功！");
                        #region 获取添加操作日志所需的信息
                        RecordHelper.Record(AdminInfo.Account + "-" + AdminInfo.Name + "在" + DateTime.Now + "位于" + AdminInfo.SoftwareVersion + "执行：" + "删除职位类型操作！删除值为：" + _position.position_no, 2);
                        #endregion
                        ReloadPositionList();
                    }
                }
            }
        }
        public void Access()
        {
            //筛选出只与当前职位对应的数据
            Position position = positions.FirstOrDefault(a => a.position_name.Equals(info));
            if (position.position_name.Equals(info))
            {
                var _position = new Position()
                {
                    position_no = position.position_no,
                    delete_mk = 0,
                    datachg_usr = AdminInfo.Account,
                    datachg_date = DateTime.Now
                };
                if (_position != null)
                {
                    bool n = new BaseService().DelPosition(_position);
                    if (n == true)
                    {
                        UIMessageBox.ShowSuccess("恢复成功！");
                        #region 获取添加操作日志所需的信息
                        RecordHelper.Record(AdminInfo.Account + "-" + AdminInfo.Name + "在" + DateTime.Now + "位于" + AdminInfo.SoftwareVersion + "执行：" + "恢复职位类型操作！恢复值为：" + _position.position_no, 2);
                        #endregion
                        ReloadPositionList();
                    }
                }
            }

        }

        public void Insert()
        {
            var _position = new Position()
            {
                position_no = new SYS.Core.CounterHelper().GetNewId(CounterRuleConsts.PositionId).ToString(),
                position_name = info,
                delete_mk = 0,
                datains_usr = AdminInfo.Account,
                datains_date = DateTime.Now
            };
            if (_position != null)
            {
                bool n = new BaseService().AddPosition(_position);
                if (n == true)
                {
                    UIMessageBox.ShowSuccess("新增成功！");
                    #region 获取添加操作日志所需的信息
                    RecordHelper.Record(AdminInfo.Account + "-" + AdminInfo.Name + "在" + DateTime.Now + "位于" + AdminInfo.SoftwareVersion + "执行：" + "新增职位类型操作！新增值为：" + _position.position_no, 2);
                    #endregion
                    ReloadPositionList();
                }
            }
        }
    }
}
