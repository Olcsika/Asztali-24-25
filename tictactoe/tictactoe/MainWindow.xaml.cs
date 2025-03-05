using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace tictactoe
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

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (button2.Content == "") 
            {
                button2.Content ="X";
            }      
        }

        private void button2_Copy_Click(object sender, RoutedEventArgs e)
        {
            
            
        }

        private void button2_Copy1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button2_Copy2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button2_Copy3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button2_Copy4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button2_Copy5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button2_Copy6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button2_Copy7_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}