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
using Microsoft.Win32;

namespace WaterSupply.Lists
{
    /// <summary>
    /// Логика взаимодействия для WaterQualityPage.xaml
    /// </summary>
    public partial class WaterQualityPage : Page
    {
        public WaterQualityPage()
        {
            InitializeComponent();
            dgQuality.ItemsSource = DataBase.a.Drinking_water_quality_indicator.ToList();
        }

        private void WaterVPG_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Content = new VolumePage();
        }

        private void ContractPG_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Content = new ContractPage();
        }

        private void SubBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Content = new SubscriberPage();
        }

        private void WordBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dgQuality.SelectedItems.Count > 0)
                {
                    {
                SaveFileDialog sfd = new SaveFileDialog();
                string source = $@"{Directory.GetCurrentDirectory()}\Показатель качества питьевой воды.docx";
                word.Application app = new word.Application();
                word.Document doc = app.Documents.Open(source);
                doc.Activate();
                try
                {
                    var x = dgQuality.SelectedItem as Drinking_water_quality_indicator;
                    if (sfd.ShowDialog() == false)
                    {
                        doc.Close();
                        doc = null;
                        app.Quit();
                        return;
                    }
                    var results = DataBase.a.Drinking_water_quality_indicator.Where(P => P.Indicator_number == x.Indicator_number).FirstOrDefault();
                    word.Bookmarks wB = doc.Bookmarks;
                    wB["НомерПоказателя"].Range.Text = results.Indicator_number.ToString();
                    wB["Показатели"].Range.Text = results.Indicators.ToString();
                    wB["ЕдиницыИзмерения"].Range.Text = results.Units_measurement.ToString();
                    wB["Нормативы"].Range.Text = results.Regulations.ToString();
                    wB["ПоказательВредности"].Range.Text = results.Indicator_harmfulness.ToString();
                    wB["КлассОпасности"].Range.Text = results.Hazard_class.ToString();
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

        private void SortNumInd_Click(object sender, RoutedEventArgs e)
        {
            dgQuality.ItemsSource = DataBase.a.Drinking_water_quality_indicator.OrderBy(c => c.Indicator_number).ToList();
        }

        private void SortHazzard_Click(object sender, RoutedEventArgs e)
        {
            dgQuality.ItemsSource = DataBase.a.Drinking_water_quality_indicator.OrderBy(c => c.Hazard_class).ToList();
        }

        private void SearchNumInd_TextChanged(object sender, TextChangedEventArgs e)
        {
            dgQuality.ItemsSource = DataBase.a.Drinking_water_quality_indicator.Where(p => p.Indicator_number.ToString().Contains(SearchNumInd.Text)).ToList();
        }

        private void SearchNumInd_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        private void dgQuality_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex() + 1).ToString();
        }
    }
}
