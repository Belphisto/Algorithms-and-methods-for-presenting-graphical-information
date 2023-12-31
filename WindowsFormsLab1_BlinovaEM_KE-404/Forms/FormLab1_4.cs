﻿using System;
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
    public partial class FormLab1_4 : Form
    {
        private List<Shape> shapesList = new List<Shape>();
        Bitmap bitmap;

        public FormLab1_4()
        {
            InitializeComponent();
            this.CenterToScreen();

            shapesPicture.Visible = true;
            shapesPicture.Paint += ShapesPanel_Paint;
            this.Controls.Add(shapesPicture);
            //bitmap = new Bitmap(shapesPicture.Width, shapesPicture.Height);
        }

        

        private void CtreatObkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreateObject form = new FormCreateObject();
            form.ShapeCreated += (createdShape) =>
            {
                shapesList.Add(createdShape);

                shapesPicture.Invalidate();

            };
            /*form.PointCreated += (point) =>
              {
                  bitmap.SetPixel(point.X, point.Y, Color.Red);
                  shapesPicture.Invalidate();
              };*/
            form.ShowDialog(this);

        }

        private void ShapesPanel_Paint(object sender, PaintEventArgs e)
        {
            
            foreach (var shape in shapesList)
            {
                shape.Draw(e.Graphics);
            }
            
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
