using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coloring_closed_surfaces
{
    public partial class Form1 : Form
    {
        public MyFigure rectangle;
        private Bitmap bitmap;
        private Color fillColor;

        private Point startPoint;

        public Form1()
        {
            InitializeComponent();

            var points = new List<PointF> { new Point(200, 220), new Point(280, 100), new Point(480, 100), new Point(400, 220) };
            //var points = new List<PointF> { new Point(10, 10), new Point(150, 10), new Point(150, 35), new Point(180, 35), new Point(180, 25), new Point(210, 50), new Point(180, 75), new Point(180, 65), new Point(150, 65), new Point(150, 100), new Point(10, 100) };
            rectangle = new MyFigure(Color.Black, points);

            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            fillColor = Color.Red;

            toolStripButtonLineScan.Enabled = false;
            toolStripButtonSeedFilling.Enabled = false;
        }

        private void FillPictureBox()
        {
            using Graphics graphics = Graphics.FromImage(bitmap);
            graphics.Clear(pictureBox1.BackColor);
            rectangle.DrawFigure(graphics);
            pictureBox1.Image = bitmap;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (bitmap != null)
            {
                e.Graphics.DrawImage(bitmap, Point.Empty);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Point clickPoint = new Point(e.X, e.Y); // Получение координат клика мыши

            if (!rectangle.Contains(clickPoint))
            {
                MessageBox.Show("Выбрана точка вне фигуры");
                return;
            }
            else
            {
                startPoint = clickPoint;
            }
        }

        private void toolStripButtonDrow_Click(object sender, EventArgs e)
        {
            FillPictureBox();
            toolStripButtonLineScan.Enabled = true;
            toolStripButtonSeedFilling.Enabled = true;
        }

        private void toolStripButtonLineScan_Click(object sender, EventArgs e)
        {
            // Запросить у пользователя цвет для заполнения фигуры
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                fillColor = colorDialog1.Color; // Установить выбранный цвет

                // Создать Graphics объект для рисования
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    // Заполнить фигуру
                    PaintingColor.FillFigureScanline(fillColor, rectangle, bitmap, pictureBox1);
                }

                // Отобразить заполненную фигуру в PictureBox
                pictureBox1.Image = bitmap;
            }
        }

        private void toolStripButtonSeedFilling_Click(object sender, EventArgs e)
        {
            if (startPoint != null)
            {  
                // Запросить у пользователя цвет для заполнения фигуры
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    fillColor = colorDialog1.Color; // Установить выбранный цвет

                    // Создать Graphics объект для рисования
                    using (Graphics graphics = Graphics.FromImage(bitmap))
                    {
                        PaintingColor.SeedFilling(fillColor, rectangle, bitmap, pictureBox1, startPoint);
                    }

                    // Отобразить заполненную фигуру в PictureBox
                    pictureBox1.Image = bitmap;
                }
            }
            else
            {
                MessageBox.Show("Выберите точку внутри фигуры");
            }
        }
    }
}
