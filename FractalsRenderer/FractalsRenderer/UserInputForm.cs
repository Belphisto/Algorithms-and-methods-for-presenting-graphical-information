using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractalsRenderer
{
    public partial class UserInputForm : Form
    {
        private int _angle;
        private int _lenght;
        private int _depth;
        private Color _color;

        public event Action<int> UpdateAngle;
        public event Action<int> UpdateLenght;
        public event Action<int> UpdateDepth;
        public event Action<Color> UpdateColor;

        public UserInputForm(int angle, int lenght, int depth, Color color)
        {
            InitializeComponent();
            _angle = angle;
            _lenght = lenght;
            _depth = depth;
            _color = color;
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                // Получаем выбранный цвет
                _color = colorDialog1.Color;

                // Теперь переменная selectedColor содержит выбранный цвет
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            UpdateAngle?.Invoke(_angle);
            UpdateLenght?.Invoke(_lenght);
            UpdateDepth?.Invoke(_depth);
            UpdateColor?.Invoke(_color);

            this.Close();
        }

        private void AngleTrackBar_Scroll(object sender, EventArgs e)
        {
            labelAngle.Text = AngleTrackBar.Value.ToString();
            _angle = AngleTrackBar.Value;
        }

        private void LenghtTrackBar_Scroll(object sender, EventArgs e)
        {
            labelLenght.Text = LenghtTrackBar.Value.ToString();
            _lenght = LenghtTrackBar.Value;
        }

        private void DepthTrackBar_Scroll(object sender, EventArgs e)
        {
            labelDepth.Text = DepthTrackBar.Value.ToString();
            _depth = DepthTrackBar.Value;
        }
    }
}
