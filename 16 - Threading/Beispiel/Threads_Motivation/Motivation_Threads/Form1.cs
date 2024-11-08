using System;
using System.Windows.Forms;

namespace Motivation
{
    public partial class Form1 : Form
    {
        private bool abbrechen = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLos_Click(object sender, EventArgs e)
        {
            labelAusgabe.Text = "Berechne...";

            Berechne();

            labelAusgabe.Text = "Bin fertig!";
        }

        private void Berechne()
        {
            for (int i = 0; i < 10_000 && abbrechen == false; i++)
            {
                for (int j = 0; j < 10_000 && abbrechen == false; j++)
                {
                    for (int k = 0; k < 10_000 && abbrechen == false; k++)
                    {
                        Math.Sqrt(i * j * k + 1);
                    }
                }
            }
        }

        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            abbrechen = true;
            labelAusgabe.Text = "Es reicht...!";
        }
    }
}