using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Tree_rendering
{
    public class Branch
    {
        private int _x;
        private int _y;
        private Crown _crown;
        private float _angle;
        private int _length;

        public Branch(int x, int y, Crown crown, float a, int l)
        {
            _x = x;
            _y = y;
            _crown = crown;
            _angle = a;
            _length = l;
        }

        public void ResizeBrunch()
        {
            _length *= 2;
        }

        public void DrowBranch(Graphics g, Color color)
        {
            // Вычисляем координаты конца ветки
            float width = 5; // Ширина прямоугольника
            float endX, endY;

            if (_angle == 0)
            {
                endX = _x + width;
                endY = _y - _length;
            }
            else
            {
                endX = _x + _length * (float)Math.Cos(_angle * Math.PI / 180);
                endY = _y - _length * (float)Math.Sin(_angle * Math.PI / 180);
            }

            PointF[] rectanglePoints = new PointF[]
                {
                new PointF(_x, _y),
                new PointF(endX, endY),
                new PointF(endX + width, endY),
                new PointF(_x + width, _y)
                };

            // Проверяем, выходят ли точки за границы кроны
            foreach (var point in rectanglePoints)
            {
                if (!_crown.IsPointInsideCrown(point))
                {
                    _crown.ResizeCrone(1.2); // Увеличиваем размер кроны
                    //_crown.DrawCrone(g); // Перерисовываем крону
                    break; // Прерываем цикл, чтобы не увеличивать крону многократно
                }
            }
            g.FillPolygon(new SolidBrush(color), rectanglePoints);
        }
    }
}
