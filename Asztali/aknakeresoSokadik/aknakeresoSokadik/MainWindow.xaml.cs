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

namespace aknakeresoSokadik
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
            racs.Children.Clear();
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
                    if ((aknaHely[k, i])!= 10)
                    {
                        aknaHely[k, i] = aknaSzamol(k, i);
                    };
                }
            }

        }
        void aknaMutat()
        {
            for (int k = 0; k < aknaHely.GetLength(0); k++)
            {
                for (int i = 0; i < aknaHely.GetLength(1); i++)
                {
                    gombok[k, i].Content = aknaHely[k, i];
                }
            }
        }
        int aknaSzamol(int sor, int oszlop)
        {
            int aknak = 0;
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    int ujSor = sor + i;
                    int ujOszlop = oszlop + j;
                    if (ujSor >= 0 && ujSor < this.sor && ujOszlop >= 0 && ujOszlop < this.oszlop)
                    {
                        if (aknaHely[ujSor, ujOszlop] == 10)
                        {
                            aknak++;
                        }
                    }
                }
            }
            return aknak;
        }
        private void kattintas(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            for (int i = 0; i < gombok.GetLength(0); i++)
            {
                for (int k = 0; k < gombok.GetLength(1); k++) 
                {
                    if (gombok[i, k] == button) 
                    {
                        gombok[i, k].Content = aknaHely[i, k];
                        //itt kell megmutatni mi van mögötte
                        

                        k = gombok.GetLength(1);
                        i=gombok.GetLength(0);
                        //break;
                    }
                }
            }






            /*
            if (kattintott == null) return;
            int sorIndex = -1, oszlopIndex = -1;
            for (int i = 0; i < sor; i++)
            {
                for (int j = 0; j < oszlop; j++)
                {
                    if (gombok[i, j] == kattintott)
                    {
                        sorIndex = i;
                        oszlopIndex = j;
                        break;
                    }
                }
            }

            if (sorIndex == -1 || oszlopIndex == -1) return;

            if (aknaHely[sorIndex, oszlopIndex] == 10)
            {
                MessageBox.Show("Vesztettél!");
                aknaMutat();
            }
            else
            {
                int aknak = aknaSzamol(sorIndex, oszlopIndex);
                kattintott.Content = aknak.ToString();
                kattintott.IsEnabled = false;
            }
            */
        }

        void helyEllenoriz(int sor, int oszlop) 
        {
            if (aknaHely[sor, oszlop] == 10) 
            {
                Image akna = new Image();
                
            }
        }

    }
    }
