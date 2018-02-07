using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Uzduotis_3_savarankiska_
{
    public partial class Skaiciavimai : Form
    {

        public Pasaulis Pasaulis { get; private set; } = new Pasaulis();// sukuriu Pasaulio objekta is Pasaulio klasei panaudot
        public Skaiciavimai()
        {
            InitializeComponent();
            DaugiausiaiGyv.Text = Pasaulis.Daugiausiai_gyventoju().Gyventoju_Skaicius.ToString();

            InitializeComponent();
            MaziausiaiGyv.Text = Pasaulis.Maziausiai_Gyventoju().Gyventoju_Skaicius.ToString();

            InitializeComponent();
            MaziausiasPL.Text = Pasaulis.Maziausias_Miestas().Gyventoju_Skaicius.ToString();



        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
