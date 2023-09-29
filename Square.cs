using System.Drawing;

namespace Chess
{
    internal class Square
    {
        private string _name;
        private System.Windows.Media.Color _color;
        private System.Windows.Shapes.Rectangle _square;
        private string _piece;

        public string Name => _name;
        public System.Windows.Media.Color Color => _color;
        public System.Windows.Shapes.Rectangle Rectangle => _square;
        public string Piece => _piece;

        public Square(string _name, System.Windows.Media.Color _color, System.Windows.Shapes.Rectangle _square, string _piece)
        {
            this._name = _name;
            this._color = _color;
            this._square = _square;
            this._piece = _piece;
        }
    }
}
