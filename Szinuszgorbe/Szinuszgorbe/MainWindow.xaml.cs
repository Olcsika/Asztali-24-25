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

namespace Szinuszgorbe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    //1.kordinata rendszer
    //2.kör(vekony)
    //3.fekete pont
    //4.sugar
    //5.magassag(piros)
    //6.szinusz görbe
    //7.korív(nagy)
    //8.körív(kicsi)
    //9.adattábla(szög egyebek)
    //sine curve and the unit circle
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void vaszon_Loaded(object sender, RoutedEventArgs e)
        {
            kordinataRajzol();
        }
        int r = 100;
        void kordinataRajzol()
        {
            Line xTengely = new Line();
            xTengely.Stroke=Brushes.Black;
            xTengely.X1 = 0;
            xTengely.Y1 = Height/2;
            xTengely.X2 = Width;
            xTengely.Y2 = Height/2;


            Line yTengely = new Line();
            yTengely.Stroke = Brushes.Black;
            yTengely.X1 = r * 1.1;
            yTengely.Y1 = 0;
            yTengely.X2 = r * 1.1;
            yTengely.Y2 = Height;


            vaszon.Children.Add(xTengely);
            vaszon.Children.Add(yTengely);

        }
    }
}