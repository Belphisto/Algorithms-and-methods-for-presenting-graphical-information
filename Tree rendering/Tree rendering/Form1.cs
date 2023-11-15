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
    public partial class Form1 : Form
    {
        private int _rainfall=10;
        private int _windF=10;
        private int _temp=10;
        private bool _flag = true;
        private Color _colorBranch;
        Tree tree ;

        public Form1()
        {
            InitializeComponent();
            SetProgressBar();
            tree = new Tree(pictureBox1);
        }

        private void HelpToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задача «Дерево». Отобразить изменение высоты дерева и его"+
            "ветвей в зависимости от погоды.Параметры погоды" +
            "(интенсивность ветра и осадков, температура воздуха) задаются" +
            "пользователем.При благоприятной погоде длина ветви" +
            "увеличится в 2 раза. Изначально дерево имеет ствол и три"+
            "ветви.Место появления новых веток на дереве выбирается"+
            "произвольно.", "Формулировка задачи");
        }

        private void UserInputToolStripButton_Click(object sender, EventArgs e)
        {
            UserInputForm childForm = new UserInputForm(_rainfall, _windF, _temp, _colorBranch);
            childForm.UpdateColor += (newColor) => _colorBranch = newColor;
            childForm.UpdateTemp += (newTemp) => _temp = newTemp;
            childForm.UpdateRainfall += (newRain) => _rainfall = newRain;
            childForm.UpdateWindF += (newWindF) => _windF = newWindF;
            childForm.ShowDialog(this);
            SetProgressBar();

            Crown.IsOutOfHeight += (flag) => _flag = flag;
            if (_flag)
            {
                if (IsWeatherFavorable())
                {
                    tree.CreateBrunch(3);
                    tree.UpTree();
                }
                else
                {
                    tree.CreateBrunch(1);
                }
                tree.DrawTrunk(pictureBox1, Color.Brown);
            }
            else
            {
                UserInputToolStripButton.Enabled = false;
                MessageBox.Show("Поздравляем, вы отлично заботились о дереве и оно достигло максимального размера" +
                    "чтобы начать сначала, нажмите \"очистить холст и нарисуйте дерево заново\"", "Дерево выросло!");
            }
            
        }

        private void SetProgressBar()
        {
            RainfallProgressBar.Value = _rainfall;
            WindFProgressBar.Value = _windF;
            TempProgressBar.Value = _temp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public bool IsWeatherFavorable()
        {
            bool favorableRainfall = (_rainfall <= 80) && (40 <=_rainfall);
            bool favorableWind = (_windF <= 10);
            bool favorableTemp = (_temp <= 30) && (0<=_temp);
            return favorableRainfall && favorableWind && favorableTemp;
        }

        private void ResetToolStripButton_Click(object sender, EventArgs e)
        {
            tree.DrawTrunk(pictureBox1, Color.Brown);
        }

        private void ClearToolStripButton1_Click(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
            _flag = true;
            UserInputToolStripButton.Enabled = true;
            tree = new Tree(pictureBox1);
        }
    }
}
