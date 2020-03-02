using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopScore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "GO!") button2.Text = "STOP";
            else button2.Text = "GO!";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            int _tempo = Convert.ToInt32(tempo.Text);
            _tempo--;
            tempo.Text = _tempo.ToString();
        }
    }
}
