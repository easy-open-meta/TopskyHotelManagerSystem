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
    public partial class FrmNation : UIForm
    {

        public delegate void OperationInfo();


        //定义委托类型的变量
        public static OperationInfo operation;

        public static OperationInfo reload;

        public static OperationInfo Accessed;

        public static OperationInfo insert;

        public FrmNation()
        {
            InitializeComponent();
            operation = Visited;
            reload = ReloadNationList;
            Accessed = Access;
        }

        ucBaseInformation baseInfo = null;
        List<Nation> nations = null;
        public static string info = null;
        private void FrmNation_Load(object sender, EventArgs e)
        {
            ReloadNationList();

        }

        public void ReloadNationList() 
        {
            flpInformation.Controls.Clear();
            nations = new BaseService().SelectNationAll();
            for (int i = 0; i < nations.Count; i++)
            {
                baseInfo = new ucBaseInformation();
                baseInfo.lbName.Text = "名称:" + nations[i].nation_name;
                if (nations[i].delete_mk == 1)
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
            //flpInformation.Width = 660;
            //flpInformation.Height = 582;
        }

        public void Visited()
        {
            //筛选出只与当前民族对应的数据
            Nation nation = nations.FirstOrDefault(a => a.nation_name.Equals(info));
            if (nation.nation_name.Equals(info))
            {
                var _nation = new Nation()
                {
                    nation_no = nation.nation_no,
                    delete_mk = 1,
                    datachg_usr = AdminInfo.Account,
                    datachg_date = DateTime.Now
                };
                if (_nation != null)
                {
                    bool n = new BaseService().DelNation(_nation);
                    if (n == true)
                    {
                        UIMessageBox.ShowSuccess("删除成功！");
                        #region 获取添加操作日志所需的信息
                        RecordHelper.Record(AdminInfo.Account + "-" + AdminInfo.Name + "在" + DateTime.Now + "位于" + AdminInfo.SoftwareVersion + "执行：" + "删除民族类型操作！删除值为：" + _nation.nation_no, 2);
                        #endregion
                        ReloadNationList();
                    }
                }
            }
        }
        public void Access()
        {
            //筛选出只与当前民族对应的数据
            Nation nation = nations.FirstOrDefault(a => a.nation_name.Equals(info));
            if (nation.nation_name.Equals(info))
            {
                var _nation = new Nation()
                {
                    nation_no = nation.nation_no,
                    delete_mk = 0,
                    datachg_usr = AdminInfo.Account,
                    datachg_date = DateTime.Now
                };
                if (_nation != null)
                {
                    bool n = new BaseService().DelNation(_nation);
                    if (n == true)
                    {
                        UIMessageBox.ShowSuccess("恢复成功！");
                        #region 获取添加操作日志所需的信息
                        RecordHelper.Record(AdminInfo.Account + "-" + AdminInfo.Name + "在" + DateTime.Now + "位于" + AdminInfo.SoftwareVersion + "执行：" + "恢复民族类型操作！恢复值为：" + _nation.nation_no, 2);
                        #endregion
                        ReloadNationList();
                    }
                }
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNationNm.Text.Trim().IsNullOrEmpty())
            {
                UIMessageTip.ShowError("民族名称为空，请检查", 3000);
                return;
            }
            var _nation = new Nation()
            {
                nation_no = new SYS.Core.CounterHelper().GetNewId(CounterRuleConsts.NationId).ToString(),
                nation_name = txtNationNm.Text.Trim(),
                delete_mk = 0,
                datains_usr = AdminInfo.Account,
                datains_date = DateTime.Now
            };
            if (_nation != null)
            {
                bool n = new BaseService().AddNation(_nation);
                if (n == true)
                {
                    UIMessageBox.ShowSuccess("新增成功！");
                    #region 获取添加操作日志所需的信息
                    RecordHelper.Record(AdminInfo.Account + "-" + AdminInfo.Name + "在" + DateTime.Now + "位于" + AdminInfo.SoftwareVersion + "执行：" + "新增民族类型操作！新增值为：" + _nation.nation_no, 2);
                    #endregion
                    ReloadNationList();
                    txtNationNm.Text = "";
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtNationNm.Text.Trim().IsNullOrEmpty())
            {
                UIMessageTip.ShowError("民族名称为空，请检查", 3000);
                return;
            }
            var listSource = new BaseService().SelectNationAll(new Nation { nation_name = txtNationNm.Text.Trim() });
            flpInformation.Controls.Clear();
            for (int i = 0; i < listSource.Count; i++)
            {
                baseInfo = new ucBaseInformation();
                baseInfo.Tag = "民族";
                baseInfo.lbName.Text = "名称:" + listSource[i].nation_name;
                if (listSource[i].delete_mk == 1)
                {
                    baseInfo.btnOperation.Text = "恢复";
                    baseInfo.btnOperation.FillColor = Color.FromArgb(33, 179, 81);
                    baseInfo.lbName.BackColor = Color.Red;
                    baseInfo.btnOperation.FillHoverColor = Color.FromArgb(128, 255, 128);
                }
                flpInformation.Controls.Add(baseInfo);
            }
        }
    }
}
