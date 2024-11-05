using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace LottoSorsolas
{
    public partial class SorsolasWindow : Window
    {
        public string SorsoltSzamok { get; private set; }

        public SorsolasWindow()
        {
            InitializeComponent();
        }

        private void BtnSorsolas_Click(object sender, RoutedEventArgs e)
        {
            // A ComboBox-ból kiolvasott típus alapján hívjuk meg a megfelelő sorsolást
            string selectedLottoType = ((ComboBoxItem)cmbLottoTypes.SelectedItem).Content.ToString();
            SorsoltSzamok = Sorsol(selectedLottoType);

            // Bezárás az eredmény visszaadásával
            this.DialogResult = true;
            this.Close();
        }

        private string Sorsol(string lottoType)
        {
            Random rand = new Random();
            string result = "";

            switch (lottoType)
            {
                case "5-ös lottó":
                    result = string.Join(", ", Enumerable.Range(1, 5).Select(i => rand.Next(1, 91)).OrderBy(x => x).Distinct().Take(5));
                    break;
                case "6-os lottó":
                    result = string.Join(", ", Enumerable.Range(1, 6).Select(i => rand.Next(1, 50)).OrderBy(x => x).Distinct().Take(6));
                    break;
                case "Skandináv lottó":
                    result = string.Join(", ", Enumerable.Range(1, 7).Select(i => rand.Next(1, 36)).OrderBy(x => x).Distinct().Take(7));
                    break;
                default:
                    result = "Ismeretlen típus!";
                    break;
            }

            return result;
        }
    }
}
