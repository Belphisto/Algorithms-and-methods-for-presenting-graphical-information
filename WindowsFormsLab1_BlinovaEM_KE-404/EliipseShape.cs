using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsLab1_BlinovaEM_KE_404
{
    public class EllipseShape : Shape
    {
        private Rectangle _rect;

        private Color _borderColor;
        private int _borderThickness;

        public EllipseShape(int x,int y, int w, int h)
        {
            _rect = new Rectangle(x, y, w, h);
            _borderColor = Color.DarkBlue;
            _borderThickness = 5;
        }

        public override void Draw(Graphics graphics)
        {
            using (Pen borderPen = new Pen(_borderColor, _borderThickness))
            {
                graphics.DrawEllipse(borderPen, _rect);
            }
        }
    }
}
