﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace aknakereso
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            

        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Button newBtn = new Button();

                newBtn.Content = i.ToString();
                newBtn.Content = "Button" + i.ToString();

            }
        }
    }
}