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
        private RectangleShape figure;
        public FormLab1_3()
        {
            InitializeComponent();
            this.CenterToScreen();
            figure = new RectangleShape();

            panelFigure.Paint += PanelFigure_Paint;
        }

        private void PanelFigure_Paint(object sender, PaintEventArgs e)
        {
            // Вызовите метод Draw вашей фигуры с объектом Graphics из события Paint
            figure.Draw(e.Graphics);
        }

        private void PanelFigure_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStripRightClick.Show(PointToScreen(e.Location));
            }
        }

        private void NeprerivToolStripMenuItem_Click(object sender, EventArgs e)
        {
            figure.TypeOfLine = TypeOfLine.Neprerivnaya;
            panelFigure.Refresh();
        }

        private void PunctirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            figure.TypeOfLine = TypeOfLine.Punctirnaya;
            panelFigure.Refresh();
        }

        private void ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            figure.ThicknessOfLine = ThicknessOfLine.Five;
            panelFigure.Refresh();
        }

        private void ToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            figure.ThicknessOfLine = ThicknessOfLine.Ten;
            panelFigure.Refresh();
        }

        private void ToolStripMenuItem15_Click(object sender, EventArgs e)
        {
            figure.ThicknessOfLine = ThicknessOfLine.Fiftin;
            panelFigure.Refresh();
        }

        private void ColorLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                figure.ColorPen = colorDialog.Color;
                panelFigure.Refresh();
            }
        }

        private void ColorBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                figure.ColorBrush = colorDialog.Color;
                panelFigure.Refresh();
            }
        }

        private void PanelFigure_MouseDown(object sender, MouseEventArgs e)
        {
            figure.IsMove = true;
            figure.Previos = e.Location;
        }

        private void PanelFigure_MouseMove(object sender, MouseEventArgs e)
        {
            if (figure.IsMove)
            {
                figure._start.X -= (figure.Previos.X - e.Location.X);
                figure._start.Y -= (figure.Previos.Y - e.Location.Y);
                figure.Previos = e.Location;
                panelFigure.Refresh();
            }
        }

        private void PanelFigure_MouseUp(object sender, MouseEventArgs e)
        {
            figure.IsMove = false;
        }


    }

    

}
