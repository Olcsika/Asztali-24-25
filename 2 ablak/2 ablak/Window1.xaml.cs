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
using System.Windows.Shapes;

namespace _2_ablak
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        MainWindow szulo;
        public Window1(MainWindow szulo)
        {
            this.szulo = szulo;
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            szulo.button.Content = "OK";
            this.Close();

        }
    }
}
