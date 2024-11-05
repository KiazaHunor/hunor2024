using System;
using System.Windows;

namespace LottoSorsolas
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSorsolas_Click(object sender, RoutedEventArgs e)
        {
            // Új sorsoló ablak megnyitása
            SorsolasWindow sorsolasWindow = new SorsolasWindow();
            sorsolasWindow.ShowDialog();

            // Eredmény megjelenítése a kezdő képernyőn
            txtLottoNumbers.Text = sorsolasWindow.SorsoltSzamok;
        }
    }
}
