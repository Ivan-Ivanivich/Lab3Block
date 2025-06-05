using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateBlank(pictureBox1.Width, pictureBox1.Height);
        }
        //цвет заливки по умолчанию 
        Color DefaultColor
        {
            get { return Color.White; } //Aqua
        }

        //создаем пустую облость рисования 
        void CreateBlank(int width, int height)
        {
            //сохраняем старую картинку 
            var oldImage = pictureBox1.Image;
            //созжаем новый битмап
            var bmp = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            //производим пиксельное закрашивание 
            //битмап обычный двухмерный массив точек поэтому проходим его за 2 цикла:
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    bmp.SetPixel(i, j, DefaultColor);
                }
            }

            pictureBox1.Image = bmp;
            if (oldImage != null)
            {
                oldImage.Dispose();// освобождаем ресурсы занятые старой картинкой
            }
        }

        //найти ошибки не рисует 
        int _x;
        int _y;
        bool _mouseClicked = false;
        Color SelectedColor
        { 
            get { return Color.Red; }
        }
        int SelectedSize
        {
            get { return sizeTrackBar.Value; } //изменено trackBar1
        }
        Brush _selectedBrush;

        //_selectedBrush = new QuadBrush(SelectedColor, SelectedSize);
        private void button1_Click(object sender, EventArgs e) //Button1
        {
            _selectedBrush = new QuadBrush(SelectedColor, SelectedSize);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (_selectedBrush == null) { return; }

            _selectedBrush.Draw(pictureBox1.Image as Bitmap, _x, _y);
            pictureBox1.Refresh();

            _mouseClicked = true;   
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        { 
            _mouseClicked = false ;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        { 
            _x = e.X > 0 ? e.X : 0;
            _y = e.Y > 0 ? e.Y : 0;
            if (_mouseClicked)
            {
                _selectedBrush.Draw(pictureBox1.Image as Bitmap, _x, _y);
                pictureBox1.Refresh();
            }
        }
    }
}


