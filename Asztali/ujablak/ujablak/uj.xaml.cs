using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ujablak
{
    /// <summary>
    /// Interaction logic for uj.xaml
    /// </summary>
    public partial class ujAblak : Window
    {
        Button gomb;
        public ujAblak(Button gomb)
        {
            this.gomb=gomb;
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            gomb.Content=textBox.Text;
            this.Close();
        }
    }
}
