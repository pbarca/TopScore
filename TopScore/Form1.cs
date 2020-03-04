using System;
using System.Windows.Forms;

namespace TopScore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            clickme.Visible = false;
            timer1.Interval = 1000;
        }

        private ClickMe Classe = new ClickMe();
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

        private void Button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "GO!") Start(); else Stop();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (Classe.Tempo(tempo)) Stop();
        }

        private void clickme_Click(object sender, EventArgs e)
        {
            pontos.Text = (Convert.ToInt32(pontos.Text) + 1).ToString();
            Classe.Move(sender);
        }
    }
}
