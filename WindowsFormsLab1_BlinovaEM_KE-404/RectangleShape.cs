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
        public bool IsMove { get; set; }
        public Point _start;
        public Point Previos { get; set; }
        public Color ColorBrush { get; set; }
        public Color ColorPen { get; set; }
        public Size Size { get; set; }
        public TypeOfLine TypeOfLine { get; set; }
        public ThicknessOfLine ThicknessOfLine { get; set; }

        public RectangleShape()
        {
            TypeOfLine = TypeOfLine.Neprerivnaya;
            ThicknessOfLine = ThicknessOfLine.Five;
            _start = new Point(0, 0);
            Size = new Size(100, 100);
            IsMove = false;
            Previos = _start;
            ColorBrush = Color.Red;
            ColorPen = Color.DarkBlue;
        }

        public RectangleShape(int x, int y, int height, int weight)
        {
            TypeOfLine = TypeOfLine.Neprerivnaya;
            ThicknessOfLine = ThicknessOfLine.Five;
            _start = new Point(x, y);
            Size = new Size(weight, height);
            IsMove = false;
            Previos = _start;
            ColorBrush = Color.FromArgb(0, 255, 255, 255); // Альфа-канал (прозрачность) равен 0
            ColorPen = Color.DarkBlue;
        }

        public override void Draw(Graphics graphics)
        {
            using (Brush brush = new SolidBrush(ColorBrush))
            using (Pen pen = new Pen(ColorPen, (int)ThicknessOfLine))
            {
                graphics.FillRectangle(brush, _start.X, _start.Y, Size.Width, Size.Height);
                if (TypeOfLine != TypeOfLine.Neprerivnaya)
                {
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot; // пунктирный стиль если линия не непрерывная
                }
                graphics.DrawRectangle(pen, _start.X, _start.Y, Size.Width, Size.Height);
            }
        }
    }
}

