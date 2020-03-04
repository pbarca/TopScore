using System;
using System.Drawing;
using System.Windows.Forms;

namespace TopScore
{
    class ClickMe
    {
        private int _tempo;
        public void Mover(Button sender)
        {
            Random x = new Random();
            Point pt = new Point(int.Parse(x.Next(500).ToString()), int.Parse(x.Next(250).ToString()) + 100);
            sender.Location = pt;
        }
        public string Tempo()
        {
            return _tempo.ToString();
        }
    }
}
