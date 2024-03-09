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

namespace SYS.FormUI
{
    public partial class FrmChart : UIForm
    {
        public FrmChart()
        {
            InitializeComponent();
        }

        ResponseMsg result = null;

        private void FrmChart_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series("商品销售额(/元)");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            //series.BorderWidth = 2;
            series.IsValueShownAsLabel = true;
            result = HttpHelper.Request("Custo/SelectAllMoney");
            if (result.statusCode != 200)
            {
                UIMessageBox.ShowError("SelectAllMoney+接口服务异常，请提交Issue或尝试更新版本！");
                return;
            }
            var listHotelMoney = HttpHelper.JsonToList<CustoSpend>(result.message);
            listHotelMoney.ForEach(source =>
            {
                series.Points.AddXY(Convert.ToDouble(source.Years.ToString()), Convert.ToDouble(Convert.ToDouble(source.Money.ToString())));
            });
            chart1.Series.Add(series);
            label2.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

    }

}
