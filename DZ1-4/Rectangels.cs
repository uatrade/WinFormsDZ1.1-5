using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Разработать приложение, созданное на основе форме.
//■■ Пользователь «щелкает» левой кнопкой мыши по форме и,
//не отпуская кнопку, ведет по ней мышку, а в момент отпу-
//скания кнопки по полученным координатам прямоуголь-
//ника(вам, конечно, известно, что двух точек на плоскости
//достаточно для создания прямоугольника) необходимо со-
//здать «статик», который содержит свой порядковый номер
//(имеется в виду порядок появления на форме).
//■■ Минимальный размер «статика» составляет 10х10, при по-
//пытке создания элемента меньших размеров пользователь
//должен увидеть соответствующее предупреждение.
//■■ При щелчке правой кнопкой мыши над поверхностью
//«статика» в заголовке окна должна появиться информа-
//ция о его площади и координатах (относительно формы).
//В случае, если в точке щелчка находится несколько «ста-
//тиков», то предпочтение отдается «статику» с наибольшим
//порядковым номером.
//■■ При двойном щелчке левой кнопки мыши над поверхно-
//стью «статика» он должен исчезнуть с формы.В случае,
//если в точке щелчка находится несколько «статиков», то
//предпочтение отдается «статику» с наименьшим порядко-
//вым номером.

namespace DZ1_4
{
    public partial class Rectangels : Form
    {
        private Label m_label;
        Point first, second;
        List<Label> MyLable=new List<Label>();
        int count = 0;

        public Rectangels()
        {
            InitializeComponent();
            this.MouseMove += Form1_MouseMove; ;
            this.MouseUp += Form1_MouseUp;
            this.MouseDown += Form1_MouseDown;
            this.MouseDoubleClick += Form1_MouseDoubleClick;
        }
        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
                CheckStatickForDel(e);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            first = e.Location;


            if (e.Button == MouseButtons.Right)
            {
                CheckStatickForInfo(e);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            second = e.Location;

            if (e.Button == MouseButtons.Left)
            {
                m_label = new Label();
                m_label.Location = new Point(first.X, first.Y);
                m_label.Size = new Size(second.X - first.X, second.Y - first.Y);

                m_label.BackColor = Color.Transparent;
                m_label.Enabled = false;
                m_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

                if ((second.X - first.X) >= 10 && (second.Y - first.Y) >=10)
                {
                    m_label = new Label();
                    m_label.Location = new Point(first.X, first.Y);
                    m_label.Size = new Size(second.X - first.X, second.Y - first.Y);

                    m_label.BackColor = Color.Transparent;
                    m_label.Enabled = false;
                    m_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    count++;
                    m_label.Text = count.ToString();

                    MyLable.Add(m_label);
                    m_label.Text = count.ToString();
                    this.Controls.Add(m_label);
                    m_label.BringToFront();
                }
                if((second.X - first.X)!=0&& (second.X - first.X)<10&&(second.Y - first.Y)!=0&& (second.X - first.X)<10)
                {
                    MessageBox.Show("Статик меньше 10x10", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
           this.Text="X="+" "+e.X.ToString()+" "+"Y="+" "+e.Y.ToString();
        }

        private void CheckStatickForInfo(MouseEventArgs e)
        {
            if (MyLable.Count > 0)
            {
                for(int i=MyLable.Count-1; i>=0; i--)
                {
                    if(IsClickOnStatic(e, MyLable[i]) == true)
                    {
                        this.Text = "Ширина =" + " " + MyLable[i].Width + " " + "Высота= "+" " + MyLable[i].Height;
                        return;
                    }
                }
            }
        }

        private void CheckStatickForDel(MouseEventArgs e)
        {
            if (MyLable.Count > 0)
            {
                for (int i = 0; i < MyLable.Count; i++)
                {
                    if (IsClickOnStatic(e, MyLable[i]) == true)
                    {
                        this.Controls.Remove(MyLable[i]);
                        MyLable.RemoveAt(i);
                        return;
                    }
                }
            }          
        }

        private bool IsClickOnStatic(MouseEventArgs e, Label label)
        {
            if (e.X >= label.Left && e.X <= label.Right && e.Y >= label.Top && e.Y <= label.Bottom)
                return true;
            else
                return false;
        }
    }
}
