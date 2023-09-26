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
    public partial class FormCreateObject : Form
    {
        private List<string> _figures = new List<string>();
        public event Action<Shape> ShapeCreated;

        public FormCreateObject()
        {
            InitializeComponent();
            this.CenterToScreen();
            FillFigures();
        }

        private void FillFigures()
        {
            _figures.Add("Точка");
            _figures.Add("Линия"); 
            _figures.Add("Прямоугольник");
            _figures.Add("Эллипс");
            comboBoxFigure.DataSource = _figures;
        }

        private void ButtonCreateObj_Click(object sender, EventArgs e)
        {
            if (ValidateInput(textBoxCoordinate.Text) && comboBoxFigure.SelectedItem == "Точка")
            {
                Shape newShape = null;
                int[] coordinate = ConvertToParams(textBoxCoordinate.Text);
                newShape = new PointShape(coordinate[0], coordinate[1]);

                if (newShape != null)
                {
                    // Вызов события для передачи созданного объекта Shape
                    ShapeCreated?.Invoke(newShape);
                    this.Close();
                }
            }
            else if (ValidateInput(textBoxCoordinate.Text) && ValidateInput(textBoxWeight.Text) && comboBoxFigure.SelectedIndex != -1)
            {
                Shape newShape = null;
                string selectedFigure = comboBoxFigure.SelectedItem.ToString();
                int[] size = ConvertToParams(textBoxWeight.Text);
                int[] coordinate = ConvertToParams(textBoxCoordinate.Text);
                switch (selectedFigure)
                {
                    //case "Точка":
                        //newShape = new PointShape(coordinate[0], coordinate[1], size[0], size[1]);
                        //break;
                    case "Линия":
                        newShape = new LineShape(coordinate[0], coordinate[1], size[0], size[1]);
                        break;
                    case "Прямоугольник":
                        newShape = new RectangleShape(coordinate[0], coordinate[1], size[0], size[1]);
                        break;
                    case "Эллипс":
                        newShape = new EllipseShape(coordinate[0], coordinate[1], size[0], size[1]);
                        break;
                    default:
                        break;
                }

                if (newShape != null)
                {
                    // Вызов события для передачи созданного объекта Shape
                    ShapeCreated?.Invoke(newShape);
                    this.Close();
                }
            }
            else MessageBox.Show("Некорректным образом ввидены координаты и/или размеры объекта и/или не выбран объект. Повторите попытку", "Не удалось создать объект", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
        }

        private bool ValidateInput(string input)
        {
            string[] parts = input.Split(';');
            if (parts.Length != 2) return false;
            if (!int.TryParse(parts[0], out _) || !int.TryParse(parts[1], out _)) return false;
            return true;
        }

        private int[] ConvertToParams(string input)
        {
            string[] parts = input.Split(';');
            int number1 = int.Parse(parts[0]);
            int number2 = int.Parse(parts[1]);
            return new int[] { number1, number2};
        }
    }
}
