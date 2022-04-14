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

namespace WaterSupply.Lists.Changeses
{
    /// <summary>
    /// Логика взаимодействия для ChengesPlaceComp.xaml
    /// </summary>
    public partial class ChengesPlaceComp : Page
    {
        public ChengesPlaceComp()
        {
            InitializeComponent();
            NameOrg.ItemsSource = DataBase.a.Subscriber.ToList();
            _plac = new Place_execution();
        }

        public ChengesPlaceComp(Place_execution place)
        {
            InitializeComponent();
            NameOrg.ItemsSource = DataBase.a.Subscriber.ToList();
            _plac = place;
        }
        public Place_execution _plac;

        private void NOk_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Content = new PlaceCompletionPage();
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены, что хотите изменить запись?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    if (_plac.Place_execution_number == 0)
                    {
                        DataBase.a.Place_execution.Add(_plac);
                        MessageBox.Show("Место исполнения добавлен!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    DataBase.a.SaveChanges();
                    NavigationService.Navigate(new PlaceCompletionPage());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Введены некорректные данные или остались незаполненные поля!", "Оповещение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void NumPlace_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = _plac;
        }
    }
}
