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
using System.Windows.Shapes;
using WaterSupply.Lists;
using WaterSupply.Properties;

namespace WaterSupply
{
    /// <summary>
    /// Логика взаимодействия для MainWn.xaml
    /// </summary>
    public partial class MainWn : Window
    {
        public MainWn()
        {
            InitializeComponent();
            var mainpage = new mainPage();
            MainFrame.Navigate(mainpage);
        }

        private void ListViewItem_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == true)
            {
                tt_home.Visibility = Visibility.Collapsed;
                tt_contacts.Visibility = Visibility.Collapsed;
                tt_settings.Visibility = Visibility.Collapsed;
                tt_signout.Visibility = Visibility.Collapsed;
            }
            else
            {
                tt_home.Visibility = Visibility.Visible;
                tt_contacts.Visibility = Visibility.Visible;
                tt_settings.Visibility = Visibility.Visible;
                tt_signout.Visibility = Visibility.Visible;
            }
        }
        private void BG_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Tg_Btn.IsChecked = false;
        }

        private void NovAvtorizachia_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Close();
            main.Show();
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ContBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ContractPage());
        }

        private void Subscriber_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new SubscriberPage());
        }

        private void ImgContBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ContractPage());
        }

        private void ImgBtnSub_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new SubscriberPage());
        }

        private void ImgBtnNovAvto_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Close();
            main.Show();
        }

        private void ImgBtnSvoistvo_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Inf());
        }

        private void Svoistvo_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Inf());
        }
    }
}
