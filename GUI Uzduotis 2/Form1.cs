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
    public partial class Form1 : Form
    {
        public List<Telefonas> Telefonai { get; private set; }

        public Form1()
        {
            InitializeComponent();
            Telefonai = new List<Telefonas>();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void baigtiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nuskaitytiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var failoPasirinkimolangas = new OpenFileDialog())
            {
                failoPasirinkimolangas.Filter = "cvs failai(*.csv)|*.csv"; // prafiltruojam failus
                failoPasirinkimolangas.ShowDialog();

                if (failoPasirinkimolangas.ShowDialog() == DialogResult.OK)
                {
                    //MessageBox.Show(failoPasirinkimolangas.FileName);

                    // nuskaitinejimas

                    using (var skaitytuvas = new System.IO.StreamReader(failoPasirinkimolangas.FileName))
                    {
                        string eilute;
                        var eil = 0;
                        while ((eilute = skaitytuvas.ReadLine()) != null)
                        {
                            //MessageBox.Show(eilute);

                            if (eil == 0)
                            {
                                eil++;
                                continue;
                            }
                            else
                                eil++;

                            var telefonas = new Telefonas(eilute);
                            Telefonai.Add(telefonas);

                        }
                        dataGridView1.DataSource = Telefonai;


                    }
                }
            }
        }
    }
}




