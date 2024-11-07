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

namespace gyakorlas_11._07
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        private int megnyitasDB = 0;
        
        public Window1()
        {
            InitializeComponent();
        }
        public void Show( bool szamolj) 
        {
            megnyitasDB++;
            label1.Content = megnyitasDB;
            this.Show();
        }


        public int[] darabok = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public void Show(int id)
        {
            darabok[id]++;
            label.Content = id;
        }


        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
