using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLab1_BlinovaEM_KE_404
{
    public partial class FormLab1_3 : Form
    {
        RectangleShape figure;
        public FormLab1_3()
        {
            InitializeComponent();
            this.CenterToScreen();
            figure = new RectangleShape();

            panelFigure.Paint += panelFigure_Paint;
        }

        private void panelFigure_Paint(object sender, PaintEventArgs e)
        {
            // Вызовите метод Draw вашей фигуры с объектом Graphics из события Paint
            figure.Draw(e.Graphics);
        }

        private void panelFigure_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStripRightClick.Show(PointToScreen(e.Location));
            }
        }

        private void neprerivToolStripMenuItem_Click(object sender, EventArgs e)
        {
            figure._typeOfLine = TypeOfLine.Neprerivnaya;
            panelFigure.Refresh();
        }

        private void punctirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            figure._typeOfLine = TypeOfLine.Punctirnaya;
            panelFigure.Refresh();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            figure._thicknessOfLine = ThicknessOfLine.Five;
            panelFigure.Refresh();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            figure._thicknessOfLine = ThicknessOfLine.Ten;
            panelFigure.Refresh();
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            figure._thicknessOfLine = ThicknessOfLine.Fiftin;
            panelFigure.Refresh();
        }

        private void colorLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                figure._colorPen = colorDialog.Color;
                panelFigure.Refresh();
            }
        }

        private void colorBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                figure._colorBrush = colorDialog.Color;
                panelFigure.Refresh();
            }
        }

        private void panelFigure_MouseDown(object sender, MouseEventArgs e)
        {
            figure._isMove = true;
            figure._previos = e.Location;
        }

        private void panelFigure_MouseMove(object sender, MouseEventArgs e)
        {
            if (figure._isMove)
            {
                figure._start.X -= (figure._previos.X - e.Location.X);
                figure._start.Y -= (figure._previos.Y - e.Location.Y);
                figure._previos = e.Location;
                panelFigure.Refresh();
            }
        }

        private void panelFigure_MouseUp(object sender, MouseEventArgs e)
        {
            figure._isMove = false;
        }
    }

    

}
