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
    /// Логика взаимодействия для ChangesContract.xaml
    /// </summary>
    public partial class ChangesContract : Page
    {
        public ChangesContract()
        {
            InitializeComponent();
            NameOrg.ItemsSource = DataBase.a.Subscriber.ToList();
            NumInd.ItemsSource = DataBase.a.Drinking_water_quality_indicator.ToList();
            NumVol.ItemsSource = DataBase.a.Volume_of_drinking_water_consumption.ToList();
            CbName.ItemsSource = DataBase.a.Employee.ToList();
            CbLast.ItemsSource = DataBase.a.Employee.ToList();
            CbOtch.ItemsSource = DataBase.a.Employee.ToList();
            _con = new Contract();
        }

        public ChangesContract(Contract contract)
        {
            InitializeComponent();
            NameOrg.ItemsSource = DataBase.a.Subscriber.ToList();
            NumInd.ItemsSource = DataBase.a.Drinking_water_quality_indicator.ToList();
            NumVol.ItemsSource = DataBase.a.Volume_of_drinking_water_consumption.ToList();
            CbName.ItemsSource = DataBase.a.Employee.ToList();
            CbLast.ItemsSource = DataBase.a.Employee.ToList();
            CbOtch.ItemsSource = DataBase.a.Employee.ToList();
            _con = contract;
        }
        public Contract _con;

        private void NOk_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Content = new ContractPage();
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены, что хотите изменить запись?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    if (_con.Contract_number == 0)
                    {
                        DataBase.a.Contract.Add(_con);
                        MessageBox.Show("Контракт добавлен!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    DataBase.a.SaveChanges();
                    NavigationService.Navigate(new ContractPage());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Введены некорректные данные или остались незаполненные поля!", "Оповещение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void NumCon_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        private void Pay_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = _con;
        }
    }
}
