using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Coloring_closed_surfaces
{
    public static class PaintingColor
    {
        public static void FillFigureScanline(Color fillColor, MyFigure figure, Bitmap fillBitmap, PictureBox pictureBox)
        {
            List<PointF> _mainPoints = figure.GetPoints();

            // Найти минимальную и максимальную координату Y в фигуре
            float minY = _mainPoints.Min(point => point.Y);
            float maxY = _mainPoints.Max(point => point.Y);

            // Проход по каждой строке внутри обрамляющего прямоугольника
            for (float y = minY; y <= maxY; y++)
            {
                // 4. Создаем список, чтобы хранить X-координаты пересечений текущей строки со сторонами многоугольника
                List<float> intersections = new List<float>();

                // 5. Перебираем каждую сторону многоугольника.
                for (int i = 0; i < _mainPoints.Count; i++)
                {
                    int nextIndex = (i + 1) % _mainPoints.Count;

                    float x1 = _mainPoints[i].X;
                    float y1 = _mainPoints[i].Y;
                    float x2 = _mainPoints[nextIndex].X;
                    float y2 = _mainPoints[nextIndex].Y;

                    // Проверка, пересекает ли текущая линия сканирующую строку
                    if ((y1 <= y && y2 > y) || (y2 <= y && y1 > y))
                    {
                        // 7. Если пересечение есть, вычисляем X-координату пересечения (x) и добавляем ее в список.
                        float x = x1 + (y - y1) / (y2 - y1) * (x2 - x1);
                        intersections.Add(x);
                    }
                }

                intersections.Sort();

                // Закрашиваем от одного пересечения до следующего
                for (int i = 0; i < intersections.Count; i += 2)
                {
                    int startX = (int)intersections[i];
                    int endX = (int)intersections[i + 1];

                    // Закрасить линию между двумя пересечениями
                    for (int x = startX; x < endX; x++)
                    {
                        fillBitmap.SetPixel(x, (int)y, fillColor);
                    }
                    Thread.Sleep(1);
                    pictureBox.Refresh();

                }
            }
        }

        public static void SeedFilling(Color fillColor, MyFigure figure, Bitmap fillBitmap, PictureBox pictureBox, Point startPoint)
        {
            Stack<Point> stack = new Stack<Point>();
            Color targetColor = fillBitmap.GetPixel(startPoint.X, startPoint.Y);
            stack.Push(startPoint);

            int processedPixels = 0;
            int maxProcessedPixels = 100; // Ограничение на количество обработанных пикселей перед обновлением интерфейса

            while (stack.Count > 0)
            {
                Point current = stack.Pop();
                int x = current.X;
                int y = current.Y;

                if (x < 0 || x >= fillBitmap.Width || y < 0 || y >= fillBitmap.Height)
                    continue;

                if (fillBitmap.GetPixel(x, y) == targetColor)
                {
                    // Закрашиваем пиксель
                    fillBitmap.SetPixel(x, y, fillColor);

                    processedPixels++;

                    // Обновляем изображение каждые maxProcessedPixels пикселей
                    if (processedPixels >= maxProcessedPixels)
                    {
                        processedPixels = 0;
                        pictureBox.Refresh();
                        Thread.Sleep(1); // Пауза для обновления интерфейса
                    }

                    stack.Push(new Point(x - 1, y)); // Левый сосед
                    stack.Push(new Point(x, y - 1)); // Верхний сосед
                    stack.Push(new Point(x + 1, y)); // Правый сосед
                    stack.Push(new Point(x, y + 1)); // Нижний сосед
                }
            }

            pictureBox.Refresh();

        }
    }
}
