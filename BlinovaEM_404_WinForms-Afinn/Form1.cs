using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlinovaEM_404_WinForms_Afinn
{
    public partial class Form1 : Form
    {
        public MyFigure rectangle;
        public Bitmap bitmap;
        public Form1()
        {
            InitializeComponent();
            rectangle = new MyFigure();
            bitmap = new Bitmap(panel.Width, panel.Height);
        }

        private void ButtonMove_Click(object sender, EventArgs e)
        {

        }

        private void ButtonRotate_Click(object sender, EventArgs e)
        {

        }
    }
}
