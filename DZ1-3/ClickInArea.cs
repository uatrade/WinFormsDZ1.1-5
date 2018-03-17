using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Представьте, что у вас на форме есть прямоугольник, границы ко-
//торого на 10 пикселей отстоят от границ рабочей области формы.Не-
//обходимо создать следующие обработчики:
//■■ Обработчик нажатия левой кнопки мыши, который выво-
//дит сообщение о том, где находится текущая точка: вну-
//три прямоугольника, снаружи, на границе прямоугольника.
//    Если при нажатии левой кнопки мыши была нажата кнопка
//Control (Ctrl), то приложение должно закрываться;
//■■ Обработчик нажатия правой кнопки мыши, который вы-
//водит в заголовок окна информацию о размере клиентской
//(рабочей) области окна в виде: Ширина = x, Высота = y, где
//x и y – соответствующие параметры вышего окна;
//■■ Обработчик перемещения указателя мыши в пределах ра-
//бочей области, который должен выводить в заголовок окна
//текущие координаты мыши x и y.

namespace DZ1_3
{
    public partial class ClickInArea : Form
    {
        bool CntrlKey = false;
        public ClickInArea()
        {
            InitializeComponent();
            this.MouseMove += Form1_MouseMove;
            this.MouseClick += Form1_MouseClick;
            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control)
            CntrlKey = true;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if(CntrlKey)
                    Application.Exit();     //выход из приложения


                if (e.X < 10 || e.Y < 10 || e.X > this.ClientSize.Width - 10 || e.Y > this.ClientSize.Height - 10)

                    MessageBox.Show($"За областью");
                if (e.X == 10 || e.Y == 10 || e.X == this.ClientSize.Width - 10 || e.Y == this.ClientSize.Height - 10)

                    MessageBox.Show($"На границе");
                else
                    MessageBox.Show($"Внутри области");
            }
            if (e.Button == MouseButtons.Right)
            {
                    this.Text = $"Ширина = {this.ClientSize.Width} Высота {this.ClientSize.Height}";
                System.Threading.Thread.Sleep(2000);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text= $"Координаты мыши: х=" + e.X.ToString() + "; y=" +
           e.Y.ToString();
        }
    }
}
