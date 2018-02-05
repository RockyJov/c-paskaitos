using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garazas
{
    class Automobilis
    {

        public string Modelis { get; private set; }
        public string Marke { get; private set; }
        public int Metai { get; private set; }
        public int Rida { get; private set; }
        public int GaliaKw { get; private set; }
        public double Turis { get; private set; }
        public string Spalva { get; private set; }

        public Automobilis(string modelis, string marke, int metai, int rida, int galiakw, double turis, string spalva)
        {
            Modelis = modelis;
            Marke = marke;
            Metai = metai;
            Rida = rida;
            GaliaKw = galiakw;
            Turis = turis;
            Spalva = spalva;
        }
        public void Isvedimas()
        {
            Console.WriteLine("Auto: {0}, Marke {1}, metai: {2}, rida: {3}, galia kilovatais: {4}, darbinis turis: {5}, spalva: {6}", Modelis, Marke, Metai, Rida, GaliaKw, Turis, Spalva);
        }

        //nauji metodai:
        //atsukti rida
        public void Atsukti()
        {
            Console.WriteLine("Kiek norite atsukti rida?");
            var atsukti = Convert.ToInt32(Console.ReadLine());
            Rida = Rida - atsukti;
            Console.WriteLine("Nauja rida: " + Rida);
        }
        //perdazyti
        public void Perdazyti()
        {
            Console.WriteLine("Kokia spalva norite perdazyti?");
            var perdazyti = Console.ReadLine();
            Spalva = perdazyti;
            Console.WriteLine("Nauja spalva: " + Spalva);
        }
        //pakelti galia
        public void PakeltiGalia()
        {
            Console.WriteLine("Pakelkite galia. Nauja galia: ");
            var pakeltigalia = Convert.ToInt32(Console.ReadLine());
            GaliaKw = GaliaKw + pakeltigalia;
            Console.WriteLine("Nauja galia: " + GaliaKw);
        }
    }
}
