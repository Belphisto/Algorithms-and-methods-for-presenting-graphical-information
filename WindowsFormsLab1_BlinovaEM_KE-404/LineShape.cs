using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsLab1_BlinovaEM_KE_404
{
    public class LineShape : Shape
    {
        private Point _point1;
        private Point _point2;
        public Color LineColor { get; set; }
        public int LineThickness { get; set; }

        public LineShape(int x1, int y1, int x2, int y2)
        {
            _point1 = new Point(x1, y1);
            _point2 = new Point(x2, y2);
            LineColor = Color.DarkBlue;
            LineThickness = 5;
        }

        public override void Draw(Graphics graphics)
        {
            using (Pen pen = new Pen(LineColor, LineThickness))
            {
                graphics.DrawLine(pen, _point1, _point2);
            }
        }
    }
}
