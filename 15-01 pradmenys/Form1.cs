using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_01_pradmenys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Labas");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void buttonGautiReiksme_Click(object sender, EventArgs e)
        {
            var reiksme = textBoxReiksme.Text;
                labelReiksme.Text = reiksme;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

       

        private void labelsuma_Click(object sender, EventArgs e)
        {
            var suma = Convert.ToInt32(pirmasskaicius.Text) + Convert.ToInt32(skaicius2.Text);
            //Convert.ToInt32(labelsuma.Text) = suma;
        }

        private void buttonskaiciuoti_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var forma = new InformacijosLangas();
            forma.ShowDialog(); //parodo  informacijos langas 
        }

        private void buttonsiusti_Click(object sender, EventArgs e)
        {

            var reiksme = textBoxSiusti.Text;
            var forma = new SkaiciavimuForma(reiksme);
            forma.ShowDialog();
        }

        private void buttonsiusti2_Click(object sender, EventArgs e)
        {
            using (var forma = new IvedimoForma())
            {
                forma.ShowDialog();

                if (forma.DialogResult == DialogResult.OK)
                {
                    var zodis = forma.Zodis;
                    labelIvedimas.Text = zodis;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
