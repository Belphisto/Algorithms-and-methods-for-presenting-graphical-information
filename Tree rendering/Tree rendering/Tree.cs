using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace Tree_rendering
{
    public class Tree
    {
        private Point[] trunkPoints;
        private List<Branch> branches;
        private Crown crown;
        int center_x;
        int center_y;

        public Tree(PictureBox pictureBox)
        {

            center_x = pictureBox.Size.Width/2;
            center_y = pictureBox.Size.Height/2;

            trunkPoints = new Point[]
            {
                new Point(center_x-30, pictureBox.Size.Height),
                new Point(center_x+30, pictureBox.Size.Height),
                new Point(center_x+10, center_y*4/3),
                new Point(center_x-10, center_y*4/3)
            };

            crown = new Crown((trunkPoints[0].X + trunkPoints[1].X) / 2,
            trunkPoints[0].Y - center_y * 4 / 6, 75);

            branches = new List<Branch> ();
            branches.Add(new Branch (center_x - 10,center_y * 4 / 3, crown, -205, 40));
            branches.Add(new Branch(center_x - 10, center_y * 4 / 3, crown, 0, 40));
            branches.Add(new Branch(center_x - 10, center_y * 4 / 3, crown, 25, 40));
            
        }

        public void UpTree()
        {
            foreach (var i in branches)
                i.ResizeBrunch();
        }

        public void CreateBrunch(int count)
        {
            Random random = new Random();
            //var points = crown.GetRandomPoints(count);

           //foreach (var i in points)
           for (int i=0;i<count; i++)
            {
                int angle1 = random.Next(0,180);
                Branch branch = new Branch
                (
                    center_x - 10,
                    center_y * 4 / 3,
                    crown,
                    angle1,
                    30
                );
                branches.Add(branch);
            }
        }

        public void DrawTrunk(PictureBox pictureBox, Color color)
        {
            using (Graphics g = pictureBox.CreateGraphics())
            {
                crown.DrawCrone(g);
                
                foreach(var b in branches)
                {
                    b.DrowBranch(g, color, pictureBox.Size.Height);
                }
                //MessageBox.Show(trunkPoints[1].ToString());
                g.FillPolygon(Brushes.Brown, trunkPoints);
            }
            
        }
    }
}
