using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Разработать приложение «убегающий статик»:) Суть приложения:
//на форме расположен статический элемент управления(«статик»).
//Пользователь пытается подвести курсор мыши к «статику», и, если
//курсор находиться близко со статиком, элемент управления «убега-
//ет». Предусмотреть перемещение «статика» только в пределах формы.

namespace DZ1_5
{
    public partial class RunStatic : Form
    {
        Point first, second;
        Label mylabel;
        Random rnd;
        public RunStatic()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.Fon_DZ;
           // this.BackgroundImageLayout= System.Windows.Forms.

            this.BackgroundImageLayout = ImageLayout.Stretch;

            MouseMove += Form1_MouseMove;
            mylabel = new Label();
            mylabel.Size = new Size(50, 50);
            mylabel.BackColor = Color.Transparent;
            mylabel.Image = Properties.Resources.Smile;
            mylabel.Location = new Point(50, 50);
            this.Controls.Add(mylabel);
            rnd = new Random();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"X= {e.X}  Y= {e.Y}";
            if (IsClickOnStatic(e, mylabel) == true)
           // mylabel.Location = new Point(e.X + 10, e.Y + 10);
            mylabel.Location = new Point(rnd.Next(5, this.ClientSize.Width - 52), rnd.Next(5, this.ClientSize.Height - 52));
        }

        private bool IsClickOnStatic(MouseEventArgs e, Label label)
        {
            if (e.X >= label.Left-5 && e.X <= label.Right+52 && e.Y >= label.Top-5 && e.Y <= label.Bottom+52)
                return true;
            else
                return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
