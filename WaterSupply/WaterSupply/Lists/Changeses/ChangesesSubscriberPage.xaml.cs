using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WaterSupply.Lists.Changeses
{
    /// <summary>
    /// Логика взаимодействия для ChangesesSubscriberPage.xaml
    /// </summary>
    public partial class ChangesesSubscriberPage : Page
    {
        public ChangesesSubscriberPage()
        {
            InitializeComponent();
            _sub = new Subscriber();
        }

        public ChangesesSubscriberPage(Subscriber subscriber)
        {
            InitializeComponent();
            _sub = subscriber;
            TINSub.Visibility = Visibility.Hidden;
            TN.Visibility = Visibility.Hidden;
        }
        public Subscriber _sub;

        private void NOk_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Content = new SubscriberPage();
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены, что хотите изменить запись?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    if (_sub.ID_Sub == 0)
                    {
                        DataBase.a.Subscriber.Add(_sub);
                        MessageBox.Show("Абонент добавлен!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    DataBase.a.SaveChanges();
                    NavigationService.Navigate(new SubscriberPage());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Введены некорректные данные или остались незаполненные поля!", "Оповещение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void TINSub_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
             if (!Char.IsDigit(e.Text, 0))
             {
                 e.Handled = true;
             }
        }

        private void Dir_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex inp = new Regex("^[А-Я]+", RegexOptions.IgnoreCase);
            if (!inp.IsMatch(e.Text) && (e.Text == ",") && (e.Text == ",")
            && (!Dir.Text.Contains(",")))
            {
                e.Handled = true;
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = _sub;
        }
    }
}
