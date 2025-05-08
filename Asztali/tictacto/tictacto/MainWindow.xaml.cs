using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace TicTacToe
{
    public partial class MainWindow : Window
    {
        private bool isPlayerX = true; // Kezdetben 'X' kezd
        private Button[] buttons;

        public MainWindow()
        {
            InitializeComponent();
            buttons = new Button[] { Btn0, Btn1, Btn2, Btn3, Btn4, Btn5, Btn6, Btn7, Btn8 };
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;
            if (clickedButton.Content != null) return;

            clickedButton.Content = isPlayerX ? "X" : "O";
            isPlayerX = !isPlayerX;

            CheckWinner();
        }

        private void CheckWinner()
        {
            int[,] winningCombinations = new int[,]
            {
                { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, // Sorok
                { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, // Oszlopok
                { 0, 4, 8 }, { 2, 4, 6 }  // Átlók
            };

            foreach (var combination in Enumerable.Range(0, 8))
            {
                int a = winningCombinations[combination, 0];
                int b = winningCombinations[combination, 1];
                int c = winningCombinations[combination, 2];

                if (buttons[a].Content != null &&
                    buttons[a].Content == buttons[b].Content &&
                    buttons[a].Content == buttons[c].Content)
                {
                    MessageBox.Show($"Játék vége! {buttons[a].Content} nyert!", "Győzelem", MessageBoxButton.OK);
                    ResetGame();
                    return;
                }
            }

            // Döntetlen ellenőrzése
            if (buttons.All(b => b.Content != null))
            {
                MessageBox.Show("Döntetlen!", "Játék vége", MessageBoxButton.OK);
                ResetGame();
            }
        }

        private void ResetGame()
        {
            foreach (var button in buttons)
            {
                button.Content = null;
            }
            isPlayerX = true;
        }
    }
}
