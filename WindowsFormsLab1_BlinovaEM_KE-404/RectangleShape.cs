using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsLab1_BlinovaEM_KE_404
{
    public class RectangleShape : Shape
    {
        public bool _isMove { get; set; }
        public Point _start;
        public Point _previos { get; set; }
        public Color _colorBrush { get; set; }
        public Color _colorPen { get; set; }
        public Size _size { get; set; }
        public TypeOfLine _typeOfLine { get; set; }
        public ThicknessOfLine _thicknessOfLine { get; set; }

        public RectangleShape()
        {
            _typeOfLine = TypeOfLine.Neprerivnaya;
            _thicknessOfLine = ThicknessOfLine.Five;
            _start = new Point(0, 0);
            _size = new Size(100, 100);
            _isMove = false;
            _previos = _start;
            _colorBrush = Color.Red;
            _colorPen = Color.DarkBlue;
        }

        public override void Draw(Graphics graphics)
        {
            using (Brush brush = new SolidBrush(_colorBrush))
            using (Pen pen = new Pen(_colorPen, (int)_thicknessOfLine))
            {
                if (_typeOfLine == TypeOfLine.Neprerivnaya)
                {
                    graphics.FillRectangle(brush, _start.X, _start.Y, _size.Width, _size.Height);
                    graphics.DrawRectangle(pen, _start.X, _start.Y, _size.Width, _size.Height);
                }
                else if (_typeOfLine == TypeOfLine.Punctirnaya)
                {
                    graphics.FillRectangle(brush, _start.X, _start.Y, _size.Width, _size.Height);
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot; // пунктирный стиль
                    graphics.DrawRectangle(pen, _start.X, _start.Y, _size.Width, _size.Height);
                }
            }
        }
    }
}

