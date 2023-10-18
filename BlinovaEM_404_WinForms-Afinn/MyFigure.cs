using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BlinovaEM_404_WinForms_Afinn
{
    public class MyFigure
    {
        private List<Point> _mainPoints;
        private List<Point> _currentPoints;
        private Color _color;

        public MyFigure()
        {
            _mainPoints = new List<Point> { new Point(10, 10), new Point(20, 50), new Point (20,80), new Point(10, 80) };
            _currentPoints = new List<Point>();
            _color = Color.Aqua;
        }

        public MyFigure(Color color, List<Point> points)
        {
            _mainPoints =points;
            _currentPoints = new List<Point>();
            _color = color;
        }

        private void DrawFigure(Bitmap bitmap)
        {
           // ClearF();

            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                Pen pen = new Pen(_color);

                // Соединение точек
                for (int i = 0; i < _currentPoints.Count; i++)
                {
                    graphics.DrawLine(pen, _currentPoints[i], _currentPoints[(i + 1) % _currentPoints.Count]);
                }

            }
        }

        private void ClearFigure(Bitmap bitmap)
        {
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.Clear(Color.White);
            }
        }
    }

    
}
