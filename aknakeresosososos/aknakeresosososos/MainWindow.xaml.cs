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

namespace aknakeresosososos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.SizeToContent = SizeToContent.WidthAndHeight;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 10; i++) 
            {
                Button btn = new Button();
                btn.Content = i.ToString();
                btn.MaxHeight = 100;
                btn.MaxWidth = 100;
                btn.HorizontalAlignment = HorizontalAlignment.Left; ;
                btn.VerticalAlignment = VerticalAlignment.Top;
                


            }
        }
    }
}