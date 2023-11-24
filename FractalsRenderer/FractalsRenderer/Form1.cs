using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractalsRenderer
{
    public partial class Form1 : Form
    {
        private int _angle = 45;
        private int _lenght = 2;
        private int _depth = 10;
        private Color _color = Color.Black;

        public Form1()
        {
            InitializeComponent();
        }

        private void CreateStripButton_Click(object sender, EventArgs e)
        {
            //Fractals.DrawCochCurve(panel1, depth, new Point(10, 200), new Point(590, 200));
            UserInputForm childForm = new UserInputForm(_angle, _lenght, _depth, _color);

            childForm.UpdateColor += (newColor) => _color = newColor;
            childForm.UpdateAngle += (newAngle) => _angle = newAngle;
            childForm.UpdateDepth += (newDepth) => _depth = newDepth;
            childForm.UpdateLenght += (newLenght) => _lenght = newLenght;
            childForm.ShowDialog(this);

            Fractals.DrawLeviCurve(panel1, _depth, _angle, _lenght, _color);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ClearStripButton_Click(object sender, EventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            g.Clear(panel1.BackColor);
        }
    }
}
