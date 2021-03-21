﻿/*
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
using SYS.Core;
using Sunny.UI;
using System.Collections.Generic;
using SYS.Application;

namespace SYS.FormUI
{
    public partial class FrmSelectCustoInfo : UIForm
    {
        public FrmSelectCustoInfo()
        {
            InitializeComponent();
        }

        #region 存放客户信息类
        public static string co_CustoNo;
        public static string co_RoomNo;
        public static string co_CustoName;
        public static string co_CustoBirthday;
        public static string co_CustoSex;
        public static string co_CustoTel;
        public static string co_CustoPassportType;
        public static string co_CustoAddress;
        public static string co_CustoType;
        public static string co_CustoID;
        #endregion

        private void FrmSelectCustoInfo_Load(object sender, EventArgs e)
        {

            foreach (Control label in this.Controls)
            {
                label.Font = UI_FontUtil.controlFont;
            }
            #region 加载客户类型信息
            List<CustoType> lstSourceGrid = new BaseService().SelectCustoTypeAllCanUse();
            this.cbCustoType.DataSource = lstSourceGrid;
            this.cbCustoType.DisplayMember = "TypeName";
            this.cbCustoType.ValueMember = "UserType";
            this.cbCustoType.SelectedIndex = 0;
            this.cbCustoType.ReadOnly = true;
            #endregion

            #region 加载证件类型信息
            List<PassPortType> passPorts = new BaseService().SelectPassPortTypeAllCanUse();
            this.cbPassportType.DataSource = passPorts;
            this.cbPassportType.DisplayMember = "PassportName";
            this.cbPassportType.ValueMember = "PassportId";
            this.cbPassportType.SelectedIndex = 0;
            #endregion

            #region 加载性别信息
            List<SexType> listSexType = new BaseService().SelectSexTypeAllCanUse();
            this.cbSex.DataSource = listSexType;
            this.cbSex.DisplayMember = "sexName";
            this.cbSex.ValueMember = "sexId";
            this.cbSex.SelectedIndex = 0;
            #endregion
            
            txtCustoNo.Text = ucRoomList.rm_CustoNo;
            Custo c = new CustoService().SelectCardInfoByCustoNo(txtCustoNo.Text);
            txtCustoAdress.Text = c.CustoAdress;
            txtCustoName.Text = c.CustoName;
            txtCardID.Text = c.CustoID;
            txtCustoTel.Text = c.CustoTel;
            cbSex.Text = c.CustoSex == 1 ? "男" : "女";
            cbCustoType.SelectedIndex = c.CustoType;
            cbPassportType.SelectedIndex = c.PassportType;
            dtpBirthday.Value = c.CustoBirth;
        }
    }
}
