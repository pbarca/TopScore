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
            record.Text = Classe.Abrir;
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
            Classe.Record(pontos,record);
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
            Classe.Pontos(pontos);
            Classe.Move(sender);
        }
    }
}
