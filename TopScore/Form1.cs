using System;
using System.Drawing;
using System.Windows.Forms;

namespace TopScore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            clickme.Visible = false;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Start()
        {
            button2.Text = "STOP";
            tempo.Text = "10";
            clickme.Visible = true;
            timer1.Start();
            pontos.Text = "0";
        }

        private void Stop()
        {
            button2.Text = "GO!";
            clickme.Visible = false;
            timer1.Stop();
            if (Convert.ToInt32(record.Text) < Convert.ToInt32(pontos.Text))
                record.Text = pontos.Text;
        }

        private void Mover()
        {
            Random x = new Random();
            Point pt = new Point(int.Parse(x.Next(500).ToString()), int.Parse(x.Next(250).ToString()) + 100);
            clickme.Location = pt;
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "GO!") Start(); else Stop();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            int _tempo = Convert.ToInt32(tempo.Text);
            if (_tempo < 1) Stop();
            else
            {
                _tempo--;
                Mover();
            }
            tempo.Text = _tempo.ToString();
        }

        private void clickme_Click(object sender, EventArgs e)
        {
            pontos.Text = (Convert.ToInt32(pontos.Text) +1).ToString();
            Mover();
        }
    }
}
