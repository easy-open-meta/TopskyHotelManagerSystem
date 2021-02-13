using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Sunny.UI;
using SYS.Application;
using SYS.Core;

namespace SYS.FormUI
{
    public partial class FrmChart : UIForm
    {
        public FrmChart()
        {
            InitializeComponent();
        }

        private void FrmChart_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series("商品销售额(/元)");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            series.BorderWidth = 2;
            series.ShadowOffset = 2;
            series.IsValueShownAsLabel = true;
            var custo = new CustoService().SelectAllMoney();
            for (int i = 0; i < custo.Count; i++)
            {
                series.Points.AddXY(Convert.ToDouble(custo[0].Years.ToString()), Convert.ToDouble(Convert.ToDouble(custo[0].Money.ToString())));
                series.Points.AddXY(Convert.ToDouble(custo[1].Years.ToString()), Convert.ToDouble(Convert.ToDouble(custo[1].Money.ToString())));
                series.Points.AddXY(Convert.ToDouble(custo[2].Years.ToString()), Convert.ToDouble(Convert.ToDouble(custo[2].Money.ToString())));

            }
            chart1.Series.Add(series);

        }

        private void AddSeries(string name, string legendText)
        {
            System.Windows.Forms.DataVisualization.Charting.Series s1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            s1.Name = name;
            s1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            s1.LegendText = legendText;
            this.chart1.Series.Add(s1);
        }





        private void button3_Click(object sender, EventArgs e)
        {

        }
        //画扇形图
        private void button4_Click(object sender, EventArgs e)
        {

        }


        //画曲线图
        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }

}
