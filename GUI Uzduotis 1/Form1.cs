using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Uzduotis_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var krastine = Convert.ToDouble(textBoxkrastine.Text);
            var aukstine = Convert.ToDouble(textBoxaukstine.Text);


            var suma =  (double)(krastine * aukstine)/2;
            textBoxplotas.Text = Convert.ToString(suma);
        }

        private void textBoxplotas_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
