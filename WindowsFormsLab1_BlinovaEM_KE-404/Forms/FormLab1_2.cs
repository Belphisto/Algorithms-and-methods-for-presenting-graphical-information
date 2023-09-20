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
    public partial class FormLab1_2 : Form
    {
        List<string> _figures = new List<string>();

        public FormLab1_2()
        {
            this.CenterToScreen();
            InitializeComponent();
            FillFigures();
        }

        private void FillFigures()
        {
            _figures.Add("Круг");
            _figures.Add("Квадрат");
            _figures.Add("Прямоугольник");

            comboBoxListFigures.DataSource = _figures;
        }

        private void ButtonAddTypeLine_Click(object sender, EventArgs e)
        {
            if (textBoxInputLine.Text != "")
            {

                listBoxTypes.Items.Add(textBoxInputLine.Text);
                textBoxInputLine.Text = "";
            }
        }

        private void ButtonShowChose_Click(object sender, EventArgs e)
        {
            if (listBoxTypes.SelectedIndex != -1 && comboBoxListFigures.SelectedIndex!= -1)
            {
                textBoxOutput.Text = $"Тип линии: {listBoxTypes.SelectedItem} \r\n Вид геометрической фигуры: {comboBoxListFigures.SelectedItem}";
            }
            else
            {
                MessageBox.Show("Выберите тип линии и вид геометрической фигуры из предложенных вариантов", "Действие не удалось", MessageBoxButtons.OK);
            }
        }

        private void ListBoxTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxOutput.Text = "";
        }

        private void ComboBoxListFigures_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxOutput.Text = "";
        }
    }
}
