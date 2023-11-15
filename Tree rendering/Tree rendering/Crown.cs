using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Tree_rendering
{
    public class Crown
    {
        public int crownCenterX;
        public int crownCenterY;
        public int crownRadius;

        public static event Action<bool> IsOutOfHeight;

        public Crown(int x, int y, int r)
        {
            crownCenterX = x;
            crownCenterY = y;
            crownRadius = r;
        }

        public void DrawCrone(Graphics g)
        {
            g.FillEllipse(Brushes.Green, crownCenterX - crownRadius, crownCenterY - crownRadius, 2 * crownRadius, 2 * crownRadius);
        }

        public List<Point> GetRandomPoints(int count)
        {
            var output = new List<Point>();
            Random random = new Random();

            for(int i = 0; i<count; i++)
            {
                // Генерируем случайные углы в верхней половине кроны (0..180 градусов)
                double angle1 = random.NextDouble() * Math.PI;

                // Генерируем случайное расстояние от центра кроны в пределах радиуса
                double distance = random.NextDouble() * crownRadius;

                // Преобразуем угол и расстояние в координаты
                //int x1 = (int)(crownCenterX + distance * Math.Sin(angle1));
                //int y1 = (int)(crownCenterY + distance * Math.Cos(angle1));
                int x1 = (int)(crownCenterX );
                int y1 = (int)(crownCenterY );

                output.Add(new Point(x1, y1));
            }
            return output;
        }

        public void ResizeCrone(double k, int height)
        {
            int newY = Convert.ToInt32(crownCenterY - crownCenterY / 10 * k);
            int newRadius = Convert.ToInt32(crownRadius + crownRadius / 10 * k);
            // Проверяем, не выходит ли новая крона за границы PictureBox
            if (newY + newRadius <= height)
            {
                // Если не выходит, применяем изменения
                crownCenterY = newY;
                crownRadius = newRadius;
            }
            else
            {
                IsOutOfHeight?.Invoke(false);
            }
            //MessageBox.Show(crownRadius.ToString());
        }

        public bool IsPointInsideCrown(PointF point)
        {
            // Проверяем, находится ли точка внутри кроны
            double distance = Math.Sqrt(Math.Pow(point.X - crownCenterX, 2) + Math.Pow(point.Y - crownCenterY, 2));
            return distance <= crownRadius;
        }
    }
}
