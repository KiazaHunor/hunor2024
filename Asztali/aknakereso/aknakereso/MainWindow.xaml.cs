using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Minesweeper
{
    public partial class MainWindow : Window
    {
        private const int Size = 10; // 10x10 mező
        private const int MineCount = 15; // 15 akna
        private Button[,] buttons = new Button[Size, Size];
        private int[,] board = new int[Size, Size]; // -1 = akna, 0-8 = szám

        public MainWindow()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            GameGrid.Children.Clear();
            PlaceMines();
            CalculateNumbers();

            for (int row = 0; row < Size; row++)
            {
                for (int col = 0; col < Size; col++)
                {
                    Button btn = new Button
                    {
                        Tag = new Point(row, col),
                        FontWeight = FontWeights.Bold
                    };
                    btn.Click += Button_Click;
                    btn.MouseRightButtonDown += Button_RightClick;
                    buttons[row, col] = btn;
                    GameGrid.Children.Add(btn);
                }
            }
        }

        private void PlaceMines()
        {
            Random rnd = new Random();
            Array.Clear(board, 0, board.Length);
            int placedMines = 0;

            while (placedMines < MineCount)
            {
                int row = rnd.Next(Size);
                int col = rnd.Next(Size);

                if (board[row, col] == -1) continue;

                board[row, col] = -1;
                placedMines++;
            }
        }

        private void CalculateNumbers()
        {
            for (int row = 0; row < Size; row++)
            {
                for (int col = 0; col < Size; col++)
                {
                    if (board[row, col] == -1) continue;

                    int count = 0;
                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            int nr = row + i, nc = col + j;
                            if (nr >= 0 && nr < Size && nc >= 0 && nc < Size && board[nr, nc] == -1)
                                count++;
                        }
                    }
                    board[row, col] = count;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            Point pos = (Point)btn.Tag;
            int row = (int)pos.X, col = (int)pos.Y;

            if (board[row, col] == -1)
            {
                btn.Content = "💣";
                btn.Background = Brushes.Red;
                MessageBox.Show("Vesztettél!");
                InitializeGame();
                return;
            }

            RevealCell(row, col);
        }

        private void RevealCell(int row, int col)
        {
            if (row < 0 || row >= Size || col < 0 || col >= Size || buttons[row, col].IsEnabled == false)
                return;

            buttons[row, col].IsEnabled = false;
            buttons[row, col].Content = board[row, col] > 0 ? board[row, col].ToString() : "";
            buttons[row, col].Background = Brushes.LightGray;

            if (board[row, col] == 0) // Ha üres, felfedjük a szomszédokat
            {
                for (int i = -1; i <= 1; i++)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        RevealCell(row + i, col + j);
                    }
                }
            }
        }

        private void Button_RightClick(object sender, MouseButtonEventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Content == null || btn.Content.ToString() == "")
            {
                btn.Content = "🚩";
            }
            else if (btn.Content.ToString() == "🚩")
            {
                btn.Content = "";
            }
        }

        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            InitializeGame();
        }
    }
}
