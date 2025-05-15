using System.IO;
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

namespace Kutyak
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

        List<KutyaNev> kutyaNevek = new List<KutyaNev>();
        List<KutyaFajta> kutyaFajtak = new List<KutyaFajta>();
        List<Kutya> kutyak = new List<Kutya>();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string[] sorok = File.ReadAllLines("KutyaNevek.csv");
            for (int i = 1; i < sorok.Length; i++) 
            {
                string[] vag = sorok[i].Split(";");
                kutyaNevek.Add(new KutyaNev(Convert.ToInt32(vag[0]), vag[1]));
            }

            sorok = File.ReadAllLines("KutyaFajtak.csv");
            for(int i = 1;i < sorok.Length; i++) 
            {
                string[] vag =sorok[i].Split(";");
                kutyaFajtak.Add(new KutyaFajta(int.Parse(vag[0]), vag[1], vag[2]));
            }


            sorok = File.ReadAllLines("Kutyak.csv");
            for (int i = 1; i < sorok.Length; i++)
            {
                string[] vag = sorok[i].Split(";");
                kutyak.Add(new Kutya(int.Parse(vag[0]),
                                     int.Parse(vag[1]),
                                     int.Parse(vag[2]),
                                     int.Parse(vag[3]),
                                     DateOnly.Parse(vag[4]),
                                     kutyaFajtak.Where(x => x.id == int.Parse(vag[1])).First(),
                                     kutyaNevek.Where(x => x.id == int.Parse(vag[2])).First()));

            }


        }

        
















        private void Button_Click(object sender, RoutedEventArgs e)
        {
            label2.Content = kutyaNevek.Count;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            List<int> korok = new List<int>();
            korok=kutyak.Select(x => x.kor).ToList();
            label4.Content = Math.Round(korok.Average(),2);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            List<int> korok = new List<int>();
            korok = kutyak.Select(x => x.kor).ToList();
            int maximum=korok.Max();

             Kutya legidosEb = kutyak.Where(x => x.kor == maximum).First();
             label6.Content = legidosEb.nev.nev + " ," + legidosEb.fajta.nev;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var aznapi=kutyak.Where(x=>x.datum==DateOnly.FromDateTime((DateTime)datePicker.SelectedDate));
            lisBox.ItemsSource = aznapi.Select(x => x.nev.nev);
        }
    }
}