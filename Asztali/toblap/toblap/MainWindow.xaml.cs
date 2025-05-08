using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfJumpingButton
{
    public partial class MainWindow : Window
    {
        private Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
            PositionButtonRandomly();
        }

        private void JumpButton_MouseEnter(object sender, MouseEventArgs e)
        {
            PositionButtonRandomly();
        }

        private void PositionButtonRandomly()
        {
            if (JumpButton == null || MainCanvas == null) return;

            double maxX = MainCanvas.ActualWidth - JumpButton.Width;
            double maxY = MainCanvas.ActualHeight - JumpButton.Height;

            if (maxX > 0 && maxY > 0)
            {
                Canvas.SetLeft(JumpButton, random.NextDouble() * maxX);
                Canvas.SetTop(JumpButton, random.NextDouble() * maxY);
            }
        }
    }
}
