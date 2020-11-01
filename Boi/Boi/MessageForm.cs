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
    public partial class MessageForm : Form
    {
        private string Message;
        public MessageForm(string message)
        {
            InitializeComponent();
            Message = message;
            Location = GenerateRandomPosition();
            TypeMesssage();
        }

        private Point GenerateRandomPosition()
        {
            Random Rand = new Random();
            var WorkArea = Screen.PrimaryScreen.WorkingArea;
            int x = Rand.Next(WorkArea.Width / 2);
            int y = Rand.Next(WorkArea.Height / 2);
            return new Point(x, y);
        }

        private async void TypeMesssage()
        {
            for (int i = 0; i < Message.Length; i++, await Task.Delay(20))
            {
                label1.Text += Message[i];
            }
            await Task.Delay(4000);
            Close();
        }

        private void MessageForm_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = BackColor;
        }
    }
}
