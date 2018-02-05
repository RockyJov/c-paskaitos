using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GUI_Uzduotis_3_savarankiska_
{
    public partial class Form1 : Form
    {
        public Pasaulis Pasaulis { get; private set; } = new Pasaulis(); 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void atidarytiToolStripMenuItem_Click(object sender, EventArgs e) // atidaryti mygtukas
        {
            using (var failoPasirinkimas = new OpenFileDialog())
            {
                failoPasirinkimas.Filter = "csv failai (*csv)|*csv";
                failoPasirinkimas.Multiselect = true;

                if (failoPasirinkimas.ShowDialog() == DialogResult.OK)
                {
                    foreach (var failai in failoPasirinkimas.FileNames)
                    {
                        var salis = new Salis(failai);
                        Pasaulis.Saliu_sarasas.Add(salis);

                        var skirtukas = new TabPage(String.Format("Salis: {0}, Zemynas: {1}", salis.Pavadinimas, salis.Zemynas));
                        tabControl1.Controls.Add(skirtukas);

                        skirtukas.Controls.Add(new DataGridView()
                        {
                            Dock = DockStyle.Fill,
                            DataSource = Pasaulis.Saliu_sarasas.Last().Miestu_sarasas
                        });

                    }
                }
            }
            skaiciavimaiToolStripMenuItem.Enabled = true;
        }

        private void skaiciavimaiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var forma = new Skaiciavimai();
            forma.ShowDialog(); //parodo  Skaiciavimu langa

        }

        private void baigtiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }// klases form1 pabaiga
}
