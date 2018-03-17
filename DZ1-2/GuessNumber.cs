using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Задание 2
//Написать функцию, которая «угадывает» задуманное пользова-
//телем число от 1 до 2000. Для запроса к пользователю использовать
//MessageBox.После того, как число отгадано, необходимо вывести
//количество запросов, потребовавшихся для этого, и предоставить
//пользователю возможность сыграть еще раз, не выходя из программы
//(MessageBox’ы оформляются кнопками и значками соответственно
//ситуации).
namespace DZ1_2
{
    public partial class GuessNumber : Form
    {
        Random rnd;
        int value, num=0;
        DialogResult result;

        public GuessNumber()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.Fon_DZ;
            rnd = new Random();
        }

        private void StartProg_Click(object sender, EventArgs e)
        {
            do
            {
                value = rnd.Next(1, 2000);
                result=MessageBox.Show(value.ToString(), "Угадай число", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                
                if(result== System.Windows.Forms.DialogResult.Yes)
                {
                    num++;
                    MessageBox.Show($"Ты угадал из {num} попыток", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    num = 0;
                }
                if (result == System.Windows.Forms.DialogResult.No)
                {
                    num++;
                    MessageBox.Show($"Ты не угадал", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } while (result != System.Windows.Forms.DialogResult.Cancel);

            Application.Exit();
        }

        private void FinishProg_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
