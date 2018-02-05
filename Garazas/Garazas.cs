using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garazas
{
    class Garazas
    {
        public string Pavadinimas { get; private set; }
        public string Adresas { get; private set; }
        public int Meistru_Skaicius { get; private set; }
        public List<Automobilis> Automobiliai { get; private set; }

        public Garazas(string pavadinimas, string adresas, int meistru_skaicius, List<Automobilis> automobiliai)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            Meistru_Skaicius = meistru_skaicius;
            Automobiliai = automobiliai;

        }

        public void Isvedimas()
        {
            Console.WriteLine("Garazas: {0} randasi adresu {1}, jame dirba {2} meistrai", Pavadinimas, Adresas, Meistru_Skaicius);

            Console.WriteLine("Remontuojami auto: ");
            for (int i = 0; i < Automobiliai.Count; i++)
            {
                Console.WriteLine(i + 1 + "Auto: ");
                Automobiliai[i].Isvedimas();
            }
        }

        public void AtnaujintiPasirinkti()
        {
            Console.WriteLine("Kuri automobili atnaujinti? Iveskite skaiciu.");
            var kuris = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pasirinktas automobilis: ");
            Automobiliai[kuris - 1].Isvedimas();

            Console.WriteLine("1 - atsukti rida");
            Console.WriteLine("2 - perdazyti");
            Console.WriteLine("3 - padidinti galia");
            var pasirinkimas = Convert.ToInt32(Console.ReadLine());

            switch (pasirinkimas)
            {
                case 1:
                    Automobiliai[kuris - 1].Atsukti();
                    break;
                case 2:
                    Automobiliai[kuris - 1].Perdazyti();
                    break;
                case 3:
                    Automobiliai[kuris - 1].PakeltiGalia();
                    break;

            }
        }

        public void Skaiciavimai()
        {
            Console.WriteLine("Skaiciavimai.");
            Console.WriteLine("Bendra rida " + Totalrida());
            Console.WriteLine("Didziausia " + Didziausia());
        }
        public int Totalrida()
        {
            var sum = 0;
            //cia skaiciuoti
            foreach (var auto in Automobiliai)
            {
                sum += auto.Rida;
            }

            return sum;
        }
        public Automobilis Didziausia()
        {
            var didziausia = Automobiliai.First();

            return didziausia;
        }
    }//garazas pabaiga

}



