﻿using System;
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
using WaterSupply.Lists.HelperFolder;

namespace WaterSupply.Lists
{
    /// <summary>
    /// Логика взаимодействия для Inf.xaml
    /// </summary>
    public partial class Inf : Page
    {
        public Inf()
        {
            InitializeComponent();
        }

        private void Svoistv_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new PageProperties());
        }

        private void Pomosh_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Helper());
        }
    }
}
