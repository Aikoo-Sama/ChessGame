using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Chess
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static readonly int ROW_COUNT = 8;
        private static readonly int COL_COUNT = 8;

        private Square[,] squares = new Square[COL_COUNT, ROW_COUNT];

        public MainWindow()
        {
            InitializeComponent();
            CreateBoard();
        }

        private void CreateBoard()
        {
            for (int col = 0; col < COL_COUNT; col++)
            {
                for (int row = 0; row < ROW_COUNT; row++)
                {
                    System.Windows.Media.Color c = ((row % 2 == 0 && col % 2 == 0) || (row % 2 != 0 && col % 2 != 0)) ? Colors.White : Colors.Black;
                    System.Windows.Shapes.Rectangle rectangle = new System.Windows.Shapes.Rectangle();
                    rectangle.Width = 600 / 8;
                    rectangle.Height = 600 / 8;
                    rectangle.Fill = new SolidColorBrush(c);

                    // Add square to board
                    CanvasBoard.Children.Add(rectangle);
                    Canvas.SetTop(rectangle, (600/8) * row);
                    Canvas.SetLeft(rectangle, (600 / 8) * col);

                    Square square = new Square("q", c, rectangle, "r");

                    squares[col, row] = square;
                }
            }
        }
    }
}
