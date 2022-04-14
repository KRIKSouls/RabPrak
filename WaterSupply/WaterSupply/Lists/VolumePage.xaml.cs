using Microsoft.Win32;
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
using word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Word;
using Page = System.Windows.Controls.Page;
using System.Text.RegularExpressions;
using System.IO;

namespace WaterSupply.Lists
{
    /// <summary>
    /// Логика взаимодействия для VolumePage.xaml
    /// </summary>
    public partial class VolumePage : Page
    {
        public VolumePage()
        {
            InitializeComponent();
            dgVol.ItemsSource = DataBase.a.Volume_of_drinking_water_consumption.ToList();
        }

        private void ContractPG_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Content = new ContractPage();
        }

        private void WaterQPG_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Content = new WaterQualityPage();
        }

        private void SubBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Content = new SubscriberPage();
        }

        private void WordBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dgVol.SelectedItems.Count > 0)
                {
                    {
                SaveFileDialog sfd = new SaveFileDialog();
                string source = $@"{Directory.GetCurrentDirectory()}\Объём потребления питьевой воды.docx";
                word.Application app = new word.Application();
                word.Document doc = app.Documents.Open(source);
                doc.Activate();
                try
                {
                    var x = dgVol.SelectedItem as Volume_of_drinking_water_consumption;
                    if (sfd.ShowDialog() == false)
                    {
                        doc.Close();
                        doc = null;
                        app.Quit();
                        return;
                    }
                    var results = DataBase.a.Volume_of_drinking_water_consumption.Where(P => P.Volume_number == x.Volume_number).FirstOrDefault();
                    word.Bookmarks wB = doc.Bookmarks;
                    wB["НомерОбъёма"].Range.Text = results.Volume_number.ToString();
                    wB["ОбщийОбъём"].Range.Text = results.Total_volume.ToString();
                    wB["Стоимость"].Range.Text = results.Price.ToString();
                    wB["ОбщиеКоличествоМесяцев"].Range.Text = results.Total_number_months.ToString();
                    doc.SaveAs2(sfd.FileName);
                    doc.Close();
                    doc = null;
                    app.Quit();
                    MessageBox.Show("Файл успешно создан");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    doc.Close();
                    doc = null;
                    app.Quit();
                }
            }
                }
                else MessageBox.Show("Выберите строку для создания word документа.", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SortPrice_Click(object sender, RoutedEventArgs e)
        {
            dgVol.ItemsSource = DataBase.a.Volume_of_drinking_water_consumption.OrderBy(c => c.Price).ToList();
        }

        private void SortTotalVol_Click(object sender, RoutedEventArgs e)
        {
            dgVol.ItemsSource = DataBase.a.Volume_of_drinking_water_consumption.OrderBy(c => c.Total_volume).ToList();
        }

        private void SearchNumVol_TextChanged(object sender, TextChangedEventArgs e)
        {
            dgVol.ItemsSource = DataBase.a.Volume_of_drinking_water_consumption.Where(p => p.Volume_number.ToString().Contains(SearchNumVol.Text)).ToList();
        }

        private void SearchNumVol_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        private void dgVol_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex() + 1).ToString();
        }
    }
}
