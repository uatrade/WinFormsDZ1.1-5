using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Задание 1
//Вывести на экран свое(краткое!!!) резюме с помощью последова-
//тельности MessageBox’ов(числом не менее трех). Причем на заголовке
//последнего должно отобразиться среднее число символов на странице
//(общее количество символов в резюме / количество MessageBox’ов).

namespace TestApp2
{
    public partial class Average : Form
    {
        string firstname;
        string secondname;
        string result;
        public Average()
        {
            InitializeComponent();
            firstname = "Oleksandr";
            secondname = "Piskovtsev";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            result = ((firstname.Length + secondname.Length) / 2).ToString();         
        }

        private void StartDZ_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Имя", firstname, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            MessageBox.Show("Фамилия", secondname, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            MessageBox.Show("Результат:", "Среднее число символов на странице = " + result, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void FinishDZ_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
