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
using WaterSupply.Lists.Changeses;

namespace WaterSupply.Lists
{
    /// <summary>
    /// Логика взаимодействия для PlaceCompletionPage.xaml
    /// </summary>
    public partial class PlaceCompletionPage : Page
    {
        public PlaceCompletionPage()
        {
            InitializeComponent();
            dgPlace.ItemsSource = DataBase.a.Place_execution.ToList();
        }

        private void btnDob_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Content = new ChengesPlaceComp();
        }

        private void btnEzm_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dgPlace.SelectedItems.Count > 0)
                {
                    var tablplace = dgPlace.SelectedItem as Place_execution;
                    NavigationService.Content = new ChengesPlaceComp(tablplace);
                }
                else MessageBox.Show("Выберите строку для изменения.", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SubBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Content = new SubscriberPage();
        }

        private void ContractPG_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Content = new ContractPage();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены, что хотите удалить запись?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    if (dgPlace.SelectedItems.Count > 0)
                    {
                        var a = dgPlace.SelectedItem as Place_execution;
                        DataBase.a.Place_execution.Remove(a);
                        DataBase.a.SaveChanges();
                        dgPlace.ItemsSource = DataBase.a.Place_execution.ToList();
                    }
                    else MessageBox.Show("Выберите строку для удаления.", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SortName_Click(object sender, RoutedEventArgs e)
        {
            dgPlace.ItemsSource = DataBase.a.Place_execution.OrderBy(c => c.Title).ToList();
        }

        private void SortNameOrg_Click(object sender, RoutedEventArgs e)
        {
            dgPlace.ItemsSource = DataBase.a.Place_execution.OrderBy(c => c.Subscriber.Name_organization).ToList();
        }

        private void SearchNumPlace_TextChanged(object sender, TextChangedEventArgs e)
        {
            dgPlace.ItemsSource = DataBase.a.Place_execution.Where(p => p.Title.ToString().Contains(SearchNumPlace.Text)).ToList();
        }

        private void dgPlace_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex() + 1).ToString();
        }
    }
}
