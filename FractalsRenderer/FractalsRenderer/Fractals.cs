using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace FractalsRenderer
{
    public static class Fractals
    {
        public static void DrawLeviCurve(Panel panel, int iterations, int angle, int lenght, Color color)
        {
            using (Graphics g = panel.CreateGraphics())
            {
                turtle(color, panel, hide: true, g: g, axiom: "F", tempAx: "", logic: new System.Collections.Generic.Dictionary<char, string> { { 'F', "-F++F-" } }, iterations, angle, lenght);
            }
        }

        private static void turtle(Color color, Panel panel, bool hide, Graphics g, string axiom, string tempAx, System.Collections.Generic.Dictionary<char, string> logic, int iterations, float angle, int length)
        {
            if (hide)
            {
                //g.Clear(panel.BackColor);
                g.TranslateTransform(panel.Width *1/4, panel.Height *3/4);
            }
            else
            {
                g.TranslateTransform(panel.Width * 1 / 4, panel.Height *3/ 4);
            }

            for (int i = 0; i < iterations; i++)
            {
                for (int j = 0; j < axiom.Length; j++)
                {
                    tempAx += logic.ContainsKey(axiom[j]) ? logic[axiom[j]] : axiom[j].ToString();
                }
                axiom = tempAx;
                tempAx = "";
            }

            for (int k = 0; k < axiom.Length; k++)
            {
                if (axiom[k] == '+')
                {
                    g.RotateTransform(angle);
                }
                else if (axiom[k] == '-')
                {
                    g.RotateTransform(-angle);
                }
                else
                {
                    using (Pen customPen = new Pen(color))
                    {
                        // Рисуем линию с собственным цветом
                        g.DrawLine(customPen, 0, 0, length, 0);
                    }
                    g.TranslateTransform(length, 0);
                }
            }
        }

    }
}
