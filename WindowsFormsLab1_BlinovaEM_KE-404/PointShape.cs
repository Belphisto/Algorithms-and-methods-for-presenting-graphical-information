using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsLab1_BlinovaEM_KE_404
{
    public class PointShape : Shape
    {
        private Point _point;
        public Color PaintColor { get; set; }
        //private Bitmap _bitmap;

        public PointShape(int x, int y)
        {
            _point = new Point(x, y);
            PaintColor = Color.Red;
            //_bitmap = new Bitmap(10, 10);
            
        }

        public override void Draw(Graphics graphics)
        {
            using (Brush brush = new SolidBrush(PaintColor))
            {
                graphics.FillRectangle(brush, _point.X, _point.Y, 1, 1);
                
            }
        }
    }
}
