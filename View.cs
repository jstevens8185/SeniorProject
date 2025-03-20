using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SeniorProject
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
            LoadChartData();
        }

        private void LoadChartData()
        {
            // Clear previous data
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.Legends.Clear();

            // Create a ChartArea
            ChartArea chartArea = new ChartArea();
            chartArea.AxisX.Title = "Year";
            chartArea.AxisX.Interval = 1; // Ensures one tick per year
            chartArea.AxisX.MajorGrid.Enabled = false; // Optional: Hide grid

            chartArea.AxisY.Title = "% Students Meeting Target";
            chartArea.AxisY.LabelStyle.Format = "0%"; // Display as percentage
            chart1.ChartAreas.Add(chartArea);

            // Create and add two data series
            AddSeries("SLO 1 M1", Color.Blue, new Dictionary<int, double>
            {
                { 2020, 0.39 }, { 2021, 0.50 }, { 2022, 0.43 }, { 2023, 0.55 }, { 2024, 0.72 }
            });

            AddSeries("SLO 1 M2", Color.Red, new Dictionary<int, double>
            {
                { 2020, 0.50 }, { 2021, 0.55 }, { 2022, 0.52 }, { 2023, 0.58 }, { 2024, 0.53 }
            });

            AddSeries("SLO 1 T1", Color.Green, new Dictionary<int, double>
            {
                { 2020, 0.70 },  { 2024, 0.70 }
            });

            AddSeries("SLO 2 T1", Color.Purple, new Dictionary<int, double>
            {
                { 2020, 0.60 },  { 2024, 0.60 }
            });

            // Add legend
            chart1.Legends.Add(new Legend("Legend"));
        }

        private void AddSeries(string seriesName, Color color, Dictionary<int, double> data)
        {
            Series series = new Series(seriesName)
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 2,
                Color = color
            };

            foreach (var point in data)
            {
                series.Points.AddXY(point.Key, point.Value);
            }

            chart1.Series.Add(series);
        }
    }
}
