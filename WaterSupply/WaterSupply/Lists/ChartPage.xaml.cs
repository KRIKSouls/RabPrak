using ScottPlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WaterSupply.Lists
{
    /// <summary>
    /// Логика взаимодействия для ChartPage.xaml
    /// </summary>
    public partial class ChartPage : Page
    {
        public ChartPage()
        {
            InitializeComponent();

            double[] values = { 26, 20, 23};
            double[] positions = { 0, 1, 2};
            string[] labels = { "Котельная №5", "Котельная №2", "Автоматизированная Блочно-Модульная Коттельная"};
            WpfPlot1.Plot.AddBar(values, positions);
            WpfPlot1.Plot.XTicks(positions, labels);
            WpfPlot1.Plot.SetAxisLimits(yMin: 0);

            WpfPlot1.Plot.SaveFig("bar_labels.png");

            WpfPlot1.Refresh();
        }
    }
}
