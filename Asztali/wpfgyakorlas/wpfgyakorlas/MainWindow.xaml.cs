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

namespace wpfgyakorlas
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
        private void button_Click(object sender, RoutedEventArgs e) 
        {
            
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            int szam1 = int.Parse(textBox1.Text);
            int szam2 = int.Parse(textBox.Text);

            label1.Content = szam1 + szam2;
        }
    }
}