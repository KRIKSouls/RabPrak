using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace WaterSupply
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public static string Encrypt(string value)
        {
            StringBuilder Sb = new StringBuilder();

            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(value));

                foreach (Byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }


        private void Input_Click(object sender, RoutedEventArgs e)
        {
            string EncryptPassword = Encrypt(Pass.Password);
            try 
            {
                User EnterUser = DataBase.a.User.Where(l => l.login == Login.Text && l.password == EncryptPassword).FirstOrDefault();
                if (EnterUser != null)
                {
                    MainWn win = new MainWn();
                    this.Close();
                    win.Show();
                }
                else throw new Exception("Пользователь не найден");
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка с sql сервером","Ошибка!",  MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
