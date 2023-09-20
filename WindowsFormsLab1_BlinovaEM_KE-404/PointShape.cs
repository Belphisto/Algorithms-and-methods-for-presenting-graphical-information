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
        private Rectangle _rect;
        public Color PaintColor { get; set; }

        public PointShape(int x, int y, int w, int h)
        {
            _rect = new Rectangle(x, y, w, h);
            PaintColor = Color.DarkBlue;
        }

        public override void Draw(Graphics graphics)
        {
            using (Brush brush = new SolidBrush(PaintColor))
            {
                graphics.FillEllipse(brush, _rect); 
            }
        }
    }
}
