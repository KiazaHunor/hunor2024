using System.DirectoryServices.ActiveDirectory;
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

namespace aknakereso2
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
        int akna = 10;
        Button[,] gombok;
        private void startGomb_Click(object sender, RoutedEventArgs e)

        {
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
                    g.Margin = new Thickness(i + 25, k, 0, 0);
                    racs.Children.Add(g);
                }
            }
            
            racs.Children.Remove()
                this.SizeToContent = SizeToContent.WidthAndHeight;


        void aknaLerak() 
            {
                aknaHely = new int[sor, oszlop];
                for (int i = 0; k < aknaDarab; k++) 
                {
                    int randomSor = rand.Next(sor);
                    int randomOszlop = rand.Next(oszlop);
                    aknaHely = new int[randomOszlop, randomSor];
                }
                
            }












        }
        private void kattintas(object sender, RoutedEventArgs e) 
        {

        }
    }
}