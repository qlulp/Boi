using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boi
{
    public partial class PussyDestroyer : Form
    {
        Rectangle WorkArea;
        Random Rand;
        bool IsTriggered = false;
        private int CountOfAttempts = 0;

        string[] Values =
        {
            "Нормальный человек не просыпается с мыслью о том, что сегодня последний день в его жизни. Но я считаю, что это роскошь, не проклятие. Знание, что смерть близка, даёт свободу.",
            "Press F to escape",
            "Чтобы изменить мир, нужна красивая ложь и море крови.",
            "Конечно, важно, у кого самая большая дубина. Но не менее важно, кто ей размахивает.",
            "Что-то меняется, что-то остаётся прежним. Границы меняются, приходят новые игроки, но власть всегда находит себе место.",
            "Одна пуля становится причиной ярости целого государства.",
            "Месть подобна призраку: она завладевает каждым, кого касается. И её жажда не утихнет, пока последний враг не падёт.",
            "Я считаю, что знать что ты завтра умрёшь — роскошь, не проклятье. Знание того что смерть близка даёт свободу…",
            "Если ты собираешься драться, то и я ударю в ответ.",
            "Пять лет назад я за какие-то секунды потерял 30 тысяч человек. А этот дерьмовый мир просто наблюдал.",
            "Возможно, вы убьёте меня, но однажды зверь придёт и за вами.",
            "Месть на мне. И я отомщу."
        };
        public PussyDestroyer()
        {
            InitializeComponent();
            Rand = new Random();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = BackColor;
            WorkArea = Screen.PrimaryScreen.WorkingArea;
            SetRandomPositionOnScreen();
        }

        private void SetRandomPositionOnScreen()
        {
            int x = Rand.Next(0, WorkArea.Width - this.Size.Width / 2);
            int y = WorkArea.Bottom - this.Size.Height;
            Location = new Point(x, y);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SetRandomPositionOnScreen();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            CountOfAttempts++;
            SetRandomPositionOnScreen();
            if (CountOfAttempts % 5 == 0)
            {
                int index = Rand.Next(0, Values.Length);
                MessageForm message = new MessageForm(Values[index]);
                message.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!IsTriggered)
            {
                IsTriggered = true;
                pictureBox1.Image = Properties.Resources.angry;
            }
            else
            {
                // MessageForm a = new MessageForm("", Mouth.Location);
                for (int i = 0; i < 30; i++)
                {
                    PussyDestroyer a = new PussyDestroyer();
                    a.Show();
                }
            }
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Show();
            }
        }
    }
}
