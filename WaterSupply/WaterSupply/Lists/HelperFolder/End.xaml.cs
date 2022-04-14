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

namespace WaterSupply.Lists.HelperFolder
{
    /// <summary>
    /// Логика взаимодействия для End.xaml
    /// </summary>
    public partial class End : Page
    {
        public End()
        {
            InitializeComponent();
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Content = new Helper();
        }
    }
}
