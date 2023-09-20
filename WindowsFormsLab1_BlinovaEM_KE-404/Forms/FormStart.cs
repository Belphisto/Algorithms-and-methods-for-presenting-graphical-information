using System;
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
    public partial class BlinovaEM_Lab1_1 : Form
    {
        private string _author = "";
        public BlinovaEM_Lab1_1()
        {
            InitializeComponent();
            if (_author == "")
            {
                authorToolStripMenuItem.Enabled = false;
            }
        }


        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelAboutAuthor.Visible = true;
        }

        private void AuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Имя автора: {_author}", "Сведения об авторе", MessageBoxButtons.OK);
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Лабораторная работа №1 \n Версия 1.0.0", "О программе", MessageBoxButtons.OK);
        }

        private void ButtonSaveName_Click(object sender, EventArgs e)
        {
            if (textBoxAuthor.Text != "")
            {
                _author = textBoxAuthor.Text;
                authorToolStripMenuItem.Enabled = true;
            }
            panelAboutAuthor.Visible = false;
        }

        private void Lab2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var lab1_2 = new FormLab1_2();
            lab1_2.ShowDialog(this);
        }

        private void Lab3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var lab1_3 = new FormLab1_3();
            lab1_3.ShowDialog(this);
        }

        private void Lab44ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var lab1_4 = new FormLab1_4();
            lab1_4.ShowDialog(this);
        }
    }
}
