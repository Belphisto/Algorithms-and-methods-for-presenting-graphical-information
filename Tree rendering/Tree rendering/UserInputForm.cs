using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tree_rendering
{
    public partial class UserInputForm : Form
    {
        private int _rainfall;
        private int _windF;
        private int _temp;
        private Color _color;

        public event Action<int> UpdateTemp;
        public event Action<int> UpdateRainfall;
        public event Action<int> UpdateWindF;
        public event Action<Color> UpdateColor;

        public UserInputForm(int rainfall, int wind, int temp, Color color)
        {
            InitializeComponent();
            _rainfall = rainfall;
            _windF = wind;
            _temp = temp;
            _color = color;
        }

        private void UserInputForm_Load(object sender, EventArgs e)
        {
            labelRainfall2.Text = _rainfall.ToString();
            labelTemp2.Text = _temp.ToString();
            labelWindF.Text = _windF.ToString();

            trackBarRainfall.Value = _rainfall;
            trackBarTemp.Value = _temp;
            trackBarWindF.Value = _windF;
        }

        private void SetColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                _color = colorDialog1.Color;
        }

        private void trackBarRainfall_Scroll(object sender, EventArgs e)
        {
            labelRainfall2.Text = trackBarRainfall.Value.ToString();
            _rainfall = trackBarRainfall.Value;
        }

        private void trackBarTemp_Scroll(object sender, EventArgs e)
        {
            labelTemp2.Text = trackBarTemp.Value.ToString();
            _temp = trackBarTemp.Value;
        }

        private void trackBarWindF_Scroll(object sender, EventArgs e)
        {
            labelWindF.Text = trackBarWindF.Value.ToString();
            _windF = trackBarWindF.Value;
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            UpdateTemp?.Invoke(_temp);
            UpdateRainfall?.Invoke(_rainfall);
            UpdateWindF?.Invoke(_windF);
            UpdateColor?.Invoke(_color);

            this.Close();
        }
    }
}
