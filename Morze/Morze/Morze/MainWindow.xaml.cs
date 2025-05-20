using System.Text;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Morze
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

        List<Morzek> jelek = new List<Morzek>();
        List<Idezet> idezetek = new List<Idezet>();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string[] sorok = File.ReadAllLines("morzeabc.txt"); 
            for (int i = 1; i < sorok.Length; i++) 
            {
                string[] vag = sorok[i].Split("\t");
                jelek.Add(new Morzek((vag[0]), vag[1]));

            }

            sorok = File.ReadAllLines("morze.txt");
            for (int i = 0; i < sorok.Length; i++) 
            {
                string[] vag = sorok[i].Split(";");
                idezetek.Add(new Idezet(vag[0], vag[1]));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
                label1.Content = jelek.Count.ToString();
        }

        private void beker_KeyDown(object sender, KeyEventArgs e)
        {

        }



        /*private void Grid_KeyDown(object sender, KeyEventArgs e)
        {

        }
        */




    }
}