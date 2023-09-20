using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsLab1_BlinovaEM_KE_404
{
    public enum TypeOfLine
    {
        Neprerivnaya = 1,
        Punctirnaya = 2
    }

    public enum ThicknessOfLine
    {
        Five = 5,
        Ten = 10,
        Fiftin = 15
    }

    public abstract class Shape
    {
        public abstract void Draw(Graphics graphics);
    }
}
