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
        private PointF _center;
        public List<PointF> CurrentPoints { get; set; }
        private readonly Color _color;

        public MyFigure()
        {
            _mainPoints = new List<PointF> { new Point(0, 60), new Point(40, 0), new Point (140,0), new Point(100, 60) };
            CurrentPoints = new List<PointF>(_mainPoints);
            _color = Color.Black;
            _center = new PointF(0, 0);
        }

        public string ReternCenter()
        {
            return $"x = {_center.X}, y= {_center.Y}";
        }

        public MyFigure(Color color, List<PointF> points)
        {
            _mainPoints =points;
            CurrentPoints = new List<PointF>(_mainPoints);
            _color = color;
        }

        public void DrawFigure(Graphics graphics)
        {
            Pen pen = new(_color);
            pen.Width = 2.0f;

            // Соединение точек
            for (int i = 0; i < _mainPoints.Count; i++)
            {
                graphics.DrawLine(pen, _mainPoints[i], _mainPoints[(i + 1) % _mainPoints.Count]);
            }
        }

        public void Move(int moveX, int moveY)
        {
            for (int i = 0; i < CurrentPoints.Count; i++)
            {
                CurrentPoints[i] = new PointF(CurrentPoints[i].X + moveX, CurrentPoints[i].Y + moveY);
            }
        }

        public void Rotate(float angle)
        {
            float radians = (float)(angle * Math.PI / 180);
            PointF fixPoint = CurrentPoints[0];

            for (int i = 0; i < CurrentPoints.Count; i++)
            {
                float newX = (float)((CurrentPoints[i].X - fixPoint.X) * Math.Cos(radians) - (CurrentPoints[i].Y - fixPoint.Y) * Math.Sin(radians) + fixPoint.X);
                float newY = (float)((CurrentPoints[i].X - fixPoint.X) * Math.Sin(radians) + (CurrentPoints[i].Y - fixPoint.Y) * Math.Cos(radians) + fixPoint.Y);
                CurrentPoints[i] = new PointF(newX, newY);
            }
        }

        public void Resize(float resizeX, float resizeY)
        {
            float centerX = CurrentPoints[0].X;
            float centerY = CurrentPoints[0].Y;

            for (int i = 0; i < CurrentPoints.Count; i++)
            {
                // Сдвиг точек относительно центра
                float x = CurrentPoints[i].X - centerX;
                float y = CurrentPoints[i].Y - centerY;

                // Масштабирование
                x *= resizeX;
                y *= resizeY;

                // Возврат точек относительно центра
                CurrentPoints[i] = new PointF(x + centerX, y + centerY);
            }
        }

        public void SaveChanges()
        {
            _mainPoints = new List<PointF>(CurrentPoints);
        }
        public void DiscardChanges()
        {
            CurrentPoints = new List<PointF>(_mainPoints);
        }

        public bool IsFigureOutOfPanel(int[] size)
        {
            foreach (var point in CurrentPoints)
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
