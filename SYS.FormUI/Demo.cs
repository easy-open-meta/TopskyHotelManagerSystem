using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChartDirector;

namespace TSHotelManagerSystem
{
    class Demo
    {
        //Name of demo module
        public string getName() { return "Simple Bar Chart (2)"; }

        //Number of charts produced in this demo module
        public int getNoOfCharts() { return 1; }

        //Main code for creating chart.
        //Note: the argument chartIndex is unused because this demo only has 1 chart.
        public void createChart(WinChartViewer viewer, int chartIndex)
        {
            // The data for the bar chart
            double[] data = { 85, 156, 179, 211, 123, 189, 166 };

            // The labels for the bar chart
            string[] labels = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };

            // Create a XYChart object of size 600 x 400 pixels
            XYChart c = new XYChart(600, 400);

            // Set default text color to dark grey (0x333333)
            c.setColor(Chart.TextColor, 0x333333);

            // Add a title box using grey (0x555555) 24pt Arial Bold font
            c.addTitle("    Bar Chart Demonstration", "Arial Bold", 24, 0x555555);

            // Set the plotarea at (70, 60) and of size 500 x 300 pixels, with transparent
            // background and border and light grey (0xcccccc) horizontal grid lines
            c.setPlotArea(70, 60, 500, 300, Chart.Transparent, -1, Chart.Transparent, 0xcccccc);

            // Set the x and y axis stems to transparent and the label font to 12pt Arial
            c.xAxis().setColors(Chart.Transparent);
            c.yAxis().setColors(Chart.Transparent);
            c.xAxis().setLabelStyle("Arial", 12);
            c.yAxis().setLabelStyle("Arial", 12);

            // Add a blue (0x6699bb) bar chart layer with transparent border using the given data
            c.addBarLayer(data, 0x6699bb).setBorderColor(Chart.Transparent);

            // Set the labels on the x axis.
            c.xAxis().setLabels(labels);

            // For the automatic y-axis labels, set the minimum spacing to 40 pixels.
            c.yAxis().setTickDensity(40);

            // Add a title to the y axis using dark grey (0x555555) 14pt Arial Bold font
            c.yAxis().setTitle("Y-Axis Title Placeholder", "Arial Bold", 14, 0x555555);

            // Output the chart
            viewer.Chart = c;

            //include tool tip for the chart
            viewer.ImageMap = c.getHTMLImageMap("clickable", "", "title='{xLabel}: {value} kg'");
        }
    }
}
