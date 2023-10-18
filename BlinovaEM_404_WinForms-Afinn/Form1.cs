using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlinovaEM_404_WinForms_Afinn
{
    public partial class Form1 : Form
    {
        public MyFigure rectangle;
        public int[] panel_size;

        public Form1()
        {
            InitializeComponent();
            rectangle = new MyFigure();
            panel_size = new int[] {panel.Width, panel.Height };
        }

        private void ButtonCreateFigure_Click(object sender, EventArgs e)
        {
            using (Graphics graphics = panel.CreateGraphics())
            {
                rectangle.DrawFigure(graphics);
            }
        }

        private void ButtonMove_Click(object sender, EventArgs e)
        {
            if (CheckValidUserInput(textBoxMoveX.Text, out int moveX) && CheckValidUserInput(textBoxMoveY.Text, out int moveY))
            {
                List<PointF> tempPoints = rectangle.CurrentPoints;

                for (int i = 0; i < tempPoints.Count; i++)
                {
                    tempPoints[i] = new PointF(tempPoints[i].X + moveX, tempPoints[i].Y + moveY);
                }

                if (!MyFigure.IsFigureOutOfPanel(tempPoints, panel_size))
                {
                    rectangle.CurrentPoints = tempPoints;
                    ClearPanel();
                    using (Graphics graphics = panel.CreateGraphics())
                    {
                        rectangle.DrawFigure(graphics);
                    }
                }
                else
                {
                    MessageBox.Show("Фигура выходит за пределы поля");
                }
            }
            else
            {
                MessageBox.Show("Введите целые числа для перемещения фигуры");
            }
        }

        private void ClearPanel()
        {
            using (Graphics graphics = panel.CreateGraphics())
            {
                graphics.Clear(panel.BackColor);
            }
        }

        private void ButtonRotate_Click(object sender, EventArgs e)
        {

        }

        private void buttonReSize_Click(object sender, EventArgs e)
        {

        }

        private static bool CheckValidUserInput(string field, out int k)
        {
            if (field == "") { k = 0; return true; }
            if (int.TryParse(field, out k))
            {
                return true;
            }
            return false;
        }

        private static bool CheckValidUserInput(string field, out float k)
        {
            if (field == "") { k = 0; return true; }
            if (float.TryParse(field, out k))
            {
                return true;
            }
            return false;
        }

    }
}
