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

namespace ablakos_mindenség
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        Button gomb;
        public Window1(Button gomb)
        {
            InitializeComponent();
            this.gomb = gomb;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            gomb.Content = textBox.Text;
            this.Close();

        }
    }
}
