using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


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

            textBoxMoveX.Text = "0";
            textBoxMoveY.Text = "0";
            textBoxRotate.Text = "0";
            textBoxReSizeX.Text = "1";
            textBoxReSizeY.Text = "1";
        }

        private void FillPanel()
        {
            using Graphics graphics = panel.CreateGraphics();
            graphics.Clear(panel.BackColor);
            rectangle.SaveChanges();
            rectangle.DrawFigure(graphics);
        }

        private void ButtonCreateFigure_Click(object sender, EventArgs e)
        {
            FillPanel();
            ButtonCreateFigure.Enabled = false;
        }

        private void ButtonMove_Click(object sender, EventArgs e)
        {
            if (CheckValidUserInput(textBoxMoveX.Text, out int moveX) && CheckValidUserInput(textBoxMoveY.Text, out int moveY))
            {
                rectangle.Move(moveX, moveY);

                if (!rectangle.IsFigureOutOfPanel(panel_size))
                {
                    FillPanel();
                }
                else
                {
                    rectangle.DiscardChanges();
                    MessageBox.Show("Фигура выходит за пределы поля");
                }
            }
            else MessageBox.Show("Введите целые числа для перемещения фигуры");
            
        }

        private void ButtonRotate_Click(object sender, EventArgs e)
        {
            if (CheckValidUserInput(textBoxRotate.Text, out float angle))
            {
                rectangle.Rotate(angle);

                if (!rectangle.IsFigureOutOfPanel(panel_size))
                {
                    FillPanel();
                }
                else
                {
                    rectangle.DiscardChanges();
                    MessageBox.Show("Фигура выходит за пределы поля");
                }
            }
            else MessageBox.Show("Введите целое число для угла поворота");
        }

        private void ButtonReSize_Click(object sender, EventArgs e)
        {
            if (CheckValidUserInput(textBoxReSizeX.Text, out float resizeX) && CheckValidUserInput(textBoxReSizeY.Text, out float resizeY))
            {
                rectangle.Resize(resizeX, resizeY);
                if (!rectangle.IsFigureOutOfPanel(panel_size))
                {
                    FillPanel();
                }
                else
                {
                    rectangle.DiscardChanges();
                    MessageBox.Show("Фигура выходит за пределы поля");
                }
            }
            else MessageBox.Show("Введите дробное число через знак . для изменения размера");
        }

        private static bool CheckValidUserInput(string field, out int k)
        {
            if (field == "") { k = 0; return true; }
            if (int.TryParse(field, NumberStyles.Float, CultureInfo.InvariantCulture, out k))
            {
                return true;
            }
            return false;
        }

        private static bool CheckValidUserInput(string field, out float k)
        {
            if (field == "" || field == "0") { k = 1; return true; }
            if (float.TryParse(field, NumberStyles.Float, CultureInfo.InvariantCulture, out k))
            {
                return true;
            }
            return false;
        }
    }
}
