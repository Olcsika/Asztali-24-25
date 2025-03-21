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
using static System.Net.Mime.MediaTypeNames;

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
        int aknaDarab = 10;
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
                    g.ContextMenuOpening += jeloles;
                    g.Margin = new Thickness(i * 25, k * 25, 0, 0);
                    racs.Children.Add(g);
                    gombok[k, i] = g;
                }
            }
            racs.Children.Remove(startGomb);
            this.SizeToContent = SizeToContent.WidthAndHeight;
            aknalerak();

        }
        int[,] aknaHely;
        Random rand = new Random();
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

            for (int k = 0; k < aknaHely.GetLength(0); k++)
            {
                for (int i = 0; i < aknaHely.GetLength(1); i++)
                {
                    if (aknaHely[k, i] != 10)
                    {
                        aknaHely[k, i] = aknaSzamol(k, i);
                    }
                }
            }

        }
        void aknaMutat()
        {
            for (int k = 0; k < aknaHely.GetLength(0); k++)
            {
                for (int i = 0; i < aknaHely.GetLength(1); i++)
                {
                    if (aknaHely[k, i] == 10)
                    {
                        System.Windows.Controls.Image akna = new System.Windows.Controls.Image();
                        akna.Source = new BitmapImage(new Uri("/akna3.jpg", UriKind.Relative));

                        gombok[k, i].Content = akna;
                    }
                   
                }
            }
        }
        int aknaSzamol(int sor, int oszlop)
        {
            int db = 0;
            if (sor - 1 >= 0 && oszlop - 1 >= 0 && aknaHely[sor - 1, oszlop - 1] == 10) { db++; }
            if (sor - 1 >= 0 && oszlop >= 0 && aknaHely[sor - 1, oszlop] == 10) { db++; }
            if (sor - 1 >= 0 && oszlop + 1 < this.oszlop && aknaHely[sor - 1, oszlop + 1] == 10) { db++; }

            if (sor >= 0 && oszlop - 1 >= 0 && aknaHely[sor, oszlop - 1] == 10) { db++; }
            if (sor >= 0 && oszlop + 1 < this.oszlop && aknaHely[sor, oszlop + 1] == 10) { db++; }

            if (sor + 1 < this.sor && oszlop - 1 >= 0 && aknaHely[sor + 1, oszlop - 1] == 10) { db++; }
            if (sor + 1 < this.sor && oszlop >= 0 && aknaHely[sor + 1, oszlop] == 10) { db++; }
            if (sor + 1 < this.sor && oszlop + 1 < this.oszlop && aknaHely[sor + 1, oszlop + 1] == 10) { db++; }

            return db;
        }

        void helyEllenoriz(int sor, int oszlop)
        {
            if (aknaHely[sor, oszlop] == 10)
            {
            
                aknaMutat();
            }
            else if (aknaHely[sor, oszlop] == 0)
            {
                gombok[sor, oszlop].Background = Brushes.GreenYellow;
                for (int i = -1; i < 2; i++)
                {
                    for (int j = -1; j < 2; j++)
                    {
                        try
                        {
                            int temp = aknaHely[sor + i, oszlop + j];
                            if ((i != 0 || j != 0) && gombok[sor + i, oszlop + j].Background != Brushes.GreenYellow)
                            {
                                helyEllenoriz(sor + i, oszlop + j);
                            }
                        }
                        catch
                        {

                        }
                    }
                }
            }
            else
            {
                gombok[sor, oszlop].Content = aknaHely[sor, oszlop];
            }
        }




        private void kattintas(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;

            for (int i = 0; i < gombok.GetLength(0); i++)
            {
                for (int j = 0; j < gombok.GetLength(1); j++)
                {
                    if (gombok[i, j] == button)
                    {

                        helyEllenoriz(i, j);
                        i = gombok.GetLength(0);
                        j = gombok.GetLength(1);
                    }
                }
            }
        }
        private void jeloles(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;

            for (int i = 0; i < gombok.GetLength(0); i++)
            {
                for (int j = 0; j < gombok.GetLength(1); j++)
                {
                    if (gombok[i, j] == button)
                    {
                        System.Windows.Controls.Image akna = new System.Windows.Controls.Image();
                        akna.Source= new BitmapImage(new Uri("/zsu.png", UriKind.Relative));

                        gombok[i, j].Content = akna;
                    }
                }
            }
        }
        void jatekellenoriz()
        {
            for (int i = 0; i < gombok.GetLength(0); i++)
            {
                for (int j = 0; j < gombok.GetLength(1); j++)
                {
                    if (gombok[i, j].Background == Brushes.White)
                    {
                        
                    }
                    if (gombok[i, j].Content != "" && aknaHely[i,j]==10)
                    {

                    }

                }
            }
        }
    }
}