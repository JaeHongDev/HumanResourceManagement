using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts.Wpf;
using LiveCharts;

namespace Task021
{
    public partial class Task021: UserControl
    {
        public Task021()
        {
            InitializeComponent();
            cartesianChart1.Series.Add(new VerticalLineSeries
            {
                Values = new ChartValues<double> { 3, 5, 2, 6, 2, 7, 1 }
            });

            cartesianChart1.Series.Add(new RowSeries
            {
                Values = new ChartValues<double> { 6, 2, 6, 3, 2, 7, 2 }
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Separator = new Separator { Step = 1 }
            });

            cartesianChart1.AxisX.Add(new Axis
            {
                MinValue = 0
            });

            var tooltip = new DefaultTooltip
            {
                SelectionMode = TooltipSelectionMode.SharedYValues
            };

            cartesianChart1.DataTooltip = tooltip;
        }
    }
}
