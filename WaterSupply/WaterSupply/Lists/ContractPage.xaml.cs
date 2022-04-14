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
using WaterSupply.Lists.Changeses;
using word = Microsoft.Office.Interop.Word;
using excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using Page = System.Windows.Controls.Page;
using System.Text.RegularExpressions;
using System.IO;

namespace WaterSupply.Lists
{
    /// <summary>
    /// Логика взаимодействия для ContractPage.xaml
    /// </summary>
    public partial class ContractPage : Page
    {
        public ContractPage()
        {
            InitializeComponent();
            dgCont.ItemsSource = DataBase.a.Contract.ToList();
        }

        private void VolumeBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Content = new VolumePage();
        }

        private void ShowingBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Content = new WaterQualityPage();
        }

        private void btnDob_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Content = new ChangesContract();
        }

        private void btnEzm_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dgCont.SelectedItems.Count > 0)
                {
                    var tablcont = dgCont.SelectedItem as Contract;
                    NavigationService.Content = new ChangesContract(tablcont);
                }
                else MessageBox.Show("Выберите строку для изменения.", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SubscriberBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Content = new SubscriberPage();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены, что хотите удалить запись?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {

                    if (dgCont.SelectedItems.Count > 0)
                    {
                        var a = dgCont.SelectedItem as Contract;
                        DataBase.a.Contract.Remove(a);
                        DataBase.a.SaveChanges();
                        dgCont.ItemsSource = DataBase.a.Contract.ToList();
                    }
                    else MessageBox.Show("Выберите строку для удаления.", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SortDateF_Click(object sender, RoutedEventArgs e)
        {
            dgCont.ItemsSource = DataBase.a.Contract.OrderBy(c => c.Finish_Date).ToList();
        }

        private void SortDateS_Click(object sender, RoutedEventArgs e)
        {
            dgCont.ItemsSource = DataBase.a.Contract.OrderBy(c => c.Payment).ToList();
        }

        private void SearchPay_TextChanged(object sender, TextChangedEventArgs e)
        {
            dgCont.ItemsSource = DataBase.a.Contract.Where(p => p.Payment.ToString().Contains(SearchPay.Text)).ToList();
        }

        private void BtnWord_Click(object sender, RoutedEventArgs e)
        {
            try {
                if (dgCont.SelectedItems.Count > 0)
                {
                    {
                SaveFileDialog sfd = new SaveFileDialog();
                string source = $@"{Directory.GetCurrentDirectory()}\Договор.docx";
                word.Application app = new word.Application();
                word.Document doc = app.Documents.Open(source);
                doc.Activate();
                try
                {
                    var x = dgCont.SelectedItem as Contract;
                    if (sfd.ShowDialog() == false)
                    {
                        doc.Close();
                        doc = null;
                        app.Quit();
                        return;
                    }
                    var results = DataBase.a.Contract.Join(DataBase.a.Drinking_water_quality_indicator, contract => contract.Contract_number, ind => ind.Indicator_number,
                        (contract, ind) => new
                        {
                            contract.Contract_number,
                            contract.Signature_date,
                            contract.Payment,
                            contract.Finish_Date,
                            contract.Indicator_number,
                            contract.Volume_number,
                            contract.Code_Employee,
                            contract.Subscribers_TIN,
                            ind.Indicators,
                            ind.Units_measurement,
                            ind.Regulations,
                            ind.Indicator_harmfulness,
                            ind.Hazard_class
                        }).Join(DataBase.a.Volume_of_drinking_water_consumption, contract => contract.Volume_number, vol => vol.Volume_number,
                        (contract, vol) => new
                        {
                            contract.Contract_number,
                            contract.Signature_date,
                            contract.Payment,
                            contract.Finish_Date,
                            contract.Indicator_number,
                            contract.Volume_number,
                            contract.Code_Employee,
                            contract.Subscribers_TIN,
                            contract.Indicators,
                            contract.Units_measurement,
                            contract.Regulations,
                            contract.Indicator_harmfulness,
                            contract.Hazard_class,
                            vol.Total_volume,
                            vol.Price,
                            vol.Total_number_months
                        }).Join(DataBase.a.Employee, contract => contract.Code_Employee, emp => emp.Code_Employee,
                        (contract, emp) => new
                        {
                            contract.Contract_number,
                            contract.Signature_date,
                            contract.Payment,
                            contract.Finish_Date,
                            contract.Indicator_number,
                            contract.Volume_number,
                            contract.Code_Employee,
                            contract.Subscribers_TIN,
                            contract.Indicators,
                            contract.Units_measurement,
                            contract.Regulations,
                            contract.Indicator_harmfulness,
                            contract.Hazard_class,
                            contract.Total_volume,
                            contract.Price,
                            contract.Total_number_months,
                            emp.Surname,
                            emp.NameEmployee,
                            emp.Midllename,
                            emp.Post,
                            emp.Number_Phone
                        }).Join(DataBase.a.Subscriber, contract => contract.Subscribers_TIN, sub => sub.Subscribers_TIN,
                        (contract, sub) => new
                        {
                            contract.Contract_number,
                            contract.Signature_date,
                            contract.Payment,
                            contract.Finish_Date,
                            contract.Indicator_number,
                            contract.Volume_number,
                            contract.Code_Employee,
                            contract.Subscribers_TIN,
                            contract.Indicators,
                            contract.Units_measurement,
                            contract.Regulations,
                            contract.Indicator_harmfulness,
                            contract.Hazard_class,
                            contract.Total_volume,
                            contract.Price,
                            contract.Total_number_months,
                            contract.Surname,
                            contract.NameEmployee,
                            contract.Midllename,
                            contract.Post,
                            contract.Number_Phone,
                            sub.Name_organization,
                            sub.Checking_account,
                            sub.Director,
                            sub.Address,
                            sub.Number,
                            sub.Correspondent_account
                        }).Where(p => p.Contract_number == x.Contract_number).FirstOrDefault();
                    word.Bookmarks wB = doc.Bookmarks;
                    wB["НомерДоговора"].Range.Text = results.Contract_number.ToString();
                    wB["НазваниеОрганизации"].Range.Text = results.Name_organization.ToString();
                    wB["НомерИндекатора"].Range.Text = results.Indicator_number.ToString();
                    wB["НомерОбъёма"].Range.Text = results.Volume_number.ToString();
                    wB["Фамилия"].Range.Text = results.Surname.ToString();
                    wB["Имя"].Range.Text = results.NameEmployee.ToString();
                    wB["Отчество"].Range.Text = results.Midllename.ToString();
                    wB["Оплата"].Range.Text = results.Payment.ToString();
                    wB["НачальнаяДата"].Range.Text = results.Signature_date.ToString();
                    wB["ОкончательнаяДата"].Range.Text = results.Finish_Date.ToString();
                    wB["ДатаНачалаДоговор"].Range.Text = results.Signature_date.ToString();
                    wB["Приложение"].Range.Text = results.Volume_number.ToString();
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

        private void SearchPay_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        private void BtnChart_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Content = new ChartPage();
        }

        private void BtnExcel_Click(object sender, RoutedEventArgs e)
        {
            if (dgCont.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Выберите поле!", "Оповещение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                SaveFileDialog sfd = new SaveFileDialog();
                excel.Application app = new excel.Application();
                excel.Workbook wB;
                excel.Worksheet wS;
                wB = app.Workbooks.Add();
                wS = (excel.Worksheet)wB.Worksheets.get_Item(1);
                wS.Cells[4, 1] = "Номер договора";
                wS.Cells[4, 2] = "Дата подписания";
                wS.Cells[4, 3] = "Дата окончания действия";
                wS.Cells[4, 4] = "Общий объем";
                wS.Cells[4, 5] = "Стоимость";
                var x = dgCont.SelectedItem as Contract;
                try
                {
                    if (sfd.ShowDialog() == false)
                    {
                        wB.Close();
                        wB = null;
                        app.Quit();
                        return;
                    }
                    List<Contract> contracts = DataBase.a.Contract.Where(c => c.Contract_number == x.Contract_number).ToList();
                    dgCont.ItemsSource = contracts;
                    for (int i = 0; i < contracts.Count; i++)
                    {
                        wS.Cells[i + 5, 1].Value = contracts[i].Contract_number;
                        wS.Cells[i + 5, 2].Value = contracts[i].Signature_date;
                        wS.Cells[i + 5, 3].Value = contracts[i].Finish_Date;
                        wS.Cells[i + 5, 4].Value = contracts[i].Volume_of_drinking_water_consumption.Total_volume;
                        wS.Cells[i + 5, 5].Value = contracts[i].Payment;
                    }
                    wS.Columns.AutoFit();
                    app.Application.ActiveWorkbook.SaveAs(sfd.FileName);
                    MessageBox.Show("Файл успешно сохранен");
                    app.Quit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    app.Quit();
                }
            }
        }
    }
}
