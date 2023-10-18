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
        private List<PointF> _mainPoints;
        public List<PointF> CurrentPoints { get; set; }
        private Color _color;

        public MyFigure()
        {
            _mainPoints = new List<PointF> { new Point(0, 60), new Point(40, 0), new Point (140,0), new Point(100, 60) };
            CurrentPoints = new List<PointF>(_mainPoints);
            _color = Color.Black;
        }

        public MyFigure(Color color, List<PointF> points)
        {
            _mainPoints =points;
            CurrentPoints = new List<PointF>(_mainPoints);
            _color = color;
        }

        public void DrawFigure(Graphics graphics)
        {
            //_mainPoints = CurrentPoints;
            //ClearFigure();
            Pen pen = new(_color);
            pen.Width = 2.0f;

            // Соединение точек
            for (int i = 0; i < CurrentPoints.Count; i++)
            {
                graphics.DrawLine(pen, CurrentPoints[i], CurrentPoints[(i + 1) % CurrentPoints.Count]);
            }
        }

        public void ClearFigure()
        {
            CurrentPoints.Clear();
        }

        public static bool IsFigureOutOfPanel(List<PointF> points, int[] size)
        {
            foreach (var point in points)
            {
                if (point.X < 0 || point.X > size[0] || point.Y < 0 || point.Y > size[1])
                {
                    return true;
                }
            }
            return false;
        }



    }

    
}
