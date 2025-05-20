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

namespace kosar2004
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

        List<Eredmeny> eredmenyek = new List<Eredmeny>();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string[] sorok = File.ReadAllLines("eredmenyek.csv");
            for (int i = 1; i < sorok.Length; i++) 
            {
                string[] vag = sorok[i].Split(";");
                eredmenyek.Add(new Eredmeny(
                            vag[0],
                            vag[1],
                            int.Parse(vag[2]),
                            int.Parse(vag[3]),
                            vag[4],
                            DateOnly.Parse(vag[5])
                            ));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            label3.Content = eredmenyek[0].hazaiPont;
            label5.Content = eredmenyek[0].idegenPont;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            bool dontetlen =eredmenyek.Any(x=>x.idegenPont == x.hazaiPont);
            if (dontetlen)
                label7.Content = "Igen";
            else 
            {
                label7.Content = "Nem";
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var nevKeres = eredmenyek.FirstOrDefault(x => x.hazai.Contains("Barcelona"));
            if(nevKeres != null) 
            {
                label9.Content = nevKeres.hazai;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var keresettDatum = DateOnly.FromDateTime((DateTime)datePicker.SelectedDate);

            var meccs = eredmenyek
                .Where(x => x.ido == keresettDatum)
                .GroupBy(x => x.hazai)
                .SelectMany(e => e.Select(x => $"{x.hazai} {x.idegen} {x.hazaiPont} {x.idegenPont}"))
                .ToList();

            listBox.ItemsSource = meccs;
                   
        }
    }
}