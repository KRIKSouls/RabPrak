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
    /// Логика взаимодействия для SubscriberPage.xaml
    /// </summary>
    public partial class SubscriberPage : Page
    {
        public SubscriberPage()
        {
            InitializeComponent();
            dgSub.ItemsSource = DataBase.a.Subscriber.ToList();
        }

        private void ContBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Content = new ContractPage();
        }

        private void btnDob_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Content = new ChangesesSubscriberPage();
        }

        private void btnEzm_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dgSub.SelectedItems.Count > 0)
                {
                    var tablcont = dgSub.SelectedItem as Subscriber;
                    NavigationService.Content = new ChangesesSubscriberPage(tablcont);
                }
                else MessageBox.Show("Выберите строку для изменения.", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PlaceBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Content = new PlaceCompletionPage();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены, что хотите удалить запись?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    if (dgSub.SelectedItems.Count > 0)
                    {
                        var a = dgSub.SelectedItem as Subscriber;
                        DataBase.a.Subscriber.Remove(a);
                        DataBase.a.SaveChanges();
                        dgSub.ItemsSource = DataBase.a.Subscriber.ToList();
                    }
                    else MessageBox.Show("Выберите строку для удаления.", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SortDir_Click(object sender, RoutedEventArgs e)
        {
            dgSub.ItemsSource = DataBase.a.Subscriber.OrderBy(c => c.Director).ToList();
        }

        private void SortNameOrg_Click(object sender, RoutedEventArgs e)
        {
            dgSub.ItemsSource = DataBase.a.Subscriber.OrderBy(c => c.Name_organization).ToList();
        }

        private void SearchTIN_TextChanged(object sender, TextChangedEventArgs e)
        {
            dgSub.ItemsSource = DataBase.a.Subscriber.Where(p => p.Subscribers_TIN.ToString().Contains(SearchTIN.Text)).ToList();
        }

        private void SearchTIN_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        private void dgSub_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex() + 1).ToString();
        }
    }
}
