using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Uzduotis_2
{
    public partial class Skaiciavimai : Form
    {
        

        public Skaiciavimai(List<Telefonas> Telefonai)
        {
            InitializeComponent();
            textBox1.Text = Seniausias(Telefonai).Metai.ToString();
        }

        public Telefonas Seniausias(List<Telefonas> telefonai)
        {
            var seniausias = telefonai.First();
            foreach (var tel in telefonai)
            {
                seniausias = tel;
            }
            return seniausias;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
