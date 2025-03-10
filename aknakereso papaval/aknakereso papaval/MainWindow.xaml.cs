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

namespace aknakereso_papaval
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
        int sor = 10;
        int oszlop = 10;
        int aknaDarab = 0;
        Button[,] gombok;

        private void startGomb_Click(object sender, RoutedEventArgs e)
        {
            gombok = new Button[sor, oszlop];
            for (int k = 0; k < sor; k++)
            {
                
                for (int i = 0; i < oszlop; i++)
                {
                   
                    Button g = new Button();
                    g.VerticalAlignment = VerticalAlignment.Top;
                    g.HorizontalAlignment = HorizontalAlignment.Left;
                    g.Width = 25;
                    g.Height = 25;
                    g.Click += kattintas;
                    g.Margin = new Thickness(i * 25, k*25, 0, 0);
                    racs.Children.Add(g);
                    gombok[k, i] = g;   
                }
            }
            racs.Children.Remove(startGomb);
            this.SizeToContent = SizeToContent.WidthAndHeight;
            aknalerak();
            
            
        }
        int[,] aknaHely;
        Random rand  = new Random();
        void aknalerak()
        {
            aknaHely = new int[sor, oszlop];
            
            
            for (int k = 0; k < aknaDarab; k++) 
            {
                int randomSor = rand.Next(sor);
                int randomOszlop = rand.Next(oszlop);
                if (aknaHely[randomSor, randomOszlop] == 10)
                {
                    k--;
                }
                else
                {
                    aknaHely[randomSor, randomOszlop] = 10;
                }
                
            }   
            
        }
        void aknaMutat()
        {
            for (int k = 0; k < aknaHely.GetLength(0); k++)
            {
                for (int i = 0; i < aknaHely.GetLength(1); i++)
                {
                    gombok[k, i].Content=aknaHely[k, i];
                }
            }
        }
        int aknaSzamol(int sor,int oszlop)
        {

        }
        private void kattintas(object sender, RoutedEventArgs e) 
        {

        }
    }
}