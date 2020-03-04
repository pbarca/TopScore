using System;
using System.Drawing;
using System.Windows.Forms;

namespace TopScore
{
    class ClickMe
    {
        private bool _start = true;

        public bool Start => _start;
        public void Move(object sender)
        {
            Random _r = new Random();
            int _x = int.Parse(_r.Next(500).ToString());
            int _y = int.Parse(_r.Next(250).ToString()) + 100;
            Point _pt = new Point(_x, _y);
            Button _b = (Button)sender;
            _b.Location = _pt;
        }
        public bool Tempo(object sender)
        {
            TextBox _t = (TextBox)sender;
            int _tempo = Convert.ToInt32(_t.Text);
            if (_tempo > 0)
            {
                _tempo--;
                _t.Text = _tempo.ToString();
                return false;
            }
            else return true;
        }
    }
}
