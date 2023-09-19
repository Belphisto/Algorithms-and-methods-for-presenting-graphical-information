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


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelAboutAuthor.Visible = true;
        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Имя автора: {_author}", "Сведения об авторе", MessageBoxButtons.OK);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Лабораторная работа №1 \n Версия 1.0.0", "О программе", MessageBoxButtons.OK);
        }

        private void buttonSaveName_Click(object sender, EventArgs e)
        {
            if (textBoxAuthor.Text != "")
            {
                _author = textBoxAuthor.Text;
                authorToolStripMenuItem.Enabled = true;
            }
            panelAboutAuthor.Visible = false;
        }

        private void buttonLab1_2_Click(object sender, EventArgs e)
        {
            var lab1_2 = new FormLab1_2();
            lab1_2.ShowDialog(this);
        }

        private void buttonLab1_3_Click(object sender, EventArgs e)
        {
            var lab1_3 = new FormLab1_3();
            lab1_3.ShowDialog(this);
        }
    }
}
