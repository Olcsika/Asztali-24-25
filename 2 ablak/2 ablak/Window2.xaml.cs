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
using System.Windows.Shapes;

namespace _2_ablak
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        MainWindow szulo1;
        public Window2(MainWindow szulo1)
        {
            InitializeComponent();
            this.szulo1 = szulo1;
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string szoveg = textBox.Text;
            szulo1.textBlock.Text = szoveg;
            this.Close();
        }
    }
}
